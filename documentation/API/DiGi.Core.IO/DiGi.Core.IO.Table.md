#### [DiGi\.Core\.IO](DiGi.Core.IO.Overview.md 'DiGi\.Core\.IO\.Overview')

## DiGi\.Core\.IO\.Table Namespace
### Classes

<a name='DiGi.Core.IO.Table.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.Core.IO.Table.Convert.ToSystem_String_UTable,UColumn,URow_(thisUTable)'></a>

## Convert\.ToSystem\_String\<UTable,UColumn,URow\>\(this UTable\) Method

Converts a serializable Table to its JSON string representation using default options \(WARINNG\! all table values have to be serializable objects otherwise converted data may be missing\)\.

```csharp
public static string? ToSystem_String<UTable,UColumn,URow>(this UTable? table)
    where UTable : DiGi.Core.IO.Table.Interfaces.ITable<UColumn, URow>, new()
    where UColumn : DiGi.Core.IO.Table.Interfaces.IColumn
    where URow : DiGi.Core.IO.Table.Interfaces.IRow<URow>;
```
#### Type parameters

<a name='DiGi.Core.IO.Table.Convert.ToSystem_String_UTable,UColumn,URow_(thisUTable).UTable'></a>

`UTable`

The type of the table\.

<a name='DiGi.Core.IO.Table.Convert.ToSystem_String_UTable,UColumn,URow_(thisUTable).UColumn'></a>

`UColumn`

The type of the column\.

<a name='DiGi.Core.IO.Table.Convert.ToSystem_String_UTable,UColumn,URow_(thisUTable).URow'></a>

`URow`

The type of the row\.
#### Parameters

<a name='DiGi.Core.IO.Table.Convert.ToSystem_String_UTable,UColumn,URow_(thisUTable).table'></a>

`table` [UTable](DiGi.Core.IO.Table.md#DiGi.Core.IO.Table.Convert.ToSystem_String_UTable,UColumn,URow_(thisUTable).UTable 'DiGi\.Core\.IO\.Table\.Convert\.ToSystem\_String\<UTable,UColumn,URow\>\(this UTable\)\.UTable')

The table to be converted to a JSON string\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A JSON string representation of the table, or null if the provided table is null\.