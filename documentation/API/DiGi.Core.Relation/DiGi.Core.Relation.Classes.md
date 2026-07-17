#### [DiGi\.Core\.Relation](DiGi.Core.Relation.Overview.md 'DiGi\.Core\.Relation\.Overview')

## DiGi\.Core\.Relation\.Classes Namespace
### Classes

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation'></a>

## ManyToManyRelation Class

Represents an abstract many\-to\-many relationship between unique objects\.

```csharp
public abstract class ManyToManyRelation : DiGi.Core.Relation.Classes.ManyToManyRelation<DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IUniqueObject>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Relation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>') → [DiGi\.Core\.Relation\.Classes\.ManyToManyRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>') → ManyToManyRelation
### Constructors

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation.ManyToManyRelation(DiGi.Core.Relation.Classes.ManyToManyRelation)'></a>

## ManyToManyRelation\(ManyToManyRelation\) Constructor

Creates a new instance of the ManyToManyRelation class by copying another instance\.

```csharp
public ManyToManyRelation(DiGi.Core.Relation.Classes.ManyToManyRelation? manyToManyRelation);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation.ManyToManyRelation(DiGi.Core.Relation.Classes.ManyToManyRelation).manyToManyRelation'></a>

`manyToManyRelation` [ManyToManyRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation')

The existing ManyToManyRelation instance to copy from\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation.ManyToManyRelation(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueObject_,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueObject_)'></a>

## ManyToManyRelation\(IEnumerable\<IUniqueObject\>, IEnumerable\<IUniqueObject\>\) Constructor

Creates a new instance of the ManyToManyRelation class from unique objects\.

```csharp
public ManyToManyRelation(System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueObject>? uniqueObjects_From, System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueObject>? uniqueObjects_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation.ManyToManyRelation(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueObject_,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueObject_).uniqueObjects_From'></a>

`uniqueObjects_From` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique objects representing the source side of the relation\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation.ManyToManyRelation(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueObject_,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueObject_).uniqueObjects_To'></a>

`uniqueObjects_To` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique objects representing the target side of the relation\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation.ManyToManyRelation(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_)'></a>

## ManyToManyRelation\(IEnumerable\<IUniqueReference\>, IEnumerable\<IUniqueReference\>\) Constructor

Creates a new instance of the ManyToManyRelation class from unique references\.

```csharp
public ManyToManyRelation(System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueReference>? uniqueReferences_From, System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueReference>? uniqueReferences_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation.ManyToManyRelation(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_).uniqueReferences_From'></a>

`uniqueReferences_From` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references representing the source side of the relation\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation.ManyToManyRelation(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_).uniqueReferences_To'></a>

`uniqueReferences_To` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references representing the target side of the relation\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation.ManyToManyRelation(System.Text.Json.Nodes.JsonObject)'></a>

## ManyToManyRelation\(JsonObject\) Constructor

Creates a new instance of the ManyToManyRelation class from a JSON object\.

```csharp
public ManyToManyRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation.ManyToManyRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to create the relation from\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_'></a>

## ManyToManyRelation\<From,To\> Class

Represents an abstract many\-to\-many relationship between two types of unique objects\.

```csharp
public abstract class ManyToManyRelation<From,To> : DiGi.Core.Relation.Classes.Relation<From, To>, DiGi.Core.Relation.Interfaces.IManyToManyRelation<From, To>, DiGi.Core.Relation.Interfaces.IManyToManyRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation<From, To>
    where From : DiGi.Core.Interfaces.IUniqueObject
    where To : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.From'></a>

`From`

The type of the source objects in the relation\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.To'></a>

`To`

The type of the destination objects in the relation\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Relation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>') → ManyToManyRelation\<From,To\>

Derived  
↳ [ManyToManyRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation')

Implements [DiGi\.Core\.Relation\.Interfaces\.IManyToManyRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToManyRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IManyToManyRelation\<XUniqueObject,YUniqueObject\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToManyRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IManyToManyRelation\<XUniqueObject,YUniqueObject\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToManyRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IManyToManyRelation\<XUniqueObject,YUniqueObject\>'), [IManyToManyRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToManyRelation 'DiGi\.Core\.Relation\.Interfaces\.IManyToManyRelation'), [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')
### Constructors

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.ManyToManyRelation(DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_)'></a>

## ManyToManyRelation\(ManyToManyRelation\<From,To\>\) Constructor

Creates a new instance of the ManyToManyRelation class by copying another instance\.

```csharp
public ManyToManyRelation(DiGi.Core.Relation.Classes.ManyToManyRelation<From,To>? manyToManyRelation);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.ManyToManyRelation(DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_).manyToManyRelation'></a>

`manyToManyRelation` [DiGi\.Core\.Relation\.Classes\.ManyToManyRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>')

The existing relation instance to copy from\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.ManyToManyRelation(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_)'></a>

## ManyToManyRelation\(IEnumerable\<IUniqueReference\>, IEnumerable\<IUniqueReference\>\) Constructor

Creates a new instance of the ManyToManyRelation class from unique references\.

```csharp
public ManyToManyRelation(System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueReference>? uniqueReferences_From, System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueReference>? uniqueReferences_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.ManyToManyRelation(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_).uniqueReferences_From'></a>

`uniqueReferences_From` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references from the source side\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.ManyToManyRelation(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_).uniqueReferences_To'></a>

`uniqueReferences_To` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references from the destination side\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.ManyToManyRelation(System.Collections.Generic.IEnumerable_From_,System.Collections.Generic.IEnumerable_To_)'></a>

## ManyToManyRelation\(IEnumerable\<From\>, IEnumerable\<To\>\) Constructor

Creates a new instance of the ManyToManyRelation class from unique objects\.

```csharp
public ManyToManyRelation(System.Collections.Generic.IEnumerable<From>? uniqueObjects_From, System.Collections.Generic.IEnumerable<To>? uniqueObjects_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.ManyToManyRelation(System.Collections.Generic.IEnumerable_From_,System.Collections.Generic.IEnumerable_To_).uniqueObjects_From'></a>

`uniqueObjects_From` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>\.From')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique objects from the source side\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.ManyToManyRelation(System.Collections.Generic.IEnumerable_From_,System.Collections.Generic.IEnumerable_To_).uniqueObjects_To'></a>

`uniqueObjects_To` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>\.To')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique objects from the destination side\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.ManyToManyRelation(System.Text.Json.Nodes.JsonObject)'></a>

## ManyToManyRelation\(JsonObject\) Constructor

Creates a new instance of the ManyToManyRelation class from a JSON object\.

```csharp
public ManyToManyRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.ManyToManyRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to create the relation from\.
### Properties

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.UniqueReferences'></a>

## ManyToManyRelation\<From,To\>\.UniqueReferences Property

Gets a list containing all unique references in this relation\.

```csharp
public override System.Collections.Generic.List<DiGi.Core.Interfaces.IUniqueReference>? UniqueReferences { get; }
```

Implements [UniqueReferences](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.UniqueReferences 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.UniqueReferences')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.UniqueReferences_From'></a>

## ManyToManyRelation\<From,To\>\.UniqueReferences\_From Property

Gets a list of unique references on the "from" side of the relation\.

```csharp
public System.Collections.Generic.List<DiGi.Core.Interfaces.IUniqueReference>? UniqueReferences_From { get; }
```

Implements [UniqueReferences\_From](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToManyRelation.UniqueReferences_From 'DiGi\.Core\.Relation\.Interfaces\.IManyToManyRelation\.UniqueReferences\_From')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.UniqueReferences_To'></a>

## ManyToManyRelation\<From,To\>\.UniqueReferences\_To Property

Gets a list of unique references on the "to" side of the relation\.

```csharp
public System.Collections.Generic.List<DiGi.Core.Interfaces.IUniqueReference>? UniqueReferences_To { get; }
```

Implements [UniqueReferences\_To](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToManyRelation.UniqueReferences_To 'DiGi\.Core\.Relation\.Interfaces\.IManyToManyRelation\.UniqueReferences\_To')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.Add(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference)'></a>

## ManyToManyRelation\<From,To\>\.Add\(RelationSide, IUniqueReference\) Method

Adds a unique reference to the specified side of the relation\.

```csharp
public override bool Add(DiGi.Core.Relation.Enums.RelationSide relationSide, DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.Add(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation where the reference should be added\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.Add(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the reference was successfully added; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference)'></a>

## ManyToManyRelation\<From,To\>\.Contains\(RelationSide, IUniqueReference\) Method

Determines whether the relation contains the specified unique reference on the given side\.

```csharp
public override bool Contains(DiGi.Core.Relation.Enums.RelationSide relationSide, DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to check\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to locate in the relation\.

Implements [Contains\(RelationSide, IUniqueReference\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Contains\(DiGi\.Core\.Relation\.Enums\.RelationSide, DiGi\.Core\.Interfaces\.IUniqueReference\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the relation contains the specified unique reference on the given side; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.Has(DiGi.Core.Relation.Enums.RelationSide)'></a>

## ManyToManyRelation\<From,To\>\.Has\(RelationSide\) Method

Determines whether the relation has a reference on the specified side\.

```csharp
public override bool Has(DiGi.Core.Relation.Enums.RelationSide relationSide);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.Has(DiGi.Core.Relation.Enums.RelationSide).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to check\.

Implements [Has\(RelationSide\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Has(DiGi.Core.Relation.Enums.RelationSide) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Has\(DiGi\.Core\.Relation\.Enums\.RelationSide\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the relation has a reference on the specified side; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference)'></a>

## ManyToManyRelation\<From,To\>\.Remove\(RelationSide, IUniqueReference\) Method

Removes a unique reference from the specified side of the relation\.

```csharp
public override bool Remove(DiGi.Core.Relation.Enums.RelationSide relationSide, DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to remove the reference from\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to remove\.

Implements [Remove\(RelationSide, IUniqueReference\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Remove\(DiGi\.Core\.Relation\.Enums\.RelationSide, DiGi\.Core\.Interfaces\.IUniqueReference\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the reference was successfully removed; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_)'></a>

## ManyToManyRelation\<From,To\>\.Remove\<TUniqueReference\>\(RelationSide, IEnumerable\<TUniqueReference\>\) Method

Removes multiple unique references from the specified side of the relation\.

```csharp
public override System.Collections.Generic.List<TUniqueReference>? Remove<TUniqueReference>(DiGi.Core.Relation.Enums.RelationSide relationSide, System.Collections.Generic.IEnumerable<TUniqueReference>? uniqueReferences)
    where TUniqueReference : DiGi.Core.Interfaces.IUniqueReference;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).TUniqueReference'></a>

`TUniqueReference`

The type of the unique reference\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to remove references from\.

<a name='DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).uniqueReferences'></a>

`uniqueReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TUniqueReference](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).TUniqueReference 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>\.Remove\<TUniqueReference\>\(DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Collections\.Generic\.IEnumerable\<TUniqueReference\>\)\.TUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references to remove\.

Implements [Remove&lt;TUniqueReference&gt;\(RelationSide, IEnumerable&lt;TUniqueReference&gt;\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Remove\<TUniqueReference\>\(DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Collections\.Generic\.IEnumerable\<TUniqueReference\>\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TUniqueReference](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).TUniqueReference 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>\.Remove\<TUniqueReference\>\(DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Collections\.Generic\.IEnumerable\<TUniqueReference\>\)\.TUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of removed unique references, or null if none were removed\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation'></a>

## ManyToOneRelation Class

Represents an abstract many\-to\-one relationship between unique objects\.

```csharp
public abstract class ManyToOneRelation : DiGi.Core.Relation.Classes.ManyToOneRelation<DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IUniqueObject>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Relation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>') → [DiGi\.Core\.Relation\.Classes\.ManyToOneRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>') → ManyToOneRelation
### Constructors

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation.ManyToOneRelation(DiGi.Core.Relation.Classes.ManyToOneRelation)'></a>

## ManyToOneRelation\(ManyToOneRelation\) Constructor

Creates a new instance of the ManyToOneRelation class by copying another instance\.

```csharp
public ManyToOneRelation(DiGi.Core.Relation.Classes.ManyToOneRelation? manyToOneRelation);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation.ManyToOneRelation(DiGi.Core.Relation.Classes.ManyToOneRelation).manyToOneRelation'></a>

`manyToOneRelation` [ManyToOneRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation')

The existing relation instance to copy from\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation.ManyToOneRelation(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueObject_,DiGi.Core.Interfaces.IUniqueObject)'></a>

## ManyToOneRelation\(IEnumerable\<IUniqueObject\>, IUniqueObject\) Constructor

Creates a new instance of the ManyToOneRelation class from unique objects\.

```csharp
public ManyToOneRelation(System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueObject>? uniqueObjects_From, DiGi.Core.Interfaces.IUniqueObject? uniqueObject_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation.ManyToOneRelation(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueObject_,DiGi.Core.Interfaces.IUniqueObject).uniqueObjects_From'></a>

`uniqueObjects_From` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique objects representing the 'many' side of the relation\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation.ManyToOneRelation(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueObject_,DiGi.Core.Interfaces.IUniqueObject).uniqueObject_To'></a>

`uniqueObject_To` [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')

The unique object representing the 'one' side of the relation\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation.ManyToOneRelation(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,DiGi.Core.Interfaces.IUniqueReference)'></a>

## ManyToOneRelation\(IEnumerable\<IUniqueReference\>, IUniqueReference\) Constructor

Creates a new instance of the ManyToOneRelation class from unique references\.

```csharp
public ManyToOneRelation(System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueReference>? uniqueReferences_From, DiGi.Core.Interfaces.IUniqueReference? uniqueReference_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation.ManyToOneRelation(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,DiGi.Core.Interfaces.IUniqueReference).uniqueReferences_From'></a>

`uniqueReferences_From` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references representing the 'many' side of the relation\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation.ManyToOneRelation(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,DiGi.Core.Interfaces.IUniqueReference).uniqueReference_To'></a>

`uniqueReference_To` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference representing the 'one' side of the relation\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation.ManyToOneRelation(System.Text.Json.Nodes.JsonObject)'></a>

## ManyToOneRelation\(JsonObject\) Constructor

Creates a new instance of the ManyToOneRelation class from a JSON object\.

```csharp
public ManyToOneRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation.ManyToOneRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to create the relation from\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_'></a>

## ManyToOneRelation\<From,To\> Class

Represents an abstract many\-to\-one relationship between two types of unique objects\.

```csharp
public abstract class ManyToOneRelation<From,To> : DiGi.Core.Relation.Classes.Relation<From, To>, DiGi.Core.Relation.Interfaces.IManyToOneRelation<From, To>, DiGi.Core.Relation.Interfaces.IManyToOneRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation<From, To>
    where From : DiGi.Core.Interfaces.IUniqueObject
    where To : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.From'></a>

`From`

The type of the unique objects on the 'many' side\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.To'></a>

`To`

The type of the unique object on the 'one' side\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Relation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>') → ManyToOneRelation\<From,To\>

Derived  
↳ [ManyToOneRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation')

Implements [DiGi\.Core\.Relation\.Interfaces\.IManyToOneRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToOneRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IManyToOneRelation\<XUniqueObject,YUniqueObject\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToOneRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IManyToOneRelation\<XUniqueObject,YUniqueObject\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToOneRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IManyToOneRelation\<XUniqueObject,YUniqueObject\>'), [IManyToOneRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToOneRelation 'DiGi\.Core\.Relation\.Interfaces\.IManyToOneRelation'), [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')
### Constructors

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.ManyToOneRelation(DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_)'></a>

## ManyToOneRelation\(ManyToOneRelation\<From,To\>\) Constructor

Creates a new instance of the ManyToOneRelation class by copying another instance\.

```csharp
public ManyToOneRelation(DiGi.Core.Relation.Classes.ManyToOneRelation<From,To>? manyToOneRelation);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.ManyToOneRelation(DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_).manyToOneRelation'></a>

`manyToOneRelation` [DiGi\.Core\.Relation\.Classes\.ManyToOneRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>')

The existing relation to copy from\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.ManyToOneRelation(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,DiGi.Core.Interfaces.IUniqueReference)'></a>

## ManyToOneRelation\(IEnumerable\<IUniqueReference\>, IUniqueReference\) Constructor

Creates a new instance of the ManyToOneRelation class from unique references\.

```csharp
public ManyToOneRelation(System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueReference>? uniqueReferences_From, DiGi.Core.Interfaces.IUniqueReference? uniqueReference_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.ManyToOneRelation(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,DiGi.Core.Interfaces.IUniqueReference).uniqueReferences_From'></a>

`uniqueReferences_From` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references on the 'many' side\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.ManyToOneRelation(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,DiGi.Core.Interfaces.IUniqueReference).uniqueReference_To'></a>

`uniqueReference_To` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference on the 'one' side\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.ManyToOneRelation(System.Collections.Generic.IEnumerable_From_,To)'></a>

## ManyToOneRelation\(IEnumerable\<From\>, To\) Constructor

Creates a new instance of the ManyToOneRelation class from unique objects\.

```csharp
public ManyToOneRelation(System.Collections.Generic.IEnumerable<From>? uniqueObjects_From, To? uniqueObject_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.ManyToOneRelation(System.Collections.Generic.IEnumerable_From_,To).uniqueObjects_From'></a>

`uniqueObjects_From` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>\.From')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique objects on the 'many' side\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.ManyToOneRelation(System.Collections.Generic.IEnumerable_From_,To).uniqueObject_To'></a>

`uniqueObject_To` [To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>\.To')

The unique object on the 'one' side\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.ManyToOneRelation(System.Text.Json.Nodes.JsonObject)'></a>

## ManyToOneRelation\(JsonObject\) Constructor

Creates a new instance of the ManyToOneRelation class from a JSON object\.

```csharp
public ManyToOneRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.ManyToOneRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to create the relation from\.
### Properties

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.UniqueReferences'></a>

## ManyToOneRelation\<From,To\>\.UniqueReferences Property

Gets a list containing all unique references in this relation\.

```csharp
public override System.Collections.Generic.List<DiGi.Core.Interfaces.IUniqueReference>? UniqueReferences { get; }
```

Implements [UniqueReferences](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.UniqueReferences 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.UniqueReferences')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.UniqueReferences_From'></a>

## ManyToOneRelation\<From,To\>\.UniqueReferences\_From Property

Gets a list of unique references on the "from" side of the relation\.

```csharp
public System.Collections.Generic.List<DiGi.Core.Interfaces.IUniqueReference>? UniqueReferences_From { get; }
```

Implements [UniqueReferences\_From](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToOneRelation.UniqueReferences_From 'DiGi\.Core\.Relation\.Interfaces\.IManyToOneRelation\.UniqueReferences\_From')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.UniqueReference_To'></a>

## ManyToOneRelation\<From,To\>\.UniqueReference\_To Property

Gets the unique reference to the target object\.

```csharp
public DiGi.Core.Interfaces.IUniqueReference? UniqueReference_To { get; }
```

Implements [UniqueReference\_To](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToOneRelation.UniqueReference_To 'DiGi\.Core\.Relation\.Interfaces\.IManyToOneRelation\.UniqueReference\_To')

#### Property Value
[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')
### Methods

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.Add(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference)'></a>

## ManyToOneRelation\<From,To\>\.Add\(RelationSide, IUniqueReference\) Method

Adds a unique reference to the specified side of the relation\.

```csharp
public override bool Add(DiGi.Core.Relation.Enums.RelationSide relationSide, DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.Add(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to add the reference to\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.Add(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the reference was successfully added; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference)'></a>

## ManyToOneRelation\<From,To\>\.Contains\(RelationSide, IUniqueReference\) Method

Determines whether the relation contains the specified unique reference on the given side\.

```csharp
public override bool Contains(DiGi.Core.Relation.Enums.RelationSide relationSide, DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to check\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to locate\.

Implements [Contains\(RelationSide, IUniqueReference\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Contains\(DiGi\.Core\.Relation\.Enums\.RelationSide, DiGi\.Core\.Interfaces\.IUniqueReference\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the relation contains the specified unique reference on the given side; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.Has(DiGi.Core.Relation.Enums.RelationSide)'></a>

## ManyToOneRelation\<From,To\>\.Has\(RelationSide\) Method

Determines whether the relation has a reference on the specified side\.

```csharp
public override bool Has(DiGi.Core.Relation.Enums.RelationSide relationSide);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.Has(DiGi.Core.Relation.Enums.RelationSide).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to check\.

Implements [Has\(RelationSide\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Has(DiGi.Core.Relation.Enums.RelationSide) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Has\(DiGi\.Core\.Relation\.Enums\.RelationSide\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the relation has a reference on the specified side; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference)'></a>

## ManyToOneRelation\<From,To\>\.Remove\(RelationSide, IUniqueReference\) Method

Removes a unique reference from the specified side of the relation\.

```csharp
public override bool Remove(DiGi.Core.Relation.Enums.RelationSide relationSide, DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to remove the reference from\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to remove\.

Implements [Remove\(RelationSide, IUniqueReference\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Remove\(DiGi\.Core\.Relation\.Enums\.RelationSide, DiGi\.Core\.Interfaces\.IUniqueReference\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the reference was successfully removed; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_)'></a>

## ManyToOneRelation\<From,To\>\.Remove\<TUniqueReference\>\(RelationSide, IEnumerable\<TUniqueReference\>\) Method

Removes multiple unique references from the specified side of the relation\.

```csharp
public override System.Collections.Generic.List<TUniqueReference>? Remove<TUniqueReference>(DiGi.Core.Relation.Enums.RelationSide relationSide, System.Collections.Generic.IEnumerable<TUniqueReference>? uniqueReferences)
    where TUniqueReference : DiGi.Core.Interfaces.IUniqueReference;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).TUniqueReference'></a>

`TUniqueReference`

The type of the unique reference\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to remove references from\.

<a name='DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).uniqueReferences'></a>

`uniqueReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TUniqueReference](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).TUniqueReference 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>\.Remove\<TUniqueReference\>\(DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Collections\.Generic\.IEnumerable\<TUniqueReference\>\)\.TUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references to remove\.

Implements [Remove&lt;TUniqueReference&gt;\(RelationSide, IEnumerable&lt;TUniqueReference&gt;\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Remove\<TUniqueReference\>\(DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Collections\.Generic\.IEnumerable\<TUniqueReference\>\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TUniqueReference](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).TUniqueReference 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>\.Remove\<TUniqueReference\>\(DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Collections\.Generic\.IEnumerable\<TUniqueReference\>\)\.TUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of removed unique references, or null if none were removed\.

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation'></a>

## OneToManyBidirectionalRelation Class

Represents a bidirectional one\-to\-many relationship between unique objects\.

```csharp
public class OneToManyBidirectionalRelation : DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation<DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IUniqueObject>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Relation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>') → [DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>') → OneToManyBidirectionalRelation
### Constructors

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation.OneToManyBidirectionalRelation(DiGi.Core.Classes.UniqueReference,System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_)'></a>

## OneToManyBidirectionalRelation\(UniqueReference, IEnumerable\<UniqueReference\>\) Constructor

Creates a new instance of the OneToManyBidirectionalRelation class from unique references\.

```csharp
public OneToManyBidirectionalRelation(DiGi.Core.Classes.UniqueReference? uniqueReference_From, System.Collections.Generic.IEnumerable<DiGi.Core.Classes.UniqueReference>? uniqueReferences_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation.OneToManyBidirectionalRelation(DiGi.Core.Classes.UniqueReference,System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_).uniqueReference_From'></a>

`uniqueReference_From` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The unique reference for the 'from' side of the relation\.

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation.OneToManyBidirectionalRelation(DiGi.Core.Classes.UniqueReference,System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_).uniqueReferences_To'></a>

`uniqueReferences_To` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references for the 'to' side of the relation\.

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation.OneToManyBidirectionalRelation(DiGi.Core.Interfaces.IUniqueObject,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueObject_)'></a>

## OneToManyBidirectionalRelation\(IUniqueObject, IEnumerable\<IUniqueObject\>\) Constructor

Creates a new instance of the OneToManyBidirectionalRelation class from unique objects\.

```csharp
public OneToManyBidirectionalRelation(DiGi.Core.Interfaces.IUniqueObject? uniqueObject_From, System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueObject>? uniqueObjects_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation.OneToManyBidirectionalRelation(DiGi.Core.Interfaces.IUniqueObject,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueObject_).uniqueObject_From'></a>

`uniqueObject_From` [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')

The unique object for the 'from' side of the relation\.

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation.OneToManyBidirectionalRelation(DiGi.Core.Interfaces.IUniqueObject,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueObject_).uniqueObjects_To'></a>

`uniqueObjects_To` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique objects for the 'to' side of the relation\.

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation.OneToManyBidirectionalRelation(DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation)'></a>

## OneToManyBidirectionalRelation\(OneToManyBidirectionalRelation\) Constructor

Creates a new instance of the OneToManyBidirectionalRelation class by copying another instance\.

```csharp
public OneToManyBidirectionalRelation(DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation? oneToManyBidirectionalRelation);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation.OneToManyBidirectionalRelation(DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation).oneToManyBidirectionalRelation'></a>

`oneToManyBidirectionalRelation` [OneToManyBidirectionalRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation')

The existing relation instance to copy from\.

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation.OneToManyBidirectionalRelation(System.Text.Json.Nodes.JsonObject)'></a>

## OneToManyBidirectionalRelation\(JsonObject\) Constructor

Creates a new instance of the OneToManyBidirectionalRelation class from a JSON object\.

```csharp
public OneToManyBidirectionalRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation.OneToManyBidirectionalRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to create the relation from\.

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_'></a>

## OneToManyBidirectionalRelation\<From,To\> Class

Represents a bidirectional one\-to\-many relationship between two types of unique objects\.

```csharp
public class OneToManyBidirectionalRelation<From,To> : DiGi.Core.Relation.Classes.OneToManyRelation<From, To>, DiGi.Core.Relation.Interfaces.IBidirectionalRelation<From, To>, DiGi.Core.Relation.Interfaces.IBidirectionalRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation<From, To>
    where From : DiGi.Core.Interfaces.IUniqueObject
    where To : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.From'></a>

`From`

The type of the object on the 'one' side of the relation\.

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.To'></a>

`To`

The type of the objects on the 'many' side of the relation\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Relation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>') → OneToManyBidirectionalRelation\<From,To\>

Derived  
↳ [OneToManyBidirectionalRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation')

Implements [DiGi\.Core\.Relation\.Interfaces\.IBidirectionalRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IBidirectionalRelation_X,Y_ 'DiGi\.Core\.Relation\.Interfaces\.IBidirectionalRelation\<X,Y\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IBidirectionalRelation_X,Y_ 'DiGi\.Core\.Relation\.Interfaces\.IBidirectionalRelation\<X,Y\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IBidirectionalRelation_X,Y_ 'DiGi\.Core\.Relation\.Interfaces\.IBidirectionalRelation\<X,Y\>'), [IBidirectionalRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IBidirectionalRelation 'DiGi\.Core\.Relation\.Interfaces\.IBidirectionalRelation'), [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')
### Constructors

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.OneToManyBidirectionalRelation(DiGi.Core.Classes.UniqueReference,System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_)'></a>

## OneToManyBidirectionalRelation\(UniqueReference, IEnumerable\<UniqueReference\>\) Constructor

Creates a new instance of the OneToManyBidirectionalRelation class from unique references\.

```csharp
public OneToManyBidirectionalRelation(DiGi.Core.Classes.UniqueReference? uniqueReference_From, System.Collections.Generic.IEnumerable<DiGi.Core.Classes.UniqueReference>? uniqueReferences_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.OneToManyBidirectionalRelation(DiGi.Core.Classes.UniqueReference,System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_).uniqueReference_From'></a>

`uniqueReference_From` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The unique reference for the 'from' side of the relation\.

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.OneToManyBidirectionalRelation(DiGi.Core.Classes.UniqueReference,System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_).uniqueReferences_To'></a>

`uniqueReferences_To` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references for the 'to' side of the relation\.

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.OneToManyBidirectionalRelation(DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_)'></a>

## OneToManyBidirectionalRelation\(OneToManyBidirectionalRelation\<From,To\>\) Constructor

Creates a new instance of the OneToManyBidirectionalRelation class by copying another instance\.

```csharp
public OneToManyBidirectionalRelation(DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation<From,To>? oneToManyBidirectionalRelation);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.OneToManyBidirectionalRelation(DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_).oneToManyBidirectionalRelation'></a>

`oneToManyBidirectionalRelation` [DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>')

The existing relation instance to copy from\.

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.OneToManyBidirectionalRelation(From,System.Collections.Generic.IEnumerable_To_)'></a>

## OneToManyBidirectionalRelation\(From, IEnumerable\<To\>\) Constructor

Creates a new instance of the OneToManyBidirectionalRelation class from unique objects\.

```csharp
public OneToManyBidirectionalRelation(From? uniqueObject_From, System.Collections.Generic.IEnumerable<To>? uniqueObjects_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.OneToManyBidirectionalRelation(From,System.Collections.Generic.IEnumerable_To_).uniqueObject_From'></a>

`uniqueObject_From` [From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>\.From')

The unique object for the 'from' side of the relation\.

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.OneToManyBidirectionalRelation(From,System.Collections.Generic.IEnumerable_To_).uniqueObjects_To'></a>

`uniqueObjects_To` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>\.To')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique objects for the 'to' side of the relation\.

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.OneToManyBidirectionalRelation(System.Text.Json.Nodes.JsonObject)'></a>

## OneToManyBidirectionalRelation\(JsonObject\) Constructor

Creates a new instance of the OneToManyBidirectionalRelation class from a JSON object\.

```csharp
public OneToManyBidirectionalRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_.OneToManyBidirectionalRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to create the relation from\.

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation'></a>

## OneToManyDirectionalRelation Class

Represents a one\-to\-many directional relationship between IUniqueObject instances\.

```csharp
public class OneToManyDirectionalRelation : DiGi.Core.Relation.Classes.OneToManyRelation<DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IUniqueObject>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Relation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>') → OneToManyDirectionalRelation
### Constructors

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation.OneToManyDirectionalRelation(DiGi.Core.Classes.UniqueReference,System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_)'></a>

## OneToManyDirectionalRelation\(UniqueReference, IEnumerable\<UniqueReference\>\) Constructor

Creates a new instance from unique references\.

```csharp
public OneToManyDirectionalRelation(DiGi.Core.Classes.UniqueReference? uniqueReference_From, System.Collections.Generic.IEnumerable<DiGi.Core.Classes.UniqueReference>? uniqueReferences_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation.OneToManyDirectionalRelation(DiGi.Core.Classes.UniqueReference,System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_).uniqueReference_From'></a>

`uniqueReference_From` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The source unique reference\.

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation.OneToManyDirectionalRelation(DiGi.Core.Classes.UniqueReference,System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_).uniqueReferences_To'></a>

`uniqueReferences_To` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of destination unique references\.

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation.OneToManyDirectionalRelation(DiGi.Core.Interfaces.IUniqueObject,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueObject_)'></a>

## OneToManyDirectionalRelation\(IUniqueObject, IEnumerable\<IUniqueObject\>\) Constructor

Creates a new instance from unique objects\.

```csharp
public OneToManyDirectionalRelation(DiGi.Core.Interfaces.IUniqueObject? uniqueObject_From, System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueObject>? uniqueObjects_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation.OneToManyDirectionalRelation(DiGi.Core.Interfaces.IUniqueObject,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueObject_).uniqueObject_From'></a>

`uniqueObject_From` [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')

The source unique object\.

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation.OneToManyDirectionalRelation(DiGi.Core.Interfaces.IUniqueObject,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueObject_).uniqueObjects_To'></a>

`uniqueObjects_To` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of destination unique objects\.

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation.OneToManyDirectionalRelation(DiGi.Core.Relation.Classes.OneToManyDirectionalRelation)'></a>

## OneToManyDirectionalRelation\(OneToManyDirectionalRelation\) Constructor

Creates a new instance by copying another instance\.

```csharp
public OneToManyDirectionalRelation(DiGi.Core.Relation.Classes.OneToManyDirectionalRelation? oneToManyDirectionalRelation);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation.OneToManyDirectionalRelation(DiGi.Core.Relation.Classes.OneToManyDirectionalRelation).oneToManyDirectionalRelation'></a>

`oneToManyDirectionalRelation` [OneToManyDirectionalRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation')

The existing relation to copy from\.

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation.OneToManyDirectionalRelation(System.Text.Json.Nodes.JsonObject)'></a>

## OneToManyDirectionalRelation\(JsonObject\) Constructor

Creates a new instance from a JSON object\.

```csharp
public OneToManyDirectionalRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation.OneToManyDirectionalRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to create the instance from\.

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_'></a>

## OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\> Class

One To One Directional Relation

```csharp
public class OneToManyDirectionalRelation<XUniqueObject,YUniqueObject> : DiGi.Core.Relation.Classes.OneToManyRelation<XUniqueObject, YUniqueObject>, DiGi.Core.Relation.Interfaces.IDirectionalRelation<XUniqueObject, YUniqueObject>, DiGi.Core.Relation.Interfaces.IDirectionalRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation<XUniqueObject, YUniqueObject>
    where XUniqueObject : DiGi.Core.Interfaces.IUniqueObject
    where YUniqueObject : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.XUniqueObject'></a>

`XUniqueObject`

Parent Unique Object

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.YUniqueObject'></a>

`YUniqueObject`

Related Unique Object

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Relation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[XUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.XUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>\.XUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.YUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>\.YUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>')[XUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.XUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>\.XUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.YUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>\.YUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>') → OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>

Implements [DiGi\.Core\.Relation\.Interfaces\.IDirectionalRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IDirectionalRelation\<XUniqueObject,YUniqueObject\>')[XUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.XUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>\.XUniqueObject')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IDirectionalRelation\<XUniqueObject,YUniqueObject\>')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.YUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>\.YUniqueObject')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IDirectionalRelation\<XUniqueObject,YUniqueObject\>'), [IDirectionalRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IDirectionalRelation 'DiGi\.Core\.Relation\.Interfaces\.IDirectionalRelation'), [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[XUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.XUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>\.XUniqueObject')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.YUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>\.YUniqueObject')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')
### Constructors

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.OneToManyDirectionalRelation(DiGi.Core.Classes.UniqueReference,System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_)'></a>

## OneToManyDirectionalRelation\(UniqueReference, IEnumerable\<UniqueReference\>\) Constructor

Creates a new instance from unique references\.

```csharp
public OneToManyDirectionalRelation(DiGi.Core.Classes.UniqueReference? uniqueReference_From, System.Collections.Generic.IEnumerable<DiGi.Core.Classes.UniqueReference>? uniqueReferences_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.OneToManyDirectionalRelation(DiGi.Core.Classes.UniqueReference,System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_).uniqueReference_From'></a>

`uniqueReference_From` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The source unique reference\.

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.OneToManyDirectionalRelation(DiGi.Core.Classes.UniqueReference,System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_).uniqueReferences_To'></a>

`uniqueReferences_To` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of destination unique references\.

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.OneToManyDirectionalRelation(DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_)'></a>

## OneToManyDirectionalRelation\(OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>\) Constructor

Creates a new instance by copying another instance\.

```csharp
public OneToManyDirectionalRelation(DiGi.Core.Relation.Classes.OneToManyDirectionalRelation<XUniqueObject,YUniqueObject>? oneToManyDirectionalRelation);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.OneToManyDirectionalRelation(DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_).oneToManyDirectionalRelation'></a>

`oneToManyDirectionalRelation` [DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>')[XUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.XUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>\.XUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.YUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>\.YUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>')

The existing relation to copy from\.

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.OneToManyDirectionalRelation(System.Text.Json.Nodes.JsonObject)'></a>

## OneToManyDirectionalRelation\(JsonObject\) Constructor

Creates a new instance from a JSON object\.

```csharp
public OneToManyDirectionalRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.OneToManyDirectionalRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to create the instance from\.

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.OneToManyDirectionalRelation(XUniqueObject,System.Collections.Generic.IEnumerable_YUniqueObject_)'></a>

## OneToManyDirectionalRelation\(XUniqueObject, IEnumerable\<YUniqueObject\>\) Constructor

Creates a new instance from unique objects\.

```csharp
public OneToManyDirectionalRelation(XUniqueObject? uniqueObject_From, System.Collections.Generic.IEnumerable<YUniqueObject>? uniqueObjects_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.OneToManyDirectionalRelation(XUniqueObject,System.Collections.Generic.IEnumerable_YUniqueObject_).uniqueObject_From'></a>

`uniqueObject_From` [XUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.XUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>\.XUniqueObject')

The source unique object\.

<a name='DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.OneToManyDirectionalRelation(XUniqueObject,System.Collections.Generic.IEnumerable_YUniqueObject_).uniqueObjects_To'></a>

`uniqueObjects_To` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_.YUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>\.YUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of destination unique objects\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation'></a>

## OneToManyRelation Class

Represents an abstract one\-to\-many relationship between unique objects\.

```csharp
public abstract class OneToManyRelation : DiGi.Core.Relation.Classes.OneToManyRelation<DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IUniqueObject>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Relation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>') → [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>') → OneToManyRelation
### Constructors

<a name='DiGi.Core.Relation.Classes.OneToManyRelation.OneToManyRelation(DiGi.Core.Interfaces.IUniqueObject,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueObject_)'></a>

## OneToManyRelation\(IUniqueObject, IEnumerable\<IUniqueObject\>\) Constructor

Creates a new instance of the OneToManyRelation class from unique objects\.

```csharp
public OneToManyRelation(DiGi.Core.Interfaces.IUniqueObject? uniqueObject_From, System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueObject>? uniqueObjects_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyRelation.OneToManyRelation(DiGi.Core.Interfaces.IUniqueObject,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueObject_).uniqueObject_From'></a>

`uniqueObject_From` [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')

The source unique object\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation.OneToManyRelation(DiGi.Core.Interfaces.IUniqueObject,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueObject_).uniqueObjects_To'></a>

`uniqueObjects_To` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of destination unique objects\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation.OneToManyRelation(DiGi.Core.Interfaces.IUniqueReference,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_)'></a>

## OneToManyRelation\(IUniqueReference, IEnumerable\<IUniqueReference\>\) Constructor

Creates a new instance of the OneToManyRelation class from unique references\.

```csharp
public OneToManyRelation(DiGi.Core.Interfaces.IUniqueReference? uniqueReference_From, System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueReference>? uniqueReferences_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyRelation.OneToManyRelation(DiGi.Core.Interfaces.IUniqueReference,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_).uniqueReference_From'></a>

`uniqueReference_From` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The source unique reference\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation.OneToManyRelation(DiGi.Core.Interfaces.IUniqueReference,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_).uniqueReferences_To'></a>

`uniqueReferences_To` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of destination unique references\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation.OneToManyRelation(DiGi.Core.Relation.Classes.OneToManyRelation)'></a>

## OneToManyRelation\(OneToManyRelation\) Constructor

Creates a new instance of the OneToManyRelation class by copying another instance\.

```csharp
public OneToManyRelation(DiGi.Core.Relation.Classes.OneToManyRelation? oneToManyRelation);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyRelation.OneToManyRelation(DiGi.Core.Relation.Classes.OneToManyRelation).oneToManyRelation'></a>

`oneToManyRelation` [OneToManyRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation')

The existing relation to copy from\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation.OneToManyRelation(System.Text.Json.Nodes.JsonObject)'></a>

## OneToManyRelation\(JsonObject\) Constructor

Creates a new instance of the OneToManyRelation class from a JSON object\.

```csharp
public OneToManyRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyRelation.OneToManyRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to create the relation from\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_'></a>

## OneToManyRelation\<From,To\> Class

Represents an abstract one\-to\-many relationship between two types of unique objects\.

```csharp
public abstract class OneToManyRelation<From,To> : DiGi.Core.Relation.Classes.Relation<From, To>, DiGi.Core.Relation.Interfaces.IOneToManyRelation<From, To>, DiGi.Core.Relation.Interfaces.IOneToManyRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation<From, To>
    where From : DiGi.Core.Interfaces.IUniqueObject
    where To : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.From'></a>

`From`

The type of the object on the 'one' side of the relation\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.To'></a>

`To`

The type of the objects on the 'many' side of the relation\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Relation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>') → OneToManyRelation\<From,To\>

Derived  
↳ [OneToManyBidirectionalRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>')  
↳ [OneToManyDirectionalRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation')  
↳ [OneToManyDirectionalRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>')  
↳ [OneToManyRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation')

Implements [DiGi\.Core\.Relation\.Interfaces\.IOneToManyRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToManyRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IOneToManyRelation\<XUniqueObject,YUniqueObject\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToManyRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IOneToManyRelation\<XUniqueObject,YUniqueObject\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToManyRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IOneToManyRelation\<XUniqueObject,YUniqueObject\>'), [IOneToManyRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToManyRelation 'DiGi\.Core\.Relation\.Interfaces\.IOneToManyRelation'), [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')
### Constructors

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.OneToManyRelation(DiGi.Core.Interfaces.IUniqueReference,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_)'></a>

## OneToManyRelation\(IUniqueReference, IEnumerable\<IUniqueReference\>\) Constructor

Creates a new instance of the OneToManyRelation class from unique references\.

```csharp
public OneToManyRelation(DiGi.Core.Interfaces.IUniqueReference? uniqueReference_From, System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueReference>? uniqueReferences_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.OneToManyRelation(DiGi.Core.Interfaces.IUniqueReference,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_).uniqueReference_From'></a>

`uniqueReference_From` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference for the single side of the relationship\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.OneToManyRelation(DiGi.Core.Interfaces.IUniqueReference,System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_).uniqueReferences_To'></a>

`uniqueReferences_To` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references for the many side of the relationship\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.OneToManyRelation(DiGi.Core.Relation.Classes.OneToManyRelation_From,To_)'></a>

## OneToManyRelation\(OneToManyRelation\<From,To\>\) Constructor

Creates a new instance of the OneToManyRelation class by copying another instance\.

```csharp
public OneToManyRelation(DiGi.Core.Relation.Classes.OneToManyRelation<From,To>? oneToManyRelation);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.OneToManyRelation(DiGi.Core.Relation.Classes.OneToManyRelation_From,To_).oneToManyRelation'></a>

`oneToManyRelation` [DiGi\.Core\.Relation\.Classes\.OneToManyRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>')

The source relation instance to copy\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.OneToManyRelation(From,System.Collections.Generic.IEnumerable_To_)'></a>

## OneToManyRelation\(From, IEnumerable\<To\>\) Constructor

Creates a new instance of the OneToManyRelation class from unique objects\.

```csharp
public OneToManyRelation(From? uniqueObject_From, System.Collections.Generic.IEnumerable<To>? uniqueObjects_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.OneToManyRelation(From,System.Collections.Generic.IEnumerable_To_).uniqueObject_From'></a>

`uniqueObject_From` [From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>\.From')

The unique object for the single side of the relationship\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.OneToManyRelation(From,System.Collections.Generic.IEnumerable_To_).uniqueObjects_To'></a>

`uniqueObjects_To` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>\.To')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique objects for the many side of the relationship\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.OneToManyRelation(System.Text.Json.Nodes.JsonObject)'></a>

## OneToManyRelation\(JsonObject\) Constructor

Creates a new instance of the OneToManyRelation class from a JSON object\.

```csharp
public OneToManyRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.OneToManyRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the relation from\.
### Properties

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.UniqueReferences'></a>

## OneToManyRelation\<From,To\>\.UniqueReferences Property

Gets a list containing all unique references in this relation\.

```csharp
public override System.Collections.Generic.List<DiGi.Core.Interfaces.IUniqueReference>? UniqueReferences { get; }
```

Implements [UniqueReferences](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.UniqueReferences 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.UniqueReferences')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.UniqueReferences_To'></a>

## OneToManyRelation\<From,To\>\.UniqueReferences\_To Property

Gets a list of unique references on the "to" side of the relation\.

```csharp
public System.Collections.Generic.List<DiGi.Core.Interfaces.IUniqueReference>? UniqueReferences_To { get; }
```

Implements [UniqueReferences\_To](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToManyRelation.UniqueReferences_To 'DiGi\.Core\.Relation\.Interfaces\.IOneToManyRelation\.UniqueReferences\_To')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.UniqueReference_From'></a>

## OneToManyRelation\<From,To\>\.UniqueReference\_From Property

Gets the unique reference from the source object\.

```csharp
public DiGi.Core.Interfaces.IUniqueReference? UniqueReference_From { get; }
```

Implements [UniqueReference\_From](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToManyRelation.UniqueReference_From 'DiGi\.Core\.Relation\.Interfaces\.IOneToManyRelation\.UniqueReference\_From')

#### Property Value
[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')
### Methods

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.Add(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference)'></a>

## OneToManyRelation\<From,To\>\.Add\(RelationSide, IUniqueReference\) Method

Adds a unique reference to the specified side of the relation\.

```csharp
public override bool Add(DiGi.Core.Relation.Enums.RelationSide relationSide, DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.Add(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to add the reference to\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.Add(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the reference was successfully added; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference)'></a>

## OneToManyRelation\<From,To\>\.Contains\(RelationSide, IUniqueReference\) Method

Determines whether the relation contains the specified unique reference on the given side\.

```csharp
public override bool Contains(DiGi.Core.Relation.Enums.RelationSide relationSide, DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to check\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to locate in the relation\.

Implements [Contains\(RelationSide, IUniqueReference\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Contains\(DiGi\.Core\.Relation\.Enums\.RelationSide, DiGi\.Core\.Interfaces\.IUniqueReference\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the relation contains the specified unique reference on the given side; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.Has(DiGi.Core.Relation.Enums.RelationSide)'></a>

## OneToManyRelation\<From,To\>\.Has\(RelationSide\) Method

Determines whether the relation has a reference on the specified side\.

```csharp
public override bool Has(DiGi.Core.Relation.Enums.RelationSide relationSide);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.Has(DiGi.Core.Relation.Enums.RelationSide).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to check\.

Implements [Has\(RelationSide\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Has(DiGi.Core.Relation.Enums.RelationSide) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Has\(DiGi\.Core\.Relation\.Enums\.RelationSide\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the relation has a reference on the specified side; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference)'></a>

## OneToManyRelation\<From,To\>\.Remove\(RelationSide, IUniqueReference\) Method

Removes a unique reference from the specified side of the relation\.

```csharp
public override bool Remove(DiGi.Core.Relation.Enums.RelationSide relationSide, DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to remove the reference from\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to remove\.

Implements [Remove\(RelationSide, IUniqueReference\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Remove\(DiGi\.Core\.Relation\.Enums\.RelationSide, DiGi\.Core\.Interfaces\.IUniqueReference\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the reference was successfully removed; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_)'></a>

## OneToManyRelation\<From,To\>\.Remove\<TUniqueReference\>\(RelationSide, IEnumerable\<TUniqueReference\>\) Method

Removes multiple unique references from the specified side of the relation\.

```csharp
public override System.Collections.Generic.List<TUniqueReference>? Remove<TUniqueReference>(DiGi.Core.Relation.Enums.RelationSide relationSide, System.Collections.Generic.IEnumerable<TUniqueReference>? uniqueReferences)
    where TUniqueReference : DiGi.Core.Interfaces.IUniqueReference;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).TUniqueReference'></a>

`TUniqueReference`

The type of the unique reference\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to remove references from\.

<a name='DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).uniqueReferences'></a>

`uniqueReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TUniqueReference](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).TUniqueReference 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>\.Remove\<TUniqueReference\>\(DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Collections\.Generic\.IEnumerable\<TUniqueReference\>\)\.TUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references to remove\.

Implements [Remove&lt;TUniqueReference&gt;\(RelationSide, IEnumerable&lt;TUniqueReference&gt;\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Remove\<TUniqueReference\>\(DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Collections\.Generic\.IEnumerable\<TUniqueReference\>\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TUniqueReference](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).TUniqueReference 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>\.Remove\<TUniqueReference\>\(DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Collections\.Generic\.IEnumerable\<TUniqueReference\>\)\.TUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of removed unique references, or null if no references were removed\.

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation'></a>

## OneToOneBidirectionalRelation Class

Represents a bidirectional one\-to\-one relationship between two IUniqueObject instances\.

```csharp
public class OneToOneBidirectionalRelation : DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation<DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IUniqueObject>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Relation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>') → [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>') → [DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>') → OneToOneBidirectionalRelation
### Constructors

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation.OneToOneBidirectionalRelation(DiGi.Core.Interfaces.IUniqueObject,DiGi.Core.Interfaces.IUniqueObject)'></a>

## OneToOneBidirectionalRelation\(IUniqueObject, IUniqueObject\) Constructor

Creates a new instance of the OneToOneBidirectionalRelation class from unique objects\.

```csharp
public OneToOneBidirectionalRelation(DiGi.Core.Interfaces.IUniqueObject? uniqueObject_From, DiGi.Core.Interfaces.IUniqueObject? uniqueObject_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation.OneToOneBidirectionalRelation(DiGi.Core.Interfaces.IUniqueObject,DiGi.Core.Interfaces.IUniqueObject).uniqueObject_From'></a>

`uniqueObject_From` [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')

The source unique object\.

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation.OneToOneBidirectionalRelation(DiGi.Core.Interfaces.IUniqueObject,DiGi.Core.Interfaces.IUniqueObject).uniqueObject_To'></a>

`uniqueObject_To` [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')

The destination unique object\.

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation.OneToOneBidirectionalRelation(DiGi.Core.Interfaces.IUniqueReference,DiGi.Core.Interfaces.IUniqueReference)'></a>

## OneToOneBidirectionalRelation\(IUniqueReference, IUniqueReference\) Constructor

Creates a new instance of the OneToOneBidirectionalRelation class from unique references\.

```csharp
public OneToOneBidirectionalRelation(DiGi.Core.Interfaces.IUniqueReference? uniqueReference_From, DiGi.Core.Interfaces.IUniqueReference? uniqueReference_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation.OneToOneBidirectionalRelation(DiGi.Core.Interfaces.IUniqueReference,DiGi.Core.Interfaces.IUniqueReference).uniqueReference_From'></a>

`uniqueReference_From` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The source unique reference\.

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation.OneToOneBidirectionalRelation(DiGi.Core.Interfaces.IUniqueReference,DiGi.Core.Interfaces.IUniqueReference).uniqueReference_To'></a>

`uniqueReference_To` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The destination unique reference\.

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation.OneToOneBidirectionalRelation(DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation)'></a>

## OneToOneBidirectionalRelation\(OneToOneBidirectionalRelation\) Constructor

Creates a new instance of the OneToOneBidirectionalRelation class by copying another instance\.

```csharp
public OneToOneBidirectionalRelation(DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation? oneToOneBidirectionalRelation);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation.OneToOneBidirectionalRelation(DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation).oneToOneBidirectionalRelation'></a>

`oneToOneBidirectionalRelation` [OneToOneBidirectionalRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation')

The existing relation to copy from\.

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation.OneToOneBidirectionalRelation(System.Text.Json.Nodes.JsonObject)'></a>

## OneToOneBidirectionalRelation\(JsonObject\) Constructor

Creates a new instance of the OneToOneBidirectionalRelation class from a JSON object\.

```csharp
public OneToOneBidirectionalRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation.OneToOneBidirectionalRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to create the relation from\.

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_'></a>

## OneToOneBidirectionalRelation\<From,To\> Class

Represents a bidirectional one\-to\-one relationship between two unique object instances\.

```csharp
public class OneToOneBidirectionalRelation<From,To> : DiGi.Core.Relation.Classes.OneToOneRelation<From, To>, DiGi.Core.Relation.Interfaces.IBidirectionalRelation<From, To>, DiGi.Core.Relation.Interfaces.IBidirectionalRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation<From, To>
    where From : DiGi.Core.Interfaces.IUniqueObject
    where To : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.From'></a>

`From`

The type of the source object\.

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.To'></a>

`To`

The type of the destination object\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Relation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>') → [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>') → OneToOneBidirectionalRelation\<From,To\>

Derived  
↳ [OneToOneBidirectionalRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation')

Implements [DiGi\.Core\.Relation\.Interfaces\.IBidirectionalRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IBidirectionalRelation_X,Y_ 'DiGi\.Core\.Relation\.Interfaces\.IBidirectionalRelation\<X,Y\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IBidirectionalRelation_X,Y_ 'DiGi\.Core\.Relation\.Interfaces\.IBidirectionalRelation\<X,Y\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IBidirectionalRelation_X,Y_ 'DiGi\.Core\.Relation\.Interfaces\.IBidirectionalRelation\<X,Y\>'), [IBidirectionalRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IBidirectionalRelation 'DiGi\.Core\.Relation\.Interfaces\.IBidirectionalRelation'), [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')
### Constructors

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.OneToOneBidirectionalRelation(DiGi.Core.Interfaces.IUniqueReference,DiGi.Core.Interfaces.IUniqueReference)'></a>

## OneToOneBidirectionalRelation\(IUniqueReference, IUniqueReference\) Constructor

Creates a new instance of the OneToOneBidirectionalRelation class from unique references\.

```csharp
public OneToOneBidirectionalRelation(DiGi.Core.Interfaces.IUniqueReference? uniqueReference_From, DiGi.Core.Interfaces.IUniqueReference? uniqueReference_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.OneToOneBidirectionalRelation(DiGi.Core.Interfaces.IUniqueReference,DiGi.Core.Interfaces.IUniqueReference).uniqueReference_From'></a>

`uniqueReference_From` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The source unique reference\.

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.OneToOneBidirectionalRelation(DiGi.Core.Interfaces.IUniqueReference,DiGi.Core.Interfaces.IUniqueReference).uniqueReference_To'></a>

`uniqueReference_To` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The destination unique reference\.

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.OneToOneBidirectionalRelation(DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_)'></a>

## OneToOneBidirectionalRelation\(OneToOneBidirectionalRelation\<From,To\>\) Constructor

Creates a new instance of the OneToOneBidirectionalRelation class by copying another instance\.

```csharp
public OneToOneBidirectionalRelation(DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation<From,To>? oneToOneBidirectionalRelation);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.OneToOneBidirectionalRelation(DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_).oneToOneBidirectionalRelation'></a>

`oneToOneBidirectionalRelation` [DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>')

The existing relation to copy from\.

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.OneToOneBidirectionalRelation(From,To)'></a>

## OneToOneBidirectionalRelation\(From, To\) Constructor

Creates a new instance of the OneToOneBidirectionalRelation class from unique objects\.

```csharp
public OneToOneBidirectionalRelation(From? uniqueObject_From, To? uniqueObject_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.OneToOneBidirectionalRelation(From,To).uniqueObject_From'></a>

`uniqueObject_From` [From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>\.From')

The source unique object\.

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.OneToOneBidirectionalRelation(From,To).uniqueObject_To'></a>

`uniqueObject_To` [To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>\.To')

The destination unique object\.

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.OneToOneBidirectionalRelation(System.Text.Json.Nodes.JsonObject)'></a>

## OneToOneBidirectionalRelation\(JsonObject\) Constructor

Creates a new instance of the OneToOneBidirectionalRelation class from a JSON object\.

```csharp
public OneToOneBidirectionalRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_.OneToOneBidirectionalRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to create the relation from\.

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation'></a>

## OneToOneDirectionalRelation Class

Represents a one\-to\-one directional relationship between IUniqueObject instances\.

```csharp
public class OneToOneDirectionalRelation : DiGi.Core.Relation.Classes.OneToOneRelation<DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IUniqueObject>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Relation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>') → [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>') → OneToOneDirectionalRelation
### Constructors

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation.OneToOneDirectionalRelation(DiGi.Core.Classes.UniqueReference,DiGi.Core.Classes.UniqueReference)'></a>

## OneToOneDirectionalRelation\(UniqueReference, UniqueReference\) Constructor

Creates a new instance from unique references\.

```csharp
public OneToOneDirectionalRelation(DiGi.Core.Classes.UniqueReference? uniqueReference_From, DiGi.Core.Classes.UniqueReference? uniqueReference_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation.OneToOneDirectionalRelation(DiGi.Core.Classes.UniqueReference,DiGi.Core.Classes.UniqueReference).uniqueReference_From'></a>

`uniqueReference_From` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The source unique reference\.

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation.OneToOneDirectionalRelation(DiGi.Core.Classes.UniqueReference,DiGi.Core.Classes.UniqueReference).uniqueReference_To'></a>

`uniqueReference_To` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The destination unique reference\.

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation.OneToOneDirectionalRelation(DiGi.Core.Interfaces.IUniqueObject,DiGi.Core.Interfaces.IUniqueObject)'></a>

## OneToOneDirectionalRelation\(IUniqueObject, IUniqueObject\) Constructor

Creates a new instance from unique objects\.

```csharp
public OneToOneDirectionalRelation(DiGi.Core.Interfaces.IUniqueObject? uniqueObject_From, DiGi.Core.Interfaces.IUniqueObject? uniqueObject_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation.OneToOneDirectionalRelation(DiGi.Core.Interfaces.IUniqueObject,DiGi.Core.Interfaces.IUniqueObject).uniqueObject_From'></a>

`uniqueObject_From` [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')

The source unique object\.

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation.OneToOneDirectionalRelation(DiGi.Core.Interfaces.IUniqueObject,DiGi.Core.Interfaces.IUniqueObject).uniqueObject_To'></a>

`uniqueObject_To` [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')

The destination unique object\.

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation.OneToOneDirectionalRelation(DiGi.Core.Relation.Classes.OneToOneDirectionalRelation)'></a>

## OneToOneDirectionalRelation\(OneToOneDirectionalRelation\) Constructor

Creates a new instance by copying another instance\.

```csharp
public OneToOneDirectionalRelation(DiGi.Core.Relation.Classes.OneToOneDirectionalRelation? oneToOneDirectionalRelation);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation.OneToOneDirectionalRelation(DiGi.Core.Relation.Classes.OneToOneDirectionalRelation).oneToOneDirectionalRelation'></a>

`oneToOneDirectionalRelation` [OneToOneDirectionalRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation')

The relation instance to copy from\.

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation.OneToOneDirectionalRelation(System.Text.Json.Nodes.JsonObject)'></a>

## OneToOneDirectionalRelation\(JsonObject\) Constructor

Creates a new instance from a JSON object\.

```csharp
public OneToOneDirectionalRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation.OneToOneDirectionalRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to create the instance from\.
### Methods

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation.Clone()'></a>

## OneToOneDirectionalRelation\.Clone\(\) Method

Creates a shallow copy of this relation\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A shallow copy of the current relation as an [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_'></a>

## OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\> Class

One To One Directional Relation

```csharp
public class OneToOneDirectionalRelation<XUniqueObject,YUniqueObject> : DiGi.Core.Relation.Classes.OneToOneRelation<XUniqueObject, YUniqueObject>, DiGi.Core.Relation.Interfaces.IDirectionalRelation<XUniqueObject, YUniqueObject>, DiGi.Core.Relation.Interfaces.IDirectionalRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation<XUniqueObject, YUniqueObject>
    where XUniqueObject : DiGi.Core.Interfaces.IUniqueObject
    where YUniqueObject : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.XUniqueObject'></a>

`XUniqueObject`

Parent Unique Object

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.YUniqueObject'></a>

`YUniqueObject`

Related Unique Object

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Relation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[XUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.XUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>\.XUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.YUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>\.YUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>') → [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>')[XUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.XUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>\.XUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.YUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>\.YUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>') → OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>

Implements [DiGi\.Core\.Relation\.Interfaces\.IDirectionalRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IDirectionalRelation\<XUniqueObject,YUniqueObject\>')[XUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.XUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>\.XUniqueObject')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IDirectionalRelation\<XUniqueObject,YUniqueObject\>')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.YUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>\.YUniqueObject')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IDirectionalRelation\<XUniqueObject,YUniqueObject\>'), [IDirectionalRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IDirectionalRelation 'DiGi\.Core\.Relation\.Interfaces\.IDirectionalRelation'), [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[XUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.XUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>\.XUniqueObject')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.YUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>\.YUniqueObject')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')
### Constructors

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.OneToOneDirectionalRelation(DiGi.Core.Classes.UniqueReference,DiGi.Core.Classes.UniqueReference)'></a>

## OneToOneDirectionalRelation\(UniqueReference, UniqueReference\) Constructor

Creates a new instance from unique references\.

```csharp
public OneToOneDirectionalRelation(DiGi.Core.Classes.UniqueReference? uniqueReference_From, DiGi.Core.Classes.UniqueReference? uniqueReference_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.OneToOneDirectionalRelation(DiGi.Core.Classes.UniqueReference,DiGi.Core.Classes.UniqueReference).uniqueReference_From'></a>

`uniqueReference_From` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The source unique reference\.

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.OneToOneDirectionalRelation(DiGi.Core.Classes.UniqueReference,DiGi.Core.Classes.UniqueReference).uniqueReference_To'></a>

`uniqueReference_To` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The destination unique reference\.

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.OneToOneDirectionalRelation(DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_)'></a>

## OneToOneDirectionalRelation\(OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>\) Constructor

Creates a new instance by copying another instance\.

```csharp
public OneToOneDirectionalRelation(DiGi.Core.Relation.Classes.OneToOneDirectionalRelation<XUniqueObject,YUniqueObject>? oneToOneDirectionalRelation);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.OneToOneDirectionalRelation(DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_).oneToOneDirectionalRelation'></a>

`oneToOneDirectionalRelation` [DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>')[XUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.XUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>\.XUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.YUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>\.YUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>')

The relation instance to copy from\.

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.OneToOneDirectionalRelation(System.Text.Json.Nodes.JsonObject)'></a>

## OneToOneDirectionalRelation\(JsonObject\) Constructor

Creates a new instance from a JSON object\.

```csharp
public OneToOneDirectionalRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.OneToOneDirectionalRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to create the instance from\.

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.OneToOneDirectionalRelation(XUniqueObject,YUniqueObject)'></a>

## OneToOneDirectionalRelation\(XUniqueObject, YUniqueObject\) Constructor

Creates a new instance from unique objects\.

```csharp
public OneToOneDirectionalRelation(XUniqueObject? uniqueObject_From, YUniqueObject? uniqueObject_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.OneToOneDirectionalRelation(XUniqueObject,YUniqueObject).uniqueObject_From'></a>

`uniqueObject_From` [XUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.XUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>\.XUniqueObject')

The source unique object\.

<a name='DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.OneToOneDirectionalRelation(XUniqueObject,YUniqueObject).uniqueObject_To'></a>

`uniqueObject_To` [YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_.YUniqueObject 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>\.YUniqueObject')

The destination unique object\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation'></a>

## OneToOneRelation Class

Represents a one\-to\-one relationship between two IUniqueObject instances\.

```csharp
public abstract class OneToOneRelation : DiGi.Core.Relation.Classes.OneToOneRelation<DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IUniqueObject>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Relation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>') → [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>')[DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>') → OneToOneRelation
### Constructors

<a name='DiGi.Core.Relation.Classes.OneToOneRelation.OneToOneRelation(DiGi.Core.Classes.UniqueReference,DiGi.Core.Classes.UniqueReference)'></a>

## OneToOneRelation\(UniqueReference, UniqueReference\) Constructor

Creates a new instance of the OneToOneRelation class from unique references\.

```csharp
public OneToOneRelation(DiGi.Core.Classes.UniqueReference? uniqueReference_From, DiGi.Core.Classes.UniqueReference? uniqueReference_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneRelation.OneToOneRelation(DiGi.Core.Classes.UniqueReference,DiGi.Core.Classes.UniqueReference).uniqueReference_From'></a>

`uniqueReference_From` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The source unique reference for the relation\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation.OneToOneRelation(DiGi.Core.Classes.UniqueReference,DiGi.Core.Classes.UniqueReference).uniqueReference_To'></a>

`uniqueReference_To` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The destination unique reference for the relation\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation.OneToOneRelation(DiGi.Core.Interfaces.IUniqueObject,DiGi.Core.Interfaces.IUniqueObject)'></a>

## OneToOneRelation\(IUniqueObject, IUniqueObject\) Constructor

Creates a new instance of the OneToOneRelation class from unique objects\.

```csharp
public OneToOneRelation(DiGi.Core.Interfaces.IUniqueObject? uniqueObject_From, DiGi.Core.Interfaces.IUniqueObject? uniqueObject_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneRelation.OneToOneRelation(DiGi.Core.Interfaces.IUniqueObject,DiGi.Core.Interfaces.IUniqueObject).uniqueObject_From'></a>

`uniqueObject_From` [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')

The source unique object for the relation\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation.OneToOneRelation(DiGi.Core.Interfaces.IUniqueObject,DiGi.Core.Interfaces.IUniqueObject).uniqueObject_To'></a>

`uniqueObject_To` [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')

The destination unique object for the relation\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation.OneToOneRelation(DiGi.Core.Relation.Classes.OneToOneRelation)'></a>

## OneToOneRelation\(OneToOneRelation\) Constructor

Creates a new instance of the OneToOneRelation class by copying another instance\.

```csharp
public OneToOneRelation(DiGi.Core.Relation.Classes.OneToOneRelation? oneToOneRelation);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneRelation.OneToOneRelation(DiGi.Core.Relation.Classes.OneToOneRelation).oneToOneRelation'></a>

`oneToOneRelation` [OneToOneRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation')

The existing OneToOneRelation instance to copy from\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation.OneToOneRelation(System.Text.Json.Nodes.JsonObject)'></a>

## OneToOneRelation\(JsonObject\) Constructor

Creates a new instance of the OneToOneRelation class from a JSON object\.

```csharp
public OneToOneRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneRelation.OneToOneRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the relation\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_'></a>

## OneToOneRelation\<From,To\> Class

Represents a one\-to\-one relationship between two unique object instances\.

```csharp
public abstract class OneToOneRelation<From,To> : DiGi.Core.Relation.Classes.Relation<From, To>, DiGi.Core.Relation.Interfaces.IOneToOneRelation<From, To>, DiGi.Core.Relation.Interfaces.IOneToOneRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation<From, To>
    where From : DiGi.Core.Interfaces.IUniqueObject
    where To : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.From'></a>

`From`

The type of the source object\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.To'></a>

`To`

The type of the target object\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Relation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation 'DiGi\.Core\.Relation\.Classes\.Relation') → [DiGi\.Core\.Relation\.Classes\.Relation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>') → OneToOneRelation\<From,To\>

Derived  
↳ [OneToOneBidirectionalRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>')  
↳ [OneToOneDirectionalRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation')  
↳ [OneToOneDirectionalRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>')  
↳ [OneToOneRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation')

Implements [DiGi\.Core\.Relation\.Interfaces\.IOneToOneRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToOneRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IOneToOneRelation\<XUniqueObject,YUniqueObject\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToOneRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IOneToOneRelation\<XUniqueObject,YUniqueObject\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToOneRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IOneToOneRelation\<XUniqueObject,YUniqueObject\>'), [IOneToOneRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToOneRelation 'DiGi\.Core\.Relation\.Interfaces\.IOneToOneRelation'), [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')
### Constructors

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.OneToOneRelation(DiGi.Core.Interfaces.IUniqueReference,DiGi.Core.Interfaces.IUniqueReference)'></a>

## OneToOneRelation\(IUniqueReference, IUniqueReference\) Constructor

Creates a new instance of the OneToOneRelation class from unique references\.

```csharp
public OneToOneRelation(DiGi.Core.Interfaces.IUniqueReference? uniqueReference_From, DiGi.Core.Interfaces.IUniqueReference? uniqueReference_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.OneToOneRelation(DiGi.Core.Interfaces.IUniqueReference,DiGi.Core.Interfaces.IUniqueReference).uniqueReference_From'></a>

`uniqueReference_From` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The source unique reference\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.OneToOneRelation(DiGi.Core.Interfaces.IUniqueReference,DiGi.Core.Interfaces.IUniqueReference).uniqueReference_To'></a>

`uniqueReference_To` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The target unique reference\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.OneToOneRelation(DiGi.Core.Relation.Classes.OneToOneRelation_From,To_)'></a>

## OneToOneRelation\(OneToOneRelation\<From,To\>\) Constructor

Creates a new instance of the OneToOneRelation class by copying another instance\.

```csharp
public OneToOneRelation(DiGi.Core.Relation.Classes.OneToOneRelation<From,To>? oneToOneRelation);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.OneToOneRelation(DiGi.Core.Relation.Classes.OneToOneRelation_From,To_).oneToOneRelation'></a>

`oneToOneRelation` [DiGi\.Core\.Relation\.Classes\.OneToOneRelation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>\.From')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>')

The existing relation to copy from\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.OneToOneRelation(From,To)'></a>

## OneToOneRelation\(From, To\) Constructor

Creates a new instance of the OneToOneRelation class from unique objects\.

```csharp
public OneToOneRelation(From? uniqueObject_From, To? uniqueObject_To);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.OneToOneRelation(From,To).uniqueObject_From'></a>

`uniqueObject_From` [From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>\.From')

The source unique object\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.OneToOneRelation(From,To).uniqueObject_To'></a>

`uniqueObject_To` [To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>\.To')

The target unique object\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.OneToOneRelation(System.Text.Json.Nodes.JsonObject)'></a>

## OneToOneRelation\(JsonObject\) Constructor

Creates a new instance of the OneToOneRelation class from a JSON object\.

```csharp
public OneToOneRelation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.OneToOneRelation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to create the relation from\.
### Properties

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.UniqueReferences'></a>

## OneToOneRelation\<From,To\>\.UniqueReferences Property

Gets a list containing all unique references in this relation\.

```csharp
public override System.Collections.Generic.List<DiGi.Core.Interfaces.IUniqueReference>? UniqueReferences { get; }
```

Implements [UniqueReferences](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.UniqueReferences 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.UniqueReferences')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.UniqueReference_From'></a>

## OneToOneRelation\<From,To\>\.UniqueReference\_From Property

Gets the unique reference from the source object\.

```csharp
public DiGi.Core.Interfaces.IUniqueReference? UniqueReference_From { get; }
```

Implements [UniqueReference\_From](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToOneRelation.UniqueReference_From 'DiGi\.Core\.Relation\.Interfaces\.IOneToOneRelation\.UniqueReference\_From')

#### Property Value
[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.UniqueReference_To'></a>

## OneToOneRelation\<From,To\>\.UniqueReference\_To Property

Gets the unique reference to the target object\.

```csharp
public DiGi.Core.Interfaces.IUniqueReference? UniqueReference_To { get; }
```

Implements [UniqueReference\_To](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToOneRelation.UniqueReference_To 'DiGi\.Core\.Relation\.Interfaces\.IOneToOneRelation\.UniqueReference\_To')

#### Property Value
[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')
### Methods

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.Add(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference)'></a>

## OneToOneRelation\<From,To\>\.Add\(RelationSide, IUniqueReference\) Method

Adds a unique reference to the specified side of the relation\.

```csharp
public override bool Add(DiGi.Core.Relation.Enums.RelationSide relationSide, DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.Add(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to add the reference to\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.Add(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the reference was successfully added; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference)'></a>

## OneToOneRelation\<From,To\>\.Contains\(RelationSide, IUniqueReference\) Method

Determines whether the relation contains the specified unique reference on the given side\.

```csharp
public override bool Contains(DiGi.Core.Relation.Enums.RelationSide relationSide, DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to check\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to locate\.

Implements [Contains\(RelationSide, IUniqueReference\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Contains\(DiGi\.Core\.Relation\.Enums\.RelationSide, DiGi\.Core\.Interfaces\.IUniqueReference\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the relation contains the specified unique reference on the given side; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.Has(DiGi.Core.Relation.Enums.RelationSide)'></a>

## OneToOneRelation\<From,To\>\.Has\(RelationSide\) Method

Determines whether the relation has a reference on the specified side\.

```csharp
public override bool Has(DiGi.Core.Relation.Enums.RelationSide relationSide);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.Has(DiGi.Core.Relation.Enums.RelationSide).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to check\.

Implements [Has\(RelationSide\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Has(DiGi.Core.Relation.Enums.RelationSide) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Has\(DiGi\.Core\.Relation\.Enums\.RelationSide\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the relation has a reference on the specified side; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference)'></a>

## OneToOneRelation\<From,To\>\.Remove\(RelationSide, IUniqueReference\) Method

Removes a unique reference from the specified side of the relation\.

```csharp
public override bool Remove(DiGi.Core.Relation.Enums.RelationSide relationSide, DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to remove the reference from\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to remove\.

Implements [Remove\(RelationSide, IUniqueReference\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Remove\(DiGi\.Core\.Relation\.Enums\.RelationSide, DiGi\.Core\.Interfaces\.IUniqueReference\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the reference was successfully removed; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_)'></a>

## OneToOneRelation\<From,To\>\.Remove\<TUniqueReference\>\(RelationSide, IEnumerable\<TUniqueReference\>\) Method

Removes multiple unique references from the specified side of the relation\.

```csharp
public override System.Collections.Generic.List<TUniqueReference>? Remove<TUniqueReference>(DiGi.Core.Relation.Enums.RelationSide relationSide, System.Collections.Generic.IEnumerable<TUniqueReference>? uniqueReferences)
    where TUniqueReference : DiGi.Core.Interfaces.IUniqueReference;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).TUniqueReference'></a>

`TUniqueReference`

The type of the unique reference\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to remove references from\.

<a name='DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).uniqueReferences'></a>

`uniqueReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TUniqueReference](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).TUniqueReference 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>\.Remove\<TUniqueReference\>\(DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Collections\.Generic\.IEnumerable\<TUniqueReference\>\)\.TUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references to remove\.

Implements [Remove&lt;TUniqueReference&gt;\(RelationSide, IEnumerable&lt;TUniqueReference&gt;\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Remove\<TUniqueReference\>\(DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Collections\.Generic\.IEnumerable\<TUniqueReference\>\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TUniqueReference](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).TUniqueReference 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>\.Remove\<TUniqueReference\>\(DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Collections\.Generic\.IEnumerable\<TUniqueReference\>\)\.TUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of removed unique references, or null if none were removed\.

<a name='DiGi.Core.Relation.Classes.Relation'></a>

## Relation Class

Represents an abstract relationship between unique objects\.

```csharp
public abstract class Relation : DiGi.Core.Classes.SerializableObject, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Relation

Derived  
↳ [Relation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')

Implements [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Relation.Classes.Relation.Relation()'></a>

## Relation\(\) Constructor

Creates a new instance of the Relation class\.

```csharp
public Relation();
```

<a name='DiGi.Core.Relation.Classes.Relation.Relation(DiGi.Core.Relation.Classes.Relation)'></a>

## Relation\(Relation\) Constructor

Creates a new instance of the Relation class by copying another instance\.

```csharp
public Relation(DiGi.Core.Relation.Classes.Relation? relation);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.Relation.Relation(DiGi.Core.Relation.Classes.Relation).relation'></a>

`relation` [Relation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation 'DiGi\.Core\.Relation\.Classes\.Relation')

The relation instance to copy from\.

<a name='DiGi.Core.Relation.Classes.Relation.Relation(System.Text.Json.Nodes.JsonObject)'></a>

## Relation\(JsonObject\) Constructor

Creates a new instance of the Relation class from a JSON object\.

```csharp
public Relation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.Relation.Relation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to create the relation from\.
### Properties

<a name='DiGi.Core.Relation.Classes.Relation.UniqueReferences'></a>

## Relation\.UniqueReferences Property

Gets a list containing all unique references in this relation\.

```csharp
public abstract System.Collections.Generic.List<DiGi.Core.Interfaces.IUniqueReference>? UniqueReferences { get; }
```

Implements [UniqueReferences](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.UniqueReferences 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.UniqueReferences')

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.Core.Relation.Classes.Relation.Add(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference)'></a>

## Relation\.Add\(RelationSide, IUniqueReference\) Method

Adds a unique reference to the specified side of the relation\.

```csharp
public abstract bool Add(DiGi.Core.Relation.Enums.RelationSide relationSide, DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.Relation.Add(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation where the reference should be added\.

<a name='DiGi.Core.Relation.Classes.Relation.Add(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the reference was successfully added; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.Relation.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference)'></a>

## Relation\.Contains\(RelationSide, IUniqueReference\) Method

Determines whether the relation contains the specified unique reference on the given side\.

```csharp
public abstract bool Contains(DiGi.Core.Relation.Enums.RelationSide relationSide, DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.Relation.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to search\.

<a name='DiGi.Core.Relation.Classes.Relation.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to locate within the relation\.

Implements [Contains\(RelationSide, IUniqueReference\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Contains\(DiGi\.Core\.Relation\.Enums\.RelationSide, DiGi\.Core\.Interfaces\.IUniqueReference\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified unique reference is found on the given side; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.Relation.GetType(DiGi.Core.Relation.Enums.RelationSide)'></a>

## Relation\.GetType\(RelationSide\) Method

Gets the type of the object on the specified side of the relation\.

```csharp
public abstract System.Type? GetType(DiGi.Core.Relation.Enums.RelationSide relationSide);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.Relation.GetType(DiGi.Core.Relation.Enums.RelationSide).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to retrieve the type for\.

Implements [GetType\(RelationSide\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.GetType(DiGi.Core.Relation.Enums.RelationSide) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.GetType\(DiGi\.Core\.Relation\.Enums\.RelationSide\)')

#### Returns
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')  
The type of the object on the specified side, or null if no type is associated with that side\.

<a name='DiGi.Core.Relation.Classes.Relation.Has(DiGi.Core.Relation.Enums.RelationSide)'></a>

## Relation\.Has\(RelationSide\) Method

Determines whether the relation has a reference on the specified side\.

```csharp
public abstract bool Has(DiGi.Core.Relation.Enums.RelationSide relationSide);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.Relation.Has(DiGi.Core.Relation.Enums.RelationSide).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to check for a reference\.

Implements [Has\(RelationSide\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Has(DiGi.Core.Relation.Enums.RelationSide) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Has\(DiGi\.Core\.Relation\.Enums\.RelationSide\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the relation has a reference on the specified side; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.Relation.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference)'></a>

## Relation\.Remove\(RelationSide, IUniqueReference\) Method

Removes a unique reference from the specified side of the relation\.

```csharp
public abstract bool Remove(DiGi.Core.Relation.Enums.RelationSide relationSide, DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.Relation.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to remove the reference from\.

<a name='DiGi.Core.Relation.Classes.Relation.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to remove\.

Implements [Remove\(RelationSide, IUniqueReference\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Remove\(DiGi\.Core\.Relation\.Enums\.RelationSide, DiGi\.Core\.Interfaces\.IUniqueReference\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the reference was successfully removed; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.Relation.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_)'></a>

## Relation\.Remove\<TUniqueReference\>\(RelationSide, IEnumerable\<TUniqueReference\>\) Method

Removes multiple unique references from the specified side of the relation\.

```csharp
public abstract System.Collections.Generic.List<TUniqueReference>? Remove<TUniqueReference>(DiGi.Core.Relation.Enums.RelationSide relationSide, System.Collections.Generic.IEnumerable<TUniqueReference>? uniqueReferences)
    where TUniqueReference : DiGi.Core.Interfaces.IUniqueReference;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.Relation.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).TUniqueReference'></a>

`TUniqueReference`

The type of the unique reference being removed\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.Relation.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation from which to remove references\.

<a name='DiGi.Core.Relation.Classes.Relation.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).uniqueReferences'></a>

`uniqueReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TUniqueReference](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).TUniqueReference 'DiGi\.Core\.Relation\.Classes\.Relation\.Remove\<TUniqueReference\>\(DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Collections\.Generic\.IEnumerable\<TUniqueReference\>\)\.TUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references to be removed\.

Implements [Remove&lt;TUniqueReference&gt;\(RelationSide, IEnumerable&lt;TUniqueReference&gt;\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Remove\<TUniqueReference\>\(DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Collections\.Generic\.IEnumerable\<TUniqueReference\>\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TUniqueReference](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).TUniqueReference 'DiGi\.Core\.Relation\.Classes\.Relation\.Remove\<TUniqueReference\>\(DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Collections\.Generic\.IEnumerable\<TUniqueReference\>\)\.TUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of the removed unique references, or `null` if no references were removed\.

<a name='DiGi.Core.Relation.Classes.Relation_From,To_'></a>

## Relation\<From,To\> Class

Represents an abstract relationship between two types of unique objects\.

```csharp
public abstract class Relation<From,To> : DiGi.Core.Relation.Classes.Relation, DiGi.Core.Relation.Interfaces.IRelation<From, To>, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
    where From : DiGi.Core.Interfaces.IUniqueObject
    where To : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.Relation_From,To_.From'></a>

`From`

The type of the source object in the relation\.

<a name='DiGi.Core.Relation.Classes.Relation_From,To_.To'></a>

`To`

The type of the destination object in the relation\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Relation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation 'DiGi\.Core\.Relation\.Classes\.Relation') → Relation\<From,To\>

Derived  
↳ [ManyToManyRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>')  
↳ [ManyToOneRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>')  
↳ [OneToManyRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>')  
↳ [OneToOneRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>')

Implements [DiGi\.Core\.Relation\.Interfaces\.IRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>\.From')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>'), [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.Relation.Classes.Relation_From,To_.Relation()'></a>

## Relation\(\) Constructor

Creates a new instance of the Relation class\.

```csharp
public Relation();
```

<a name='DiGi.Core.Relation.Classes.Relation_From,To_.Relation(DiGi.Core.Relation.Classes.Relation_From,To_)'></a>

## Relation\(Relation\<From,To\>\) Constructor

Creates a new instance of the Relation class by copying another instance\.

```csharp
public Relation(DiGi.Core.Relation.Classes.Relation<From,To>? relation);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.Relation_From,To_.Relation(DiGi.Core.Relation.Classes.Relation_From,To_).relation'></a>

`relation` [DiGi\.Core\.Relation\.Classes\.Relation&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[From](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_.From 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>\.From')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')[To](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_.To 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>\.To')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')

The relation instance to copy from\.

<a name='DiGi.Core.Relation.Classes.Relation_From,To_.Relation(System.Text.Json.Nodes.JsonObject)'></a>

## Relation\(JsonObject\) Constructor

Creates a new instance of the Relation class from a JSON object\.

```csharp
public Relation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.Relation_From,To_.Relation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the relation from\.
### Methods

<a name='DiGi.Core.Relation.Classes.Relation_From,To_.GetType(DiGi.Core.Relation.Enums.RelationSide)'></a>

## Relation\<From,To\>\.GetType\(RelationSide\) Method

Gets the type associated with the specified relation side\.

```csharp
public override System.Type? GetType(DiGi.Core.Relation.Enums.RelationSide relationSide);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.Relation_From,To_.GetType(DiGi.Core.Relation.Enums.RelationSide).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to retrieve the type for\.

Implements [GetType\(RelationSide\)](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.GetType(DiGi.Core.Relation.Enums.RelationSide) 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.GetType\(DiGi\.Core\.Relation\.Enums\.RelationSide\)')

#### Returns
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')  
The type associated with the specified relation side, or `null` if not found\.

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_'></a>

## RelationCollection\<TRelation\> Class

Represents a collection of relations\.

```csharp
public class RelationCollection<TRelation> : DiGi.Core.Classes.SerializableObjectCollection<TRelation>
    where TRelation : DiGi.Core.Relation.Interfaces.IRelation
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.TRelation'></a>

`TRelation`

The type of relation elements in the collection\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableObjectCollection&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectcollection-1 'DiGi\.Core\.Classes\.SerializableObjectCollection\`1')[TRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationCollection_TRelation_.TRelation 'DiGi\.Core\.Relation\.Classes\.RelationCollection\<TRelation\>\.TRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectcollection-1 'DiGi\.Core\.Classes\.SerializableObjectCollection\`1') → RelationCollection\<TRelation\>
### Constructors

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.RelationCollection()'></a>

## RelationCollection\(\) Constructor

Initializes a new instance of the RelationCollection class\.

```csharp
public RelationCollection();
```

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.RelationCollection(DiGi.Core.Relation.Classes.RelationCollection_TRelation_)'></a>

## RelationCollection\(RelationCollection\<TRelation\>\) Constructor

Initializes a new instance of the RelationCollection class by copying another RelationCollection\.

```csharp
public RelationCollection(DiGi.Core.Relation.Classes.RelationCollection<TRelation>? relationCollection);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.RelationCollection(DiGi.Core.Relation.Classes.RelationCollection_TRelation_).relationCollection'></a>

`relationCollection` [DiGi\.Core\.Relation\.Classes\.RelationCollection&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationCollection_TRelation_ 'DiGi\.Core\.Relation\.Classes\.RelationCollection\<TRelation\>')[TRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationCollection_TRelation_.TRelation 'DiGi\.Core\.Relation\.Classes\.RelationCollection\<TRelation\>\.TRelation')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationCollection_TRelation_ 'DiGi\.Core\.Relation\.Classes\.RelationCollection\<TRelation\>')

The source collection to copy from\.

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.RelationCollection(System.Collections.Generic.IEnumerable_TRelation_)'></a>

## RelationCollection\(IEnumerable\<TRelation\>\) Constructor

Initializes a new instance of the RelationCollection class with the specified relations\.

```csharp
public RelationCollection(System.Collections.Generic.IEnumerable<TRelation>? relations);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.RelationCollection(System.Collections.Generic.IEnumerable_TRelation_).relations'></a>

`relations` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationCollection_TRelation_.TRelation 'DiGi\.Core\.Relation\.Classes\.RelationCollection\<TRelation\>\.TRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of relations to initialize with\.

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.RelationCollection(System.Text.Json.Nodes.JsonObject)'></a>

## RelationCollection\(JsonObject\) Constructor

Initializes a new instance of the RelationCollection class from a JSON object\.

```csharp
public RelationCollection(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.RelationCollection(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the collection from\.
### Methods

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.Find_XRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_XRelation,bool_)'></a>

## RelationCollection\<TRelation\>\.Find\<XRelation\>\(IUniqueReference, Func\<XRelation,bool\>\) Method

Finds the first relation that contains the specified unique reference and optionally matches the predicate\.

```csharp
public XRelation? Find<XRelation>(DiGi.Core.Interfaces.IUniqueReference? uniqueReference, System.Func<XRelation?,bool>? func=null)
    where XRelation : TRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.Find_XRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_XRelation,bool_).XRelation'></a>

`XRelation`

The type of relation being searched for\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.Find_XRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_XRelation,bool_).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to filter by\.

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.Find_XRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_XRelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationCollection_TRelation_.Find_XRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_XRelation,bool_).XRelation 'DiGi\.Core\.Relation\.Classes\.RelationCollection\<TRelation\>\.Find\<XRelation\>\(DiGi\.Core\.Interfaces\.IUniqueReference, System\.Func\<XRelation,bool\>\)\.XRelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The predicate used to further filter the relations\.

#### Returns
[XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationCollection_TRelation_.Find_XRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_XRelation,bool_).XRelation 'DiGi\.Core\.Relation\.Classes\.RelationCollection\<TRelation\>\.Find\<XRelation\>\(DiGi\.Core\.Interfaces\.IUniqueReference, System\.Func\<XRelation,bool\>\)\.XRelation')  
The first relation that matches both the unique reference and the predicate, or null if no match is found\.

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.Find_XRelation_(System.Func_XRelation,bool_)'></a>

## RelationCollection\<TRelation\>\.Find\<XRelation\>\(Func\<XRelation,bool\>\) Method

Finds the first relation that optionally matches the predicate\.

```csharp
public XRelation? Find<XRelation>(System.Func<XRelation?,bool>? func=null)
    where XRelation : TRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.Find_XRelation_(System.Func_XRelation,bool_).XRelation'></a>

`XRelation`

The type of relation being searched for\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.Find_XRelation_(System.Func_XRelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationCollection_TRelation_.Find_XRelation_(System.Func_XRelation,bool_).XRelation 'DiGi\.Core\.Relation\.Classes\.RelationCollection\<TRelation\>\.Find\<XRelation\>\(System\.Func\<XRelation,bool\>\)\.XRelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The predicate used to filter the relations\.

#### Returns
[XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationCollection_TRelation_.Find_XRelation_(System.Func_XRelation,bool_).XRelation 'DiGi\.Core\.Relation\.Classes\.RelationCollection\<TRelation\>\.Find\<XRelation\>\(System\.Func\<XRelation,bool\>\)\.XRelation')  
The first relation that matches the predicate, or null if no match is found\.

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.FindAll_XRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_XRelation,bool_)'></a>

## RelationCollection\<TRelation\>\.FindAll\<XRelation\>\(IUniqueReference, Func\<XRelation,bool\>\) Method

Finds all relations that contain the specified unique reference and optionally match the predicate\.

```csharp
public System.Collections.Generic.List<XRelation>? FindAll<XRelation>(DiGi.Core.Interfaces.IUniqueReference? uniqueReference, System.Func<XRelation?,bool>? func=null)
    where XRelation : TRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.FindAll_XRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_XRelation,bool_).XRelation'></a>

`XRelation`

The type of relation being searched for\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.FindAll_XRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_XRelation,bool_).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to filter by\.

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.FindAll_XRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_XRelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationCollection_TRelation_.FindAll_XRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_XRelation,bool_).XRelation 'DiGi\.Core\.Relation\.Classes\.RelationCollection\<TRelation\>\.FindAll\<XRelation\>\(DiGi\.Core\.Interfaces\.IUniqueReference, System\.Func\<XRelation,bool\>\)\.XRelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The predicate used to further filter the relations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationCollection_TRelation_.FindAll_XRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_XRelation,bool_).XRelation 'DiGi\.Core\.Relation\.Classes\.RelationCollection\<TRelation\>\.FindAll\<XRelation\>\(DiGi\.Core\.Interfaces\.IUniqueReference, System\.Func\<XRelation,bool\>\)\.XRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of relations that match both the unique reference and the predicate, or null if no matches are found\.

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.FindAll_XRelation_(System.Func_XRelation,bool_)'></a>

## RelationCollection\<TRelation\>\.FindAll\<XRelation\>\(Func\<XRelation,bool\>\) Method

Finds all relations that optionally match the predicate\.

```csharp
public System.Collections.Generic.List<XRelation>? FindAll<XRelation>(System.Func<XRelation?,bool>? func=null)
    where XRelation : TRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.FindAll_XRelation_(System.Func_XRelation,bool_).XRelation'></a>

`XRelation`

The type of relation being searched for\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.FindAll_XRelation_(System.Func_XRelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationCollection_TRelation_.FindAll_XRelation_(System.Func_XRelation,bool_).XRelation 'DiGi\.Core\.Relation\.Classes\.RelationCollection\<TRelation\>\.FindAll\<XRelation\>\(System\.Func\<XRelation,bool\>\)\.XRelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The predicate used to filter the relations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationCollection_TRelation_.FindAll_XRelation_(System.Func_XRelation,bool_).XRelation 'DiGi\.Core\.Relation\.Classes\.RelationCollection\<TRelation\>\.FindAll\<XRelation\>\(System\.Func\<XRelation,bool\>\)\.XRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of relations that match the predicate, or null if no matches are found\.

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.Remove(DiGi.Core.Interfaces.IUniqueReference)'></a>

## RelationCollection\<TRelation\>\.Remove\(IUniqueReference\) Method

Removes all relations that contain the specified unique reference\.

```csharp
public bool Remove(DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationCollection_TRelation_.Remove(DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference of the relations to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more relations were removed; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.RelationListCluster'></a>

## RelationListCluster Class

Represents a cluster that organizes all relations by their source type references\.

```csharp
public class RelationListCluster : DiGi.Core.Relation.Classes.RelationListCluster<DiGi.Core.Relation.Interfaces.IRelation>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Cluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3') → [DiGi\.Core\.Classes\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.list-3 'DiGi\.Core\.Classes\.List\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.list-3 'DiGi\.Core\.Classes\.List\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.list-3 'DiGi\.Core\.Classes\.List\`3')[IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.list-3 'DiGi\.Core\.Classes\.List\`3') → [DiGi\.Core\.Classes\.SerializableObjectListCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectlistcluster-3 'DiGi\.Core\.Classes\.SerializableObjectListCluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectlistcluster-3 'DiGi\.Core\.Classes\.SerializableObjectListCluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectlistcluster-3 'DiGi\.Core\.Classes\.SerializableObjectListCluster\`3')[IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectlistcluster-3 'DiGi\.Core\.Classes\.SerializableObjectListCluster\`3') → [DiGi\.Core\.Relation\.Classes\.RelationListCluster&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListCluster_XRelation_ 'DiGi\.Core\.Relation\.Classes\.RelationListCluster\<XRelation\>')[IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListCluster_XRelation_ 'DiGi\.Core\.Relation\.Classes\.RelationListCluster\<XRelation\>') → RelationListCluster
### Constructors

<a name='DiGi.Core.Relation.Classes.RelationListCluster.RelationListCluster()'></a>

## RelationListCluster\(\) Constructor

Initializes a new instance of the RelationListCluster class\.

```csharp
public RelationListCluster();
```

<a name='DiGi.Core.Relation.Classes.RelationListCluster.RelationListCluster(DiGi.Core.Relation.Classes.RelationListCluster)'></a>

## RelationListCluster\(RelationListCluster\) Constructor

Initializes a new instance of the RelationListCluster class by copying another RelationListCluster\.

```csharp
public RelationListCluster(DiGi.Core.Relation.Classes.RelationListCluster? relationCluster);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationListCluster.RelationListCluster(DiGi.Core.Relation.Classes.RelationListCluster).relationCluster'></a>

`relationCluster` [RelationListCluster](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListCluster 'DiGi\.Core\.Relation\.Classes\.RelationListCluster')

The RelationListCluster to copy from\.

<a name='DiGi.Core.Relation.Classes.RelationListCluster.RelationListCluster(System.Collections.Generic.IEnumerable_DiGi.Core.Relation.Interfaces.IRelation_)'></a>

## RelationListCluster\(IEnumerable\<IRelation\>\) Constructor

Initializes a new instance of the RelationListCluster class with the specified relations\.

```csharp
public RelationListCluster(System.Collections.Generic.IEnumerable<DiGi.Core.Relation.Interfaces.IRelation>? relations);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationListCluster.RelationListCluster(System.Collections.Generic.IEnumerable_DiGi.Core.Relation.Interfaces.IRelation_).relations'></a>

`relations` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of relations to initialize with\.

<a name='DiGi.Core.Relation.Classes.RelationListCluster.RelationListCluster(System.Text.Json.Nodes.JsonObject)'></a>

## RelationListCluster\(JsonObject\) Constructor

Initializes a new instance of the RelationListCluster class from a JSON object\.

```csharp
public RelationListCluster(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationListCluster.RelationListCluster(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize from\.

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_'></a>

## RelationListCluster\<XRelation\> Class

Represents a cluster that organizes relations by their source type references\.

```csharp
public class RelationListCluster<XRelation> : DiGi.Core.Classes.SerializableObjectListCluster<DiGi.Core.Classes.TypeReference, DiGi.Core.Classes.TypeReference, XRelation>
    where XRelation : DiGi.Core.Relation.Interfaces.IRelation
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.XRelation'></a>

`XRelation`

The type of relation used in the cluster\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Cluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.XRelation 'DiGi\.Core\.Relation\.Classes\.RelationListCluster\<XRelation\>\.XRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3') → [DiGi\.Core\.Classes\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.list-3 'DiGi\.Core\.Classes\.List\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.list-3 'DiGi\.Core\.Classes\.List\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.list-3 'DiGi\.Core\.Classes\.List\`3')[XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.XRelation 'DiGi\.Core\.Relation\.Classes\.RelationListCluster\<XRelation\>\.XRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.list-3 'DiGi\.Core\.Classes\.List\`3') → [DiGi\.Core\.Classes\.SerializableObjectListCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectlistcluster-3 'DiGi\.Core\.Classes\.SerializableObjectListCluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectlistcluster-3 'DiGi\.Core\.Classes\.SerializableObjectListCluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectlistcluster-3 'DiGi\.Core\.Classes\.SerializableObjectListCluster\`3')[XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.XRelation 'DiGi\.Core\.Relation\.Classes\.RelationListCluster\<XRelation\>\.XRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectlistcluster-3 'DiGi\.Core\.Classes\.SerializableObjectListCluster\`3') → RelationListCluster\<XRelation\>

Derived  
↳ [RelationListCluster](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListCluster 'DiGi\.Core\.Relation\.Classes\.RelationListCluster')
### Constructors

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.RelationListCluster()'></a>

## RelationListCluster\(\) Constructor

Initializes a new instance of the RelationListCluster class\.

```csharp
public RelationListCluster();
```

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.RelationListCluster(DiGi.Core.Relation.Classes.RelationListCluster_XRelation_)'></a>

## RelationListCluster\(RelationListCluster\<XRelation\>\) Constructor

Initializes a new instance of the RelationListCluster class by copying another RelationListCluster\.

```csharp
public RelationListCluster(DiGi.Core.Relation.Classes.RelationListCluster<XRelation>? relationListCluster);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.RelationListCluster(DiGi.Core.Relation.Classes.RelationListCluster_XRelation_).relationListCluster'></a>

`relationListCluster` [DiGi\.Core\.Relation\.Classes\.RelationListCluster&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListCluster_XRelation_ 'DiGi\.Core\.Relation\.Classes\.RelationListCluster\<XRelation\>')[XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.XRelation 'DiGi\.Core\.Relation\.Classes\.RelationListCluster\<XRelation\>\.XRelation')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListCluster_XRelation_ 'DiGi\.Core\.Relation\.Classes\.RelationListCluster\<XRelation\>')

The source cluster to copy from\.

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.RelationListCluster(System.Collections.Generic.IEnumerable_XRelation_)'></a>

## RelationListCluster\(IEnumerable\<XRelation\>\) Constructor

Initializes a new instance of the RelationListCluster class with the specified relations\.

```csharp
public RelationListCluster(System.Collections.Generic.IEnumerable<XRelation>? relations);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.RelationListCluster(System.Collections.Generic.IEnumerable_XRelation_).relations'></a>

`relations` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.XRelation 'DiGi\.Core\.Relation\.Classes\.RelationListCluster\<XRelation\>\.XRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of relations to initialize the cluster with\.

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.RelationListCluster(System.Text.Json.Nodes.JsonObject)'></a>

## RelationListCluster\(JsonObject\) Constructor

Initializes a new instance of the RelationListCluster class from a JSON object\.

```csharp
public RelationListCluster(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.RelationListCluster(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the cluster from\.
### Properties

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.TypeReferences_From'></a>

## RelationListCluster\<XRelation\>\.TypeReferences\_From Property

Gets the list of source type references\.

```csharp
public System.Collections.Generic.List<DiGi.Core.Classes.TypeReference>? TypeReferences_From { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.GetKey_1(XRelation)'></a>

## RelationListCluster\<XRelation\>\.GetKey\_1\(XRelation\) Method

Gets the source type reference from a relation\.

```csharp
protected override DiGi.Core.Classes.TypeReference? GetKey_1(XRelation? value);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.GetKey_1(XRelation).value'></a>

`value` [XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.XRelation 'DiGi\.Core\.Relation\.Classes\.RelationListCluster\<XRelation\>\.XRelation')

#### Returns
[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.GetKey_2(XRelation)'></a>

## RelationListCluster\<XRelation\>\.GetKey\_2\(XRelation\) Method

Gets the target type reference from a relation\.

```csharp
protected override DiGi.Core.Classes.TypeReference? GetKey_2(XRelation? value);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.GetKey_2(XRelation).value'></a>

`value` [XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.XRelation 'DiGi\.Core\.Relation\.Classes\.RelationListCluster\<XRelation\>\.XRelation')

#### Returns
[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.GetValues_URelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_URelation,bool_)'></a>

## RelationListCluster\<XRelation\>\.GetValues\<URelation\>\(IUniqueReference, Func\<URelation,bool\>\) Method

Gets all relations of the specified type that contain the given unique reference and optionally match the predicate\.

```csharp
public System.Collections.Generic.List<URelation>? GetValues<URelation>(DiGi.Core.Interfaces.IUniqueReference? uniqueReference, System.Func<URelation?,bool>? func=null)
    where URelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.GetValues_URelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_URelation,bool_).URelation'></a>

`URelation`

The type of relation to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.GetValues_URelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_URelation,bool_).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to search for\.

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.GetValues_URelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_URelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[URelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.GetValues_URelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_URelation,bool_).URelation 'DiGi\.Core\.Relation\.Classes\.RelationListCluster\<XRelation\>\.GetValues\<URelation\>\(DiGi\.Core\.Interfaces\.IUniqueReference, System\.Func\<URelation,bool\>\)\.URelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the relations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[URelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.GetValues_URelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_URelation,bool_).URelation 'DiGi\.Core\.Relation\.Classes\.RelationListCluster\<XRelation\>\.GetValues\<URelation\>\(DiGi\.Core\.Interfaces\.IUniqueReference, System\.Func\<URelation,bool\>\)\.URelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of matching relations, or null if none are found\.

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.GetValues_URelation_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Func_URelation,bool_)'></a>

## RelationListCluster\<XRelation\>\.GetValues\<URelation\>\(IEnumerable\<IUniqueReference\>, Func\<URelation,bool\>\) Method

Gets all relations of the specified type that contain any of the given unique references and optionally match the predicate\.

```csharp
public System.Collections.Generic.List<URelation>? GetValues<URelation>(System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueReference>? uniqueReferences, System.Func<URelation?,bool>? func=null)
    where URelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.GetValues_URelation_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Func_URelation,bool_).URelation'></a>

`URelation`

The type of relation to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.GetValues_URelation_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Func_URelation,bool_).uniqueReferences'></a>

`uniqueReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of unique references to search for\.

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.GetValues_URelation_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Func_URelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[URelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.GetValues_URelation_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Func_URelation,bool_).URelation 'DiGi\.Core\.Relation\.Classes\.RelationListCluster\<XRelation\>\.GetValues\<URelation\>\(System\.Collections\.Generic\.IEnumerable\<DiGi\.Core\.Interfaces\.IUniqueReference\>, System\.Func\<URelation,bool\>\)\.URelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the relations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[URelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.GetValues_URelation_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Func_URelation,bool_).URelation 'DiGi\.Core\.Relation\.Classes\.RelationListCluster\<XRelation\>\.GetValues\<URelation\>\(System\.Collections\.Generic\.IEnumerable\<DiGi\.Core\.Interfaces\.IUniqueReference\>, System\.Func\<URelation,bool\>\)\.URelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of matching relations, or null if none are found\.

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.Remove(DiGi.Core.Interfaces.IUniqueReference)'></a>

## RelationListCluster\<XRelation\>\.Remove\(IUniqueReference\) Method

Removes the specified unique reference from the relations\.

```csharp
public bool Remove(DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.Remove(DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the element is successfully removed; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.Remove_XUniqueReference_(System.Collections.Generic.IEnumerable_XUniqueReference_)'></a>

## RelationListCluster\<XRelation\>\.Remove\<XUniqueReference\>\(IEnumerable\<XUniqueReference\>\) Method

Removes the specified unique references from the relations and returns the affected relations\.

```csharp
public System.Collections.Generic.List<XRelation>? Remove<XUniqueReference>(System.Collections.Generic.IEnumerable<XUniqueReference>? uniqueReferences)
    where XUniqueReference : DiGi.Core.Interfaces.IUniqueReference;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.Remove_XUniqueReference_(System.Collections.Generic.IEnumerable_XUniqueReference_).XUniqueReference'></a>

`XUniqueReference`

The type of unique reference\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.Remove_XUniqueReference_(System.Collections.Generic.IEnumerable_XUniqueReference_).uniqueReferences'></a>

`uniqueReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[XUniqueReference](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.Remove_XUniqueReference_(System.Collections.Generic.IEnumerable_XUniqueReference_).XUniqueReference 'DiGi\.Core\.Relation\.Classes\.RelationListCluster\<XRelation\>\.Remove\<XUniqueReference\>\(System\.Collections\.Generic\.IEnumerable\<XUniqueReference\>\)\.XUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references to remove\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListCluster_XRelation_.XRelation 'DiGi\.Core\.Relation\.Classes\.RelationListCluster\<XRelation\>\.XRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of the affected relations, or null if none were removed\.

<a name='DiGi.Core.Relation.Classes.RelationListClusterReference'></a>

## RelationListClusterReference Class

Represents a reference to a relation list cluster identified by two type references and an index\.

```csharp
public class RelationListClusterReference : DiGi.Core.Classes.ListClusterReference<DiGi.Core.Classes.TypeReference, DiGi.Core.Classes.TypeReference>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.ListClusterReference&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.listclusterreference-2 'DiGi\.Core\.Classes\.ListClusterReference\`2')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.listclusterreference-2 'DiGi\.Core\.Classes\.ListClusterReference\`2')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.listclusterreference-2 'DiGi\.Core\.Classes\.ListClusterReference\`2') → RelationListClusterReference

### Example
Renders and parses \(via [DiGi\.Core\.Query\.TryParse\(System\.String,DiGi\.Core\.Interfaces\.IReference@\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.query.tryparse#digi-core-query-tryparse(system-string-digi-core-interfaces-ireference@) 'DiGi\.Core\.Query\.TryParse\(System\.String,DiGi\.Core\.Interfaces\.IReference@\)')\) as the discriminator, the
two nested type references, then the index:

```csharp
RelationListCluster::(Type::DiGi.GIS.Classes.Building2D,DiGi.GIS)::(Type::DiGi.GIS.Classes.Space,DiGi.GIS)::3
```

### Remarks
TODO \[ReferenceFormat\]: This type renders its own string by hand\. It derives from
[DiGi\.Core\.Classes\.ListClusterReference&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.listclusterreference-2 'DiGi\.Core\.Classes\.ListClusterReference\`2'), which implements [DiGi\.Core\.Interfaces\.IReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireference 'DiGi\.Core\.Interfaces\.IReference') directly rather
than deriving from [DiGi\.Core\.Classes\.SerializableReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializablereference 'DiGi\.Core\.Classes\.SerializableReference'), so it does not inherit the sealed ToString that
guarantees the grammar\. Keep [ToString\(\)](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListClusterReference.ToString() 'DiGi\.Core\.Relation\.Classes\.RelationListClusterReference\.ToString\(\)') below in step with
[DiGi\.Core\.Convert\.ToSystem\_String\(System\.Type,System\.Collections\.Generic\.IEnumerable\{System\.String\}\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.convert.tosystem_string#digi-core-convert-tosystem_string(system-type-system-collections-generic-ienumerable{system-string}) 'DiGi\.Core\.Convert\.ToSystem\_String\(System\.Type,System\.Collections\.Generic\.IEnumerable\{System\.String\}\)') and with its factory in
Create/RelationListClusterReference\.cs\. The ReferenceKind facts assert this type still round\-trips\.
### Constructors

<a name='DiGi.Core.Relation.Classes.RelationListClusterReference.RelationListClusterReference(DiGi.Core.Classes.TypeReference,DiGi.Core.Classes.TypeReference,int)'></a>

## RelationListClusterReference\(TypeReference, TypeReference, int\) Constructor

Represents a reference to a relation list cluster identified by two type references and an index\.

```csharp
public RelationListClusterReference(DiGi.Core.Classes.TypeReference? key_1, DiGi.Core.Classes.TypeReference? key_2, int index);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationListClusterReference.RelationListClusterReference(DiGi.Core.Classes.TypeReference,DiGi.Core.Classes.TypeReference,int).key_1'></a>

`key_1` [DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')

<a name='DiGi.Core.Relation.Classes.RelationListClusterReference.RelationListClusterReference(DiGi.Core.Classes.TypeReference,DiGi.Core.Classes.TypeReference,int).key_2'></a>

`key_2` [DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')

<a name='DiGi.Core.Relation.Classes.RelationListClusterReference.RelationListClusterReference(DiGi.Core.Classes.TypeReference,DiGi.Core.Classes.TypeReference,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

### Example
Renders and parses \(via [DiGi\.Core\.Query\.TryParse\(System\.String,DiGi\.Core\.Interfaces\.IReference@\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.query.tryparse#digi-core-query-tryparse(system-string-digi-core-interfaces-ireference@) 'DiGi\.Core\.Query\.TryParse\(System\.String,DiGi\.Core\.Interfaces\.IReference@\)')\) as the discriminator, the
two nested type references, then the index:

```csharp
RelationListCluster::(Type::DiGi.GIS.Classes.Building2D,DiGi.GIS)::(Type::DiGi.GIS.Classes.Space,DiGi.GIS)::3
```

### Remarks
TODO \[ReferenceFormat\]: This type renders its own string by hand\. It derives from
[DiGi\.Core\.Classes\.ListClusterReference&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.listclusterreference-2 'DiGi\.Core\.Classes\.ListClusterReference\`2'), which implements [DiGi\.Core\.Interfaces\.IReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireference 'DiGi\.Core\.Interfaces\.IReference') directly rather
than deriving from [DiGi\.Core\.Classes\.SerializableReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializablereference 'DiGi\.Core\.Classes\.SerializableReference'), so it does not inherit the sealed ToString that
guarantees the grammar\. Keep [ToString\(\)](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.RelationListClusterReference.ToString() 'DiGi\.Core\.Relation\.Classes\.RelationListClusterReference\.ToString\(\)') below in step with
[DiGi\.Core\.Convert\.ToSystem\_String\(System\.Type,System\.Collections\.Generic\.IEnumerable\{System\.String\}\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.convert.tosystem_string#digi-core-convert-tosystem_string(system-type-system-collections-generic-ienumerable{system-string}) 'DiGi\.Core\.Convert\.ToSystem\_String\(System\.Type,System\.Collections\.Generic\.IEnumerable\{System\.String\}\)') and with its factory in
Create/RelationListClusterReference\.cs\. The ReferenceKind facts assert this type still round\-trips\.
### Methods

<a name='DiGi.Core.Relation.Classes.RelationListClusterReference.Equals(DiGi.Core.Interfaces.IReference)'></a>

## RelationListClusterReference\.Equals\(IReference\) Method

Determines whether this instance equals the specified reference\.

```csharp
public override bool Equals(DiGi.Core.Interfaces.IReference? reference);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.RelationListClusterReference.Equals(DiGi.Core.Interfaces.IReference).reference'></a>

`reference` [DiGi\.Core\.Interfaces\.IReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireference 'DiGi\.Core\.Interfaces\.IReference')

The reference to compare with this instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the instances are equal; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.RelationListClusterReference.GetHashCode()'></a>

## RelationListClusterReference\.GetHashCode\(\) Method

Returns the hash code for this instance\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The hash code for this instance\.

<a name='DiGi.Core.Relation.Classes.RelationListClusterReference.ToString()'></a>

## RelationListClusterReference\.ToString\(\) Method

Returns the reference string: this type's discriminator, both keys, then the index\.

```csharp
public override string? ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The reference string\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\> Class

Represents a cluster that associates unique objects with their related relations\.

```csharp
public class UniqueObjectRelationCluster<TUniqueObject,XRelation> : DiGi.Core.Classes.UniqueObjectValueCluster<TUniqueObject>
    where TUniqueObject : DiGi.Core.Interfaces.IUniqueObject
    where XRelation : DiGi.Core.Relation.Interfaces.IRelation
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject'></a>

`TUniqueObject`

The type of the unique objects in the cluster\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.XRelation'></a>

`XRelation`

The type of the relations associated with the unique objects\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Cluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3') → [DiGi\.Core\.Classes\.ValueCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3') → [DiGi\.Core\.Classes\.SerializableObjectValueCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3')[TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobjectvaluecluster-3 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\`3') → [DiGi\.Core\.Classes\.UniqueObjectValueCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobjectvaluecluster-1 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\`1')[TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobjectvaluecluster-1 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\`1') → UniqueObjectRelationCluster\<TUniqueObject,XRelation\>
### Constructors

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.UniqueObjectRelationCluster()'></a>

## UniqueObjectRelationCluster\(\) Constructor

Initializes a new instance of the UniqueObjectRelationCluster class\.

```csharp
public UniqueObjectRelationCluster();
```

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.UniqueObjectRelationCluster(DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_)'></a>

## UniqueObjectRelationCluster\(UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\) Constructor

Initializes a new instance of the UniqueObjectRelationCluster class by copying another UniqueObjectRelationCluster\.

```csharp
public UniqueObjectRelationCluster(DiGi.Core.Relation.Classes.UniqueObjectRelationCluster<TUniqueObject,XRelation>? uniqueObjectRelationCluster);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.UniqueObjectRelationCluster(DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_).uniqueObjectRelationCluster'></a>

`uniqueObjectRelationCluster` [DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_ 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>')[TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_ 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>')[XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.XRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.XRelation')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_ 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>')

The existing cluster to copy from\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.UniqueObjectRelationCluster(System.Collections.Generic.IEnumerable_TUniqueObject_)'></a>

## UniqueObjectRelationCluster\(IEnumerable\<TUniqueObject\>\) Constructor

Initializes a new instance of the UniqueObjectRelationCluster class with the specified unique objects\.

```csharp
public UniqueObjectRelationCluster(System.Collections.Generic.IEnumerable<TUniqueObject>? uniqueObjects);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.UniqueObjectRelationCluster(System.Collections.Generic.IEnumerable_TUniqueObject_).uniqueObjects'></a>

`uniqueObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique objects to initialize the cluster with\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.UniqueObjectRelationCluster(System.Text.Json.Nodes.JsonObject)'></a>

## UniqueObjectRelationCluster\(JsonObject\) Constructor

Initializes a new instance of the UniqueObjectRelationCluster class from a JSON object\.

```csharp
public UniqueObjectRelationCluster(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.UniqueObjectRelationCluster(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to deserialize into a cluster\.
### Methods

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.AddRelation_ZRelation_(ZRelation)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.AddRelation\<ZRelation\>\(ZRelation\) Method

Adds a relation to the cluster and returns it if successfully added\.

```csharp
public ZRelation? AddRelation<ZRelation>(ZRelation? relation)
    where ZRelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.AddRelation_ZRelation_(ZRelation).ZRelation'></a>

`ZRelation`

The type of the relation\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.AddRelation_ZRelation_(ZRelation).relation'></a>

`relation` [ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.AddRelation_ZRelation_(ZRelation).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.AddRelation\<ZRelation\>\(ZRelation\)\.ZRelation')

The relation to add to the cluster\.

#### Returns
[ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.AddRelation_ZRelation_(ZRelation).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.AddRelation\<ZRelation\>\(ZRelation\)\.ZRelation')  
The added relation if successful; otherwise, null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValue_UUniqueObject,ZRelation_(TUniqueObject,System.Func_UUniqueObject,bool_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelatedValue\<UUniqueObject,ZRelation\>\(TUniqueObject, Func\<UUniqueObject,bool\>\) Method

Gets a related value of the specified relation type for the given unique object\.

```csharp
public UUniqueObject? GetRelatedValue<UUniqueObject,ZRelation>(TUniqueObject? value, System.Func<UUniqueObject?,bool>? func=null)
    where UUniqueObject : TUniqueObject
    where ZRelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValue_UUniqueObject,ZRelation_(TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject'></a>

`UUniqueObject`

The type of the related unique object\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValue_UUniqueObject,ZRelation_(TUniqueObject,System.Func_UUniqueObject,bool_).ZRelation'></a>

`ZRelation`

The type of the relation\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValue_UUniqueObject,ZRelation_(TUniqueObject,System.Func_UUniqueObject,bool_).value'></a>

`value` [TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TUniqueObject')

The unique object to get a related value for\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValue_UUniqueObject,ZRelation_(TUniqueObject,System.Func_UUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValue_UUniqueObject,ZRelation_(TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelatedValue\<UUniqueObject,ZRelation\>\(TUniqueObject, System\.Func\<UUniqueObject,bool\>\)\.UUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional filter function to apply to the related value\.

#### Returns
[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValue_UUniqueObject,ZRelation_(TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelatedValue\<UUniqueObject,ZRelation\>\(TUniqueObject, System\.Func\<UUniqueObject,bool\>\)\.UUniqueObject')  
The related value, or null if not found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValue_UUniqueObject_(TUniqueObject,System.Func_UUniqueObject,bool_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelatedValue\<UUniqueObject\>\(TUniqueObject, Func\<UUniqueObject,bool\>\) Method

Gets a related value of the specified type for the given unique object\.

```csharp
public UUniqueObject? GetRelatedValue<UUniqueObject>(TUniqueObject? value, System.Func<UUniqueObject?,bool>? func=null)
    where UUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValue_UUniqueObject_(TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject'></a>

`UUniqueObject`

The type of the related unique object\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValue_UUniqueObject_(TUniqueObject,System.Func_UUniqueObject,bool_).value'></a>

`value` [TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TUniqueObject')

The unique object to get a related value for\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValue_UUniqueObject_(TUniqueObject,System.Func_UUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValue_UUniqueObject_(TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelatedValue\<UUniqueObject\>\(TUniqueObject, System\.Func\<UUniqueObject,bool\>\)\.UUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional filter function to apply to the related value\.

#### Returns
[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValue_UUniqueObject_(TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelatedValue\<UUniqueObject\>\(TUniqueObject, System\.Func\<UUniqueObject,bool\>\)\.UUniqueObject')  
The related value, or null if not found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValueDictionary_UUniqueObject,ZRelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_UUniqueObject,bool_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelatedValueDictionary\<UUniqueObject,ZRelation\>\(IEnumerable\<TUniqueObject\>, Func\<UUniqueObject,bool\>\) Method

Gets a dictionary mapping unique references to their related values of the specified relation type\.

```csharp
public System.Collections.Generic.Dictionary<DiGi.Core.Interfaces.IUniqueReference,UUniqueObject>? GetRelatedValueDictionary<UUniqueObject,ZRelation>(System.Collections.Generic.IEnumerable<TUniqueObject>? values, System.Func<UUniqueObject?,bool>? func=null)
    where UUniqueObject : TUniqueObject
    where ZRelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValueDictionary_UUniqueObject,ZRelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_UUniqueObject,bool_).UUniqueObject'></a>

`UUniqueObject`

The type of the related unique objects\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValueDictionary_UUniqueObject,ZRelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_UUniqueObject,bool_).ZRelation'></a>

`ZRelation`

The type of the relation\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValueDictionary_UUniqueObject,ZRelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_UUniqueObject,bool_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique objects to get related values for\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValueDictionary_UUniqueObject,ZRelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_UUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValueDictionary_UUniqueObject,ZRelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_UUniqueObject,bool_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelatedValueDictionary\<UUniqueObject,ZRelation\>\(System\.Collections\.Generic\.IEnumerable\<TUniqueObject\>, System\.Func\<UUniqueObject,bool\>\)\.UUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional filter function to apply to the related values\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValueDictionary_UUniqueObject,ZRelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_UUniqueObject,bool_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelatedValueDictionary\<UUniqueObject,ZRelation\>\(System\.Collections\.Generic\.IEnumerable\<TUniqueObject\>, System\.Func\<UUniqueObject,bool\>\)\.UUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping unique references to their related values, or null if none are found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValues_UUniqueObject,ZRelation_(TUniqueObject,System.Func_UUniqueObject,bool_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelatedValues\<UUniqueObject,ZRelation\>\(TUniqueObject, Func\<UUniqueObject,bool\>\) Method

Gets all related values of the specified relation type for the given unique object\.

```csharp
public System.Collections.Generic.List<UUniqueObject>? GetRelatedValues<UUniqueObject,ZRelation>(TUniqueObject? value, System.Func<UUniqueObject?,bool>? func=null)
    where UUniqueObject : TUniqueObject
    where ZRelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValues_UUniqueObject,ZRelation_(TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject'></a>

`UUniqueObject`

The type of the related unique objects\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValues_UUniqueObject,ZRelation_(TUniqueObject,System.Func_UUniqueObject,bool_).ZRelation'></a>

`ZRelation`

The type of the relation\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValues_UUniqueObject,ZRelation_(TUniqueObject,System.Func_UUniqueObject,bool_).value'></a>

`value` [TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TUniqueObject')

The unique object to get related values for\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValues_UUniqueObject,ZRelation_(TUniqueObject,System.Func_UUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValues_UUniqueObject,ZRelation_(TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelatedValues\<UUniqueObject,ZRelation\>\(TUniqueObject, System\.Func\<UUniqueObject,bool\>\)\.UUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional filter function to apply to the related values\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValues_UUniqueObject,ZRelation_(TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelatedValues\<UUniqueObject,ZRelation\>\(TUniqueObject, System\.Func\<UUniqueObject,bool\>\)\.UUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of related values, or null if none are found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValues_UUniqueObject_(TUniqueObject,System.Func_UUniqueObject,bool_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelatedValues\<UUniqueObject\>\(TUniqueObject, Func\<UUniqueObject,bool\>\) Method

Gets all related values for the given unique object\.

```csharp
public System.Collections.Generic.List<UUniqueObject>? GetRelatedValues<UUniqueObject>(TUniqueObject? value, System.Func<UUniqueObject?,bool>? func=null)
    where UUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValues_UUniqueObject_(TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject'></a>

`UUniqueObject`

The type of the related unique objects\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValues_UUniqueObject_(TUniqueObject,System.Func_UUniqueObject,bool_).value'></a>

`value` [TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TUniqueObject')

The unique object to get related values for\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValues_UUniqueObject_(TUniqueObject,System.Func_UUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValues_UUniqueObject_(TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelatedValues\<UUniqueObject\>\(TUniqueObject, System\.Func\<UUniqueObject,bool\>\)\.UUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional filter function to apply to the related values\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelatedValues_UUniqueObject_(TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelatedValues\<UUniqueObject\>\(TUniqueObject, System\.Func\<UUniqueObject,bool\>\)\.UUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of related values, or null if none are found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelation_ZRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_ZRelation,bool_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelation\<ZRelation\>\(IUniqueReference, Func\<ZRelation,bool\>\) Method

Gets the first relation of the specified type that contains the given unique reference and optionally matches the predicate\.

```csharp
public ZRelation? GetRelation<ZRelation>(DiGi.Core.Interfaces.IUniqueReference? uniqueReference, System.Func<ZRelation?,bool>? func=null)
    where ZRelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelation_ZRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_ZRelation,bool_).ZRelation'></a>

`ZRelation`

The type of relation to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelation_ZRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_ZRelation,bool_).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to search for\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelation_ZRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_ZRelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelation_ZRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_ZRelation,bool_).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelation\<ZRelation\>\(DiGi\.Core\.Interfaces\.IUniqueReference, System\.Func\<ZRelation,bool\>\)\.ZRelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the relations\.

#### Returns
[ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelation_ZRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_ZRelation,bool_).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelation\<ZRelation\>\(DiGi\.Core\.Interfaces\.IUniqueReference, System\.Func\<ZRelation,bool\>\)\.ZRelation')  
The first relation containing the unique reference and matching the predicate, or null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelation_ZRelation_(TUniqueObject,System.Func_ZRelation,bool_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelation\<ZRelation\>\(TUniqueObject, Func\<ZRelation,bool\>\) Method

Gets the first relation of the specified type that contains the given unique object and optionally matches the predicate\.

```csharp
public ZRelation? GetRelation<ZRelation>(TUniqueObject? value, System.Func<ZRelation?,bool>? func=null)
    where ZRelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelation_ZRelation_(TUniqueObject,System.Func_ZRelation,bool_).ZRelation'></a>

`ZRelation`

The type of relation to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelation_ZRelation_(TUniqueObject,System.Func_ZRelation,bool_).value'></a>

`value` [TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TUniqueObject')

The unique object to search for\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelation_ZRelation_(TUniqueObject,System.Func_ZRelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelation_ZRelation_(TUniqueObject,System.Func_ZRelation,bool_).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelation\<ZRelation\>\(TUniqueObject, System\.Func\<ZRelation,bool\>\)\.ZRelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the relations\.

#### Returns
[ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelation_ZRelation_(TUniqueObject,System.Func_ZRelation,bool_).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelation\<ZRelation\>\(TUniqueObject, System\.Func\<ZRelation,bool\>\)\.ZRelation')  
The first relation containing the unique object and matching the predicate, or null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(DiGi.Core.Interfaces.IUniqueReference)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelations\<ZRelation\>\(IUniqueReference\) Method

Gets all relations of the specified type that contain the given unique reference\.

```csharp
public System.Collections.Generic.List<ZRelation>? GetRelations<ZRelation>(DiGi.Core.Interfaces.IUniqueReference? uniqueReference)
    where ZRelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(DiGi.Core.Interfaces.IUniqueReference).ZRelation'></a>

`ZRelation`

The type of relation to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference to search for\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(DiGi.Core.Interfaces.IUniqueReference).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelations\<ZRelation\>\(DiGi\.Core\.Interfaces\.IUniqueReference\)\.ZRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of relations containing the unique reference, or null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_ZRelation,bool_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelations\<ZRelation\>\(IUniqueReference, Func\<ZRelation,bool\>\) Method

Gets all relations of the specified type that contain the given unique reference and optionally match the predicate\.

```csharp
public System.Collections.Generic.List<ZRelation>? GetRelations<ZRelation>(DiGi.Core.Interfaces.IUniqueReference? uniqueReference, System.Func<ZRelation?,bool>? func=null)
    where ZRelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_ZRelation,bool_).ZRelation'></a>

`ZRelation`

The type of relation to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_ZRelation,bool_).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference used to filter the relations\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_ZRelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_ZRelation,bool_).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelations\<ZRelation\>\(DiGi\.Core\.Interfaces\.IUniqueReference, System\.Func\<ZRelation,bool\>\)\.ZRelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to further filter the resulting relations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(DiGi.Core.Interfaces.IUniqueReference,System.Func_ZRelation,bool_).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelations\<ZRelation\>\(DiGi\.Core\.Interfaces\.IUniqueReference, System\.Func\<ZRelation,bool\>\)\.ZRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of matching relations, or null if no matches were found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Func_ZRelation,bool_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelations\<ZRelation\>\(IEnumerable\<IUniqueReference\>, Func\<ZRelation,bool\>\) Method

Gets all relations of the specified type that contain any of the given unique references and optionally match the predicate\.

```csharp
public System.Collections.Generic.List<ZRelation>? GetRelations<ZRelation>(System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueReference>? uniqueReferences, System.Func<ZRelation?,bool>? func=null)
    where ZRelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Func_ZRelation,bool_).ZRelation'></a>

`ZRelation`

The type of relation to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Func_ZRelation,bool_).uniqueReferences'></a>

`uniqueReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references used to filter the relations\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Func_ZRelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Func_ZRelation,bool_).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelations\<ZRelation\>\(System\.Collections\.Generic\.IEnumerable\<DiGi\.Core\.Interfaces\.IUniqueReference\>, System\.Func\<ZRelation,bool\>\)\.ZRelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to further filter the resulting relations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_,System.Func_ZRelation,bool_).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelations\<ZRelation\>\(System\.Collections\.Generic\.IEnumerable\<DiGi\.Core\.Interfaces\.IUniqueReference\>, System\.Func\<ZRelation,bool\>\)\.ZRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of matching relations, or null if no matches were found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_ZRelation,bool_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelations\<ZRelation\>\(IEnumerable\<TUniqueObject\>, Func\<ZRelation,bool\>\) Method

Gets all relations of the specified type that contain any of the given unique objects and optionally match the predicate\.

```csharp
public System.Collections.Generic.List<ZRelation>? GetRelations<ZRelation>(System.Collections.Generic.IEnumerable<TUniqueObject>? uniqueObjects, System.Func<ZRelation?,bool>? func=null)
    where ZRelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_ZRelation,bool_).ZRelation'></a>

`ZRelation`

The type of relation to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_ZRelation,bool_).uniqueObjects'></a>

`uniqueObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of unique objects to search for\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_ZRelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_ZRelation,bool_).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelations\<ZRelation\>\(System\.Collections\.Generic\.IEnumerable\<TUniqueObject\>, System\.Func\<ZRelation,bool\>\)\.ZRelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the relations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_ZRelation,bool_).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelations\<ZRelation\>\(System\.Collections\.Generic\.IEnumerable\<TUniqueObject\>, System\.Func\<ZRelation,bool\>\)\.ZRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of relations containing any of the specified unique objects and matching the predicate, or null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(TUniqueObject,System.Func_ZRelation,bool_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelations\<ZRelation\>\(TUniqueObject, Func\<ZRelation,bool\>\) Method

Gets all relations of the specified type that contain the given unique object and optionally match the predicate\.

```csharp
public System.Collections.Generic.List<ZRelation>? GetRelations<ZRelation>(TUniqueObject? uniqueObject, System.Func<ZRelation?,bool>? func=null)
    where ZRelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(TUniqueObject,System.Func_ZRelation,bool_).ZRelation'></a>

`ZRelation`

The type of relation to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(TUniqueObject,System.Func_ZRelation,bool_).uniqueObject'></a>

`uniqueObject` [TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TUniqueObject')

The unique object to search for\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(TUniqueObject,System.Func_ZRelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(TUniqueObject,System.Func_ZRelation,bool_).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelations\<ZRelation\>\(TUniqueObject, System\.Func\<ZRelation,bool\>\)\.ZRelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the relations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetRelations_ZRelation_(TUniqueObject,System.Func_ZRelation,bool_).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetRelations\<ZRelation\>\(TUniqueObject, System\.Func\<ZRelation,bool\>\)\.ZRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of relations containing the unique object and matching the predicate, or null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetValue_UUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetValue\<UUniqueObject\>\(XRelation, RelationSide\) Method

Gets the unique object of the specified type from the relation on the given side\.

```csharp
public UUniqueObject? GetValue<UUniqueObject>(XRelation? relation, DiGi.Core.Relation.Enums.RelationSide relationSide)
    where UUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetValue_UUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide).UUniqueObject'></a>

`UUniqueObject`

The type of unique object to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetValue_UUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide).relation'></a>

`relation` [XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.XRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.XRelation')

The relation to query\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetValue_UUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to retrieve the value from\.

#### Returns
[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetValue_UUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetValue\<UUniqueObject\>\(XRelation, DiGi\.Core\.Relation\.Enums\.RelationSide\)\.UUniqueObject')  
The unique object found, or null if no such object exists\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetValues_UUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetValues\<UUniqueObject\>\(XRelation, RelationSide\) Method

Gets all unique objects of the specified type from the relation on the given side\.

```csharp
public System.Collections.Generic.List<UUniqueObject>? GetValues<UUniqueObject>(XRelation? relation, DiGi.Core.Relation.Enums.RelationSide relationSide)
    where UUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetValues_UUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide).UUniqueObject'></a>

`UUniqueObject`

The type of unique object to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetValues_UUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide).relation'></a>

`relation` [XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.XRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.XRelation')

The relation to query\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetValues_UUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to retrieve values from\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.GetValues_UUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.GetValues\<UUniqueObject\>\(XRelation, DiGi\.Core\.Relation\.Enums\.RelationSide\)\.UUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of unique objects found, or null if no objects were found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.Remove(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.Remove\(IEnumerable\<IUniqueReference\>\) Method

Removes the specified unique references and returns the affected references\.

```csharp
public override System.Collections.Generic.List<DiGi.Core.Interfaces.IUniqueReference>? Remove(System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.IUniqueReference>? keys_2);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.Remove(System.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.IUniqueReference_).keys_2'></a>

`keys_2` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references to remove\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of the removed unique references, or null if no references were removed\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.Remove(TUniqueObject)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.Remove\(TUniqueObject\) Method

Removes the specified unique object and its associated relations\.

```csharp
public override bool Remove(TUniqueObject? uniqueObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.Remove(TUniqueObject).uniqueObject'></a>

`uniqueObject` [TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TUniqueObject')

The unique object to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the unique object was successfully removed; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.Remove(XRelation)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.Remove\(XRelation\) Method

Removes the specified relation from the cluster\.

```csharp
public virtual bool Remove(XRelation? relation);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.Remove(XRelation).relation'></a>

`relation` [XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.XRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.XRelation')

The relation to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the relation was successfully removed; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.Remove_UUniqueObject_(System.Collections.Generic.IEnumerable_UUniqueObject_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.Remove\<UUniqueObject\>\(IEnumerable\<UUniqueObject\>\) Method

Removes the specified unique objects and returns those that were successfully removed\.

```csharp
public override System.Collections.Generic.List<UUniqueObject>? Remove<UUniqueObject>(System.Collections.Generic.IEnumerable<UUniqueObject>? uniqueObjects)
    where UUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.Remove_UUniqueObject_(System.Collections.Generic.IEnumerable_UUniqueObject_).UUniqueObject'></a>

`UUniqueObject`

The type of the unique objects\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.Remove_UUniqueObject_(System.Collections.Generic.IEnumerable_UUniqueObject_).uniqueObjects'></a>

`uniqueObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.Remove_UUniqueObject_(System.Collections.Generic.IEnumerable_UUniqueObject_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.Remove\<UUniqueObject\>\(System\.Collections\.Generic\.IEnumerable\<UUniqueObject\>\)\.UUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique objects to remove\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.Remove_UUniqueObject_(System.Collections.Generic.IEnumerable_UUniqueObject_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.Remove\<UUniqueObject\>\(System\.Collections\.Generic\.IEnumerable\<UUniqueObject\>\)\.UUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of unique objects that were successfully removed, or null if none were removed\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValue_UUniqueObject,ZRelation_(UUniqueObject,TUniqueObject,System.Func_UUniqueObject,bool_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelatedValue\<UUniqueObject,ZRelation\>\(UUniqueObject, TUniqueObject, Func\<UUniqueObject,bool\>\) Method

Tries to get a related value of the specified type for the given unique object using the specified relation type\.

```csharp
public bool TryGetRelatedValue<UUniqueObject,ZRelation>(out UUniqueObject? uniqueObject, TUniqueObject? value, System.Func<UUniqueObject?,bool>? func=null)
    where UUniqueObject : TUniqueObject
    where ZRelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValue_UUniqueObject,ZRelation_(UUniqueObject,TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject'></a>

`UUniqueObject`

The type of the unique object\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValue_UUniqueObject,ZRelation_(UUniqueObject,TUniqueObject,System.Func_UUniqueObject,bool_).ZRelation'></a>

`ZRelation`

The type of the relation\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValue_UUniqueObject,ZRelation_(UUniqueObject,TUniqueObject,System.Func_UUniqueObject,bool_).uniqueObject'></a>

`uniqueObject` [UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValue_UUniqueObject,ZRelation_(UUniqueObject,TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelatedValue\<UUniqueObject,ZRelation\>\(UUniqueObject, TUniqueObject, System\.Func\<UUniqueObject,bool\>\)\.UUniqueObject')

When this method returns, contains the related value if found; otherwise, null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValue_UUniqueObject,ZRelation_(UUniqueObject,TUniqueObject,System.Func_UUniqueObject,bool_).value'></a>

`value` [TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TUniqueObject')

The value to search for\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValue_UUniqueObject,ZRelation_(UUniqueObject,TUniqueObject,System.Func_UUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValue_UUniqueObject,ZRelation_(UUniqueObject,TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelatedValue\<UUniqueObject,ZRelation\>\(UUniqueObject, TUniqueObject, System\.Func\<UUniqueObject,bool\>\)\.UUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional function to filter the results\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a related value was found; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValue_UUniqueObject_(UUniqueObject,TUniqueObject,System.Func_UUniqueObject,bool_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelatedValue\<UUniqueObject\>\(UUniqueObject, TUniqueObject, Func\<UUniqueObject,bool\>\) Method

Tries to get a related value of the specified type for the given unique object\.

```csharp
public bool TryGetRelatedValue<UUniqueObject>(out UUniqueObject? uniqueObject, TUniqueObject? value, System.Func<UUniqueObject?,bool>? func=null)
    where UUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValue_UUniqueObject_(UUniqueObject,TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject'></a>

`UUniqueObject`

The type of the unique object\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValue_UUniqueObject_(UUniqueObject,TUniqueObject,System.Func_UUniqueObject,bool_).uniqueObject'></a>

`uniqueObject` [UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValue_UUniqueObject_(UUniqueObject,TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelatedValue\<UUniqueObject\>\(UUniqueObject, TUniqueObject, System\.Func\<UUniqueObject,bool\>\)\.UUniqueObject')

When this method returns, contains the related value if found; otherwise, null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValue_UUniqueObject_(UUniqueObject,TUniqueObject,System.Func_UUniqueObject,bool_).value'></a>

`value` [TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TUniqueObject')

The value to search for\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValue_UUniqueObject_(UUniqueObject,TUniqueObject,System.Func_UUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValue_UUniqueObject_(UUniqueObject,TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelatedValue\<UUniqueObject\>\(UUniqueObject, TUniqueObject, System\.Func\<UUniqueObject,bool\>\)\.UUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional function to filter the results\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a related value was found; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValues_UUniqueObject,ZRelation_(System.Collections.Generic.List_UUniqueObject_,TUniqueObject,System.Func_UUniqueObject,bool_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelatedValues\<UUniqueObject,ZRelation\>\(List\<UUniqueObject\>, TUniqueObject, Func\<UUniqueObject,bool\>\) Method

Tries to get all related values of the specified type for the given unique object using the specified relation type\.

```csharp
public bool TryGetRelatedValues<UUniqueObject,ZRelation>(out System.Collections.Generic.List<UUniqueObject>? uniqueObjects, TUniqueObject? value, System.Func<UUniqueObject?,bool>? func=null)
    where UUniqueObject : TUniqueObject
    where ZRelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValues_UUniqueObject,ZRelation_(System.Collections.Generic.List_UUniqueObject_,TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject'></a>

`UUniqueObject`

The type of the unique objects to retrieve\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValues_UUniqueObject,ZRelation_(System.Collections.Generic.List_UUniqueObject_,TUniqueObject,System.Func_UUniqueObject,bool_).ZRelation'></a>

`ZRelation`

The type of the relation used to find the values\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValues_UUniqueObject,ZRelation_(System.Collections.Generic.List_UUniqueObject_,TUniqueObject,System.Func_UUniqueObject,bool_).uniqueObjects'></a>

`uniqueObjects` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValues_UUniqueObject,ZRelation_(System.Collections.Generic.List_UUniqueObject_,TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelatedValues\<UUniqueObject,ZRelation\>\(System\.Collections\.Generic\.List\<UUniqueObject\>, TUniqueObject, System\.Func\<UUniqueObject,bool\>\)\.UUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains the list of related unique objects found; otherwise, null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValues_UUniqueObject,ZRelation_(System.Collections.Generic.List_UUniqueObject_,TUniqueObject,System.Func_UUniqueObject,bool_).value'></a>

`value` [TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TUniqueObject')

The unique object for which to retrieve related values\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValues_UUniqueObject,ZRelation_(System.Collections.Generic.List_UUniqueObject_,TUniqueObject,System.Func_UUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValues_UUniqueObject,ZRelation_(System.Collections.Generic.List_UUniqueObject_,TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelatedValues\<UUniqueObject,ZRelation\>\(System\.Collections\.Generic\.List\<UUniqueObject\>, TUniqueObject, System\.Func\<UUniqueObject,bool\>\)\.UUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the related values\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more related values were found; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValues_UUniqueObject_(System.Collections.Generic.List_UUniqueObject_,TUniqueObject,System.Func_UUniqueObject,bool_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelatedValues\<UUniqueObject\>\(List\<UUniqueObject\>, TUniqueObject, Func\<UUniqueObject,bool\>\) Method

Tries to get all related values of the specified type for the given unique object\.

```csharp
public bool TryGetRelatedValues<UUniqueObject>(out System.Collections.Generic.List<UUniqueObject>? uniqueObjects, TUniqueObject? value, System.Func<UUniqueObject?,bool>? func=null)
    where UUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValues_UUniqueObject_(System.Collections.Generic.List_UUniqueObject_,TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject'></a>

`UUniqueObject`

The type of the unique objects to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValues_UUniqueObject_(System.Collections.Generic.List_UUniqueObject_,TUniqueObject,System.Func_UUniqueObject,bool_).uniqueObjects'></a>

`uniqueObjects` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValues_UUniqueObject_(System.Collections.Generic.List_UUniqueObject_,TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelatedValues\<UUniqueObject\>\(System\.Collections\.Generic\.List\<UUniqueObject\>, TUniqueObject, System\.Func\<UUniqueObject,bool\>\)\.UUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains the list of related unique objects found; otherwise, null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValues_UUniqueObject_(System.Collections.Generic.List_UUniqueObject_,TUniqueObject,System.Func_UUniqueObject,bool_).value'></a>

`value` [TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TUniqueObject')

The unique object for which to retrieve related values\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValues_UUniqueObject_(System.Collections.Generic.List_UUniqueObject_,TUniqueObject,System.Func_UUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelatedValues_UUniqueObject_(System.Collections.Generic.List_UUniqueObject_,TUniqueObject,System.Func_UUniqueObject,bool_).UUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelatedValues\<UUniqueObject\>\(System\.Collections\.Generic\.List\<UUniqueObject\>, TUniqueObject, System\.Func\<UUniqueObject,bool\>\)\.UUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the related values\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more related values were found; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelation_ZRelation_(DiGi.Core.Interfaces.IUniqueReference,ZRelation,System.Func_ZRelation,bool_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelation\<ZRelation\>\(IUniqueReference, ZRelation, Func\<ZRelation,bool\>\) Method

Tries to get a relation of the specified type that contains the given unique reference and optionally matches the predicate\.

```csharp
public bool TryGetRelation<ZRelation>(DiGi.Core.Interfaces.IUniqueReference? uniqueReference, out ZRelation? relation, System.Func<ZRelation?,bool>? func=null)
    where ZRelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelation_ZRelation_(DiGi.Core.Interfaces.IUniqueReference,ZRelation,System.Func_ZRelation,bool_).ZRelation'></a>

`ZRelation`

The type of relation to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelation_ZRelation_(DiGi.Core.Interfaces.IUniqueReference,ZRelation,System.Func_ZRelation,bool_).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

The unique reference used to identify the relation\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelation_ZRelation_(DiGi.Core.Interfaces.IUniqueReference,ZRelation,System.Func_ZRelation,bool_).relation'></a>

`relation` [ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelation_ZRelation_(DiGi.Core.Interfaces.IUniqueReference,ZRelation,System.Func_ZRelation,bool_).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelation\<ZRelation\>\(DiGi\.Core\.Interfaces\.IUniqueReference, ZRelation, System\.Func\<ZRelation,bool\>\)\.ZRelation')

When this method returns, contains the relation found; otherwise, null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelation_ZRelation_(DiGi.Core.Interfaces.IUniqueReference,ZRelation,System.Func_ZRelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelation_ZRelation_(DiGi.Core.Interfaces.IUniqueReference,ZRelation,System.Func_ZRelation,bool_).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelation\<ZRelation\>\(DiGi\.Core\.Interfaces\.IUniqueReference, ZRelation, System\.Func\<ZRelation,bool\>\)\.ZRelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the relation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a matching relation was found; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelation_ZRelation_(ZRelation,System.Func_ZRelation,bool_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelation\<ZRelation\>\(ZRelation, Func\<ZRelation,bool\>\) Method

Tries to get a relation of the specified type that optionally matches the predicate\.

```csharp
public bool TryGetRelation<ZRelation>(out ZRelation? relation, System.Func<ZRelation?,bool>? func=null)
    where ZRelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelation_ZRelation_(ZRelation,System.Func_ZRelation,bool_).ZRelation'></a>

`ZRelation`

The type of relation to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelation_ZRelation_(ZRelation,System.Func_ZRelation,bool_).relation'></a>

`relation` [ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelation_ZRelation_(ZRelation,System.Func_ZRelation,bool_).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelation\<ZRelation\>\(ZRelation, System\.Func\<ZRelation,bool\>\)\.ZRelation')

When this method returns, contains the relation found; otherwise, null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelation_ZRelation_(ZRelation,System.Func_ZRelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelation_ZRelation_(ZRelation,System.Func_ZRelation,bool_).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelation\<ZRelation\>\(ZRelation, System\.Func\<ZRelation,bool\>\)\.ZRelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the relation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a matching relation was found; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelations_ZRelation_(System.Collections.Generic.List_ZRelation_,System.Func_ZRelation,bool_)'></a>

## UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelations\<ZRelation\>\(List\<ZRelation\>, Func\<ZRelation,bool\>\) Method

Tries to get all relations of the specified type that optionally match the predicate\.

```csharp
public bool TryGetRelations<ZRelation>(out System.Collections.Generic.List<ZRelation>? relations, System.Func<ZRelation?,bool>? func=null)
    where ZRelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelations_ZRelation_(System.Collections.Generic.List_ZRelation_,System.Func_ZRelation,bool_).ZRelation'></a>

`ZRelation`

The type of relation to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelations_ZRelation_(System.Collections.Generic.List_ZRelation_,System.Func_ZRelation,bool_).relations'></a>

`relations` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelations_ZRelation_(System.Collections.Generic.List_ZRelation_,System.Func_ZRelation,bool_).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelations\<ZRelation\>\(System\.Collections\.Generic\.List\<ZRelation\>, System\.Func\<ZRelation,bool\>\)\.ZRelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains the list of relations found; otherwise, null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelations_ZRelation_(System.Collections.Generic.List_ZRelation_,System.Func_ZRelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[ZRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationCluster_TUniqueObject,XRelation_.TryGetRelations_ZRelation_(System.Collections.Generic.List_ZRelation_,System.Func_ZRelation,bool_).ZRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationCluster\<TUniqueObject,XRelation\>\.TryGetRelations\<ZRelation\>\(System\.Collections\.Generic\.List\<ZRelation\>, System\.Func\<ZRelation,bool\>\)\.ZRelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the relations\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more relations were found; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\> Class

Provides a base class for unique objects that manage relations through a UniqueObjectRelationCluster\.

```csharp
public abstract class UniqueObjectRelationClusterModel<TUniqueObject,XRelation> : DiGi.Core.Classes.GuidModel
    where TUniqueObject : DiGi.Core.Interfaces.IUniqueObject
    where XRelation : DiGi.Core.Relation.Interfaces.IRelation
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TUniqueObject'></a>

`TUniqueObject`

The type of the unique object\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.XRelation'></a>

`XRelation`

The type of the relation\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → [DiGi\.Core\.Classes\.GuidModel](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidmodel 'DiGi\.Core\.Classes\.GuidModel') → UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>
### Constructors

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.UniqueObjectRelationClusterModel()'></a>

## UniqueObjectRelationClusterModel\(\) Constructor

Initializes a new instance of the UniqueObjectRelationClusterModel class\.

```csharp
public UniqueObjectRelationClusterModel();
```

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.UniqueObjectRelationClusterModel(DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_)'></a>

## UniqueObjectRelationClusterModel\(UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\) Constructor

Initializes a new instance of the UniqueObjectRelationClusterModel class by cloning another instance\.

```csharp
public UniqueObjectRelationClusterModel(DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel<TUniqueObject,XRelation>? uniqueObjectRelationClusterModel);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.UniqueObjectRelationClusterModel(DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_).uniqueObjectRelationClusterModel'></a>

`uniqueObjectRelationClusterModel` [DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel&lt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_ 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>')[TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TUniqueObject')[,](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_ 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>')[XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.XRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.XRelation')[&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_ 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>')

The existing model instance to clone from\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.UniqueObjectRelationClusterModel(System.Text.Json.Nodes.JsonObject)'></a>

## UniqueObjectRelationClusterModel\(JsonObject\) Constructor

Initializes a new instance of the UniqueObjectRelationClusterModel class from a JsonObject\.

```csharp
public UniqueObjectRelationClusterModel(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.UniqueObjectRelationClusterModel(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to initialize the model from\.
### Methods

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetNewGuid(System.Type)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetNewGuid\(Type\) Method

Creates a new Guid for a unique object of the specified type\.

```csharp
public System.Guid GetNewGuid(System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetNewGuid(System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type of the unique object\.

#### Returns
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')  
A new unique identifier \(Guid\)\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetNewGuid_YUniqueObject_()'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetNewGuid\<YUniqueObject\>\(\) Method

Creates a new Guid for a unique object of the specified generic type\.

```csharp
public System.Guid GetNewGuid<YUniqueObject>()
    where YUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetNewGuid_YUniqueObject_().YUniqueObject'></a>

`YUniqueObject`

The type of unique object for which to create a new GUID\.

#### Returns
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')  
A new unique identifier \(Guid\)\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObject_YUniqueObject_(DiGi.Core.Classes.GuidReference)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetObject\<YUniqueObject\>\(GuidReference\) Method

Gets the unique object of the specified type identified by the given GUID reference\.

```csharp
public YUniqueObject? GetObject<YUniqueObject>(DiGi.Core.Classes.GuidReference? guidReference)
    where YUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObject_YUniqueObject_(DiGi.Core.Classes.GuidReference).YUniqueObject'></a>

`YUniqueObject`

The type of unique object to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObject_YUniqueObject_(DiGi.Core.Classes.GuidReference).guidReference'></a>

`guidReference` [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')

The GUID reference identifying the unique object\.

#### Returns
[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObject_YUniqueObject_(DiGi.Core.Classes.GuidReference).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetObject\<YUniqueObject\>\(DiGi\.Core\.Classes\.GuidReference\)\.YUniqueObject')  
The unique object associated with the provided GUID reference, or null if not found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObject_YUniqueObject_(System.Func_YUniqueObject,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetObject\<YUniqueObject\>\(Func\<YUniqueObject,bool\>\) Method

Gets the first unique object of the specified type that optionally matches the predicate\.

```csharp
public YUniqueObject? GetObject<YUniqueObject>(System.Func<YUniqueObject?,bool>? func=null)
    where YUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObject_YUniqueObject_(System.Func_YUniqueObject,bool_).YUniqueObject'></a>

`YUniqueObject`

The type of unique object to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObject_YUniqueObject_(System.Func_YUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObject_YUniqueObject_(System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetObject\<YUniqueObject\>\(System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the unique objects\.

#### Returns
[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObject_YUniqueObject_(System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetObject\<YUniqueObject\>\(System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')  
The first unique object that matches the predicate, or null if no match is found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObjects_YUniqueObject_(System.Func_YUniqueObject,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetObjects\<YUniqueObject\>\(Func\<YUniqueObject,bool\>\) Method

Gets all unique objects of the specified type that optionally match the predicate\.

```csharp
public System.Collections.Generic.List<YUniqueObject>? GetObjects<YUniqueObject>(System.Func<YUniqueObject?,bool>? func=null)
    where YUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObjects_YUniqueObject_(System.Func_YUniqueObject,bool_).YUniqueObject'></a>

`YUniqueObject`

The type of unique object to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObjects_YUniqueObject_(System.Func_YUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObjects_YUniqueObject_(System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetObjects\<YUniqueObject\>\(System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the unique objects\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObjects_YUniqueObject_(System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetObjects\<YUniqueObject\>\(System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of unique objects that match the predicate, or null if none are found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObjects_YUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide,System.Func_YUniqueObject,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetObjects\<YUniqueObject\>\(XRelation, RelationSide, Func\<YUniqueObject,bool\>\) Method

Gets all unique objects of the specified type related through the specified relation on the given side that optionally match the predicate\.

```csharp
public System.Collections.Generic.List<YUniqueObject>? GetObjects<YUniqueObject>(XRelation? relation, DiGi.Core.Relation.Enums.RelationSide relationSide, System.Func<YUniqueObject?,bool>? func=null)
    where YUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObjects_YUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide,System.Func_YUniqueObject,bool_).YUniqueObject'></a>

`YUniqueObject`

The type of the unique objects to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObjects_YUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide,System.Func_YUniqueObject,bool_).relation'></a>

`relation` [XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.XRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.XRelation')

The relation used to find the objects\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObjects_YUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide,System.Func_YUniqueObject,bool_).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to query\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObjects_YUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide,System.Func_YUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObjects_YUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetObjects\<YUniqueObject\>\(XRelation, DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the retrieved objects\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetObjects_YUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetObjects\<YUniqueObject\>\(XRelation, DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of unique objects that match the criteria, or null if none are found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObject_YUniqueObject_(TUniqueObject,System.Func_YUniqueObject,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelatedObject\<YUniqueObject\>\(TUniqueObject, Func\<YUniqueObject,bool\>\) Method

Gets the related object of the specified type for the given unique object that optionally matches the predicate\.

```csharp
public YUniqueObject? GetRelatedObject<YUniqueObject>(TUniqueObject? uniqueObject, System.Func<YUniqueObject?,bool>? func=null)
    where YUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObject_YUniqueObject_(TUniqueObject,System.Func_YUniqueObject,bool_).YUniqueObject'></a>

`YUniqueObject`

The type of the related object\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObject_YUniqueObject_(TUniqueObject,System.Func_YUniqueObject,bool_).uniqueObject'></a>

`uniqueObject` [TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TUniqueObject')

The unique object to find a relation for\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObject_YUniqueObject_(TUniqueObject,System.Func_YUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObject_YUniqueObject_(TUniqueObject,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelatedObject\<YUniqueObject\>\(TUniqueObject, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the related object\.

#### Returns
[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObject_YUniqueObject_(TUniqueObject,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelatedObject\<YUniqueObject\>\(TUniqueObject, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')  
The related object that matches the criteria, or null if not found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjectDictionary_YUniqueObject,URelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_YUniqueObject,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelatedObjectDictionary\<YUniqueObject,URelation\>\(IEnumerable\<TUniqueObject\>, Func\<YUniqueObject,bool\>\) Method

Gets a dictionary mapping unique references to related objects of the specified type using the specified relation type\.

```csharp
public virtual System.Collections.Generic.Dictionary<DiGi.Core.Interfaces.IUniqueReference,YUniqueObject>? GetRelatedObjectDictionary<YUniqueObject,URelation>(System.Collections.Generic.IEnumerable<TUniqueObject>? uniqueObjects, System.Func<YUniqueObject?,bool>? func=null)
    where YUniqueObject : TUniqueObject
    where URelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjectDictionary_YUniqueObject,URelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject'></a>

`YUniqueObject`

The type of the related objects\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjectDictionary_YUniqueObject,URelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_YUniqueObject,bool_).URelation'></a>

`URelation`

The type of the relation used for mapping\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjectDictionary_YUniqueObject,URelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_YUniqueObject,bool_).uniqueObjects'></a>

`uniqueObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique objects to find relations for\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjectDictionary_YUniqueObject,URelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_YUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjectDictionary_YUniqueObject,URelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelatedObjectDictionary\<YUniqueObject,URelation\>\(System\.Collections\.Generic\.IEnumerable\<TUniqueObject\>, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the related objects\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjectDictionary_YUniqueObject,URelation_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelatedObjectDictionary\<YUniqueObject,URelation\>\(System\.Collections\.Generic\.IEnumerable\<TUniqueObject\>, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping unique references to their corresponding related objects, or null if none are found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjectDictionary_YUniqueObject_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_YUniqueObject,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelatedObjectDictionary\<YUniqueObject\>\(IEnumerable\<TUniqueObject\>, Func\<YUniqueObject,bool\>\) Method

Gets a dictionary mapping unique references to related objects of the specified type for the given unique objects\.

```csharp
public System.Collections.Generic.Dictionary<DiGi.Core.Interfaces.IUniqueReference,YUniqueObject>? GetRelatedObjectDictionary<YUniqueObject>(System.Collections.Generic.IEnumerable<TUniqueObject>? uniqueObjects, System.Func<YUniqueObject?,bool>? func=null)
    where YUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjectDictionary_YUniqueObject_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject'></a>

`YUniqueObject`

The type of the related objects\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjectDictionary_YUniqueObject_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_YUniqueObject,bool_).uniqueObjects'></a>

`uniqueObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique objects to find relations for\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjectDictionary_YUniqueObject_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_YUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjectDictionary_YUniqueObject_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelatedObjectDictionary\<YUniqueObject\>\(System\.Collections\.Generic\.IEnumerable\<TUniqueObject\>, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the related objects\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjectDictionary_YUniqueObject_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelatedObjectDictionary\<YUniqueObject\>\(System\.Collections\.Generic\.IEnumerable\<TUniqueObject\>, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary mapping unique references to their corresponding related objects, or null if none are found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjects_YUniqueObject_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_YUniqueObject,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelatedObjects\<YUniqueObject\>\(IEnumerable\<TUniqueObject\>, Func\<YUniqueObject,bool\>\) Method

Gets all related objects of the specified type for the given unique objects that optionally match the predicate\.

```csharp
public System.Collections.Generic.List<YUniqueObject>? GetRelatedObjects<YUniqueObject>(System.Collections.Generic.IEnumerable<TUniqueObject>? uniqueObjects, System.Func<YUniqueObject?,bool>? func=null)
    where YUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjects_YUniqueObject_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject'></a>

`YUniqueObject`

The type of the related objects\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjects_YUniqueObject_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_YUniqueObject,bool_).uniqueObjects'></a>

`uniqueObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique objects to find relations for\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjects_YUniqueObject_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_YUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjects_YUniqueObject_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelatedObjects\<YUniqueObject\>\(System\.Collections\.Generic\.IEnumerable\<TUniqueObject\>, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the related objects\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjects_YUniqueObject_(System.Collections.Generic.IEnumerable_TUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelatedObjects\<YUniqueObject\>\(System\.Collections\.Generic\.IEnumerable\<TUniqueObject\>, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of related objects that match the criteria, or null if none are found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjects_YUniqueObject_(TUniqueObject,System.Func_YUniqueObject,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelatedObjects\<YUniqueObject\>\(TUniqueObject, Func\<YUniqueObject,bool\>\) Method

Gets all related objects of the specified type for the given unique object that optionally match the predicate\.

```csharp
public System.Collections.Generic.List<YUniqueObject>? GetRelatedObjects<YUniqueObject>(TUniqueObject? uniqueObject, System.Func<YUniqueObject?,bool>? func=null)
    where YUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjects_YUniqueObject_(TUniqueObject,System.Func_YUniqueObject,bool_).YUniqueObject'></a>

`YUniqueObject`

The type of the related objects\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjects_YUniqueObject_(TUniqueObject,System.Func_YUniqueObject,bool_).uniqueObject'></a>

`uniqueObject` [TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TUniqueObject')

The unique object to find relations for\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjects_YUniqueObject_(TUniqueObject,System.Func_YUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjects_YUniqueObject_(TUniqueObject,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelatedObjects\<YUniqueObject\>\(TUniqueObject, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the related objects\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelatedObjects_YUniqueObject_(TUniqueObject,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelatedObjects\<YUniqueObject\>\(TUniqueObject, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of related objects that match the predicate, or null if none are found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelation_URelation_(TUniqueObject,System.Func_URelation,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelation\<URelation\>\(TUniqueObject, Func\<URelation,bool\>\) Method

Gets the relation of the specified type for the given unique object that optionally matches the predicate\.

```csharp
public URelation? GetRelation<URelation>(TUniqueObject? uniqueObject, System.Func<URelation?,bool>? func=null)
    where URelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelation_URelation_(TUniqueObject,System.Func_URelation,bool_).URelation'></a>

`URelation`

The type of the relation\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelation_URelation_(TUniqueObject,System.Func_URelation,bool_).uniqueObject'></a>

`uniqueObject` [TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TUniqueObject')

The unique object for which to get the relation\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelation_URelation_(TUniqueObject,System.Func_URelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[URelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelation_URelation_(TUniqueObject,System.Func_URelation,bool_).URelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelation\<URelation\>\(TUniqueObject, System\.Func\<URelation,bool\>\)\.URelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the relation\.

#### Returns
[URelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelation_URelation_(TUniqueObject,System.Func_URelation,bool_).URelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelation\<URelation\>\(TUniqueObject, System\.Func\<URelation,bool\>\)\.URelation')  
The relation that matches the predicate, or null if not found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelation_YUniqueObject_(System.Func_YUniqueObject,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelation\<YUniqueObject\>\(Func\<YUniqueObject,bool\>\) Method

Gets the first relation of the specified type that optionally matches the predicate\.

```csharp
public YUniqueObject? GetRelation<YUniqueObject>(System.Func<YUniqueObject?,bool>? func=null)
    where YUniqueObject : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelation_YUniqueObject_(System.Func_YUniqueObject,bool_).YUniqueObject'></a>

`YUniqueObject`

The type of the unique object\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelation_YUniqueObject_(System.Func_YUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelation_YUniqueObject_(System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelation\<YUniqueObject\>\(System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the result\.

#### Returns
[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelation_YUniqueObject_(System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelation\<YUniqueObject\>\(System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')  
The first matching unique object, or null if not found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelations_URelation_(System.Func_URelation,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelations\<URelation\>\(Func\<URelation,bool\>\) Method

Gets all relations of the specified type that optionally match the predicate\.

```csharp
public System.Collections.Generic.List<URelation>? GetRelations<URelation>(System.Func<URelation?,bool>? func=null)
    where URelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelations_URelation_(System.Func_URelation,bool_).URelation'></a>

`URelation`

The type of the relation\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelations_URelation_(System.Func_URelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[URelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelations_URelation_(System.Func_URelation,bool_).URelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelations\<URelation\>\(System\.Func\<URelation,bool\>\)\.URelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the relations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[URelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.GetRelations_URelation_(System.Func_URelation,bool_).URelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.GetRelations\<URelation\>\(System\.Func\<URelation,bool\>\)\.URelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of relations that match the predicate, or null if none are found\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObject_YUniqueObject_(DiGi.Core.Classes.GuidReference,YUniqueObject)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetObject\<YUniqueObject\>\(GuidReference, YUniqueObject\) Method

Determines whether a unique object of the specified type exists for the given GUID reference\.

```csharp
public bool TryGetObject<YUniqueObject>(DiGi.Core.Classes.GuidReference? guidReference, out YUniqueObject? uniqueObject)
    where YUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObject_YUniqueObject_(DiGi.Core.Classes.GuidReference,YUniqueObject).YUniqueObject'></a>

`YUniqueObject`

The type of the unique object to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObject_YUniqueObject_(DiGi.Core.Classes.GuidReference,YUniqueObject).guidReference'></a>

`guidReference` [DiGi\.Core\.Classes\.GuidReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidreference 'DiGi\.Core\.Classes\.GuidReference')

The GUID reference of the unique object\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObject_YUniqueObject_(DiGi.Core.Classes.GuidReference,YUniqueObject).uniqueObject'></a>

`uniqueObject` [YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObject_YUniqueObject_(DiGi.Core.Classes.GuidReference,YUniqueObject).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetObject\<YUniqueObject\>\(DiGi\.Core\.Classes\.GuidReference, YUniqueObject\)\.YUniqueObject')

When this method returns, contains the unique object if found; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a unique object was found for the given GUID reference; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObject_YUniqueObject_(YUniqueObject,System.Func_YUniqueObject,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetObject\<YUniqueObject\>\(YUniqueObject, Func\<YUniqueObject,bool\>\) Method

Determines whether a unique object of the specified type exists and optionally matches the predicate\.

```csharp
public virtual bool TryGetObject<YUniqueObject>(out YUniqueObject? uniqueObject, System.Func<YUniqueObject?,bool>? func=null)
    where YUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObject_YUniqueObject_(YUniqueObject,System.Func_YUniqueObject,bool_).YUniqueObject'></a>

`YUniqueObject`

The type of the unique object\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObject_YUniqueObject_(YUniqueObject,System.Func_YUniqueObject,bool_).uniqueObject'></a>

`uniqueObject` [YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObject_YUniqueObject_(YUniqueObject,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetObject\<YUniqueObject\>\(YUniqueObject, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')

When this method returns, contains the unique object if found; otherwise, null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObject_YUniqueObject_(YUniqueObject,System.Func_YUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObject_YUniqueObject_(YUniqueObject,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetObject\<YUniqueObject\>\(YUniqueObject, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the unique object\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the unique object was found and matches the predicate; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObjects_YUniqueObject_(System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetObjects\<YUniqueObject\>\(List\<YUniqueObject\>, Func\<YUniqueObject,bool\>\) Method

Determines whether any unique objects of the specified type exist and optionally match the predicate\.

```csharp
public virtual bool TryGetObjects<YUniqueObject>(out System.Collections.Generic.List<YUniqueObject>? uniqueObjects, System.Func<YUniqueObject?,bool>? func=null)
    where YUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObjects_YUniqueObject_(System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject'></a>

`YUniqueObject`

The type of the unique objects to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObjects_YUniqueObject_(System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).uniqueObjects'></a>

`uniqueObjects` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObjects_YUniqueObject_(System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetObjects\<YUniqueObject\>\(System\.Collections\.Generic\.List\<YUniqueObject\>, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of found unique objects if any exist; otherwise, null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObjects_YUniqueObject_(System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObjects_YUniqueObject_(System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetObjects\<YUniqueObject\>\(System\.Collections\.Generic\.List\<YUniqueObject\>, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the unique objects\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more unique objects were found that match the predicate; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObjects_YUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetObjects\<YUniqueObject\>\(XRelation, RelationSide, List\<YUniqueObject\>, Func\<YUniqueObject,bool\>\) Method

Determines whether any unique objects of the specified type exist that are related through the specified relation on the given side and optionally match the predicate\.

```csharp
public virtual bool TryGetObjects<YUniqueObject>(XRelation? relation, DiGi.Core.Relation.Enums.RelationSide relationSide, out System.Collections.Generic.List<YUniqueObject>? uniqueObjects, System.Func<YUniqueObject?,bool>? func=null)
    where YUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObjects_YUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject'></a>

`YUniqueObject`

The type of the unique objects to retrieve\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObjects_YUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).relation'></a>

`relation` [XRelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.XRelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.XRelation')

The relation used to find the unique objects\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObjects_YUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

The side of the relation to search on\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObjects_YUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).uniqueObjects'></a>

`uniqueObjects` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObjects_YUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetObjects\<YUniqueObject\>\(XRelation, DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Collections\.Generic\.List\<YUniqueObject\>, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of found unique objects if any exist; otherwise, null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObjects_YUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetObjects_YUniqueObject_(XRelation,DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetObjects\<YUniqueObject\>\(XRelation, DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Collections\.Generic\.List\<YUniqueObject\>, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the unique objects\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more unique objects were found that match the predicate; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObject_YUniqueObject,URelation_(TUniqueObject,YUniqueObject,System.Func_YUniqueObject,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelatedObject\<YUniqueObject,URelation\>\(TUniqueObject, YUniqueObject, Func\<YUniqueObject,bool\>\) Method

Determines whether a related object of the specified type exists for the given unique object using the specified relation type and optionally matches the predicate\.

```csharp
public virtual bool TryGetRelatedObject<YUniqueObject,URelation>(TUniqueObject? uniqueObject, out YUniqueObject? relatedUniqueObject, System.Func<YUniqueObject?,bool>? func=null)
    where YUniqueObject : TUniqueObject
    where URelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObject_YUniqueObject,URelation_(TUniqueObject,YUniqueObject,System.Func_YUniqueObject,bool_).YUniqueObject'></a>

`YUniqueObject`

The type of the related unique object\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObject_YUniqueObject,URelation_(TUniqueObject,YUniqueObject,System.Func_YUniqueObject,bool_).URelation'></a>

`URelation`

The type of the relation used to find the related object\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObject_YUniqueObject,URelation_(TUniqueObject,YUniqueObject,System.Func_YUniqueObject,bool_).uniqueObject'></a>

`uniqueObject` [TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TUniqueObject')

The unique object for which to find a related object\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObject_YUniqueObject,URelation_(TUniqueObject,YUniqueObject,System.Func_YUniqueObject,bool_).relatedUniqueObject'></a>

`relatedUniqueObject` [YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObject_YUniqueObject,URelation_(TUniqueObject,YUniqueObject,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelatedObject\<YUniqueObject,URelation\>\(TUniqueObject, YUniqueObject, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')

When this method returns, contains the related unique object if found; otherwise, null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObject_YUniqueObject,URelation_(TUniqueObject,YUniqueObject,System.Func_YUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObject_YUniqueObject,URelation_(TUniqueObject,YUniqueObject,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelatedObject\<YUniqueObject,URelation\>\(TUniqueObject, YUniqueObject, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the related object\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a related object was found that matches the predicate; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObject_YUniqueObject_(TUniqueObject,YUniqueObject,System.Func_YUniqueObject,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelatedObject\<YUniqueObject\>\(TUniqueObject, YUniqueObject, Func\<YUniqueObject,bool\>\) Method

Determines whether a related object of the specified type exists for the given unique object and optionally matches the predicate\.

```csharp
public virtual bool TryGetRelatedObject<YUniqueObject>(TUniqueObject? uniqueObject, out YUniqueObject? relatedUniqueObject, System.Func<YUniqueObject?,bool>? func=null)
    where YUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObject_YUniqueObject_(TUniqueObject,YUniqueObject,System.Func_YUniqueObject,bool_).YUniqueObject'></a>

`YUniqueObject`

The type of the related unique object\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObject_YUniqueObject_(TUniqueObject,YUniqueObject,System.Func_YUniqueObject,bool_).uniqueObject'></a>

`uniqueObject` [TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TUniqueObject')

The unique object for which to find a related object\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObject_YUniqueObject_(TUniqueObject,YUniqueObject,System.Func_YUniqueObject,bool_).relatedUniqueObject'></a>

`relatedUniqueObject` [YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObject_YUniqueObject_(TUniqueObject,YUniqueObject,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelatedObject\<YUniqueObject\>\(TUniqueObject, YUniqueObject, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')

When this method returns, contains the related unique object if found; otherwise, null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObject_YUniqueObject_(TUniqueObject,YUniqueObject,System.Func_YUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObject_YUniqueObject_(TUniqueObject,YUniqueObject,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelatedObject\<YUniqueObject\>\(TUniqueObject, YUniqueObject, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate to filter the related object\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a related object was found that matches the predicate; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObjects_YUniqueObject,URelation_(TUniqueObject,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelatedObjects\<YUniqueObject,URelation\>\(TUniqueObject, List\<YUniqueObject\>, Func\<YUniqueObject,bool\>\) Method

Determines whether any related objects of the specified type exist for the given unique object using the specified relation type and optionally match the predicate\.

```csharp
public virtual bool TryGetRelatedObjects<YUniqueObject,URelation>(TUniqueObject? uniqueObject, out System.Collections.Generic.List<YUniqueObject>? uniqueObjects, System.Func<YUniqueObject?,bool>? func=null)
    where YUniqueObject : TUniqueObject
    where URelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObjects_YUniqueObject,URelation_(TUniqueObject,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject'></a>

`YUniqueObject`

The type of the related objects\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObjects_YUniqueObject,URelation_(TUniqueObject,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).URelation'></a>

`URelation`

The type of the relation used to identify related objects\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObjects_YUniqueObject,URelation_(TUniqueObject,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).uniqueObject'></a>

`uniqueObject` [TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TUniqueObject')

The unique object to evaluate\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObjects_YUniqueObject,URelation_(TUniqueObject,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).uniqueObjects'></a>

`uniqueObjects` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObjects_YUniqueObject,URelation_(TUniqueObject,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelatedObjects\<YUniqueObject,URelation\>\(TUniqueObject, System\.Collections\.Generic\.List\<YUniqueObject\>, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of related objects found; otherwise, null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObjects_YUniqueObject,URelation_(TUniqueObject,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObjects_YUniqueObject,URelation_(TUniqueObject,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelatedObjects\<YUniqueObject,URelation\>\(TUniqueObject, System\.Collections\.Generic\.List\<YUniqueObject\>, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate used to filter the related objects\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more related objects were found; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObjects_YUniqueObject_(TUniqueObject,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelatedObjects\<YUniqueObject\>\(TUniqueObject, List\<YUniqueObject\>, Func\<YUniqueObject,bool\>\) Method

Determines whether any related objects of the specified type exist for the given unique object and optionally match the predicate\.

```csharp
public virtual bool TryGetRelatedObjects<YUniqueObject>(TUniqueObject? uniqueObject, out System.Collections.Generic.List<YUniqueObject>? uniqueObjects, System.Func<YUniqueObject?,bool>? func=null)
    where YUniqueObject : TUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObjects_YUniqueObject_(TUniqueObject,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject'></a>

`YUniqueObject`

The type of the related objects\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObjects_YUniqueObject_(TUniqueObject,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).uniqueObject'></a>

`uniqueObject` [TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TUniqueObject')

The unique object to evaluate\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObjects_YUniqueObject_(TUniqueObject,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).uniqueObjects'></a>

`uniqueObjects` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObjects_YUniqueObject_(TUniqueObject,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelatedObjects\<YUniqueObject\>\(TUniqueObject, System\.Collections\.Generic\.List\<YUniqueObject\>, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of related objects found; otherwise, null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObjects_YUniqueObject_(TUniqueObject,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[YUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelatedObjects_YUniqueObject_(TUniqueObject,System.Collections.Generic.List_YUniqueObject_,System.Func_YUniqueObject,bool_).YUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelatedObjects\<YUniqueObject\>\(TUniqueObject, System\.Collections\.Generic\.List\<YUniqueObject\>, System\.Func\<YUniqueObject,bool\>\)\.YUniqueObject')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate used to filter the related objects\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more related objects were found; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelation_URelation_(TUniqueObject,URelation,System.Func_URelation,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelation\<URelation\>\(TUniqueObject, URelation, Func\<URelation,bool\>\) Method

Determines whether a relation of the specified type exists for the given unique object and optionally matches the predicate\.

```csharp
public bool TryGetRelation<URelation>(TUniqueObject uniqueObject, out URelation? relation, System.Func<URelation?,bool>? func=null)
    where URelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelation_URelation_(TUniqueObject,URelation,System.Func_URelation,bool_).URelation'></a>

`URelation`

The type of relation to search for\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelation_URelation_(TUniqueObject,URelation,System.Func_URelation,bool_).uniqueObject'></a>

`uniqueObject` [TUniqueObject](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TUniqueObject 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TUniqueObject')

The unique object to evaluate\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelation_URelation_(TUniqueObject,URelation,System.Func_URelation,bool_).relation'></a>

`relation` [URelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelation_URelation_(TUniqueObject,URelation,System.Func_URelation,bool_).URelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelation\<URelation\>\(TUniqueObject, URelation, System\.Func\<URelation,bool\>\)\.URelation')

When this method returns, contains the relation found; otherwise, null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelation_URelation_(TUniqueObject,URelation,System.Func_URelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[URelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelation_URelation_(TUniqueObject,URelation,System.Func_URelation,bool_).URelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelation\<URelation\>\(TUniqueObject, URelation, System\.Func\<URelation,bool\>\)\.URelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate used to filter the relation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a relation was found for the specified object; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelation_URelation_(URelation,System.Func_URelation,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelation\<URelation\>\(URelation, Func\<URelation,bool\>\) Method

Determines whether a relation of the specified type exists and optionally matches the predicate\.

```csharp
public virtual bool TryGetRelation<URelation>(out URelation? relation, System.Func<URelation?,bool>? func=null)
    where URelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelation_URelation_(URelation,System.Func_URelation,bool_).URelation'></a>

`URelation`

The type of relation to search for\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelation_URelation_(URelation,System.Func_URelation,bool_).relation'></a>

`relation` [URelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelation_URelation_(URelation,System.Func_URelation,bool_).URelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelation\<URelation\>\(URelation, System\.Func\<URelation,bool\>\)\.URelation')

When this method returns, contains the relation found; otherwise, null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelation_URelation_(URelation,System.Func_URelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[URelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelation_URelation_(URelation,System.Func_URelation,bool_).URelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelation\<URelation\>\(URelation, System\.Func\<URelation,bool\>\)\.URelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate used to filter the relation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a relation was found; otherwise, false\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelations_URelation_(System.Collections.Generic.List_URelation_,System.Func_URelation,bool_)'></a>

## UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelations\<URelation\>\(List\<URelation\>, Func\<URelation,bool\>\) Method

Determines whether any relations of the specified type exist and optionally match the predicate\.

```csharp
public virtual bool TryGetRelations<URelation>(out System.Collections.Generic.List<URelation>? relations, System.Func<URelation?,bool>? func=null)
    where URelation : XRelation;
```
#### Type parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelations_URelation_(System.Collections.Generic.List_URelation_,System.Func_URelation,bool_).URelation'></a>

`URelation`

The type of relation to search for\.
#### Parameters

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelations_URelation_(System.Collections.Generic.List_URelation_,System.Func_URelation,bool_).relations'></a>

`relations` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[URelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelations_URelation_(System.Collections.Generic.List_URelation_,System.Func_URelation,bool_).URelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelations\<URelation\>\(System\.Collections\.Generic\.List\<URelation\>, System\.Func\<URelation,bool\>\)\.URelation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of relations found; otherwise, null\.

<a name='DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelations_URelation_(System.Collections.Generic.List_URelation_,System.Func_URelation,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[URelation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.UniqueObjectRelationClusterModel_TUniqueObject,XRelation_.TryGetRelations_URelation_(System.Collections.Generic.List_URelation_,System.Func_URelation,bool_).URelation 'DiGi\.Core\.Relation\.Classes\.UniqueObjectRelationClusterModel\<TUniqueObject,XRelation\>\.TryGetRelations\<URelation\>\(System\.Collections\.Generic\.List\<URelation\>, System\.Func\<URelation,bool\>\)\.URelation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate used to filter the relations\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more relations were found; otherwise, false\.