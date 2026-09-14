#### [DiGi\.Core](DiGi.Core.Overview.md 'DiGi\.Core\.Overview')

## DiGi\.Core\.Constants Namespace
### Classes

<a name='DiGi.Core.Constants.ColorScheme'></a>

## ColorScheme Class

Color scheme parameters for Create\.Colors: the OKLab lightness band, the default ramp anchors, the curated categorical palette, and the golden\-angle fallback parameters\.

```csharp
public static class ColorScheme
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → ColorScheme
### Fields

<a name='DiGi.Core.Constants.ColorScheme.CategoricalGoldenAngleChroma'></a>

## ColorScheme\.CategoricalGoldenAngleChroma Field

OKLab chroma of the beyond\-12 categorical fallback, fixed so new buckets differ mostly in hue and lightness\.

```csharp
public const double CategoricalGoldenAngleChroma = 0.1;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Constants.ColorScheme.CategoricalGoldenAngleDegrees'></a>

## ColorScheme\.CategoricalGoldenAngleDegrees Field

Golden angle in degrees, the hue step of the beyond\-12 categorical fallback\.

```csharp
public const double CategoricalGoldenAngleDegrees = 137.508;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Constants.ColorScheme.CategoricalGoldenAngleLightness_0'></a>

## ColorScheme\.CategoricalGoldenAngleLightness\_0 Field

OKLab lightness of the first and third golden\-angle turns \(i = 12\-23, i = 36\-47\)\.

```csharp
public const double CategoricalGoldenAngleLightness_0 = 0.3;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Constants.ColorScheme.CategoricalGoldenAngleLightness_1'></a>

## ColorScheme\.CategoricalGoldenAngleLightness\_1 Field

OKLab lightness of the second and fourth golden\-angle turns \(i = 24\-35, i = 48\-59\)\.

```csharp
public const double CategoricalGoldenAngleLightness_1 = 0.65;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Constants.ColorScheme.CategoricalMinimumDistance'></a>

## ColorScheme\.CategoricalMinimumDistance Field

Minimum OKLab distance any two categorical colors may sit apart\.

Set to 0.075, below the 0.08 proposed in the issue, because the curated palette's own closest pair (#bcbd22 and #e7ba52) sits at 0.0778; the floor is set to the palette's achieved minimum so the exact palette the GIS page uses stays assertable and reproducible.

```csharp
public const double CategoricalMinimumDistance = 0.075;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Constants.ColorScheme.CategoricalPalette'></a>

## ColorScheme\.CategoricalPalette Field

Curated categorical palette in bucket order, the 12 colors a GIS typology page seeds its unique\-value buckets with\.

Tableau 10 extended with #393b79 and #e7ba52. Its minimum pairwise OKLab distance is 0.0778, between #bcbd22 and #e7ba52.

```csharp
public static readonly int[] CategoricalPalette;
```

#### Field Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Core.Constants.ColorScheme.CategoricalPaletteSize'></a>

## ColorScheme\.CategoricalPaletteSize Field

Number of buckets the curated palette covers; Colors falls back to golden\-angle generation above this count\.

```csharp
public const int CategoricalPaletteSize = 12;
```

#### Field Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.Constants.ColorScheme.CategoricalTurnSize'></a>

## ColorScheme\.CategoricalTurnSize Field

Buckets per golden\-angle turn; the lightness level flips at each turn boundary so turns differ in more than hue\.

```csharp
public const int CategoricalTurnSize = 12;
```

#### Field Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.Constants.ColorScheme.DivergingEnd'></a>

## ColorScheme\.DivergingEnd Field

Default diverging ramp end anchor, a blue \#2166ac, in ARGB integer form\.

```csharp
public const int DivergingEnd = -14588244;
```

#### Field Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.Constants.ColorScheme.DivergingMiddle'></a>

## ColorScheme\.DivergingMiddle Field

Default diverging ramp middle point, a near\-white \#f7f7f7, in ARGB integer form\.

Lightness-clamped at generation time, because its L = 0.9761 exceeds LightnessMax.

```csharp
public const int DivergingMiddle = -526345;
```

#### Field Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.Constants.ColorScheme.DivergingStart'></a>

## ColorScheme\.DivergingStart Field

Default diverging ramp start anchor, a red \#b2182b, in ARGB integer form\.

```csharp
public const int DivergingStart = -5105621;
```

#### Field Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.Constants.ColorScheme.LightnessMax'></a>

## ColorScheme\.LightnessMax Field

Maximum OKLab lightness L any generated color may reach\.

An anchor or middle point above this value is clamped down to it, for example the default sequential start #deebf7 (L = 0.9339) and the diverging middle #f7f7f7 (L = 0.9761).

```csharp
public const double LightnessMax = 0.93;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Constants.ColorScheme.LightnessMin'></a>

## ColorScheme\.LightnessMin Field

Minimum OKLab lightness L any generated color may reach\.

Colors outside the band read as washed out or crushed on a light background, so every generated color clamps L to this band.

```csharp
public const double LightnessMin = 0.15;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Constants.ColorScheme.SequentialEnd'></a>

## ColorScheme\.SequentialEnd Field

Default sequential ramp end anchor, a dark blue \#08306b, in ARGB integer form\.

```csharp
public const int SequentialEnd = -16240533;
```

#### Field Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.Core.Constants.ColorScheme.SequentialStart'></a>

## ColorScheme\.SequentialStart Field

Default sequential ramp start anchor, a light blue \#deebf7, in ARGB integer form\.

Lightness-clamped at generation time, because its L = 0.9339 exceeds LightnessMax.

```csharp
public const int SequentialStart = -2167817;
```

#### Field Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

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

Constants defining the reference string grammar\.

A reference renders as `discriminator ( "::" segment )*`, where the discriminator is a
            [Kind](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.Kind 'DiGi\.Core\.Constants\.Reference\.Kind') token (always written) or an assembly-qualified full type name (accepted on read only).
            A segment is either an escaped scalar token, a nested reference wrapped in [NestingStart](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.NestingStart 'DiGi\.Core\.Constants\.Reference\.NestingStart') /
            [NestingEnd](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.NestingEnd 'DiGi\.Core\.Constants\.Reference\.NestingEnd'), or [Null](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.Null 'DiGi\.Core\.Constants\.Reference\.Null').

```csharp
public static class Reference
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Reference
### Fields

<a name='DiGi.Core.Constants.Reference.Escape'></a>

## Reference\.Escape Field

Escape prefix\. Applied to itself, to each character of [Separator](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.Separator 'DiGi\.Core\.Constants\.Reference\.Separator'), and to
[NestingStart](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.NestingStart 'DiGi\.Core\.Constants\.Reference\.NestingStart') / [NestingEnd](DiGi.Core.Constants.md#DiGi.Core.Constants.Reference.NestingEnd 'DiGi\.Core\.Constants\.Reference\.NestingEnd'), making the mapping prefix\-free and invertible\.

```csharp
public const string Escape = "\";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Reference.NestingEnd'></a>

## Reference\.NestingEnd Field

Closes a nested reference segment\.

```csharp
public const string NestingEnd = ")";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Reference.NestingStart'></a>

## Reference\.NestingStart Field

Opens a nested reference segment\.

```csharp
public const string NestingStart = "(";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Reference.Null'></a>

## Reference\.Null Field

Segment representing a null value, as distinct from an empty segment which represents
[System\.String\.Empty](https://learn.microsoft.com/en-us/dotnet/api/system.string.empty 'System\.String\.Empty')\. A real payload can never render as this token, because a literal escape
character is always itself escaped\.

```csharp
public const string Null = "\0";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Reference.Separator'></a>

## Reference\.Separator Field

Separator between the discriminator and each segment\. Only an unescaped occurrence at nesting depth zero
separates; an occurrence inside a payload is escaped and never splits\.

```csharp
public const string Separator = "::";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Reference.Kind'></a>

## Reference\.Kind Class

Discriminator tokens for the reference types defined in DiGi\.Core\.

These values are a persisted contract: they are written into stored reference strings, so they are
            append-only. Renaming one silently invalidates every string already stored in that format. Types outside
            DiGi.Core declare their own tokens in their repository's `Constants.ReferenceKind` class.

A token must never contain a comma (which would make it parse as a full type name) or a colon.

```csharp
public static class Reference.Kind
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Kind
### Fields

<a name='DiGi.Core.Constants.Reference.Kind.Complex'></a>

## Reference\.Kind\.Complex Field

Discriminator for [ComplexReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ComplexReference 'DiGi\.Core\.Classes\.ComplexReference')\.

```csharp
public const string Complex = "Complex";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Reference.Kind.Guid'></a>

## Reference\.Kind\.Guid Field

Discriminator for [GuidReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidReference 'DiGi\.Core\.Classes\.GuidReference')\.

```csharp
public const string Guid = "Guid";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Reference.Kind.GuidExternal'></a>

## Reference\.Kind\.GuidExternal Field

Discriminator for [GuidExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidExternalReference 'DiGi\.Core\.Classes\.GuidExternalReference')\.

```csharp
public const string GuidExternal = "GuidExternal";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Reference.Kind.GuidProperty'></a>

## Reference\.Kind\.GuidProperty Field

Discriminator for [GuidPropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidPropertyReference 'DiGi\.Core\.Classes\.GuidPropertyReference')\.

```csharp
public const string GuidProperty = "GuidProperty";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Reference.Kind.InstanceExternal'></a>

## Reference\.Kind\.InstanceExternal Field

Discriminator for [InstanceRelatedExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.InstanceRelatedExternalReference 'DiGi\.Core\.Classes\.InstanceRelatedExternalReference')\.

```csharp
public const string InstanceExternal = "InstanceExternal";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Reference.Kind.Type'></a>

## Reference\.Kind\.Type Field

Discriminator for [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')\.

```csharp
public const string Type = "Type";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Reference.Kind.TypeExternal'></a>

## Reference\.Kind\.TypeExternal Field

Discriminator for [TypeRelatedExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeRelatedExternalReference 'DiGi\.Core\.Classes\.TypeRelatedExternalReference')\.

```csharp
public const string TypeExternal = "TypeExternal";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Reference.Kind.TypeProperty'></a>

## Reference\.Kind\.TypeProperty Field

Discriminator for [TypePropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypePropertyReference 'DiGi\.Core\.Classes\.TypePropertyReference')\.

```csharp
public const string TypeProperty = "TypeProperty";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Reference.Kind.UniqueId'></a>

## Reference\.Kind\.UniqueId Field

Discriminator for [UniqueIdReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdReference 'DiGi\.Core\.Classes\.UniqueIdReference')\.

```csharp
public const string UniqueId = "UniqueId";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Constants.Reference.Kind.UniqueIdProperty'></a>

## Reference\.Kind\.UniqueIdProperty Field

Discriminator for [UniqueIdPropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdPropertyReference 'DiGi\.Core\.Classes\.UniqueIdPropertyReference')\.

```csharp
public const string UniqueIdProperty = "UniqueIdProperty";
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