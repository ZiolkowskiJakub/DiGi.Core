#### [DiGi\.Core\.Drawing](index.md 'index')

## DiGi\.Core\.Drawing\.Classes Namespace
### Classes

<a name='DiGi.Core.Drawing.Classes.Pen'></a>

## Pen Class

Represents a pen with a color and thickness\.

```csharp
public class Pen : DiGi.Core.Classes.SerializableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Pen
### Constructors

<a name='DiGi.Core.Drawing.Classes.Pen.Pen(DiGi.Core.Classes.Color,double)'></a>

## Pen\(Color, double\) Constructor

Initializes a new instance of the Pen class with specified color and thickness\.

```csharp
public Pen(DiGi.Core.Classes.Color? color, double thickness);
```
#### Parameters

<a name='DiGi.Core.Drawing.Classes.Pen.Pen(DiGi.Core.Classes.Color,double).color'></a>

`color` [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

The color of the pen\.

<a name='DiGi.Core.Drawing.Classes.Pen.Pen(DiGi.Core.Classes.Color,double).thickness'></a>

`thickness` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The thickness of the pen\.

<a name='DiGi.Core.Drawing.Classes.Pen.Pen(DiGi.Core.Drawing.Classes.Pen)'></a>

## Pen\(Pen\) Constructor

Initializes a new instance of the Pen class by copying another pen\.

```csharp
public Pen(DiGi.Core.Drawing.Classes.Pen? pen);
```
#### Parameters

<a name='DiGi.Core.Drawing.Classes.Pen.Pen(DiGi.Core.Drawing.Classes.Pen).pen'></a>

`pen` [Pen](DiGi.Core.Drawing.Classes.md#DiGi.Core.Drawing.Classes.Pen 'DiGi\.Core\.Drawing\.Classes\.Pen')

The source pen to copy from\.

<a name='DiGi.Core.Drawing.Classes.Pen.Pen(System.Text.Json.Nodes.JsonObject)'></a>

## Pen\(JsonObject\) Constructor

Initializes a new instance of the Pen class from a JsonObject\.

```csharp
public Pen(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Drawing.Classes.Pen.Pen(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing pen data\.
### Properties

<a name='DiGi.Core.Drawing.Classes.Pen.Color'></a>

## Pen\.Color Property

Gets the color of the pen\.

```csharp
public DiGi.Core.Classes.Color? Color { get; }
```

#### Property Value
[DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')

<a name='DiGi.Core.Drawing.Classes.Pen.Thickness'></a>

## Pen\.Thickness Property

Gets the thickness of the pen\.

```csharp
public double Thickness { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')