#### [DiGi\.Core\.IO](DiGi.Core.IO.Overview.md 'DiGi\.Core\.IO\.Overview')

## DiGi\.Core\.IO\.DelimitedData Namespace
### Classes

<a name='DiGi.Core.IO.DelimitedData.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Core.IO.DelimitedData.Create.Columns(thisSystem.Collections.Generic.IEnumerable_string_)'></a>

## Create\.Columns\(this IEnumerable\<string\>\) Method

Creates a list of columns from string names\.

```csharp
public static System.Collections.Generic.List<DiGi.Core.IO.Table.Classes.Column>? Columns(this System.Collections.Generic.IEnumerable<string>? names);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Create.Columns(thisSystem.Collections.Generic.IEnumerable_string_).names'></a>

`names` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of column names to convert\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column') objects, or null if the input is null\.

<a name='DiGi.Core.IO.DelimitedData.Create.Table(string,char,int,int)'></a>

## Create\.Table\(string, char, int, int\) Method

Creates a Table from a delimited file using a separator character\.

```csharp
public static DiGi.Core.IO.Table.Classes.Table? Table(string? path, char separator, int columnIndex=0, int rowIndex=1);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Create.Table(string,char,int,int).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the delimited file\.

<a name='DiGi.Core.IO.DelimitedData.Create.Table(string,char,int,int).separator'></a>

`separator` [System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')

The character used as a separator in the delimited file\.

<a name='DiGi.Core.IO.DelimitedData.Create.Table(string,char,int,int).columnIndex'></a>

`columnIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the column to start from\. Defaults to 0\.

<a name='DiGi.Core.IO.DelimitedData.Create.Table(string,char,int,int).rowIndex'></a>

`rowIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the row to start from\. Defaults to 1\.

#### Returns
[Table](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table 'DiGi\.Core\.IO\.Table\.Classes\.Table')  
A Table object if successful; otherwise, null\.

<a name='DiGi.Core.IO.DelimitedData.Create.Table(string,DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,int,int)'></a>

## Create\.Table\(string, DelimitedDataSeparator, int, int\) Method

Creates a Table from a delimited file using a DelimitedDataSeparator enum value\.

```csharp
public static DiGi.Core.IO.Table.Classes.Table? Table(string? path, DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator delimitedDataSeparator, int columnIndex=0, int rowIndex=1);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Create.Table(string,DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,int,int).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the delimited file\.

<a name='DiGi.Core.IO.DelimitedData.Create.Table(string,DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,int,int).delimitedDataSeparator'></a>

`delimitedDataSeparator` [DelimitedDataSeparator](DiGi.Core.IO.DelimitedData.Enums.md#DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator 'DiGi\.Core\.IO\.DelimitedData\.Enums\.DelimitedDataSeparator')

The separator used in the delimited file\.

<a name='DiGi.Core.IO.DelimitedData.Create.Table(string,DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,int,int).columnIndex'></a>

`columnIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the column to start from\. Defaults to 0\.

<a name='DiGi.Core.IO.DelimitedData.Create.Table(string,DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,int,int).rowIndex'></a>

`rowIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the row to start from\. Defaults to 1\.

#### Returns
[Table](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table 'DiGi\.Core\.IO\.Table\.Classes\.Table')  
A Table object if successful; otherwise, null\.

<a name='DiGi.Core.IO.DelimitedData.Create.Table(thisDiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataReader,int,int)'></a>

## Create\.Table\(this IDelimitedDataReader, int, int\) Method

Converts DelimitedDataReader to Table

```csharp
public static DiGi.Core.IO.Table.Classes.Table? Table(this DiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataReader? delimitedDataReader, int columnIndex=0, int rowIndex=1);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Create.Table(thisDiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataReader,int,int).delimitedDataReader'></a>

`delimitedDataReader` [IDelimitedDataReader](DiGi.Core.IO.DelimitedData.Interfaces.md#DiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataReader 'DiGi\.Core\.IO\.DelimitedData\.Interfaces\.IDelimitedDataReader')

DelimitedDataReader

<a name='DiGi.Core.IO.DelimitedData.Create.Table(thisDiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataReader,int,int).columnIndex'></a>

`columnIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

Header index \(column names\)\. If data has no header then set to \-1

<a name='DiGi.Core.IO.DelimitedData.Create.Table(thisDiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataReader,int,int).rowIndex'></a>

`rowIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

Row Index where data starts

#### Returns
[Table](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table 'DiGi\.Core\.IO\.Table\.Classes\.Table')

<a name='DiGi.Core.IO.DelimitedData.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.Core.IO.DelimitedData.Modify.Append(string,DiGi.Core.IO.Table.Classes.Table,char,System.Func_object,string_)'></a>

## Modify\.Append\(string, Table, char, Func\<object,string\>\) Method

Appends a table's data to a delimited file\.

```csharp
public static bool Append(string? path, DiGi.Core.IO.Table.Classes.Table? table, char separator, System.Func<object?,string?>? func=null);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Modify.Append(string,DiGi.Core.IO.Table.Classes.Table,char,System.Func_object,string_).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the delimited file\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Append(string,DiGi.Core.IO.Table.Classes.Table,char,System.Func_object,string_).table'></a>

`table` [Table](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table 'DiGi\.Core\.IO\.Table\.Classes\.Table')

The table containing the data to append\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Append(string,DiGi.Core.IO.Table.Classes.Table,char,System.Func_object,string_).separator'></a>

`separator` [System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')

The character used as a separator in the delimited file\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Append(string,DiGi.Core.IO.Table.Classes.Table,char,System.Func_object,string_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional function to convert objects to strings\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the operation was successful; otherwise, false\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Read(thisDiGi.Core.IO.Table.Classes.Table,DiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataReader,int,int)'></a>

## Modify\.Read\(this Table, IDelimitedDataReader, int, int\) Method

Reads delimited data from a reader into a table\.

```csharp
public static bool Read(this DiGi.Core.IO.Table.Classes.Table? table, DiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataReader? delimitedDataReader, int columnIndex=0, int rowIndex=1);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Modify.Read(thisDiGi.Core.IO.Table.Classes.Table,DiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataReader,int,int).table'></a>

`table` [Table](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table 'DiGi\.Core\.IO\.Table\.Classes\.Table')

The table to read the data into\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Read(thisDiGi.Core.IO.Table.Classes.Table,DiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataReader,int,int).delimitedDataReader'></a>

`delimitedDataReader` [IDelimitedDataReader](DiGi.Core.IO.DelimitedData.Interfaces.md#DiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataReader 'DiGi\.Core\.IO\.DelimitedData\.Interfaces\.IDelimitedDataReader')

The reader used to read the delimited data\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Read(thisDiGi.Core.IO.Table.Classes.Table,DiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataReader,int,int).columnIndex'></a>

`columnIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the column to start reading from\. Defaults to 0\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Read(thisDiGi.Core.IO.Table.Classes.Table,DiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataReader,int,int).rowIndex'></a>

`rowIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the row to start reading from\. Defaults to 1\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the data was read successfully; otherwise, false\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Read(thisDiGi.Core.IO.Table.Classes.Table,string,char,int,int)'></a>

## Modify\.Read\(this Table, string, char, int, int\) Method

Reads delimited data from a file using a separator character into a table\.

```csharp
public static bool Read(this DiGi.Core.IO.Table.Classes.Table? table, string? path, char separator, int columnIndex=0, int rowIndex=1);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Modify.Read(thisDiGi.Core.IO.Table.Classes.Table,string,char,int,int).table'></a>

`table` [Table](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table 'DiGi\.Core\.IO\.Table\.Classes\.Table')

The table to read the data into\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Read(thisDiGi.Core.IO.Table.Classes.Table,string,char,int,int).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the file containing the delimited data\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Read(thisDiGi.Core.IO.Table.Classes.Table,string,char,int,int).separator'></a>

`separator` [System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')

The character used as a separator in the delimited data file\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Read(thisDiGi.Core.IO.Table.Classes.Table,string,char,int,int).columnIndex'></a>

`columnIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the column to start reading from\. Defaults to 0\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Read(thisDiGi.Core.IO.Table.Classes.Table,string,char,int,int).rowIndex'></a>

`rowIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the row to start reading from\. Defaults to 1\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the data was read successfully; otherwise, false\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Read(thisDiGi.Core.IO.Table.Classes.Table,string,DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,int,int)'></a>

## Modify\.Read\(this Table, string, DelimitedDataSeparator, int, int\) Method

Reads delimited data from a file using a DelimitedDataSeparator enum into a table\.

```csharp
public static bool Read(this DiGi.Core.IO.Table.Classes.Table? table, string? path, DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator delimitedDataSeparator, int columnIndex=0, int rowIndex=1);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Modify.Read(thisDiGi.Core.IO.Table.Classes.Table,string,DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,int,int).table'></a>

`table` [Table](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table 'DiGi\.Core\.IO\.Table\.Classes\.Table')

The table to read the data into\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Read(thisDiGi.Core.IO.Table.Classes.Table,string,DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,int,int).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the file containing the delimited data\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Read(thisDiGi.Core.IO.Table.Classes.Table,string,DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,int,int).delimitedDataSeparator'></a>

`delimitedDataSeparator` [DelimitedDataSeparator](DiGi.Core.IO.DelimitedData.Enums.md#DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator 'DiGi\.Core\.IO\.DelimitedData\.Enums\.DelimitedDataSeparator')

The separator used in the delimited data file\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Read(thisDiGi.Core.IO.Table.Classes.Table,string,DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,int,int).columnIndex'></a>

`columnIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the column to start reading from\. Defaults to 0\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Read(thisDiGi.Core.IO.Table.Classes.Table,string,DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,int,int).rowIndex'></a>

`rowIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the row to start reading from\. Defaults to 1\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the data was read successfully; otherwise, false\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Write(thisDiGi.Core.IO.Table.Classes.Table,DiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataWriter,System.Func_object,string_)'></a>

## Modify\.Write\(this Table, IDelimitedDataWriter, Func\<object,string\>\) Method

Writes a table to a delimited data writer\.

```csharp
public static bool Write(this DiGi.Core.IO.Table.Classes.Table? table, DiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataWriter? delimitedDataWriter, System.Func<object?,string?>? func=null);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Modify.Write(thisDiGi.Core.IO.Table.Classes.Table,DiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataWriter,System.Func_object,string_).table'></a>

`table` [Table](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table 'DiGi\.Core\.IO\.Table\.Classes\.Table')

The table to write\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Write(thisDiGi.Core.IO.Table.Classes.Table,DiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataWriter,System.Func_object,string_).delimitedDataWriter'></a>

`delimitedDataWriter` [IDelimitedDataWriter](DiGi.Core.IO.DelimitedData.Interfaces.md#DiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataWriter 'DiGi\.Core\.IO\.DelimitedData\.Interfaces\.IDelimitedDataWriter')

The delimited data writer to use\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Write(thisDiGi.Core.IO.Table.Classes.Table,DiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataWriter,System.Func_object,string_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional function to convert objects to strings\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the write operation was successful; otherwise, false\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Write(thisDiGi.Core.IO.Table.Classes.Table,string,char,System.Func_object,string_)'></a>

## Modify\.Write\(this Table, string, char, Func\<object,string\>\) Method

Writes a table to a delimited file using a separator character\.

```csharp
public static bool Write(this DiGi.Core.IO.Table.Classes.Table? table, string? path, char separator, System.Func<object?,string?>? func=null);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Modify.Write(thisDiGi.Core.IO.Table.Classes.Table,string,char,System.Func_object,string_).table'></a>

`table` [Table](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table 'DiGi\.Core\.IO\.Table\.Classes\.Table')

The table to write\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Write(thisDiGi.Core.IO.Table.Classes.Table,string,char,System.Func_object,string_).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path where the file will be written\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Write(thisDiGi.Core.IO.Table.Classes.Table,string,char,System.Func_object,string_).separator'></a>

`separator` [System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')

The character to use as a separator\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Write(thisDiGi.Core.IO.Table.Classes.Table,string,char,System.Func_object,string_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional function to convert objects to strings\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the write operation was successful; otherwise, false\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Write(thisDiGi.Core.IO.Table.Classes.Table,string,DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,System.Func_object,string_)'></a>

## Modify\.Write\(this Table, string, DelimitedDataSeparator, Func\<object,string\>\) Method

Writes a table to a delimited file using a DelimitedDataSeparator enum\.

```csharp
public static bool Write(this DiGi.Core.IO.Table.Classes.Table? table, string? path, DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator delimitedDataSeparator, System.Func<object?,string?>? func=null);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Modify.Write(thisDiGi.Core.IO.Table.Classes.Table,string,DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,System.Func_object,string_).table'></a>

`table` [Table](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table 'DiGi\.Core\.IO\.Table\.Classes\.Table')

The table to write\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Write(thisDiGi.Core.IO.Table.Classes.Table,string,DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,System.Func_object,string_).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path where the file will be written\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Write(thisDiGi.Core.IO.Table.Classes.Table,string,DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,System.Func_object,string_).delimitedDataSeparator'></a>

`delimitedDataSeparator` [DelimitedDataSeparator](DiGi.Core.IO.DelimitedData.Enums.md#DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator 'DiGi\.Core\.IO\.DelimitedData\.Enums\.DelimitedDataSeparator')

The separator to use for the delimited data\.

<a name='DiGi.Core.IO.DelimitedData.Modify.Write(thisDiGi.Core.IO.Table.Classes.Table,string,DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,System.Func_object,string_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional function to convert objects to strings\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the write operation was successful; otherwise, false\.

<a name='DiGi.Core.IO.DelimitedData.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Core.IO.DelimitedData.Query.Separator(thisDiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator)'></a>

## Query\.Separator\(this DelimitedDataSeparator\) Method

Gets the character value of a DelimitedDataSeparator enum member\.

```csharp
public static char Separator(this DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator delimitedDataSeparator);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Query.Separator(thisDiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator).delimitedDataSeparator'></a>

`delimitedDataSeparator` [DelimitedDataSeparator](DiGi.Core.IO.DelimitedData.Enums.md#DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator 'DiGi\.Core\.IO\.DelimitedData\.Enums\.DelimitedDataSeparator')

The delimited data separator to get the character value for\.

#### Returns
[System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')  
The character representation of the specified delimiter\.

<a name='DiGi.Core.IO.DelimitedData.Query.Text(thisSystem.Collections.Generic.IEnumerable_string_,char)'></a>

## Query\.Text\(this IEnumerable\<string\>, char\) Method

Joins a collection of values into a delimited string\.

```csharp
public static string? Text(this System.Collections.Generic.IEnumerable<string?>? values, char separator);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Query.Text(thisSystem.Collections.Generic.IEnumerable_string_,char).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of strings to join\.

<a name='DiGi.Core.IO.DelimitedData.Query.Text(thisSystem.Collections.Generic.IEnumerable_string_,char).separator'></a>

`separator` [System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')

The character used as the delimiter between strings\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string containing the joined values, or null if the input is null\.

<a name='DiGi.Core.IO.DelimitedData.Query.Values(thisstring,char,System.Func_string_)'></a>

## Query\.Values\(this string, char, Func\<string\>\) Method

Parses a delimited line into individual values\.

```csharp
public static System.Collections.Generic.List<string>? Values(this string? line, char separator, System.Func<string>? nextLine=null);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Query.Values(thisstring,char,System.Func_string_).line'></a>

`line` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The string to be parsed\.

<a name='DiGi.Core.IO.DelimitedData.Query.Values(thisstring,char,System.Func_string_).separator'></a>

`separator` [System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')

The character used as the delimiter\.

<a name='DiGi.Core.IO.DelimitedData.Query.Values(thisstring,char,System.Func_string_).nextLine'></a>

`nextLine` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-1 'System\.Func\`1')

An optional function to retrieve the next line if needed for multi\-line parsing\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of strings containing the parsed values, or null if the input line is null\.