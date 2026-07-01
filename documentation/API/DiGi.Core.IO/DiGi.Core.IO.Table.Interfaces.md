#### [DiGi\.Core\.IO](index.md 'index')

## DiGi\.Core\.IO\.Table\.Interfaces Namespace
### Interfaces

<a name='DiGi.Core.IO.Table.Interfaces.IColumn'></a>

## IColumn Interface

Defines the contract for a column in a table\.

```csharp
public interface IColumn : DiGi.Core.IO.Table.Interfaces.ITableSerializableObject, DiGi.Core.IO.Table.Interfaces.ITableObject, DiGi.Core.IO.Interfaces.IIOObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.INamedObject
```

Derived  
↳ [Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column')  
↳ [ExtendedColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.ExtendedColumn 'DiGi\.Core\.IO\.Table\.Classes\.ExtendedColumn')  
↳ [IExtendedColumn](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IExtendedColumn 'DiGi\.Core\.IO\.Table\.Interfaces\.IExtendedColumn')

Implements [ITableSerializableObject](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITableSerializableObject 'DiGi\.Core\.IO\.Table\.Interfaces\.ITableSerializableObject'), [ITableObject](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITableObject 'DiGi\.Core\.IO\.Table\.Interfaces\.ITableObject'), [DiGi\.Core\.IO\.Interfaces\.IIOObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iioobject 'DiGi\.Core\.IO\.Interfaces\.IIOObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject')
### Properties

<a name='DiGi.Core.IO.Table.Interfaces.IColumn.Index'></a>

## IColumn\.Index Property

Gets or sets the index of the column\.

```csharp
int Index { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.IO.Table.Interfaces.IColumn.Type'></a>

## IColumn\.Type Property

Gets the data type of the column\.

```csharp
System.Type? Type { get; }
```

#### Property Value
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')
### Methods

<a name='DiGi.Core.IO.Table.Interfaces.IColumn.TryGetValidValue(object,object,bool)'></a>

## IColumn\.TryGetValidValue\(object, object, bool\) Method

Tries to get a valid value for this column from the input object\.

```csharp
bool TryGetValidValue(object? @in, out object? @out, bool tryConvert=true);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Interfaces.IColumn.TryGetValidValue(object,object,bool).in'></a>

`in` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The input value to validate or convert\.

<a name='DiGi.Core.IO.Table.Interfaces.IColumn.TryGetValidValue(object,object,bool).out'></a>

`out` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The validated and potentially converted output value\.

<a name='DiGi.Core.IO.Table.Interfaces.IColumn.TryGetValidValue(object,object,bool).tryConvert'></a>

`tryConvert` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to attempt conversion if the type doesn't match\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if a valid value was obtained, false otherwise\.

<a name='DiGi.Core.IO.Table.Interfaces.IExtendedColumn'></a>

## IExtendedColumn Interface

Defines an extended column in a table with additional metadata such as category and description\.

```csharp
public interface IExtendedColumn : DiGi.Core.IO.Table.Interfaces.IColumn, DiGi.Core.IO.Table.Interfaces.ITableSerializableObject, DiGi.Core.IO.Table.Interfaces.ITableObject, DiGi.Core.IO.Interfaces.IIOObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.INamedObject, DiGi.Core.Interfaces.IDescribableObject
```

Derived  
↳ [ExtendedColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.ExtendedColumn 'DiGi\.Core\.IO\.Table\.Classes\.ExtendedColumn')

Implements [IColumn](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IColumn 'DiGi\.Core\.IO\.Table\.Interfaces\.IColumn'), [ITableSerializableObject](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITableSerializableObject 'DiGi\.Core\.IO\.Table\.Interfaces\.ITableSerializableObject'), [ITableObject](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITableObject 'DiGi\.Core\.IO\.Table\.Interfaces\.ITableObject'), [DiGi\.Core\.IO\.Interfaces\.IIOObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iioobject 'DiGi\.Core\.IO\.Interfaces\.IIOObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Core\.Interfaces\.IDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject 'DiGi\.Core\.Interfaces\.IDescribableObject')
### Properties

<a name='DiGi.Core.IO.Table.Interfaces.IExtendedColumn.Category'></a>

## IExtendedColumn\.Category Property

Gets the category of the column\.

```csharp
string? Category { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.IO.Table.Interfaces.IRow'></a>

## IRow Interface

Defines the contract for a row in a table\.

```csharp
public interface IRow : DiGi.Core.IO.Table.Interfaces.ITableObject, DiGi.Core.IO.Interfaces.IIOObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [Row&lt;TRow&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row_TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Row\<TRow\>')  
↳ [IRow&lt;TRow&gt;](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IRow_TRow_ 'DiGi\.Core\.IO\.Table\.Interfaces\.IRow\<TRow\>')

Implements [ITableObject](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITableObject 'DiGi\.Core\.IO\.Table\.Interfaces\.ITableObject'), [DiGi\.Core\.IO\.Interfaces\.IIOObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iioobject 'DiGi\.Core\.IO\.Interfaces\.IIOObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Core.IO.Table.Interfaces.IRow.Index'></a>

## IRow\.Index Property

Gets the index of the row\.

```csharp
int Index { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.IO.Table.Interfaces.IRow.Indexes'></a>

## IRow\.Indexes Property

Gets the set of indexes associated with this row\.

```csharp
System.Collections.Generic.HashSet<int> Indexes { get; }
```

#### Property Value
[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')

<a name='DiGi.Core.IO.Table.Interfaces.IRow.this[int]'></a>

## IRow\.this\[int\] Property

Gets or sets the value at the specified index\.

```csharp
object? this[int index] { get; set; }
```
#### Parameters

<a name='DiGi.Core.IO.Table.Interfaces.IRow.this[int].index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the value\.

#### Property Value
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')
### Methods

<a name='DiGi.Core.IO.Table.Interfaces.IRow.GetValues()'></a>

## IRow\.GetValues\(\) Method

Gets all values in the row as an array\.

```csharp
object?[] GetValues();
```

#### Returns
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array containing all values of the row\.

<a name='DiGi.Core.IO.Table.Interfaces.IRow.RemoveValue(int)'></a>

## IRow\.RemoveValue\(int\) Method

Removes the value at the specified index\.

```csharp
bool RemoveValue(int index);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Interfaces.IRow.RemoveValue(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the value to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was removed, false otherwise\.

<a name='DiGi.Core.IO.Table.Interfaces.IRow.TryGetValue_T_(int,T)'></a>

## IRow\.TryGetValue\<T\>\(int, T\) Method

Tries to get the value at the specified index as a specific type\.

```csharp
bool TryGetValue<T>(int index, out T? value);
```
#### Type parameters

<a name='DiGi.Core.IO.Table.Interfaces.IRow.TryGetValue_T_(int,T).T'></a>

`T`

The type of the value\.
#### Parameters

<a name='DiGi.Core.IO.Table.Interfaces.IRow.TryGetValue_T_(int,T).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the value\.

<a name='DiGi.Core.IO.Table.Interfaces.IRow.TryGetValue_T_(int,T).value'></a>

`value` [T](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IRow.TryGetValue_T_(int,T).T 'DiGi\.Core\.IO\.Table\.Interfaces\.IRow\.TryGetValue\<T\>\(int, T\)\.T')

The retrieved value, or default if not found or wrong type\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully retrieved, false otherwise\.

<a name='DiGi.Core.IO.Table.Interfaces.IRow_TRow_'></a>

## IRow\<TRow\> Interface

Defines a generic contract for a row that supports cloning\.

```csharp
public interface IRow<out TRow> : DiGi.Core.IO.Table.Interfaces.IRow, DiGi.Core.IO.Table.Interfaces.ITableObject, DiGi.Core.IO.Interfaces.IIOObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ICloneableObject<TRow>, DiGi.Core.Interfaces.ICloneableObject
    where TRow : DiGi.Core.IO.Table.Interfaces.IRow<TRow>
```
#### Type parameters

<a name='DiGi.Core.IO.Table.Interfaces.IRow_TRow_.TRow'></a>

`TRow`

Derived  
↳ [Row&lt;TRow&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row_TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Row\<TRow\>')

Implements [IRow](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IRow 'DiGi\.Core\.IO\.Table\.Interfaces\.IRow'), [ITableObject](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITableObject 'DiGi\.Core\.IO\.Table\.Interfaces\.ITableObject'), [DiGi\.Core\.IO\.Interfaces\.IIOObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iioobject 'DiGi\.Core\.IO\.Interfaces\.IIOObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[TRow](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IRow_TRow_.TRow 'DiGi\.Core\.IO\.Table\.Interfaces\.IRow\<TRow\>\.TRow')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')

<a name='DiGi.Core.IO.Table.Interfaces.ITable'></a>

## ITable Interface

Defines the contract for a table object\.

```csharp
public interface ITable : DiGi.Core.IO.Table.Interfaces.ITableObject, DiGi.Core.IO.Interfaces.IIOObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [Table&lt;TColumn,TRow&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>')  
↳ [ITable&lt;UColumn,URow&gt;](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_ 'DiGi\.Core\.IO\.Table\.Interfaces\.ITable\<UColumn,URow\>')

Implements [ITableObject](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITableObject 'DiGi\.Core\.IO\.Table\.Interfaces\.ITableObject'), [DiGi\.Core\.IO\.Interfaces\.IIOObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iioobject 'DiGi\.Core\.IO\.Interfaces\.IIOObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_'></a>

## ITable\<UColumn,URow\> Interface

Defines the contract for a table with specified column and row types\.

```csharp
public interface ITable<UColumn,URow> : DiGi.Core.IO.Table.Interfaces.ITable, DiGi.Core.IO.Table.Interfaces.ITableObject, DiGi.Core.IO.Interfaces.IIOObject, DiGi.Core.Interfaces.IObject, System.Collections.Generic.IEnumerable<URow>, System.Collections.IEnumerable
    where UColumn : DiGi.Core.IO.Table.Interfaces.IColumn
    where URow : DiGi.Core.IO.Table.Interfaces.IRow<URow>
```
#### Type parameters

<a name='DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_.UColumn'></a>

`UColumn`

<a name='DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_.URow'></a>

`URow`

Derived  
↳ [Table&lt;TColumn,TRow&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>')

Implements [ITable](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITable 'DiGi\.Core\.IO\.Table\.Interfaces\.ITable'), [ITableObject](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITableObject 'DiGi\.Core\.IO\.Table\.Interfaces\.ITableObject'), [DiGi\.Core\.IO\.Interfaces\.IIOObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iioobject 'DiGi\.Core\.IO\.Interfaces\.IIOObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[URow](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_.URow 'DiGi\.Core\.IO\.Table\.Interfaces\.ITable\<UColumn,URow\>\.URow')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')
### Properties

<a name='DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_.Columns'></a>

## ITable\<UColumn,URow\>\.Columns Property

Gets the columns of the table\.

```csharp
System.Collections.Generic.IEnumerable<UColumn> Columns { get; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[UColumn](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_.UColumn 'DiGi\.Core\.IO\.Table\.Interfaces\.ITable\<UColumn,URow\>\.UColumn')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_.Rows'></a>

## ITable\<UColumn,URow\>\.Rows Property

Gets the rows of the table\.

```csharp
System.Collections.Generic.IEnumerable<URow> Rows { get; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[URow](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_.URow 'DiGi\.Core\.IO\.Table\.Interfaces\.ITable\<UColumn,URow\>\.URow')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')
### Methods

<a name='DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_.AddColumn(UColumn)'></a>

## ITable\<UColumn,URow\>\.AddColumn\(UColumn\) Method

Adds a column to the table\.

```csharp
UColumn? AddColumn(UColumn? column);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_.AddColumn(UColumn).column'></a>

`column` [UColumn](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_.UColumn 'DiGi\.Core\.IO\.Table\.Interfaces\.ITable\<UColumn,URow\>\.UColumn')

The column to add\.

#### Returns
[UColumn](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_.UColumn 'DiGi\.Core\.IO\.Table\.Interfaces\.ITable\<UColumn,URow\>\.UColumn')  
The added column, or null if it could not be added\.

<a name='DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_.AddRow(System.Collections.Generic.IEnumerable_object_)'></a>

## ITable\<UColumn,URow\>\.AddRow\(IEnumerable\<object\>\) Method

Adds a row to the table using the specified values\.

```csharp
URow? AddRow(System.Collections.Generic.IEnumerable<object?>? values);
```
#### Parameters

<a name='DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_.AddRow(System.Collections.Generic.IEnumerable_object_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The values for the new row\.

#### Returns
[URow](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_.URow 'DiGi\.Core\.IO\.Table\.Interfaces\.ITable\<UColumn,URow\>\.URow')  
The added row, or null if it could not be added\.

<a name='DiGi.Core.IO.Table.Interfaces.ITableObject'></a>

## ITableObject Interface

Defines a base contract for table\-related objects\.

```csharp
public interface ITableObject : DiGi.Core.IO.Interfaces.IIOObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column')  
↳ [ExtendedColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.ExtendedColumn 'DiGi\.Core\.IO\.Table\.Classes\.ExtendedColumn')  
↳ [Row&lt;TRow&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Row_TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Row\<TRow\>')  
↳ [Table&lt;TColumn,TRow&gt;](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Table_TColumn,TRow_ 'DiGi\.Core\.IO\.Table\.Classes\.Table\<TColumn,TRow\>')  
↳ [IColumn](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IColumn 'DiGi\.Core\.IO\.Table\.Interfaces\.IColumn')  
↳ [IExtendedColumn](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IExtendedColumn 'DiGi\.Core\.IO\.Table\.Interfaces\.IExtendedColumn')  
↳ [IRow](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IRow 'DiGi\.Core\.IO\.Table\.Interfaces\.IRow')  
↳ [IRow&lt;TRow&gt;](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IRow_TRow_ 'DiGi\.Core\.IO\.Table\.Interfaces\.IRow\<TRow\>')  
↳ [ITable](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITable 'DiGi\.Core\.IO\.Table\.Interfaces\.ITable')  
↳ [ITable&lt;UColumn,URow&gt;](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITable_UColumn,URow_ 'DiGi\.Core\.IO\.Table\.Interfaces\.ITable\<UColumn,URow\>')  
↳ [ITableSerializableObject](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITableSerializableObject 'DiGi\.Core\.IO\.Table\.Interfaces\.ITableSerializableObject')

Implements [DiGi\.Core\.IO\.Interfaces\.IIOObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iioobject 'DiGi\.Core\.IO\.Interfaces\.IIOObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Core.IO.Table.Interfaces.ITableSerializableObject'></a>

## ITableSerializableObject Interface

Defines a contract for table objects that can be serialized\.

```csharp
public interface ITableSerializableObject : DiGi.Core.IO.Table.Interfaces.ITableObject, DiGi.Core.IO.Interfaces.IIOObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [Column](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.Column 'DiGi\.Core\.IO\.Table\.Classes\.Column')  
↳ [ExtendedColumn](DiGi.Core.IO.Table.Classes.md#DiGi.Core.IO.Table.Classes.ExtendedColumn 'DiGi\.Core\.IO\.Table\.Classes\.ExtendedColumn')  
↳ [IColumn](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IColumn 'DiGi\.Core\.IO\.Table\.Interfaces\.IColumn')  
↳ [IExtendedColumn](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.IExtendedColumn 'DiGi\.Core\.IO\.Table\.Interfaces\.IExtendedColumn')

Implements [ITableObject](DiGi.Core.IO.Table.Interfaces.md#DiGi.Core.IO.Table.Interfaces.ITableObject 'DiGi\.Core\.IO\.Table\.Interfaces\.ITableObject'), [DiGi\.Core\.IO\.Interfaces\.IIOObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iioobject 'DiGi\.Core\.IO\.Interfaces\.IIOObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')