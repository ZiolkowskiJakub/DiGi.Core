#### [DiGi\.Core\.IO](DiGi.Core.IO.Overview.md 'DiGi\.Core\.IO\.Overview')

## DiGi\.Core\.IO\.FileWatcher\.Classes Namespace
### Classes

<a name='DiGi.Core.IO.FileWatcher.Classes.ConfigurationFileWatcher'></a>

## ConfigurationFileWatcher Class

Watches a configuration file for changes and provides access to its content\.

```csharp
public class ConfigurationFileWatcher : DiGi.Core.IO.FileWatcher.Classes.FileWatcher
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [FileWatcher](DiGi.Core.IO.FileWatcher.Classes.md#DiGi.Core.IO.FileWatcher.Classes.FileWatcher 'DiGi\.Core\.IO\.FileWatcher\.Classes\.FileWatcher') → ConfigurationFileWatcher
### Constructors

<a name='DiGi.Core.IO.FileWatcher.Classes.ConfigurationFileWatcher.ConfigurationFileWatcher(string,double,System.Text.Encoding)'></a>

## ConfigurationFileWatcher\(string, double, Encoding\) Constructor

Initializes a new instance of the [ConfigurationFileWatcher](DiGi.Core.IO.FileWatcher.Classes.md#DiGi.Core.IO.FileWatcher.Classes.ConfigurationFileWatcher 'DiGi\.Core\.IO\.FileWatcher\.Classes\.ConfigurationFileWatcher') class\.

```csharp
public ConfigurationFileWatcher(string path, double interval=5000.0, System.Text.Encoding? encoding=null);
```
#### Parameters

<a name='DiGi.Core.IO.FileWatcher.Classes.ConfigurationFileWatcher.ConfigurationFileWatcher(string,double,System.Text.Encoding).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the configuration file to watch\.

<a name='DiGi.Core.IO.FileWatcher.Classes.ConfigurationFileWatcher.ConfigurationFileWatcher(string,double,System.Text.Encoding).interval'></a>

`interval` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The interval in milliseconds between checks for changes\.

<a name='DiGi.Core.IO.FileWatcher.Classes.ConfigurationFileWatcher.ConfigurationFileWatcher(string,double,System.Text.Encoding).encoding'></a>

`encoding` [System\.Text\.Encoding](https://learn.microsoft.com/en-us/dotnet/api/system.text.encoding 'System\.Text\.Encoding')

The encoding to use when reading the file\.
### Properties

<a name='DiGi.Core.IO.FileWatcher.Classes.ConfigurationFileWatcher.ConfigurationFile'></a>

## ConfigurationFileWatcher\.ConfigurationFile Property

Gets the configuration file associated with this watcher\.

```csharp
public DiGi.Core.Classes.ConfigurationFile ConfigurationFile { get; }
```

#### Property Value
[DiGi\.Core\.Classes\.ConfigurationFile](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.configurationfile 'DiGi\.Core\.Classes\.ConfigurationFile')
### Operators

<a name='DiGi.Core.IO.FileWatcher.Classes.ConfigurationFileWatcher.op_ImplicitDiGi.Core.Classes.ConfigurationFile(DiGi.Core.IO.FileWatcher.Classes.ConfigurationFileWatcher)'></a>

## ConfigurationFileWatcher\.implicit operator ConfigurationFile\(ConfigurationFileWatcher\) Operator

Implicitly converts a [ConfigurationFileWatcher](DiGi.Core.IO.FileWatcher.Classes.md#DiGi.Core.IO.FileWatcher.Classes.ConfigurationFileWatcher 'DiGi\.Core\.IO\.FileWatcher\.Classes\.ConfigurationFileWatcher') instance to its associated [ConfigurationFile](DiGi.Core.IO.FileWatcher.Classes.md#DiGi.Core.IO.FileWatcher.Classes.ConfigurationFileWatcher.ConfigurationFile 'DiGi\.Core\.IO\.FileWatcher\.Classes\.ConfigurationFileWatcher\.ConfigurationFile')\.

```csharp
public static DiGi.Core.Classes.ConfigurationFile? implicit operator DiGi.Core.Classes.ConfigurationFile?(DiGi.Core.IO.FileWatcher.Classes.ConfigurationFileWatcher? configurationFileWatcher);
```
#### Parameters

<a name='DiGi.Core.IO.FileWatcher.Classes.ConfigurationFileWatcher.op_ImplicitDiGi.Core.Classes.ConfigurationFile(DiGi.Core.IO.FileWatcher.Classes.ConfigurationFileWatcher).configurationFileWatcher'></a>

`configurationFileWatcher` [ConfigurationFileWatcher](DiGi.Core.IO.FileWatcher.Classes.md#DiGi.Core.IO.FileWatcher.Classes.ConfigurationFileWatcher 'DiGi\.Core\.IO\.FileWatcher\.Classes\.ConfigurationFileWatcher')

The [ConfigurationFileWatcher](DiGi.Core.IO.FileWatcher.Classes.md#DiGi.Core.IO.FileWatcher.Classes.ConfigurationFileWatcher 'DiGi\.Core\.IO\.FileWatcher\.Classes\.ConfigurationFileWatcher') instance to convert\.

#### Returns
[DiGi\.Core\.Classes\.ConfigurationFile](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.configurationfile 'DiGi\.Core\.Classes\.ConfigurationFile')  
The [ConfigurationFile](DiGi.Core.IO.FileWatcher.Classes.md#DiGi.Core.IO.FileWatcher.Classes.ConfigurationFileWatcher.ConfigurationFile 'DiGi\.Core\.IO\.FileWatcher\.Classes\.ConfigurationFileWatcher\.ConfigurationFile') associated with the watcher, or null if the watcher is null\.

<a name='DiGi.Core.IO.FileWatcher.Classes.FileWatcher'></a>

## FileWatcher Class

Monitors any file and reloads its binary content only if the hash has changed\.

```csharp
public class FileWatcher : System.IDisposable, DiGi.Core.IO.Interfaces.IIOObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → FileWatcher

Derived  
↳ [ConfigurationFileWatcher](DiGi.Core.IO.FileWatcher.Classes.md#DiGi.Core.IO.FileWatcher.Classes.ConfigurationFileWatcher 'DiGi\.Core\.IO\.FileWatcher\.Classes\.ConfigurationFileWatcher')  
↳ [FileWatcher&lt;TFile&gt;](DiGi.Core.IO.FileWatcher.Classes.md#DiGi.Core.IO.FileWatcher.Classes.FileWatcher_TFile_ 'DiGi\.Core\.IO\.FileWatcher\.Classes\.FileWatcher\<TFile\>')

Implements [System\.IDisposable](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable 'System\.IDisposable'), [DiGi\.Core\.IO\.Interfaces\.IIOObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.interfaces.iioobject 'DiGi\.Core\.IO\.Interfaces\.IIOObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.Core.IO.FileWatcher.Classes.FileWatcher.FileWatcher(string,double)'></a>

## FileWatcher\(string, double\) Constructor

Initializes a new instance of the FileWatcher class to monitor changes to the specified file at a given
interval\.

```csharp
public FileWatcher(string path, double interval=5000.0);
```
#### Parameters

<a name='DiGi.Core.IO.FileWatcher.Classes.FileWatcher.FileWatcher(string,double).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The full path to the file to be monitored\. The file must exist at the time of initialization\.

<a name='DiGi.Core.IO.FileWatcher.Classes.FileWatcher.FileWatcher(string,double).interval'></a>

`interval` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The interval, in milliseconds, at which the file is checked for changes\. The default is 5000 milliseconds\.

#### Exceptions

[System\.IO\.FileNotFoundException](https://learn.microsoft.com/en-us/dotnet/api/system.io.filenotfoundexception 'System\.IO\.FileNotFoundException')  
Thrown if the file specified by path does not exist\.
### Properties

<a name='DiGi.Core.IO.FileWatcher.Classes.FileWatcher.Bytes'></a>

## FileWatcher\.Bytes Property

Gets the raw bytes of the file content\.

```csharp
public byte[]? Bytes { get; }
```

#### Property Value
[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Core.IO.FileWatcher.Classes.FileWatcher.Interval'></a>

## FileWatcher\.Interval Property

Gets or sets the interval in milliseconds between checks for file changes\.

```csharp
public double Interval { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.IO.FileWatcher.Classes.FileWatcher.Path'></a>

## FileWatcher\.Path Property

Gets the path to the file being watched\.

```csharp
public string Path { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Core.IO.FileWatcher.Classes.FileWatcher.Dispose()'></a>

## FileWatcher\.Dispose\(\) Method

Releases all resources used by the watcher\.

```csharp
public void Dispose();
```

Implements [Dispose\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable.dispose 'System\.IDisposable\.Dispose')

<a name='DiGi.Core.IO.FileWatcher.Classes.FileWatcher.GetLines(System.Text.Encoding)'></a>

## FileWatcher\.GetLines\(Encoding\) Method

Reads the content of the file as an array of strings\.

```csharp
public string[]? GetLines(System.Text.Encoding? encoding=null);
```
#### Parameters

<a name='DiGi.Core.IO.FileWatcher.Classes.FileWatcher.GetLines(System.Text.Encoding).encoding'></a>

`encoding` [System\.Text\.Encoding](https://learn.microsoft.com/en-us/dotnet/api/system.text.encoding 'System\.Text\.Encoding')

The encoding to use when reading the file\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of strings containing the lines of the file\.

<a name='DiGi.Core.IO.FileWatcher.Classes.FileWatcher.GetString(System.Text.Encoding)'></a>

## FileWatcher\.GetString\(Encoding\) Method

Reads the content of the file as a single string\.

```csharp
public string GetString(System.Text.Encoding? encoding=null);
```
#### Parameters

<a name='DiGi.Core.IO.FileWatcher.Classes.FileWatcher.GetString(System.Text.Encoding).encoding'></a>

`encoding` [System\.Text\.Encoding](https://learn.microsoft.com/en-us/dotnet/api/system.text.encoding 'System\.Text\.Encoding')

The encoding to use when reading the file\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The content of the file as a string\.

<a name='DiGi.Core.IO.FileWatcher.Classes.FileWatcher_TFile_'></a>

## FileWatcher\<TFile\> Class

Provides a base implementation for watching a file for changes\.

```csharp
public abstract class FileWatcher<TFile> : DiGi.Core.IO.FileWatcher.Classes.FileWatcher
    where TFile : DiGi.Core.IO.File.Interfaces.IFile
```
#### Type parameters

<a name='DiGi.Core.IO.FileWatcher.Classes.FileWatcher_TFile_.TFile'></a>

`TFile`

The type of the file being watched\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [FileWatcher](DiGi.Core.IO.FileWatcher.Classes.md#DiGi.Core.IO.FileWatcher.Classes.FileWatcher 'DiGi\.Core\.IO\.FileWatcher\.Classes\.FileWatcher') → FileWatcher\<TFile\>
### Constructors

<a name='DiGi.Core.IO.FileWatcher.Classes.FileWatcher_TFile_.FileWatcher(string,double)'></a>

## FileWatcher\(string, double\) Constructor

Initializes a new instance of the [FileWatcher](DiGi.Core.IO.FileWatcher.Classes.md#DiGi.Core.IO.FileWatcher.Classes.FileWatcher 'DiGi\.Core\.IO\.FileWatcher\.Classes\.FileWatcher') class\.

```csharp
public FileWatcher(string path, double interval=60000.0);
```
#### Parameters

<a name='DiGi.Core.IO.FileWatcher.Classes.FileWatcher_TFile_.FileWatcher(string,double).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the file to watch\.

<a name='DiGi.Core.IO.FileWatcher.Classes.FileWatcher_TFile_.FileWatcher(string,double).interval'></a>

`interval` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The interval in milliseconds between checks for changes\.
### Properties

<a name='DiGi.Core.IO.FileWatcher.Classes.FileWatcher_TFile_.File'></a>

## FileWatcher\<TFile\>\.File Property

Gets the file object being watched\.

```csharp
public TFile? File { get; }
```

#### Property Value
[TFile](DiGi.Core.IO.FileWatcher.Classes.md#DiGi.Core.IO.FileWatcher.Classes.FileWatcher_TFile_.TFile 'DiGi\.Core\.IO\.FileWatcher\.Classes\.FileWatcher\<TFile\>\.TFile')