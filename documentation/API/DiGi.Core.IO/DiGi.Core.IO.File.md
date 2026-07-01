#### [DiGi\.Core\.IO](index.md 'index')

## DiGi\.Core\.IO\.File Namespace
### Classes

<a name='DiGi.Core.IO.File.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Core.IO.File.Query.Decode(string)'></a>

## Query\.Decode\(string\) Method

Decodes the specified string into a [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')\.

```csharp
public static DiGi.Core.Classes.UniqueReference? Decode(string? text);
```
#### Parameters

<a name='DiGi.Core.IO.File.Query.Decode(string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string to decode\.

#### Returns
[DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')  
The decoded [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference'), or `null` if the decoding process fails\.

<a name='DiGi.Core.IO.File.Query.Encode(string)'></a>

## Query\.Encode\(string\) Method

Encodes the specified string for use as a reference\.

```csharp
public static string? Encode(string? text);
```
#### Parameters

<a name='DiGi.Core.IO.File.Query.Encode(string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string to encode\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The encoded string, or null if the input is null\.

<a name='DiGi.Core.IO.File.Query.Encode(thisDiGi.Core.Classes.UniqueReference)'></a>

## Query\.Encode\(this UniqueReference\) Method

Encodes the specified [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference') into its string representation\.

```csharp
public static string? Encode(this DiGi.Core.Classes.UniqueReference? uniqueReference);
```
#### Parameters

<a name='DiGi.Core.IO.File.Query.Encode(thisDiGi.Core.Classes.UniqueReference).uniqueReference'></a>

`uniqueReference` [DiGi\.Core\.Classes\.UniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniquereference 'DiGi\.Core\.Classes\.UniqueReference')

The unique reference to encode\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The encoded string representation of the unique reference, or null if the input is null\.

<a name='DiGi.Core.IO.File.Query.TryGetEncoding(string,System.Text.Encoding)'></a>

## Query\.TryGetEncoding\(string, Encoding\) Method

Attempts to determine the text encoding of the specified file\.

```csharp
public static bool TryGetEncoding(string? filePath, out System.Text.Encoding? encoding);
```
#### Parameters

<a name='DiGi.Core.IO.File.Query.TryGetEncoding(string,System.Text.Encoding).filePath'></a>

`filePath` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the file\.

<a name='DiGi.Core.IO.File.Query.TryGetEncoding(string,System.Text.Encoding).encoding'></a>

`encoding` [System\.Text\.Encoding](https://learn.microsoft.com/en-us/dotnet/api/system.text.encoding 'System\.Text\.Encoding')

When this method returns, contains the encoding of the specified file if successful; otherwise, null\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the encoding was successfully determined; otherwise, false\.