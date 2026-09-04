# DiGi.Core#4 — Investigation Results & Implementation Plan

> Status: **Still valid — with narrowed scope.** Every code excerpt in the issue was verified against the current tree on 2026-09-04. Two findings change the original proposal (see §2.2 and §2.3).

---

## 1. Verdict

| Action item | Verdict |
|---|---|
| A1 · Audit & benchmark all `IEnumerable` implementations | **Done in this investigation** (full matrix in §2.4). Only `Table` and the `Cluster` base fallback are non-streaming. |
| A2 · Optimize `Cluster` base enumeration | **Partially valid.** `List<...>` and `ValueCluster<...>` already stream; the base `GetEnumerator()` cannot be improved (it has no storage). The base `GetKeys_1()` / `GetKeys_2()` / `GetValues(...)` *can* be re-pointed at `this`. Low impact — nothing in the ecosystem reaches these fallbacks. |
| A3 · Optimize `Table` enumeration | **Fully valid — the real win.** `TablePostgreSQLConverter` (primary table→PostgreSQL write path) pays an N-row deep clone per write. Fix must be scoped to `GetEnumerator()` only: the clone semantics of `Rows` are pinned by a committed test. |
| A4 · Automatic tests | **Valid.** New facts required, per the reproduce-before-fixing and benchmark-isolation rules. |

---

## 2. Verification against the code (issue premises checked)

### 2.1 `Cluster` base — issue claims confirmed, impact re-scoped

- `DiGi.Core/Classes/Cluster/Cluster.cs:128` — base `GetEnumerator()` materializes via `GetValues<TValue>()`. **Confirmed.**
- `DiGi.Core/Classes/Cluster/ListCluster.cs:217` (`List<TKey_1, TKey_2, TValue>`) and `DiGi.Core/Classes/Cluster/ValueCluster.cs:153` both **override** `GetEnumerator()` with streaming generators. **Confirmed.**
- Base `GetKeys_1()` (Cluster.cs:156), `GetKeys_2()` (Cluster.cs:186), `GetValues<UValue>(key_1)`, `GetValues<UValue>(func)` all call the abstract `GetValues<TValue>()`, which allocates a fresh `List`. **Confirmed.**
- **New finding (scope reduction):** a repo-wide grep of the whole DiGiProject shows **no concrete cluster derives directly from the abstract `Cluster<TKey_1, TKey_2, TValue>`** — `dg_dfl/DelimitedFileRow`, `DiGi.GIS/IndexDataFile`, `DiGi.YOLO/BoundingBoxResultFile`, `DiGi.Test/DiGi.Core.xUnit/Classes/TestListCluster.cs` all derive from `List<...>` or `ValueCluster<...>` (the other two `List<...>` hits are `System.Collections.Generic.List`). The base fallbacks are only reachable by hypothetical third-party derivatives of the published NuGet package.

Consequences:

1. The base `GetEnumerator()` **cannot** become streaming — the base has no storage; `GetValues<TValue>()` is its only data source. Making it `abstract` would break the published API for unknown external derivatives. **Keep as-is**, and document that derivatives should override with a streaming implementation.
2. The base `GetKeys_1()` / `GetKeys_2()` **can** iterate over `this` (virtual dispatch lands on the derivative's streaming `GetEnumerator`), removing the intermediate `List` allocation for streaming derivatives. `GetValues<UValue>(key_1)` and `GetValues<UValue>(func)` can likewise build their result lists in a single pass over `this` instead of materializing-then-filtering. Their `List` return type still requires one allocation — that is inherent to the return contract.

### 2.2 `Table` — issue claim confirmed, and a real hot path found

- `DiGi.Core.IO/Table/Classes/Table.cs:89-95` — `Rows` getter: `[.. rows.Values.Select(x => x.Clone()!)]`. **N deep clones + one array allocation per call. Confirmed.**
- `DiGi.Core.IO/Table/Classes/Table.cs:454-457` — `GetEnumerator()` delegates to `Rows`. **Confirmed.**
- **New finding (hot path):** `DiGi.PostgreSQL/DiGi.PostgreSQL.Table/Classes/TablePostgreSQLConverter.cs:1610` iterates `foreach (TRow row in table)` in the primary table→PostgreSQL write path — the whole table is deep-cloned up front and held alive across the batched `NpgsqlBatch` write. For thousands of rows this is the dominant allocation of the write.
- All other in-ecosystem consumers iterate the `Rows` property (snapshot), not the table itself: `DiGi.Core.IO/DelimitedData/Modify/Append.cs:84`, `Write.cs:41`, `TableConverter.cs:123`, `DiGi.GIS.WebAPI/BuildingDataController.cs:1267,1281`, `DiGi.Translate/Modify/Read.cs:65`. **None of them mutate the table during iteration**, so live-row enumeration is safe for every known call site.

### 2.3 Constraint the issue misses: `Rows` clone semantics are pinned by a test

- `DiGi.Test/DiGi.Core.xUnit/Facts/TableRows.cs::Table_Rows_ReturnsClonedRowsInOrder` asserts that `Table.Rows` **must keep returning clones** ("mutating the returned row must not affect the table's internal state").

Therefore A3 must be implemented as: **`GetEnumerator()` streams live rows from `rows.Values`; `Rows` (and `Columns`) stay defensive snapshots.** This also matches the .NET convention (`List<T>` / `Dictionary.Values` enumerate live references; snapshots are opt-in via `ToList()`). The `Rows`/`Columns` split then documents as: *snapshot accessors*, while `GetEnumerator` is the *live view*.

### 2.4 A1 audit — complete `GetEnumerator` matrix (5 DiGi.Core projects)

| Type | GetEnumerator behavior | Verdict |
|---|---|---|
| `Cluster<TKey_1, TKey_2, TValue>` (base) | `GetValues<TValue>()` → List allocation | ⚠️ fallback only — no storage in base; no known derivative hits it |
| `List<TKey_1, TKey_2, TValue>` | streams over internal `Dictionary` | ✅ |
| `ValueCluster<TKey_1, TKey_2, TValue>` | streams over internal `Dictionary` | ✅ |
| `SerializableObjectListCluster` / `SerializableObjectValueCluster` / `UniqueObjectValueCluster` | inherit streaming overrides | ✅ |
| `IndexedObjects<T>` | `sortedDictionary.Values.GetEnumerator()` | ✅ |
| `SerializableObjectCollection<T>` | `values?.GetEnumerator()` | ✅ |
| `DateTimeCollection` | `dateTimes?.GetEnumerator()` | ✅ |
| `Table<TColumn, TRow>` | `Rows` → N deep clones + array | ❌ **the real defect** |
| `MetadataStorage` (internal) | `Metadatas` → `[.. dictionary.Values]` (reference-copy only, no clones) | ✅ acceptable |
| `AssociatedTypes` | `types.GetEnumerator()` | ✅ |
| `ParameterGroup` / `ParameterGroupCollection` | `dictionary.Values.GetEnumerator()` | ✅ |

`DelimitedDataRow` is `System.Collections.Generic.List<string>` — not in scope.

---

## 3. Implementation plan

### Phase 0 — Reproduce before fixing (guideline: *Coding - Automatic Tests*, "Reproduce Before Fixing")

Add a fact to `DiGi.Test/DiGi.Core.xUnit/Facts/Table.cs` (existing shared `Facts` partial class; method named after the target) **before touching production code**:

```csharp
/// <summary>
/// Verifies that Table enumerates live rows instead of materializing a cloned snapshot.
/// </summary>
[Fact]
public void Table_GetEnumeratorStreamsLiveRows()
{
    Table table = new();
    table.AddColumn(new Column("Col0", typeof(string)));
    table.AddColumn(new Column("Col1", typeof(int)));

    table.AddRow(["A", 1]);
    table.AddRow(["B", 2]);

    foreach (Row row in table)
    {
        row[0] = "Mutated";
        break;
    }

    // Fails on the unmodified code (cloned rows): mutation is invisible to the table.
    Assert.Equal("Mutated", table[0, 0]);
}
```

Run it and confirm it **fails on the unmodified code** — that failure is the committed reproduction evidence.

### Phase 1 — Fix `Table` enumeration (`DiGi.Core.IO/Table/Classes/Table.cs`)

Replace `GetEnumerator()` (lines 454–457) with a direct streaming generator over the internal store (a `SortedDictionary` value-collection enumerator — order-preserving, zero intermediate allocation):

```csharp
public IEnumerator<TRow> GetEnumerator()
{
    foreach (TRow row in rows.Values)
    {
        if (row == null)
        {
            continue;
        }

        yield return row;
    }
}
```

Documentation updates (same change):

- `GetEnumerator()` `<summary>`: state that it iterates the **live** rows in index order and that `Rows` is the defensive-copy accessor.
- Class-level `<summary>` "Behavior and Architecture" list: add a paragraph 7 documenting the snapshot-vs-live split (`Rows`/`Columns` return defensive copies; `GetEnumerator` is a live view).
- **Do not touch** `Rows` / `Columns` — `Table_Rows_ReturnsClonedRowsInOrder` pins the clone semantics of `Rows`.

### Phase 2 — Re-point `Cluster` base helpers (`DiGi.Core/Classes/Cluster/Cluster.cs`)

- `GetKeys_1()` (line 156) and `GetKeys_2()` (line 186): iterate `foreach (TValue value in this)` instead of `GetValues<TValue>()`; keep the existing null-key skips and the `key_1 == null → null` guard on `GetKeys_2`. Keep the null-vs-empty return contract documented.
- `GetValues<UValue>(TKey_1? key_1)` and `GetValues<UValue>(Func<UValue?, bool>?)`: build the result `List` in a single pass over `this` (type-filter + key/predicate filter inline) instead of materializing a full `List<UValue>` and then filtering / `RemoveAll`. Result semantics identical.
- Base `GetEnumerator()` (line 128): **unchanged** — no storage in the base; `GetValues<TValue>()` is the only source. Extend its `<summary>` to instruct derivatives to override with a streaming implementation.

### Phase 3 — Tests (`DiGi.Test/DiGi.Core.xUnit`)

Per *Coding - Automatic Tests*:

1. `Facts/Table.cs` — `Table_GetEnumeratorStreamsLiveRows()` (Phase 0, must go red first, green after Phase 1).
2. `Facts/Table.cs` — `Table_Enumeration_Performance()`: build a table of ≥10k rows × 8 columns; warm-up run (JIT); 3 `Stopwatch` measurements, report the **range** to `Core.xUnit.Query.ReportsDirectory(Assembly.GetExecutingAssembly())`; assert a threshold that clears the **in-suite** time. Measure in isolation: `dotnet test DiGi.Core.xUnit -c Release --filter "FullyQualifiedName~Table_Enumeration_Performance"`. A/B against the pre-change `Table.cs` (keep a copy of the original file, swap it back in, re-run isolated under identical conditions) — never compare against a stale report.
3. `Classes/` — add `TestBaseCluster : Cluster<string, string, string>` (minimal concrete derivative; none exists today) and facts in `Facts/Cluster.cs` pinning base `GetKeys_1()` / `GetKeys_2()` / `GetValues(key_1)` / `GetValues(func)` results against the `TestListCluster` / `TestValueCluster` equivalents.
4. Guard-effectiveness check (guideline: "A Guard Must Be Shown To Fail"): temporarily break one of the Phase 2 methods and confirm the new facts fail, then restore.
5. Regression: full `DiGi.Core.xUnit` suite green; `Table_Rows_ReturnsClonedRowsInOrder` **must stay green** (snapshot semantics intact); `TableWrite` / `TableConverter` round-trip facts green.

### Phase 4 — Build & cross-repo verification

- `dotnet build DiGi.Core.slnx` — **zero warnings** (guideline: *Coding - General* §1.4).
- Build `DiGi.PostgreSQL` (consumer of the changed enumeration) and `DiGi.GIS.WebAPI` to confirm no compile impact — no public signature changes are made.
- SemVer: no public API signature changes (implementation + XML docs only) → patch bump of `DiGi.Core`.

---

## 4. Explicit rejections / out of scope

1. **"Make direct streaming enumeration mandatory"** (issue's proposed remedy 1): rejected — making the base `GetEnumerator()` abstract is a breaking change to a published NuGet, and no known derivative would benefit (all concrete clusters already stream).
2. **Changing `Table.Rows` / `Table.Columns` snapshot semantics:** rejected — pinned by the committed test `Table_Rows_ReturnsClonedRowsInOrder` and used as the snapshot accessor by every known consumer.
3. **Auditing other `IEnumerable` types:** complete — the §2.4 matrix is the audit; everything else already streams.

## 5. Behavioral change statement

`foreach (T t in table)` on a `Table` yields **live row references** instead of defensive clones. Mutating a row obtained from the enumerator now mutates the table. No known consumer in the DiGi ecosystem mutates rows obtained via enumeration (all verified read-only); consumers needing the old semantics should use `table.Rows`. This must be called out in the release notes / wiki.
