#### [DiGi\.Core\.IO](index.md 'index')

## DiGi\.Core\.IO\.FileWatcher Namespace
### Classes

<a name='DiGi.Core.IO.FileWatcher.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Core.IO.FileWatcher.Create.ConfigurationFile(thisDiGi.Core.IO.FileWatcher.Classes.FileWatcher,System.Text.Encoding)'></a>

## Create\.ConfigurationFile\(this FileWatcher, Encoding\) Method

Converts a [FileWatcher](DiGi.Core.IO.FileWatcher.Classes.md#DiGi.Core.IO.FileWatcher.Classes.FileWatcher 'DiGi\.Core\.IO\.FileWatcher\.Classes\.FileWatcher') to a [ConfigurationFile\(this FileWatcher, Encoding\)](DiGi.Core.IO.FileWatcher.md#DiGi.Core.IO.FileWatcher.Create.ConfigurationFile(thisDiGi.Core.IO.FileWatcher.Classes.FileWatcher,System.Text.Encoding) 'DiGi\.Core\.IO\.FileWatcher\.Create\.ConfigurationFile\(this DiGi\.Core\.IO\.FileWatcher\.Classes\.FileWatcher, System\.Text\.Encoding\)')\.

```csharp
public static DiGi.Core.Classes.ConfigurationFile? ConfigurationFile(this DiGi.Core.IO.FileWatcher.Classes.FileWatcher? fileWatcher, System.Text.Encoding? encoding=null);
```
#### Parameters

<a name='DiGi.Core.IO.FileWatcher.Create.ConfigurationFile(thisDiGi.Core.IO.FileWatcher.Classes.FileWatcher,System.Text.Encoding).fileWatcher'></a>

`fileWatcher` [FileWatcher](DiGi.Core.IO.FileWatcher.Classes.md#DiGi.Core.IO.FileWatcher.Classes.FileWatcher 'DiGi\.Core\.IO\.FileWatcher\.Classes\.FileWatcher')

The file watcher instance to convert\.

<a name='DiGi.Core.IO.FileWatcher.Create.ConfigurationFile(thisDiGi.Core.IO.FileWatcher.Classes.FileWatcher,System.Text.Encoding).encoding'></a>

`encoding` [System\.Text\.Encoding](https://learn.microsoft.com/en-us/dotnet/api/system.text.encoding 'System\.Text\.Encoding')

The encoding to use for the conversion, if any\.

#### Returns
[DiGi\.Core\.Classes\.ConfigurationFile](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.configurationfile 'DiGi\.Core\.Classes\.ConfigurationFile')  
A [ConfigurationFile\(this FileWatcher, Encoding\)](DiGi.Core.IO.FileWatcher.md#DiGi.Core.IO.FileWatcher.Create.ConfigurationFile(thisDiGi.Core.IO.FileWatcher.Classes.FileWatcher,System.Text.Encoding) 'DiGi\.Core\.IO\.FileWatcher\.Create\.ConfigurationFile\(this DiGi\.Core\.IO\.FileWatcher\.Classes\.FileWatcher, System\.Text\.Encoding\)') object, or null if the input is null\.