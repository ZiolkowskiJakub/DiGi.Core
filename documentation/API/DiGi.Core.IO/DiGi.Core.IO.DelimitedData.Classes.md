#### [DiGi\.Core\.IO](DiGi.Core.IO.Overview.md 'DiGi\.Core\.IO\.Overview')

## DiGi\.Core\.IO\.DelimitedData\.Classes Namespace
### Classes

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader'></a>

## DelimitedDataReader Class

Reader for delimited data files\.

```csharp
public class DelimitedDataReader : System.IO.StreamReader, DiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataReader
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.MarshalByRefObject](https://learn.microsoft.com/en-us/dotnet/api/system.marshalbyrefobject 'System\.MarshalByRefObject') → [System\.IO\.TextReader](https://learn.microsoft.com/en-us/dotnet/api/system.io.textreader 'System\.IO\.TextReader') → [System\.IO\.StreamReader](https://learn.microsoft.com/en-us/dotnet/api/system.io.streamreader 'System\.IO\.StreamReader') → DelimitedDataReader

Implements [IDelimitedDataReader](DiGi.Core.IO.DelimitedData.Interfaces.md#DiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataReader 'DiGi\.Core\.IO\.DelimitedData\.Interfaces\.IDelimitedDataReader')
### Constructors

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.DelimitedDataReader(char,string)'></a>

## DelimitedDataReader\(char, string\) Constructor

Initializes a new instance of the [DelimitedDataReader](DiGi.Core.IO.DelimitedData.Classes.md#DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader 'DiGi\.Core\.IO\.DelimitedData\.Classes\.DelimitedDataReader') class\.

```csharp
public DelimitedDataReader(char separator, string path);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.DelimitedDataReader(char,string).separator'></a>

`separator` [System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')

The character to use as the separator\.

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.DelimitedDataReader(char,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the file containing the delimited data\.

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.DelimitedDataReader(char,System.Collections.Generic.IEnumerable_string_)'></a>

## DelimitedDataReader\(char, IEnumerable\<string\>\) Constructor

Initializes a new instance of the [DelimitedDataReader](DiGi.Core.IO.DelimitedData.Classes.md#DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader 'DiGi\.Core\.IO\.DelimitedData\.Classes\.DelimitedDataReader') class\.

```csharp
public DelimitedDataReader(char separator, System.Collections.Generic.IEnumerable<string> lines);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.DelimitedDataReader(char,System.Collections.Generic.IEnumerable_string_).separator'></a>

`separator` [System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')

The character to use as the separator\.

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.DelimitedDataReader(char,System.Collections.Generic.IEnumerable_string_).lines'></a>

`lines` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of lines containing the delimited data\.

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.DelimitedDataReader(char,System.IO.Stream)'></a>

## DelimitedDataReader\(char, Stream\) Constructor

Initializes a new instance of the [DelimitedDataReader](DiGi.Core.IO.DelimitedData.Classes.md#DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader 'DiGi\.Core\.IO\.DelimitedData\.Classes\.DelimitedDataReader') class\.

```csharp
public DelimitedDataReader(char separator, System.IO.Stream stream);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.DelimitedDataReader(char,System.IO.Stream).separator'></a>

`separator` [System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')

The character used as a separator\.

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.DelimitedDataReader(char,System.IO.Stream).stream'></a>

`stream` [System\.IO\.Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream 'System\.IO\.Stream')

The stream to read from\.

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.DelimitedDataReader(DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,string)'></a>

## DelimitedDataReader\(DelimitedDataSeparator, string\) Constructor

Initializes a new instance of the [DelimitedDataReader](DiGi.Core.IO.DelimitedData.Classes.md#DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader 'DiGi\.Core\.IO\.DelimitedData\.Classes\.DelimitedDataReader') class\.

```csharp
public DelimitedDataReader(DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator delimitedDataSeparator, string path);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.DelimitedDataReader(DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,string).delimitedDataSeparator'></a>

`delimitedDataSeparator` [DelimitedDataSeparator](DiGi.Core.IO.DelimitedData.Enums.md#DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator 'DiGi\.Core\.IO\.DelimitedData\.Enums\.DelimitedDataSeparator')

The separator to use for delimited data\.

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.DelimitedDataReader(DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the file containing the delimited data\.

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.DelimitedDataReader(DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,string,System.Text.Encoding)'></a>

## DelimitedDataReader\(DelimitedDataSeparator, string, Encoding\) Constructor

Initializes a new instance of the [DelimitedDataReader](DiGi.Core.IO.DelimitedData.Classes.md#DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader 'DiGi\.Core\.IO\.DelimitedData\.Classes\.DelimitedDataReader') class\.

```csharp
public DelimitedDataReader(DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator delimitedDataSeparator, string path, System.Text.Encoding encoding);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.DelimitedDataReader(DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,string,System.Text.Encoding).delimitedDataSeparator'></a>

`delimitedDataSeparator` [DelimitedDataSeparator](DiGi.Core.IO.DelimitedData.Enums.md#DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator 'DiGi\.Core\.IO\.DelimitedData\.Enums\.DelimitedDataSeparator')

The separator to use for delimited data\.

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.DelimitedDataReader(DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,string,System.Text.Encoding).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the file containing the delimited data\.

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.DelimitedDataReader(DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,string,System.Text.Encoding).encoding'></a>

`encoding` [System\.Text\.Encoding](https://learn.microsoft.com/en-us/dotnet/api/system.text.encoding 'System\.Text\.Encoding')

The encoding to use when reading the file\.

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.DelimitedDataReader(DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,System.Collections.Generic.IEnumerable_string_)'></a>

## DelimitedDataReader\(DelimitedDataSeparator, IEnumerable\<string\>\) Constructor

Initializes a new instance of the [DelimitedDataReader](DiGi.Core.IO.DelimitedData.Classes.md#DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader 'DiGi\.Core\.IO\.DelimitedData\.Classes\.DelimitedDataReader') class\.

```csharp
public DelimitedDataReader(DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator delimitedDataSeparator, System.Collections.Generic.IEnumerable<string> lines);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.DelimitedDataReader(DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,System.Collections.Generic.IEnumerable_string_).delimitedDataSeparator'></a>

`delimitedDataSeparator` [DelimitedDataSeparator](DiGi.Core.IO.DelimitedData.Enums.md#DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator 'DiGi\.Core\.IO\.DelimitedData\.Enums\.DelimitedDataSeparator')

The separator to use for delimited data\.

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.DelimitedDataReader(DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,System.Collections.Generic.IEnumerable_string_).lines'></a>

`lines` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of lines containing the delimited data\.
### Properties

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.Separator'></a>

## DelimitedDataReader\.Separator Property

Gets the character used as a separator in the delimited data file\.

```csharp
public char Separator { get; }
```

Implements [Separator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.delimiteddata.interfaces.idelimiteddatareader.separator 'DiGi\.Core\.IO\.DelimitedData\.Interfaces\.IDelimitedDataReader\.Separator')

#### Property Value
[System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')
### Methods

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.ReadRow()'></a>

## DelimitedDataReader\.ReadRow\(\) Method

Reads a row of data from a CSV file

```csharp
public DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow? ReadRow();
```

Implements [ReadRow\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.delimiteddata.interfaces.idelimiteddatareader.readrow 'DiGi\.Core\.IO\.DelimitedData\.Interfaces\.IDelimitedDataReader\.ReadRow')

#### Returns
[DelimitedDataRow](DiGi.Core.IO.DelimitedData.Classes.md#DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow 'DiGi\.Core\.IO\.DelimitedData\.Classes\.DelimitedDataRow')  
DelimitedDataRow

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataReader.ReadRows()'></a>

## DelimitedDataReader\.ReadRows\(\) Method

Reads a rows of data from a CSV file

```csharp
public System.Collections.Generic.List<DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow> ReadRows();
```

Implements [ReadRows\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.delimiteddata.interfaces.idelimiteddatareader.readrows 'DiGi\.Core\.IO\.DelimitedData\.Interfaces\.IDelimitedDataReader\.ReadRows')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DelimitedDataRow](DiGi.Core.IO.DelimitedData.Classes.md#DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow 'DiGi\.Core\.IO\.DelimitedData\.Classes\.DelimitedDataRow')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
List of the rows

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow'></a>

## DelimitedDataRow Class

Class to store one delimited file row

```csharp
public class DelimitedDataRow : System.Collections.Generic.List<string>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') → DelimitedDataRow
### Constructors

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow.DelimitedDataRow()'></a>

## DelimitedDataRow\(\) Constructor

Initializes a new instance of the [DelimitedDataRow](DiGi.Core.IO.DelimitedData.Classes.md#DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow 'DiGi\.Core\.IO\.DelimitedData\.Classes\.DelimitedDataRow') class\.

```csharp
public DelimitedDataRow();
```

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow.DelimitedDataRow(System.Collections.Generic.IEnumerable_string_)'></a>

## DelimitedDataRow\(IEnumerable\<string\>\) Constructor

Initializes a new instance of the [DelimitedDataRow](DiGi.Core.IO.DelimitedData.Classes.md#DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow 'DiGi\.Core\.IO\.DelimitedData\.Classes\.DelimitedDataRow') class\.

```csharp
public DelimitedDataRow(System.Collections.Generic.IEnumerable<string>? values);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow.DelimitedDataRow(System.Collections.Generic.IEnumerable_string_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of string values to initialize the row with\.
### Methods

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow.TryGetValue_T_(int,T)'></a>

## DelimitedDataRow\.TryGetValue\<T\>\(int, T\) Method

Tries to get the value at the specified index as a specific type\.

```csharp
public bool TryGetValue<T>(int index, out T? value);
```
#### Type parameters

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow.TryGetValue_T_(int,T).T'></a>

`T`

The type of the value to retrieve\.
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow.TryGetValue_T_(int,T).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the element to get\.

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow.TryGetValue_T_(int,T).value'></a>

`value` [T](DiGi.Core.IO.DelimitedData.Classes.md#DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow.TryGetValue_T_(int,T).T 'DiGi\.Core\.IO\.DelimitedData\.Classes\.DelimitedDataRow\.TryGetValue\<T\>\(int, T\)\.T')

When this method returns, contains the value at the specified index if the operation was successful; otherwise, the default value for the type of the element\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the element is successfully retrieved; otherwise, false\.

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataWriter'></a>

## DelimitedDataWriter Class

Writer for delimited data files\.

```csharp
public class DelimitedDataWriter : System.IO.StreamWriter, DiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataWriter
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.MarshalByRefObject](https://learn.microsoft.com/en-us/dotnet/api/system.marshalbyrefobject 'System\.MarshalByRefObject') → [System\.IO\.TextWriter](https://learn.microsoft.com/en-us/dotnet/api/system.io.textwriter 'System\.IO\.TextWriter') → [System\.IO\.StreamWriter](https://learn.microsoft.com/en-us/dotnet/api/system.io.streamwriter 'System\.IO\.StreamWriter') → DelimitedDataWriter

Implements [IDelimitedDataWriter](DiGi.Core.IO.DelimitedData.Interfaces.md#DiGi.Core.IO.DelimitedData.Interfaces.IDelimitedDataWriter 'DiGi\.Core\.IO\.DelimitedData\.Interfaces\.IDelimitedDataWriter')
### Constructors

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataWriter.DelimitedDataWriter(char,string)'></a>

## DelimitedDataWriter\(char, string\) Constructor

Initializes a new instance of the [DelimitedDataWriter](DiGi.Core.IO.DelimitedData.Classes.md#DiGi.Core.IO.DelimitedData.Classes.DelimitedDataWriter 'DiGi\.Core\.IO\.DelimitedData\.Classes\.DelimitedDataWriter') class\.

```csharp
public DelimitedDataWriter(char separator, string path);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataWriter.DelimitedDataWriter(char,string).separator'></a>

`separator` [System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')

The character to use as a separator\.

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataWriter.DelimitedDataWriter(char,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the file where data will be written\.

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataWriter.DelimitedDataWriter(char,System.IO.Stream)'></a>

## DelimitedDataWriter\(char, Stream\) Constructor

Initializes a new instance of the [DelimitedDataWriter](DiGi.Core.IO.DelimitedData.Classes.md#DiGi.Core.IO.DelimitedData.Classes.DelimitedDataWriter 'DiGi\.Core\.IO\.DelimitedData\.Classes\.DelimitedDataWriter') class\.

```csharp
public DelimitedDataWriter(char separator, System.IO.Stream stream);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataWriter.DelimitedDataWriter(char,System.IO.Stream).separator'></a>

`separator` [System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')

The character to use as a separator\.

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataWriter.DelimitedDataWriter(char,System.IO.Stream).stream'></a>

`stream` [System\.IO\.Stream](https://learn.microsoft.com/en-us/dotnet/api/system.io.stream 'System\.IO\.Stream')

The stream where data will be written\.

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataWriter.DelimitedDataWriter(DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,string)'></a>

## DelimitedDataWriter\(DelimitedDataSeparator, string\) Constructor

Initializes a new instance of the [DelimitedDataWriter](DiGi.Core.IO.DelimitedData.Classes.md#DiGi.Core.IO.DelimitedData.Classes.DelimitedDataWriter 'DiGi\.Core\.IO\.DelimitedData\.Classes\.DelimitedDataWriter') class\.

```csharp
public DelimitedDataWriter(DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator delimitedDataSeparator, string path);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataWriter.DelimitedDataWriter(DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,string).delimitedDataSeparator'></a>

`delimitedDataSeparator` [DelimitedDataSeparator](DiGi.Core.IO.DelimitedData.Enums.md#DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator 'DiGi\.Core\.IO\.DelimitedData\.Enums\.DelimitedDataSeparator')

The separator to use for delimited data\.

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataWriter.DelimitedDataWriter(DiGi.Core.IO.DelimitedData.Enums.DelimitedDataSeparator,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the file where data will be written\.
### Properties

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataWriter.Separator'></a>

## DelimitedDataWriter\.Separator Property

Gets the character used as a separator in the delimited data file\.

```csharp
public char Separator { get; }
```

Implements [Separator](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.delimiteddata.interfaces.idelimiteddatawriter.separator 'DiGi\.Core\.IO\.DelimitedData\.Interfaces\.IDelimitedDataWriter\.Separator')

#### Property Value
[System\.Char](https://learn.microsoft.com/en-us/dotnet/api/system.char 'System\.Char')
### Methods

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataWriter.WriteRow(DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow)'></a>

## DelimitedDataWriter\.WriteRow\(DelimitedDataRow\) Method

Writes a single row to a CSV file\.

```csharp
public void WriteRow(DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow? delimitedDataRow);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataWriter.WriteRow(DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow).delimitedDataRow'></a>

`delimitedDataRow` [DelimitedDataRow](DiGi.Core.IO.DelimitedData.Classes.md#DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow 'DiGi\.Core\.IO\.DelimitedData\.Classes\.DelimitedDataRow')

The row to be written

Implements [WriteRow\(DelimitedDataRow\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.delimiteddata.interfaces.idelimiteddatawriter.writerow#digi-core-io-delimiteddata-interfaces-idelimiteddatawriter-writerow(digi-core-io-delimiteddata-classes-delimiteddatarow) 'DiGi\.Core\.IO\.DelimitedData\.Interfaces\.IDelimitedDataWriter\.WriteRow\(DiGi\.Core\.IO\.DelimitedData\.Classes\.DelimitedDataRow\)')

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataWriter.WriteRows(System.Collections.Generic.IEnumerable_DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow_)'></a>

## DelimitedDataWriter\.WriteRows\(IEnumerable\<DelimitedDataRow\>\) Method

Writes a rows to a CSV file\.

```csharp
public void WriteRows(System.Collections.Generic.IEnumerable<DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow>? delimitedDataRows);
```
#### Parameters

<a name='DiGi.Core.IO.DelimitedData.Classes.DelimitedDataWriter.WriteRows(System.Collections.Generic.IEnumerable_DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow_).delimitedDataRows'></a>

`delimitedDataRows` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DelimitedDataRow](DiGi.Core.IO.DelimitedData.Classes.md#DiGi.Core.IO.DelimitedData.Classes.DelimitedDataRow 'DiGi\.Core\.IO\.DelimitedData\.Classes\.DelimitedDataRow')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The rows to be written

Implements [WriteRows\(IEnumerable&lt;DelimitedDataRow&gt;\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.delimiteddata.interfaces.idelimiteddatawriter.writerows#digi-core-io-delimiteddata-interfaces-idelimiteddatawriter-writerows(system-collections-generic-ienumerable{digi-core-io-delimiteddata-classes-delimiteddatarow}) 'DiGi\.Core\.IO\.DelimitedData\.Interfaces\.IDelimitedDataWriter\.WriteRows\(System\.Collections\.Generic\.IEnumerable\{DiGi\.Core\.IO\.DelimitedData\.Classes\.DelimitedDataRow\}\)')