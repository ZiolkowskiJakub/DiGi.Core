#### [DiGi\.Core](DiGi.Core.Overview.md 'DiGi\.Core\.Overview')

## DiGi\.Core Namespace
### Classes

<a name='DiGi.Core.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.Core.Convert.ToDiGi(thisSystem.Drawing.Color)'></a>

## Convert\.ToDiGi\(this Color\) Method

Converts a [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color') to a DiGi\-compatible [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color')\.

```csharp
public static DiGi.Core.Classes.Color ToDiGi(this System.Drawing.Color color);
```
#### Parameters

<a name='DiGi.Core.Convert.ToDiGi(thisSystem.Drawing.Color).color'></a>

`color` [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')

The source color to convert\.

#### Returns
[Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color')  
A DiGi\-compatible [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color') object\.

<a name='DiGi.Core.Convert.ToDiGi_T_(byte[])'></a>

## Convert\.ToDiGi\<T\>\(byte\[\]\) Method

Deserializes a byte array into a list of objects of type [T](DiGi.Core.md#DiGi.Core.Convert.ToDiGi_T_(byte[]).T 'DiGi\.Core\.Convert\.ToDiGi\<T\>\(byte\[\]\)\.T')\.

```csharp
public static System.Collections.Generic.List<T>? ToDiGi<T>(byte[]? bytes)
    where T : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.Convert.ToDiGi_T_(byte[]).T'></a>

`T`

The type of elements in the list\.
#### Parameters

<a name='DiGi.Core.Convert.ToDiGi_T_(byte[]).bytes'></a>

`bytes` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The byte array to deserialize\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.md#DiGi.Core.Convert.ToDiGi_T_(byte[]).T 'DiGi\.Core\.Convert\.ToDiGi\<T\>\(byte\[\]\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of objects of type [T](DiGi.Core.md#DiGi.Core.Convert.ToDiGi_T_(byte[]).T 'DiGi\.Core\.Convert\.ToDiGi\<T\>\(byte\[\]\)\.T'), or null if deserialization fails\.

<a name='DiGi.Core.Convert.ToDiGi_T_(DiGi.Core.Classes.Path)'></a>

## Convert\.ToDiGi\<T\>\(Path\) Method

Loads and deserializes a list of objects of type [T](DiGi.Core.md#DiGi.Core.Convert.ToDiGi_T_(DiGi.Core.Classes.Path).T 'DiGi\.Core\.Convert\.ToDiGi\<T\>\(DiGi\.Core\.Classes\.Path\)\.T') from the specified path\.

```csharp
public static System.Collections.Generic.List<T>? ToDiGi<T>(DiGi.Core.Classes.Path path)
    where T : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.Convert.ToDiGi_T_(DiGi.Core.Classes.Path).T'></a>

`T`

The type of elements in the list\.
#### Parameters

<a name='DiGi.Core.Convert.ToDiGi_T_(DiGi.Core.Classes.Path).path'></a>

`path` [Path](DiGi.Core.Classes.md#DiGi.Core.Classes.Path 'DiGi\.Core\.Classes\.Path')

The path to the source data\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.md#DiGi.Core.Convert.ToDiGi_T_(DiGi.Core.Classes.Path).T 'DiGi\.Core\.Convert\.ToDiGi\<T\>\(DiGi\.Core\.Classes\.Path\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of objects of type [T](DiGi.Core.md#DiGi.Core.Convert.ToDiGi_T_(DiGi.Core.Classes.Path).T 'DiGi\.Core\.Convert\.ToDiGi\<T\>\(DiGi\.Core\.Classes\.Path\)\.T'), or null if loading fails\.

<a name='DiGi.Core.Convert.ToDiGi_T_(string)'></a>

## Convert\.ToDiGi\<T\>\(string\) Method

Deserializes a JSON string into a list of objects of type [T](DiGi.Core.md#DiGi.Core.Convert.ToDiGi_T_(string).T 'DiGi\.Core\.Convert\.ToDiGi\<T\>\(string\)\.T')\.

```csharp
public static System.Collections.Generic.List<T>? ToDiGi<T>(string? json)
    where T : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.Convert.ToDiGi_T_(string).T'></a>

`T`

The type of elements in the list\.
#### Parameters

<a name='DiGi.Core.Convert.ToDiGi_T_(string).json'></a>

`json` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The JSON string to deserialize\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.md#DiGi.Core.Convert.ToDiGi_T_(string).T 'DiGi\.Core\.Convert\.ToDiGi\<T\>\(string\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of objects of type [T](DiGi.Core.md#DiGi.Core.Convert.ToDiGi_T_(string).T 'DiGi\.Core\.Convert\.ToDiGi\<T\>\(string\)\.T'), or null if deserialization fails\.

<a name='DiGi.Core.Convert.ToDrawing(int,byte)'></a>

## Convert\.ToDrawing\(int, byte\) Method

Converts an int color value \(RGB\) to a System\.Drawing\.Color with optional alpha\.

```csharp
public static System.Drawing.Color ToDrawing(int @int, byte alpha=byte.MaxValue);
```
#### Parameters

<a name='DiGi.Core.Convert.ToDrawing(int,byte).int'></a>

`int` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer RGB color value\.

<a name='DiGi.Core.Convert.ToDrawing(int,byte).alpha'></a>

`alpha` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')

The alpha channel value\.

#### Returns
[System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')  
The converted System\.Drawing\.Color\.

<a name='DiGi.Core.Convert.ToDrawing(string)'></a>

## Convert\.ToDrawing\(string\) Method

Converts a color string \(named, hex, or alpha hex\) to a System\.Drawing\.Color\.

```csharp
public static System.Drawing.Color ToDrawing(string? value);
```
#### Parameters

<a name='DiGi.Core.Convert.ToDrawing(string).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The color string to convert\.

#### Returns
[System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')  
The converted System\.Drawing\.Color, or Color\.Empty if parsing fails\.

<a name='DiGi.Core.Convert.ToDrawing(thisDiGi.Core.Classes.Color)'></a>

## Convert\.ToDrawing\(this Color\) Method

Converts a DiGi\.Core\.Classes\.Color to a System\.Drawing\.Color\.

```csharp
public static System.Drawing.Color ToDrawing(this DiGi.Core.Classes.Color? color);
```
#### Parameters

<a name='DiGi.Core.Convert.ToDrawing(thisDiGi.Core.Classes.Color).color'></a>

`color` [Color](DiGi.Core.Classes.md#DiGi.Core.Classes.Color 'DiGi\.Core\.Classes\.Color')

The color to convert\.

#### Returns
[System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')  
The converted System\.Drawing\.Color\.

<a name='DiGi.Core.Convert.ToDrawing(uint)'></a>

## Convert\.ToDrawing\(uint\) Method

Converts a uint color value \(ARGB\) to a System\.Drawing\.Color\.

```csharp
public static System.Drawing.Color ToDrawing(uint @uint);
```
#### Parameters

<a name='DiGi.Core.Convert.ToDrawing(uint).uint'></a>

`uint` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

The unsigned integer ARGB color value\.

#### Returns
[System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')  
The converted System\.Drawing\.Color\.

<a name='DiGi.Core.Convert.ToJson(thisDiGi.Core.Interfaces.ISerializableObject)'></a>

## Convert\.ToJson\(this ISerializableObject\) Method

Converts a serializable object to a JsonObject\.

```csharp
public static System.Text.Json.Nodes.JsonObject? ToJson(this DiGi.Core.Interfaces.ISerializableObject? serializableObject);
```
#### Parameters

<a name='DiGi.Core.Convert.ToJson(thisDiGi.Core.Interfaces.ISerializableObject).serializableObject'></a>

`serializableObject` [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The serializable object to convert\.

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') representation of the object, or `null` if the input is null\.

<a name='DiGi.Core.Convert.ToJson_T_(thisSystem.Collections.Generic.IEnumerable_T_)'></a>

## Convert\.ToJson\<T\>\(this IEnumerable\<T\>\) Method

Converts a collection of serializable objects to a JsonArray\.

```csharp
public static System.Text.Json.Nodes.JsonArray? ToJson<T>(this System.Collections.Generic.IEnumerable<T>? serializableObjects)
    where T : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.Convert.ToJson_T_(thisSystem.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of elements in the collection\.
#### Parameters

<a name='DiGi.Core.Convert.ToJson_T_(thisSystem.Collections.Generic.IEnumerable_T_).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.md#DiGi.Core.Convert.ToJson_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'DiGi\.Core\.Convert\.ToJson\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of serializable objects to convert\.

#### Returns
[System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')  
A [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray') containing the serialized objects, or `null` if the input is null\.

<a name='DiGi.Core.Convert.ToSystem_T_(thisDiGi.Core.Classes.Range_T_,T)'></a>

## Convert\.ToSystem\<T\>\(this Range\<T\>, T\) Method

Converts a range of values into a system list with a specified step\.

```csharp
public static System.Collections.Generic.List<T>? ToSystem<T>(this DiGi.Core.Classes.Range<T>? range, T step);
```
#### Type parameters

<a name='DiGi.Core.Convert.ToSystem_T_(thisDiGi.Core.Classes.Range_T_,T).T'></a>

`T`

The type of elements in the range\.
#### Parameters

<a name='DiGi.Core.Convert.ToSystem_T_(thisDiGi.Core.Classes.Range_T_,T).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[T](DiGi.Core.md#DiGi.Core.Convert.ToSystem_T_(thisDiGi.Core.Classes.Range_T_,T).T 'DiGi\.Core\.Convert\.ToSystem\<T\>\(this DiGi\.Core\.Classes\.Range\<T\>, T\)\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range to convert\.

<a name='DiGi.Core.Convert.ToSystem_T_(thisDiGi.Core.Classes.Range_T_,T).step'></a>

`step` [T](DiGi.Core.md#DiGi.Core.Convert.ToSystem_T_(thisDiGi.Core.Classes.Range_T_,T).T 'DiGi\.Core\.Convert\.ToSystem\<T\>\(this DiGi\.Core\.Classes\.Range\<T\>, T\)\.T')

The step value used for conversion\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.md#DiGi.Core.Convert.ToSystem_T_(thisDiGi.Core.Classes.Range_T_,T).T 'DiGi\.Core\.Convert\.ToSystem\<T\>\(this DiGi\.Core\.Classes\.Range\<T\>, T\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the values from the range, or null if the range is null\.

<a name='DiGi.Core.Convert.ToSystem_Bytes(thisDiGi.Core.Interfaces.ISerializableObject)'></a>

## Convert\.ToSystem\_Bytes\(this ISerializableObject\) Method

Converts a serializable object to its UTF\-8 byte representation\.

```csharp
public static byte[]? ToSystem_Bytes(this DiGi.Core.Interfaces.ISerializableObject? serializableObject);
```
#### Parameters

<a name='DiGi.Core.Convert.ToSystem_Bytes(thisDiGi.Core.Interfaces.ISerializableObject).serializableObject'></a>

`serializableObject` [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The serializable object to convert\.

#### Returns
[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
A byte array representing the UTF\-8 encoded data, or null if the input is null\.

<a name='DiGi.Core.Convert.ToSystem_Bytes_T_(thisSystem.Collections.Generic.IEnumerable_T_)'></a>

## Convert\.ToSystem\_Bytes\<T\>\(this IEnumerable\<T\>\) Method

Converts a collection of serializable objects to their UTF\-8 byte representation\.

```csharp
public static byte[]? ToSystem_Bytes<T>(this System.Collections.Generic.IEnumerable<T>? serializableObjects)
    where T : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.Convert.ToSystem_Bytes_T_(thisSystem.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of elements in the collection\.
#### Parameters

<a name='DiGi.Core.Convert.ToSystem_Bytes_T_(thisSystem.Collections.Generic.IEnumerable_T_).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.md#DiGi.Core.Convert.ToSystem_Bytes_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'DiGi\.Core\.Convert\.ToSystem\_Bytes\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of serializable objects to convert\.

#### Returns
[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
A byte array representing the UTF\-8 encoded data, or null if the input is null\.

<a name='DiGi.Core.Convert.ToSystem_Dictionary_T,X_(thisSystem.Collections.Generic.IEnumerable_X_,System.Func_X,T_)'></a>

## Convert\.ToSystem\_Dictionary\<T,X\>\(this IEnumerable\<X\>, Func\<X,T\>\) Method

Converts a collection of values into a dictionary where each key is associated with a list of values produced by the key function\.

```csharp
public static System.Collections.Generic.Dictionary<T,System.Collections.Generic.List<X>>? ToSystem_Dictionary<T,X>(this System.Collections.Generic.IEnumerable<X> values, System.Func<X,T?> keyFunc);
```
#### Type parameters

<a name='DiGi.Core.Convert.ToSystem_Dictionary_T,X_(thisSystem.Collections.Generic.IEnumerable_X_,System.Func_X,T_).T'></a>

`T`

The type of keys in the resulting dictionary\.

<a name='DiGi.Core.Convert.ToSystem_Dictionary_T,X_(thisSystem.Collections.Generic.IEnumerable_X_,System.Func_X,T_).X'></a>

`X`

The type of elements in the input collection\.
#### Parameters

<a name='DiGi.Core.Convert.ToSystem_Dictionary_T,X_(thisSystem.Collections.Generic.IEnumerable_X_,System.Func_X,T_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[X](DiGi.Core.md#DiGi.Core.Convert.ToSystem_Dictionary_T,X_(thisSystem.Collections.Generic.IEnumerable_X_,System.Func_X,T_).X 'DiGi\.Core\.Convert\.ToSystem\_Dictionary\<T,X\>\(this System\.Collections\.Generic\.IEnumerable\<X\>, System\.Func\<X,T\>\)\.X')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of values to convert\.

<a name='DiGi.Core.Convert.ToSystem_Dictionary_T,X_(thisSystem.Collections.Generic.IEnumerable_X_,System.Func_X,T_).keyFunc'></a>

`keyFunc` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[X](DiGi.Core.md#DiGi.Core.Convert.ToSystem_Dictionary_T,X_(thisSystem.Collections.Generic.IEnumerable_X_,System.Func_X,T_).X 'DiGi\.Core\.Convert\.ToSystem\_Dictionary\<T,X\>\(this System\.Collections\.Generic\.IEnumerable\<X\>, System\.Func\<X,T\>\)\.X')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[T](DiGi.Core.md#DiGi.Core.Convert.ToSystem_Dictionary_T,X_(thisSystem.Collections.Generic.IEnumerable_X_,System.Func_X,T_).T 'DiGi\.Core\.Convert\.ToSystem\_Dictionary\<T,X\>\(this System\.Collections\.Generic\.IEnumerable\<X\>, System\.Func\<X,T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

A function to extract the key for each element\.

#### Returns
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[T](DiGi.Core.md#DiGi.Core.Convert.ToSystem_Dictionary_T,X_(thisSystem.Collections.Generic.IEnumerable_X_,System.Func_X,T_).T 'DiGi\.Core\.Convert\.ToSystem\_Dictionary\<T,X\>\(this System\.Collections\.Generic\.IEnumerable\<X\>, System\.Func\<X,T\>\)\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[X](DiGi.Core.md#DiGi.Core.Convert.ToSystem_Dictionary_T,X_(thisSystem.Collections.Generic.IEnumerable_X_,System.Func_X,T_).X 'DiGi\.Core\.Convert\.ToSystem\_Dictionary\<T,X\>\(this System\.Collections\.Generic\.IEnumerable\<X\>, System\.Func\<X,T\>\)\.X')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')  
A dictionary containing lists of values grouped by the keys produced by the key function, or null if the input is null\.

<a name='DiGi.Core.Convert.ToSystem_FileInfo(thisDiGi.Core.Interfaces.ISerializableObject,System.Nullable_DiGi.Core.Classes.Path_)'></a>

## Convert\.ToSystem\_FileInfo\(this ISerializableObject, Nullable\<Path\>\) Method

Serializes a serializable object to a file and returns the FileInfo\.

```csharp
public static System.IO.FileInfo? ToSystem_FileInfo(this DiGi.Core.Interfaces.ISerializableObject? serializableObject, System.Nullable<DiGi.Core.Classes.Path> path);
```
#### Parameters

<a name='DiGi.Core.Convert.ToSystem_FileInfo(thisDiGi.Core.Interfaces.ISerializableObject,System.Nullable_DiGi.Core.Classes.Path_).serializableObject'></a>

`serializableObject` [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The serializable object to serialize\.

<a name='DiGi.Core.Convert.ToSystem_FileInfo(thisDiGi.Core.Interfaces.ISerializableObject,System.Nullable_DiGi.Core.Classes.Path_).path'></a>

`path` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Path](DiGi.Core.Classes.md#DiGi.Core.Classes.Path 'DiGi\.Core\.Classes\.Path')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The destination path for the serialized file\.

#### Returns
[System\.IO\.FileInfo](https://learn.microsoft.com/en-us/dotnet/api/system.io.fileinfo 'System\.IO\.FileInfo')  
A [System\.IO\.FileInfo](https://learn.microsoft.com/en-us/dotnet/api/system.io.fileinfo 'System\.IO\.FileInfo') object representing the created file, or null if the operation failed\.

<a name='DiGi.Core.Convert.ToSystem_FileInfo_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Nullable_DiGi.Core.Classes.Path_)'></a>

## Convert\.ToSystem\_FileInfo\<T\>\(this IEnumerable\<T\>, Nullable\<Path\>\) Method

Serializes a collection of serializable objects to a file and returns the FileInfo\.

```csharp
public static System.IO.FileInfo? ToSystem_FileInfo<T>(this System.Collections.Generic.IEnumerable<T>? serializableObjects, System.Nullable<DiGi.Core.Classes.Path> path)
    where T : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.Convert.ToSystem_FileInfo_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Nullable_DiGi.Core.Classes.Path_).T'></a>

`T`

The type of elements in the collection\.
#### Parameters

<a name='DiGi.Core.Convert.ToSystem_FileInfo_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Nullable_DiGi.Core.Classes.Path_).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.md#DiGi.Core.Convert.ToSystem_FileInfo_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Nullable_DiGi.Core.Classes.Path_).T 'DiGi\.Core\.Convert\.ToSystem\_FileInfo\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, System\.Nullable\<DiGi\.Core\.Classes\.Path\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of serializable objects to serialize\.

<a name='DiGi.Core.Convert.ToSystem_FileInfo_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Nullable_DiGi.Core.Classes.Path_).path'></a>

`path` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[Path](DiGi.Core.Classes.md#DiGi.Core.Classes.Path 'DiGi\.Core\.Classes\.Path')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The destination path for the serialized file\.

#### Returns
[System\.IO\.FileInfo](https://learn.microsoft.com/en-us/dotnet/api/system.io.fileinfo 'System\.IO\.FileInfo')  
A [System\.IO\.FileInfo](https://learn.microsoft.com/en-us/dotnet/api/system.io.fileinfo 'System\.IO\.FileInfo') object representing the created file, or null if the operation failed\.

<a name='DiGi.Core.Convert.ToSystem_String(thisDiGi.Core.Interfaces.ISerializableObject)'></a>

## Convert\.ToSystem\_String\(this ISerializableObject\) Method

Converts a serializable object to its JSON string representation using default options\.

```csharp
public static string? ToSystem_String(this DiGi.Core.Interfaces.ISerializableObject? serializableObject);
```
#### Parameters

<a name='DiGi.Core.Convert.ToSystem_String(thisDiGi.Core.Interfaces.ISerializableObject).serializableObject'></a>

`serializableObject` [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The serializable object to convert\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A JSON string representation of the object, or null if the input is null\.

<a name='DiGi.Core.Convert.ToSystem_String(thisDiGi.Core.Interfaces.ISerializableObject,System.Text.Json.JsonSerializerOptions)'></a>

## Convert\.ToSystem\_String\(this ISerializableObject, JsonSerializerOptions\) Method

Converts a serializable object to its JSON string representation using specified options\.

```csharp
public static string? ToSystem_String(this DiGi.Core.Interfaces.ISerializableObject? serializableObject, System.Text.Json.JsonSerializerOptions? jsonSerializerOptions);
```
#### Parameters

<a name='DiGi.Core.Convert.ToSystem_String(thisDiGi.Core.Interfaces.ISerializableObject,System.Text.Json.JsonSerializerOptions).serializableObject'></a>

`serializableObject` [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The serializable object to convert\.

<a name='DiGi.Core.Convert.ToSystem_String(thisDiGi.Core.Interfaces.ISerializableObject,System.Text.Json.JsonSerializerOptions).jsonSerializerOptions'></a>

`jsonSerializerOptions` [System\.Text\.Json\.JsonSerializerOptions](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializeroptions 'System\.Text\.Json\.JsonSerializerOptions')

The options to use for JSON serialization\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A JSON string representation of the object, or null if applicable\.

<a name='DiGi.Core.Convert.ToSystem_String(thisSystem.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.ISerializableObject_)'></a>

## Convert\.ToSystem\_String\(this IEnumerable\<ISerializableObject\>\) Method

Converts a collection of serializable objects to a JSON string representation using default options\.

```csharp
public static string? ToSystem_String(this System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.ISerializableObject>? serializableObjects);
```
#### Parameters

<a name='DiGi.Core.Convert.ToSystem_String(thisSystem.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.ISerializableObject_).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of serializable objects to convert\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A JSON string representation of the collection, or null if the input is null\.

<a name='DiGi.Core.Convert.ToSystem_String(thisSystem.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.ISerializableObject_,System.Text.Json.JsonSerializerOptions)'></a>

## Convert\.ToSystem\_String\(this IEnumerable\<ISerializableObject\>, JsonSerializerOptions\) Method

Converts a collection of serializable objects to a JSON string representation using specified options\.

```csharp
public static string? ToSystem_String(this System.Collections.Generic.IEnumerable<DiGi.Core.Interfaces.ISerializableObject>? serializableObjects, System.Text.Json.JsonSerializerOptions? jsonSerializerOptions);
```
#### Parameters

<a name='DiGi.Core.Convert.ToSystem_String(thisSystem.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.ISerializableObject_,System.Text.Json.JsonSerializerOptions).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of serializable objects to convert\.

<a name='DiGi.Core.Convert.ToSystem_String(thisSystem.Collections.Generic.IEnumerable_DiGi.Core.Interfaces.ISerializableObject_,System.Text.Json.JsonSerializerOptions).jsonSerializerOptions'></a>

`jsonSerializerOptions` [System\.Text\.Json\.JsonSerializerOptions](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializeroptions 'System\.Text\.Json\.JsonSerializerOptions')

The options to use for JSON serialization\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A JSON string representation of the collection, or null if applicable\.

<a name='DiGi.Core.Convert.ToSystem_String(thisSystem.Type,System.Collections.Generic.IEnumerable_string_)'></a>

## Convert\.ToSystem\_String\(this Type, IEnumerable\<string\>\) Method

Renders a reference type and its ordered, already\-escaped segments into a reference string\.

Prefixes the type's discriminator - its [Kind](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.Kind 'DiGi\.Core\.Constants\.Reference\.Kind') token when it
            declares one, otherwise its assembly-qualified full type name - so the result identifies exactly one
            reference type and can be parsed back by [TryParse\(this string, IReference\)](DiGi.Core.md#DiGi.Core.Query.TryParse(thisstring,DiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.TryParse\(this string, DiGi\.Core\.Interfaces\.IReference\)').

```csharp
public static string? ToSystem_String(this System.Type? type, System.Collections.Generic.IEnumerable<string?>? segments);
```
#### Parameters

<a name='DiGi.Core.Convert.ToSystem_String(thisSystem.Type,System.Collections.Generic.IEnumerable_string_).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The concrete reference type being rendered\.

<a name='DiGi.Core.Convert.ToSystem_String(thisSystem.Type,System.Collections.Generic.IEnumerable_string_).segments'></a>

`segments` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The segments, already escaped via [Segment\(this string\)](DiGi.Core.md#DiGi.Core.Query.Segment(thisstring) 'DiGi\.Core\.Query\.Segment\(this string\)') or [Segment\(this IReference\)](DiGi.Core.md#DiGi.Core.Query.Segment(thisDiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.Segment\(this DiGi\.Core\.Interfaces\.IReference\)')\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The reference string, or null when [type](DiGi.Core.md#DiGi.Core.Convert.ToSystem_String(thisSystem.Type,System.Collections.Generic.IEnumerable_string_).type 'DiGi\.Core\.Convert\.ToSystem\_String\(this System\.Type, System\.Collections\.Generic\.IEnumerable\<string\>\)\.type') has no registered factory\.

<a name='DiGi.Core.Convert.ToSystem_String_T_(thisSystem.Collections.Generic.IEnumerable_T_)'></a>

## Convert\.ToSystem\_String\<T\>\(this IEnumerable\<T\>\) Method

Converts a collection of objects implementing ISerializableObject to a JSON string representation using default options\.

```csharp
public static string? ToSystem_String<T>(this System.Collections.Generic.IEnumerable<T>? serializableObjects)
    where T : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.Convert.ToSystem_String_T_(thisSystem.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of elements in the collection\.
#### Parameters

<a name='DiGi.Core.Convert.ToSystem_String_T_(thisSystem.Collections.Generic.IEnumerable_T_).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.md#DiGi.Core.Convert.ToSystem_String_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'DiGi\.Core\.Convert\.ToSystem\_String\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of serializable objects to convert\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A JSON string representation of the collection, or null if the input is null\.

<a name='DiGi.Core.Convert.ToSystem_String_USerializableObject_(thisSystem.Collections.Generic.IEnumerable_USerializableObject_,System.Text.Json.JsonSerializerOptions)'></a>

## Convert\.ToSystem\_String\<USerializableObject\>\(this IEnumerable\<USerializableObject\>, JsonSerializerOptions\) Method

Converts a collection of objects implementing ISerializableObject to a JSON string representation using specified options\.

```csharp
public static string? ToSystem_String<USerializableObject>(this System.Collections.Generic.IEnumerable<USerializableObject>? serializableObjects, System.Text.Json.JsonSerializerOptions? jsonSerializerOptions)
    where USerializableObject : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.Convert.ToSystem_String_USerializableObject_(thisSystem.Collections.Generic.IEnumerable_USerializableObject_,System.Text.Json.JsonSerializerOptions).USerializableObject'></a>

`USerializableObject`

The type of the serializable objects in the collection\.
#### Parameters

<a name='DiGi.Core.Convert.ToSystem_String_USerializableObject_(thisSystem.Collections.Generic.IEnumerable_USerializableObject_,System.Text.Json.JsonSerializerOptions).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[USerializableObject](DiGi.Core.md#DiGi.Core.Convert.ToSystem_String_USerializableObject_(thisSystem.Collections.Generic.IEnumerable_USerializableObject_,System.Text.Json.JsonSerializerOptions).USerializableObject 'DiGi\.Core\.Convert\.ToSystem\_String\<USerializableObject\>\(this System\.Collections\.Generic\.IEnumerable\<USerializableObject\>, System\.Text\.Json\.JsonSerializerOptions\)\.USerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of serializable objects to convert\.

<a name='DiGi.Core.Convert.ToSystem_String_USerializableObject_(thisSystem.Collections.Generic.IEnumerable_USerializableObject_,System.Text.Json.JsonSerializerOptions).jsonSerializerOptions'></a>

`jsonSerializerOptions` [System\.Text\.Json\.JsonSerializerOptions](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializeroptions 'System\.Text\.Json\.JsonSerializerOptions')

The options to use for JSON serialization\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A JSON string representation of the collection, or null if applicable\.

<a name='DiGi.Core.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Core.Create.Array_T_(string,string,bool,T)'></a>

## Create\.Array\<T\>\(string, string, bool, T\) Method

Creates a 2D array of values by reading and parsing a delimited text file\.

```csharp
public static T?[,]? Array<T>(string? path, string separator="\t", bool removeEmptyLines=true, T? @default=default(T?));
```
#### Type parameters

<a name='DiGi.Core.Create.Array_T_(string,string,bool,T).T'></a>

`T`

The type of the array elements\.
#### Parameters

<a name='DiGi.Core.Create.Array_T_(string,string,bool,T).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file path to read from\.

<a name='DiGi.Core.Create.Array_T_(string,string,bool,T).separator'></a>

`separator` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string used to separate values in each line\.

<a name='DiGi.Core.Create.Array_T_(string,string,bool,T).removeEmptyLines'></a>

`removeEmptyLines` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If true, ignores empty lines in the file\.

<a name='DiGi.Core.Create.Array_T_(string,string,bool,T).default'></a>

`default` [T](DiGi.Core.md#DiGi.Core.Create.Array_T_(string,string,bool,T).T 'DiGi\.Core\.Create\.Array\<T\>\(string, string, bool, T\)\.T')

The default value to use if parsing fails\.

#### Returns
[T](DiGi.Core.md#DiGi.Core.Create.Array_T_(string,string,bool,T).T 'DiGi\.Core\.Create\.Array\<T\>\(string, string, bool, T\)\.T')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
A 2D array containing the parsed values, or null if the file is invalid\.

<a name='DiGi.Core.Create.Category(thisSystem.Collections.Generic.IEnumerable_string_)'></a>

## Create\.Category\(this IEnumerable\<string\>\) Method

Creates a hierarchical structure of Category objects from an enumerable sequence of names\.

```csharp
public static DiGi.Core.Classes.Category? Category(this System.Collections.Generic.IEnumerable<string>? names);
```
#### Parameters

<a name='DiGi.Core.Create.Category(thisSystem.Collections.Generic.IEnumerable_string_).names'></a>

`names` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sequence of names representing the category hierarchy\.

#### Returns
[Category](DiGi.Core.Classes.md#DiGi.Core.Classes.Category 'DiGi\.Core\.Classes\.Category')  
The root Category object, or null if the input is empty\.

<a name='DiGi.Core.Create.CategoryPath(string)'></a>

## Create\.CategoryPath\(string\) Method

Creates a CategoryPath object by parsing a string containing quoted names\.

```csharp
public static DiGi.Core.Classes.CategoryPath? CategoryPath(string text);
```
#### Parameters

<a name='DiGi.Core.Create.CategoryPath(string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string containing the category path\.

#### Returns
[CategoryPath](DiGi.Core.Classes.md#DiGi.Core.Classes.CategoryPath 'DiGi\.Core\.Classes\.CategoryPath')  
A CategoryPath object, or null if the string is invalid or empty\.

<a name='DiGi.Core.Create.ComplexReference(System.Collections.Generic.IReadOnlyList_string_)'></a>

## Create\.ComplexReference\(IReadOnlyList\<string\>\) Method

Rebuilds a [ComplexReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ComplexReference 'DiGi\.Core\.Classes\.ComplexReference') from the segments of its string form\.

```csharp
public static DiGi.Core.Interfaces.IReference? ComplexReference(System.Collections.Generic.IReadOnlyList<string?>? segments);
```
#### Parameters

<a name='DiGi.Core.Create.ComplexReference(System.Collections.Generic.IReadOnlyList_string_).segments'></a>

`segments` [System\.Collections\.Generic\.IReadOnlyList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')

The segments: one nested reference per step of the chain, in order\.

#### Returns
[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')  
The reference, or `null` if any segment is not a nested serializable reference\.

### Remarks
The only factory accepting a variable number of segments, because a chain has no fixed depth\. No segments
yields an empty chain, which is what an empty chain renders back to\.

<a name='DiGi.Core.Create.ConfigurationFile(string)'></a>

## Create\.ConfigurationFile\(string\) Method

Creates a ConfigurationFile object by loading it from the specified path\.

```csharp
public static DiGi.Core.Classes.ConfigurationFile? ConfigurationFile(string? path);
```
#### Parameters

<a name='DiGi.Core.Create.ConfigurationFile(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file path to the configuration file\.

#### Returns
[ConfigurationFile](DiGi.Core.Classes.md#DiGi.Core.Classes.ConfigurationFile 'DiGi\.Core\.Classes\.ConfigurationFile')  
A ConfigurationFile object loaded with data, or null if the file does not exist\.

<a name='DiGi.Core.Create.Dictionary(System.Type,System.Type)'></a>

## Create\.Dictionary\(Type, Type\) Method

Creates a dictionary instance with the specified key and value types\.

```csharp
public static System.Collections.IDictionary? Dictionary(System.Type? key, System.Type? value);
```
#### Parameters

<a name='DiGi.Core.Create.Dictionary(System.Type,System.Type).key'></a>

`key` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type of keys in the dictionary\.

<a name='DiGi.Core.Create.Dictionary(System.Type,System.Type).value'></a>

`value` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type of values in the dictionary\.

#### Returns
[System\.Collections\.IDictionary](https://learn.microsoft.com/en-us/dotnet/api/system.collections.idictionary 'System\.Collections\.IDictionary')  
An [System\.Collections\.IDictionary](https://learn.microsoft.com/en-us/dotnet/api/system.collections.idictionary 'System\.Collections\.IDictionary') instance created with the specified types, or null\.

<a name='DiGi.Core.Create.Directory(string)'></a>

## Create\.Directory\(string\) Method

Creates the directory and its parent directories if they do not exist\.

```csharp
public static bool Directory(string? directory);
```
#### Parameters

<a name='DiGi.Core.Create.Directory(string).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the directory to create\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the directory was created or already exists; otherwise, false\.

<a name='DiGi.Core.Create.Guid(thisstring)'></a>

## Create\.Guid\(this string\) Method

Creates a unique GUID that is consistent for the same string

```csharp
public static System.Guid Guid(this string? @string);
```
#### Parameters

<a name='DiGi.Core.Create.Guid(thisstring).string'></a>

`string` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

#### Returns
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')  
Unique Guid

<a name='DiGi.Core.Create.Guid_TUniqueObject_(thisDiGi.Core.Classes.UniqueObjectValueCluster_TUniqueObject_,System.Type)'></a>

## Create\.Guid\<TUniqueObject\>\(this UniqueObjectValueCluster\<TUniqueObject\>, Type\) Method

Creates a unique GUID for the specified type that does not exist in the given cluster\.

```csharp
public static System.Guid Guid<TUniqueObject>(this DiGi.Core.Classes.UniqueObjectValueCluster<TUniqueObject>? uniqueObjectValueCluster, System.Type? type)
    where TUniqueObject : DiGi.Core.Interfaces.IUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Create.Guid_TUniqueObject_(thisDiGi.Core.Classes.UniqueObjectValueCluster_TUniqueObject_,System.Type).TUniqueObject'></a>

`TUniqueObject`

The type of the unique object value\.
#### Parameters

<a name='DiGi.Core.Create.Guid_TUniqueObject_(thisDiGi.Core.Classes.UniqueObjectValueCluster_TUniqueObject_,System.Type).uniqueObjectValueCluster'></a>

`uniqueObjectValueCluster` [DiGi\.Core\.Classes\.UniqueObjectValueCluster&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_ 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>')[TUniqueObject](DiGi.Core.md#DiGi.Core.Create.Guid_TUniqueObject_(thisDiGi.Core.Classes.UniqueObjectValueCluster_TUniqueObject_,System.Type).TUniqueObject 'DiGi\.Core\.Create\.Guid\<TUniqueObject\>\(this DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TUniqueObject\>, System\.Type\)\.TUniqueObject')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_ 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>')

The cluster used to ensure the generated GUID is unique\.

<a name='DiGi.Core.Create.Guid_TUniqueObject_(thisDiGi.Core.Classes.UniqueObjectValueCluster_TUniqueObject_,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type for which the unique GUID is created\.

#### Returns
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')  
A unique [Guid\(this string\)](DiGi.Core.md#DiGi.Core.Create.Guid(thisstring) 'DiGi\.Core\.Create\.Guid\(this string\)') that does not exist in the specified cluster\.

<a name='DiGi.Core.Create.GuidExternalReference(System.Collections.Generic.IReadOnlyList_string_)'></a>

## Create\.GuidExternalReference\(IReadOnlyList\<string\>\) Method

Rebuilds a [GuidExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidExternalReference 'DiGi\.Core\.Classes\.GuidExternalReference') from the segments of its string form\.

```csharp
public static DiGi.Core.Interfaces.IReference? GuidExternalReference(System.Collections.Generic.IReadOnlyList<string?>? segments);
```
#### Parameters

<a name='DiGi.Core.Create.GuidExternalReference(System.Collections.Generic.IReadOnlyList_string_).segments'></a>

`segments` [System\.Collections\.Generic\.IReadOnlyList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')

The segments: the source, then the nested GUID reference\.

#### Returns
[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')  
The reference, or `null` if the segments do not describe one\.

### Remarks
Renders identically to [InstanceRelatedExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference') apart from the
discriminator, which is the only thing that keeps the two apart on the way back\.

<a name='DiGi.Core.Create.GuidPropertyReference(System.Collections.Generic.IReadOnlyList_string_)'></a>

## Create\.GuidPropertyReference\(IReadOnlyList\<string\>\) Method

Rebuilds a [GuidPropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidPropertyReference 'DiGi\.Core\.Classes\.GuidPropertyReference') from the segments of its string form\.

```csharp
public static DiGi.Core.Interfaces.IReference? GuidPropertyReference(System.Collections.Generic.IReadOnlyList<string?>? segments);
```
#### Parameters

<a name='DiGi.Core.Create.GuidPropertyReference(System.Collections.Generic.IReadOnlyList_string_).segments'></a>

`segments` [System\.Collections\.Generic\.IReadOnlyList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')

The segments: the nested GUID reference, then the property name\.

#### Returns
[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')  
The reference, or `null` if the segments do not describe one\.

<a name='DiGi.Core.Create.GuidReference(System.Collections.Generic.IReadOnlyList_string_)'></a>

## Create\.GuidReference\(IReadOnlyList\<string\>\) Method

Rebuilds a [GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference') from the segments of its string form\.

```csharp
public static DiGi.Core.Interfaces.IReference? GuidReference(System.Collections.Generic.IReadOnlyList<string?>? segments);
```
#### Parameters

<a name='DiGi.Core.Create.GuidReference(System.Collections.Generic.IReadOnlyList_string_).segments'></a>

`segments` [System\.Collections\.Generic\.IReadOnlyList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')

The segments: the nested type reference, then the GUID\.

#### Returns
[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')  
The reference, or `null` if the segments do not describe one\.

<a name='DiGi.Core.Create.GuidReference_T_(thisT,System.Func_T,System.Guid_)'></a>

## Create\.GuidReference\<T\>\(this T, Func\<T,Guid\>\) Method

Creates a GUID reference for the specified object using the given function to retrieve its GUID\.

```csharp
public static DiGi.Core.Classes.GuidReference? GuidReference<T>(this T? @object, System.Func<T?,System.Guid> func);
```
#### Type parameters

<a name='DiGi.Core.Create.GuidReference_T_(thisT,System.Func_T,System.Guid_).T'></a>

`T`

The type of the object\.
#### Parameters

<a name='DiGi.Core.Create.GuidReference_T_(thisT,System.Func_T,System.Guid_).object'></a>

`object` [T](DiGi.Core.md#DiGi.Core.Create.GuidReference_T_(thisT,System.Func_T,System.Guid_).T 'DiGi\.Core\.Create\.GuidReference\<T\>\(this T, System\.Func\<T,System\.Guid\>\)\.T')

The object for which to create a GUID reference\.

<a name='DiGi.Core.Create.GuidReference_T_(thisT,System.Func_T,System.Guid_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[T](DiGi.Core.md#DiGi.Core.Create.GuidReference_T_(thisT,System.Func_T,System.Guid_).T 'DiGi\.Core\.Create\.GuidReference\<T\>\(this T, System\.Func\<T,System\.Guid\>\)\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The function used to retrieve the GUID from the object\.

#### Returns
[GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference')  
A [GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference') if successful; otherwise, `null`\.

<a name='DiGi.Core.Create.GuidReference_TUniqueObject_(thisDiGi.Core.Classes.UniqueObjectValueCluster_TUniqueObject_,System.Type)'></a>

## Create\.GuidReference\<TUniqueObject\>\(this UniqueObjectValueCluster\<TUniqueObject\>, Type\) Method

Creates a unique GUID reference for the specified type that does not exist in the given cluster\.

```csharp
public static DiGi.Core.Classes.GuidReference? GuidReference<TUniqueObject>(this DiGi.Core.Classes.UniqueObjectValueCluster<TUniqueObject>? uniqueObjectValueCluster, System.Type? type)
    where TUniqueObject : DiGi.Core.Interfaces.IUniqueObject;
```
#### Type parameters

<a name='DiGi.Core.Create.GuidReference_TUniqueObject_(thisDiGi.Core.Classes.UniqueObjectValueCluster_TUniqueObject_,System.Type).TUniqueObject'></a>

`TUniqueObject`

The type of the unique object\.
#### Parameters

<a name='DiGi.Core.Create.GuidReference_TUniqueObject_(thisDiGi.Core.Classes.UniqueObjectValueCluster_TUniqueObject_,System.Type).uniqueObjectValueCluster'></a>

`uniqueObjectValueCluster` [DiGi\.Core\.Classes\.UniqueObjectValueCluster&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_ 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>')[TUniqueObject](DiGi.Core.md#DiGi.Core.Create.GuidReference_TUniqueObject_(thisDiGi.Core.Classes.UniqueObjectValueCluster_TUniqueObject_,System.Type).TUniqueObject 'DiGi\.Core\.Create\.GuidReference\<TUniqueObject\>\(this DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TUniqueObject\>, System\.Type\)\.TUniqueObject')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObjectValueCluster_TValue_ 'DiGi\.Core\.Classes\.UniqueObjectValueCluster\<TValue\>')

The cluster to check for existing references\.

<a name='DiGi.Core.Create.GuidReference_TUniqueObject_(thisDiGi.Core.Classes.UniqueObjectValueCluster_TUniqueObject_,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type for which to create a GUID reference\.

#### Returns
[GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference')  
A [GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference') if successful; otherwise, `null`\.

<a name='DiGi.Core.Create.InstanceRelatedExternalReference(System.Collections.Generic.IReadOnlyList_string_)'></a>

## Create\.InstanceRelatedExternalReference\(IReadOnlyList\<string\>\) Method

Rebuilds an [InstanceRelatedExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference') from the segments of its string form\.

```csharp
public static DiGi.Core.Interfaces.IReference? InstanceRelatedExternalReference(System.Collections.Generic.IReadOnlyList<string?>? segments);
```
#### Parameters

<a name='DiGi.Core.Create.InstanceRelatedExternalReference(System.Collections.Generic.IReadOnlyList_string_).segments'></a>

`segments` [System\.Collections\.Generic\.IReadOnlyList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')

The segments: the source, then the nested instance\-related reference\.

#### Returns
[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')  
The reference, or `null` if the segments do not describe one\.

<a name='DiGi.Core.Create.JsonNode(thisobject)'></a>

## Create\.JsonNode\(this object\) Method

Creates a JSON node from the given object\.

```csharp
public static System.Text.Json.Nodes.JsonNode? JsonNode(this object? @object);
```
#### Parameters

<a name='DiGi.Core.Create.JsonNode(thisobject).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert to a JSON node\.

#### Returns
[System\.Text\.Json\.Nodes\.JsonNode](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonnode 'System\.Text\.Json\.Nodes\.JsonNode')  
A [JsonNode\(this object\)](DiGi.Core.md#DiGi.Core.Create.JsonNode(thisobject) 'DiGi\.Core\.Create\.JsonNode\(this object\)') representing the object, or `null` if the object is null\.

<a name='DiGi.Core.Create.List(System.Type)'></a>

## Create\.List\(Type\) Method

Creates a list instance of the specified type\.

```csharp
public static System.Collections.IList? List(System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Create.List(System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type of elements in the list\.

#### Returns
[System\.Collections\.IList](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ilist 'System\.Collections\.IList')  
A new [System\.Collections\.IList](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ilist 'System\.Collections\.IList') instance, or null if the operation fails\.

<a name='DiGi.Core.Create.LongProgressWrapper(thisSystem.IProgress_long_,long)'></a>

## Create\.LongProgressWrapper\(this IProgress\<long\>, long\) Method

Creates a wrapper for a long\-based progress reporter\.

```csharp
public static DiGi.Core.Classes.LongProgressWrapper? LongProgressWrapper(this System.IProgress<long>? progress, long initialValue=0L);
```
#### Parameters

<a name='DiGi.Core.Create.LongProgressWrapper(thisSystem.IProgress_long_,long).progress'></a>

`progress` [System\.IProgress&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1 'System\.IProgress\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1 'System\.IProgress\`1')

The progress reporter to wrap\.

<a name='DiGi.Core.Create.LongProgressWrapper(thisSystem.IProgress_long_,long).initialValue'></a>

`initialValue` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The initial value for the progress reporter\.

#### Returns
[LongProgressWrapper](DiGi.Core.Classes.md#DiGi.Core.Classes.LongProgressWrapper 'DiGi\.Core\.Classes\.LongProgressWrapper')  
A [LongProgressWrapper\(this IProgress&lt;long&gt;, long\)](DiGi.Core.md#DiGi.Core.Create.LongProgressWrapper(thisSystem.IProgress_long_,long) 'DiGi\.Core\.Create\.LongProgressWrapper\(this System\.IProgress\<long\>, long\)') instance, or null if the provided progress is null\.

<a name='DiGi.Core.Create.MemoryStream(thisstring)'></a>

## Create\.MemoryStream\(this string\) Method

Creates a memory stream from the given string\.

```csharp
public static System.IO.MemoryStream? MemoryStream(this string? text);
```
#### Parameters

<a name='DiGi.Core.Create.MemoryStream(thisstring).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string to convert into a memory stream\.

#### Returns
[System\.IO\.MemoryStream](https://learn.microsoft.com/en-us/dotnet/api/system.io.memorystream 'System\.IO\.MemoryStream')  
A [System\.IO\.MemoryStream](https://learn.microsoft.com/en-us/dotnet/api/system.io.memorystream 'System\.IO\.MemoryStream') containing the text, or null if the input is null\.

<a name='DiGi.Core.Create.MemoryStream(thisSystem.Collections.Generic.IEnumerable_string_)'></a>

## Create\.MemoryStream\(this IEnumerable\<string\>\) Method

Creates a memory stream from the given collection of strings\.

```csharp
public static System.IO.MemoryStream? MemoryStream(this System.Collections.Generic.IEnumerable<string>? text);
```
#### Parameters

<a name='DiGi.Core.Create.MemoryStream(thisSystem.Collections.Generic.IEnumerable_string_).text'></a>

`text` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of strings to convert into a memory stream\.

#### Returns
[System\.IO\.MemoryStream](https://learn.microsoft.com/en-us/dotnet/api/system.io.memorystream 'System\.IO\.MemoryStream')  
A [System\.IO\.MemoryStream](https://learn.microsoft.com/en-us/dotnet/api/system.io.memorystream 'System\.IO\.MemoryStream') containing the text, or null if the input is null\.

<a name='DiGi.Core.Create.Object_T_(object[])'></a>

## Create\.Object\<T\>\(object\[\]\) Method

Creates an instance of the specified type using the provided arguments\.

```csharp
public static T? Object<T>(params object[] objects);
```
#### Type parameters

<a name='DiGi.Core.Create.Object_T_(object[]).T'></a>

`T`

The type of the object to create\.
#### Parameters

<a name='DiGi.Core.Create.Object_T_(object[]).objects'></a>

`objects` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The arguments to be passed to the constructor of the created object\.

#### Returns
[T](DiGi.Core.md#DiGi.Core.Create.Object_T_(object[]).T 'DiGi\.Core\.Create\.Object\<T\>\(object\[\]\)\.T')  
An instance of type [T](DiGi.Core.md#DiGi.Core.Create.Object_T_(object[]).T 'DiGi\.Core\.Create\.Object\<T\>\(object\[\]\)\.T'), or null if the operation fails\.

<a name='DiGi.Core.Create.ObjectPath(string)'></a>

## Create\.ObjectPath\(string\) Method

Creates an object path from the given text\.

```csharp
public static DiGi.Core.Classes.ObjectPath? ObjectPath(string? text);
```
#### Parameters

<a name='DiGi.Core.Create.ObjectPath(string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The text to be converted into an object path\.

#### Returns
[ObjectPath](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath 'DiGi\.Core\.Classes\.ObjectPath')  
An [ObjectPath\(string\)](DiGi.Core.md#DiGi.Core.Create.ObjectPath(string) 'DiGi\.Core\.Create\.ObjectPath\(string\)') if successful; otherwise, `null`\.

<a name='DiGi.Core.Create.ParallelOptions(double)'></a>

## Create\.ParallelOptions\(double\) Method

Creates parallel options based on the specified processor fraction\.

```csharp
public static System.Threading.Tasks.ParallelOptions ParallelOptions(double fraction=0.9);
```
#### Parameters

<a name='DiGi.Core.Create.ParallelOptions(double).fraction'></a>

`fraction` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The fraction of available processors to be used for parallel operations\.

#### Returns
[System\.Threading\.Tasks\.ParallelOptions](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.paralleloptions 'System\.Threading\.Tasks\.ParallelOptions')  
A [ParallelOptions\(double\)](DiGi.Core.md#DiGi.Core.Create.ParallelOptions(double) 'DiGi\.Core\.Create\.ParallelOptions\(double\)') instance configured with the specified fraction\.

<a name='DiGi.Core.Create.Random(int)'></a>

## Create\.Random\(int\) Method

Creates a random number generator with an optional seed\.

```csharp
public static System.Random Random(int seed=-1);
```
#### Parameters

<a name='DiGi.Core.Create.Random(int).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The seed value for the random number generator\. Defaults to \-1\.

#### Returns
[System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')  
A new [Random\(int\)](DiGi.Core.md#DiGi.Core.Create.Random(int) 'DiGi\.Core\.Create\.Random\(int\)') instance\.

<a name='DiGi.Core.Create.ReferenceConstructor(thisSystem.Reflection.MethodInfo)'></a>

## Create\.ReferenceConstructor\(this MethodInfo\) Method

Creates a reference constructor from a method marked with [ReferenceFactoryAttribute](DiGi.Core.Classes.md#DiGi.Core.Classes.ReferenceFactoryAttribute 'DiGi\.Core\.Classes\.ReferenceFactoryAttribute')\.

```csharp
public static DiGi.Core.Classes.ReferenceConstructor? ReferenceConstructor(this System.Reflection.MethodInfo? methodInfo);
```
#### Parameters

<a name='DiGi.Core.Create.ReferenceConstructor(thisSystem.Reflection.MethodInfo).methodInfo'></a>

`methodInfo` [System\.Reflection\.MethodInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.methodinfo 'System\.Reflection\.MethodInfo')

The candidate factory method\.

#### Returns
[ReferenceConstructor](DiGi.Core.Classes.md#DiGi.Core.Classes.ReferenceConstructor 'DiGi\.Core\.Classes\.ReferenceConstructor')  
A [ReferenceConstructor\(this MethodInfo\)](DiGi.Core.md#DiGi.Core.Create.ReferenceConstructor(thisSystem.Reflection.MethodInfo) 'DiGi\.Core\.Create\.ReferenceConstructor\(this System\.Reflection\.MethodInfo\)') if the method is a valid factory; otherwise, `null`\.

<a name='DiGi.Core.Create.SerializableObject_T_(thisSystem.Text.Json.Nodes.JsonObject)'></a>

## Create\.SerializableObject\<T\>\(this JsonObject\) Method

Creates a serializable object from the given JSON object\.

```csharp
public static T? SerializableObject<T>(this System.Text.Json.Nodes.JsonObject? jsonObject)
    where T : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.Create.SerializableObject_T_(thisSystem.Text.Json.Nodes.JsonObject).T'></a>

`T`

The type of the object to create\.
#### Parameters

<a name='DiGi.Core.Create.SerializableObject_T_(thisSystem.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to convert into a serializable object\.

#### Returns
[T](DiGi.Core.md#DiGi.Core.Create.SerializableObject_T_(thisSystem.Text.Json.Nodes.JsonObject).T 'DiGi\.Core\.Create\.SerializableObject\<T\>\(this System\.Text\.Json\.Nodes\.JsonObject\)\.T')  
A serializable object of type [T](DiGi.Core.md#DiGi.Core.Create.SerializableObject_T_(thisSystem.Text.Json.Nodes.JsonObject).T 'DiGi\.Core\.Create\.SerializableObject\<T\>\(this System\.Text\.Json\.Nodes\.JsonObject\)\.T'), or null if the conversion fails\.

<a name='DiGi.Core.Create.SerializableObjects_T_(thisSystem.Text.Json.Nodes.JsonArray)'></a>

## Create\.SerializableObjects\<T\>\(this JsonArray\) Method

Creates a list of serializable objects from the given JSON array\.

```csharp
public static System.Collections.Generic.List<T>? SerializableObjects<T>(this System.Text.Json.Nodes.JsonArray? jsonArray)
    where T : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.Create.SerializableObjects_T_(thisSystem.Text.Json.Nodes.JsonArray).T'></a>

`T`

The type of elements in the resulting list\.
#### Parameters

<a name='DiGi.Core.Create.SerializableObjects_T_(thisSystem.Text.Json.Nodes.JsonArray).jsonArray'></a>

`jsonArray` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The JSON array to be converted into a list of serializable objects\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.md#DiGi.Core.Create.SerializableObjects_T_(thisSystem.Text.Json.Nodes.JsonArray).T 'DiGi\.Core\.Create\.SerializableObjects\<T\>\(this System\.Text\.Json\.Nodes\.JsonArray\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the deserialized objects of type [T](DiGi.Core.md#DiGi.Core.Create.SerializableObjects_T_(thisSystem.Text.Json.Nodes.JsonArray).T 'DiGi\.Core\.Create\.SerializableObjects\<T\>\(this System\.Text\.Json\.Nodes\.JsonArray\)\.T'), or null if the input is null\.

<a name='DiGi.Core.Create.SerializationConstructor(thisSystem.Type)'></a>

## Create\.SerializationConstructor\(this Type\) Method

Creates a serialization constructor for the specified type\.

```csharp
public static DiGi.Core.Classes.SerializationConstructor? SerializationConstructor(this System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Create.SerializationConstructor(thisSystem.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type for which to create the serialization constructor\.

#### Returns
[SerializationConstructor](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializationConstructor 'DiGi\.Core\.Classes\.SerializationConstructor')  
A [SerializationConstructor\(this Type\)](DiGi.Core.md#DiGi.Core.Create.SerializationConstructor(thisSystem.Type) 'DiGi\.Core\.Create\.SerializationConstructor\(this System\.Type\)') if successful; otherwise, `null`\.

<a name='DiGi.Core.Create.SerializationMethodCollection(thisSystem.Type)'></a>

## Create\.SerializationMethodCollection\(this Type\) Method

Creates a serialization method collection for the specified type\.

```csharp
public static DiGi.Core.Classes.SerializationMethodCollection? SerializationMethodCollection(this System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Create.SerializationMethodCollection(thisSystem.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type for which to create the serialization method collection\.

#### Returns
[SerializationMethodCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializationMethodCollection 'DiGi\.Core\.Classes\.SerializationMethodCollection')  
A [SerializationMethodCollection\(this Type\)](DiGi.Core.md#DiGi.Core.Create.SerializationMethodCollection(thisSystem.Type) 'DiGi\.Core\.Create\.SerializationMethodCollection\(this System\.Type\)') containing the serialization methods for the specified type, or null if none are found\.

<a name='DiGi.Core.Create.TypePropertyReference(System.Collections.Generic.IReadOnlyList_string_)'></a>

## Create\.TypePropertyReference\(IReadOnlyList\<string\>\) Method

Rebuilds a [TypePropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypePropertyReference 'DiGi\.Core\.Classes\.TypePropertyReference') from the segments of its string form\.

```csharp
public static DiGi.Core.Interfaces.IReference? TypePropertyReference(System.Collections.Generic.IReadOnlyList<string?>? segments);
```
#### Parameters

<a name='DiGi.Core.Create.TypePropertyReference(System.Collections.Generic.IReadOnlyList_string_).segments'></a>

`segments` [System\.Collections\.Generic\.IReadOnlyList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')

The segments: the nested type reference, then the property name\.

#### Returns
[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')  
The reference, or `null` if the segments do not describe one\.

<a name='DiGi.Core.Create.TypeReference(System.Collections.Generic.IReadOnlyList_string_)'></a>

## Create\.TypeReference\(IReadOnlyList\<string\>\) Method

Rebuilds a [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference') from the segments of its string form\.

```csharp
public static DiGi.Core.Interfaces.IReference? TypeReference(System.Collections.Generic.IReadOnlyList<string?>? segments);
```
#### Parameters

<a name='DiGi.Core.Create.TypeReference(System.Collections.Generic.IReadOnlyList_string_).segments'></a>

`segments` [System\.Collections\.Generic\.IReadOnlyList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')

The segments: the full type name\.

#### Returns
[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')  
The reference, or `null` if the segments do not describe one\.

<a name='DiGi.Core.Create.TypeReference(thisSystem.Type)'></a>

## Create\.TypeReference\(this Type\) Method

Creates a type reference for the specified type\.

```csharp
public static DiGi.Core.Classes.TypeReference? TypeReference(this System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Create.TypeReference(thisSystem.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type for which to create a type reference\.

#### Returns
[TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')  
A type reference for the specified type, or `null` if the provided type is null\.

<a name='DiGi.Core.Create.TypeRelatedExternalReference(System.Collections.Generic.IReadOnlyList_string_)'></a>

## Create\.TypeRelatedExternalReference\(IReadOnlyList\<string\>\) Method

Rebuilds a [TypeRelatedExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeRelatedExternalReference 'DiGi\.Core\.Classes\.TypeRelatedExternalReference') from the segments of its string form\.

```csharp
public static DiGi.Core.Interfaces.IReference? TypeRelatedExternalReference(System.Collections.Generic.IReadOnlyList<string?>? segments);
```
#### Parameters

<a name='DiGi.Core.Create.TypeRelatedExternalReference(System.Collections.Generic.IReadOnlyList_string_).segments'></a>

`segments` [System\.Collections\.Generic\.IReadOnlyList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')

The segments: the source, then the nested type\-related reference\.

#### Returns
[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')  
The reference, or `null` if the segments do not describe one\.

<a name='DiGi.Core.Create.UniqueIdPropertyReference(System.Collections.Generic.IReadOnlyList_string_)'></a>

## Create\.UniqueIdPropertyReference\(IReadOnlyList\<string\>\) Method

Rebuilds a [UniqueIdPropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdPropertyReference 'DiGi\.Core\.Classes\.UniqueIdPropertyReference') from the segments of its string form\.

```csharp
public static DiGi.Core.Interfaces.IReference? UniqueIdPropertyReference(System.Collections.Generic.IReadOnlyList<string?>? segments);
```
#### Parameters

<a name='DiGi.Core.Create.UniqueIdPropertyReference(System.Collections.Generic.IReadOnlyList_string_).segments'></a>

`segments` [System\.Collections\.Generic\.IReadOnlyList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')

The segments: the nested unique identifier reference, then the property name\.

#### Returns
[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')  
The reference, or `null` if the segments do not describe one\.

<a name='DiGi.Core.Create.UniqueIdReference(System.Collections.Generic.IReadOnlyList_string_)'></a>

## Create\.UniqueIdReference\(IReadOnlyList\<string\>\) Method

Rebuilds a [UniqueIdReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdReference 'DiGi\.Core\.Classes\.UniqueIdReference') from the segments of its string form\.

```csharp
public static DiGi.Core.Interfaces.IReference? UniqueIdReference(System.Collections.Generic.IReadOnlyList<string?>? segments);
```
#### Parameters

<a name='DiGi.Core.Create.UniqueIdReference(System.Collections.Generic.IReadOnlyList_string_).segments'></a>

`segments` [System\.Collections\.Generic\.IReadOnlyList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')

The segments: the nested type reference, then the unique identifier\.

#### Returns
[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')  
The reference, or `null` if the segments do not describe one\.

<a name='DiGi.Core.Create.UniqueReference(thisobject)'></a>

## Create\.UniqueReference\(this object\) Method

Creates a unique reference for the specified object\.

```csharp
public static DiGi.Core.Classes.UniqueReference? UniqueReference(this object? @object);
```
#### Parameters

<a name='DiGi.Core.Create.UniqueReference(thisobject).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object for which to create a unique reference\.

#### Returns
[UniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference 'DiGi\.Core\.Classes\.UniqueReference')  
A unique reference for the specified object\.

<a name='DiGi.Core.Create.UTC(double)'></a>

## Create\.UTC\(double\) Method

Creates a UTC offset from the given double value\.

```csharp
public static DiGi.Core.Enums.UTC UTC(double timeOffset);
```
#### Parameters

<a name='DiGi.Core.Create.UTC(double).timeOffset'></a>

`timeOffset` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double representation of the UTC offset\.

#### Returns
[UTC](DiGi.Core.Enums.md#DiGi.Core.Enums.UTC 'DiGi\.Core\.Enums\.UTC')  
A [UTC](DiGi.Core.Enums.md#DiGi.Core.Enums.UTC 'DiGi\.Core\.Enums\.UTC') instance representing the specified offset\.

<a name='DiGi.Core.Create.UTC(float)'></a>

## Create\.UTC\(float\) Method

Creates a UTC offset from the given float value\.

```csharp
public static DiGi.Core.Enums.UTC UTC(float timeOffset);
```
#### Parameters

<a name='DiGi.Core.Create.UTC(float).timeOffset'></a>

`timeOffset` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The float representation of the UTC offset\.

#### Returns
[UTC](DiGi.Core.Enums.md#DiGi.Core.Enums.UTC 'DiGi\.Core\.Enums\.UTC')  
A [UTC](DiGi.Core.Enums.md#DiGi.Core.Enums.UTC 'DiGi\.Core\.Enums\.UTC') instance representing the specified offset\.

<a name='DiGi.Core.Create.UTC(string)'></a>

## Create\.UTC\(string\) Method

Creates a UTC offset from the given string value\.

```csharp
public static DiGi.Core.Enums.UTC UTC(string value);
```
#### Parameters

<a name='DiGi.Core.Create.UTC(string).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string representation of the UTC offset\.

#### Returns
[UTC](DiGi.Core.Enums.md#DiGi.Core.Enums.UTC 'DiGi\.Core\.Enums\.UTC')  
A [UTC](DiGi.Core.Enums.md#DiGi.Core.Enums.UTC 'DiGi\.Core\.Enums\.UTC') instance representing the specified offset\.

<a name='DiGi.Core.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.Core.Modify.Add_T_(thisSystem.Collections.Generic.List_T_,T,System.Func_T,bool_)'></a>

## Modify\.Add\<T\>\(this List\<T\>, T, Func\<T,bool\>\) Method

Adds item to the list if condition in func is not meet by any of item on the list

```csharp
public static bool Add<T>(this System.Collections.Generic.List<T>? list, T item, System.Func<T,bool> func);
```
#### Type parameters

<a name='DiGi.Core.Modify.Add_T_(thisSystem.Collections.Generic.List_T_,T,System.Func_T,bool_).T'></a>

`T`

Item type
#### Parameters

<a name='DiGi.Core.Modify.Add_T_(thisSystem.Collections.Generic.List_T_,T,System.Func_T,bool_).list'></a>

`list` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.md#DiGi.Core.Modify.Add_T_(thisSystem.Collections.Generic.List_T_,T,System.Func_T,bool_).T 'DiGi\.Core\.Modify\.Add\<T\>\(this System\.Collections\.Generic\.List\<T\>, T, System\.Func\<T,bool\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

List

<a name='DiGi.Core.Modify.Add_T_(thisSystem.Collections.Generic.List_T_,T,System.Func_T,bool_).item'></a>

`item` [T](DiGi.Core.md#DiGi.Core.Modify.Add_T_(thisSystem.Collections.Generic.List_T_,T,System.Func_T,bool_).T 'DiGi\.Core\.Modify\.Add\<T\>\(this System\.Collections\.Generic\.List\<T\>, T, System\.Func\<T,bool\>\)\.T')

Item to be added

<a name='DiGi.Core.Modify.Add_T_(thisSystem.Collections.Generic.List_T_,T,System.Func_T,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[T](DiGi.Core.md#DiGi.Core.Modify.Add_T_(thisSystem.Collections.Generic.List_T_,T,System.Func_T,bool_).T 'DiGi\.Core\.Modify\.Add\<T\>\(this System\.Collections\.Generic\.List\<T\>, T, System\.Func\<T,bool\>\)\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

Condition

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if item has been added

<a name='DiGi.Core.Modify.Append(thisSystem.Text.StringBuilder,System.Type)'></a>

## Modify\.Append\(this StringBuilder, Type\) Method

Appends the full, formatted type name of a Type to the StringBuilder\.

```csharp
public static void Append(this System.Text.StringBuilder? stringBuilder, System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Modify.Append(thisSystem.Text.StringBuilder,System.Type).stringBuilder'></a>

`stringBuilder` [System\.Text\.StringBuilder](https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder 'System\.Text\.StringBuilder')

The StringBuilder to append to\.

<a name='DiGi.Core.Modify.Append(thisSystem.Text.StringBuilder,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The Type to format and append\.

<a name='DiGi.Core.Modify.Extend_T_(thisSystem.Collections.Generic.List_T_,int)'></a>

## Modify\.Extend\<T\>\(this List\<T\>, int\) Method

Extends list to given length \(count\) by adding values from start of the list

```csharp
public static bool Extend<T>(this System.Collections.Generic.List<T>? list, int count);
```
#### Type parameters

<a name='DiGi.Core.Modify.Extend_T_(thisSystem.Collections.Generic.List_T_,int).T'></a>

`T`

List type
#### Parameters

<a name='DiGi.Core.Modify.Extend_T_(thisSystem.Collections.Generic.List_T_,int).list'></a>

`list` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.md#DiGi.Core.Modify.Extend_T_(thisSystem.Collections.Generic.List_T_,int).T 'DiGi\.Core\.Modify\.Extend\<T\>\(this System\.Collections\.Generic\.List\<T\>, int\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

List

<a name='DiGi.Core.Modify.Extend_T_(thisSystem.Collections.Generic.List_T_,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

New length of the list

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if new items added\. False if list is longer than given count value, list is empty or null

<a name='DiGi.Core.Modify.FromJsonObject(thisDiGi.Core.Interfaces.ISerializableObject,System.Text.Json.Nodes.JsonObject)'></a>

## Modify\.FromJsonObject\(this ISerializableObject, JsonObject\) Method

Populates an ISerializableObject from a JSON object\.

```csharp
public static bool FromJsonObject(this DiGi.Core.Interfaces.ISerializableObject? serializableObject, System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Modify.FromJsonObject(thisDiGi.Core.Interfaces.ISerializableObject,System.Text.Json.Nodes.JsonObject).serializableObject'></a>

`serializableObject` [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The serializable object to populate\.

<a name='DiGi.Core.Modify.FromJsonObject(thisDiGi.Core.Interfaces.ISerializableObject,System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the data\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object was successfully populated; otherwise, false\.

<a name='DiGi.Core.Modify.MatchLength_T,X_(System.Collections.Generic.List_T_,System.Collections.Generic.List_X_)'></a>

## Modify\.MatchLength\<T,X\>\(List\<T\>, List\<X\>\) Method

Matches the length of two lists by duplicating elements cyclically from the shorter list to match the longer list\.

```csharp
public static bool MatchLength<T,X>(System.Collections.Generic.List<T>? list_1, System.Collections.Generic.List<X>? list_2);
```
#### Type parameters

<a name='DiGi.Core.Modify.MatchLength_T,X_(System.Collections.Generic.List_T_,System.Collections.Generic.List_X_).T'></a>

`T`

The type of elements in the first list\.

<a name='DiGi.Core.Modify.MatchLength_T,X_(System.Collections.Generic.List_T_,System.Collections.Generic.List_X_).X'></a>

`X`

The type of elements in the second list\.
#### Parameters

<a name='DiGi.Core.Modify.MatchLength_T,X_(System.Collections.Generic.List_T_,System.Collections.Generic.List_X_).list_1'></a>

`list_1` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.md#DiGi.Core.Modify.MatchLength_T,X_(System.Collections.Generic.List_T_,System.Collections.Generic.List_X_).T 'DiGi\.Core\.Modify\.MatchLength\<T,X\>\(System\.Collections\.Generic\.List\<T\>, System\.Collections\.Generic\.List\<X\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The first list\.

<a name='DiGi.Core.Modify.MatchLength_T,X_(System.Collections.Generic.List_T_,System.Collections.Generic.List_X_).list_2'></a>

`list_2` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[X](DiGi.Core.md#DiGi.Core.Modify.MatchLength_T,X_(System.Collections.Generic.List_T_,System.Collections.Generic.List_X_).X 'DiGi\.Core\.Modify\.MatchLength\<T,X\>\(System\.Collections\.Generic\.List\<T\>, System\.Collections\.Generic\.List\<X\>\)\.X')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The second list\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if lengths were successfully matched; otherwise, false\.

<a name='DiGi.Core.Modify.ReleaseCOMObject(thisobject)'></a>

## Modify\.ReleaseCOMObject\(this object\) Method

Releases all references to a COM object\.

```csharp
public static bool ReleaseCOMObject(this object? cOMObject);
```
#### Parameters

<a name='DiGi.Core.Modify.ReleaseCOMObject(thisobject).cOMObject'></a>

`cOMObject` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The COM object to release\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object was successfully released; otherwise, false\.

<a name='DiGi.Core.Modify.Sort_T_(thisSystem.Collections.Generic.List_T_,System.Func_T,System.IComparable_)'></a>

## Modify\.Sort\<T\>\(this List\<T\>, Func\<T,IComparable\>\) Method

Sorts the elements of a list using a specified function to extract a comparable key\.

```csharp
public static void Sort<T>(this System.Collections.Generic.List<T>? list, System.Func<T,System.IComparable>? func);
```
#### Type parameters

<a name='DiGi.Core.Modify.Sort_T_(thisSystem.Collections.Generic.List_T_,System.Func_T,System.IComparable_).T'></a>

`T`

The type of elements in the list\.
#### Parameters

<a name='DiGi.Core.Modify.Sort_T_(thisSystem.Collections.Generic.List_T_,System.Func_T,System.IComparable_).list'></a>

`list` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.md#DiGi.Core.Modify.Sort_T_(thisSystem.Collections.Generic.List_T_,System.Func_T,System.IComparable_).T 'DiGi\.Core\.Modify\.Sort\<T\>\(this System\.Collections\.Generic\.List\<T\>, System\.Func\<T,System\.IComparable\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list to sort\.

<a name='DiGi.Core.Modify.Sort_T_(thisSystem.Collections.Generic.List_T_,System.Func_T,System.IComparable_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[T](DiGi.Core.md#DiGi.Core.Modify.Sort_T_(thisSystem.Collections.Generic.List_T_,System.Func_T,System.IComparable_).T 'DiGi\.Core\.Modify\.Sort\<T\>\(this System\.Collections\.Generic\.List\<T\>, System\.Func\<T,System\.IComparable\>\)\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.IComparable](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable 'System\.IComparable')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

A function to extract the comparable key from an element\.

<a name='DiGi.Core.Query'></a>

## Query Class

Provides utility methods for querying and determining data types of objects and types\.

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Core.Query.AlmostEquals(thisdouble,double,double)'></a>

## Query\.AlmostEquals\(this double, double, double\) Method

Determines whether two double values are approximately equal within a specified tolerance\.

```csharp
public static bool AlmostEquals(this double value_1, double value_2, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.Core.Query.AlmostEquals(thisdouble,double,double).value_1'></a>

`value_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The first value to compare\.

<a name='DiGi.Core.Query.AlmostEquals(thisdouble,double,double).value_2'></a>

`value_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The second value to compare\.

<a name='DiGi.Core.Query.AlmostEquals(thisdouble,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum allowed difference between the values\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the values are approximately equal; otherwise, false\.

<a name='DiGi.Core.Query.AspectRatio(thisdouble,double,bool)'></a>

## Query\.AspectRatio\(this double, double, bool\) Method

Calculates the aspect ratio of two values\.

```csharp
public static double AspectRatio(this double value_1, double value_2, bool normalized=false);
```
#### Parameters

<a name='DiGi.Core.Query.AspectRatio(thisdouble,double,bool).value_1'></a>

`value_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The first value\.

<a name='DiGi.Core.Query.AspectRatio(thisdouble,double,bool).value_2'></a>

`value_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The second value\.

<a name='DiGi.Core.Query.AspectRatio(thisdouble,double,bool).normalized'></a>

`normalized` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If true, returns the ratio of the smaller value to the larger value\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The calculated aspect ratio, or NaN if inputs are invalid\.

<a name='DiGi.Core.Query.BoundedIndex(thisDiGi.Core.Classes.Range_int_,int)'></a>

## Query\.BoundedIndex\(this Range\<int\>, int\) Method

Maps an out\-of\-bounds index back into the specified range using a wrap\-around \(circular\) logic\.
If the index is within the range, it returns the index unchanged\.
If the range is null, returns [System\.Int32\.MinValue](https://learn.microsoft.com/en-us/dotnet/api/system.int32.minvalue 'System\.Int32\.MinValue')\.

```csharp
public static int BoundedIndex(this DiGi.Core.Classes.Range<int>? range, int index);
```
#### Parameters

<a name='DiGi.Core.Query.BoundedIndex(thisDiGi.Core.Classes.Range_int_,int).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The boundaries within which the index should be contained\.

<a name='DiGi.Core.Query.BoundedIndex(thisDiGi.Core.Classes.Range_int_,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index to be evaluated or mapped\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The original index if it's within bounds;
the wrapped index if it's outside;
or [System\.Int32\.MinValue](https://learn.microsoft.com/en-us/dotnet/api/system.int32.minvalue 'System\.Int32\.MinValue') if the range is null\.

<a name='DiGi.Core.Query.BoundedIndex(thisint,int)'></a>

## Query\.BoundedIndex\(this int, int\) Method

Bounded index between 0 and count \- 1

```csharp
public static int BoundedIndex(this int count, int index);
```
#### Parameters

<a name='DiGi.Core.Query.BoundedIndex(thisint,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

Items count

<a name='DiGi.Core.Query.BoundedIndex(thisint,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

Index

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
BoundedIndex

<a name='DiGi.Core.Query.Checksum(thisstring)'></a>

## Query\.Checksum\(this string\) Method

Computes the MD5 checksum of a string\.

```csharp
public static string? Checksum(this string? value);
```
#### Parameters

<a name='DiGi.Core.Query.Checksum(thisstring).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string to compute the checksum for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the MD5 checksum, or null if the input is null\.

<a name='DiGi.Core.Query.Clamp_T_(thisDiGi.Core.Classes.Range_T_,T,T)'></a>

## Query\.Clamp\<T\>\(this Range\<T\>, T, T\) Method

Limits the values of a Range to be within the specified minimum and maximum values\.

```csharp
public static DiGi.Core.Classes.Range<T>? Clamp<T>(this DiGi.Core.Classes.Range<T>? range, T min, T max);
```
#### Type parameters

<a name='DiGi.Core.Query.Clamp_T_(thisDiGi.Core.Classes.Range_T_,T,T).T'></a>

`T`

The type of the range elements\.
#### Parameters

<a name='DiGi.Core.Query.Clamp_T_(thisDiGi.Core.Classes.Range_T_,T,T).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[T](DiGi.Core.md#DiGi.Core.Query.Clamp_T_(thisDiGi.Core.Classes.Range_T_,T,T).T 'DiGi\.Core\.Query\.Clamp\<T\>\(this DiGi\.Core\.Classes\.Range\<T\>, T, T\)\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range to clamp\.

<a name='DiGi.Core.Query.Clamp_T_(thisDiGi.Core.Classes.Range_T_,T,T).min'></a>

`min` [T](DiGi.Core.md#DiGi.Core.Query.Clamp_T_(thisDiGi.Core.Classes.Range_T_,T,T).T 'DiGi\.Core\.Query\.Clamp\<T\>\(this DiGi\.Core\.Classes\.Range\<T\>, T, T\)\.T')

The minimal value\.

<a name='DiGi.Core.Query.Clamp_T_(thisDiGi.Core.Classes.Range_T_,T,T).max'></a>

`max` [T](DiGi.Core.md#DiGi.Core.Query.Clamp_T_(thisDiGi.Core.Classes.Range_T_,T,T).T 'DiGi\.Core\.Query\.Clamp\<T\>\(this DiGi\.Core\.Classes\.Range\<T\>, T, T\)\.T')

The maximal value\.

#### Returns
[DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[T](DiGi.Core.md#DiGi.Core.Query.Clamp_T_(thisDiGi.Core.Classes.Range_T_,T,T).T 'DiGi\.Core\.Query\.Clamp\<T\>\(this DiGi\.Core\.Classes\.Range\<T\>, T, T\)\.T')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')  
A new Range clamped to the specified limits, or null if the input range is null\.

<a name='DiGi.Core.Query.Clamp_T_(thisT,T,T)'></a>

## Query\.Clamp\<T\>\(this T, T, T\) Method

Limits given value to min and max

```csharp
public static T Clamp<T>(this T value, T min, T max);
```
#### Type parameters

<a name='DiGi.Core.Query.Clamp_T_(thisT,T,T).T'></a>

`T`

The type of the values being clamped\.
#### Parameters

<a name='DiGi.Core.Query.Clamp_T_(thisT,T,T).value'></a>

`value` [T](DiGi.Core.md#DiGi.Core.Query.Clamp_T_(thisT,T,T).T 'DiGi\.Core\.Query\.Clamp\<T\>\(this T, T, T\)\.T')

Value to be clamped

<a name='DiGi.Core.Query.Clamp_T_(thisT,T,T).min'></a>

`min` [T](DiGi.Core.md#DiGi.Core.Query.Clamp_T_(thisT,T,T).T 'DiGi\.Core\.Query\.Clamp\<T\>\(this T, T, T\)\.T')

Minimal Value

<a name='DiGi.Core.Query.Clamp_T_(thisT,T,T).max'></a>

`max` [T](DiGi.Core.md#DiGi.Core.Query.Clamp_T_(thisT,T,T).T 'DiGi\.Core\.Query\.Clamp\<T\>\(this T, T, T\)\.T')

Maximal Value

#### Returns
[T](DiGi.Core.md#DiGi.Core.Query.Clamp_T_(thisT,T,T).T 'DiGi\.Core\.Query\.Clamp\<T\>\(this T, T, T\)\.T')  
Clamp value

<a name='DiGi.Core.Query.Clone_T_(thisSystem.Collections.Generic.IEnumerable_T_)'></a>

## Query\.Clone\<T\>\(this IEnumerable\<T\>\) Method

Clones a sequence of serializable objects into a new list\.

```csharp
public static System.Collections.Generic.List<T?>? Clone<T>(this System.Collections.Generic.IEnumerable<T?>? serializableObjects)
    where T : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.Query.Clone_T_(thisSystem.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of the serializable objects\.
#### Parameters

<a name='DiGi.Core.Query.Clone_T_(thisSystem.Collections.Generic.IEnumerable_T_).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.md#DiGi.Core.Query.Clone_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'DiGi\.Core\.Query\.Clone\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sequence of objects to clone\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.md#DiGi.Core.Query.Clone_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'DiGi\.Core\.Query\.Clone\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A new list containing the cloned objects, or null if the input is null\.

<a name='DiGi.Core.Query.Clone_T_(thisT[])'></a>

## Query\.Clone\<T\>\(this T\[\]\) Method

Clones an array into a new array\.

```csharp
public static T?[]? Clone<T>(this T?[]? values);
```
#### Type parameters

<a name='DiGi.Core.Query.Clone_T_(thisT[]).T'></a>

`T`

The type of the array elements\.
#### Parameters

<a name='DiGi.Core.Query.Clone_T_(thisT[]).values'></a>

`values` [T](DiGi.Core.md#DiGi.Core.Query.Clone_T_(thisT[]).T 'DiGi\.Core\.Query\.Clone\<T\>\(this T\[\]\)\.T')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The array to clone\.

#### Returns
[T](DiGi.Core.md#DiGi.Core.Query.Clone_T_(thisT[]).T 'DiGi\.Core\.Query\.Clone\<T\>\(this T\[\]\)\.T')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
A new array containing the cloned elements, or null if the input is null\.

<a name='DiGi.Core.Query.Clone_TSerializableObject_(thisTSerializableObject)'></a>

## Query\.Clone\<TSerializableObject\>\(this TSerializableObject\) Method

Creates a clone of a serializable object\.

```csharp
public static TSerializableObject? Clone<TSerializableObject>(this TSerializableObject? serializableObject)
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.Query.Clone_TSerializableObject_(thisTSerializableObject).TSerializableObject'></a>

`TSerializableObject`

The type of the serializable object\.
#### Parameters

<a name='DiGi.Core.Query.Clone_TSerializableObject_(thisTSerializableObject).serializableObject'></a>

`serializableObject` [TSerializableObject](DiGi.Core.md#DiGi.Core.Query.Clone_TSerializableObject_(thisTSerializableObject).TSerializableObject 'DiGi\.Core\.Query\.Clone\<TSerializableObject\>\(this TSerializableObject\)\.TSerializableObject')

The object to clone\.

#### Returns
[TSerializableObject](DiGi.Core.md#DiGi.Core.Query.Clone_TSerializableObject_(thisTSerializableObject).TSerializableObject 'DiGi\.Core\.Query\.Clone\<TSerializableObject\>\(this TSerializableObject\)\.TSerializableObject')  
A cloned instance of the object, or default if cloning fails\.

<a name='DiGi.Core.Query.CloneAndFilterNulls_T_(thisSystem.Collections.Generic.IEnumerable_T_)'></a>

## Query\.CloneAndFilterNulls\<T\>\(this IEnumerable\<T\>\) Method

Clones a sequence of serializable objects and filters out any null results\.

```csharp
public static System.Collections.Generic.List<T>? CloneAndFilterNulls<T>(this System.Collections.Generic.IEnumerable<T?>? serializableObjects)
    where T : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.Query.CloneAndFilterNulls_T_(thisSystem.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of the serializable objects\.
#### Parameters

<a name='DiGi.Core.Query.CloneAndFilterNulls_T_(thisSystem.Collections.Generic.IEnumerable_T_).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.md#DiGi.Core.Query.CloneAndFilterNulls_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'DiGi\.Core\.Query\.CloneAndFilterNulls\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sequence of objects to clone\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.md#DiGi.Core.Query.CloneAndFilterNulls_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'DiGi\.Core\.Query\.CloneAndFilterNulls\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of non\-null cloned objects, or null if the input is null\.

<a name='DiGi.Core.Query.Compare(thisdouble,double,DiGi.Core.Enums.NumberComparisonType)'></a>

## Query\.Compare\(this double, double, NumberComparisonType\) Method

Compares two numbers using NumberComparisonType \(Example: NumberComparisonType\.Greater returns true if value\_1 greater than value\_2\)

```csharp
public static bool Compare(this double value_1, double value_2, DiGi.Core.Enums.NumberComparisonType numberComparisonType);
```
#### Parameters

<a name='DiGi.Core.Query.Compare(thisdouble,double,DiGi.Core.Enums.NumberComparisonType).value_1'></a>

`value_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

First value

<a name='DiGi.Core.Query.Compare(thisdouble,double,DiGi.Core.Enums.NumberComparisonType).value_2'></a>

`value_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Second value

<a name='DiGi.Core.Query.Compare(thisdouble,double,DiGi.Core.Enums.NumberComparisonType).numberComparisonType'></a>

`numberComparisonType` [NumberComparisonType](DiGi.Core.Enums.md#DiGi.Core.Enums.NumberComparisonType 'DiGi\.Core\.Enums\.NumberComparisonType')

Number Comparison Type example Equals etc\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
Comparison Type Result

<a name='DiGi.Core.Query.Compare(thisdouble,double,DiGi.Core.Enums.NumberComparisonType,double)'></a>

## Query\.Compare\(this double, double, NumberComparisonType, double\) Method

Compares two numbers using NumberComparisonType \(Example: NumberComparisonType\.Greater returns true if value\_1 greater than value\_2\)

```csharp
public static bool Compare(this double value_1, double value_2, DiGi.Core.Enums.NumberComparisonType numberComparisonType, double tolerance);
```
#### Parameters

<a name='DiGi.Core.Query.Compare(thisdouble,double,DiGi.Core.Enums.NumberComparisonType,double).value_1'></a>

`value_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

First value

<a name='DiGi.Core.Query.Compare(thisdouble,double,DiGi.Core.Enums.NumberComparisonType,double).value_2'></a>

`value_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Second value

<a name='DiGi.Core.Query.Compare(thisdouble,double,DiGi.Core.Enums.NumberComparisonType,double).numberComparisonType'></a>

`numberComparisonType` [NumberComparisonType](DiGi.Core.Enums.md#DiGi.Core.Enums.NumberComparisonType 'DiGi\.Core\.Enums\.NumberComparisonType')

Number Comparison Type example Equals etc\.

<a name='DiGi.Core.Query.Compare(thisdouble,double,DiGi.Core.Enums.NumberComparisonType,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Comparison tolerance

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
Comparison Type Result

<a name='DiGi.Core.Query.Compare(thisstring,string,DiGi.Core.Enums.TextComparisonType,bool)'></a>

## Query\.Compare\(this string, string, TextComparisonType, bool\) Method

Compares two numbers using TextComparisonType \(Example: TextComparisonType\.StartsWith returns true if value\_1 starts with value\_2\)

```csharp
public static bool Compare(this string? value_1, string? value_2, DiGi.Core.Enums.TextComparisonType textComparisonType, bool caseSensitive=true);
```
#### Parameters

<a name='DiGi.Core.Query.Compare(thisstring,string,DiGi.Core.Enums.TextComparisonType,bool).value_1'></a>

`value_1` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Base value to be checked, reference text ie\.GUID to be found

<a name='DiGi.Core.Query.Compare(thisstring,string,DiGi.Core.Enums.TextComparisonType,bool).value_2'></a>

`value_2` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Text to be checked ie\. name containing GUID

<a name='DiGi.Core.Query.Compare(thisstring,string,DiGi.Core.Enums.TextComparisonType,bool).textComparisonType'></a>

`textComparisonType` [TextComparisonType](DiGi.Core.Enums.md#DiGi.Core.Enums.TextComparisonType 'DiGi\.Core\.Enums\.TextComparisonType')

Text Comparison Type

<a name='DiGi.Core.Query.Compare(thisstring,string,DiGi.Core.Enums.TextComparisonType,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Case Sensitive

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
Bool

<a name='DiGi.Core.Query.Compare(thisSystem.Collections.Generic.IEnumerable_double_,double,DiGi.Core.Enums.NumberComparisonType)'></a>

## Query\.Compare\(this IEnumerable\<double\>, double, NumberComparisonType\) Method

Compares a collection of doubles against a single double using the specified comparison type\.

```csharp
public static System.Collections.Generic.List<bool>? Compare(this System.Collections.Generic.IEnumerable<double>? values, double value, DiGi.Core.Enums.NumberComparisonType numberComparisonType);
```
#### Parameters

<a name='DiGi.Core.Query.Compare(thisSystem.Collections.Generic.IEnumerable_double_,double,DiGi.Core.Enums.NumberComparisonType).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of doubles to compare\.

<a name='DiGi.Core.Query.Compare(thisSystem.Collections.Generic.IEnumerable_double_,double,DiGi.Core.Enums.NumberComparisonType).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double to compare against\.

<a name='DiGi.Core.Query.Compare(thisSystem.Collections.Generic.IEnumerable_double_,double,DiGi.Core.Enums.NumberComparisonType).numberComparisonType'></a>

`numberComparisonType` [NumberComparisonType](DiGi.Core.Enums.md#DiGi.Core.Enums.NumberComparisonType 'DiGi\.Core\.Enums\.NumberComparisonType')

The numeric comparison type to use\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of booleans representing the comparison results\.

<a name='DiGi.Core.Query.Compare(thisSystem.Collections.Generic.IEnumerable_string_,string,DiGi.Core.Enums.TextComparisonType,bool)'></a>

## Query\.Compare\(this IEnumerable\<string\>, string, TextComparisonType, bool\) Method

Compares a collection of strings against a single string using the specified comparison type\.

```csharp
public static System.Collections.Generic.List<bool>? Compare(this System.Collections.Generic.IEnumerable<string>? values, string? value, DiGi.Core.Enums.TextComparisonType textComparisonType, bool caseSensitive=true);
```
#### Parameters

<a name='DiGi.Core.Query.Compare(thisSystem.Collections.Generic.IEnumerable_string_,string,DiGi.Core.Enums.TextComparisonType,bool).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of strings to compare\.

<a name='DiGi.Core.Query.Compare(thisSystem.Collections.Generic.IEnumerable_string_,string,DiGi.Core.Enums.TextComparisonType,bool).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string to compare against\.

<a name='DiGi.Core.Query.Compare(thisSystem.Collections.Generic.IEnumerable_string_,string,DiGi.Core.Enums.TextComparisonType,bool).textComparisonType'></a>

`textComparisonType` [TextComparisonType](DiGi.Core.Enums.md#DiGi.Core.Enums.TextComparisonType 'DiGi\.Core\.Enums\.TextComparisonType')

The comparison type to use\.

<a name='DiGi.Core.Query.Compare(thisSystem.Collections.Generic.IEnumerable_string_,string,DiGi.Core.Enums.TextComparisonType,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether the comparison should be case sensitive\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of booleans representing the comparison results\.

<a name='DiGi.Core.Query.Compare(thisSystem.DateTime,System.DateTime,DiGi.Core.Enums.NumberComparisonType)'></a>

## Query\.Compare\(this DateTime, DateTime, NumberComparisonType\) Method

Compares two DateTimes using NumberComparisonType \(Example: NumberComparisonType\.Greater returns true if value\_1 greater than value\_2\)

```csharp
public static bool Compare(this System.DateTime value_1, System.DateTime value_2, DiGi.Core.Enums.NumberComparisonType numberComparisonType);
```
#### Parameters

<a name='DiGi.Core.Query.Compare(thisSystem.DateTime,System.DateTime,DiGi.Core.Enums.NumberComparisonType).value_1'></a>

`value_1` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

First value

<a name='DiGi.Core.Query.Compare(thisSystem.DateTime,System.DateTime,DiGi.Core.Enums.NumberComparisonType).value_2'></a>

`value_2` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

Second value

<a name='DiGi.Core.Query.Compare(thisSystem.DateTime,System.DateTime,DiGi.Core.Enums.NumberComparisonType).numberComparisonType'></a>

`numberComparisonType` [NumberComparisonType](DiGi.Core.Enums.md#DiGi.Core.Enums.NumberComparisonType 'DiGi\.Core\.Enums\.NumberComparisonType')

Number Comparison Type example Equals etc\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
Comparison Type Result

<a name='DiGi.Core.Query.Compress(thisDiGi.Core.Interfaces.ISerializableObject)'></a>

## Query\.Compress\(this ISerializableObject\) Method

Compresses an ISerializableObject into a Base64 encoded string\.

```csharp
public static string? Compress(this DiGi.Core.Interfaces.ISerializableObject? serializableObject);
```
#### Parameters

<a name='DiGi.Core.Query.Compress(thisDiGi.Core.Interfaces.ISerializableObject).serializableObject'></a>

`serializableObject` [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The object to compress\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A compressed string, or null if the object is null\.

<a name='DiGi.Core.Query.Compress(thisstring)'></a>

## Query\.Compress\(this string\) Method

Source: https://stackoverflow\.com/questions/7343465/compression\-decompression\-string\-with\-c\-sharp

```csharp
public static string? Compress(this string? @string);
```
#### Parameters

<a name='DiGi.Core.Query.Compress(thisstring).string'></a>

`string` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

String to be compressed

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
Compressed string

<a name='DiGi.Core.Query.Compress_T_(thisSystem.Collections.Generic.IEnumerable_T_)'></a>

## Query\.Compress\<T\>\(this IEnumerable\<T\>\) Method

Compresses a collection of ISerializableObject into a Base64 encoded string\.

```csharp
public static string? Compress<T>(this System.Collections.Generic.IEnumerable<T>? serializableObject)
    where T : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.Query.Compress_T_(thisSystem.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of the serializable objects\.
#### Parameters

<a name='DiGi.Core.Query.Compress_T_(thisSystem.Collections.Generic.IEnumerable_T_).serializableObject'></a>

`serializableObject` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.md#DiGi.Core.Query.Compress_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'DiGi\.Core\.Query\.Compress\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of objects to compress\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A compressed string, or null if the collection is null\.

<a name='DiGi.Core.Query.CustomAttribute_TAttribute_(System.Enum)'></a>

## Query\.CustomAttribute\<TAttribute\>\(Enum\) Method

Optimized retrieval of a custom attribute from an Enum value\.

```csharp
public static TAttribute? CustomAttribute<TAttribute>(System.Enum? @enum)
    where TAttribute : System.Attribute;
```
#### Type parameters

<a name='DiGi.Core.Query.CustomAttribute_TAttribute_(System.Enum).TAttribute'></a>

`TAttribute`

The type of the attribute to retrieve\.
#### Parameters

<a name='DiGi.Core.Query.CustomAttribute_TAttribute_(System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enum value to search for the attribute\.

#### Returns
[TAttribute](DiGi.Core.md#DiGi.Core.Query.CustomAttribute_TAttribute_(System.Enum).TAttribute 'DiGi\.Core\.Query\.CustomAttribute\<TAttribute\>\(System\.Enum\)\.TAttribute')  
The specified attribute if found; otherwise, null\.

<a name='DiGi.Core.Query.CustomAttribute_TAttribute_(System.Type,string)'></a>

## Query\.CustomAttribute\<TAttribute\>\(Type, string\) Method

Optimized retrieval of a custom attribute from a Type and member name\.

```csharp
public static TAttribute? CustomAttribute<TAttribute>(System.Type? type, string? text)
    where TAttribute : System.Attribute;
```
#### Type parameters

<a name='DiGi.Core.Query.CustomAttribute_TAttribute_(System.Type,string).TAttribute'></a>

`TAttribute`

The type of the attribute to retrieve\.
#### Parameters

<a name='DiGi.Core.Query.CustomAttribute_TAttribute_(System.Type,string).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type containing the member\.

<a name='DiGi.Core.Query.CustomAttribute_TAttribute_(System.Type,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the member from which to retrieve the attribute\.

#### Returns
[TAttribute](DiGi.Core.md#DiGi.Core.Query.CustomAttribute_TAttribute_(System.Type,string).TAttribute 'DiGi\.Core\.Query\.CustomAttribute\<TAttribute\>\(System\.Type, string\)\.TAttribute')  
The specified attribute if found; otherwise, null\.

<a name='DiGi.Core.Query.CustomAttribute_TAttribute_(thisSystem.Reflection.MemberInfo)'></a>

## Query\.CustomAttribute\<TAttribute\>\(this MemberInfo\) Method

Efficiently retrieves a custom attribute from MemberInfo using generic reflection extensions\.

```csharp
public static TAttribute? CustomAttribute<TAttribute>(this System.Reflection.MemberInfo? memberInfo)
    where TAttribute : System.Attribute;
```
#### Type parameters

<a name='DiGi.Core.Query.CustomAttribute_TAttribute_(thisSystem.Reflection.MemberInfo).TAttribute'></a>

`TAttribute`

The type of the attribute to retrieve\.
#### Parameters

<a name='DiGi.Core.Query.CustomAttribute_TAttribute_(thisSystem.Reflection.MemberInfo).memberInfo'></a>

`memberInfo` [System\.Reflection\.MemberInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.memberinfo 'System\.Reflection\.MemberInfo')

The member information to search for the attribute\.

#### Returns
[TAttribute](DiGi.Core.md#DiGi.Core.Query.CustomAttribute_TAttribute_(thisSystem.Reflection.MemberInfo).TAttribute 'DiGi\.Core\.Query\.CustomAttribute\<TAttribute\>\(this System\.Reflection\.MemberInfo\)\.TAttribute')  
The specified attribute if found; otherwise, null\.

<a name='DiGi.Core.Query.CustomTypeAttribute_TAttribute_(System.Type)'></a>

## Query\.CustomTypeAttribute\<TAttribute\>\(Type\) Method

Retrieves an attribute from the Type level \(e\.g\., for CategoryAttribute on Enum declaration\)\.

```csharp
public static TAttribute? CustomTypeAttribute<TAttribute>(System.Type? type)
    where TAttribute : System.Attribute;
```
#### Type parameters

<a name='DiGi.Core.Query.CustomTypeAttribute_TAttribute_(System.Type).TAttribute'></a>

`TAttribute`

The type of the attribute to retrieve\.
#### Parameters

<a name='DiGi.Core.Query.CustomTypeAttribute_TAttribute_(System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type from which to retrieve the attribute\.

#### Returns
[TAttribute](DiGi.Core.md#DiGi.Core.Query.CustomTypeAttribute_TAttribute_(System.Type).TAttribute 'DiGi\.Core\.Query\.CustomTypeAttribute\<TAttribute\>\(System\.Type\)\.TAttribute')  
The specified attribute if found; otherwise, null\.

<a name='DiGi.Core.Query.DataType(thisobject)'></a>

## Query\.DataType\(this object\) Method

Gets the DiGi\.Core\.Enums\.DataType of the specified object\.

```csharp
public static DiGi.Core.Enums.DataType DataType(this object? @object);
```
#### Parameters

<a name='DiGi.Core.Query.DataType(thisobject).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object for which to get the data type\.

#### Returns
[DataType](DiGi.Core.Enums.md#DiGi.Core.Enums.DataType 'DiGi\.Core\.Enums\.DataType')  
The DiGi\.Core\.Enums\.DataType of the specified object\.

<a name='DiGi.Core.Query.DataType(thisobject,bool)'></a>

## Query\.DataType\(this object, bool\) Method

Gets the DiGi\.Core\.Enums\.DataType of the specified object and determines if it is nullable\.

```csharp
public static DiGi.Core.Enums.DataType DataType(this object? @object, out bool nullable);
```
#### Parameters

<a name='DiGi.Core.Query.DataType(thisobject,bool).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object for which to get the data type\.

<a name='DiGi.Core.Query.DataType(thisobject,bool).nullable'></a>

`nullable` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

When this method returns, contains a boolean value indicating whether the type is nullable\.

#### Returns
[DataType](DiGi.Core.Enums.md#DiGi.Core.Enums.DataType 'DiGi\.Core\.Enums\.DataType')  
The DiGi\.Core\.Enums\.DataType of the specified object\.

<a name='DiGi.Core.Query.DataType(thisSystem.Type)'></a>

## Query\.DataType\(this Type\) Method

Gets the DiGi\.Core\.Enums\.DataType of the specified type\.

```csharp
public static DiGi.Core.Enums.DataType DataType(this System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Query.DataType(thisSystem.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type for which to get the data type\.

#### Returns
[DataType](DiGi.Core.Enums.md#DiGi.Core.Enums.DataType 'DiGi\.Core\.Enums\.DataType')  
The DiGi\.Core\.Enums\.DataType of the specified type\.

<a name='DiGi.Core.Query.DataType(thisSystem.Type,bool)'></a>

## Query\.DataType\(this Type, bool\) Method

Gets the DiGi\.Core\.Enums\.DataType of the specified type and determines if it is nullable\.

```csharp
public static DiGi.Core.Enums.DataType DataType(this System.Type? type, out bool nullable);
```
#### Parameters

<a name='DiGi.Core.Query.DataType(thisSystem.Type,bool).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type for which to get the data type\.

<a name='DiGi.Core.Query.DataType(thisSystem.Type,bool).nullable'></a>

`nullable` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

When this method returns, contains a boolean value indicating whether the type is nullable\.

#### Returns
[DataType](DiGi.Core.Enums.md#DiGi.Core.Enums.DataType 'DiGi\.Core\.Enums\.DataType')  
The DiGi\.Core\.Enums\.DataType of the specified type\.

<a name='DiGi.Core.Query.DecimalPlacesCount(thisdouble)'></a>

## Query\.DecimalPlacesCount\(this double\) Method

Counts the number of decimal places in a double value\.

```csharp
public static int DecimalPlacesCount(this double value);
```
#### Parameters

<a name='DiGi.Core.Query.DecimalPlacesCount(thisdouble).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value to evaluate\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The number of decimal places\.

<a name='DiGi.Core.Query.Decompress(thisstring)'></a>

## Query\.Decompress\(this string\) Method

Source: https://stackoverflow\.com/questions/7343465/compression\-decompression\-string\-with\-c\-sharp

```csharp
public static string? Decompress(this string? @string);
```
#### Parameters

<a name='DiGi.Core.Query.Decompress(thisstring).string'></a>

`string` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Compressed string to be decompressed

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
Decompressed string

<a name='DiGi.Core.Query.Decompress_T_(thisstring)'></a>

## Query\.Decompress\<T\>\(this string\) Method

Decompresses a Base64 encoded string back into a collection of ISerializableObjects\.

```csharp
public static System.Collections.Generic.List<T>? Decompress<T>(this string? @string)
    where T : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.Query.Decompress_T_(thisstring).T'></a>

`T`

The type of the serializable objects\.
#### Parameters

<a name='DiGi.Core.Query.Decompress_T_(thisstring).string'></a>

`string` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string to decompress\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.md#DiGi.Core.Query.Decompress_T_(thisstring).T 'DiGi\.Core\.Query\.Decompress\<T\>\(this string\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of deserialized objects, or null if decompression fails\.

<a name='DiGi.Core.Query.Default(thisSystem.Type)'></a>

## Query\.Default\(this Type\) Method

Returns the default value for a given Type\.

```csharp
public static object? Default(this System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Query.Default(thisSystem.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to get the default value for\.

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')  
The default value, or null for reference types\.

<a name='DiGi.Core.Query.Description(thisSystem.Enum)'></a>

## Query\.Description\(this Enum\) Method

Gets the description attribute of an enum value\.

```csharp
public static string? Description(this System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Core.Query.Description(thisSystem.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enum value\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The description string, or the enum name if no attribute is found\.

<a name='DiGi.Core.Query.Description(thisSystem.Type)'></a>

## Query\.Description\(this Type\) Method

Gets the description attribute of a Type\.

```csharp
public static string? Description(this System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Query.Description(thisSystem.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The description string, or the type name if no attribute is found\.

<a name='DiGi.Core.Query.Directories(string)'></a>

## Query\.Directories\(string\) Method

Retrieves a list of all parent directories up to the root for a given directory path\.

```csharp
public static System.Collections.Generic.List<string>? Directories(string? directory);
```
#### Parameters

<a name='DiGi.Core.Query.Directories(string).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The starting directory path\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of directory paths, or null if the path is invalid\.

<a name='DiGi.Core.Query.Directories(System.IO.DirectoryInfo)'></a>

## Query\.Directories\(DirectoryInfo\) Method

Retrieves a list of all parent directories up to the root for a given DirectoryInfo\.

```csharp
public static System.Collections.Generic.List<string>? Directories(System.IO.DirectoryInfo? directoryInfo);
```
#### Parameters

<a name='DiGi.Core.Query.Directories(System.IO.DirectoryInfo).directoryInfo'></a>

`directoryInfo` [System\.IO\.DirectoryInfo](https://learn.microsoft.com/en-us/dotnet/api/system.io.directoryinfo 'System\.IO\.DirectoryInfo')

The DirectoryInfo object\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of directory paths, or null if the DirectoryInfo is null\.

<a name='DiGi.Core.Query.Duplicate_TGuidObject_(thisTGuidObject,System.Nullable_System.Guid_)'></a>

## Query\.Duplicate\<TGuidObject\>\(this TGuidObject, Nullable\<Guid\>\) Method

Creates a duplicate of an IGuidObject, optionally assigning it a new Guid\.

```csharp
public static TGuidObject? Duplicate<TGuidObject>(this TGuidObject? guidObject, System.Nullable<System.Guid> guid=null)
    where TGuidObject : DiGi.Core.Interfaces.IGuidObject;
```
#### Type parameters

<a name='DiGi.Core.Query.Duplicate_TGuidObject_(thisTGuidObject,System.Nullable_System.Guid_).TGuidObject'></a>

`TGuidObject`

The type of the GUID object\.
#### Parameters

<a name='DiGi.Core.Query.Duplicate_TGuidObject_(thisTGuidObject,System.Nullable_System.Guid_).guidObject'></a>

`guidObject` [TGuidObject](DiGi.Core.md#DiGi.Core.Query.Duplicate_TGuidObject_(thisTGuidObject,System.Nullable_System.Guid_).TGuidObject 'DiGi\.Core\.Query\.Duplicate\<TGuidObject\>\(this TGuidObject, System\.Nullable\<System\.Guid\>\)\.TGuidObject')

The object to duplicate\.

<a name='DiGi.Core.Query.Duplicate_TGuidObject_(thisTGuidObject,System.Nullable_System.Guid_).guid'></a>

`guid` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional new GUID to assign to the duplicate\.

#### Returns
[TGuidObject](DiGi.Core.md#DiGi.Core.Query.Duplicate_TGuidObject_(thisTGuidObject,System.Nullable_System.Guid_).TGuidObject 'DiGi\.Core\.Query\.Duplicate\<TGuidObject\>\(this TGuidObject, System\.Nullable\<System\.Guid\>\)\.TGuidObject')  
A duplicated object, or default if the duplication fails\.

<a name='DiGi.Core.Query.Enum(string,System.Type)'></a>

## Query\.Enum\(string, Type\) Method

Parses a string into an Enum value of the specified type\.

```csharp
public static System.Enum? Enum(string? text, System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Query.Enum(string,System.Type).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string representation of the Enum\.

<a name='DiGi.Core.Query.Enum(string,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The Type of the Enum\.

#### Returns
[System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')  
The parsed Enum value, or null if parsing fails\.

<a name='DiGi.Core.Query.Enum_TEnum_(string)'></a>

## Query\.Enum\<TEnum\>\(string\) Method

Parses a string into a strongly\-typed Enum value\.

```csharp
public static TEnum? Enum<TEnum>(string? text)
    where TEnum : System.Enum;
```
#### Type parameters

<a name='DiGi.Core.Query.Enum_TEnum_(string).TEnum'></a>

`TEnum`

The type of the Enum\.
#### Parameters

<a name='DiGi.Core.Query.Enum_TEnum_(string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string representation of the Enum\.

#### Returns
[TEnum](DiGi.Core.md#DiGi.Core.Query.Enum_TEnum_(string).TEnum 'DiGi\.Core\.Query\.Enum\<TEnum\>\(string\)\.TEnum')  
The parsed Enum value, or the 'Undefined' enum value if found, or default if parsing fails\.

<a name='DiGi.Core.Query.Enum_TEnum_(string,TEnum)'></a>

## Query\.Enum\<TEnum\>\(string, TEnum\) Method

Parses a string into a strongly\-typed Enum value, providing a fallback default value\.

```csharp
public static TEnum? Enum<TEnum>(string? text, TEnum? @default)
    where TEnum : System.Enum;
```
#### Type parameters

<a name='DiGi.Core.Query.Enum_TEnum_(string,TEnum).TEnum'></a>

`TEnum`

The type of the Enum\.
#### Parameters

<a name='DiGi.Core.Query.Enum_TEnum_(string,TEnum).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string representation of the Enum\.

<a name='DiGi.Core.Query.Enum_TEnum_(string,TEnum).default'></a>

`default` [TEnum](DiGi.Core.md#DiGi.Core.Query.Enum_TEnum_(string,TEnum).TEnum 'DiGi\.Core\.Query\.Enum\<TEnum\>\(string, TEnum\)\.TEnum')

The default value to return if parsing fails\.

#### Returns
[TEnum](DiGi.Core.md#DiGi.Core.Query.Enum_TEnum_(string,TEnum).TEnum 'DiGi\.Core\.Query\.Enum\<TEnum\>\(string, TEnum\)\.TEnum')  
The parsed Enum value, or the default if parsing fails\.

<a name='DiGi.Core.Query.Equals(thisbyte[],byte[])'></a>

## Query\.Equals\(this byte\[\], byte\[\]\) Method

Compares two byte arrays for equality\.

```csharp
public static bool Equals(this byte[]? bytes_1, byte[]? bytes_2);
```
#### Parameters

<a name='DiGi.Core.Query.Equals(thisbyte[],byte[]).bytes_1'></a>

`bytes_1` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The first byte array\.

<a name='DiGi.Core.Query.Equals(thisbyte[],byte[]).bytes_2'></a>

`bytes_2` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The second byte array\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the arrays are equal; otherwise, false\.

<a name='DiGi.Core.Query.Equals(thisSystem.Collections.IEnumerable,System.Collections.IEnumerable)'></a>

## Query\.Equals\(this IEnumerable, IEnumerable\) Method

Compares two non\-generic IEnumerable collections for equality\.

```csharp
public static bool Equals(this System.Collections.IEnumerable? enumerable_1, System.Collections.IEnumerable? enumerable_2);
```
#### Parameters

<a name='DiGi.Core.Query.Equals(thisSystem.Collections.IEnumerable,System.Collections.IEnumerable).enumerable_1'></a>

`enumerable_1` [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')

The first collection\.

<a name='DiGi.Core.Query.Equals(thisSystem.Collections.IEnumerable,System.Collections.IEnumerable).enumerable_2'></a>

`enumerable_2` [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')

The second collection\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the collections contain the same elements in the same order; otherwise, false\.

<a name='DiGi.Core.Query.Equals_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Collections.Generic.IEnumerable_T_)'></a>

## Query\.Equals\<T\>\(this IEnumerable\<T\>, IEnumerable\<T\>\) Method

Compares two generic IEnumerable collections for equality\.

```csharp
public static bool Equals<T>(this System.Collections.Generic.IEnumerable<T>? enumerable_1, System.Collections.Generic.IEnumerable<T>? enumerable_2);
```
#### Type parameters

<a name='DiGi.Core.Query.Equals_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of the elements in the collections\.
#### Parameters

<a name='DiGi.Core.Query.Equals_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Collections.Generic.IEnumerable_T_).enumerable_1'></a>

`enumerable_1` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.md#DiGi.Core.Query.Equals_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Collections.Generic.IEnumerable_T_).T 'DiGi\.Core\.Query\.Equals\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The first collection\.

<a name='DiGi.Core.Query.Equals_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Collections.Generic.IEnumerable_T_).enumerable_2'></a>

`enumerable_2` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.md#DiGi.Core.Query.Equals_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Collections.Generic.IEnumerable_T_).T 'DiGi\.Core\.Query\.Equals\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The second collection\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the collections contain the same elements in the same order; otherwise, false\.

<a name='DiGi.Core.Query.Escaped(thisstring)'></a>

## Query\.Escaped\(this string\) Method

Escapes a scalar value for use as a segment of a reference string\.

Only the grammar metacharacters are escaped: the escape character itself, each character of
            [Separator](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.Separator 'DiGi\.Core\.Constants\.Reference\.Separator'), and the nesting delimiters. Every other character - including
            quotes, brackets and unicode - is a literal and passes through untouched.

The mapping is prefix-free and invertible by [Unescaped\(this string\)](DiGi.Core.md#DiGi.Core.Query.Unescaped(thisstring) 'DiGi\.Core\.Query\.Unescaped\(this string\)'). Because a literal
            escape character is always doubled, no real value can render as [Null](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.Null 'DiGi\.Core\.Constants\.Reference\.Null').

```csharp
public static string Escaped(this string? value);
```
#### Parameters

<a name='DiGi.Core.Query.Escaped(thisstring).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The scalar value to escape\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The escaped value, or [Null](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.Null 'DiGi\.Core\.Constants\.Reference\.Null') when [value](DiGi.Core.md#DiGi.Core.Query.Escaped(thisstring).value 'DiGi\.Core\.Query\.Escaped\(this string\)\.value') is null\.

<a name='DiGi.Core.Query.ExtensionMethodInfos(System.Type)'></a>

## Query\.ExtensionMethodInfos\(Type\) Method

Retrieves all public static extension methods from the current app domain assemblies\.

```csharp
public static System.Collections.Generic.List<System.Reflection.MethodInfo> ExtensionMethodInfos(System.Type? type=null);
```
#### Parameters

<a name='DiGi.Core.Query.ExtensionMethodInfos(System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

Optional\. The type that the extension method extends\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Reflection\.MethodInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.methodinfo 'System\.Reflection\.MethodInfo')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of MethodInfo objects representing the extension methods\.

<a name='DiGi.Core.Query.Filter_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_,System.Collections.Generic.List_T_,System.Collections.Generic.List_T_)'></a>

## Query\.Filter\<T\>\(this IEnumerable\<T\>, Func\<T,bool\>, List\<T\>, List\<T\>\) Method

Filters a sequence of values based on a predicate, splitting them into matching and non\-matching lists\.

```csharp
public static bool Filter<T>(this System.Collections.Generic.IEnumerable<T>? values, System.Func<T?,bool> func, out System.Collections.Generic.List<T>? values_In, out System.Collections.Generic.List<T>? values_Out);
```
#### Type parameters

<a name='DiGi.Core.Query.Filter_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_,System.Collections.Generic.List_T_,System.Collections.Generic.List_T_).T'></a>

`T`

The type of elements in the sequence\.
#### Parameters

<a name='DiGi.Core.Query.Filter_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_,System.Collections.Generic.List_T_,System.Collections.Generic.List_T_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.md#DiGi.Core.Query.Filter_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_,System.Collections.Generic.List_T_,System.Collections.Generic.List_T_).T 'DiGi\.Core\.Query\.Filter\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, System\.Func\<T,bool\>, System\.Collections\.Generic\.List\<T\>, System\.Collections\.Generic\.List\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sequence to filter\.

<a name='DiGi.Core.Query.Filter_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_,System.Collections.Generic.List_T_,System.Collections.Generic.List_T_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[T](DiGi.Core.md#DiGi.Core.Query.Filter_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_,System.Collections.Generic.List_T_,System.Collections.Generic.List_T_).T 'DiGi\.Core\.Query\.Filter\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, System\.Func\<T,bool\>, System\.Collections\.Generic\.List\<T\>, System\.Collections\.Generic\.List\<T\>\)\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The predicate function to test each element\.

<a name='DiGi.Core.Query.Filter_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_,System.Collections.Generic.List_T_,System.Collections.Generic.List_T_).values_In'></a>

`values_In` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.md#DiGi.Core.Query.Filter_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_,System.Collections.Generic.List_T_,System.Collections.Generic.List_T_).T 'DiGi\.Core\.Query\.Filter\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, System\.Func\<T,bool\>, System\.Collections\.Generic\.List\<T\>, System\.Collections\.Generic\.List\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains the elements that satisfied the condition\.

<a name='DiGi.Core.Query.Filter_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_,System.Collections.Generic.List_T_,System.Collections.Generic.List_T_).values_Out'></a>

`values_Out` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.md#DiGi.Core.Query.Filter_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_,System.Collections.Generic.List_T_,System.Collections.Generic.List_T_).T 'DiGi\.Core\.Query\.Filter\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, System\.Func\<T,bool\>, System\.Collections\.Generic\.List\<T\>, System\.Collections\.Generic\.List\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains the elements that did not satisfy the condition\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the filtering was successful; otherwise, false\.

<a name='DiGi.Core.Query.FilterNulls_T_(thisSystem.Collections.Generic.IEnumerable_T_)'></a>

## Query\.FilterNulls\<T\>\(this IEnumerable\<T\>\) Method

Filters out null values from a sequence of items\.

```csharp
public static System.Collections.Generic.List<T>? FilterNulls<T>(this System.Collections.Generic.IEnumerable<T?>? values);
```
#### Type parameters

<a name='DiGi.Core.Query.FilterNulls_T_(thisSystem.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of the elements\.
#### Parameters

<a name='DiGi.Core.Query.FilterNulls_T_(thisSystem.Collections.Generic.IEnumerable_T_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.md#DiGi.Core.Query.FilterNulls_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'DiGi\.Core\.Query\.FilterNulls\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sequence to filter\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.Core.md#DiGi.Core.Query.FilterNulls_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'DiGi\.Core\.Query\.FilterNulls\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing only the non\-null elements, or null if the input is null\.

<a name='DiGi.Core.Query.Find_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_)'></a>

## Query\.Find\<T\>\(this IEnumerable\<T\>, Func\<T,bool\>\) Method

Finds the first element in a sequence that satisfies a specified condition\.

```csharp
public static T? Find<T>(this System.Collections.Generic.IEnumerable<T?>? values, System.Func<T?,bool> func);
```
#### Type parameters

<a name='DiGi.Core.Query.Find_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).T'></a>

`T`

The type of the elements\.
#### Parameters

<a name='DiGi.Core.Query.Find_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.md#DiGi.Core.Query.Find_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).T 'DiGi\.Core\.Query\.Find\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, System\.Func\<T,bool\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sequence to search\.

<a name='DiGi.Core.Query.Find_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[T](DiGi.Core.md#DiGi.Core.Query.Find_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).T 'DiGi\.Core\.Query\.Find\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, System\.Func\<T,bool\>\)\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The predicate function\.

#### Returns
[T](DiGi.Core.md#DiGi.Core.Query.Find_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).T 'DiGi\.Core\.Query\.Find\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, System\.Func\<T,bool\>\)\.T')  
The first element that matches the condition, or default if not found\.

<a name='DiGi.Core.Query.Flatten(thisSystem.Text.Json.Nodes.JsonArray)'></a>

## Query\.Flatten\(this JsonArray\) Method

Flattens a nested JSON array into a single\-dimensional JSON array\.

```csharp
public static System.Text.Json.Nodes.JsonArray? Flatten(this System.Text.Json.Nodes.JsonArray? jsonArray);
```
#### Parameters

<a name='DiGi.Core.Query.Flatten(thisSystem.Text.Json.Nodes.JsonArray).jsonArray'></a>

`jsonArray` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The JSON array to flatten\.

#### Returns
[System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')  
A new flattened JSON array, or null if the input is null\.

<a name='DiGi.Core.Query.FullName(thisSystem.Enum)'></a>

## Query\.FullName\(this Enum\) Method

Gets the full name of an enum value, including its full type name\.

```csharp
public static string? FullName(this System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Core.Query.FullName(thisSystem.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enum value\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The formatted full name string, or null if the input is null\.

<a name='DiGi.Core.Query.FullTypeName(DiGi.Core.Interfaces.ISerializableObject)'></a>

## Query\.FullTypeName\(ISerializableObject\) Method

Retrieves the full type name of an ISerializableObject\.

```csharp
public static string? FullTypeName(DiGi.Core.Interfaces.ISerializableObject? serializableObject);
```
#### Parameters

<a name='DiGi.Core.Query.FullTypeName(DiGi.Core.Interfaces.ISerializableObject).serializableObject'></a>

`serializableObject` [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The serializable object\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The full type name\.

<a name='DiGi.Core.Query.FullTypeName(System.Type)'></a>

## Query\.FullTypeName\(Type\) Method

Retrieves the full, formatted type name of a Type\.

```csharp
public static string? FullTypeName(System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Query.FullTypeName(System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The full type name\.

<a name='DiGi.Core.Query.FullTypeName(thisSystem.Text.Json.Nodes.JsonObject)'></a>

## Query\.FullTypeName\(this JsonObject\) Method

Retrieves the full type name from a JsonObject\.

```csharp
public static string? FullTypeName(this System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Query.FullTypeName(thisSystem.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The full type name, or null if not found\.

<a name='DiGi.Core.Query.HashCode(int[])'></a>

## Query\.HashCode\(int\[\]\) Method

Computes a hash code from an array of integers\.

```csharp
public static int HashCode(params int[]? values);
```
#### Parameters

<a name='DiGi.Core.Query.HashCode(int[]).values'></a>

`values` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The values to hash\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The computed hash code\.

<a name='DiGi.Core.Query.IsNullable(thisSystem.Type)'></a>

## Query\.IsNullable\(this Type\) Method

Determines whether the specified type is nullable\.

```csharp
public static bool IsNullable(this System.Type type);
```
#### Parameters

<a name='DiGi.Core.Query.IsNullable(thisSystem.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the type is nullable; otherwise, false\.

<a name='DiGi.Core.Query.IsNumeric(thisDiGi.Core.Enums.DataType)'></a>

## Query\.IsNumeric\(this DataType\) Method

Determines whether the specified DataType represents a numeric type\.

```csharp
public static bool IsNumeric(this DiGi.Core.Enums.DataType dataType);
```
#### Parameters

<a name='DiGi.Core.Query.IsNumeric(thisDiGi.Core.Enums.DataType).dataType'></a>

`dataType` [DataType](DiGi.Core.Enums.md#DiGi.Core.Enums.DataType 'DiGi\.Core\.Enums\.DataType')

The DataType to check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the DataType is numeric; otherwise, false\.

<a name='DiGi.Core.Query.IsNumeric(thisDiGi.Core.Enums.DataType,bool)'></a>

## Query\.IsNumeric\(this DataType, bool\) Method

Determines whether the specified DataType represents a numeric type and checks if it's an integer\.

```csharp
public static bool IsNumeric(this DiGi.Core.Enums.DataType dataType, out bool isInteger);
```
#### Parameters

<a name='DiGi.Core.Query.IsNumeric(thisDiGi.Core.Enums.DataType,bool).dataType'></a>

`dataType` [DataType](DiGi.Core.Enums.md#DiGi.Core.Enums.DataType 'DiGi\.Core\.Enums\.DataType')

The DataType to check\.

<a name='DiGi.Core.Query.IsNumeric(thisDiGi.Core.Enums.DataType,bool).isInteger'></a>

`isInteger` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Out parameter indicating whether the numeric type is an integer\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the DataType is numeric; otherwise, false\.

<a name='DiGi.Core.Query.IsNumeric(thisobject)'></a>

## Query\.IsNumeric\(this object\) Method

Determines whether the specified object represents a numeric type\.

```csharp
public static bool IsNumeric(this object? @object);
```
#### Parameters

<a name='DiGi.Core.Query.IsNumeric(thisobject).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object is numeric; otherwise, false\.

<a name='DiGi.Core.Query.IsNumeric(thisobject,bool)'></a>

## Query\.IsNumeric\(this object, bool\) Method

Determines whether the specified object represents a numeric type and checks if it's an integer\.

```csharp
public static bool IsNumeric(this object? @object, out bool isInteger);
```
#### Parameters

<a name='DiGi.Core.Query.IsNumeric(thisobject,bool).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to check\.

<a name='DiGi.Core.Query.IsNumeric(thisobject,bool).isInteger'></a>

`isInteger` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Out parameter indicating whether the numeric type is an integer\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object is numeric; otherwise, false\.

<a name='DiGi.Core.Query.IsNumeric(thisSystem.Type)'></a>

## Query\.IsNumeric\(this Type\) Method

Determines whether the specified Type represents a numeric type\.

```csharp
public static bool IsNumeric(this System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Query.IsNumeric(thisSystem.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the type is numeric; otherwise, false\.

<a name='DiGi.Core.Query.IsNumeric(thisSystem.Type,bool)'></a>

## Query\.IsNumeric\(this Type, bool\) Method

Determines whether the specified Type represents a numeric type and checks if it's an integer\.

```csharp
public static bool IsNumeric(this System.Type? type, out bool isInteger);
```
#### Parameters

<a name='DiGi.Core.Query.IsNumeric(thisSystem.Type,bool).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to check\.

<a name='DiGi.Core.Query.IsNumeric(thisSystem.Type,bool).isInteger'></a>

`isInteger` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Out parameter indicating whether the numeric type is an integer\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the type is numeric; otherwise, false\.

<a name='DiGi.Core.Query.IsSeparator(thisstring,int)'></a>

## Query\.IsSeparator\(this string, int\) Method

Determines whether an unescaped [Separator](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.Separator 'DiGi\.Core\.Constants\.Reference\.Separator') starts at the specified index\.

The caller is responsible for having consumed any escape sequences before this index, so the
            character at [index](DiGi.Core.md#DiGi.Core.Query.IsSeparator(thisstring,int).index 'DiGi\.Core\.Query\.IsSeparator\(this string, int\)\.index') is known to be unescaped.

```csharp
public static bool IsSeparator(this string? value, int index);
```
#### Parameters

<a name='DiGi.Core.Query.IsSeparator(thisstring,int).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string to inspect\.

<a name='DiGi.Core.Query.IsSeparator(thisstring,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index to test\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the separator starts at the specified index; otherwise, false\.

<a name='DiGi.Core.Query.JsonValueKind(thisobject)'></a>

## Query\.JsonValueKind\(this object\) Method

Determines the JsonValueKind of a given object\.

```csharp
public static System.Text.Json.JsonValueKind JsonValueKind(this object value);
```
#### Parameters

<a name='DiGi.Core.Query.JsonValueKind(thisobject).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to evaluate\.

#### Returns
[System\.Text\.Json\.JsonValueKind](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonvaluekind 'System\.Text\.Json\.JsonValueKind')  
The corresponding JsonValueKind\.

<a name='DiGi.Core.Query.Lerp(thisSystem.Drawing.Color,System.Drawing.Color,double)'></a>

## Query\.Lerp\(this Color, Color, double\) Method

Linearly interpolates between color\_1 and color\_2 by value
Source: http://www\.java2s\.com/example/csharp/system\.drawing/lerp\-between\-two\-color\.html

```csharp
public static System.Drawing.Color Lerp(this System.Drawing.Color color_1, System.Drawing.Color color_2, double value);
```
#### Parameters

<a name='DiGi.Core.Query.Lerp(thisSystem.Drawing.Color,System.Drawing.Color,double).color_1'></a>

`color_1` [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')

Start Color

<a name='DiGi.Core.Query.Lerp(thisSystem.Drawing.Color,System.Drawing.Color,double).color_2'></a>

`color_2` [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')

End Color

<a name='DiGi.Core.Query.Lerp(thisSystem.Drawing.Color,System.Drawing.Color,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Lerp value \(0\-1\)

#### Returns
[System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')  
Lerp Color

<a name='DiGi.Core.Query.Lerps(thisSystem.Drawing.Color,System.Drawing.Color,int)'></a>

## Query\.Lerps\(this Color, Color, int\) Method

Creates list of colors being linearly interpolated between color\_1 and color\_2 by value

```csharp
public static System.Collections.Generic.List<System.Drawing.Color>? Lerps(this System.Drawing.Color color_1, System.Drawing.Color color_2, int count);
```
#### Parameters

<a name='DiGi.Core.Query.Lerps(thisSystem.Drawing.Color,System.Drawing.Color,int).color_1'></a>

`color_1` [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')

Start Color

<a name='DiGi.Core.Query.Lerps(thisSystem.Drawing.Color,System.Drawing.Color,int).color_2'></a>

`color_2` [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')

End Color

<a name='DiGi.Core.Query.Lerps(thisSystem.Drawing.Color,System.Drawing.Color,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

Number of colors

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
Lerped Colors

<a name='DiGi.Core.Query.Next(thisint,int)'></a>

## Query\.Next\(this int, int\) Method

Calculates the next index in a circular collection\.

```csharp
public static int Next(this int count, int index);
```
#### Parameters

<a name='DiGi.Core.Query.Next(thisint,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The total number of elements\.

<a name='DiGi.Core.Query.Next(thisint,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The current index\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The next index, or \-1 if invalid\.

<a name='DiGi.Core.Query.Next_T_(thisSystem.Collections.Generic.IEnumerable_T_,int)'></a>

## Query\.Next\<T\>\(this IEnumerable\<T\>, int\) Method

Gets the next element in a sequence, wrapping around if necessary\.

```csharp
public static T? Next<T>(this System.Collections.Generic.IEnumerable<T?>? values, int index);
```
#### Type parameters

<a name='DiGi.Core.Query.Next_T_(thisSystem.Collections.Generic.IEnumerable_T_,int).T'></a>

`T`

The type of elements in the sequence\.
#### Parameters

<a name='DiGi.Core.Query.Next_T_(thisSystem.Collections.Generic.IEnumerable_T_,int).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.md#DiGi.Core.Query.Next_T_(thisSystem.Collections.Generic.IEnumerable_T_,int).T 'DiGi\.Core\.Query\.Next\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, int\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sequence to search\.

<a name='DiGi.Core.Query.Next_T_(thisSystem.Collections.Generic.IEnumerable_T_,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The current index\.

#### Returns
[T](DiGi.Core.md#DiGi.Core.Query.Next_T_(thisSystem.Collections.Generic.IEnumerable_T_,int).T 'DiGi\.Core\.Query\.Next\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, int\)\.T')  
The next element, or default if the sequence is null or empty\.

<a name='DiGi.Core.Query.Next_TEnum_(TEnum)'></a>

## Query\.Next\<TEnum\>\(TEnum\) Method

Gets the next value in an enum, wrapping around to the first if it's the last\.

```csharp
public static TEnum? Next<TEnum>(TEnum? @enum)
    where TEnum : System.Enum;
```
#### Type parameters

<a name='DiGi.Core.Query.Next_TEnum_(TEnum).TEnum'></a>

`TEnum`

The enum type\.
#### Parameters

<a name='DiGi.Core.Query.Next_TEnum_(TEnum).enum'></a>

`enum` [TEnum](DiGi.Core.md#DiGi.Core.Query.Next_TEnum_(TEnum).TEnum 'DiGi\.Core\.Query\.Next\<TEnum\>\(TEnum\)\.TEnum')

The current enum value\.

#### Returns
[TEnum](DiGi.Core.md#DiGi.Core.Query.Next_TEnum_(TEnum).TEnum 'DiGi\.Core\.Query\.Next\<TEnum\>\(TEnum\)\.TEnum')  
The next enum value\.

<a name='DiGi.Core.Query.Opposite(thisDiGi.Core.Enums.NumberComparisonType)'></a>

## Query\.Opposite\(this NumberComparisonType\) Method

Gets the opposite of the specified [NumberComparisonType](DiGi.Core.Enums.md#DiGi.Core.Enums.NumberComparisonType 'DiGi\.Core\.Enums\.NumberComparisonType')\.

```csharp
public static DiGi.Core.Enums.NumberComparisonType Opposite(this DiGi.Core.Enums.NumberComparisonType numberComparisonType);
```
#### Parameters

<a name='DiGi.Core.Query.Opposite(thisDiGi.Core.Enums.NumberComparisonType).numberComparisonType'></a>

`numberComparisonType` [NumberComparisonType](DiGi.Core.Enums.md#DiGi.Core.Enums.NumberComparisonType 'DiGi\.Core\.Enums\.NumberComparisonType')

The number comparison type\.

#### Returns
[NumberComparisonType](DiGi.Core.Enums.md#DiGi.Core.Enums.NumberComparisonType 'DiGi\.Core\.Enums\.NumberComparisonType')  
The opposite [NumberComparisonType](DiGi.Core.Enums.md#DiGi.Core.Enums.NumberComparisonType 'DiGi\.Core\.Enums\.NumberComparisonType')\.

<a name='DiGi.Core.Query.Opposite(thisDiGi.Core.Enums.TextComparisonType)'></a>

## Query\.Opposite\(this TextComparisonType\) Method

Gets the opposite of the specified [TextComparisonType](DiGi.Core.Enums.md#DiGi.Core.Enums.TextComparisonType 'DiGi\.Core\.Enums\.TextComparisonType')\.

```csharp
public static DiGi.Core.Enums.TextComparisonType Opposite(this DiGi.Core.Enums.TextComparisonType textComparisonType);
```
#### Parameters

<a name='DiGi.Core.Query.Opposite(thisDiGi.Core.Enums.TextComparisonType).textComparisonType'></a>

`textComparisonType` [TextComparisonType](DiGi.Core.Enums.md#DiGi.Core.Enums.TextComparisonType 'DiGi\.Core\.Enums\.TextComparisonType')

The text comparison type\.

#### Returns
[TextComparisonType](DiGi.Core.Enums.md#DiGi.Core.Enums.TextComparisonType 'DiGi\.Core\.Enums\.TextComparisonType')  
The opposite [TextComparisonType](DiGi.Core.Enums.md#DiGi.Core.Enums.TextComparisonType 'DiGi\.Core\.Enums\.TextComparisonType')\.

<a name='DiGi.Core.Query.Previous(thisint,int)'></a>

## Query\.Previous\(this int, int\) Method

Calculates the previous index in a circular collection\.

```csharp
public static int Previous(this int count, int index);
```
#### Parameters

<a name='DiGi.Core.Query.Previous(thisint,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The total number of elements\.

<a name='DiGi.Core.Query.Previous(thisint,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The current index\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The previous index, or \-1 if invalid\.

<a name='DiGi.Core.Query.Previous_T_(thisSystem.Collections.Generic.IEnumerable_T_,int)'></a>

## Query\.Previous\<T\>\(this IEnumerable\<T\>, int\) Method

Gets the previous element in a sequence, wrapping around if necessary\.

```csharp
public static T? Previous<T>(this System.Collections.Generic.IEnumerable<T?>? values, int index);
```
#### Type parameters

<a name='DiGi.Core.Query.Previous_T_(thisSystem.Collections.Generic.IEnumerable_T_,int).T'></a>

`T`

The type of elements in the sequence\.
#### Parameters

<a name='DiGi.Core.Query.Previous_T_(thisSystem.Collections.Generic.IEnumerable_T_,int).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.md#DiGi.Core.Query.Previous_T_(thisSystem.Collections.Generic.IEnumerable_T_,int).T 'DiGi\.Core\.Query\.Previous\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, int\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sequence to search\.

<a name='DiGi.Core.Query.Previous_T_(thisSystem.Collections.Generic.IEnumerable_T_,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The current index\.

#### Returns
[T](DiGi.Core.md#DiGi.Core.Query.Previous_T_(thisSystem.Collections.Generic.IEnumerable_T_,int).T 'DiGi\.Core\.Query\.Previous\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, int\)\.T')  
The previous element, or default if the sequence is null or empty\.

<a name='DiGi.Core.Query.Previous_TENum_(TENum)'></a>

## Query\.Previous\<TENum\>\(TENum\) Method

Gets the previous value in an enum, wrapping around to the last if it's the first\.

```csharp
public static TENum? Previous<TENum>(TENum? @enum)
    where TENum : System.Enum;
```
#### Type parameters

<a name='DiGi.Core.Query.Previous_TENum_(TENum).TENum'></a>

`TENum`

The enum type\.
#### Parameters

<a name='DiGi.Core.Query.Previous_TENum_(TENum).enum'></a>

`enum` [TENum](DiGi.Core.md#DiGi.Core.Query.Previous_TENum_(TENum).TENum 'DiGi\.Core\.Query\.Previous\<TENum\>\(TENum\)\.TENum')

The current enum value\.

#### Returns
[TENum](DiGi.Core.md#DiGi.Core.Query.Previous_TENum_(TENum).TENum 'DiGi\.Core\.Query\.Previous\<TENum\>\(TENum\)\.TENum')  
The previous enum value\.

<a name='DiGi.Core.Query.ProcessorCount(double)'></a>

## Query\.ProcessorCount\(double\) Method

Gets the calculated processor count based on a specified fraction\.

```csharp
public static int ProcessorCount(double fraction=1.0);
```
#### Parameters

<a name='DiGi.Core.Query.ProcessorCount(double).fraction'></a>

`fraction` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The fraction of total processors to use\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The calculated number of processors\.

<a name='DiGi.Core.Query.QuotedStrings(string,string)'></a>

## Query\.QuotedStrings\(string, string\) Method

Splits a string by a separator, respecting quoted sections\.

```csharp
public static System.Collections.Generic.List<string>? QuotedStrings(string? text, string separator=",");
```
#### Parameters

<a name='DiGi.Core.Query.QuotedStrings(string,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The text to split\.

<a name='DiGi.Core.Query.QuotedStrings(string,string).separator'></a>

`separator` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The separator string\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of extracted strings\.

<a name='DiGi.Core.Query.Random(DiGi.Core.Classes.Range_double_,int,double)'></a>

## Query\.Random\(Range\<double\>, int, double\) Method

Generates a random double within a Range struct using a seed\.

```csharp
public static double Random(DiGi.Core.Classes.Range<double>? range, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Core.Query.Random(DiGi.Core.Classes.Range_double_,int,double).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range\.

<a name='DiGi.Core.Query.Random(DiGi.Core.Classes.Range_double_,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The seed\.

<a name='DiGi.Core.Query.Random(DiGi.Core.Classes.Range_double_,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A random double\.

<a name='DiGi.Core.Query.Random(DiGi.Core.Classes.Range_int_,int)'></a>

## Query\.Random\(Range\<int\>, int\) Method

Generates a random integer within a Range struct using a seed\.

```csharp
public static int Random(DiGi.Core.Classes.Range<int>? range, int seed=-1);
```
#### Parameters

<a name='DiGi.Core.Query.Random(DiGi.Core.Classes.Range_int_,int).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range\.

<a name='DiGi.Core.Query.Random(DiGi.Core.Classes.Range_int_,int).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The seed\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A random integer\.

<a name='DiGi.Core.Query.Random(double,double,int,double)'></a>

## Query\.Random\(double, double, int, double\) Method

Generates a random double using a seed\.

```csharp
public static double Random(double start, double end, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Core.Query.Random(double,double,int,double).start'></a>

`start` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The start value\.

<a name='DiGi.Core.Query.Random(double,double,int,double).end'></a>

`end` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The end value\.

<a name='DiGi.Core.Query.Random(double,double,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The seed\.

<a name='DiGi.Core.Query.Random(double,double,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A random double\.

<a name='DiGi.Core.Query.Random(int)'></a>

## Query\.Random\(int\) Method

Generates a random boolean using a seed\.

```csharp
public static bool Random(int seed=-1);
```
#### Parameters

<a name='DiGi.Core.Query.Random(int).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The seed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A random boolean\.

<a name='DiGi.Core.Query.Random(int,int,int)'></a>

## Query\.Random\(int, int, int\) Method

Generates a random integer within a range using a seed\.

```csharp
public static int Random(int start, int end, int seed=-1);
```
#### Parameters

<a name='DiGi.Core.Query.Random(int,int,int).start'></a>

`start` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The start value\.

<a name='DiGi.Core.Query.Random(int,int,int).end'></a>

`end` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The end value\.

<a name='DiGi.Core.Query.Random(int,int,int).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The seed\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A random integer\.

<a name='DiGi.Core.Query.Random(System.Random)'></a>

## Query\.Random\(Random\) Method

Generates a random boolean\.

```csharp
public static bool Random(System.Random? random);
```
#### Parameters

<a name='DiGi.Core.Query.Random(System.Random).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The Random instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
A random boolean\.

<a name='DiGi.Core.Query.Random(System.Random,DiGi.Core.Classes.Range_double_,double)'></a>

## Query\.Random\(Random, Range\<double\>, double\) Method

Generates a random double within a Range struct\.

```csharp
public static double Random(System.Random? random, DiGi.Core.Classes.Range<double>? range, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Core.Query.Random(System.Random,DiGi.Core.Classes.Range_double_,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The Random instance\.

<a name='DiGi.Core.Query.Random(System.Random,DiGi.Core.Classes.Range_double_,double).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range\.

<a name='DiGi.Core.Query.Random(System.Random,DiGi.Core.Classes.Range_double_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A random double\.

<a name='DiGi.Core.Query.Random(System.Random,DiGi.Core.Classes.Range_int_)'></a>

## Query\.Random\(Random, Range\<int\>\) Method

Generates a random integer within a Range struct\.

```csharp
public static int Random(System.Random? random, DiGi.Core.Classes.Range<int>? range);
```
#### Parameters

<a name='DiGi.Core.Query.Random(System.Random,DiGi.Core.Classes.Range_int_).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The Random instance\.

<a name='DiGi.Core.Query.Random(System.Random,DiGi.Core.Classes.Range_int_).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A random integer\.

<a name='DiGi.Core.Query.Random(System.Random,double,double,double)'></a>

## Query\.Random\(Random, double, double, double\) Method

Generates a random double within a range\.

```csharp
public static double Random(System.Random? random, double start, double end, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Core.Query.Random(System.Random,double,double,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The Random instance\.

<a name='DiGi.Core.Query.Random(System.Random,double,double,double).start'></a>

`start` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The start value\.

<a name='DiGi.Core.Query.Random(System.Random,double,double,double).end'></a>

`end` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The end value\.

<a name='DiGi.Core.Query.Random(System.Random,double,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
A random double\.

<a name='DiGi.Core.Query.Random(System.Random,int,int)'></a>

## Query\.Random\(Random, int, int\) Method

Generates a random integer within a range\.

```csharp
public static int Random(System.Random? random, int start, int end);
```
#### Parameters

<a name='DiGi.Core.Query.Random(System.Random,int,int).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The Random instance\.

<a name='DiGi.Core.Query.Random(System.Random,int,int).start'></a>

`start` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The start value\.

<a name='DiGi.Core.Query.Random(System.Random,int,int).end'></a>

`end` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The end value\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A random integer\.

<a name='DiGi.Core.Query.Randoms(int,DiGi.Core.Classes.Range_double_,int,double)'></a>

## Query\.Randoms\(int, Range\<double\>, int, double\) Method

Generates a list of random doubles within a specified Range using an optional seed\.

```csharp
public static System.Collections.Generic.List<double>? Randoms(int count, DiGi.Core.Classes.Range<double>? range, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Core.Query.Randoms(int,DiGi.Core.Classes.Range_double_,int,double).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of random doubles to generate\.

<a name='DiGi.Core.Query.Randoms(int,DiGi.Core.Classes.Range_double_,int,double).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range from which the random doubles are generated\.

<a name='DiGi.Core.Query.Randoms(int,DiGi.Core.Classes.Range_double_,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An optional seed for the random number generator\.

<a name='DiGi.Core.Query.Randoms(int,DiGi.Core.Classes.Range_double_,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used during generation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of random doubles, or null if generation fails\.

<a name='DiGi.Core.Query.Randoms(int,DiGi.Core.Classes.Range_int_,int)'></a>

## Query\.Randoms\(int, Range\<int\>, int\) Method

Generates a list of random integers within a specified Range using an optional seed\.

```csharp
public static System.Collections.Generic.List<int>? Randoms(int count, DiGi.Core.Classes.Range<int>? range, int seed=-1);
```
#### Parameters

<a name='DiGi.Core.Query.Randoms(int,DiGi.Core.Classes.Range_int_,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of random integers to generate\.

<a name='DiGi.Core.Query.Randoms(int,DiGi.Core.Classes.Range_int_,int).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range from which the random integers are generated\.

<a name='DiGi.Core.Query.Randoms(int,DiGi.Core.Classes.Range_int_,int).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An optional seed for the random number generator\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of random integers, or null if generation fails\.

<a name='DiGi.Core.Query.Randoms(int,double,double,int,double)'></a>

## Query\.Randoms\(int, double, double, int, double\) Method

Generates a list of random doubles within a specified range using an optional seed\.

```csharp
public static System.Collections.Generic.List<double>? Randoms(int count, double start, double end, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Core.Query.Randoms(int,double,double,int,double).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of random doubles to generate\.

<a name='DiGi.Core.Query.Randoms(int,double,double,int,double).start'></a>

`start` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The start value of the range\.

<a name='DiGi.Core.Query.Randoms(int,double,double,int,double).end'></a>

`end` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The end value of the range\.

<a name='DiGi.Core.Query.Randoms(int,double,double,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An optional seed for the random number generator\.

<a name='DiGi.Core.Query.Randoms(int,double,double,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used during generation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of random doubles, or null if generation fails\.

<a name='DiGi.Core.Query.Randoms(int,int)'></a>

## Query\.Randoms\(int, int\) Method

Generates a list of random booleans using an optional seed\.

```csharp
public static System.Collections.Generic.List<bool>? Randoms(int count, int seed=-1);
```
#### Parameters

<a name='DiGi.Core.Query.Randoms(int,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of random booleans to generate\.

<a name='DiGi.Core.Query.Randoms(int,int).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The seed for the random number generator\. Defaults to \-1\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of random booleans, or null if generation fails\.

<a name='DiGi.Core.Query.Randoms(int,int,int,int)'></a>

## Query\.Randoms\(int, int, int, int\) Method

Generates a list of random integers within a specified range using an optional seed\.

```csharp
public static System.Collections.Generic.List<int>? Randoms(int count, int start, int end, int seed=-1);
```
#### Parameters

<a name='DiGi.Core.Query.Randoms(int,int,int,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of random integers to generate\.

<a name='DiGi.Core.Query.Randoms(int,int,int,int).start'></a>

`start` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The inclusive lower bound of the range\.

<a name='DiGi.Core.Query.Randoms(int,int,int,int).end'></a>

`end` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The exclusive upper bound of the range\.

<a name='DiGi.Core.Query.Randoms(int,int,int,int).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The seed for the random number generator\. Defaults to \-1\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of random integers, or null if generation fails\.

<a name='DiGi.Core.Query.Randoms(int,System.Random)'></a>

## Query\.Randoms\(int, Random\) Method

Generates a list of random booleans using a provided Random instance\.

```csharp
public static System.Collections.Generic.List<bool>? Randoms(int count, System.Random? random);
```
#### Parameters

<a name='DiGi.Core.Query.Randoms(int,System.Random).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of random booleans to generate\.

<a name='DiGi.Core.Query.Randoms(int,System.Random).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The Random instance used to generate the values\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of random booleans, or null if generation fails\.

<a name='DiGi.Core.Query.Randoms(int,System.Random,DiGi.Core.Classes.Range_double_,double)'></a>

## Query\.Randoms\(int, Random, Range\<double\>, double\) Method

Generates a list of random doubles within a specified Range using a provided Random instance\.

```csharp
public static System.Collections.Generic.List<double>? Randoms(int count, System.Random? random, DiGi.Core.Classes.Range<double>? range, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Core.Query.Randoms(int,System.Random,DiGi.Core.Classes.Range_double_,double).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of random doubles to generate\.

<a name='DiGi.Core.Query.Randoms(int,System.Random,DiGi.Core.Classes.Range_double_,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The Random instance to use for generation\.

<a name='DiGi.Core.Query.Randoms(int,System.Random,DiGi.Core.Classes.Range_double_,double).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range from which the random doubles are generated\.

<a name='DiGi.Core.Query.Randoms(int,System.Random,DiGi.Core.Classes.Range_double_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used during generation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of random doubles, or null if generation fails\.

<a name='DiGi.Core.Query.Randoms(int,System.Random,DiGi.Core.Classes.Range_int_)'></a>

## Query\.Randoms\(int, Random, Range\<int\>\) Method

Generates a list of random integers within a specified Range using a provided Random instance\.

```csharp
public static System.Collections.Generic.List<int>? Randoms(int count, System.Random? random, DiGi.Core.Classes.Range<int>? range);
```
#### Parameters

<a name='DiGi.Core.Query.Randoms(int,System.Random,DiGi.Core.Classes.Range_int_).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of random integers to generate\.

<a name='DiGi.Core.Query.Randoms(int,System.Random,DiGi.Core.Classes.Range_int_).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The Random instance used to generate the values\.

<a name='DiGi.Core.Query.Randoms(int,System.Random,DiGi.Core.Classes.Range_int_).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range within which the random integers should be generated\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of random integers, or null if generation fails\.

<a name='DiGi.Core.Query.Randoms(int,System.Random,double,double,double)'></a>

## Query\.Randoms\(int, Random, double, double, double\) Method

Generates a list of random doubles within a specified range using a provided Random instance\.

```csharp
public static System.Collections.Generic.List<double>? Randoms(int count, System.Random? random, double start, double end, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Core.Query.Randoms(int,System.Random,double,double,double).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of random doubles to generate\.

<a name='DiGi.Core.Query.Randoms(int,System.Random,double,double,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The Random instance to use for generation\.

<a name='DiGi.Core.Query.Randoms(int,System.Random,double,double,double).start'></a>

`start` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The start value of the range\.

<a name='DiGi.Core.Query.Randoms(int,System.Random,double,double,double).end'></a>

`end` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The end value of the range\.

<a name='DiGi.Core.Query.Randoms(int,System.Random,double,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used during generation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of random doubles, or null if generation fails\.

<a name='DiGi.Core.Query.Randoms(int,System.Random,int,int)'></a>

## Query\.Randoms\(int, Random, int, int\) Method

Generates a list of random integers within a specified range using a provided Random instance\.

```csharp
public static System.Collections.Generic.List<int>? Randoms(int count, System.Random? random, int start, int end);
```
#### Parameters

<a name='DiGi.Core.Query.Randoms(int,System.Random,int,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of random integers to generate\.

<a name='DiGi.Core.Query.Randoms(int,System.Random,int,int).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The Random instance used to generate the values\.

<a name='DiGi.Core.Query.Randoms(int,System.Random,int,int).start'></a>

`start` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The inclusive lower bound of the range\.

<a name='DiGi.Core.Query.Randoms(int,System.Random,int,int).end'></a>

`end` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The exclusive upper bound of the range\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of random integers, or null if generation fails\.

<a name='DiGi.Core.Query.Reference(thisstring)'></a>

## Query\.Reference\(this string\) Method

Reverses [Segment\(this IReference\)](DiGi.Core.md#DiGi.Core.Query.Segment(thisDiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.Segment\(this DiGi\.Core\.Interfaces\.IReference\)'), turning a nested segment back into a reference by stripping
one nesting layer and parsing the content\.

```csharp
public static DiGi.Core.Interfaces.IReference? Reference(this string? segment);
```
#### Parameters

<a name='DiGi.Core.Query.Reference(thisstring).segment'></a>

`segment` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The nested segment, including its enclosing nesting delimiters\.

#### Returns
[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')  
The reference; null when [segment](DiGi.Core.md#DiGi.Core.Query.Reference(thisstring).segment 'DiGi\.Core\.Query\.Reference\(this string\)\.segment') is null, is [Null](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.Null 'DiGi\.Core\.Constants\.Reference\.Null'),
is not a nested segment, or does not parse\.

<a name='DiGi.Core.Query.Reference_TReference_(thisstring)'></a>

## Query\.Reference\<TReference\>\(this string\) Method

Reverses [Segment\(this IReference\)](DiGi.Core.md#DiGi.Core.Query.Segment(thisDiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.Segment\(this DiGi\.Core\.Interfaces\.IReference\)') and narrows the result to the requested reference type\.

```csharp
public static TReference? Reference<TReference>(this string? segment)
    where TReference : DiGi.Core.Interfaces.IReference;
```
#### Type parameters

<a name='DiGi.Core.Query.Reference_TReference_(thisstring).TReference'></a>

`TReference`

The expected reference type\.
#### Parameters

<a name='DiGi.Core.Query.Reference_TReference_(thisstring).segment'></a>

`segment` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The nested segment, including its enclosing nesting delimiters\.

#### Returns
[TReference](DiGi.Core.md#DiGi.Core.Query.Reference_TReference_(thisstring).TReference 'DiGi\.Core\.Query\.Reference\<TReference\>\(this string\)\.TReference')  
The reference when it parses and is of the requested type; otherwise, the default value\.

<a name='DiGi.Core.Query.Round(thisdouble,double)'></a>

## Query\.Round\(this double, double\) Method

Rounds the value to the nearest multiple of the tolerance using decimal precision\.
This prevents floating\-point artifacts common in double arithmetic\.

```csharp
public static double Round(this double value, double tolerance);
```
#### Parameters

<a name='DiGi.Core.Query.Round(thisdouble,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value to be rounded\.

<a name='DiGi.Core.Query.Round(thisdouble,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for rounding\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The rounded value\.

<a name='DiGi.Core.Query.Seeds(thisint,int)'></a>

## Query\.Seeds\(this int, int\) Method

Generates a sequence of seeds\.

```csharp
public static System.Collections.Generic.List<int> Seeds(this int count, int seed=-1);
```
#### Parameters

<a name='DiGi.Core.Query.Seeds(thisint,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of seeds to generate\.

<a name='DiGi.Core.Query.Seeds(thisint,int).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The starting seed value\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of integers representing the seeds\.

<a name='DiGi.Core.Query.Segment(thisDiGi.Core.Interfaces.IReference)'></a>

## Query\.Segment\(this IReference\) Method

Renders a nested reference as a segment of a reference string, wrapped in the nesting delimiters so that
the segment stays self\-contained and the enclosing string can be split without knowing the nested type\.

```csharp
public static string Segment(this DiGi.Core.Interfaces.IReference? reference);
```
#### Parameters

<a name='DiGi.Core.Query.Segment(thisDiGi.Core.Interfaces.IReference).reference'></a>

`reference` [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')

The reference to nest\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The nested segment, [Null](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.Null 'DiGi\.Core\.Constants\.Reference\.Null') when [reference](DiGi.Core.md#DiGi.Core.Query.Segment(thisDiGi.Core.Interfaces.IReference).reference 'DiGi\.Core\.Query\.Segment\(this DiGi\.Core\.Interfaces\.IReference\)\.reference') is null, or
when the reference renders to null\.

<a name='DiGi.Core.Query.Segment(thisstring)'></a>

## Query\.Segment\(this string\) Method

Renders a scalar value as a segment of a reference string\.

```csharp
public static string Segment(this string? value);
```
#### Parameters

<a name='DiGi.Core.Query.Segment(thisstring).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The scalar value\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The escaped segment, or [Null](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.Null 'DiGi\.Core\.Constants\.Reference\.Null') when [value](DiGi.Core.md#DiGi.Core.Query.Segment(thisstring).value 'DiGi\.Core\.Query\.Segment\(this string\)\.value') is null\.

<a name='DiGi.Core.Query.Segments(thisstring)'></a>

## Query\.Segments\(this string\) Method

Splits the body of a reference string \- everything after the discriminator \- into its segments\.

Splits only on an unescaped [Separator](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.Separator 'DiGi\.Core\.Constants\.Reference\.Separator') at nesting depth zero, so a
            separator inside an escaped payload or inside a nested reference never splits. Empty segments are
            preserved: an empty segment means [System\.String\.Empty](https://learn.microsoft.com/en-us/dotnet/api/system.string.empty 'System\.String\.Empty') and is distinct from
            [Null](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.Null 'DiGi\.Core\.Constants\.Reference\.Null').

```csharp
public static System.Collections.Generic.List<string>? Segments(this string? body);
```
#### Parameters

<a name='DiGi.Core.Query.Segments(thisstring).body'></a>

`body` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The body of a reference string\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
The segments in order; null when [body](DiGi.Core.md#DiGi.Core.Query.Segments(thisstring).body 'DiGi\.Core\.Query\.Segments\(this string\)\.body') is null or malformed \- unbalanced nesting
delimiters, or a trailing lone escape character\.

<a name='DiGi.Core.Query.SerializableMemberInfos(thisSystem.Type)'></a>

## Query\.SerializableMemberInfos\(this Type\) Method

Retrieves the properties and fields of a type that are marked for serialization\.

```csharp
public static System.Collections.Generic.List<System.Reflection.MemberInfo>? SerializableMemberInfos(this System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Query.SerializableMemberInfos(thisSystem.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to reflect on\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Reflection\.MemberInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.memberinfo 'System\.Reflection\.MemberInfo')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of serializable MemberInfo objects\.

<a name='DiGi.Core.Query.SerializableName(thisSystem.Reflection.MemberInfo)'></a>

## Query\.SerializableName\(this MemberInfo\) Method

Gets the serializable name \(e\.g\. from JsonPropertyNameAttribute\) for a MemberInfo\.

```csharp
public static string? SerializableName(this System.Reflection.MemberInfo? memberInfo);
```
#### Parameters

<a name='DiGi.Core.Query.SerializableName(thisSystem.Reflection.MemberInfo).memberInfo'></a>

`memberInfo` [System\.Reflection\.MemberInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.memberinfo 'System\.Reflection\.MemberInfo')

The MemberInfo\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The serializable name\.

<a name='DiGi.Core.Query.SerializableOrder(thisSystem.Reflection.MemberInfo)'></a>

## Query\.SerializableOrder\(this MemberInfo\) Method

Gets the serialization order of the specified member, as defined by the [System\.Text\.Json\.Serialization\.JsonPropertyOrderAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonpropertyorderattribute 'System\.Text\.Json\.Serialization\.JsonPropertyOrderAttribute')\.

```csharp
public static System.Nullable<int> SerializableOrder(this System.Reflection.MemberInfo? memberInfo);
```
#### Parameters

<a name='DiGi.Core.Query.SerializableOrder(thisSystem.Reflection.MemberInfo).memberInfo'></a>

`memberInfo` [System\.Reflection\.MemberInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.memberinfo 'System\.Reflection\.MemberInfo')

The member to evaluate\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The serialization order if the attribute is present; otherwise, null\.

<a name='DiGi.Core.Query.Split_X_(thisSystem.Collections.Generic.IEnumerable_X_,int)'></a>

## Query\.Split\<X\>\(this IEnumerable\<X\>, int\) Method

Splits a sequence into a list of smaller lists, each containing at most [maxCount](DiGi.Core.md#DiGi.Core.Query.Split_X_(thisSystem.Collections.Generic.IEnumerable_X_,int).maxCount 'DiGi\.Core\.Query\.Split\<X\>\(this System\.Collections\.Generic\.IEnumerable\<X\>, int\)\.maxCount') elements\.

```csharp
public static System.Collections.Generic.List<System.Collections.Generic.List<X>>? Split<X>(this System.Collections.Generic.IEnumerable<X>? values, int maxCount);
```
#### Type parameters

<a name='DiGi.Core.Query.Split_X_(thisSystem.Collections.Generic.IEnumerable_X_,int).X'></a>

`X`

The type of elements in the sequence\.
#### Parameters

<a name='DiGi.Core.Query.Split_X_(thisSystem.Collections.Generic.IEnumerable_X_,int).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[X](DiGi.Core.md#DiGi.Core.Query.Split_X_(thisSystem.Collections.Generic.IEnumerable_X_,int).X 'DiGi\.Core\.Query\.Split\<X\>\(this System\.Collections\.Generic\.IEnumerable\<X\>, int\)\.X')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sequence to split\.

<a name='DiGi.Core.Query.Split_X_(thisSystem.Collections.Generic.IEnumerable_X_,int).maxCount'></a>

`maxCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of elements per chunk\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[X](DiGi.Core.md#DiGi.Core.Query.Split_X_(thisSystem.Collections.Generic.IEnumerable_X_,int).X 'DiGi\.Core\.Query\.Split\<X\>\(this System\.Collections\.Generic\.IEnumerable\<X\>, int\)\.X')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of lists, or null if the input is null or maxCount is less than 1\.

<a name='DiGi.Core.Query.TimeOffset(thisDiGi.Core.Enums.UTC)'></a>

## Query\.TimeOffset\(this UTC\) Method

Converts a [UTC](DiGi.Core.Enums.md#DiGi.Core.Enums.UTC 'DiGi\.Core\.Enums\.UTC') enum value to its corresponding numeric hour offset from UTC\.

```csharp
public static double TimeOffset(this DiGi.Core.Enums.UTC uTC);
```
#### Parameters

<a name='DiGi.Core.Query.TimeOffset(thisDiGi.Core.Enums.UTC).uTC'></a>

`uTC` [UTC](DiGi.Core.Enums.md#DiGi.Core.Enums.UTC 'DiGi\.Core\.Enums\.UTC')

The UTC timezone enum value\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The numeric hour offset \(e\.g\., 2\.0 for UTC\+2\), or NaN if undefined\.

<a name='DiGi.Core.Query.TryConvert(thisobject,object,DiGi.Core.Enums.DataType)'></a>

## Query\.TryConvert\(this object, object, DataType\) Method

Attempts to convert the specified object using a DataType enum to determine the target type\.

```csharp
public static bool TryConvert(this object? @object, out object? result, DiGi.Core.Enums.DataType dataType);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert(thisobject,object,DiGi.Core.Enums.DataType).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert(thisobject,object,DiGi.Core.Enums.DataType).result'></a>

`result` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the converted object, or null if conversion failed\.

<a name='DiGi.Core.Query.TryConvert(thisobject,object,DiGi.Core.Enums.DataType).dataType'></a>

`dataType` [DataType](DiGi.Core.Enums.md#DiGi.Core.Enums.DataType 'DiGi\.Core\.Enums\.DataType')

The DataType enum value indicating the target type\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert(thisobject,object,System.Type)'></a>

## Query\.TryConvert\(this object, object, Type\) Method

Attempts to convert the specified object to the target type\.

```csharp
public static bool TryConvert(this object? @object, out object? result, System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert(thisobject,object,System.Type).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert(thisobject,object,System.Type).result'></a>

`result` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the converted object, or null if conversion failed\.

<a name='DiGi.Core.Query.TryConvert(thisobject,object,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The target type to convert to\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert(thisSystem.Text.Json.JsonElement,object,System.Type)'></a>

## Query\.TryConvert\(this JsonElement, object, Type\) Method

Attempts to convert a [System\.Text\.Json\.JsonElement](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonelement 'System\.Text\.Json\.JsonElement') to the specified target type\.

```csharp
public static bool TryConvert(this System.Text.Json.JsonElement jsonElement, out object? result, System.Type type);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert(thisSystem.Text.Json.JsonElement,object,System.Type).jsonElement'></a>

`jsonElement` [System\.Text\.Json\.JsonElement](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonelement 'System\.Text\.Json\.JsonElement')

The JsonElement to convert\.

<a name='DiGi.Core.Query.TryConvert(thisSystem.Text.Json.JsonElement,object,System.Type).result'></a>

`result` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the converted object, or null if conversion failed\.

<a name='DiGi.Core.Query.TryConvert(thisSystem.Text.Json.JsonElement,object,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The target type to convert to\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_T_(thisobject,T)'></a>

## Query\.TryConvert\<T\>\(this object, T\) Method

Attempts to convert the specified object to the target type [T](DiGi.Core.md#DiGi.Core.Query.TryConvert_T_(thisobject,T).T 'DiGi\.Core\.Query\.TryConvert\<T\>\(this object, T\)\.T')\.

```csharp
public static bool TryConvert<T>(this object? @object, out T? result);
```
#### Type parameters

<a name='DiGi.Core.Query.TryConvert_T_(thisobject,T).T'></a>

`T`

The target type to convert to\.
#### Parameters

<a name='DiGi.Core.Query.TryConvert_T_(thisobject,T).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_T_(thisobject,T).result'></a>

`result` [T](DiGi.Core.md#DiGi.Core.Query.TryConvert_T_(thisobject,T).T 'DiGi\.Core\.Query\.TryConvert\<T\>\(this object, T\)\.T')

When this method returns, contains the converted value, or default if conversion failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_Boolean(object,System.Nullable_bool_)'></a>

## Query\.TryConvert\_Boolean\(object, Nullable\<bool\>\) Method

Attempts to convert the specified object to a nullable boolean\.

```csharp
public static bool TryConvert_Boolean(object @object, out System.Nullable<bool> result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_Boolean(object,System.Nullable_bool_).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_Boolean(object,System.Nullable_bool_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted bool, or null if conversion failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_Byte(object,System.Nullable_byte_)'></a>

## Query\.TryConvert\_Byte\(object, Nullable\<byte\>\) Method

Attempts to convert the specified object to a nullable byte\.

```csharp
public static bool TryConvert_Byte(object @object, out System.Nullable<byte> result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_Byte(object,System.Nullable_byte_).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_Byte(object,System.Nullable_byte_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted byte, or null if conversion failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_Char(object,System.Nullable_char_)'></a>

## Query\.TryConvert\_Char\(object, Nullable\<char\>\) Method

Attempts to convert the specified object to a nullable char\.

```csharp
public static bool TryConvert_Char(object @object, out System.Nullable<char> result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_Char(object,System.Nullable_char_).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_Char(object,System.Nullable_char_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted char value if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_Color(object,System.Nullable_System.Drawing.Color_)'></a>

## Query\.TryConvert\_Color\(object, Nullable\<Color\>\) Method

Attempts to convert the specified object to a nullable [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')\.

```csharp
public static bool TryConvert_Color(object @object, out System.Nullable<System.Drawing.Color> result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_Color(object,System.Nullable_System.Drawing.Color_).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_Color(object,System.Nullable_System.Drawing.Color_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted Color, or null if conversion failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_DateTime(object,System.Nullable_System.DateTime_)'></a>

## Query\.TryConvert\_DateTime\(object, Nullable\<DateTime\>\) Method

Attempts to convert the specified object to a nullable [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')\.

```csharp
public static bool TryConvert_DateTime(object @object, out System.Nullable<System.DateTime> result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_DateTime(object,System.Nullable_System.DateTime_).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_DateTime(object,System.Nullable_System.DateTime_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted DateTime, or null if conversion failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_DateTimeOffset(object,System.Nullable_System.DateTimeOffset_)'></a>

## Query\.TryConvert\_DateTimeOffset\(object, Nullable\<DateTimeOffset\>\) Method

Attempts to convert the specified object to a nullable DateTimeOffset\.

```csharp
public static bool TryConvert_DateTimeOffset(object @object, out System.Nullable<System.DateTimeOffset> result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_DateTimeOffset(object,System.Nullable_System.DateTimeOffset_).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_DateTimeOffset(object,System.Nullable_System.DateTimeOffset_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted DateTimeOffset, or null if conversion failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_Decimal(object,System.Nullable_decimal_)'></a>

## Query\.TryConvert\_Decimal\(object, Nullable\<decimal\>\) Method

Attempts to convert the specified object to a nullable decimal\.

```csharp
public static bool TryConvert_Decimal(object @object, out System.Nullable<decimal> result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_Decimal(object,System.Nullable_decimal_).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_Decimal(object,System.Nullable_decimal_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal 'System\.Decimal')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted decimal, or null if conversion failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_Double(object,System.Nullable_double_)'></a>

## Query\.TryConvert\_Double\(object, Nullable\<double\>\) Method

Attempts to convert the specified object to a nullable double\.

```csharp
public static bool TryConvert_Double(object @object, out System.Nullable<double> result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_Double(object,System.Nullable_double_).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_Double(object,System.Nullable_double_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted double, or null if conversion failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_Enum(object,System.Enum,System.Type)'></a>

## Query\.TryConvert\_Enum\(object, Enum, Type\) Method

Attempts to convert the specified object to an Enum of the specified type\.

```csharp
public static bool TryConvert_Enum(object @object, out System.Enum? result, System.Type type);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_Enum(object,System.Enum,System.Type).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_Enum(object,System.Enum,System.Type).result'></a>

`result` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

When this method returns, contains the converted Enum, or null if conversion failed\.

<a name='DiGi.Core.Query.TryConvert_Enum(object,System.Enum,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The target enum type\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_Enumerable(object,System.Collections.IEnumerable,System.Type)'></a>

## Query\.TryConvert\_Enumerable\(object, IEnumerable, Type\) Method

Attempts to convert the specified object to an IEnumerable of the specified type\.

```csharp
public static bool TryConvert_Enumerable(object @object, out System.Collections.IEnumerable? result, System.Type type);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_Enumerable(object,System.Collections.IEnumerable,System.Type).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_Enumerable(object,System.Collections.IEnumerable,System.Type).result'></a>

`result` [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')

When this method returns, contains the converted IEnumerable, or null if conversion failed\.

<a name='DiGi.Core.Query.TryConvert_Enumerable(object,System.Collections.IEnumerable,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The target enumerable type\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_Float(object,System.Nullable_float_)'></a>

## Query\.TryConvert\_Float\(object, Nullable\<float\>\) Method

Attempts to convert the specified object to a nullable float\.

```csharp
public static bool TryConvert_Float(object @object, out System.Nullable<float> result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_Float(object,System.Nullable_float_).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_Float(object,System.Nullable_float_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted float, or null if conversion failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_Guid(object,System.Nullable_System.Guid_)'></a>

## Query\.TryConvert\_Guid\(object, Nullable\<Guid\>\) Method

Attempts to convert the specified object to a nullable [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')\.

```csharp
public static bool TryConvert_Guid(object @object, out System.Nullable<System.Guid> result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_Guid(object,System.Nullable_System.Guid_).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_Guid(object,System.Nullable_System.Guid_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted Guid, or null if conversion failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_Int(object,System.Nullable_int_)'></a>

## Query\.TryConvert\_Int\(object, Nullable\<int\>\) Method

Attempts to convert the specified object to a nullable int\.

```csharp
public static bool TryConvert_Int(object @object, out System.Nullable<int> result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_Int(object,System.Nullable_int_).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_Int(object,System.Nullable_int_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted int, or null if conversion failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_JsonNode(object,System.Text.Json.Nodes.JsonNode)'></a>

## Query\.TryConvert\_JsonNode\(object, JsonNode\) Method

Attempts to convert the specified object to a [System\.Text\.Json\.Nodes\.JsonNode](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonnode 'System\.Text\.Json\.Nodes\.JsonNode')\.

```csharp
public static bool TryConvert_JsonNode(object @object, out System.Text.Json.Nodes.JsonNode? result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_JsonNode(object,System.Text.Json.Nodes.JsonNode).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_JsonNode(object,System.Text.Json.Nodes.JsonNode).result'></a>

`result` [System\.Text\.Json\.Nodes\.JsonNode](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonnode 'System\.Text\.Json\.Nodes\.JsonNode')

When this method returns, contains the converted JsonNode, or null if conversion failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_Long(object,System.Nullable_long_)'></a>

## Query\.TryConvert\_Long\(object, Nullable\<long\>\) Method

Attempts to convert the specified object to a nullable long\.

```csharp
public static bool TryConvert_Long(object @object, out System.Nullable<long> result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_Long(object,System.Nullable_long_).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_Long(object,System.Nullable_long_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted long, or null if conversion failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_Reference(object,DiGi.Core.Interfaces.IReference,System.Type)'></a>

## Query\.TryConvert\_Reference\(object, IReference, Type\) Method

Attempts to convert the specified object to an [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference') of the specified type\.

A reference string is parsed with [TryParse\(this string, IReference\)](DiGi.Core.md#DiGi.Core.Query.TryParse(thisstring,DiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.TryParse\(this string, DiGi\.Core\.Interfaces\.IReference\)') and accepted only
            when the parsed reference is assignable to [type](DiGi.Core.md#DiGi.Core.Query.TryConvert_Reference(object,DiGi.Core.Interfaces.IReference,System.Type).type 'DiGi\.Core\.Query\.TryConvert\_Reference\(object, DiGi\.Core\.Interfaces\.IReference, System\.Type\)\.type'), so a string naming one reference kind
            does not convert to another. A non-string input, or a string that is a JSON serialization rather than a
            reference string, falls back to the [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject') path for reference types that
            support it.

```csharp
public static bool TryConvert_Reference(object @object, out DiGi.Core.Interfaces.IReference? result, System.Type type);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_Reference(object,DiGi.Core.Interfaces.IReference,System.Type).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_Reference(object,DiGi.Core.Interfaces.IReference,System.Type).result'></a>

`result` [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')

When this method returns, contains the converted reference, or null if conversion failed\.

<a name='DiGi.Core.Query.TryConvert_Reference(object,DiGi.Core.Interfaces.IReference,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The target reference type\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_Sbyte(object,System.Nullable_sbyte_)'></a>

## Query\.TryConvert\_Sbyte\(object, Nullable\<sbyte\>\) Method

Attempts to convert the specified object to a nullable sbyte\.

```csharp
public static bool TryConvert_Sbyte(object @object, out System.Nullable<sbyte> result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_Sbyte(object,System.Nullable_sbyte_).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_Sbyte(object,System.Nullable_sbyte_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.SByte](https://learn.microsoft.com/en-us/dotnet/api/system.sbyte 'System\.SByte')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted sbyte value if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_SerializableObject(object,DiGi.Core.Interfaces.ISerializableObject,System.Type)'></a>

## Query\.TryConvert\_SerializableObject\(object, ISerializableObject, Type\) Method

Attempts to convert the specified object to an [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject') of the specified type\.

```csharp
public static bool TryConvert_SerializableObject(object @object, out DiGi.Core.Interfaces.ISerializableObject? result, System.Type type);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_SerializableObject(object,DiGi.Core.Interfaces.ISerializableObject,System.Type).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_SerializableObject(object,DiGi.Core.Interfaces.ISerializableObject,System.Type).result'></a>

`result` [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')

When this method returns, contains the converted ISerializableObject, or null if conversion failed\.

<a name='DiGi.Core.Query.TryConvert_SerializableObject(object,DiGi.Core.Interfaces.ISerializableObject,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The target ISerializableObject type\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_Short(object,System.Nullable_short_)'></a>

## Query\.TryConvert\_Short\(object, Nullable\<short\>\) Method

Attempts to convert the specified object to a nullable short\.

```csharp
public static bool TryConvert_Short(object @object, out System.Nullable<short> result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_Short(object,System.Nullable_short_).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_Short(object,System.Nullable_short_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted short, or null if conversion failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_String(thisobject,string)'></a>

## Query\.TryConvert\_String\(this object, string\) Method

Attempts to convert the specified object to a nullable string\.

```csharp
public static bool TryConvert_String(this object? @object, out string? result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_String(thisobject,string).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_String(thisobject,string).result'></a>

`result` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

When this method returns, contains the converted string, or null if conversion failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_TimeSpan(object,System.Nullable_System.TimeSpan_)'></a>

## Query\.TryConvert\_TimeSpan\(object, Nullable\<TimeSpan\>\) Method

Attempts to convert the specified object to a [System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan')\.

```csharp
public static bool TryConvert_TimeSpan(object @object, out System.Nullable<System.TimeSpan> result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_TimeSpan(object,System.Nullable_System.TimeSpan_).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_TimeSpan(object,System.Nullable_System.TimeSpan_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted TimeSpan value if successful; otherwise, the default value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_Type(object,System.Type)'></a>

## Query\.TryConvert\_Type\(object, Type\) Method

Attempts to convert the specified object to a [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')\.

```csharp
public static bool TryConvert_Type(object @object, out System.Type? result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_Type(object,System.Type).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_Type(object,System.Type).result'></a>

`result` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

When this method returns, contains the converted Type value if successful; otherwise, the default value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_Uint(object,System.Nullable_uint_)'></a>

## Query\.TryConvert\_Uint\(object, Nullable\<uint\>\) Method

Attempts to convert the specified object to an unsigned integer \(uint\)\.

```csharp
public static bool TryConvert_Uint(object @object, out System.Nullable<uint> result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_Uint(object,System.Nullable_uint_).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_Uint(object,System.Nullable_uint_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted uint value if successful; otherwise, the default value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_Ulong(object,System.Nullable_ulong_)'></a>

## Query\.TryConvert\_Ulong\(object, Nullable\<ulong\>\) Method

Attempts to convert the specified object to an unsigned long \(ulong\)\.

```csharp
public static bool TryConvert_Ulong(object @object, out System.Nullable<ulong> result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_Ulong(object,System.Nullable_ulong_).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_Ulong(object,System.Nullable_ulong_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64 'System\.UInt64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted ulong value if successful; otherwise, the default value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryConvert_Ushort(object,System.Nullable_ushort_)'></a>

## Query\.TryConvert\_Ushort\(object, Nullable\<ushort\>\) Method

Attempts to convert the specified object to an unsigned short \(ushort\)\.

```csharp
public static bool TryConvert_Ushort(object @object, out System.Nullable<ushort> result);
```
#### Parameters

<a name='DiGi.Core.Query.TryConvert_Ushort(object,System.Nullable_ushort_).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to convert\.

<a name='DiGi.Core.Query.TryConvert_Ushort(object,System.Nullable_ushort_).result'></a>

`result` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt16](https://learn.microsoft.com/en-us/dotnet/api/system.uint16 'System\.UInt16')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

When this method returns, contains the converted ushort value if successful; otherwise, the default value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the conversion was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryGetDiscriminator(thisstring,string,string)'></a>

## Query\.TryGetDiscriminator\(this string, string, string\) Method

Splits a reference string into its discriminator and its body at the first unescaped
[Separator](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.Separator 'DiGi\.Core\.Constants\.Reference\.Separator') at nesting depth zero\.

The discriminator is either a [Kind](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.Kind 'DiGi\.Core\.Constants\.Reference\.Kind') token or an assembly-qualified
            full type name; the two are told apart by the comma a full type name always contains and a kind token
            never does. This method does not validate the discriminator - a caller must resolve it to know whether it
            names a reference type at all.

```csharp
public static bool TryGetDiscriminator(this string? value, out string? discriminator, out string? body);
```
#### Parameters

<a name='DiGi.Core.Query.TryGetDiscriminator(thisstring,string,string).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The reference string\.

<a name='DiGi.Core.Query.TryGetDiscriminator(thisstring,string,string).discriminator'></a>

`discriminator` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

When this method returns, contains the discriminator; otherwise, null\.

<a name='DiGi.Core.Query.TryGetDiscriminator(thisstring,string,string).body'></a>

`body` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

When this method returns, contains everything after the first separator, or null when the string has no
separator and is therefore a bare discriminator\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a discriminator was extracted; otherwise, false\.

<a name='DiGi.Core.Query.TryGetEnum(string,System.Enum)'></a>

## Query\.TryGetEnum\(string, Enum\) Method

Attempts to parse a "TypeFullName:EnumValueName" formatted string into an Enum value\.

```csharp
public static bool TryGetEnum(string? text, out System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Core.Query.TryGetEnum(string,System.Enum).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The text in "TypeFullName:EnumValueName" format\.

<a name='DiGi.Core.Query.TryGetEnum(string,System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

When this method returns, contains the parsed Enum value, or null if parsing failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the parsing was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryGetEnum(thisstring,System.Type,System.Enum)'></a>

## Query\.TryGetEnum\(this string, Type, Enum\) Method

Attempts to parse a string into an enum value by checking names, descriptions, and fuzzy matching\.

```csharp
public static bool TryGetEnum(this string? text, System.Type? type, out System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Core.Query.TryGetEnum(thisstring,System.Type,System.Enum).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string text to be parsed\.

<a name='DiGi.Core.Query.TryGetEnum(thisstring,System.Type,System.Enum).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type of the enum to parse into\.

<a name='DiGi.Core.Query.TryGetEnum(thisstring,System.Type,System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

When this method returns, contains the parsed enum value if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the string was successfully parsed into an enum value; otherwise, false\.

<a name='DiGi.Core.Query.TryGetEnum_TEnum_(thisstring,TEnum)'></a>

## Query\.TryGetEnum\<TEnum\>\(this string, TEnum\) Method

Attempts to parse a string into a strongly\-typed enum value of type [TEnum](DiGi.Core.md#DiGi.Core.Query.TryGetEnum_TEnum_(thisstring,TEnum).TEnum 'DiGi\.Core\.Query\.TryGetEnum\<TEnum\>\(this string, TEnum\)\.TEnum')\.

```csharp
public static bool TryGetEnum<TEnum>(this string? text, out TEnum? @enum)
    where TEnum : System.Enum;
```
#### Type parameters

<a name='DiGi.Core.Query.TryGetEnum_TEnum_(thisstring,TEnum).TEnum'></a>

`TEnum`

The target enum type\.
#### Parameters

<a name='DiGi.Core.Query.TryGetEnum_TEnum_(thisstring,TEnum).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The text to parse\.

<a name='DiGi.Core.Query.TryGetEnum_TEnum_(thisstring,TEnum).enum'></a>

`enum` [TEnum](DiGi.Core.md#DiGi.Core.Query.TryGetEnum_TEnum_(thisstring,TEnum).TEnum 'DiGi\.Core\.Query\.TryGetEnum\<TEnum\>\(this string, TEnum\)\.TEnum')

When this method returns, contains the parsed TEnum value, or default if parsing failed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the parsing was successful; otherwise, false\.

<a name='DiGi.Core.Query.TryGetFirstKey_T_(thisSystem.Collections.Generic.IDictionary_string,T_,string,string,System.Func_string,string_)'></a>

## Query\.TryGetFirstKey\<T\>\(this IDictionary\<string,T\>, string, string, Func\<string,string\>\) Method

Attempts to find the first key in the dictionary whose transformed value matches the transformed text\.

```csharp
public static bool TryGetFirstKey<T>(this System.Collections.Generic.IDictionary<string,T>? dictionary, string? text, out string? key, System.Func<string?,string?>? func=null);
```
#### Type parameters

<a name='DiGi.Core.Query.TryGetFirstKey_T_(thisSystem.Collections.Generic.IDictionary_string,T_,string,string,System.Func_string,string_).T'></a>

`T`

The type of the dictionary values\.
#### Parameters

<a name='DiGi.Core.Query.TryGetFirstKey_T_(thisSystem.Collections.Generic.IDictionary_string,T_,string,string,System.Func_string,string_).dictionary'></a>

`dictionary` [System\.Collections\.Generic\.IDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[T](DiGi.Core.md#DiGi.Core.Query.TryGetFirstKey_T_(thisSystem.Collections.Generic.IDictionary_string,T_,string,string,System.Func_string,string_).T 'DiGi\.Core\.Query\.TryGetFirstKey\<T\>\(this System\.Collections\.Generic\.IDictionary\<string,T\>, string, string, System\.Func\<string,string\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')

The dictionary to search\.

<a name='DiGi.Core.Query.TryGetFirstKey_T_(thisSystem.Collections.Generic.IDictionary_string,T_,string,string,System.Func_string,string_).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The text to match against\.

<a name='DiGi.Core.Query.TryGetFirstKey_T_(thisSystem.Collections.Generic.IDictionary_string,T_,string,string,System.Func_string,string_).key'></a>

`key` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

When this method returns, contains the first matching key, or null if not found\.

<a name='DiGi.Core.Query.TryGetFirstKey_T_(thisSystem.Collections.Generic.IDictionary_string,T_,string,string,System.Func_string,string_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional transformation function applied to both the text and dictionary keys before comparison\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a matching key was found; otherwise, false\.

<a name='DiGi.Core.Query.TryGetKeys_T_(thisSystem.Collections.Generic.IDictionary_string,T_,string,System.Collections.Generic.List_string_,System.Func_string,string_)'></a>

## Query\.TryGetKeys\<T\>\(this IDictionary\<string,T\>, string, List\<string\>, Func\<string,string\>\) Method

Attempts to find all keys in the dictionary whose transformed value matches the transformed text\.

```csharp
public static bool TryGetKeys<T>(this System.Collections.Generic.IDictionary<string,T>? dictionary, string? text, out System.Collections.Generic.List<string>? keys, System.Func<string?,string?>? func=null);
```
#### Type parameters

<a name='DiGi.Core.Query.TryGetKeys_T_(thisSystem.Collections.Generic.IDictionary_string,T_,string,System.Collections.Generic.List_string_,System.Func_string,string_).T'></a>

`T`

The type of the dictionary values\.
#### Parameters

<a name='DiGi.Core.Query.TryGetKeys_T_(thisSystem.Collections.Generic.IDictionary_string,T_,string,System.Collections.Generic.List_string_,System.Func_string,string_).dictionary'></a>

`dictionary` [System\.Collections\.Generic\.IDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[T](DiGi.Core.md#DiGi.Core.Query.TryGetKeys_T_(thisSystem.Collections.Generic.IDictionary_string,T_,string,System.Collections.Generic.List_string_,System.Func_string,string_).T 'DiGi\.Core\.Query\.TryGetKeys\<T\>\(this System\.Collections\.Generic\.IDictionary\<string,T\>, string, System\.Collections\.Generic\.List\<string\>, System\.Func\<string,string\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')

The dictionary to search\.

<a name='DiGi.Core.Query.TryGetKeys_T_(thisSystem.Collections.Generic.IDictionary_string,T_,string,System.Collections.Generic.List_string_,System.Func_string,string_).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The text to match against\.

<a name='DiGi.Core.Query.TryGetKeys_T_(thisSystem.Collections.Generic.IDictionary_string,T_,string,System.Collections.Generic.List_string_,System.Func_string,string_).keys'></a>

`keys` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

When this method returns, contains a list of all matching keys, or null if none were found\.

<a name='DiGi.Core.Query.TryGetKeys_T_(thisSystem.Collections.Generic.IDictionary_string,T_,string,System.Collections.Generic.List_string_,System.Func_string,string_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional transformation function applied to both the text and dictionary keys before comparison\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if one or more matching keys were found; otherwise, false\.

<a name='DiGi.Core.Query.TryGetLowerValue_TKey,TValue_(thisSystem.Collections.Generic.SortedDictionary_TKey,TValue_,TKey,TValue,bool,bool)'></a>

## Query\.TryGetLowerValue\<TKey,TValue\>\(this SortedDictionary\<TKey,TValue\>, TKey, TValue, bool, bool\) Method

Attempts to get the value associated with the nearest key less than or equal to the specified key in a sorted dictionary\.

```csharp
public static bool TryGetLowerValue<TKey,TValue>(this System.Collections.Generic.SortedDictionary<TKey,TValue>? sortedDictionary, TKey? key, out TValue? value, bool lowerLimit=true, bool upperLimit=false)
    where TKey : System.IComparable<TKey>;
```
#### Type parameters

<a name='DiGi.Core.Query.TryGetLowerValue_TKey,TValue_(thisSystem.Collections.Generic.SortedDictionary_TKey,TValue_,TKey,TValue,bool,bool).TKey'></a>

`TKey`

The type of the keys, which must be comparable\.

<a name='DiGi.Core.Query.TryGetLowerValue_TKey,TValue_(thisSystem.Collections.Generic.SortedDictionary_TKey,TValue_,TKey,TValue,bool,bool).TValue'></a>

`TValue`

The type of the values\.
#### Parameters

<a name='DiGi.Core.Query.TryGetLowerValue_TKey,TValue_(thisSystem.Collections.Generic.SortedDictionary_TKey,TValue_,TKey,TValue,bool,bool).sortedDictionary'></a>

`sortedDictionary` [System\.Collections\.Generic\.SortedDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.sorteddictionary-2 'System\.Collections\.Generic\.SortedDictionary\`2')[TKey](DiGi.Core.md#DiGi.Core.Query.TryGetLowerValue_TKey,TValue_(thisSystem.Collections.Generic.SortedDictionary_TKey,TValue_,TKey,TValue,bool,bool).TKey 'DiGi\.Core\.Query\.TryGetLowerValue\<TKey,TValue\>\(this System\.Collections\.Generic\.SortedDictionary\<TKey,TValue\>, TKey, TValue, bool, bool\)\.TKey')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.sorteddictionary-2 'System\.Collections\.Generic\.SortedDictionary\`2')[TValue](DiGi.Core.md#DiGi.Core.Query.TryGetLowerValue_TKey,TValue_(thisSystem.Collections.Generic.SortedDictionary_TKey,TValue_,TKey,TValue,bool,bool).TValue 'DiGi\.Core\.Query\.TryGetLowerValue\<TKey,TValue\>\(this System\.Collections\.Generic\.SortedDictionary\<TKey,TValue\>, TKey, TValue, bool, bool\)\.TValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.sorteddictionary-2 'System\.Collections\.Generic\.SortedDictionary\`2')

The sorted dictionary to search\.

<a name='DiGi.Core.Query.TryGetLowerValue_TKey,TValue_(thisSystem.Collections.Generic.SortedDictionary_TKey,TValue_,TKey,TValue,bool,bool).key'></a>

`key` [TKey](DiGi.Core.md#DiGi.Core.Query.TryGetLowerValue_TKey,TValue_(thisSystem.Collections.Generic.SortedDictionary_TKey,TValue_,TKey,TValue,bool,bool).TKey 'DiGi\.Core\.Query\.TryGetLowerValue\<TKey,TValue\>\(this System\.Collections\.Generic\.SortedDictionary\<TKey,TValue\>, TKey, TValue, bool, bool\)\.TKey')

The key to look up or find the nearest lower key for\.

<a name='DiGi.Core.Query.TryGetLowerValue_TKey,TValue_(thisSystem.Collections.Generic.SortedDictionary_TKey,TValue_,TKey,TValue,bool,bool).value'></a>

`value` [TValue](DiGi.Core.md#DiGi.Core.Query.TryGetLowerValue_TKey,TValue_(thisSystem.Collections.Generic.SortedDictionary_TKey,TValue_,TKey,TValue,bool,bool).TValue 'DiGi\.Core\.Query\.TryGetLowerValue\<TKey,TValue\>\(this System\.Collections\.Generic\.SortedDictionary\<TKey,TValue\>, TKey, TValue, bool, bool\)\.TValue')

When this method returns, contains the associated value, or default if not found\.

<a name='DiGi.Core.Query.TryGetLowerValue_TKey,TValue_(thisSystem.Collections.Generic.SortedDictionary_TKey,TValue_,TKey,TValue,bool,bool).lowerLimit'></a>

`lowerLimit` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If true, returns false when the key is below the minimum key\. If false, clamps to the minimum\.

<a name='DiGi.Core.Query.TryGetLowerValue_TKey,TValue_(thisSystem.Collections.Generic.SortedDictionary_TKey,TValue_,TKey,TValue,bool,bool).upperLimit'></a>

`upperLimit` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If true, returns false when the key is above the maximum key\. If false, clamps to the maximum\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a value was found; otherwise, false\.

<a name='DiGi.Core.Query.TryGetUniqueId(thisobject,string)'></a>

## Query\.TryGetUniqueId\(this object, string\) Method

Attempts to retrieve the unique identifier of the specified object\.

```csharp
public static bool TryGetUniqueId(this object? @object, out string? uniqueId);
```
#### Parameters

<a name='DiGi.Core.Query.TryGetUniqueId(thisobject,string).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object whose unique ID to retrieve\.

<a name='DiGi.Core.Query.TryGetUniqueId(thisobject,string).uniqueId'></a>

`uniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

When this method returns, contains the unique identifier string, or null if it could not be determined\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the unique ID was successfully retrieved; otherwise, false\.

<a name='DiGi.Core.Query.TryParse(thisstring,DiGi.Core.Interfaces.IReference)'></a>

## Query\.TryParse\(this string, IReference\) Method

Attempts to parse the specified string into an [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')\.

The string's discriminator names exactly one reference type, so the result is the same type that
            produced the string. Types defined outside DiGi.Core resolve too, provided their assembly is loaded.

Strings written before the discriminator was introduced are still accepted, via
            [TryParseLegacy\(this string, IReference\)](DiGi.Core.md#DiGi.Core.Query.TryParseLegacy(thisstring,DiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.TryParseLegacy\(this string, DiGi\.Core\.Interfaces\.IReference\)').

```csharp
public static bool TryParse(this string? value, out DiGi.Core.Interfaces.IReference? reference);
```
#### Parameters

<a name='DiGi.Core.Query.TryParse(thisstring,DiGi.Core.Interfaces.IReference).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string to parse\.

<a name='DiGi.Core.Query.TryParse(thisstring,DiGi.Core.Interfaces.IReference).reference'></a>

`reference` [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')

When this method returns, contains the parsed reference; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the string was successfully parsed; otherwise, false\.

<a name='DiGi.Core.Query.TryParse_UReference_(thisstring,UReference)'></a>

## Query\.TryParse\<UReference\>\(this string, UReference\) Method

Attempts to parse the specified string into a reference of the requested type\.

```csharp
public static bool TryParse<UReference>(this string? value, out UReference? reference)
    where UReference : DiGi.Core.Interfaces.IReference;
```
#### Type parameters

<a name='DiGi.Core.Query.TryParse_UReference_(thisstring,UReference).UReference'></a>

`UReference`

The type of reference to parse\.
#### Parameters

<a name='DiGi.Core.Query.TryParse_UReference_(thisstring,UReference).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string to parse\.

<a name='DiGi.Core.Query.TryParse_UReference_(thisstring,UReference).reference'></a>

`reference` [UReference](DiGi.Core.md#DiGi.Core.Query.TryParse_UReference_(thisstring,UReference).UReference 'DiGi\.Core\.Query\.TryParse\<UReference\>\(this string, UReference\)\.UReference')

When this method returns, contains the parsed reference; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the string was successfully parsed into the requested type; otherwise, false\.

<a name='DiGi.Core.Query.TryParseDouble(thisstring,double)'></a>

## Query\.TryParseDouble\(this string, double\) Method

Attempts to parse the specified string into a double\-precision floating\-point number\.

```csharp
public static bool TryParseDouble(this string value, out double result);
```
#### Parameters

<a name='DiGi.Core.Query.TryParseDouble(thisstring,double).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string containing the double\-precision floating\-point number to parse\.

<a name='DiGi.Core.Query.TryParseDouble(thisstring,double).result'></a>

`result` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

When this method returns, contains the parsed value if the conversion was successful; otherwise, zero\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
true if the string was successfully parsed; otherwise, false\.

<a name='DiGi.Core.Query.TryParseLegacy(thisstring,DiGi.Core.Interfaces.IReference)'></a>

## Query\.TryParseLegacy\(this string, IReference\) Method

Attempts to parse a reference string written in the format used before discriminators were introduced\.

Read-only compatibility for pre-existing storage archives. See the file header for the format, its
            limits, and the conditions for deleting this method.

```csharp
public static bool TryParseLegacy(this string? value, out DiGi.Core.Interfaces.IReference? reference);
```
#### Parameters

<a name='DiGi.Core.Query.TryParseLegacy(thisstring,DiGi.Core.Interfaces.IReference).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The legacy string to parse\.

<a name='DiGi.Core.Query.TryParseLegacy(thisstring,DiGi.Core.Interfaces.IReference).reference'></a>

`reference` [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')

When this method returns, contains the parsed reference; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the string was successfully parsed; otherwise, false\.

<a name='DiGi.Core.Query.Type(thisDiGi.Core.Classes.TypeReference)'></a>

## Query\.Type\(this TypeReference\) Method

Gets the Type associated with the specified TypeReference\.

```csharp
public static System.Type? Type(this DiGi.Core.Classes.TypeReference? typeReference);
```
#### Parameters

<a name='DiGi.Core.Query.Type(thisDiGi.Core.Classes.TypeReference).typeReference'></a>

`typeReference` [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')

The type reference to get the type for\.

#### Returns
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')  
The Type associated with the specified TypeReference, or null if not found\.

<a name='DiGi.Core.Query.Type(thisDiGi.Core.Enums.DataType)'></a>

## Query\.Type\(this DataType\) Method

Gets the Type associated with the specified DataType\.

```csharp
public static System.Type? Type(this DiGi.Core.Enums.DataType dataType);
```
#### Parameters

<a name='DiGi.Core.Query.Type(thisDiGi.Core.Enums.DataType).dataType'></a>

`dataType` [DataType](DiGi.Core.Enums.md#DiGi.Core.Enums.DataType 'DiGi\.Core\.Enums\.DataType')

The data type to get the type for\.

#### Returns
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')  
The Type associated with the specified DataType, or null if not found\.

<a name='DiGi.Core.Query.Type(thisstring,bool)'></a>

## Query\.Type\(this string, bool\) Method

Gets the Type associated with the specified type name\.

```csharp
public static System.Type? Type(this string? typeName, bool ignoreCase=false);
```
#### Parameters

<a name='DiGi.Core.Query.Type(thisstring,bool).typeName'></a>

`typeName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the type to search for\.

<a name='DiGi.Core.Query.Type(thisstring,bool).ignoreCase'></a>

`ignoreCase` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to ignore case during comparison\.

#### Returns
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')  
The Type associated with the specified type name, or null if not found\.

<a name='DiGi.Core.Query.Type(thisstring,DiGi.Core.Enums.TextComparisonType,bool,System.Func_System.Reflection.Assembly,bool_)'></a>

## Query\.Type\(this string, TextComparisonType, bool, Func\<Assembly,bool\>\) Method

Gets the Type associated with the specified type name using custom comparison and assembly filtering\.

```csharp
public static System.Type? Type(this string? typeName, DiGi.Core.Enums.TextComparisonType textComparisonType, bool ignoreCase=false, System.Func<System.Reflection.Assembly,bool>? func=null);
```
#### Parameters

<a name='DiGi.Core.Query.Type(thisstring,DiGi.Core.Enums.TextComparisonType,bool,System.Func_System.Reflection.Assembly,bool_).typeName'></a>

`typeName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the type to search for\.

<a name='DiGi.Core.Query.Type(thisstring,DiGi.Core.Enums.TextComparisonType,bool,System.Func_System.Reflection.Assembly,bool_).textComparisonType'></a>

`textComparisonType` [TextComparisonType](DiGi.Core.Enums.md#DiGi.Core.Enums.TextComparisonType 'DiGi\.Core\.Enums\.TextComparisonType')

The type of text comparison to use\.

<a name='DiGi.Core.Query.Type(thisstring,DiGi.Core.Enums.TextComparisonType,bool,System.Func_System.Reflection.Assembly,bool_).ignoreCase'></a>

`ignoreCase` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to ignore case during comparison\.

<a name='DiGi.Core.Query.Type(thisstring,DiGi.Core.Enums.TextComparisonType,bool,System.Func_System.Reflection.Assembly,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Reflection\.Assembly](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.assembly 'System\.Reflection\.Assembly')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

A function used to filter assemblies\.

#### Returns
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')  
The Type associated with the specified type name, or null if not found\.

<a name='DiGi.Core.Query.Unescaped(thisstring)'></a>

## Query\.Unescaped\(this string\) Method

Reverses [Escaped\(this string\)](DiGi.Core.md#DiGi.Core.Query.Escaped(thisstring) 'DiGi\.Core\.Query\.Escaped\(this string\)'), turning a reference segment back into its scalar value\.

```csharp
public static string? Unescaped(this string? value);
```
#### Parameters

<a name='DiGi.Core.Query.Unescaped(thisstring).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The escaped segment\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The original scalar value; null when [value](DiGi.Core.md#DiGi.Core.Query.Unescaped(thisstring).value 'DiGi\.Core\.Query\.Unescaped\(this string\)\.value') is null or is the
[Null](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.Null 'DiGi\.Core\.Constants\.Reference\.Null') token\. A trailing lone escape character is malformed and also
yields null\.

<a name='DiGi.Core.Query.UniqueHash(thisstring,ulong)'></a>

## Query\.UniqueHash\(this string, ulong\) Method

Computes a unique hash for the specified string\.

```csharp
public static ulong UniqueHash(this string? @string, ulong hash=14695981039346656037uL);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueHash(thisstring,ulong).string'></a>

`string` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string to hash\.

<a name='DiGi.Core.Query.UniqueHash(thisstring,ulong).hash'></a>

`hash` [System\.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64 'System\.UInt64')

The initial hash value \(offset basis\)\.

#### Returns
[System\.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64 'System\.UInt64')  
The computed unique hash as a ulong\.

<a name='DiGi.Core.Query.UniqueHash(thisSystem.Text.Json.Nodes.JsonNode,ulong)'></a>

## Query\.UniqueHash\(this JsonNode, ulong\) Method

Computes a unique hash for the specified JsonNode\.

```csharp
public static ulong UniqueHash(this System.Text.Json.Nodes.JsonNode? jsonNode, ulong hash=14695981039346656037uL);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueHash(thisSystem.Text.Json.Nodes.JsonNode,ulong).jsonNode'></a>

`jsonNode` [System\.Text\.Json\.Nodes\.JsonNode](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonnode 'System\.Text\.Json\.Nodes\.JsonNode')

The JsonNode to hash\.

<a name='DiGi.Core.Query.UniqueHash(thisSystem.Text.Json.Nodes.JsonNode,ulong).hash'></a>

`hash` [System\.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64 'System\.UInt64')

The initial hash value \(offset basis\)\.

#### Returns
[System\.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64 'System\.UInt64')  
The computed unique hash as a ulong\.

<a name='DiGi.Core.Query.UniqueId(System.Text.Json.Nodes.JsonArray)'></a>

## Query\.UniqueId\(JsonArray\) Method

Generates a unique identifier for the specified JsonArray\.

```csharp
public static string UniqueId(System.Text.Json.Nodes.JsonArray? value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(System.Text.Json.Nodes.JsonArray).value'></a>

`value` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The JsonArray to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(System.Text.Json.Nodes.JsonNode)'></a>

## Query\.UniqueId\(JsonNode\) Method

Generates a unique identifier for the specified JsonNode\.

```csharp
public static string UniqueId(System.Text.Json.Nodes.JsonNode? value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(System.Text.Json.Nodes.JsonNode).value'></a>

`value` [System\.Text\.Json\.Nodes\.JsonNode](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonnode 'System\.Text\.Json\.Nodes\.JsonNode')

The JsonNode to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(System.Text.Json.Nodes.JsonValue)'></a>

## Query\.UniqueId\(JsonValue\) Method

Generates a unique identifier for the specified JsonValue\.

```csharp
public static string UniqueId(System.Text.Json.Nodes.JsonValue? value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(System.Text.Json.Nodes.JsonValue).value'></a>

`value` [System\.Text\.Json\.Nodes\.JsonValue](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonvalue 'System\.Text\.Json\.Nodes\.JsonValue')

The JsonValue to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisbool)'></a>

## Query\.UniqueId\(this bool\) Method

Generates a unique identifier for the specified boolean\.

```csharp
public static string UniqueId(this bool value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisbool).value'></a>

`value` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

The boolean value to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisdecimal)'></a>

## Query\.UniqueId\(this decimal\) Method

Generates a unique identifier for the specified decimal\.

```csharp
public static string UniqueId(this decimal value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisdecimal).value'></a>

`value` [System\.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal 'System\.Decimal')

The decimal value to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisDiGi.Core.Interfaces.ISerializableObject)'></a>

## Query\.UniqueId\(this ISerializableObject\) Method

Generates a unique identifier for the specified ISerializableObject\.

```csharp
public static string UniqueId(this DiGi.Core.Interfaces.ISerializableObject? serializableObject);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisDiGi.Core.Interfaces.ISerializableObject).serializableObject'></a>

`serializableObject` [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The serializable object to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisDiGi.Core.Interfaces.IUniqueObject)'></a>

## Query\.UniqueId\(this IUniqueObject\) Method

Generates a unique identifier for the specified IUniqueObject\.

```csharp
public static string UniqueId(this DiGi.Core.Interfaces.IUniqueObject? uniqueObject);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisDiGi.Core.Interfaces.IUniqueObject).uniqueObject'></a>

`uniqueObject` [IUniqueObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject 'DiGi\.Core\.Interfaces\.IUniqueObject')

The unique object to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisdouble)'></a>

## Query\.UniqueId\(this double\) Method

Generates a unique identifier for the specified double\.

```csharp
public static string UniqueId(this double value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisdouble).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisfloat)'></a>

## Query\.UniqueId\(this float\) Method

Generates a unique identifier for the specified float\.

```csharp
public static string UniqueId(this float value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisfloat).value'></a>

`value` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The float value to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisint)'></a>

## Query\.UniqueId\(this int\) Method

Generates a unique identifier for the specified integer\.

```csharp
public static string UniqueId(this int value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisint).value'></a>

`value` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer to generate an identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thislong)'></a>

## Query\.UniqueId\(this long\) Method

Generates a unique identifier for the specified long\.

```csharp
public static string UniqueId(this long value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thislong).value'></a>

`value` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The long value to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisobject)'></a>

## Query\.UniqueId\(this object\) Method

Generates a unique identifier for the specified object\.

```csharp
public static string UniqueId(this object? @object);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisobject).object'></a>

`object` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisshort)'></a>

## Query\.UniqueId\(this short\) Method

Generates a unique identifier for the specified short\.

```csharp
public static string UniqueId(this short value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisshort).value'></a>

`value` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The short value to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisstring)'></a>

## Query\.UniqueId\(this string\) Method

Generates a unique identifier for the specified string\.

```csharp
public static string UniqueId(this string? value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisstring).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string value to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A unique identifier as a string\.

<a name='DiGi.Core.Query.UniqueId(thisSystem.DateTime)'></a>

## Query\.UniqueId\(this DateTime\) Method

Generates a unique identifier for the specified DateTime\.

```csharp
public static string UniqueId(this System.DateTime value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisSystem.DateTime).value'></a>

`value` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The DateTime value to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisSystem.Enum)'></a>

## Query\.UniqueId\(this Enum\) Method

Generates a unique identifier for the specified nullable Enum\.

```csharp
public static string UniqueId(this System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisSystem.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The nullable Enum to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisSystem.Guid)'></a>

## Query\.UniqueId\(this Guid\) Method

Generates a unique identifier for the specified Guid\.

```csharp
public static string UniqueId(this System.Guid guid);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisSystem.Guid).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The Guid to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_bool_)'></a>

## Query\.UniqueId\(this Nullable\<bool\>\) Method

Generates a unique identifier for the specified nullable boolean\.

```csharp
public static string UniqueId(this System.Nullable<bool> value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_bool_).value'></a>

`value` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The nullable boolean value to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_decimal_)'></a>

## Query\.UniqueId\(this Nullable\<decimal\>\) Method

Generates a unique identifier for the specified nullable decimal\.

```csharp
public static string UniqueId(this System.Nullable<decimal> value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_decimal_).value'></a>

`value` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Decimal](https://learn.microsoft.com/en-us/dotnet/api/system.decimal 'System\.Decimal')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The nullable decimal to generate an identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_double_)'></a>

## Query\.UniqueId\(this Nullable\<double\>\) Method

Generates a unique identifier for the specified nullable double\.

```csharp
public static string UniqueId(this System.Nullable<double> value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_double_).value'></a>

`value` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The nullable double value to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_float_)'></a>

## Query\.UniqueId\(this Nullable\<float\>\) Method

Generates a unique identifier for the specified nullable float\.

```csharp
public static string UniqueId(this System.Nullable<float> value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_float_).value'></a>

`value` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The nullable float value to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_int_)'></a>

## Query\.UniqueId\(this Nullable\<int\>\) Method

Generates a unique identifier for the specified nullable integer\.

```csharp
public static string UniqueId(this System.Nullable<int> value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_int_).value'></a>

`value` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The nullable integer to generate an identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_long_)'></a>

## Query\.UniqueId\(this Nullable\<long\>\) Method

Generates a unique identifier for the specified nullable long\.

```csharp
public static string UniqueId(this System.Nullable<long> value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_long_).value'></a>

`value` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The nullable long value to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_short_)'></a>

## Query\.UniqueId\(this Nullable\<short\>\) Method

Generates a unique identifier for the specified nullable short\.

```csharp
public static string UniqueId(this System.Nullable<short> value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_short_).value'></a>

`value` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The nullable short value to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_System.DateTime_)'></a>

## Query\.UniqueId\(this Nullable\<DateTime\>\) Method

Generates a unique identifier for the specified nullable DateTime\.

```csharp
public static string UniqueId(this System.Nullable<System.DateTime> value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_System.DateTime_).value'></a>

`value` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The nullable DateTime to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_System.Guid_)'></a>

## Query\.UniqueId\(this Nullable\<Guid\>\) Method

Generates a unique identifier for the specified nullable Guid\.

```csharp
public static string UniqueId(this System.Nullable<System.Guid> guid);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_System.Guid_).guid'></a>

`guid` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The nullable Guid to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_uint_)'></a>

## Query\.UniqueId\(this Nullable\<uint\>\) Method

Generates a unique identifier for the specified nullable unsigned integer\.

```csharp
public static string UniqueId(this System.Nullable<uint> value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_uint_).value'></a>

`value` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The nullable unsigned integer to generate an identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_ulong_)'></a>

## Query\.UniqueId\(this Nullable\<ulong\>\) Method

Generates a unique identifier for the specified nullable ulong\.

```csharp
public static string UniqueId(this System.Nullable<ulong> value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisSystem.Nullable_ulong_).value'></a>

`value` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64 'System\.UInt64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The nullable ulong value to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisSystem.Text.Json.Nodes.JsonObject)'></a>

## Query\.UniqueId\(this JsonObject\) Method

Generates a unique identifier for the specified JsonObject\.

```csharp
public static string UniqueId(this System.Text.Json.Nodes.JsonObject? value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisSystem.Text.Json.Nodes.JsonObject).value'></a>

`value` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JsonObject to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisuint)'></a>

## Query\.UniqueId\(this uint\) Method

Generates a unique identifier for the specified unsigned integer\.

```csharp
public static string UniqueId(this uint value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisuint).value'></a>

`value` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

The unsigned integer to generate an identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.UniqueId(thisulong)'></a>

## Query\.UniqueId\(this ulong\) Method

Generates a unique identifier for the specified ulong\.

```csharp
public static string UniqueId(this ulong value);
```
#### Parameters

<a name='DiGi.Core.Query.UniqueId(thisulong).value'></a>

`value` [System\.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64 'System\.UInt64')

The ulong value to generate a unique identifier for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the unique identifier\.

<a name='DiGi.Core.Query.Value(thisSystem.Text.Json.Nodes.JsonNode,System.Type)'></a>

## Query\.Value\(this JsonNode, Type\) Method

Extracts the value from a [System\.Text\.Json\.Nodes\.JsonNode](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonnode 'System\.Text\.Json\.Nodes\.JsonNode') cast to the specified type\.

```csharp
public static object? Value(this System.Text.Json.Nodes.JsonNode? jsonNode, System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Query.Value(thisSystem.Text.Json.Nodes.JsonNode,System.Type).jsonNode'></a>

`jsonNode` [System\.Text\.Json\.Nodes\.JsonNode](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonnode 'System\.Text\.Json\.Nodes\.JsonNode')

The JSON node to extract the value from\.

<a name='DiGi.Core.Query.Value(thisSystem.Text.Json.Nodes.JsonNode,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The target type to cast the value to\.

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')  
The extracted value cast to the specified type, or null if the operation fails or the input is null\.

<a name='DiGi.Core.Query.Values(thisDiGi.Core.Classes.Range_int_)'></a>

## Query\.Values\(this Range\<int\>\) Method

Generates an array of integers within the specified range\.

```csharp
public static int[]? Values(this DiGi.Core.Classes.Range<int>? range);
```
#### Parameters

<a name='DiGi.Core.Query.Values(thisDiGi.Core.Classes.Range_int_).range'></a>

`range` [DiGi\.Core\.Classes\.Range&lt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Range_T_ 'DiGi\.Core\.Classes\.Range\<T\>')

The range from which to generate values\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array containing all integer values in the range, or null if the range is null\.

<a name='DiGi.Core.Settings'></a>

## Settings Class

Provides global settings and managers for the DiGi\.Core library\.

```csharp
public static class Settings
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Settings
### Properties

<a name='DiGi.Core.Settings.ConversionManager'></a>

## Settings\.ConversionManager Property

Gets the manager responsible for conversion tasks\.

```csharp
public static DiGi.Core.Classes.ConversionManager ConversionManager { get; }
```

#### Property Value
[ConversionManager](DiGi.Core.Classes.md#DiGi.Core.Classes.ConversionManager 'DiGi\.Core\.Classes\.ConversionManager')

<a name='DiGi.Core.Settings.ReferenceManager'></a>

## Settings\.ReferenceManager Property

Gets the manager responsible for resolving reference discriminators to the factories that rebuild them\.

```csharp
public static DiGi.Core.Classes.ReferenceManager ReferenceManager { get; }
```

#### Property Value
[ReferenceManager](DiGi.Core.Classes.md#DiGi.Core.Classes.ReferenceManager 'DiGi\.Core\.Classes\.ReferenceManager')

<a name='DiGi.Core.Settings.SerializationManager'></a>

## Settings\.SerializationManager Property

Gets the manager responsible for serialization tasks\.

```csharp
public static DiGi.Core.Classes.SerializationManager SerializationManager { get; }
```

#### Property Value
[SerializationManager](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializationManager 'DiGi\.Core\.Classes\.SerializationManager')