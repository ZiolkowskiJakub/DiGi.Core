#### [DiGi\.Core\.IO](index.md 'index')

## DiGi\.Core\.IO\.Table\.Classes Namespace
### Classes

<a name='DiGi.Core.IO.Table.Classes.Column'></a>

## Column Class

Represents a column in a table, defining its index, name, and data type\.

```csharp
public class Column : DiGi.Core.Classes.SerializableObject, DiGi.Core.IO.Table.Interfaces.IColumn, DiGi.Core.IO.Table.Interfaces.ITableSerializableObject, DiGi.Core.IO.Table.Interfaces.ITableObject, DiGi.Core.IO.Interfaces.IIOObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.INamedObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Column

Derived  
↳ [ExtendedColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.ExtendedColumn 'DiGi\.Core\.IO\.Table\.Classes\.ExtendedColumn')

Implements [IColumn](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IColumn 'DiGi\.Core\.IO\.Table\.Interfaces\.IColumn'), [ITableSerializableObject](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITableSerializableObject 'DiGi\.Core\.IO\.Table\.Interfaces\.ITableSerializableObject'), [ITableObject](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITableObject 'DiGi\.Core\.IO\.Table\.Interfaces\.ITableObject'), [DiGi\.Core\.IO\.Interfaces\.IIOObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iioobject 'DiGi\.Core\.IO\.Interfaces\.IIOObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject')
### Constructors

<a name='DiGi.Core.IO.Table.Classes.Column.Column(DiGi.Core.IO.Table.Classes.Column)'></a>

## Column\(Column\) Constructor

Initializes a new instance of the [Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column') class by copying another column\.

```csharp
public Column(DiGi.Core.IO.Table.Classes.Column? column);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Column.Column(DiGi.Core.IO.Table.Classes.Column).column'></a>

`column` [Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column')

The source column to copy from\.

<a name='DiGi.Core.IO.Table.Classes.Column.Column(int)'></a>

## Column\(int\) Constructor

Initializes a new instance of the [Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column') class with a specified index\.

```csharp
public Column(int index);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Column.Column(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

<a name='DiGi.Core.IO.Table.Classes.Column.Column(int,DiGi.Core.IO.Table.Classes.Column)'></a>

## Column\(int, Column\) Constructor

Initializes a new instance of the [Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column') class with a specified index and values copied from another column\.

```csharp
public Column(int index, DiGi.Core.IO.Table.Classes.Column? column);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Column.Column(int,DiGi.Core.IO.Table.Classes.Column).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

<a name='DiGi.Core.IO.Table.Classes.Column.Column(int,DiGi.Core.IO.Table.Classes.Column).column'></a>

`column` [Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column')

The source column to copy properties from\.

<a name='DiGi.Core.IO.Table.Classes.Column.Column(int,string,System.Type)'></a>

## Column\(int, string, Type\) Constructor

Initializes a new instance of the [Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column') class with a specified index, name, and type\.

```csharp
public Column(int index, string? name, System.Type? type);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Column.Column(int,string,System.Type).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

<a name='DiGi.Core.IO.Table.Classes.Column.Column(int,string,System.Type).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the column\.

<a name='DiGi.Core.IO.Table.Classes.Column.Column(int,string,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The data type of the column\.

<a name='DiGi.Core.IO.Table.Classes.Column.Column(int,System.Type)'></a>

## Column\(int, Type\) Constructor

Initializes a new instance of the [Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column') class with a specified index and type\.

```csharp
public Column(int index, System.Type? type);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Column.Column(int,System.Type).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

<a name='DiGi.Core.IO.Table.Classes.Column.Column(int,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The data type of the column\.

<a name='DiGi.Core.IO.Table.Classes.Column.Column(string,System.Type)'></a>

## Column\(string, Type\) Constructor

Initializes a new instance of the [Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column') class with a specified name and type\.

```csharp
public Column(string? name, System.Type? type);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Column.Column(string,System.Type).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the column\.

<a name='DiGi.Core.IO.Table.Classes.Column.Column(string,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The data type of the column\.

<a name='DiGi.Core.IO.Table.Classes.Column.Column(System.Text.Json.Nodes.JsonObject)'></a>

## Column\(JsonObject\) Constructor

Initializes a new instance of the [Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column') class from a JSON object\.

```csharp
public Column(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Column.Column(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing column data\.
### Properties

<a name='DiGi.Core.IO.Table.Classes.Column.Index'></a>

## Column\.Index Property

Gets or sets the zero\-based index of the column\.

```csharp
public int Index { get; set; }
```

Implements [Index](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IColumn.Index 'DiGi\.Core\.IO\.Table\.Interfaces\.IColumn\.Index')

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.IO.Table.Classes.Column.Name'></a>

## Column\.Name Property

Gets the name of the column\.

```csharp
public string? Name { get; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.IO.Table.Classes.Column.Type'></a>

## Column\.Type Property

Gets the data type of the column\.

```csharp
public System.Type? Type { get; }
```

Implements [Type](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IColumn.Type 'DiGi\.Core\.IO\.Table\.Interfaces\.IColumn\.Type')

#### Property Value
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')
### Methods

<a name='DiGi.Core.IO.Table.Classes.Column.TryGetValidValue(object,object,bool)'></a>

## Column\.TryGetValidValue\(object, object, bool\) Method

Attempts to get a valid value for the column from the provided input, optionally attempting conversion\.

```csharp
public bool TryGetValidValue(object? @in, out object? @out, bool tryConvert=true);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Column.TryGetValidValue(object,object,bool).in'></a>

`in` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The input object to validate or convert\.

<a name='DiGi.Core.IO.Table.Classes.Column.TryGetValidValue(object,object,bool).out'></a>

`out` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the validated or converted value if successful; otherwise, null\.

<a name='DiGi.Core.IO.Table.Classes.Column.TryGetValidValue(object,object,bool).tryConvert'></a>

`tryConvert` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to attempt conversion if the type is not directly assignable\. Defaults to true\.

Implements [TryGetValidValue\(object, object, bool\)](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IColumn.TryGetValidValue(object,object,bool) 'DiGi\.Core\.IO\.Table\.Interfaces\.IColumn\.TryGetValidValue\(object, object, bool\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a valid value was obtained; otherwise, false\.

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn'></a>

## ExtendedColumn Class

Represents an extended column in a table with additional metadata such as category and description\.

```csharp
public class ExtendedColumn : DiGi.Core.IO.Table.Classes.Column, DiGi.Core.IO.Table.Interfaces.IExtendedColumn, DiGi.Core.IO.Table.Interfaces.IColumn, DiGi.Core.IO.Table.Interfaces.ITableSerializableObject, DiGi.Core.IO.Table.Interfaces.ITableObject, DiGi.Core.IO.Interfaces.IIOObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.INamedObject, DiGi.Core.Interfaces.IDescribableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column') → ExtendedColumn

Implements [IExtendedColumn](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IExtendedColumn 'DiGi\.Core\.IO\.Table\.Interfaces\.IExtendedColumn'), [IColumn](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IColumn 'DiGi\.Core\.IO\.Table\.Interfaces\.IColumn'), [ITableSerializableObject](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITableSerializableObject 'DiGi\.Core\.IO\.Table\.Interfaces\.ITableSerializableObject'), [ITableObject](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITableObject 'DiGi\.Core\.IO\.Table\.Interfaces\.ITableObject'), [DiGi\.Core\.IO\.Interfaces\.IIOObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iioobject 'DiGi\.Core\.IO\.Interfaces\.IIOObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Core\.Interfaces\.IDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject 'DiGi\.Core\.Interfaces\.IDescribableObject')
### Constructors

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(DiGi.Core.IO.Table.Classes.ExtendedColumn)'></a>

## ExtendedColumn\(ExtendedColumn\) Constructor

Initializes a new instance of the [ExtendedColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.ExtendedColumn 'DiGi\.Core\.IO\.Table\.Classes\.ExtendedColumn') class by copying another extended column\.

```csharp
public ExtendedColumn(DiGi.Core.IO.Table.Classes.ExtendedColumn? extendedColumn);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(DiGi.Core.IO.Table.Classes.ExtendedColumn).extendedColumn'></a>

`extendedColumn` [ExtendedColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.ExtendedColumn 'DiGi\.Core\.IO\.Table\.Classes\.ExtendedColumn')

The source extended column to copy from\.

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(int)'></a>

## ExtendedColumn\(int\) Constructor

Initializes a new instance of the [ExtendedColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.ExtendedColumn 'DiGi\.Core\.IO\.Table\.Classes\.ExtendedColumn') class with a specified index\.

```csharp
public ExtendedColumn(int index);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(int,DiGi.Core.IO.Table.Classes.ExtendedColumn)'></a>

## ExtendedColumn\(int, ExtendedColumn\) Constructor

Initializes a new instance of the [ExtendedColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.ExtendedColumn 'DiGi\.Core\.IO\.Table\.Classes\.ExtendedColumn') class with a specified index and values copied from another extended column\.

```csharp
public ExtendedColumn(int index, DiGi.Core.IO.Table.Classes.ExtendedColumn? extendedColumn);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(int,DiGi.Core.IO.Table.Classes.ExtendedColumn).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(int,DiGi.Core.IO.Table.Classes.ExtendedColumn).extendedColumn'></a>

`extendedColumn` [ExtendedColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.ExtendedColumn 'DiGi\.Core\.IO\.Table\.Classes\.ExtendedColumn')

The source extended column to copy properties from\.

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(int,string,System.Type)'></a>

## ExtendedColumn\(int, string, Type\) Constructor

Initializes a new instance of the [ExtendedColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.ExtendedColumn 'DiGi\.Core\.IO\.Table\.Classes\.ExtendedColumn') class with a specified index, name, and type\.

```csharp
public ExtendedColumn(int index, string? name, System.Type? type);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(int,string,System.Type).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(int,string,System.Type).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the column\.

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(int,string,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The data type of the column\.

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(int,System.Type)'></a>

## ExtendedColumn\(int, Type\) Constructor

Initializes a new instance of the [ExtendedColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.ExtendedColumn 'DiGi\.Core\.IO\.Table\.Classes\.ExtendedColumn') class with a specified index and type\.

```csharp
public ExtendedColumn(int index, System.Type? type);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(int,System.Type).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(int,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The data type of the column\.

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(string,System.Type)'></a>

## ExtendedColumn\(string, Type\) Constructor

Initializes a new instance of the [ExtendedColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.ExtendedColumn 'DiGi\.Core\.IO\.Table\.Classes\.ExtendedColumn') class with a specified name and type\.

```csharp
public ExtendedColumn(string? name, System.Type? type);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(string,System.Type).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the column\.

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(string,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The data type of the column\.

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(string,System.Type,string,string)'></a>

## ExtendedColumn\(string, Type, string, string\) Constructor

Initializes a new instance of the [ExtendedColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.ExtendedColumn 'DiGi\.Core\.IO\.Table\.Classes\.ExtendedColumn') class with specified metadata\.

```csharp
public ExtendedColumn(string? name, System.Type? type, string? category, string? description);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(string,System.Type,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the column\.

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(string,System.Type,string,string).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The data type of the column\.

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(string,System.Type,string,string).category'></a>

`category` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The category of the column\.

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(string,System.Type,string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

A description of the column's purpose\.

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(System.Text.Json.Nodes.JsonObject)'></a>

## ExtendedColumn\(JsonObject\) Constructor

Initializes a new instance of the [ExtendedColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.ExtendedColumn 'DiGi\.Core\.IO\.Table\.Classes\.ExtendedColumn') class from a JSON object\.

```csharp
public ExtendedColumn(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.ExtendedColumn(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing column data\.
### Properties

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.Category'></a>

## ExtendedColumn\.Category Property

Gets or sets the category of the column\.

```csharp
public string? Category { get; set; }
```

Implements [Category](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IExtendedColumn.Category 'DiGi\.Core\.IO\.Table\.Interfaces\.IExtendedColumn\.Category')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.IO.Table.Classes.ExtendedColumn.Description'></a>

## ExtendedColumn\.Description Property

Gets or sets a description for the column\.

```csharp
public string? Description { get; set; }
```

Implements [Description](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject.description 'DiGi\.Core\.Interfaces\.IDescribableObject\.Description')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.IO.Table.Classes.Row'></a>

## Row Class

Represents a concrete implementation of a table row\.

```csharp
public sealed class Row : DiGi.Core.IO.Table.Classes.Row<DiGi.Core.IO.Table.Classes.Row>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.IO\.Table\.Classes\.Row&lt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row_TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Row\<TRow\>')[Row](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row 'DiGi\.Core\.IO\.Table\.Classes\.Row')[&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row_TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Row\<TRow\>') → Row
### Constructors

<a name='DiGi.Core.IO.Table.Classes.Row.Row(DiGi.Core.IO.Table.Classes.Row)'></a>

## Row\(Row\) Constructor

Initializes a new instance of the [Row](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row 'DiGi\.Core\.IO\.Table\.Classes\.Row') class by copying another row\.

```csharp
public Row(DiGi.Core.IO.Table.Classes.Row row);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Row.Row(DiGi.Core.IO.Table.Classes.Row).row'></a>

`row` [Row](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row 'DiGi\.Core\.IO\.Table\.Classes\.Row')

The source row to copy from\.

<a name='DiGi.Core.IO.Table.Classes.Row.Row(int)'></a>

## Row\(int\) Constructor

Initializes a new instance of the [Row](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row 'DiGi\.Core\.IO\.Table\.Classes\.Row') class with a specified index\.

```csharp
public Row(int index);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Row.Row(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row\.

<a name='DiGi.Core.IO.Table.Classes.Row.Row(int,System.Collections.Generic.IDictionary_int,object_)'></a>

## Row\(int, IDictionary\<int,object\>\) Constructor

Initializes a new instance of the [Row](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row 'DiGi\.Core\.IO\.Table\.Classes\.Row') class with a specified index and initial values\.

```csharp
public Row(int index, System.Collections.Generic.IDictionary<int,object?>? values);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Row.Row(int,System.Collections.Generic.IDictionary_int,object_).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row\.

<a name='DiGi.Core.IO.Table.Classes.Row.Row(int,System.Collections.Generic.IDictionary_int,object_).values'></a>

`values` [System\.Collections\.Generic\.IDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')

A dictionary containing column indices and their corresponding values\.
### Methods

<a name='DiGi.Core.IO.Table.Classes.Row.Clone()'></a>

## Row\.Clone\(\) Method

Creates a shallow copy of the current row\.

```csharp
public override DiGi.Core.IO.Table.Classes.Row? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[Row](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row 'DiGi\.Core\.IO\.Table\.Classes\.Row')  
A new instance of the row with copied values\.

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_'></a>

## Row\<TRow\> Class

Represents a base row in a table, providing functionality to manage column values by index\.

```csharp
public abstract class Row<TRow> : DiGi.Core.IO.Table.Interfaces.IRow<TRow>, DiGi.Core.IO.Table.Interfaces.IRow, DiGi.Core.IO.Table.Interfaces.ITableObject, DiGi.Core.IO.Interfaces.IIOObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ICloneableObject<TRow>, DiGi.Core.Interfaces.ICloneableObject
    where TRow : DiGi.Core.IO.Table.Classes.Row<TRow>
```
#### Type parameters

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.TRow'></a>

`TRow`

The type of the row\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Row\<TRow\>

Derived  
↳ [Row](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row 'DiGi\.Core\.IO\.Table\.Classes\.Row')

Implements [DiGi\.Core\.IO\.Table\.Interfaces\.IRow&lt;](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IRow_TRow_ 'DiGi\.Core\.IO\.Table\.Interfaces\.IRow\<TRow\>')[TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row_TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Row\<TRow\>\.TRow')[&gt;](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IRow_TRow_ 'DiGi\.Core\.IO\.Table\.Interfaces\.IRow\<TRow\>'), [IRow](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IRow 'DiGi\.Core\.IO\.Table\.Interfaces\.IRow'), [ITableObject](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITableObject 'DiGi\.Core\.IO\.Table\.Interfaces\.ITableObject'), [DiGi\.Core\.IO\.Interfaces\.IIOObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iioobject 'DiGi\.Core\.IO\.Interfaces\.IIOObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row_TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Row\<TRow\>\.TRow')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.Row(DiGi.Core.IO.Table.Classes.Row)'></a>

## Row\(Row\) Constructor

Initializes a new instance of the [Row&lt;TRow&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row_TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Row\<TRow\>') class by copying another row\.

```csharp
public Row(DiGi.Core.IO.Table.Classes.Row? row);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.Row(DiGi.Core.IO.Table.Classes.Row).row'></a>

`row` [Row](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row 'DiGi\.Core\.IO\.Table\.Classes\.Row')

The source row to copy from\.

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.Row(int)'></a>

## Row\(int\) Constructor

Initializes a new instance of the [Row&lt;TRow&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row_TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Row\<TRow\>') class with a specified index\.

```csharp
public Row(int index);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.Row(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row\.

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.Row(int,DiGi.Core.IO.Table.Classes.Row)'></a>

## Row\(int, Row\) Constructor

Initializes a new instance of the [Row&lt;TRow&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row_TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Row\<TRow\>') class with a specified index and values copied from another row\.

```csharp
public Row(int index, DiGi.Core.IO.Table.Classes.Row? row);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.Row(int,DiGi.Core.IO.Table.Classes.Row).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row\.

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.Row(int,DiGi.Core.IO.Table.Classes.Row).row'></a>

`row` [Row](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row 'DiGi\.Core\.IO\.Table\.Classes\.Row')

The source row to copy properties from\.

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.Row(int,System.Collections.Generic.IDictionary_int,object_)'></a>

## Row\(int, IDictionary\<int,object\>\) Constructor

Initializes a new instance of the [Row&lt;TRow&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row_TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Row\<TRow\>') class with a specified index and initial values\.

```csharp
public Row(int index, System.Collections.Generic.IDictionary<int,object?>? values);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.Row(int,System.Collections.Generic.IDictionary_int,object_).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row\.

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.Row(int,System.Collections.Generic.IDictionary_int,object_).values'></a>

`values` [System\.Collections\.Generic\.IDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')

A dictionary containing column indices and their corresponding values\.

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.Row(System.Collections.Generic.IDictionary_int,object_)'></a>

## Row\(IDictionary\<int,object\>\) Constructor

Initializes a new instance of the [Row&lt;TRow&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row_TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Row\<TRow\>') class with initial values\.

```csharp
public Row(System.Collections.Generic.IDictionary<int,object?>? values);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.Row(System.Collections.Generic.IDictionary_int,object_).values'></a>

`values` [System\.Collections\.Generic\.IDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')

A dictionary containing column indices and their corresponding values\.
### Properties

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.Count'></a>

## Row\<TRow\>\.Count Property

Gets the number of values currently stored in the row\.

```csharp
public int Count { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.Index'></a>

## Row\<TRow\>\.Index Property

Gets the zero\-based index of the row\.

```csharp
public int Index { get; }
```

Implements [Index](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IRow.Index 'DiGi\.Core\.IO\.Table\.Interfaces\.IRow\.Index')

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.Indexes'></a>

## Row\<TRow\>\.Indexes Property

Gets a set of all column indices that have values assigned in this row\.

```csharp
public System.Collections.Generic.HashSet<int> Indexes { get; }
```

Implements [Indexes](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IRow.Indexes 'DiGi\.Core\.IO\.Table\.Interfaces\.IRow\.Indexes')

#### Property Value
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.this[int]'></a>

## Row\<TRow\>\.this\[int\] Property

Gets or sets the value for the specified column index\.

```csharp
public object? this[int index] { get; set; }
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.this[int].index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

Implements [this\[int\]](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IRow.this[int] 'DiGi\.Core\.IO\.Table\.Interfaces\.IRow\.this\[int\]')

#### Property Value
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')
### Methods

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.Clone()'></a>

## Row\<TRow\>\.Clone\(\) Method

Creates a shallow copy of the current row\.

```csharp
public abstract TRow? Clone();
```

Implements [Clone\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1.clone 'DiGi\.Core\.Interfaces\.ICloneableObject\`1\.Clone')

#### Returns
[TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row_TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Row\<TRow\>\.TRow')  
A new instance of the row with copied values\.

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.GetValue_T_(int,T,bool)'></a>

## Row\<TRow\>\.GetValue\<T\>\(int, T, bool\) Method

Retrieves the value for the specified index, optionally converting it to the requested type\.

```csharp
public T? GetValue<T>(int index, T? defaultValue=default(T?), bool tryConvert=true);
```
#### Type parameters

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.GetValue_T_(int,T,bool).T'></a>

`T`

The target type of the value\.
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.GetValue_T_(int,T,bool).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.GetValue_T_(int,T,bool).defaultValue'></a>

`defaultValue` [T](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row_TRow_.GetValue_T_(int,T,bool).T 'DiGi\.Core\.IO\.Table\.Classes\.Row\<TRow\>\.GetValue\<T\>\(int, T, bool\)\.T')

The value to return if no value is found or conversion fails\.

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.GetValue_T_(int,T,bool).tryConvert'></a>

`tryConvert` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to attempt converting the value to type \<typeparam typeparamref="T" /\>\.

#### Returns
[T](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row_TRow_.GetValue_T_(int,T,bool).T 'DiGi\.Core\.IO\.Table\.Classes\.Row\<TRow\>\.GetValue\<T\>\(int, T, bool\)\.T')  
The value at the specified index converted to \<typeparam typeparamref="T" /\>, or the defaultValue\.

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.GetValues()'></a>

## Row\<TRow\>\.GetValues\(\) Method

Retrieves all values in the row as an array\.

```csharp
public object?[] GetValues();
```

Implements [GetValues\(\)](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IRow.GetValues() 'DiGi\.Core\.IO\.Table\.Interfaces\.IRow\.GetValues\(\)')

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of values where the array index corresponds to the column index\.

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.RemoveValue(int)'></a>

## Row\<TRow\>\.RemoveValue\(int\) Method

Removes the value for the specified index from the row\.

```csharp
public bool RemoveValue(int index);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.RemoveValue(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column to remove\.

Implements [RemoveValue\(int\)](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IRow.RemoveValue(int) 'DiGi\.Core\.IO\.Table\.Interfaces\.IRow\.RemoveValue\(int\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully removed; otherwise, false\.

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.TryGetValue_T_(int,T)'></a>

## Row\<TRow\>\.TryGetValue\<T\>\(int, T\) Method

Attempts to retrieve and convert the value for the specified index to the requested type\.

```csharp
public bool TryGetValue<T>(int index, out T? value);
```
#### Type parameters

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.TryGetValue_T_(int,T).T'></a>

`T`

The target type of the value\.
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.TryGetValue_T_(int,T).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

<a name='DiGi.Core.IO.Table.Classes.Row_TRow_.TryGetValue_T_(int,T).value'></a>

`value` [T](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row_TRow_.TryGetValue_T_(int,T).T 'DiGi\.Core\.IO\.Table\.Classes\.Row\<TRow\>\.TryGetValue\<T\>\(int, T\)\.T')

When this method returns, contains the value if retrieval and conversion succeeded; otherwise, the default value of [T](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row_TRow_.TryGetValue_T_(int,T).T 'DiGi\.Core\.IO\.Table\.Classes\.Row\<TRow\>\.TryGetValue\<T\>\(int, T\)\.T')\.

Implements [TryGetValue&lt;T&gt;\(int, T\)](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IRow.TryGetValue_T_(int,T) 'DiGi\.Core\.IO\.Table\.Interfaces\.IRow\.TryGetValue\<T\>\(int, T\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully retrieved and converted; otherwise, false\.

<a name='DiGi.Core.IO.Table.Classes.Table'></a>

## Table Class

Represents a standard table with default [Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column') and [Row](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row 'DiGi\.Core\.IO\.Table\.Classes\.Row') types\.

Behavior and Architecture:

1. Anemic Model Pattern: This class is designed as an anemic data model. It serves strictly as a structured data container holding columns of type [Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column') and rows of type [Row](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row 'DiGi\.Core\.IO\.Table\.Classes\.Row'), containing minimal internal logic.

2. Extension-Based Logic: All complex operations, queries, mutations, and business logic on this table are implemented as static extension methods in the static partial classes `Query`, `Modify`, and `Create`.

3. Sorted Indexing: Columns and rows are stored in sorted dictionaries keyed by their index. This guarantees that columns and rows are always ordered sequentially by their index.

4. Dynamic Shifting: Column removal operations shift all subsequent columns and their corresponding values in each row down by one index to maintain contiguous, zero-based column indexing.

5. Default Value Fallback: Accessing a cell via the indexer `this[rowIndex, columnIndex]` returns the default value for the column's type if the cell does not exist or has not been populated.

6. JSON Serialization: Designed for custom JSON serialization and deserialization using `TableConverter` which handles column schemas and row value arrays.

```csharp
public class Table : DiGi.Core.IO.Table.Classes.Table<DiGi.Core.IO.Table.Classes.Column>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.IO\.Table\.Classes\.Table&lt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>')[Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column')[,](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>')[Row](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row 'DiGi\.Core\.IO\.Table\.Classes\.Row')[&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>') → [DiGi\.Core\.IO\.Table\.Classes\.Table&lt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn_ 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn\>')[Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column')[&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn_ 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn\>') → Table
### Constructors

<a name='DiGi.Core.IO.Table.Classes.Table.Table()'></a>

## Table\(\) Constructor

Initializes a new instance of the [Table](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table 'DiGi\.Core\.IO\.Table\.Classes\.Table') class\.

```csharp
public Table();
```

<a name='DiGi.Core.IO.Table.Classes.Table.Table(System.Collections.Generic.IEnumerable_DiGi.Core.IO.Table.Classes.Column_)'></a>

## Table\(IEnumerable\<Column\>\) Constructor

Initializes a new instance of the [Table](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table 'DiGi\.Core\.IO\.Table\.Classes\.Table') class with specified columns\.

```csharp
public Table(System.Collections.Generic.IEnumerable<DiGi.Core.IO.Table.Classes.Column> columns);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table.Table(System.Collections.Generic.IEnumerable_DiGi.Core.IO.Table.Classes.Column_).columns'></a>

`columns` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of columns to add to the table\.
### Methods

<a name='DiGi.Core.IO.Table.Classes.Table.AddColumn()'></a>

## Table\.AddColumn\(\) Method

Adds a new column with default settings\.

```csharp
public DiGi.Core.IO.Table.Classes.Column? AddColumn();
```

#### Returns
[Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column')  
The added column, or null if addition failed\.

<a name='DiGi.Core.IO.Table.Classes.Table.AddColumn(string,System.Type)'></a>

## Table\.AddColumn\(string, Type\) Method

Adds a new column with the specified name and type\.

```csharp
public DiGi.Core.IO.Table.Classes.Column? AddColumn(string? name, System.Type? type=null);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table.AddColumn(string,System.Type).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the new column\.

<a name='DiGi.Core.IO.Table.Classes.Table.AddColumn(string,System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type of the new column\.

#### Returns
[Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column')  
The added column, or null if addition failed\.

<a name='DiGi.Core.IO.Table.Classes.Table.AddColumn(System.Type)'></a>

## Table\.AddColumn\(Type\) Method

Adds a new column with the specified type\.

```csharp
public DiGi.Core.IO.Table.Classes.Column? AddColumn(System.Type? type);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table.AddColumn(System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type of the new column\.

#### Returns
[Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column')  
The added column, or null if addition failed\.

<a name='DiGi.Core.IO.Table.Classes.Table.UpdateColumn(int,string,System.Type,bool)'></a>

## Table\.UpdateColumn\(int, string, Type, bool\) Method

Updates an existing column with a new name and type\.

```csharp
public DiGi.Core.IO.Table.Classes.Column? UpdateColumn(int index, string? name, System.Type? type=null, bool tryConvert=true);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table.UpdateColumn(int,string,System.Type,bool).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column to update\.

<a name='DiGi.Core.IO.Table.Classes.Table.UpdateColumn(int,string,System.Type,bool).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The new name for the column\.

<a name='DiGi.Core.IO.Table.Classes.Table.UpdateColumn(int,string,System.Type,bool).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The new type for the column\.

<a name='DiGi.Core.IO.Table.Classes.Table.UpdateColumn(int,string,System.Type,bool).tryConvert'></a>

`tryConvert` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to attempt conversion of existing row values to the new column type\.

#### Returns
[Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column')  
A clone of the updated column, or null if update failed\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_'></a>

## Table\<TColumn,TRow\> Class

Represents a base table structure with generic column and row types\.

Behavior and Architecture:

1. Anemic Model Pattern: This class is designed as an anemic data model. It serves strictly as a structured data container holding columns and rows, containing minimal internal logic.

2. Extension-Based Logic: All complex operations, queries, mutations, and business logic on this table are implemented as static extension methods in the static partial classes `Query`, `Modify`, and `Create`.

3. Sorted Indexing: Columns and rows are stored in sorted dictionaries keyed by their index. This guarantees that columns and rows are always ordered sequentially by their index.

4. Dynamic Shifting: Column removal operations (typically found in Modify extensions) shift all subsequent columns and their corresponding values in each row down by one index to maintain contiguous, zero-based column indexing.

5. Default Value Fallback: Accessing a cell via the indexer `this[rowIndex, columnIndex]` returns the default value for the column's type if the cell does not exist or has not been populated.

6. JSON Serialization: Designed for custom JSON serialization and deserialization using `TableConverter` which handles column schemas and row value arrays.

```csharp
public abstract class Table<TColumn,TRow> : DiGi.Core.IO.Table.Interfaces.ITable<TColumn, TRow>, DiGi.Core.IO.Table.Interfaces.ITable, DiGi.Core.IO.Table.Interfaces.ITableObject, DiGi.Core.IO.Interfaces.IIOObject, DiGi.Core.Interfaces.IObject, System.Collections.Generic.IEnumerable<TRow>, System.Collections.IEnumerable
    where TColumn : DiGi.Core.IO.Table.Interfaces.IColumn
    where TRow : DiGi.Core.IO.Table.Interfaces.IRow<TRow>
```
#### Type parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TColumn'></a>

`TColumn`

The type of the columns in the table\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow'></a>

`TRow`

The type of the rows in the table\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Table\<TColumn,TRow\>

Derived  
↳ [Table&lt;TColumn&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn_ 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn\>')

Implements [DiGi\.Core\.IO\.Table\.Interfaces\.ITable&lt;](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_ 'DiGi\.Core\.IO\.Table\.Interfaces\.ITable\<UColumn,URow\>')[TColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TColumn 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TColumn')[,](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_ 'DiGi\.Core\.IO\.Table\.Interfaces\.ITable\<UColumn,URow\>')[TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')[&gt;](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_ 'DiGi\.Core\.IO\.Table\.Interfaces\.ITable\<UColumn,URow\>'), [ITable](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITable 'DiGi\.Core\.IO\.Table\.Interfaces\.ITable'), [ITableObject](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITableObject 'DiGi\.Core\.IO\.Table\.Interfaces\.ITableObject'), [DiGi\.Core\.IO\.Interfaces\.IIOObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iioobject 'DiGi\.Core\.IO\.Interfaces\.IIOObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')
### Constructors

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.Table()'></a>

## Table\(\) Constructor

Initializes a new instance of the [Table&lt;TColumn,TRow&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>') class\.

```csharp
public Table();
```

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.Table(System.Collections.Generic.IEnumerable_TColumn_)'></a>

## Table\(IEnumerable\<TColumn\>\) Constructor

Initializes a new instance of the [Table&lt;TColumn,TRow&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>') class with specified columns\.

```csharp
public Table(System.Collections.Generic.IEnumerable<TColumn> columns);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.Table(System.Collections.Generic.IEnumerable_TColumn_).columns'></a>

`columns` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TColumn 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TColumn')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of columns to add to the table\.
### Properties

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.ColumnCount'></a>

## Table\<TColumn,TRow\>\.ColumnCount Property

Gets the number of columns in the table\.

```csharp
public int ColumnCount { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.Columns'></a>

## Table\<TColumn,TRow\>\.Columns Property

Gets the collection of columns in the table\.

```csharp
public System.Collections.Generic.IEnumerable<TColumn> Columns { get; }
```

Implements [Columns](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_.Columns 'DiGi\.Core\.IO\.Table\.Interfaces\.ITable\<UColumn,URow\>\.Columns')

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TColumn 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TColumn')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.RowCount'></a>

## Table\<TColumn,TRow\>\.RowCount Property

Gets the number of rows in the table\.

```csharp
public int RowCount { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.Rows'></a>

## Table\<TColumn,TRow\>\.Rows Property

Gets the collection of rows in the table\.

```csharp
public System.Collections.Generic.IEnumerable<TRow> Rows { get; }
```

Implements [Rows](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_.Rows 'DiGi\.Core\.IO\.Table\.Interfaces\.ITable\<UColumn,URow\>\.Rows')

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.this[int,int]'></a>

## Table\<TColumn,TRow\>\.this\[int, int\] Property

Gets or sets the value at the specified row and column indices\.

```csharp
public object? this[int rowIndex, int columnIndex] { get; }
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.this[int,int].rowIndex'></a>

`rowIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.this[int,int].columnIndex'></a>

`columnIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

#### Property Value
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.this[TRow,TColumn]'></a>

## Table\<TColumn,TRow\>\.this\[TRow, TColumn\] Property

Gets or sets the value for the specified row and column objects\.

```csharp
public object? this[TRow? row, TColumn? column] { get; }
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.this[TRow,TColumn].row'></a>

`row` [TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')

The row object\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.this[TRow,TColumn].column'></a>

`column` [TColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TColumn 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TColumn')

The column object\.

#### Property Value
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')
### Methods

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.AddColumn(TColumn)'></a>

## Table\<TColumn,TRow\>\.AddColumn\(TColumn\) Method

Adds a new column to the table\.

```csharp
public TColumn? AddColumn(TColumn? column);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.AddColumn(TColumn).column'></a>

`column` [TColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TColumn 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TColumn')

The column to add\.

Implements [AddColumn\(UColumn\)](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_.AddColumn(UColumn) 'DiGi\.Core\.IO\.Table\.Interfaces\.ITable\<UColumn,URow\>\.AddColumn\(UColumn\)')

#### Returns
[TColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TColumn 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TColumn')  
A clone of the added column with its index assigned, or null if addition failed\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.AddRow()'></a>

## Table\<TColumn,TRow\>\.AddRow\(\) Method

Adds a new row to the table with default values\.

```csharp
public TRow AddRow();
```

#### Returns
[TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')  
The newly created row\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.AddRow(System.Collections.Generic.IDictionary_int,object_)'></a>

## Table\<TColumn,TRow\>\.AddRow\(IDictionary\<int,object\>\) Method

Adds a new row to the table using column indices and values\.

```csharp
public TRow? AddRow(System.Collections.Generic.IDictionary<int,object?>? values);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.AddRow(System.Collections.Generic.IDictionary_int,object_).values'></a>

`values` [System\.Collections\.Generic\.IDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')

A dictionary of column indices and their corresponding values\.

#### Returns
[TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')  
The added row, or null if addition failed\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.AddRow(System.Collections.Generic.IDictionary_string,object_)'></a>

## Table\<TColumn,TRow\>\.AddRow\(IDictionary\<string,object\>\) Method

Adds a new row to the table using column names and values\.

```csharp
public TRow? AddRow(System.Collections.Generic.IDictionary<string,object?>? values);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.AddRow(System.Collections.Generic.IDictionary_string,object_).values'></a>

`values` [System\.Collections\.Generic\.IDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')

A dictionary of column names and their corresponding values\.

#### Returns
[TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')  
The added row, or null if addition failed\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.AddRow(System.Collections.Generic.IDictionary_string,object_,DiGi.Core.Enums.TextComparisonType,bool)'></a>

## Table\<TColumn,TRow\>\.AddRow\(IDictionary\<string,object\>, TextComparisonType, bool\) Method

Adds a new row to the table using column names and values, with specific text comparison settings\.

```csharp
public TRow? AddRow(System.Collections.Generic.IDictionary<string,object?> values, DiGi.Core.Enums.TextComparisonType textComparisonType, bool caseSensitive);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.AddRow(System.Collections.Generic.IDictionary_string,object_,DiGi.Core.Enums.TextComparisonType,bool).values'></a>

`values` [System\.Collections\.Generic\.IDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')

A dictionary of column names and their corresponding values\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.AddRow(System.Collections.Generic.IDictionary_string,object_,DiGi.Core.Enums.TextComparisonType,bool).textComparisonType'></a>

`textComparisonType` [DiGi\.Core\.Enums\.TextComparisonType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.textcomparisontype 'DiGi\.Core\.Enums\.TextComparisonType')

The type of text comparison to use for matching columns\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.AddRow(System.Collections.Generic.IDictionary_string,object_,DiGi.Core.Enums.TextComparisonType,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether the search should be case\-sensitive\.

#### Returns
[TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')  
The added row, or null if addition failed\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.AddRow(System.Collections.Generic.IDictionary_string,object_,System.Func_string,string,bool_)'></a>

## Table\<TColumn,TRow\>\.AddRow\(IDictionary\<string,object\>, Func\<string,string,bool\>\) Method

Adds a new row to the table using column names and values, with a custom column matching function\.

```csharp
public TRow? AddRow(System.Collections.Generic.IDictionary<string,object?>? values, System.Func<string?,string?,bool>? matchColumnFunc);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.AddRow(System.Collections.Generic.IDictionary_string,object_,System.Func_string,string,bool_).values'></a>

`values` [System\.Collections\.Generic\.IDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')

A dictionary of column names and their corresponding values\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.AddRow(System.Collections.Generic.IDictionary_string,object_,System.Func_string,string,bool_).matchColumnFunc'></a>

`matchColumnFunc` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')

A function to determine if a provided key matches a column name\.

#### Returns
[TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')  
The added row, or null if addition failed\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.AddRow(System.Collections.Generic.IEnumerable_object_)'></a>

## Table\<TColumn,TRow\>\.AddRow\(IEnumerable\<object\>\) Method

Adds a new row to the table using an ordered collection of values\.

```csharp
public TRow? AddRow(System.Collections.Generic.IEnumerable<object?>? values);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.AddRow(System.Collections.Generic.IEnumerable_object_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A sequence of values corresponding to columns in order\.

Implements [AddRow\(IEnumerable&lt;object&gt;\)](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_.AddRow(System.Collections.Generic.IEnumerable_object_) 'DiGi\.Core\.IO\.Table\.Interfaces\.ITable\<UColumn,URow\>\.AddRow\(System\.Collections\.Generic\.IEnumerable\<object\>\)')

#### Returns
[TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')  
The added row, or null if addition failed\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.AddRow(TRow,bool)'></a>

## Table\<TColumn,TRow\>\.AddRow\(TRow, bool\) Method

Adds a new row to the table based on an existing row object\.

```csharp
public TRow? AddRow(TRow? row, bool tryConvert=true);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.AddRow(TRow,bool).row'></a>

`row` [TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')

The source row\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.AddRow(TRow,bool).tryConvert'></a>

`tryConvert` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to attempt value conversion if types differ\.

#### Returns
[TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')  
A clone of the added row, or null if addition failed\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.Clear()'></a>

## Table\<TColumn,TRow\>\.Clear\(\) Method

Clears all rows and columns from the table\.

```csharp
public void Clear();
```

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.ClearRows()'></a>

## Table\<TColumn,TRow\>\.ClearRows\(\) Method

Clears all rows from the table, keeping the columns intact\.

```csharp
public void ClearRows();
```

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.CreateRow(int,System.Collections.Generic.IDictionary_int,object_)'></a>

## Table\<TColumn,TRow\>\.CreateRow\(int, IDictionary\<int,object\>\) Method

Creates a new row instance for the table\. Must be implemented by derived classes\.

```csharp
protected abstract TRow CreateRow(int index, System.Collections.Generic.IDictionary<int,object?>? values=null);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.CreateRow(int,System.Collections.Generic.IDictionary_int,object_).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index to assign to the new row\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.CreateRow(int,System.Collections.Generic.IDictionary_int,object_).values'></a>

`values` [System\.Collections\.Generic\.IDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')

Optional initial values for the row\.

#### Returns
[TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')  
A newly created row instance\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetColumn(int)'></a>

## Table\<TColumn,TRow\>\.GetColumn\(int\) Method

Gets a column by its index\.

```csharp
public TColumn? GetColumn(int index);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetColumn(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

#### Returns
[TColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TColumn 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TColumn')  
A clone of the column if found; otherwise, default\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetColumnIndex(string,DiGi.Core.Enums.TextComparisonType,bool)'></a>

## Table\<TColumn,TRow\>\.GetColumnIndex\(string, TextComparisonType, bool\) Method

Gets the index of a column based on its name and specific text comparison settings\.

```csharp
public int GetColumnIndex(string name, DiGi.Core.Enums.TextComparisonType textComparisonType, bool caseSensitive);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetColumnIndex(string,DiGi.Core.Enums.TextComparisonType,bool).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the column to search for\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetColumnIndex(string,DiGi.Core.Enums.TextComparisonType,bool).textComparisonType'></a>

`textComparisonType` [DiGi\.Core\.Enums\.TextComparisonType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.textcomparisontype 'DiGi\.Core\.Enums\.TextComparisonType')

The type of text comparison to use\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetColumnIndex(string,DiGi.Core.Enums.TextComparisonType,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether the search should be case\-sensitive\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The zero\-based index of the column, or \-1 if not found\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetColumnIndex(string,System.Func_string,string,bool_)'></a>

## Table\<TColumn,TRow\>\.GetColumnIndex\(string, Func\<string,string,bool\>\) Method

Gets the index of a column based on its name\.

```csharp
public int GetColumnIndex(string? name, System.Func<string?,string?,bool>? matchColumnFunc=null);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetColumnIndex(string,System.Func_string,string,bool_).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the column to search for\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetColumnIndex(string,System.Func_string,string,bool_).matchColumnFunc'></a>

`matchColumnFunc` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')

An optional custom function to match the name\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The zero\-based index of the column, or \-1 if not found\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetColumnValues(int)'></a>

## Table\<TColumn,TRow\>\.GetColumnValues\(int\) Method

Gets all values for a specific column index across all rows\.

```csharp
public object?[]? GetColumnValues(int columnIndex);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetColumnValues(int).columnIndex'></a>

`columnIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array containing the values of the specified column for each row\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetColumnValues(TColumn)'></a>

## Table\<TColumn,TRow\>\.GetColumnValues\(TColumn\) Method

Gets all values for a specific column across all rows\.

```csharp
public object?[]? GetColumnValues(TColumn? column);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetColumnValues(TColumn).column'></a>

`column` [TColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TColumn 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TColumn')

The column object\.

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array containing the values of the specified column for each row, or null if the column is null\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetEnumerator()'></a>

## Table\<TColumn,TRow\>\.GetEnumerator\(\) Method

Returns an enumerator that iterates through the rows of the table\.

```csharp
public System.Collections.Generic.IEnumerator<TRow> GetEnumerator();
```

Implements [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator 'System\.Collections\.Generic\.IEnumerable\`1\.GetEnumerator'), [GetEnumerator\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator 'System\.Collections\.IEnumerable\.GetEnumerator')

#### Returns
[System\.Collections\.Generic\.IEnumerator&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')[TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1 'System\.Collections\.Generic\.IEnumerator\`1')  
An enumerator for the rows\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetNextColumnIndex()'></a>

## Table\<TColumn,TRow\>\.GetNextColumnIndex\(\) Method

Gets the next available index for a column\.

```csharp
public int GetNextColumnIndex();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The next index, or \-1 if columns cannot be accessed\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetNextRowIndex()'></a>

## Table\<TColumn,TRow\>\.GetNextRowIndex\(\) Method

Gets the next available index for a row\.

```csharp
public int GetNextRowIndex();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The next index, or \-1 if rows cannot be accessed\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetRow(int)'></a>

## Table\<TColumn,TRow\>\.GetRow\(int\) Method

Gets a row by its index\.

```csharp
public TRow? GetRow(int index);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetRow(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row\.

#### Returns
[TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')  
A clone of the row if found; otherwise, default\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetValue(int,int)'></a>

## Table\<TColumn,TRow\>\.GetValue\(int, int\) Method

Gets the value at the specified row and column indices\.

```csharp
public object? GetValue(int rowIndex, int columnIndex);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetValue(int,int).rowIndex'></a>

`rowIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetValue(int,int).columnIndex'></a>

`columnIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')  
The value at the specified position\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetValue(TRow,TColumn)'></a>

## Table\<TColumn,TRow\>\.GetValue\(TRow, TColumn\) Method

Gets the value for the specified row and column objects\.

```csharp
public object? GetValue(TRow? row, TColumn? column);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetValue(TRow,TColumn).row'></a>

`row` [TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')

The row object\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetValue(TRow,TColumn).column'></a>

`column` [TColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TColumn 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TColumn')

The column object\.

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')  
The value at the intersection of the specified row and column\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetValue_T_(int,int)'></a>

## Table\<TColumn,TRow\>\.GetValue\<T\>\(int, int\) Method

Gets the value at the specified row and column indices, cast to the specified type\.

```csharp
public T? GetValue<T>(int rowIndex, int columnIndex);
```
#### Type parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetValue_T_(int,int).T'></a>

`T`

The expected type of the value\.
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetValue_T_(int,int).rowIndex'></a>

`rowIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetValue_T_(int,int).columnIndex'></a>

`columnIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

#### Returns
[T](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetValue_T_(int,int).T 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.GetValue\<T\>\(int, int\)\.T')  
The value cast to specified type, or default if not available or cast failed\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetValue_T_(TRow,TColumn)'></a>

## Table\<TColumn,TRow\>\.GetValue\<T\>\(TRow, TColumn\) Method

Gets the value for the specified row and column objects, cast to the specified type\.

```csharp
public T? GetValue<T>(TRow? row, TColumn? column);
```
#### Type parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetValue_T_(TRow,TColumn).T'></a>

`T`

The expected type of the value\.
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetValue_T_(TRow,TColumn).row'></a>

`row` [TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')

The row object\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetValue_T_(TRow,TColumn).column'></a>

`column` [TColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TColumn 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TColumn')

The column object\.

#### Returns
[T](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetValue_T_(TRow,TColumn).T 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.GetValue\<T\>\(TRow, TColumn\)\.T')  
The value cast to specified type, or default if not available or cast failed\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetValues()'></a>

## Table\<TColumn,TRow\>\.GetValues\(\) Method

Gets all values for all rows in the table\.

```csharp
public object?[]?[]? GetValues();
```

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
A jagged array containing all values of all rows\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetValues(int)'></a>

## Table\<TColumn,TRow\>\.GetValues\(int\) Method

Gets all values for the specified row index\.

```csharp
public object?[]? GetValues(int rowIndex);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.GetValues(int).rowIndex'></a>

`rowIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row\.

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array containing the values of the specified row, or null if the row is not found\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.RemoveColumn(int)'></a>

## Table\<TColumn,TRow\>\.RemoveColumn\(int\) Method

Removes a column at the specified index\.

```csharp
public bool RemoveColumn(int index);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.RemoveColumn(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the column was removed; otherwise, false\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.RemoveColumns(System.Collections.Generic.IEnumerable_int_)'></a>

## Table\<TColumn,TRow\>\.RemoveColumns\(IEnumerable\<int\>\) Method

Removes columns at the specified indices and shifts remaining columns to fill gaps\.

```csharp
public System.Collections.Generic.List<int>? RemoveColumns(System.Collections.Generic.IEnumerable<int>? indexes);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.RemoveColumns(System.Collections.Generic.IEnumerable_int_).indexes'></a>

`indexes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of zero\-based indices of the columns to remove\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of indices that were successfully removed, or null if input was null\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.RemoveRow(int)'></a>

## Table\<TColumn,TRow\>\.RemoveRow\(int\) Method

Removes a row at the specified index\.

```csharp
public bool RemoveRow(int index);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.RemoveRow(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the row was removed; otherwise, false\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.RemoveRows(System.Collections.Generic.IEnumerable_int_)'></a>

## Table\<TColumn,TRow\>\.RemoveRows\(IEnumerable\<int\>\) Method

Removes rows at the specified indices and shifts remaining rows to fill gaps\.

```csharp
public System.Collections.Generic.List<int>? RemoveRows(System.Collections.Generic.IEnumerable<int>? indexes);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.RemoveRows(System.Collections.Generic.IEnumerable_int_).indexes'></a>

`indexes` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of zero\-based indices of the rows to remove\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of indices that were successfully removed, or null if input was null\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.SetValue(int,int,object,bool)'></a>

## Table\<TColumn,TRow\>\.SetValue\(int, int, object, bool\) Method

Sets the value at the specified row and column indices\.

```csharp
public bool SetValue(int rowIndex, int columnIndex, object? value, bool tryConvert=true);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.SetValue(int,int,object,bool).rowIndex'></a>

`rowIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.SetValue(int,int,object,bool).columnIndex'></a>

`columnIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.SetValue(int,int,object,bool).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to set\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.SetValue(int,int,object,bool).tryConvert'></a>

`tryConvert` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to attempt conversion of the value to the column type\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully set; otherwise, false\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetColumn(string,TColumn,DiGi.Core.Enums.TextComparisonType,bool)'></a>

## Table\<TColumn,TRow\>\.TryGetColumn\(string, TColumn, TextComparisonType, bool\) Method

Attempts to get a column by its name\.

```csharp
public bool TryGetColumn(string? name, out TColumn? column, DiGi.Core.Enums.TextComparisonType textComparisonType=DiGi.Core.Enums.TextComparisonType.Equals, bool caseSensitive=true);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetColumn(string,TColumn,DiGi.Core.Enums.TextComparisonType,bool).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the column\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetColumn(string,TColumn,DiGi.Core.Enums.TextComparisonType,bool).column'></a>

`column` [TColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TColumn 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TColumn')

When this method returns, contains the column if found; otherwise, null\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetColumn(string,TColumn,DiGi.Core.Enums.TextComparisonType,bool).textComparisonType'></a>

`textComparisonType` [DiGi\.Core\.Enums\.TextComparisonType](https://learn.microsoft.com/en-us/dotnet/api/digi.core.enums.textcomparisontype 'DiGi\.Core\.Enums\.TextComparisonType')

The type of text comparison to use\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetColumn(string,TColumn,DiGi.Core.Enums.TextComparisonType,bool).caseSensitive'></a>

`caseSensitive` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether the search should be case\-sensitive\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the column was found; otherwise, false\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetValidValue(int,object,object,bool)'></a>

## Table\<TColumn,TRow\>\.TryGetValidValue\(int, object, object, bool\) Method

Attempts to get a valid value for the specified column index\.

```csharp
public bool TryGetValidValue(int columnIndex, object? @in, out object? @out, bool tryConvert=true);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetValidValue(int,object,object,bool).columnIndex'></a>

`columnIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetValidValue(int,object,object,bool).in'></a>

`in` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to validate/convert\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetValidValue(int,object,object,bool).out'></a>

`out` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

When this method returns, contains the validated/converted value if successful; otherwise, null\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetValidValue(int,object,object,bool).tryConvert'></a>

`tryConvert` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to attempt conversion of the value to the column type\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a valid value was obtained; otherwise, false\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetValue_T_(int,int,T)'></a>

## Table\<TColumn,TRow\>\.TryGetValue\<T\>\(int, int, T\) Method

Attempts to get a value from the specified row and column indices, cast to type T\.

```csharp
public bool TryGetValue<T>(int rowIndex, int columnIndex, out T? value);
```
#### Type parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetValue_T_(int,int,T).T'></a>

`T`

The expected type of the value\.
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetValue_T_(int,int,T).rowIndex'></a>

`rowIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetValue_T_(int,int,T).columnIndex'></a>

`columnIndex` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetValue_T_(int,int,T).value'></a>

`value` [T](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetValue_T_(int,int,T).T 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TryGetValue\<T\>\(int, int, T\)\.T')

When this method returns, contains the value if found and cast successfully; otherwise, default\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was found and cast successfully; otherwise, false\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetValue_T_(TRow,TColumn,T)'></a>

## Table\<TColumn,TRow\>\.TryGetValue\<T\>\(TRow, TColumn, T\) Method

Attempts to get a value for the specified row and column objects, cast to type T\.

```csharp
public bool TryGetValue<T>(TRow? row, TColumn? column, out T? value);
```
#### Type parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetValue_T_(TRow,TColumn,T).T'></a>

`T`

The expected type of the value\.
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetValue_T_(TRow,TColumn,T).row'></a>

`row` [TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')

The row object\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetValue_T_(TRow,TColumn,T).column'></a>

`column` [TColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TColumn 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TColumn')

The column object\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetValue_T_(TRow,TColumn,T).value'></a>

`value` [T](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TryGetValue_T_(TRow,TColumn,T).T 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TryGetValue\<T\>\(TRow, TColumn, T\)\.T')

When this method returns, contains the value if found and cast successfully; otherwise, default\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was found and cast successfully; otherwise, false\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.UpdateColumn(int,TColumn,bool)'></a>

## Table\<TColumn,TRow\>\.UpdateColumn\(int, TColumn, bool\) Method

Updates an existing column at the specified index\.

```csharp
public TColumn? UpdateColumn(int index, TColumn column, bool tryConvert=true);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.UpdateColumn(int,TColumn,bool).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the column to update\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.UpdateColumn(int,TColumn,bool).column'></a>

`column` [TColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TColumn 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TColumn')

The new column definition\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.UpdateColumn(int,TColumn,bool).tryConvert'></a>

`tryConvert` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to attempt conversion of existing row values to the new column type\.

#### Returns
[TColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TColumn 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TColumn')  
A clone of the updated column, or null if update failed\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.UpdateRow(int,System.Collections.Generic.IDictionary_int,object_)'></a>

## Table\<TColumn,TRow\>\.UpdateRow\(int, IDictionary\<int,object\>\) Method

Updates a row at the specified index using column indices and values\.

```csharp
public TRow? UpdateRow(int index, System.Collections.Generic.IDictionary<int,object?>? values);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.UpdateRow(int,System.Collections.Generic.IDictionary_int,object_).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row to update\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.UpdateRow(int,System.Collections.Generic.IDictionary_int,object_).values'></a>

`values` [System\.Collections\.Generic\.IDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')

A dictionary of column indices and their corresponding values\.

#### Returns
[TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')  
The updated row, or null if update failed\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.UpdateRow(int,System.Collections.Generic.IDictionary_string,object_,System.Func_string,string,bool_)'></a>

## Table\<TColumn,TRow\>\.UpdateRow\(int, IDictionary\<string,object\>, Func\<string,string,bool\>\) Method

Updates a row at the specified index using column names and values\.

```csharp
public TRow? UpdateRow(int index, System.Collections.Generic.IDictionary<string,object?>? values, System.Func<string?,string?,bool>? func=null);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.UpdateRow(int,System.Collections.Generic.IDictionary_string,object_,System.Func_string,string,bool_).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row to update\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.UpdateRow(int,System.Collections.Generic.IDictionary_string,object_,System.Func_string,string,bool_).values'></a>

`values` [System\.Collections\.Generic\.IDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')

A dictionary of column names and their corresponding values\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.UpdateRow(int,System.Collections.Generic.IDictionary_string,object_,System.Func_string,string,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')

An optional custom function to match column names\.

#### Returns
[TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')  
The updated row, or null if update failed\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.UpdateRow(int,System.Collections.Generic.IEnumerable_object_)'></a>

## Table\<TColumn,TRow\>\.UpdateRow\(int, IEnumerable\<object\>\) Method

Updates a row at the specified index using an ordered collection of values\.

```csharp
public TRow? UpdateRow(int index, System.Collections.Generic.IEnumerable<object>? values);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.UpdateRow(int,System.Collections.Generic.IEnumerable_object_).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The zero\-based index of the row to update\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.UpdateRow(int,System.Collections.Generic.IEnumerable_object_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A sequence of values corresponding to columns in order\.

#### Returns
[TRow](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_.TRow 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>\.TRow')  
The updated row, or null if update failed\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn_'></a>

## Table\<TColumn\> Class

Represents a table with columns of type [TColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn_.TColumn 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn\>\.TColumn') and rows of type [Row](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row 'DiGi\.Core\.IO\.Table\.Classes\.Row')\.

```csharp
public class Table<TColumn> : DiGi.Core.IO.Table.Classes.Table<TColumn, DiGi.Core.IO.Table.Classes.Row>
    where TColumn : DiGi.Core.IO.Table.Interfaces.IColumn
```
#### Type parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn_.TColumn'></a>

`TColumn`

The type of the columns in the table\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.IO\.Table\.Classes\.Table&lt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>')[TColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn_.TColumn 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn\>\.TColumn')[,](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>')[Row](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row 'DiGi\.Core\.IO\.Table\.Classes\.Row')[&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>') → Table\<TColumn\>

Derived  
↳ [Table](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table 'DiGi\.Core\.IO\.Table\.Classes\.Table')
### Constructors

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn_.Table()'></a>

## Table\(\) Constructor

Initializes a new instance of the [Table&lt;TColumn&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn_ 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn\>') class\.

```csharp
public Table();
```

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn_.Table(System.Collections.Generic.IEnumerable_TColumn_)'></a>

## Table\(IEnumerable\<TColumn\>\) Constructor

Initializes a new instance of the [Table&lt;TColumn&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn_ 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn\>') class with specified columns\.

```csharp
public Table(System.Collections.Generic.IEnumerable<TColumn> columns);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn_.Table(System.Collections.Generic.IEnumerable_TColumn_).columns'></a>

`columns` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn_.TColumn 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn\>\.TColumn')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of columns to add to the table\.
### Methods

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn_.CreateRow(int,System.Collections.Generic.IDictionary_int,object_)'></a>

## Table\<TColumn\>\.CreateRow\(int, IDictionary\<int,object\>\) Method

Creates a new [Row](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row 'DiGi\.Core\.IO\.Table\.Classes\.Row') for this table\.

```csharp
protected override DiGi.Core.IO.Table.Classes.Row CreateRow(int index, System.Collections.Generic.IDictionary<int,object?>? values=null);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn_.CreateRow(int,System.Collections.Generic.IDictionary_int,object_).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index to assign to the new row\.

<a name='DiGi.Core.IO.Table.Classes.Table_TColumn_.CreateRow(int,System.Collections.Generic.IDictionary_int,object_).values'></a>

`values` [System\.Collections\.Generic\.IDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')

Optional initial values for the row\.

#### Returns
[Row](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row 'DiGi\.Core\.IO\.Table\.Classes\.Row')  
A newly created row instance\.

<a name='DiGi.Core.IO.Table.Classes.TableConverter_UTable,UColumn,URow_'></a>

## TableConverter\<UTable,UColumn,URow\> Class

Provides custom JSON serialization and deserialization for tables\.

```csharp
public class TableConverter<UTable,UColumn,URow> : System.Text.Json.Serialization.JsonConverter<UTable>
    where UTable : DiGi.Core.IO.Table.Interfaces.ITable<UColumn, URow>, new()
    where UColumn : DiGi.Core.IO.Table.Interfaces.IColumn
    where URow : DiGi.Core.IO.Table.Interfaces.IRow<URow>
```
#### Type parameters

<a name='DiGi.Core.IO.Table.Classes.TableConverter_UTable,UColumn,URow_.UTable'></a>

`UTable`

The type of the table\.

<a name='DiGi.Core.IO.Table.Classes.TableConverter_UTable,UColumn,URow_.UColumn'></a>

`UColumn`

The type of the column\.

<a name='DiGi.Core.IO.Table.Classes.TableConverter_UTable,UColumn,URow_.URow'></a>

`URow`

The type of the row\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Text\.Json\.Serialization\.JsonConverter](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter 'System\.Text\.Json\.Serialization\.JsonConverter') → [System\.Text\.Json\.Serialization\.JsonConverter&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter-1 'System\.Text\.Json\.Serialization\.JsonConverter\`1')[UTable](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.TableConverter_UTable,UColumn,URow_.UTable 'DiGi\.Core\.IO\.Table\.Classes\.TableConverter\<UTable,UColumn,URow\>\.UTable')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter-1 'System\.Text\.Json\.Serialization\.JsonConverter\`1') → TableConverter\<UTable,UColumn,URow\>
### Methods

<a name='DiGi.Core.IO.Table.Classes.TableConverter_UTable,UColumn,URow_.Read(System.Text.Json.Utf8JsonReader,System.Type,System.Text.Json.JsonSerializerOptions)'></a>

## TableConverter\<UTable,UColumn,URow\>\.Read\(Utf8JsonReader, Type, JsonSerializerOptions\) Method

Reads and deserializes a table object from the provided UTF8 JSON reader\.

```csharp
public override UTable? Read(ref System.Text.Json.Utf8JsonReader utf8JsonReader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions jsonSerializerOptions);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.TableConverter_UTable,UColumn,URow_.Read(System.Text.Json.Utf8JsonReader,System.Type,System.Text.Json.JsonSerializerOptions).utf8JsonReader'></a>

`utf8JsonReader` [System\.Text\.Json\.Utf8JsonReader](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.utf8jsonreader 'System\.Text\.Json\.Utf8JsonReader')

The UTF8 JSON reader to read from\.

<a name='DiGi.Core.IO.Table.Classes.TableConverter_UTable,UColumn,URow_.Read(System.Text.Json.Utf8JsonReader,System.Type,System.Text.Json.JsonSerializerOptions).typeToConvert'></a>

`typeToConvert` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type of the object to convert to\.

<a name='DiGi.Core.IO.Table.Classes.TableConverter_UTable,UColumn,URow_.Read(System.Text.Json.Utf8JsonReader,System.Type,System.Text.Json.JsonSerializerOptions).jsonSerializerOptions'></a>

`jsonSerializerOptions` [System\.Text\.Json\.JsonSerializerOptions](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializeroptions 'System\.Text\.Json\.JsonSerializerOptions')

The options for JSON deserialization\.

#### Returns
[UTable](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.TableConverter_UTable,UColumn,URow_.UTable 'DiGi\.Core\.IO\.Table\.Classes\.TableConverter\<UTable,UColumn,URow\>\.UTable')  
The deserialized table object, or null if the value is null\.

<a name='DiGi.Core.IO.Table.Classes.TableConverter_UTable,UColumn,URow_.Write(System.Text.Json.Utf8JsonWriter,UTable,System.Text.Json.JsonSerializerOptions)'></a>

## TableConverter\<UTable,UColumn,URow\>\.Write\(Utf8JsonWriter, UTable, JsonSerializerOptions\) Method

Serializes a table object into the provided UTF8 JSON writer\.

```csharp
public override void Write(System.Text.Json.Utf8JsonWriter utf8JsonWriter, UTable table, System.Text.Json.JsonSerializerOptions jsonSerializerOptions);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Classes.TableConverter_UTable,UColumn,URow_.Write(System.Text.Json.Utf8JsonWriter,UTable,System.Text.Json.JsonSerializerOptions).utf8JsonWriter'></a>

`utf8JsonWriter` [System\.Text\.Json\.Utf8JsonWriter](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.utf8jsonwriter 'System\.Text\.Json\.Utf8JsonWriter')

The UTF8 JSON writer to write to\.

<a name='DiGi.Core.IO.Table.Classes.TableConverter_UTable,UColumn,URow_.Write(System.Text.Json.Utf8JsonWriter,UTable,System.Text.Json.JsonSerializerOptions).table'></a>

`table` [UTable](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.TableConverter_UTable,UColumn,URow_.UTable 'DiGi\.Core\.IO\.Table\.Classes\.TableConverter\<UTable,UColumn,URow\>\.UTable')

The table object to serialize\.

<a name='DiGi.Core.IO.Table.Classes.TableConverter_UTable,UColumn,URow_.Write(System.Text.Json.Utf8JsonWriter,UTable,System.Text.Json.JsonSerializerOptions).jsonSerializerOptions'></a>

`jsonSerializerOptions` [System\.Text\.Json\.JsonSerializerOptions](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializeroptions 'System\.Text\.Json\.JsonSerializerOptions')

The options for JSON serialization\.