# DiGi.Core#7 — Investigation Results & Implementation Plan

> Status: **Still valid.** Every verifiable premise was checked against the current tree (branch `0.8.8`, 2026-09-14) and holds, with one premise corrected (§2.3), the mandated `Lerps` caller check resolved (§2.4) and the palette completed to exact values (§2.5). The consumer [DiGi.GIS.WebAPI.UI#20](https://github.com/ZiolkowskiJakub/DiGi.GIS.WebAPI.UI/issues/20) is still **OPEN**, so the need is current.

---

## 1. Verdict

| Action item | Verdict |
|---|---|
| `Create.Colors(ColorSchemeType, int, Color?, Color?)` — scheme as extension receiver | **Valid — the core work.** No `Colors` member and no `ColorSchemeType` exist anywhere in the repo (greps in §2.2). Receiver-first matches the house `Create` shape (e.g. `LongProgressWrapper(this IProgress<long>?, long initialValue = 0)`), and enum receivers have precedent (`Query.TimeOffset(this Enums.UTC uTC)`). |
| `ColorSchemeType` enum | **Valid.** Lands in `DiGi.Core/Enums` per the issue and the `[Project].Enums` rule. |
| OKLab support (struct + 2 Convert methods) | **Valid — and it must be shared, not local functions.** All three schemes (Sequential, Diverging, Categorical) interpolate or assert in OKLab, so per the issue's own decision rule it earns a public type. |
| `Lerps` end-point decision | **Valid — caller check came back empty** (workspace grep + GitHub code search, §2.4), so per the issue's decision rule: **fix `Lerps` in place** rather than adding a `Ramp` duplicate. |
| Categorical 12-colour palette | **Valid — palette retrieved** from `DiGi.GIS.WebAPI.UI@0.8.9` `typology.js` (§2.5). The issue's "Tableau 10 plus two" is resolved to the exact 12 hex values. |
| Consumption (Typology appearances, GIS page palette swap) | **Out of scope here.** Consumer issue #20 owns it; this repo only ships the colour list. |

---

## 2. Verification against the code (issue premises checked)

### 2.1 `Lerp` / `Lerps` — confirmed, with one type correction

- `DiGi.Core/Query/Lerp.cs:15` — `public static Color Lerp(this Color color_1, Color color_2, double value)`, per-RGB-channel interpolation. **Confirmed.**
- `DiGi.Core/Query/Lerps.cs` — signature at line 15; the loop initialises `value = 0` (line 24) and steps `value += 1.0 / count` (lines 25–29). The last element is therefore `Lerp(..., (count - 1) / count)`. **The anomaly is confirmed: `color_2` is never returned; `count = 2` yields `[color_1, midpoint]`.**
- No committed fact pins either method (no `Facts/Lerp*.cs` in `DiGi.Core.xUnit`), so the in-place fix is safe inside the test suite; a new fact pins the corrected behaviour (Phase 2.4).
- **Type note (see §2.3):** both operate on `System.Drawing.Color`, not `DiGi.Core.Classes.Color`.

### 2.2 No pre-existing `Colors` / `ColorSchemeType`

- `ColorSchemeType` — **zero** occurrences in the repository (code, docs, tests).
- `Colors` — only generated API-doc lines for `Lerps`. Nothing to reconcile against.

### 2.3 Return type — premise correction

- The issue's premise table says "`Color`, `Query.Lerp` and `Query.Lerps` already live here", and the Objective says `Colors` returns "`Core.Classes.Color` (the DiGi one), never `System.Drawing.Color`". In fact: `DiGi.Core.Classes.Color` **does** exist (`DiGi.Core/Classes/Color.cs`, with implicit conversions to/from `System.Drawing.Color` and `int`), but `Lerp`/`Lerps` are built on `System.Drawing.Color`. The two coexist; `Create.Colors` returns `List<Classes.Color>?` per the Objective, and the OKLab conversions are anchored on `Classes.Color`. No conflict — but the implementer must not assume `Lerp`-style code compiles against `Classes.Color` directly (the OKLab ramp is its own local function, Phase 0.6).

### 2.4 Caller check for the `Lerps` change (the issue's mandated grep)

- Workspace (DiGi.Core, DiGi.Test, DiGi.Typology): `\.Lerps(` → **zero hits**; `\.Lerp(` → **zero hits**.
- GitHub code search `\.Lerps( user:ZiolkowskiJakub` → **0 results** across all visible repositories.
- **Decision (must be stated in the resolution comment, per the issue):** no caller found → **fix `Lerps` in place** (`value = i / (count - 1)`; `count = 1` returns `[color_1]`) and rewrite its XML doc to state the end-point-inclusive behaviour explicitly. If an invisible external consumer of the old stepping is ever found, the documented diff is in the resolution comment; the issue's `Query.Ramp` fallback remains available for that case (see §4.3).

### 2.5 Categorical palette — retrieved, exact values

`DiGi.GIS.WebAPI.UI@0.8.9`, `wwwroot/js/typology.js` (lines 37–40):

```
'#1f77b4', '#ff7f0e', '#2ca02c', '#d62728', '#9467bd', '#8c564b',
'#e377c2', '#7f7f7f', '#bcbd22', '#17becf', '#393b79', '#e7ba52'
```

Tableau 10 plus `#393b79` and `#e7ba52`. These 12 values go into `Constants/ColorScheme.cs` and are what the distance fact asserts against — the same list the GIS page seeds with, so both sides agree without a runtime round trip.

### 2.6 Consumer-side status

- DiGi.GIS.WebAPI.UI#20 — **OPEN** (`type: feature`, `priority: medium`, `ai: heavy`).
- `DiGi.Typology.Visual.TypologyAppearance` was re-designed on 2026-09-11 into a container of `IAppearance` instances (`Classes/TypologyAppearance/TypologyAppearance.cs`). This does not change this repo's scope: the issue already defers the colour→appearance wrapping to the GIS page, and `Create.Colors` stays a pure `List<Classes.Color>` factory.

---

## 3. Implementation plan

### Phase 0 — API surface (new files; one member per file)

1. **`DiGi.Core/Enums/ColorSchemeType.cs`** — `namespace DiGi.Core.Enums`, `[Description]` on the enum and each value following the `ResultType` pattern: `Sequential`, `Diverging`, `Categorical`.
2. **`DiGi.Core/Classes/OKLab.cs`** — a small `struct OKLab` with `double L`, `double A`, `double B` and one constructor. Data container only (`/Classes` rule: properties + basic constructor, no business logic). The issue's "shared → public type" branch applies because Diverging and Categorical both use it (and the facts do too).
3. **`DiGi.Core/Convert/ToOKLab/OKLab.cs`** (new folder — target type `OKLab`) —
   `public static OKLab ToOKLab(this Classes.Color color)` — sRGB → linear → OKLab (Ottosson OKLab conversion, pure math).
4. **`DiGi.Core/Convert/ToDiGi/Color.cs`** (existing file — the target type `Color` already has a file there, and "all conversions to one target share a file") — append
   `public static Classes.Color ToDiGi(this OKLab okLab)` — inverse conversion; clamp channels to [0, 1] before the sRGB gamma step, round to byte.
5. **`DiGi.Core/Constants/ColorScheme.cs`** — documented `const` fields, shaped like `Constants/FNV.cs`:
   - `LightnessMin = 0.15`, `LightnessMax = 0.93` (the OKLab readability clamp),
   - `CategoricalMinimumDistance = 0.08` (OKLab ΔE floor for `count ≤ 12`),
   - `GoldenAngleDegrees = 137.508`, `CategoricalPaletteSize = 12`, `CategoricalTurnSize = 12`,
   - the 12 curated palette entries (§2.5) and the default Sequential anchors `#deebf7` / `#08306b`.
   No magic numbers at the call sites (guideline: *Coding - General* §2, standard constants).
6. **`DiGi.Core/Create/Colors.cs`** —

   ```csharp
   public static List<Classes.Color>? Colors(this Enums.ColorSchemeType colorSchemeType, int count, Classes.Color? color_Start = null, Classes.Color? color_End = null)
   ```

   - `colorSchemeType` is the **extension receiver**: `ColorSchemeType.Sequential.Colors(8)` at the call site (static form `Create.Colors(ColorSchemeType.Sequential, 8)` still available). The receiver-first shape with a trailing optional parameter is the established `Create` pattern (`Create.LongProgressWrapper(this IProgress<long>?, long initialValue = 0)`), and an enum receiver has precedent in the repo (`Query.TimeOffset(this Enums.UTC uTC)`).
   - The receiver is a non-nullable enum — no null guard on it; the scheme dispatch is a `switch` over the three values (no sentinel, unlike `UTC.Undefined`).
   - 4 parameters → stays on **one line** (`<= 7` rule); synchronous pure math → no `CancellationToken`.
   - `count < 1` → `null` (the `Lerps` convention).
   - Single-use helpers as **local functions** inside the method (no `private static` in partial utility classes): `OKLab LerpOKLab(OKLab, OKLab, double)`, `Classes.Color ClampLightness(OKLab)`.
   - **`Sequential`:** end-point-inclusive OKLab ramp between the (lightness-clamped) anchors; `count = 1` → the **end anchor**, per the issue.
   - **`Diverging`:** two OKLab ramps meeting at the neutral light middle `#f7f7f7`; odd `count` puts the neutral on the centre bucket; `count = 1` → the neutral centre (flagged decision, §5).
   - **`Categorical`:** `count ≤ 12` → the first `count` entries of the curated palette; `count > 12` → `h = (i × 137.508°) mod 360` at fixed OKLCH chroma with two lightness levels alternating every turn of 12; the `<summary>` documents that legends past ~24 are not readable (the issue requires the summary to say so).
   - **Deterministic:** no RNG, no `CultureInfo`-dependent formatting anywhere in the path.

### Phase 1 — `Lerps` fix (behaviour change, per §2.4 decision)

`DiGi.Core/Query/Lerps.cs`:

- `value = i / (count - 1)` with a `count == 1` guard returning `[color_1]`; `count < 1` keeps returning `null`.
- XML `<summary>` rewritten to state the **end-point-inclusive** behaviour and the single-element case explicitly — the ambiguity is what created the defect.

### Phase 2 — Tests (`DiGi.Test/DiGi.Core.xUnit`, shared `Facts` partial class)

New file **`Facts/Colors.cs`** (method names after the target, per *Coding - Automatic Tests* §2):

1. **`Colors()`** — call form `Core.Enums.ColorSchemeType.Sequential.Colors(8)` (receiver-first, per Phase 0.6); `null` for `count < 1`; `count` 1/2/5/12/24 for all three schemes; determinism (two calls, element-wise `Assert.Equal`); anchors honoured (Sequential with explicit anchors: first/last equal the clamped anchors, `count = 1` = end anchor); lightness clamp (every output within OKLab `L ∈ [0.15, 0.93]`); Diverging odd-count centre neutrality.
2. **`Colors_CategoricalDistance()`** — pairwise OKLab ΔE ≥ 0.08 for every pair at `count = 12` (and each prefix `count ≤ 12`); compute and **report the achieved minimum for `count = 24`** to the reports directory (the issue requires it documented).
3. **`Colors_Report()`** — render the three schemes for `count = 8` into **`DiGi.Test/user files/reports/colors.html`** (swatches; folder verified to exist and git-ignored) via `Core.xUnit.Query.ReportsDirectory(Assembly.GetExecutingAssembly())` — for the visual check.
4. **`Lerps()`** — new fact pinning the corrected behaviour (none exists today): `count = 1` → `[color_1]`; `count = 2` → `[color_1, color_2]`; `count = 3` → `[color_1, midpoint, color_2]`.
5. **`OKLab()`** — round trip `ToDiGi(ToOKLab(color))` equals the input within ±1 byte per channel over a sample set (white, black, mid-grey, the 12 palette colours).
6. **Guard-effectiveness check** (guideline: "A Guard Must Be Shown To Fail"): temporarily perturb one curated palette entry and one clamp boundary, confirm facts 1 and 2 **fail**, then restore.

Commands (run from `DiGi.Test`; acceptance criterion: build with `-m:1` before testing):

```powershell
dotnet build "..\DiGi.Core\DiGi.Core\DiGi.Core.csproj" -c Debug -m:1
dotnet test "DiGi.Core.xUnit\DiGi.Core.xUnit.csproj" -c Debug -m:1
```

Facts use `Classes.Color` (pure bytes) — no `System.Drawing` named-colour APIs, so no `[SupportedOSPlatform]` friction on the net10.0 test project.

### Phase 3 — Docs, release, resolution comment

- XML docs on **every** new member: one `<summary>`, no blank lines inside doc blocks, `<param>` order mirroring the signature (*XML Documentation - Create*).
- `documentation/API/` is generated from the XML docs (`DefaultDocumentation.json`) — no hand edits.
- Zero compiler/analyzer warnings (*Coding - General* §1.4).
- **Signature alignment comment on #7 (before implementation starts):** the issue body pins the old parameter order in its Objective block and in the Consumption example (`count => Create.Colors(count, Sequential)`). Per *GitHub - Issues* §2, post a comment with the updated signature and the adjusted call form (`count => Sequential.Colors(count)`) — do **not** edit the issue body. Consumer #20 was checked: its body consumes the factory through the `appearances` callback of `TryGenerateRanges` and pins no signature, so it needs no comment.
- Commit on branch `0.8.8`; the merge-into-`main` + patch-bump to `0.8.9` follows the *GitHub - Branch Synchronization* workflow.
- Resolution comment per *GitHub - Issues* §3 (resolution & commits, summary of changes, tests, verification) **plus the mandated `Lerps` decision and its evidence** (§2.4).

---

## 4. Explicit rejections / out of scope

1. **`Create.TypologyAppearances(...)`** — the issue itself defers it: the GIS page owns the colour→appearance mapping (`Create.TypologyAppearance(Color)` in `DiGi.GIS.WebAPI.UI`).
2. **Server-side palette endpoint / client palette swap in `DiGi.GIS.WebAPI.UI`** — consumer issue #20, different repository.
3. **A `Query.Ramp` duplicate** — the caller check came back empty (§2.4), so the issue's decision rule points at fixing `Lerps` in place. `Ramp` stays as the documented fallback **only if** an external caller of the old `Lerps` stepping surfaces.
4. **New NuGet packages** — OKLab is ~40 lines of pure math on `netstandard2.0`; nothing to add, so the `HintPath` transitive-dependency rules never activate.

---

## 5. Open decisions (to be pinned during implementation, with the rationale in XML docs)

- **Diverging `count = 1`:** return the neutral centre `#f7f7f7` (recommended — consistent with "odd `count` puts the middle on the centre bucket") vs. the end anchor (Sequential parity).
- **Default Diverging anchors:** the issue names only the `#f7f7f7` middle. Propose a ColorBrewer RdBu-style pair (`#b2182b` → `#2166ac`, lightness-clamped) and state it in the `<summary>`.
- **Categorical "turn":** one turn = 12 buckets (the palette size); the lightness level flips every turn so turn boundaries differ in more than hue.
- **Golden-angle chroma/lightness values:** choose OKLCH values inside the clamp band, pin them in `Constants/ColorScheme.cs`, and let `Colors_CategoricalDistance()` assert the outcome rather than trusting the choice.
