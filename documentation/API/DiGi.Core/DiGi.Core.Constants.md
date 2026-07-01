#### [DiGi\.Core](index.md 'index')

## DiGi\.Core\.Constants Namespace
### Classes

<a name='DiGi.Core.Constants.FileExtension'></a>

## FileExtension Class

File extensions used within the system\.

```csharp
public static class FileExtension
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → FileExtension
### Fields

<a name='DiGi.Core.Constants.FileExtension.ConfigurationFile'></a>

## FileExtension\.ConfigurationFile Field

Extension for configuration files\.

```csharp
public const string ConfigurationFile = "conf";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.FNV'></a>

## FNV Class

64\-bit FNV\-1a initial hash values

```csharp
public static class FNV
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → FNV
### Fields

<a name='DiGi.Core.Constants.FNV.OffsetBasis'></a>

## FNV\.OffsetBasis Field

64\-bit FNV\-1a initial value of the hash before processing any input

```csharp
public const ulong OffsetBasis = 14695981039346656037;
```

#### Field Value
[System\.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64 'System\.UInt64')

<a name='DiGi.Core.Constants.FNV.Prime'></a>

## FNV\.Prime Field

64\-bit FNV\-1a prime number is multiplied at each step to spread out the hash bits

```csharp
public const ulong Prime = 1099511628211;
```

#### Field Value
[System\.UInt64](https://learn.microsoft.com/en-us/dotnet/api/system.uint64 'System\.UInt64')

<a name='DiGi.Core.Constants.Reference'></a>

## Reference Class

Constants used for reference identifiers\.

```csharp
public static class Reference
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Reference
### Fields

<a name='DiGi.Core.Constants.Reference.Separator'></a>

## Reference\.Separator Field

Separator used in reference strings\.

```csharp
public const string Separator = "::";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Reference.Format'></a>

## Reference\.Format Class

Format strings for references\.

```csharp
public static class Reference.Format
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Format
### Fields

<a name='DiGi.Core.Constants.Reference.Format.Guid'></a>

## Reference\.Format\.Guid Field

Format for GUIDs\.

```csharp
public const string Guid = "{0}";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Reference.Format.Property'></a>

## Reference\.Format\.Property Field

Format for properties\.

```csharp
public const string Property = "["{0}"]";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Reference.Format.UniqueId'></a>

## Reference\.Format\.UniqueId Field

Format for unique identifiers\.

```csharp
public const string UniqueId = ""{0}"";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Serialization'></a>

## Serialization Class

Constants used for serialization processes\.

```csharp
public static class Serialization
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Serialization

<a name='DiGi.Core.Constants.Serialization.LiteralName'></a>

## Serialization\.LiteralName Class

Literal names for special values in serialization\.

```csharp
public static class Serialization.LiteralName
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → LiteralName
### Fields

<a name='DiGi.Core.Constants.Serialization.LiteralName.NegativeInfinity'></a>

## Serialization\.LiteralName\.NegativeInfinity Field

Negative infinity literal\.

```csharp
public const string NegativeInfinity = "-Infinity";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Serialization.LiteralName.PositiveInfinity'></a>

## Serialization\.LiteralName\.PositiveInfinity Field

Positive infinity literal\.

```csharp
public const string PositiveInfinity = "Infinity";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Serialization.MethodName'></a>

## Serialization\.MethodName Class

Method names used in serialization/deserialization\.

```csharp
public static class Serialization.MethodName
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → MethodName
### Fields

<a name='DiGi.Core.Constants.Serialization.MethodName.Clone'></a>

## Serialization\.MethodName\.Clone Field

Clone method name\.

```csharp
public const string Clone = "Clone";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Serialization.PropertyName'></a>

## Serialization\.PropertyName Class

Property names used in serialized JSON objects\.

```csharp
public static class Serialization.PropertyName
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → PropertyName
### Fields

<a name='DiGi.Core.Constants.Serialization.PropertyName.Guid'></a>

## Serialization\.PropertyName\.Guid Field

Guid property name\.

```csharp
public const string Guid = "Guid";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Serialization.PropertyName.Type'></a>

## Serialization\.PropertyName\.Type Field

Type property name\.

```csharp
public const string Type = "_type";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Serialization.PropertyName.UniqueId'></a>

## Serialization\.PropertyName\.UniqueId Field

UniqueId property name\.

```csharp
public const string UniqueId = "UniqueId";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Serialization.PropertyName.Value'></a>

## Serialization\.PropertyName\.Value Field

Value property name\.

```csharp
public const string Value = "Value";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Serialization.PropertyName.ValueType'></a>

## Serialization\.PropertyName\.ValueType Field

ValueType property name\.

```csharp
public const string ValueType = "ValueType";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Tolerance'></a>

## Tolerance Class

Provides tolerance constants for comparisons and geometric operations\.

```csharp
public static class Tolerance
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Tolerance
### Fields

<a name='DiGi.Core.Constants.Tolerance.Angle'></a>

## Tolerance\.Angle Field

Angle tolerance\. Equivalent of 2 degrees

```csharp
public const double Angle = 0.0349066;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Constants.Tolerance.Distance'></a>

## Tolerance\.Distance Field

Dictance tolerance\.

```csharp
public const double Distance = 1E-06;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Constants.Tolerance.MacroDistance'></a>

## Tolerance\.MacroDistance Field

Macro dictance tolerance\.

```csharp
public const double MacroDistance = 0.001;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Constants.Tolerance.MicroDistance'></a>

## Tolerance\.MicroDistance Field

Micro dictance tolerance\.

```csharp
public const double MicroDistance = 1E-09;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Constants.UniqueId'></a>

## UniqueId Class

Constants related to unique identifiers\.

```csharp
public static class UniqueId
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → UniqueId
### Fields

<a name='DiGi.Core.Constants.UniqueId.Null'></a>

## UniqueId\.Null Field

String representation of a null unique identifier\.

```csharp
public const string Null = "null";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')