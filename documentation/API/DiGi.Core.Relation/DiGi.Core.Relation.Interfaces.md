#### [DiGi\.Core\.Relation](DiGi.Core.Relation.Overview.md 'DiGi\.Core\.Relation\.Overview')

## DiGi\.Core\.Relation\.Interfaces Namespace
### Interfaces

<a name='DiGi.Core.Relation.Interfaces.IBidirectionalRelation'></a>

## IBidirectionalRelation Interface

Defines the contract for a bidirectional relation between unique objects\.

```csharp
public interface IBidirectionalRelation : DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [OneToManyBidirectionalRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>')  
↳ [OneToOneBidirectionalRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>')  
↳ [IBidirectionalRelation&lt;X,Y&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IBidirectionalRelation_X,Y_ 'DiGi\.Core\.Relation\.Interfaces\.IBidirectionalRelation\<X,Y\>')

Implements [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Core.Relation.Interfaces.IBidirectionalRelation_X,Y_'></a>

## IBidirectionalRelation\<X,Y\> Interface

Defines the contract for a bidirectional relation between two types of unique objects\.

```csharp
public interface IBidirectionalRelation<X,Y> : DiGi.Core.Relation.Interfaces.IBidirectionalRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation<X, Y>
    where X : DiGi.Core.Interfaces.IUniqueObject
    where Y : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Relation.Interfaces.IBidirectionalRelation_X,Y_.X'></a>

`X`

<a name='DiGi.Core.Relation.Interfaces.IBidirectionalRelation_X,Y_.Y'></a>

`Y`

Derived  
↳ [OneToManyBidirectionalRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>')  
↳ [OneToOneBidirectionalRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>')

Implements [IBidirectionalRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IBidirectionalRelation 'DiGi\.Core\.Relation\.Interfaces\.IBidirectionalRelation'), [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[X](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IBidirectionalRelation_X,Y_.X 'DiGi\.Core\.Relation\.Interfaces\.IBidirectionalRelation\<X,Y\>\.X')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[Y](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IBidirectionalRelation_X,Y_.Y 'DiGi\.Core\.Relation\.Interfaces\.IBidirectionalRelation\<X,Y\>\.Y')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')

<a name='DiGi.Core.Relation.Interfaces.IDirectionalRelation'></a>

## IDirectionalRelation Interface

Defines the contract for a directional relation between unique objects\.

```csharp
public interface IDirectionalRelation : DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [OneToManyDirectionalRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>')  
↳ [OneToOneDirectionalRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>')  
↳ [IDirectionalRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IDirectionalRelation\<XUniqueObject,YUniqueObject\>')

Implements [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Core.Relation.Interfaces.IDirectionalRelation_XUniqueObject,YUniqueObject_'></a>

## IDirectionalRelation\<XUniqueObject,YUniqueObject\> Interface

Defines the contract for a directional relation between two types of unique objects\.

```csharp
public interface IDirectionalRelation<XUniqueObject,YUniqueObject> : DiGi.Core.Relation.Interfaces.IDirectionalRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation<XUniqueObject, YUniqueObject>
    where XUniqueObject : DiGi.Core.Interfaces.IUniqueObject
    where YUniqueObject : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Relation.Interfaces.IDirectionalRelation_XUniqueObject,YUniqueObject_.XUniqueObject'></a>

`XUniqueObject`

The type of the source unique object\.

<a name='DiGi.Core.Relation.Interfaces.IDirectionalRelation_XUniqueObject,YUniqueObject_.YUniqueObject'></a>

`YUniqueObject`

The type of the target unique object\.

Derived  
↳ [OneToManyDirectionalRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>')  
↳ [OneToOneDirectionalRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>')

Implements [IDirectionalRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IDirectionalRelation 'DiGi\.Core\.Relation\.Interfaces\.IDirectionalRelation'), [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[XUniqueObject](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IDirectionalRelation_XUniqueObject,YUniqueObject_.XUniqueObject 'DiGi\.Core\.Relation\.Interfaces\.IDirectionalRelation\<XUniqueObject,YUniqueObject\>\.XUniqueObject')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[YUniqueObject](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IDirectionalRelation_XUniqueObject,YUniqueObject_.YUniqueObject 'DiGi\.Core\.Relation\.Interfaces\.IDirectionalRelation\<XUniqueObject,YUniqueObject\>\.YUniqueObject')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')

<a name='DiGi.Core.Relation.Interfaces.IManyToManyRelation'></a>

## IManyToManyRelation Interface

Defines the contract for a many\-to\-many relationship between unique objects\.

```csharp
public interface IManyToManyRelation : DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [ManyToManyRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>')  
↳ [IManyToManyRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToManyRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IManyToManyRelation\<XUniqueObject,YUniqueObject\>')

Implements [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Core.Relation.Interfaces.IManyToManyRelation.UniqueReferences_From'></a>

## IManyToManyRelation\.UniqueReferences\_From Property

Gets a list of unique references on the "from" side of the relation\.

```csharp
System.Collections.Generic.List<DiGi.Core.Interfaces.IUniqueReference>? UniqueReferences_From { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Core.Relation.Interfaces.IManyToManyRelation.UniqueReferences_To'></a>

## IManyToManyRelation\.UniqueReferences\_To Property

Gets a list of unique references on the "to" side of the relation\.

```csharp
System.Collections.Generic.List<DiGi.Core.Interfaces.IUniqueReference>? UniqueReferences_To { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Core.Relation.Interfaces.IManyToManyRelation_XUniqueObject,YUniqueObject_'></a>

## IManyToManyRelation\<XUniqueObject,YUniqueObject\> Interface

Defines the contract for a many\-to\-many relationship between two types of unique objects\.

```csharp
public interface IManyToManyRelation<XUniqueObject,YUniqueObject> : DiGi.Core.Relation.Interfaces.IManyToManyRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation<XUniqueObject, YUniqueObject>
    where XUniqueObject : DiGi.Core.Interfaces.IUniqueObject
    where YUniqueObject : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Relation.Interfaces.IManyToManyRelation_XUniqueObject,YUniqueObject_.XUniqueObject'></a>

`XUniqueObject`

<a name='DiGi.Core.Relation.Interfaces.IManyToManyRelation_XUniqueObject,YUniqueObject_.YUniqueObject'></a>

`YUniqueObject`

Derived  
↳ [ManyToManyRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>')

Implements [IManyToManyRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToManyRelation 'DiGi\.Core\.Relation\.Interfaces\.IManyToManyRelation'), [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[XUniqueObject](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToManyRelation_XUniqueObject,YUniqueObject_.XUniqueObject 'DiGi\.Core\.Relation\.Interfaces\.IManyToManyRelation\<XUniqueObject,YUniqueObject\>\.XUniqueObject')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[YUniqueObject](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToManyRelation_XUniqueObject,YUniqueObject_.YUniqueObject 'DiGi\.Core\.Relation\.Interfaces\.IManyToManyRelation\<XUniqueObject,YUniqueObject\>\.YUniqueObject')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')

<a name='DiGi.Core.Relation.Interfaces.IManyToOneRelation'></a>

## IManyToOneRelation Interface

Defines the contract for a many\-to\-one relationship between unique objects\.

```csharp
public interface IManyToOneRelation : DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [ManyToOneRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>')  
↳ [IManyToOneRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToOneRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IManyToOneRelation\<XUniqueObject,YUniqueObject\>')

Implements [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Core.Relation.Interfaces.IManyToOneRelation.UniqueReferences_From'></a>

## IManyToOneRelation\.UniqueReferences\_From Property

Gets a list of unique references on the "from" side of the relation\.

```csharp
System.Collections.Generic.List<DiGi.Core.Interfaces.IUniqueReference>? UniqueReferences_From { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Core.Relation.Interfaces.IManyToOneRelation.UniqueReference_To'></a>

## IManyToOneRelation\.UniqueReference\_To Property

Gets the unique reference on the "to" side of the relation\.

```csharp
DiGi.Core.Interfaces.IUniqueReference? UniqueReference_To { get; }
```

#### Property Value
[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

<a name='DiGi.Core.Relation.Interfaces.IManyToOneRelation_XUniqueObject,YUniqueObject_'></a>

## IManyToOneRelation\<XUniqueObject,YUniqueObject\> Interface

Defines the contract for a many\-to\-one relationship between two types of unique objects\.

```csharp
public interface IManyToOneRelation<XUniqueObject,YUniqueObject> : DiGi.Core.Relation.Interfaces.IManyToOneRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation<XUniqueObject, YUniqueObject>
    where XUniqueObject : DiGi.Core.Interfaces.IUniqueObject
    where YUniqueObject : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Relation.Interfaces.IManyToOneRelation_XUniqueObject,YUniqueObject_.XUniqueObject'></a>

`XUniqueObject`

<a name='DiGi.Core.Relation.Interfaces.IManyToOneRelation_XUniqueObject,YUniqueObject_.YUniqueObject'></a>

`YUniqueObject`

Derived  
↳ [ManyToOneRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>')

Implements [IManyToOneRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToOneRelation 'DiGi\.Core\.Relation\.Interfaces\.IManyToOneRelation'), [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[XUniqueObject](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToOneRelation_XUniqueObject,YUniqueObject_.XUniqueObject 'DiGi\.Core\.Relation\.Interfaces\.IManyToOneRelation\<XUniqueObject,YUniqueObject\>\.XUniqueObject')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[YUniqueObject](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToOneRelation_XUniqueObject,YUniqueObject_.YUniqueObject 'DiGi\.Core\.Relation\.Interfaces\.IManyToOneRelation\<XUniqueObject,YUniqueObject\>\.YUniqueObject')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')

<a name='DiGi.Core.Relation.Interfaces.IOneToManyRelation'></a>

## IOneToManyRelation Interface

Defines the contract for a one\-to\-many relationship between unique objects\.

```csharp
public interface IOneToManyRelation : DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [OneToManyRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>')  
↳ [IOneToManyRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToManyRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IOneToManyRelation\<XUniqueObject,YUniqueObject\>')

Implements [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Core.Relation.Interfaces.IOneToManyRelation.UniqueReferences_To'></a>

## IOneToManyRelation\.UniqueReferences\_To Property

Gets a list of unique references on the "to" side of the relation\.

```csharp
System.Collections.Generic.List<DiGi.Core.Interfaces.IUniqueReference>? UniqueReferences_To { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Core.Relation.Interfaces.IOneToManyRelation.UniqueReference_From'></a>

## IOneToManyRelation\.UniqueReference\_From Property

Gets the unique reference on the "from" side of the relation\.

```csharp
DiGi.Core.Interfaces.IUniqueReference? UniqueReference_From { get; }
```

#### Property Value
[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

<a name='DiGi.Core.Relation.Interfaces.IOneToManyRelation_XUniqueObject,YUniqueObject_'></a>

## IOneToManyRelation\<XUniqueObject,YUniqueObject\> Interface

Defines the contract for a one\-to\-many relationship between two types of unique objects\.

```csharp
public interface IOneToManyRelation<XUniqueObject,YUniqueObject> : DiGi.Core.Relation.Interfaces.IOneToManyRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation<XUniqueObject, YUniqueObject>
    where XUniqueObject : DiGi.Core.Interfaces.IUniqueObject
    where YUniqueObject : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Relation.Interfaces.IOneToManyRelation_XUniqueObject,YUniqueObject_.XUniqueObject'></a>

`XUniqueObject`

<a name='DiGi.Core.Relation.Interfaces.IOneToManyRelation_XUniqueObject,YUniqueObject_.YUniqueObject'></a>

`YUniqueObject`

Derived  
↳ [OneToManyRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>')

Implements [IOneToManyRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToManyRelation 'DiGi\.Core\.Relation\.Interfaces\.IOneToManyRelation'), [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[XUniqueObject](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToManyRelation_XUniqueObject,YUniqueObject_.XUniqueObject 'DiGi\.Core\.Relation\.Interfaces\.IOneToManyRelation\<XUniqueObject,YUniqueObject\>\.XUniqueObject')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[YUniqueObject](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToManyRelation_XUniqueObject,YUniqueObject_.YUniqueObject 'DiGi\.Core\.Relation\.Interfaces\.IOneToManyRelation\<XUniqueObject,YUniqueObject\>\.YUniqueObject')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')

<a name='DiGi.Core.Relation.Interfaces.IOneToOneRelation'></a>

## IOneToOneRelation Interface

Defines the contract for a one\-to\-one relationship between unique objects\.

```csharp
public interface IOneToOneRelation : DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [OneToOneRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>')  
↳ [IOneToOneRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToOneRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IOneToOneRelation\<XUniqueObject,YUniqueObject\>')

Implements [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Core.Relation.Interfaces.IOneToOneRelation.UniqueReference_From'></a>

## IOneToOneRelation\.UniqueReference\_From Property

Gets the unique reference on the "from" side of the relation\.

```csharp
DiGi.Core.Interfaces.IUniqueReference? UniqueReference_From { get; }
```

#### Property Value
[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

<a name='DiGi.Core.Relation.Interfaces.IOneToOneRelation.UniqueReference_To'></a>

## IOneToOneRelation\.UniqueReference\_To Property

Gets the unique reference on the "to" side of the relation\.

```csharp
DiGi.Core.Interfaces.IUniqueReference? UniqueReference_To { get; }
```

#### Property Value
[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

<a name='DiGi.Core.Relation.Interfaces.IOneToOneRelation_XUniqueObject,YUniqueObject_'></a>

## IOneToOneRelation\<XUniqueObject,YUniqueObject\> Interface

Defines the contract for a one\-to\-one relationship between two types of unique objects\.

```csharp
public interface IOneToOneRelation<XUniqueObject,YUniqueObject> : DiGi.Core.Relation.Interfaces.IOneToOneRelation, DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Relation.Interfaces.IRelation<XUniqueObject, YUniqueObject>
    where XUniqueObject : DiGi.Core.Interfaces.IUniqueObject
    where YUniqueObject : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Relation.Interfaces.IOneToOneRelation_XUniqueObject,YUniqueObject_.XUniqueObject'></a>

`XUniqueObject`

<a name='DiGi.Core.Relation.Interfaces.IOneToOneRelation_XUniqueObject,YUniqueObject_.YUniqueObject'></a>

`YUniqueObject`

Derived  
↳ [OneToOneRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>')

Implements [IOneToOneRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToOneRelation 'DiGi\.Core\.Relation\.Interfaces\.IOneToOneRelation'), [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Relation\.Interfaces\.IRelation&lt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[XUniqueObject](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToOneRelation_XUniqueObject,YUniqueObject_.XUniqueObject 'DiGi\.Core\.Relation\.Interfaces\.IOneToOneRelation\<XUniqueObject,YUniqueObject\>\.XUniqueObject')[,](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')[YUniqueObject](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToOneRelation_XUniqueObject,YUniqueObject_.YUniqueObject 'DiGi\.Core\.Relation\.Interfaces\.IOneToOneRelation\<XUniqueObject,YUniqueObject\>\.YUniqueObject')[&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')

<a name='DiGi.Core.Relation.Interfaces.IRelation'></a>

## IRelation Interface

Defines the contract for a relationship between unique objects\.

```csharp
public interface IRelation : DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [ManyToManyRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>')  
↳ [ManyToOneRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>')  
↳ [OneToManyBidirectionalRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>')  
↳ [OneToManyDirectionalRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>')  
↳ [OneToManyRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>')  
↳ [OneToOneBidirectionalRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>')  
↳ [OneToOneDirectionalRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>')  
↳ [OneToOneRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>')  
↳ [Relation](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation 'DiGi\.Core\.Relation\.Classes\.Relation')  
↳ [Relation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')  
↳ [IBidirectionalRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IBidirectionalRelation 'DiGi\.Core\.Relation\.Interfaces\.IBidirectionalRelation')  
↳ [IBidirectionalRelation&lt;X,Y&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IBidirectionalRelation_X,Y_ 'DiGi\.Core\.Relation\.Interfaces\.IBidirectionalRelation\<X,Y\>')  
↳ [IDirectionalRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IDirectionalRelation 'DiGi\.Core\.Relation\.Interfaces\.IDirectionalRelation')  
↳ [IDirectionalRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IDirectionalRelation\<XUniqueObject,YUniqueObject\>')  
↳ [IManyToManyRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToManyRelation 'DiGi\.Core\.Relation\.Interfaces\.IManyToManyRelation')  
↳ [IManyToManyRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToManyRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IManyToManyRelation\<XUniqueObject,YUniqueObject\>')  
↳ [IManyToOneRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToOneRelation 'DiGi\.Core\.Relation\.Interfaces\.IManyToOneRelation')  
↳ [IManyToOneRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToOneRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IManyToOneRelation\<XUniqueObject,YUniqueObject\>')  
↳ [IOneToManyRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToManyRelation 'DiGi\.Core\.Relation\.Interfaces\.IOneToManyRelation')  
↳ [IOneToManyRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToManyRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IOneToManyRelation\<XUniqueObject,YUniqueObject\>')  
↳ [IOneToOneRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToOneRelation 'DiGi\.Core\.Relation\.Interfaces\.IOneToOneRelation')  
↳ [IOneToOneRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToOneRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IOneToOneRelation\<XUniqueObject,YUniqueObject\>')  
↳ [IRelation&lt;From,To&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation_From,To_ 'DiGi\.Core\.Relation\.Interfaces\.IRelation\<From,To\>')

Implements [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Core.Relation.Interfaces.IRelation.UniqueReferences'></a>

## IRelation\.UniqueReferences Property

Gets a list containing all unique references in this relation\.

```csharp
System.Collections.Generic.List<DiGi.Core.Interfaces.IUniqueReference>? UniqueReferences { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')
### Methods

<a name='DiGi.Core.Relation.Interfaces.IRelation.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference)'></a>

## IRelation\.Contains\(RelationSide, IUniqueReference\) Method

Determines whether the relation contains the specified unique reference on the given side\.

```csharp
bool Contains(DiGi.Core.Relation.Enums.RelationSide relationSide, DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Relation.Interfaces.IRelation.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

<a name='DiGi.Core.Relation.Interfaces.IRelation.Contains(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Relation.Interfaces.IRelation.GetType(DiGi.Core.Relation.Enums.RelationSide)'></a>

## IRelation\.GetType\(RelationSide\) Method

Gets the type of the object on the specified side of the relation\.

```csharp
System.Type? GetType(DiGi.Core.Relation.Enums.RelationSide relationSide);
```
#### Parameters

<a name='DiGi.Core.Relation.Interfaces.IRelation.GetType(DiGi.Core.Relation.Enums.RelationSide).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

#### Returns
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

<a name='DiGi.Core.Relation.Interfaces.IRelation.Has(DiGi.Core.Relation.Enums.RelationSide)'></a>

## IRelation\.Has\(RelationSide\) Method

Determines whether the relation has a reference on the specified side\.

```csharp
bool Has(DiGi.Core.Relation.Enums.RelationSide relationSide);
```
#### Parameters

<a name='DiGi.Core.Relation.Interfaces.IRelation.Has(DiGi.Core.Relation.Enums.RelationSide).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Relation.Interfaces.IRelation.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference)'></a>

## IRelation\.Remove\(RelationSide, IUniqueReference\) Method

Removes a unique reference from the specified side of the relation\.

```csharp
bool Remove(DiGi.Core.Relation.Enums.RelationSide relationSide, DiGi.Core.Interfaces.IUniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.Relation.Interfaces.IRelation.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

<a name='DiGi.Core.Relation.Interfaces.IRelation.Remove(DiGi.Core.Relation.Enums.RelationSide,DiGi.Core.Interfaces.IUniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Core.Relation.Interfaces.IRelation.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_)'></a>

## IRelation\.Remove\<TUniqueReference\>\(RelationSide, IEnumerable\<TUniqueReference\>\) Method

Removes multiple unique references from the specified side of the relation\.

```csharp
System.Collections.Generic.List<TUniqueReference>? Remove<TUniqueReference>(DiGi.Core.Relation.Enums.RelationSide relationSide, System.Collections.Generic.IEnumerable<TUniqueReference>? uniqueReferences)
    where TUniqueReference : DiGi.Core.Interfaces.IUniqueReference;
```
#### Type parameters

<a name='DiGi.Core.Relation.Interfaces.IRelation.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).TUniqueReference'></a>

`TUniqueReference`
#### Parameters

<a name='DiGi.Core.Relation.Interfaces.IRelation.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).relationSide'></a>

`relationSide` [RelationSide](DiGi.Core.Relation.Enums.md#DiGi.Core.Relation.Enums.RelationSide 'DiGi\.Core\.Relation\.Enums\.RelationSide')

<a name='DiGi.Core.Relation.Interfaces.IRelation.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).uniqueReferences'></a>

`uniqueReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TUniqueReference](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).TUniqueReference 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Remove\<TUniqueReference\>\(DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Collections\.Generic\.IEnumerable\<TUniqueReference\>\)\.TUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TUniqueReference](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation.Remove_TUniqueReference_(DiGi.Core.Relation.Enums.RelationSide,System.Collections.Generic.IEnumerable_TUniqueReference_).TUniqueReference 'DiGi\.Core\.Relation\.Interfaces\.IRelation\.Remove\<TUniqueReference\>\(DiGi\.Core\.Relation\.Enums\.RelationSide, System\.Collections\.Generic\.IEnumerable\<TUniqueReference\>\)\.TUniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Core.Relation.Interfaces.IRelation_From,To_'></a>

## IRelation\<From,To\> Interface

Defines the contract for a relationship between two types of unique objects\.

```csharp
public interface IRelation<From,To> : DiGi.Core.Relation.Interfaces.IRelation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
    where From : DiGi.Core.Interfaces.IUniqueObject
    where To : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Relation.Interfaces.IRelation_From,To_.From'></a>

`From`

<a name='DiGi.Core.Relation.Interfaces.IRelation_From,To_.To'></a>

`To`

Derived  
↳ [ManyToManyRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToManyRelation\<From,To\>')  
↳ [ManyToOneRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.ManyToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.ManyToOneRelation\<From,To\>')  
↳ [OneToManyBidirectionalRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyBidirectionalRelation\<From,To\>')  
↳ [OneToManyDirectionalRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Classes\.OneToManyDirectionalRelation\<XUniqueObject,YUniqueObject\>')  
↳ [OneToManyRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToManyRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToManyRelation\<From,To\>')  
↳ [OneToOneBidirectionalRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneBidirectionalRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneBidirectionalRelation\<From,To\>')  
↳ [OneToOneDirectionalRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Classes\.OneToOneDirectionalRelation\<XUniqueObject,YUniqueObject\>')  
↳ [OneToOneRelation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.OneToOneRelation_From,To_ 'DiGi\.Core\.Relation\.Classes\.OneToOneRelation\<From,To\>')  
↳ [Relation&lt;From,To&gt;](DiGi.Core.Relation.Classes.md#DiGi.Core.Relation.Classes.Relation_From,To_ 'DiGi\.Core\.Relation\.Classes\.Relation\<From,To\>')  
↳ [IBidirectionalRelation&lt;X,Y&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IBidirectionalRelation_X,Y_ 'DiGi\.Core\.Relation\.Interfaces\.IBidirectionalRelation\<X,Y\>')  
↳ [IDirectionalRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IDirectionalRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IDirectionalRelation\<XUniqueObject,YUniqueObject\>')  
↳ [IManyToManyRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToManyRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IManyToManyRelation\<XUniqueObject,YUniqueObject\>')  
↳ [IManyToOneRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IManyToOneRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IManyToOneRelation\<XUniqueObject,YUniqueObject\>')  
↳ [IOneToManyRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToManyRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IOneToManyRelation\<XUniqueObject,YUniqueObject\>')  
↳ [IOneToOneRelation&lt;XUniqueObject,YUniqueObject&gt;](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IOneToOneRelation_XUniqueObject,YUniqueObject_ 'DiGi\.Core\.Relation\.Interfaces\.IOneToOneRelation\<XUniqueObject,YUniqueObject\>')

Implements [IRelation](DiGi.Core.Relation.Interfaces.md#DiGi.Core.Relation.Interfaces.IRelation 'DiGi\.Core\.Relation\.Interfaces\.IRelation'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')