#### [DiGi\.Core\.Drawing](DiGi.Core.Drawing.Overview.md 'DiGi\.Core\.Drawing\.Overview')

## DiGi\.Core\.Drawing Namespace
### Classes

<a name='DiGi.Core.Drawing.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.Core.Drawing.Convert.ToDiGi(thisSystem.Drawing.Pen)'></a>

## Convert\.ToDiGi\(this Pen\) Method

Converts a System\.Drawing\.Pen to a DiGi Pen\.

```csharp
public static DiGi.Core.Drawing.Classes.Pen? ToDiGi(this System.Drawing.Pen? pen);
```
#### Parameters

<a name='DiGi.Core.Drawing.Convert.ToDiGi(thisSystem.Drawing.Pen).pen'></a>

`pen` [System\.Drawing\.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen 'System\.Drawing\.Pen')

The System\.Drawing\.Pen to convert\.

#### Returns
[Pen](DiGi.Core.Drawing.Classes.md#DiGi.Core.Drawing.Classes.Pen 'DiGi\.Core\.Drawing\.Classes\.Pen')  
A Pen instance, or null if the source pen is null\.

<a name='DiGi.Core.Drawing.Convert.ToDrawing(thisDiGi.Core.Drawing.Classes.Pen)'></a>

## Convert\.ToDrawing\(this Pen\) Method

Converts a DiGi Pen to a System\.Drawing\.Pen\.

```csharp
public static System.Drawing.Pen? ToDrawing(this DiGi.Core.Drawing.Classes.Pen? pen);
```
#### Parameters

<a name='DiGi.Core.Drawing.Convert.ToDrawing(thisDiGi.Core.Drawing.Classes.Pen).pen'></a>

`pen` [Pen](DiGi.Core.Drawing.Classes.md#DiGi.Core.Drawing.Classes.Pen 'DiGi\.Core\.Drawing\.Classes\.Pen')

The Pen to convert\.

#### Returns
[System\.Drawing\.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen 'System\.Drawing\.Pen')  
A System\.Drawing\.Pen instance, or null if the source pen is null\.

<a name='DiGi.Core.Drawing.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Core.Drawing.Query.CompareByPixels(thisSystem.Drawing.Image,System.Drawing.Image)'></a>

## Query\.CompareByPixels\(this Image, Image\) Method

Compares two images by checking if all corresponding pixels are identical\.

```csharp
public static bool CompareByPixels(this System.Drawing.Image? image_1, System.Drawing.Image? image_2);
```
#### Parameters

<a name='DiGi.Core.Drawing.Query.CompareByPixels(thisSystem.Drawing.Image,System.Drawing.Image).image_1'></a>

`image_1` [System\.Drawing\.Image](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.image 'System\.Drawing\.Image')

The first image to compare\.

<a name='DiGi.Core.Drawing.Query.CompareByPixels(thisSystem.Drawing.Image,System.Drawing.Image).image_2'></a>

`image_2` [System\.Drawing\.Image](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.image 'System\.Drawing\.Image')

The second image to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if both images are identical in size and pixel data; otherwise, false\.