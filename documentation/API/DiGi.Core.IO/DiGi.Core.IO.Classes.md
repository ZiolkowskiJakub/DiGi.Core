#### [DiGi\.Core\.IO](index.md 'index')

## DiGi\.Core\.IO\.Classes Namespace
### Classes

<a name='DiGi.Core.IO.Classes.Archive_TSerializableObject_'></a>

## Archive\<TSerializableObject\> Class

Represents an archive container for storing serialized data\.

```csharp
public class Archive<TSerializableObject> : DiGi.Core.Classes.SerializableObject, DiGi.Core.IO.Interfaces.IArchive, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.IO.Interfaces.IIOObject
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Core.IO.Classes.Archive_TSerializableObject_.TSerializableObject'></a>

`TSerializableObject`

The type of object that can be serialized within the archive\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Archive\<TSerializableObject\>

Implements [DiGi\.Core\.IO\.Interfaces\.IArchive](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iarchive 'DiGi\.Core\.IO\.Interfaces\.IArchive'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.IO\.Interfaces\.IIOObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iioobject 'DiGi\.Core\.IO\.Interfaces\.IIOObject')
### Constructors

<a name='DiGi.Core.IO.Classes.Archive_TSerializableObject_.Archive(byte[])'></a>

## Archive\(byte\[\]\) Constructor

Initializes a new instance of the [Archive&lt;TSerializableObject&gt;](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.Archive_TSerializableObject_ 'DiGi\.Core\.IO\.Classes\.Archive\<TSerializableObject\>') class using the specified byte array\.

```csharp
public Archive(byte[] bytes);
```
#### Parameters

<a name='DiGi.Core.IO.Classes.Archive_TSerializableObject_.Archive(byte[]).bytes'></a>

`bytes` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The byte array to use for initialization\.

<a name='DiGi.Core.IO.Classes.Archive_TSerializableObject_.Archive(DiGi.Core.IO.Classes.Archive_TSerializableObject_)'></a>

## Archive\(Archive\<TSerializableObject\>\) Constructor

Initializes a new instance of the [Archive&lt;TSerializableObject&gt;](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.Archive_TSerializableObject_ 'DiGi\.Core\.IO\.Classes\.Archive\<TSerializableObject\>') class by copying an existing generic archive\.

```csharp
public Archive(DiGi.Core.IO.Classes.Archive<TSerializableObject> archive);
```
#### Parameters

<a name='DiGi.Core.IO.Classes.Archive_TSerializableObject_.Archive(DiGi.Core.IO.Classes.Archive_TSerializableObject_).archive'></a>

`archive` [DiGi\.Core\.IO\.Classes\.Archive&lt;](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.Archive_TSerializableObject_ 'DiGi\.Core\.IO\.Classes\.Archive\<TSerializableObject\>')[TSerializableObject](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.Archive_TSerializableObject_.TSerializableObject 'DiGi\.Core\.IO\.Classes\.Archive\<TSerializableObject\>\.TSerializableObject')[&gt;](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.Archive_TSerializableObject_ 'DiGi\.Core\.IO\.Classes\.Archive\<TSerializableObject\>')

The generic archive to copy from\.

<a name='DiGi.Core.IO.Classes.Archive_TSerializableObject_.Archive(System.Text.Json.Nodes.JsonObject)'></a>

## Archive\(JsonObject\) Constructor

Initializes a new instance of the [Archive&lt;TSerializableObject&gt;](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.Archive_TSerializableObject_ 'DiGi\.Core\.IO\.Classes\.Archive\<TSerializableObject\>') class using the specified JSON object\.

```csharp
public Archive(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.IO.Classes.Archive_TSerializableObject_.Archive(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to use for initialization\.
### Properties

<a name='DiGi.Core.IO.Classes.Archive_TSerializableObject_.Bytes'></a>

## Archive\<TSerializableObject\>\.Bytes Property

Gets or sets the raw bytes contained within the archive\.

```csharp
public byte[]? Bytes { get; }
```

Implements [Bytes](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iarchive.bytes 'DiGi\.Core\.IO\.Interfaces\.IArchive\.Bytes')

#### Property Value
[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Core.IO.Classes.FileFilter'></a>

## FileFilter Class

Provides a filter for selecting files based on a name and a set of extensions\.

```csharp
public sealed class FileFilter : DiGi.Core.Classes.SerializableObject, DiGi.Core.IO.Interfaces.IIOObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → FileFilter

Implements [DiGi\.Core\.IO\.Interfaces\.IIOObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iioobject 'DiGi\.Core\.IO\.Interfaces\.IIOObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.IO.Classes.FileFilter.FileFilter(DiGi.Core.IO.Classes.FileFilter)'></a>

## FileFilter\(FileFilter\) Constructor

Initializes a new instance of the [FileFilter](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.FileFilter 'DiGi\.Core\.IO\.Classes\.FileFilter') class by copying an existing filter\.

```csharp
public FileFilter(DiGi.Core.IO.Classes.FileFilter? fileFilter);
```
#### Parameters

<a name='DiGi.Core.IO.Classes.FileFilter.FileFilter(DiGi.Core.IO.Classes.FileFilter).fileFilter'></a>

`fileFilter` [FileFilter](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.FileFilter 'DiGi\.Core\.IO\.Classes\.FileFilter')

The existing filter to copy\.

<a name='DiGi.Core.IO.Classes.FileFilter.FileFilter(string,System.Collections.Generic.IEnumerable_string_)'></a>

## FileFilter\(string, IEnumerable\<string\>\) Constructor

Initializes a new instance of the [FileFilter](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.FileFilter 'DiGi\.Core\.IO\.Classes\.FileFilter') class with a specified name and extensions\.

```csharp
public FileFilter(string? name, System.Collections.Generic.IEnumerable<string>? extensions);
```
#### Parameters

<a name='DiGi.Core.IO.Classes.FileFilter.FileFilter(string,System.Collections.Generic.IEnumerable_string_).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the filter\.

<a name='DiGi.Core.IO.Classes.FileFilter.FileFilter(string,System.Collections.Generic.IEnumerable_string_).extensions'></a>

`extensions` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of file extensions associated with the filter\.

<a name='DiGi.Core.IO.Classes.FileFilter.FileFilter(System.Text.Json.Nodes.JsonObject)'></a>

## FileFilter\(JsonObject\) Constructor

Initializes a new instance of the [FileFilter](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.FileFilter 'DiGi\.Core\.IO\.Classes\.FileFilter') class using the specified JSON object\.

```csharp
public FileFilter(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.IO.Classes.FileFilter.FileFilter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to use for initialization\.
### Properties

<a name='DiGi.Core.IO.Classes.FileFilter.Extensions'></a>

## FileFilter\.Extensions Property

Gets or sets the list of file extensions associated with this filter\.

```csharp
public System.Collections.Generic.List<string>? Extensions { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Core.IO.Classes.FileFilter.Name'></a>

## FileFilter\.Name Property

Gets or sets the descriptive name of the file filter\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Core.IO.Classes.FileFilter.Clone()'></a>

## FileFilter\.Clone\(\) Method

Creates a copy of the current object\.

```csharp
public override DiGi.Core.Interfaces.ISerializableObject? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
A new instance of the current object containing a copy of its data\.

<a name='DiGi.Core.IO.Classes.FileFilter.Equals(object)'></a>

## FileFilter\.Equals\(object\) Method

Determines whether the specified object is equal to the current object\.

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='DiGi.Core.IO.Classes.FileFilter.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the current object\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified object is equal to the current object; otherwise, false\.

<a name='DiGi.Core.IO.Classes.FileFilter.GetHashCode()'></a>

## FileFilter\.GetHashCode\(\) Method

Returns the hash code for the current object\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The hash code for the current object\.

<a name='DiGi.Core.IO.Classes.FileFilter.ToString()'></a>

## FileFilter\.ToString\(\) Method

Returns a string that represents the current object\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representation of the current object\.

<a name='DiGi.Core.IO.Classes.Report'></a>

## Report Class

Represents a report used for collecting and exporting data\.

```csharp
public sealed class Report : DiGi.Core.IO.Interfaces.IIOObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Report

Implements [DiGi\.Core\.IO\.Interfaces\.IIOObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iioobject 'DiGi\.Core\.IO\.Interfaces\.IIOObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.IO.Classes.Report.Report()'></a>

## Report\(\) Constructor

Initializes a new instance of the [Report](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.Report 'DiGi\.Core\.IO\.Classes\.Report') class\.

```csharp
public Report();
```

<a name='DiGi.Core.IO.Classes.Report.Report(char)'></a>

## Report\(char\) Constructor

Initializes a new instance of the [Report](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.Report 'DiGi\.Core\.IO\.Classes\.Report') class with a specified separator character\.

```csharp
public Report(char separator);
```
#### Parameters

<a name='DiGi.Core.IO.Classes.Report.Report(char).separator'></a>

`separator` [System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')

The character used to separate values in the report\.
### Methods

<a name='DiGi.Core.IO.Classes.Report.Add()'></a>

## Report\.Add\(\) Method

Adds a new entry to the report\.

```csharp
public void Add();
```

<a name='DiGi.Core.IO.Classes.Report.Add(object[])'></a>

## Report\.Add\(object\[\]\) Method

Adds one or more objects to the report\.

```csharp
public void Add(params object?[]? values);
```
#### Parameters

<a name='DiGi.Core.IO.Classes.Report.Add(object[]).values'></a>

`values` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The objects to add to the report\.

<a name='DiGi.Core.IO.Classes.Report.Add_T_(System.Collections.Generic.IEnumerable_T_)'></a>

## Report\.Add\<T\>\(IEnumerable\<T\>\) Method

Adds a collection of values to the report\.

```csharp
public void Add<T>(System.Collections.Generic.IEnumerable<T?>? values);
```
#### Type parameters

<a name='DiGi.Core.IO.Classes.Report.Add_T_(System.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of elements in the collection\.
#### Parameters

<a name='DiGi.Core.IO.Classes.Report.Add_T_(System.Collections.Generic.IEnumerable_T_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.Report.Add_T_(System.Collections.Generic.IEnumerable_T_).T 'DiGi\.Core\.IO\.Classes\.Report\.Add\<T\>\(System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of values to add to the report\.

<a name='DiGi.Core.IO.Classes.Report.Add_T_(T[])'></a>

## Report\.Add\<T\>\(T\[\]\) Method

Adds one or more values of type [T](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.Report.Add_T_(T[]).T 'DiGi\.Core\.IO\.Classes\.Report\.Add\<T\>\(T\[\]\)\.T') to the report\.

```csharp
public void Add<T>(params T?[]? values);
```
#### Type parameters

<a name='DiGi.Core.IO.Classes.Report.Add_T_(T[]).T'></a>

`T`

The type of values to add\.
#### Parameters

<a name='DiGi.Core.IO.Classes.Report.Add_T_(T[]).values'></a>

`values` [T](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.Report.Add_T_(T[]).T 'DiGi\.Core\.IO\.Classes\.Report\.Add\<T\>\(T\[\]\)\.T')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The values of type [T](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.Report.Add_T_(T[]).T 'DiGi\.Core\.IO\.Classes\.Report\.Add\<T\>\(T\[\]\)\.T') to add to the report\.

<a name='DiGi.Core.IO.Classes.Report.GetHashCode()'></a>

## Report\.GetHashCode\(\) Method

Returns the hash code for this instance\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The hash code for this instance\.

<a name='DiGi.Core.IO.Classes.Report.ToString()'></a>

## Report\.ToString\(\) Method

Returns a string representation of the current report\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string that represents the current report\.

<a name='DiGi.Core.IO.Classes.Report.Write(string)'></a>

## Report\.Write\(string\) Method

Writes the report content to the specified file path\.

```csharp
public bool Write(string? path);
```
#### Parameters

<a name='DiGi.Core.IO.Classes.Report.Write(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path where the report will be written\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the write operation was successful; otherwise, false\.