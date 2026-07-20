#### [DiGi\.Core\.Parameter](DiGi.Core.Parameter.Overview.md 'DiGi\.Core\.Parameter\.Overview')

## DiGi\.Core\.Parameter\.Interfaces Namespace
### Interfaces

<a name='DiGi.Core.Parameter.Interfaces.IParameterDefinition'></a>

## IParameterDefinition Interface

Defines the contract for a parameter definition\.

```csharp
public interface IParameterDefinition : DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, System.IEquatable<DiGi.Core.Parameter.Interfaces.IParameterDefinition>, DiGi.Core.Interfaces.INamedObject
```

Derived  
↳ [ParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ParameterDefinition')

Implements [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject')
### Properties

<a name='DiGi.Core.Parameter.Interfaces.IParameterDefinition.GroupName'></a>

## IParameterDefinition\.GroupName Property

Gets the group name to which this parameter belongs\.

```csharp
string? GroupName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Parameter.Interfaces.IParameterDefinition.ParameterType'></a>

## IParameterDefinition\.ParameterType Property

Gets the type of the parameter\.

```csharp
DiGi.Core.Parameter.Enums.ParameterType ParameterType { get; }
```

#### Property Value
[ParameterType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.ParameterType 'DiGi\.Core\.Parameter\.Enums\.ParameterType')

<a name='DiGi.Core.Parameter.Interfaces.IParameterDefinition.UniqueId'></a>

## IParameterDefinition\.UniqueId Property

Gets the unique identifier of the parameter definition\.

```csharp
string? UniqueId { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.Core.Parameter.Interfaces.IParameterDefinition.IsValid(object)'></a>

## IParameterDefinition\.IsValid\(object\) Method

Determines whether the specified value is valid for this parameter definition\.

```csharp
bool IsValid(object? value);
```
#### Parameters

<a name='DiGi.Core.Parameter.Interfaces.IParameterDefinition.IsValid(object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to validate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value is valid, false otherwise\.

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedGuidObject'></a>

## IParametrizedGuidObject Interface

Defines the contract for a GUID\-based unique object that can be parameterized\.

```csharp
public interface IParametrizedGuidObject : DiGi.Core.Parameter.Interfaces.IParametrizedUniqueObject, DiGi.Core.Parameter.Interfaces.IParametrizedObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IUniqueIdObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.IGuidObject
```

Derived  
↳ [ParametrizedGuidObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedGuidObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject')

Implements [IParametrizedUniqueObject](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedUniqueObject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedUniqueObject'), [IParametrizedObject](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedObject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.IUniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueidobject 'DiGi\.Core\.Interfaces\.IUniqueIdObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject')

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedObject'></a>

## IParametrizedObject Interface

Defines the contract for an object that can be parameterized\.

```csharp
public interface IParametrizedObject : DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [ParametrizedGuidObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedGuidObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject')  
↳ [ParametrizedObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedObject')  
↳ [ParametrizedUniqueIdObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedUniqueIdObject')  
↳ [IParametrizedGuidObject](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedGuidObject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedGuidObject')  
↳ [IParametrizedUniqueIdObject](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedUniqueIdObject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedUniqueIdObject')  
↳ [IParametrizedUniqueObject](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedUniqueObject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedUniqueObject')

Implements [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Methods

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedObject.GetParameterDefinitions_TParameterDefinition_()'></a>

## IParametrizedObject\.GetParameterDefinitions\<TParameterDefinition\>\(\) Method

Gets a list of parameter definitions of the specified type\.

```csharp
System.Collections.Generic.List<TParameterDefinition>? GetParameterDefinitions<TParameterDefinition>()
    where TParameterDefinition : DiGi.Core.Parameter.Interfaces.IParameterDefinition;
```
#### Type parameters

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedObject.GetParameterDefinitions_TParameterDefinition_().TParameterDefinition'></a>

`TParameterDefinition`

The type of the parameter definition\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedObject.GetParameterDefinitions_TParameterDefinition_().TParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject\.GetParameterDefinitions\<TParameterDefinition\>\(\)\.TParameterDefinition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the matching parameter definitions, or null\.

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedObject.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## IParametrizedObject\.GetValue\<T\>\(GetValueSettings\) Method

Gets the first parameter value converted to type [T](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedObject.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject\.GetValue\<T\>\(DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')\.

```csharp
T? GetValue<T>(DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedObject.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The type of the parameter value to retrieve\.
#### Parameters

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedObject.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings for retrieving the value\.

#### Returns
[T](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedObject.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject\.GetValue\<T\>\(DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')  
The value of type [T](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedObject.GetValue_T_(DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject\.GetValue\<T\>\(DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T'), or default if not found\.

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedObject.Remove(DiGi.Core.Parameter.Interfaces.IParameterDefinition)'></a>

## IParametrizedObject\.Remove\(IParameterDefinition\) Method

Removes the specified parameter definition from the object\.

```csharp
bool Remove(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition);
```
#### Parameters

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedObject.Remove(DiGi.Core.Parameter.Interfaces.IParameterDefinition).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the parameter was removed, false otherwise\.

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedObject.SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings)'></a>

## IParametrizedObject\.SetValue\(IParameterDefinition, object, SetValueSettings\) Method

Sets the value of the specified parameter\.

```csharp
bool SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition, object? value, DiGi.Core.Parameter.Classes.SetValueSettings? setValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedObject.SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition to set\.

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedObject.SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to set\.

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedObject.SetValue(DiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings).setValueSettings'></a>

`setValueSettings` [SetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.SetValueSettings 'DiGi\.Core\.Parameter\.Classes\.SetValueSettings')

Optional settings for setting the value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully set, false otherwise\.

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedObject.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings)'></a>

## IParametrizedObject\.TryGetValue\<T\>\(IParameterDefinition, T, GetValueSettings\) Method

Tries to get the value of the specified parameter\.

```csharp
bool TryGetValue<T>(DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition, out T? value, DiGi.Core.Parameter.Classes.GetValueSettings? getValueSettings=null);
```
#### Type parameters

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedObject.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).T'></a>

`T`

The expected type of the parameter value\.
#### Parameters

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedObject.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The parameter definition to retrieve\.

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedObject.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).value'></a>

`value` [T](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedObject.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).T 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject\.TryGetValue\<T\>\(DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition, T, DiGi\.Core\.Parameter\.Classes\.GetValueSettings\)\.T')

The retrieved value, or default if not found\.

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedObject.TryGetValue_T_(DiGi.Core.Parameter.Interfaces.IParameterDefinition,T,DiGi.Core.Parameter.Classes.GetValueSettings).getValueSettings'></a>

`getValueSettings` [GetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.GetValueSettings 'DiGi\.Core\.Parameter\.Classes\.GetValueSettings')

Optional settings for retrieving the value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value was successfully retrieved, false otherwise\.

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedUniqueIdObject'></a>

## IParametrizedUniqueIdObject Interface

Defines the contract for a unique ID object that can be parameterized\.

```csharp
public interface IParametrizedUniqueIdObject : DiGi.Core.Parameter.Interfaces.IParametrizedUniqueObject, DiGi.Core.Parameter.Interfaces.IParametrizedObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IUniqueIdObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [ParametrizedUniqueIdObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedUniqueIdObject')

Implements [IParametrizedUniqueObject](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedUniqueObject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedUniqueObject'), [IParametrizedObject](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedObject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.IUniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueidobject 'DiGi\.Core\.Interfaces\.IUniqueIdObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')

<a name='DiGi.Core.Parameter.Interfaces.IParametrizedUniqueObject'></a>

## IParametrizedUniqueObject Interface

Defines the contract for a unique object that can be parameterized\.

```csharp
public interface IParametrizedUniqueObject : DiGi.Core.Parameter.Interfaces.IParametrizedObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IUniqueIdObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [ParametrizedGuidObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedGuidObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedGuidObject')  
↳ [ParametrizedUniqueIdObject](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParametrizedUniqueIdObject 'DiGi\.Core\.Parameter\.Classes\.ParametrizedUniqueIdObject')  
↳ [IParametrizedGuidObject](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedGuidObject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedGuidObject')  
↳ [IParametrizedUniqueIdObject](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedUniqueIdObject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedUniqueIdObject')

Implements [IParametrizedObject](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParametrizedObject 'DiGi\.Core\.Parameter\.Interfaces\.IParametrizedObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.IUniqueIdObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueidobject 'DiGi\.Core\.Interfaces\.IUniqueIdObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject')