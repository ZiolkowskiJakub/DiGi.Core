#### [DiGi\.Core\.Relation](DiGi.Core.Relation.Overview.md 'DiGi\.Core\.Relation\.Overview')

## DiGi\.Core\.Relation Namespace
### Classes

<a name='DiGi.Core.Relation.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Core.Relation.Create.RelationListClusterReference(System.Collections.Generic.IReadOnlyList_string_)'></a>

## Create\.RelationListClusterReference\(IReadOnlyList\<string\>\) Method

Rebuilds a [RelationListClusterReference](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListClusterReference 'DiGi\.Core\.Relation\.Classes\.RelationListClusterReference') from the segments of its string form\.

```csharp
public static DiGi.Core.Interfaces.IReference? RelationListClusterReference(System.Collections.Generic.IReadOnlyList<string?>? segments);
```
#### Parameters

<a name='DiGi.Core.Relation.Create.RelationListClusterReference(System.Collections.Generic.IReadOnlyList_string_).segments'></a>

`segments` [System\.Collections\.Generic\.IReadOnlyList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')

The segments: the first key, the second key, then the index\.

#### Returns
[DiGi\.Core\.Interfaces\.IReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireference 'DiGi\.Core\.Interfaces\.IReference')  
The reference, or `null` if the segments do not describe one\.

<a name='DiGi.Core.Relation.Modify'></a>

## Modify Class

Provides methods for modifying relations\.

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.Core.Relation.Modify.RemoveFirst_TReference_(thisSystem.Collections.Generic.List_TReference_,DiGi.Core.Interfaces.IReference)'></a>

## Modify\.RemoveFirst\<TReference\>\(this List\<TReference\>, IReference\) Method

Removes the first occurrence of the specified reference from the list\.

```csharp
public static bool RemoveFirst<TReference>(this System.Collections.Generic.List<TReference>? references, DiGi.Core.Interfaces.IReference? reference)
    where TReference : DiGi.Core.Interfaces.IReference;
```
#### Type parameters

<a name='DiGi.Core.Relation.Modify.RemoveFirst_TReference_(thisSystem.Collections.Generic.List_TReference_,DiGi.Core.Interfaces.IReference).TReference'></a>

`TReference`

The type of elements in the references list\.
#### Parameters

<a name='DiGi.Core.Relation.Modify.RemoveFirst_TReference_(thisSystem.Collections.Generic.List_TReference_,DiGi.Core.Interfaces.IReference).references'></a>

`references` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TReference](DiGi.Core.Relation.md#DiGi.Core.Relation.Modify.RemoveFirst_TReference_(thisSystem.Collections.Generic.List_TReference_,DiGi.Core.Interfaces.IReference).TReference 'DiGi\.Core\.Relation\.Modify\.RemoveFirst\<TReference\>\(this System\.Collections\.Generic\.List\<TReference\>, DiGi\.Core\.Interfaces\.IReference\)\.TReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list of references to remove the item from\.

<a name='DiGi.Core.Relation.Modify.RemoveFirst_TReference_(thisSystem.Collections.Generic.List_TReference_,DiGi.Core.Interfaces.IReference).reference'></a>

`reference` [DiGi\.Core\.Interfaces\.IReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireference 'DiGi\.Core\.Interfaces\.IReference')

The reference to remove from the list\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the reference was successfully removed; otherwise, false\.

<a name='DiGi.Core.Relation.Query'></a>

## Query Class

Provides methods for querying relations\.

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Core.Relation.Query.IsValid(thisDiGi.Core.Relation.Interfaces.IRelation,System.Type,DiGi.Core.Relation.Enums.RelationSide)'></a>

## Query\.IsValid\(this IRelation, Type, RelationSide\) Method

Determines whether the relation is valid for the specified type and side\.

```csharp
public static bool IsValid(this DiGi.Core.Relation.Interfaces.IRelation? relation, System.Type? type, DiGi.Core.Relation.Enums.RelationSide relationSide);
```
#### Parameters

<a name='DiGi.Core.Relation.Query.IsValid(thisDiGi.Core.Relation.Interfaces.IRelation,System.Type,DiGi.Core.Relation.Enums.RelationSide).relation'></a>

`relation` [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation')

The relation to validate\.

<a name='DiGi.Core.Relation.Query.IsValid(thisDiGi.Core.Relation.Interfaces.IRelation,System.Type,DiGi.Core.Relation.Enums.RelationSide).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to check against\.

<a name='DiGi.Core.Relation.Query.IsValid(thisDiGi.Core.Relation.Interfaces.IRelation,System.Type,DiGi.Core.Relation.Enums.RelationSide).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the relation is valid; otherwise, false\.

<a name='DiGi.Core.Relation.Query.UniqueReferences(thisDiGi.Core.Relation.Interfaces.IRelation,DiGi.Core.Relation.Enums.RelationSide)'></a>

## Query\.UniqueReferences\(this IRelation, RelationSide\) Method

Gets the set of unique references from the relation on the specified side\.

```csharp
public static System.Collections.Generic.HashSet<DiGi.Core.Interfaces.IUniqueReference>? UniqueReferences(this DiGi.Core.Relation.Interfaces.IRelation? relation, DiGi.Core.Relation.Enums.RelationSide relationSide);
```
#### Parameters

<a name='DiGi.Core.Relation.Query.UniqueReferences(thisDiGi.Core.Relation.Interfaces.IRelation,DiGi.Core.Relation.Enums.RelationSide).relation'></a>

`relation` [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation')

The relation to retrieve unique references from\.

<a name='DiGi.Core.Relation.Query.UniqueReferences(thisDiGi.Core.Relation.Interfaces.IRelation,DiGi.Core.Relation.Enums.RelationSide).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to check\.

#### Returns
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')  
A set of unique references, or null if none exist\.