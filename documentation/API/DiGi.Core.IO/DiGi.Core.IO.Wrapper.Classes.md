#### [DiGi\.Core\.IO](DiGi.Core.IO.Overview.md 'DiGi\.Core\.IO\.Overview')

## DiGi\.Core\.IO\.Wrapper\.Classes Namespace
### Classes

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper'></a>

## Wrapper Class

Base class for wrapping serializable objects into a structure that can be persisted and retrieved using unique references\.

```csharp
public abstract class Wrapper : System.IDisposable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Wrapper

Implements [System\.IDisposable](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable 'System\.IDisposable')
### Constructors

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Wrapper()'></a>

## Wrapper\(\) Constructor

Initializes a new instance of the [Wrapper](DiGi.Core.IO.Wrapper.Classes.md#DiGi.Core.IO.Wrapper.Classes.Wrapper 'DiGi\.Core\.IO\.Wrapper\.Classes\.Wrapper') class\.

```csharp
public Wrapper();
```
### Methods

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Add(DiGi.Core.Interfaces.ISerializableObject)'></a>

## Wrapper\.Add\(ISerializableObject\) Method

Adds a serializable object to the wrapper and returns its unique reference\.

```csharp
public DiGi.Core.Classes.UniqueReference? Add(DiGi.Core.Interfaces.ISerializableObject? value);
```
#### Parameters

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Add(DiGi.Core.Interfaces.ISerializableObject).value'></a>

`value` [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The serializable object to add\.

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
A [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference') for the added object, or null\.

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Add(double)'></a>

## Wrapper\.Add\(double\) Method

Adds a double value to the wrapper and returns its unique identifier reference\.

```csharp
public DiGi.Core.Classes.UniqueIdReference? Add(double value);
```
#### Parameters

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Add(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value to add\.

#### Returns
[DiGi\.Core\.Classes\.UniqueIdReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueidreference 'DiGi\.Core\.Classes\.UniqueIdReference')  
A [DiGi\.Core\.Classes\.UniqueIdReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueidreference 'DiGi\.Core\.Classes\.UniqueIdReference') for the added value, or null\.

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Add(string)'></a>

## Wrapper\.Add\(string\) Method

Adds a string value to the wrapper and returns its unique identifier reference\.

```csharp
public DiGi.Core.Classes.UniqueIdReference? Add(string? value);
```
#### Parameters

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Add(string).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string value to add\.

#### Returns
[DiGi\.Core\.Classes\.UniqueIdReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueidreference 'DiGi\.Core\.Classes\.UniqueIdReference')  
A [DiGi\.Core\.Classes\.UniqueIdReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueidreference 'DiGi\.Core\.Classes\.UniqueIdReference') for the added value, or null\.

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.AddRange_TSerializableObject_(System.Collections.Generic.IEnumerable_TSerializableObject_)'></a>

## Wrapper\.AddRange\<TSerializableObject\>\(IEnumerable\<TSerializableObject\>\) Method

Adds a collection of serializable objects to the wrapper and returns their unique references\.

```csharp
public System.Collections.Generic.List<DiGi.Core.Classes.UniqueReference>? AddRange<TSerializableObject>(System.Collections.Generic.IEnumerable<TSerializableObject>? serializableObjects)
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.AddRange_TSerializableObject_(System.Collections.Generic.IEnumerable_TSerializableObject_).TSerializableObject'></a>

`TSerializableObject`

The type of serializable objects being added\.
#### Parameters

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.AddRange_TSerializableObject_(System.Collections.Generic.IEnumerable_TSerializableObject_).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TSerializableObject](DiGi.Core.IO.Wrapper.Classes.md#DiGi.Core.IO.Wrapper.Classes.Wrapper.AddRange_TSerializableObject_(System.Collections.Generic.IEnumerable_TSerializableObject_).TSerializableObject 'DiGi\.Core\.IO\.Wrapper\.Classes\.Wrapper\.AddRange\<TSerializableObject\>\(System\.Collections\.Generic\.IEnumerable\<TSerializableObject\>\)\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of serializable objects to add\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference') for the added objects, or null\.

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Clear()'></a>

## Wrapper\.Clear\(\) Method

Clears the cached content of the file\.

```csharp
public void Clear();
```

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Dispose()'></a>

## Wrapper\.Dispose\(\) Method

Releases all resources used by the watcher\.

```csharp
public void Dispose();
```

Implements [Dispose\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable.dispose 'System\.IDisposable\.Dispose')

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.GetJsonNodes()'></a>

## Wrapper\.GetJsonNodes\(\) Method

Parses and returns the file content as a list of JSON nodes\.

```csharp
public System.Collections.Generic.List<System.Text.Json.Nodes.JsonNode?>? GetJsonNodes();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Text\.Json\.Nodes\.JsonNode](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonnode 'System\.Text\.Json\.Nodes\.JsonNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [System\.Text\.Json\.Nodes\.JsonNode](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonnode 'System\.Text\.Json\.Nodes\.JsonNode') objects, or null if the operation fails\.

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.GetMetadata_TMetadata_()'></a>

## Wrapper\.GetMetadata\<TMetadata\>\(\) Method

Retrieves metadata associated with the file\.

```csharp
public TMetadata? GetMetadata<TMetadata>()
    where TMetadata : DiGi.Core.IO.Interfaces.IMetadata;
```
#### Type parameters

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.GetMetadata_TMetadata_().TMetadata'></a>

`TMetadata`

The type of metadata to retrieve\.

#### Returns
[TMetadata](DiGi.Core.IO.Wrapper.Classes.md#DiGi.Core.IO.Wrapper.Classes.Wrapper.GetMetadata_TMetadata_().TMetadata 'DiGi\.Core\.IO\.Wrapper\.Classes\.Wrapper\.GetMetadata\<TMetadata\>\(\)\.TMetadata')  
The metadata object of type [TMetadata](DiGi.Core.IO.Wrapper.Classes.md#DiGi.Core.IO.Wrapper.Classes.Wrapper.GetMetadata_TMetadata_().TMetadata 'DiGi\.Core\.IO\.Wrapper\.Classes\.Wrapper\.GetMetadata\<TMetadata\>\(\)\.TMetadata'), or null if not found\.

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.GetSerializableObjects()'></a>

## Wrapper\.GetSerializableObjects\(\) Method

Retrieves all serializable objects from the file content\.

```csharp
public System.Collections.Generic.List<DiGi.Core.Interfaces.ISerializableObject>? GetSerializableObjects();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of objects implementing [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), or null\.

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.GetSerializableObjects_TSerializableObject_()'></a>

## Wrapper\.GetSerializableObjects\<TSerializableObject\>\(\) Method

Retrieves all serializable objects of a specific type from the file content\.

```csharp
public System.Collections.Generic.List<TSerializableObject>? GetSerializableObjects<TSerializableObject>()
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.GetSerializableObjects_TSerializableObject_().TSerializableObject'></a>

`TSerializableObject`

The type of serializable objects to retrieve\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TSerializableObject](DiGi.Core.IO.Wrapper.Classes.md#DiGi.Core.IO.Wrapper.Classes.Wrapper.GetSerializableObjects_TSerializableObject_().TSerializableObject 'DiGi\.Core\.IO\.Wrapper\.Classes\.Wrapper\.GetSerializableObjects\<TSerializableObject\>\(\)\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of serializable objects of type [TSerializableObject](DiGi.Core.IO.Wrapper.Classes.md#DiGi.Core.IO.Wrapper.Classes.Wrapper.GetSerializableObjects_TSerializableObject_().TSerializableObject 'DiGi\.Core\.IO\.Wrapper\.Classes\.Wrapper\.GetSerializableObjects\<TSerializableObject\>\(\)\.TSerializableObject'), or null\.

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Read()'></a>

## Wrapper\.Read\(\) Method

Reads the file and returns its content as a list of JSON nodes\.

```csharp
public System.Collections.Generic.List<System.Text.Json.Nodes.JsonNode>? Read();
```

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Text\.Json\.Nodes\.JsonNode](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonnode 'System\.Text\.Json\.Nodes\.JsonNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [System\.Text\.Json\.Nodes\.JsonNode](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonnode 'System\.Text\.Json\.Nodes\.JsonNode') objects representing the file content, or null\.

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Read(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_)'></a>

## Wrapper\.Read\(IEnumerable\<UniqueReference\>\) Method

Reads JSON nodes associated with the provided unique references\.

```csharp
public System.Collections.Generic.List<System.Text.Json.Nodes.JsonNode>? Read(System.Collections.Generic.IEnumerable<DiGi.Core.Classes.UniqueReference>? uniqueReferences);
```
#### Parameters

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Read(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_).uniqueReferences'></a>

`uniqueReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references to read\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Text\.Json\.Nodes\.JsonNode](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonnode 'System\.Text\.Json\.Nodes\.JsonNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of JSON nodes corresponding to the provided references, or null\.

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Read_TSerializableObject_(DiGi.Core.Classes.UniqueReference)'></a>

## Wrapper\.Read\<TSerializableObject\>\(UniqueReference\) Method

Reads a single serializable object from the file using its unique reference\.

```csharp
public TSerializableObject? Read<TSerializableObject>(DiGi.Core.Classes.UniqueReference? uniqueReference)
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Read_TSerializableObject_(DiGi.Core.Classes.UniqueReference).TSerializableObject'></a>

`TSerializableObject`

The type of the serializable object to read\.
#### Parameters

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Read_TSerializableObject_(DiGi.Core.Classes.UniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The unique reference of the object to read\.

#### Returns
[TSerializableObject](DiGi.Core.IO.Wrapper.Classes.md#DiGi.Core.IO.Wrapper.Classes.Wrapper.Read_TSerializableObject_(DiGi.Core.Classes.UniqueReference).TSerializableObject 'DiGi\.Core\.IO\.Wrapper\.Classes\.Wrapper\.Read\<TSerializableObject\>\(DiGi\.Core\.Classes\.UniqueReference\)\.TSerializableObject')  
The deserialized object of type [TSerializableObject](DiGi.Core.IO.Wrapper.Classes.md#DiGi.Core.IO.Wrapper.Classes.Wrapper.Read_TSerializableObject_(DiGi.Core.Classes.UniqueReference).TSerializableObject 'DiGi\.Core\.IO\.Wrapper\.Classes\.Wrapper\.Read\<TSerializableObject\>\(DiGi\.Core\.Classes\.UniqueReference\)\.TSerializableObject'), or null\.

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Read_TSerializableObject_(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_)'></a>

## Wrapper\.Read\<TSerializableObject\>\(IEnumerable\<UniqueReference\>\) Method

Reads specific serializable objects from the file based on the provided references\.

```csharp
public System.Collections.Generic.List<TSerializableObject>? Read<TSerializableObject>(System.Collections.Generic.IEnumerable<DiGi.Core.Classes.UniqueReference> uniqueReferences)
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Read_TSerializableObject_(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_).TSerializableObject'></a>

`TSerializableObject`

The type of serializable objects to read\.
#### Parameters

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Read_TSerializableObject_(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_).uniqueReferences'></a>

`uniqueReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of unique references used to identify the objects to be read\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TSerializableObject](DiGi.Core.IO.Wrapper.Classes.md#DiGi.Core.IO.Wrapper.Classes.Wrapper.Read_TSerializableObject_(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_).TSerializableObject 'DiGi\.Core\.IO\.Wrapper\.Classes\.Wrapper\.Read\<TSerializableObject\>\(System\.Collections\.Generic\.IEnumerable\<DiGi\.Core\.Classes\.UniqueReference\>\)\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of serializable objects of type [TSerializableObject](DiGi.Core.IO.Wrapper.Classes.md#DiGi.Core.IO.Wrapper.Classes.Wrapper.Read_TSerializableObject_(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_).TSerializableObject 'DiGi\.Core\.IO\.Wrapper\.Classes\.Wrapper\.Read\<TSerializableObject\>\(System\.Collections\.Generic\.IEnumerable\<DiGi\.Core\.Classes\.UniqueReference\>\)\.TSerializableObject'), or null if no objects were found\.

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.SetMetadata(DiGi.Core.IO.Interfaces.IMetadata)'></a>

## Wrapper\.SetMetadata\(IMetadata\) Method

Sets the metadata for the file content\.

```csharp
public void SetMetadata(DiGi.Core.IO.Interfaces.IMetadata metadata);
```
#### Parameters

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.SetMetadata(DiGi.Core.IO.Interfaces.IMetadata).metadata'></a>

`metadata` [DiGi\.Core\.IO\.Interfaces\.IMetadata](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.imetadata 'DiGi\.Core\.IO\.Interfaces\.IMetadata')

The metadata to set\.

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Write()'></a>

## Wrapper\.Write\(\) Method

Writes all current objects to the file\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.Core.Classes.UniqueReference>? Write();
```

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of unique references for the written objects, or null\.

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Write(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_)'></a>

## Wrapper\.Write\(IEnumerable\<UniqueReference\>\) Method

Writes specific objects to the file based on the provided references\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.Core.Classes.UniqueReference>? Write(System.Collections.Generic.IEnumerable<DiGi.Core.Classes.UniqueReference>? uniqueReferences);
```
#### Parameters

<a name='DiGi.Core.IO.Wrapper.Classes.Wrapper.Write(System.Collections.Generic.IEnumerable_DiGi.Core.Classes.UniqueReference_).uniqueReferences'></a>

`uniqueReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique references to write\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of unique references for the written objects, or null\.

<a name='DiGi.Core.IO.Wrapper.Classes.WrapperItem'></a>

## WrapperItem Class

Represents a wrapper item containing a unique reference and associated data\.

```csharp
public sealed class WrapperItem : DiGi.Core.IO.Wrapper.Interfaces.IWrapperObject, DiGi.Core.IO.Interfaces.IIOObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → WrapperItem

Implements [DiGi\.Core\.IO\.Wrapper\.Interfaces\.IWrapperObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.wrapper.interfaces.iwrapperobject 'DiGi\.Core\.IO\.Wrapper\.Interfaces\.IWrapperObject'), [DiGi\.Core\.IO\.Interfaces\.IIOObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iioobject 'DiGi\.Core\.IO\.Interfaces\.IIOObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.IO.Wrapper.Classes.WrapperItem.WrapperItem(DiGi.Core.Classes.UniqueReference)'></a>

## WrapperItem\(UniqueReference\) Constructor

Initializes a new instance of the [WrapperItem](DiGi.Core.IO.Wrapper.Classes.md#DiGi.Core.IO.Wrapper.Classes.WrapperItem 'DiGi\.Core\.IO\.Wrapper\.Classes\.WrapperItem') class with a specified unique reference\.

```csharp
public WrapperItem(DiGi.Core.Classes.UniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.IO.Wrapper.Classes.WrapperItem.WrapperItem(DiGi.Core.Classes.UniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The unique reference for the item\.

<a name='DiGi.Core.IO.Wrapper.Classes.WrapperItem.WrapperItem(DiGi.Core.Classes.UniqueReference,System.Text.Json.Nodes.JsonNode,string)'></a>

## WrapperItem\(UniqueReference, JsonNode, string\) Constructor

Initializes a new instance of the [WrapperItem](DiGi.Core.IO.Wrapper.Classes.md#DiGi.Core.IO.Wrapper.Classes.WrapperItem 'DiGi\.Core\.IO\.Wrapper\.Classes\.WrapperItem') class with a unique reference, JSON node, and checksum\.

```csharp
public WrapperItem(DiGi.Core.Classes.UniqueReference? uniqueReference, System.Text.Json.Nodes.JsonNode? jsonNode, string? checksum);
```
#### Parameters

<a name='DiGi.Core.IO.Wrapper.Classes.WrapperItem.WrapperItem(DiGi.Core.Classes.UniqueReference,System.Text.Json.Nodes.JsonNode,string).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The unique reference for the item\.

<a name='DiGi.Core.IO.Wrapper.Classes.WrapperItem.WrapperItem(DiGi.Core.Classes.UniqueReference,System.Text.Json.Nodes.JsonNode,string).jsonNode'></a>

`jsonNode` [System\.Text\.Json\.Nodes\.JsonNode](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonnode 'System\.Text\.Json\.Nodes\.JsonNode')

The JSON node associated with the item\.

<a name='DiGi.Core.IO.Wrapper.Classes.WrapperItem.WrapperItem(DiGi.Core.Classes.UniqueReference,System.Text.Json.Nodes.JsonNode,string).checksum'></a>

`checksum` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The checksum of the item\.
### Properties

<a name='DiGi.Core.IO.Wrapper.Classes.WrapperItem.Checksum'></a>

## WrapperItem\.Checksum Property

Gets or sets the checksum associated with the wrapper item\.

```csharp
public string? Checksum { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.IO.Wrapper.Classes.WrapperItem.JsonNode'></a>

## WrapperItem\.JsonNode Property

Gets or sets the JSON node data associated with the wrapper item\.

```csharp
public System.Text.Json.Nodes.JsonNode? JsonNode { get; set; }
```

#### Property Value
[System\.Text\.Json\.Nodes\.JsonNode](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonnode 'System\.Text\.Json\.Nodes\.JsonNode')

<a name='DiGi.Core.IO.Wrapper.Classes.WrapperItem.UniqueReference'></a>

## WrapperItem\.UniqueReference Property

Gets or sets the unique reference for the wrapper item\.

```csharp
public DiGi.Core.Classes.UniqueReference? UniqueReference { get; }
```

#### Property Value
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

<a name='DiGi.Core.IO.Wrapper.Classes.WrapperItemValueCluster'></a>

## WrapperItemValueCluster Class

Represents a cluster of wrapper item values\.

```csharp
public class WrapperItemValueCluster : DiGi.Core.Classes.ValueCluster<DiGi.Core.Classes.TypeReference, DiGi.Core.Classes.UniqueReference, DiGi.Core.IO.Wrapper.Classes.WrapperItem>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Cluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3')[WrapperItem](DiGi.Core.IO.Wrapper.Classes.md#DiGi.Core.IO.Wrapper.Classes.WrapperItem 'DiGi\.Core\.IO\.Wrapper\.Classes\.WrapperItem')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cluster-3 'DiGi\.Core\.Classes\.Cluster\`3') → [DiGi\.Core\.Classes\.ValueCluster&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[DiGi\.Core\.Classes\.TypeReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.typereference 'DiGi\.Core\.Classes\.TypeReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3')[WrapperItem](DiGi.Core.IO.Wrapper.Classes.md#DiGi.Core.IO.Wrapper.Classes.WrapperItem 'DiGi\.Core\.IO\.Wrapper\.Classes\.WrapperItem')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.valuecluster-3 'DiGi\.Core\.Classes\.ValueCluster\`3') → WrapperItemValueCluster
### Constructors

<a name='DiGi.Core.IO.Wrapper.Classes.WrapperItemValueCluster.WrapperItemValueCluster()'></a>

## WrapperItemValueCluster\(\) Constructor

Initializes a new instance of the [WrapperItemValueCluster](DiGi.Core.IO.Wrapper.Classes.md#DiGi.Core.IO.Wrapper.Classes.WrapperItemValueCluster 'DiGi\.Core\.IO\.Wrapper\.Classes\.WrapperItemValueCluster') class\.

```csharp
public WrapperItemValueCluster();
```
### Methods

<a name='DiGi.Core.IO.Wrapper.Classes.WrapperItemValueCluster.GetValue(DiGi.Core.Classes.UniqueReference)'></a>

## WrapperItemValueCluster\.GetValue\(UniqueReference\) Method

Retrieves the JSON value associated with the specified unique reference\.

```csharp
public System.Text.Json.Nodes.JsonNode? GetValue(DiGi.Core.Classes.UniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.IO.Wrapper.Classes.WrapperItemValueCluster.GetValue(DiGi.Core.Classes.UniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The unique reference used to identify the value\.

#### Returns
[System\.Text\.Json\.Nodes\.JsonNode](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonnode 'System\.Text\.Json\.Nodes\.JsonNode')  
The JSON value associated with the specified unique reference, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if not found\.

<a name='DiGi.Core.IO.Wrapper.Classes.WrapperItemValueCluster.GetValue_TJsonNode_(DiGi.Core.Classes.UniqueReference)'></a>

## WrapperItemValueCluster\.GetValue\<TJsonNode\>\(UniqueReference\) Method

Retrieves the typed JSON value associated with the specified unique reference\.

```csharp
public TJsonNode? GetValue<TJsonNode>(DiGi.Core.Classes.UniqueReference? uniqueReference)
    where TJsonNode : System.Text.Json.Nodes.JsonNode;
```
#### Type parameters

<a name='DiGi.Core.IO.Wrapper.Classes.WrapperItemValueCluster.GetValue_TJsonNode_(DiGi.Core.Classes.UniqueReference).TJsonNode'></a>

`TJsonNode`

The type of the JSON node to return\.
#### Parameters

<a name='DiGi.Core.IO.Wrapper.Classes.WrapperItemValueCluster.GetValue_TJsonNode_(DiGi.Core.Classes.UniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The unique reference used to identify the value\.

#### Returns
[TJsonNode](DiGi.Core.IO.Wrapper.Classes.md#DiGi.Core.IO.Wrapper.Classes.WrapperItemValueCluster.GetValue_TJsonNode_(DiGi.Core.Classes.UniqueReference).TJsonNode 'DiGi\.Core\.IO\.Wrapper\.Classes\.WrapperItemValueCluster\.GetValue\<TJsonNode\>\(DiGi\.Core\.Classes\.UniqueReference\)\.TJsonNode')  
The typed JSON value associated with the specified unique reference, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if not found\.