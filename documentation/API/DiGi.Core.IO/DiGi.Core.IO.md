#### [DiGi\.Core\.IO](index.md 'index')

## DiGi\.Core\.IO Namespace
### Classes

<a name='DiGi.Core.IO.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Core.IO.Create.Archive_TSerializableObject_(thisbyte[])'></a>

## Create\.Archive\<TSerializableObject\>\(this byte\[\]\) Method

Creates an archive from the specified byte array\.

```csharp
public static DiGi.Core.IO.Classes.Archive<TSerializableObject>? Archive<TSerializableObject>(this byte[] bytes)
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.IO.Create.Archive_TSerializableObject_(thisbyte[]).TSerializableObject'></a>

`TSerializableObject`

The type of the serializable object contained within the archive\.
#### Parameters

<a name='DiGi.Core.IO.Create.Archive_TSerializableObject_(thisbyte[]).bytes'></a>

`bytes` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The byte array to create the archive from\.

#### Returns
[DiGi\.Core\.IO\.Classes\.Archive&lt;](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.Archive_TSerializableObject_ 'DiGi\.Core\.IO\.Classes\.Archive\<TSerializableObject\>')[TSerializableObject](DiGi.Core.IO.md#DiGi.Core.IO.Create.Archive_TSerializableObject_(thisbyte[]).TSerializableObject 'DiGi\.Core\.IO\.Create\.Archive\<TSerializableObject\>\(this byte\[\]\)\.TSerializableObject')[&gt;](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.Archive_TSerializableObject_ 'DiGi\.Core\.IO\.Classes\.Archive\<TSerializableObject\>')  
An [Archive&lt;TSerializableObject&gt;](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.Archive_TSerializableObject_ 'DiGi\.Core\.IO\.Classes\.Archive\<TSerializableObject\>') instance if successful; otherwise, `null`\.

<a name='DiGi.Core.IO.Create.Archive_TSerializableObject_(thisbyte[],TSerializableObject)'></a>

## Create\.Archive\<TSerializableObject\>\(this byte\[\], TSerializableObject\) Method

Creates an archive from the specified byte array and extracts the associated serializable object\.

```csharp
public static DiGi.Core.IO.Interfaces.IArchive? Archive<TSerializableObject>(this byte[] bytes, out TSerializableObject? serializableObject)
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.IO.Create.Archive_TSerializableObject_(thisbyte[],TSerializableObject).TSerializableObject'></a>

`TSerializableObject`

The type of the serializable object to extract\.
#### Parameters

<a name='DiGi.Core.IO.Create.Archive_TSerializableObject_(thisbyte[],TSerializableObject).bytes'></a>

`bytes` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The byte array to create the archive from\.

<a name='DiGi.Core.IO.Create.Archive_TSerializableObject_(thisbyte[],TSerializableObject).serializableObject'></a>

`serializableObject` [TSerializableObject](DiGi.Core.IO.md#DiGi.Core.IO.Create.Archive_TSerializableObject_(thisbyte[],TSerializableObject).TSerializableObject 'DiGi\.Core\.IO\.Create\.Archive\<TSerializableObject\>\(this byte\[\], TSerializableObject\)\.TSerializableObject')

When this method returns, contains the extracted serializable object, or null if extraction failed\.

#### Returns
[DiGi\.Core\.IO\.Interfaces\.IArchive](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iarchive 'DiGi\.Core\.IO\.Interfaces\.IArchive')  
An [DiGi\.Core\.IO\.Interfaces\.IArchive](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iarchive 'DiGi\.Core\.IO\.Interfaces\.IArchive') instance if successful; otherwise, `null`\.

<a name='DiGi.Core.IO.Create.FileFilter(string,string[])'></a>

## Create\.FileFilter\(string, string\[\]\) Method

Creates a file filter with the specified name and allowed extensions\.

```csharp
public static DiGi.Core.IO.Classes.FileFilter FileFilter(string name, params string[] extensions);
```
#### Parameters

<a name='DiGi.Core.IO.Create.FileFilter(string,string[]).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The descriptive name of the filter\.

<a name='DiGi.Core.IO.Create.FileFilter(string,string[]).extensions'></a>

`extensions` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

An array of allowed file extensions\.

#### Returns
[FileFilter](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.FileFilter 'DiGi\.Core\.IO\.Classes\.FileFilter')  
A FileFilter configured with the specified name and extensions\.

<a name='DiGi.Core.IO.Create.FileFilter_AllFiles()'></a>

## Create\.FileFilter\_AllFiles\(\) Method

Creates a file filter that includes all files\.

```csharp
public static DiGi.Core.IO.Classes.FileFilter FileFilter_AllFiles();
```

#### Returns
[FileFilter](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.FileFilter 'DiGi\.Core\.IO\.Classes\.FileFilter')  
A FileFilter that matches all files\.

<a name='DiGi.Core.IO.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.Core.IO.Modify.UpdateLine(string,int,string)'></a>

## Modify\.UpdateLine\(string, int, string\) Method

Updates a specific line in the file at the given path\.

```csharp
public static bool UpdateLine(string? path, int index, string? line);
```
#### Parameters

<a name='DiGi.Core.IO.Modify.UpdateLine(string,int,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the file\.

<a name='DiGi.Core.IO.Modify.UpdateLine(string,int,string).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the line to update\.

<a name='DiGi.Core.IO.Modify.UpdateLine(string,int,string).line'></a>

`line` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The new content for the line\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the update was successful; otherwise, false\.

<a name='DiGi.Core.IO.Modify.UpdateLines(string,System.Collections.Generic.Dictionary_int,string_)'></a>

## Modify\.UpdateLines\(string, Dictionary\<int,string\>\) Method

Updates multiple lines in the file at the given path based on the provided dictionary of indices and content\.

```csharp
public static System.Collections.Generic.HashSet<int>? UpdateLines(string? path, System.Collections.Generic.Dictionary<int,string?>? lineDictionary);
```
#### Parameters

<a name='DiGi.Core.IO.Modify.UpdateLines(string,System.Collections.Generic.Dictionary_int,string_).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the file to be updated\.

<a name='DiGi.Core.IO.Modify.UpdateLines(string,System.Collections.Generic.Dictionary_int,string_).lineDictionary'></a>

`lineDictionary` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

A dictionary where keys are line indices and values are the new content for those lines\.

#### Returns
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')  
A [System\.Collections\.Generic\.HashSet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1') containing the indices of the lines that were successfully updated, or null if an error occurred\.

<a name='DiGi.Core.IO.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Core.IO.Query.AbsolutePath(thisstring,string)'></a>

## Query\.AbsolutePath\(this string, string\) Method

Combines a directory path and a relative path to create an absolute path\.

```csharp
public static string? AbsolutePath(this string? directory, string? relativePath);
```
#### Parameters

<a name='DiGi.Core.IO.Query.AbsolutePath(thisstring,string).directory'></a>

`directory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The base directory path\.

<a name='DiGi.Core.IO.Query.AbsolutePath(thisstring,string).relativePath'></a>

`relativePath` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The relative path to combine with the directory\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The resulting absolute path string\.

<a name='DiGi.Core.IO.Query.Deserialize_USerializableObject_(thisDiGi.Core.IO.Interfaces.IArchive)'></a>

## Query\.Deserialize\<USerializableObject\>\(this IArchive\) Method

Deserializes a USerializableObject from the specified archive\.

```csharp
public static USerializableObject? Deserialize<USerializableObject>(this DiGi.Core.IO.Interfaces.IArchive archive)
    where USerializableObject : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.Core.IO.Query.Deserialize_USerializableObject_(thisDiGi.Core.IO.Interfaces.IArchive).USerializableObject'></a>

`USerializableObject`

The type of object to deserialize\.
#### Parameters

<a name='DiGi.Core.IO.Query.Deserialize_USerializableObject_(thisDiGi.Core.IO.Interfaces.IArchive).archive'></a>

`archive` [DiGi\.Core\.IO\.Interfaces\.IArchive](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iarchive 'DiGi\.Core\.IO\.Interfaces\.IArchive')

The archive to deserialize from\.

#### Returns
[USerializableObject](DiGi.Core.IO.md#DiGi.Core.IO.Query.Deserialize_USerializableObject_(thisDiGi.Core.IO.Interfaces.IArchive).USerializableObject 'DiGi\.Core\.IO\.Query\.Deserialize\<USerializableObject\>\(this DiGi\.Core\.IO\.Interfaces\.IArchive\)\.USerializableObject')  
The deserialized USerializableObject, or null if deserialization fails\.

<a name='DiGi.Core.IO.Query.Filter(DiGi.Core.IO.Classes.FileFilter[])'></a>

## Query\.Filter\(FileFilter\[\]\) Method

Joins multiple file filters into a pipe\-separated string\.

```csharp
public static string? Filter(params DiGi.Core.IO.Classes.FileFilter[]? fileFilters);
```
#### Parameters

<a name='DiGi.Core.IO.Query.Filter(DiGi.Core.IO.Classes.FileFilter[]).fileFilters'></a>

`fileFilters` [FileFilter](DiGi.Core.IO.Classes.md#DiGi.Core.IO.Classes.FileFilter 'DiGi\.Core\.IO\.Classes\.FileFilter')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The array of file filters to be joined\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A pipe\-separated string containing the combined filters, or null if no filters are provided\.

<a name='DiGi.Core.IO.Query.IsPathFullyQualified(string)'></a>

## Query\.IsPathFullyQualified\(string\) Method

Checks if a path is fully qualified \(absolute\)\.

```csharp
public static bool IsPathFullyQualified(string? path);
```
#### Parameters

<a name='DiGi.Core.IO.Query.IsPathFullyQualified(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the path is fully qualified; otherwise, false\.

<a name='DiGi.Core.IO.Query.Lines(string,int)'></a>

## Query\.Lines\(string, int\) Method

Reads a specified number of lines from a file\.

```csharp
public static System.Collections.Generic.List<string>? Lines(string? path, int count);
```
#### Parameters

<a name='DiGi.Core.IO.Query.Lines(string,int).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the file to read\.

<a name='DiGi.Core.IO.Query.Lines(string,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of lines to read from the file\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of strings containing the lines read, or null if the operation fails\.

<a name='DiGi.Core.IO.Query.Locked(thisSystem.IO.FileInfo)'></a>

## Query\.Locked\(this FileInfo\) Method

Checks if a file is locked by another process\.

```csharp
public static bool Locked(this System.IO.FileInfo? fileInfo);
```
#### Parameters

<a name='DiGi.Core.IO.Query.Locked(thisSystem.IO.FileInfo).fileInfo'></a>

`fileInfo` [System\.IO\.FileInfo](https://learn.microsoft.com/en-us/dotnet/api/system.io.fileinfo 'System\.IO\.FileInfo')

The file information of the file to check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the file is locked; otherwise, false\.

<a name='DiGi.Core.IO.Query.RelativePath(string,string)'></a>

## Query\.RelativePath\(string, string\) Method

Calculates the relative path from one directory to another\.

```csharp
public static string? RelativePath(string? relativeTo, string? path);
```
#### Parameters

<a name='DiGi.Core.IO.Query.RelativePath(string,string).relativeTo'></a>

`relativeTo` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The base directory to calculate the relative path from\.

<a name='DiGi.Core.IO.Query.RelativePath(string,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The target path to make relative\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The calculated relative path, or null if it cannot be determined\.

<a name='DiGi.Core.IO.Query.Serialize(thisDiGi.Core.Interfaces.ISerializableObject)'></a>

## Query\.Serialize\(this ISerializableObject\) Method

Serializes an ISerializableObject into an IArchive\.

```csharp
public static DiGi.Core.IO.Interfaces.IArchive? Serialize(this DiGi.Core.Interfaces.ISerializableObject serializableObject);
```
#### Parameters

<a name='DiGi.Core.IO.Query.Serialize(thisDiGi.Core.Interfaces.ISerializableObject).serializableObject'></a>

`serializableObject` [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The object to be serialized\.

#### Returns
[DiGi\.Core\.IO\.Interfaces\.IArchive](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iarchive 'DiGi\.Core\.IO\.Interfaces\.IArchive')  
An [DiGi\.Core\.IO\.Interfaces\.IArchive](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iarchive 'DiGi\.Core\.IO\.Interfaces\.IArchive') containing the serialized data, or `null` if serialization fails\.