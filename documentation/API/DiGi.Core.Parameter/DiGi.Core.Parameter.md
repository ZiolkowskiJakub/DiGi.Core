#### [DiGi\.Core\.Parameter](DiGi.Core.Parameter.Overview.md 'DiGi\.Core\.Parameter\.Overview')

## DiGi\.Core\.Parameter Namespace
### Classes

<a name='DiGi.Core.Parameter.Create'></a>

## Create Class

Provides factory methods for creating parameter\-related objects\.

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Core.Parameter.Create.ExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.ParameterType,System.Type,DiGi.Core.Parameter.Enums.AccessType,bool,string)'></a>

## Create\.ExternalParameterDefinition\(Guid, string, string, ParameterType, Type, AccessType, bool, string\) Method

Creates a new external parameter definition with the specified properties\.

```csharp
public static DiGi.Core.Parameter.Classes.ExternalParameterDefinition? ExternalParameterDefinition(System.Guid guid, string? name, string? description, DiGi.Core.Parameter.Enums.ParameterType parameterType, System.Type? type, DiGi.Core.Parameter.Enums.AccessType accessType=DiGi.Core.Parameter.Enums.AccessType.ReadWrite, bool nullable=true, string? groupName=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Create.ExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.ParameterType,System.Type,DiGi.Core.Parameter.Enums.AccessType,bool,string).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the parameter\.

<a name='DiGi.Core.Parameter.Create.ExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.ParameterType,System.Type,DiGi.Core.Parameter.Enums.AccessType,bool,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Core.Parameter.Create.ExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.ParameterType,System.Type,DiGi.Core.Parameter.Enums.AccessType,bool,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

A description of the parameter\.

<a name='DiGi.Core.Parameter.Create.ExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.ParameterType,System.Type,DiGi.Core.Parameter.Enums.AccessType,bool,string).parameterType'></a>

`parameterType` [ParameterType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.ParameterType 'DiGi\.Core\.Parameter\.Enums\.ParameterType')

The type category of the parameter\.

<a name='DiGi.Core.Parameter.Create.ExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.ParameterType,System.Type,DiGi.Core.Parameter.Enums.AccessType,bool,string).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The underlying system type of the parameter\.

<a name='DiGi.Core.Parameter.Create.ExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.ParameterType,System.Type,DiGi.Core.Parameter.Enums.AccessType,bool,string).accessType'></a>

`accessType` [AccessType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.AccessType 'DiGi\.Core\.Parameter\.Enums\.AccessType')

The access level of the parameter\.

<a name='DiGi.Core.Parameter.Create.ExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.ParameterType,System.Type,DiGi.Core.Parameter.Enums.AccessType,bool,string).nullable'></a>

`nullable` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether the parameter can be null\.

<a name='DiGi.Core.Parameter.Create.ExternalParameterDefinition(System.Guid,string,string,DiGi.Core.Parameter.Enums.ParameterType,System.Type,DiGi.Core.Parameter.Enums.AccessType,bool,string).groupName'></a>

`groupName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the group this parameter belongs to\.

#### Returns
[ExternalParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ExternalParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ExternalParameterDefinition')  
A new instance of [ExternalParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ExternalParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ExternalParameterDefinition'), or null if creation fails\.

<a name='DiGi.Core.Parameter.Create.ExternalParameterDefinition(System.Guid,string,string,double,double,System.Type,DiGi.Core.Parameter.Enums.AccessType,bool,string)'></a>

## Create\.ExternalParameterDefinition\(Guid, string, string, double, double, Type, AccessType, bool, string\) Method

Creates a new external parameter definition with specified range constraints\.

```csharp
public static DiGi.Core.Parameter.Classes.ExternalParameterDefinition? ExternalParameterDefinition(System.Guid guid, string? name, string? description, double min, double max, System.Type? type, DiGi.Core.Parameter.Enums.AccessType accessType=DiGi.Core.Parameter.Enums.AccessType.ReadWrite, bool nullable=true, string? groupName=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Create.ExternalParameterDefinition(System.Guid,string,string,double,double,System.Type,DiGi.Core.Parameter.Enums.AccessType,bool,string).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The unique identifier for the parameter\.

<a name='DiGi.Core.Parameter.Create.ExternalParameterDefinition(System.Guid,string,string,double,double,System.Type,DiGi.Core.Parameter.Enums.AccessType,bool,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Core.Parameter.Create.ExternalParameterDefinition(System.Guid,string,string,double,double,System.Type,DiGi.Core.Parameter.Enums.AccessType,bool,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

A description of the parameter\.

<a name='DiGi.Core.Parameter.Create.ExternalParameterDefinition(System.Guid,string,string,double,double,System.Type,DiGi.Core.Parameter.Enums.AccessType,bool,string).min'></a>

`min` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimum value constraint\.

<a name='DiGi.Core.Parameter.Create.ExternalParameterDefinition(System.Guid,string,string,double,double,System.Type,DiGi.Core.Parameter.Enums.AccessType,bool,string).max'></a>

`max` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum value constraint\.

<a name='DiGi.Core.Parameter.Create.ExternalParameterDefinition(System.Guid,string,string,double,double,System.Type,DiGi.Core.Parameter.Enums.AccessType,bool,string).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type of the parameter\.

<a name='DiGi.Core.Parameter.Create.ExternalParameterDefinition(System.Guid,string,string,double,double,System.Type,DiGi.Core.Parameter.Enums.AccessType,bool,string).accessType'></a>

`accessType` [AccessType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.AccessType 'DiGi\.Core\.Parameter\.Enums\.AccessType')

The access level of the parameter\.

<a name='DiGi.Core.Parameter.Create.ExternalParameterDefinition(System.Guid,string,string,double,double,System.Type,DiGi.Core.Parameter.Enums.AccessType,bool,string).nullable'></a>

`nullable` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether the parameter can be null\.

<a name='DiGi.Core.Parameter.Create.ExternalParameterDefinition(System.Guid,string,string,double,double,System.Type,DiGi.Core.Parameter.Enums.AccessType,bool,string).groupName'></a>

`groupName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the group this parameter belongs to\.

#### Returns
[ExternalParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ExternalParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ExternalParameterDefinition')  
A new instance of [ExternalParameterDefinition](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ExternalParameterDefinition 'DiGi\.Core\.Parameter\.Classes\.ExternalParameterDefinition'), or null if creation fails\.

<a name='DiGi.Core.Parameter.Create.JsonArray(thisSystem.Collections.Generic.IEnumerable_System.Type_)'></a>

## Create\.JsonArray\(this IEnumerable\<Type\>\) Method

Converts a collection of types to a JsonArray\.

```csharp
public static System.Text.Json.Nodes.JsonArray? JsonArray(this System.Collections.Generic.IEnumerable<System.Type>? types);
```
#### Parameters

<a name='DiGi.Core.Parameter.Create.JsonArray(thisSystem.Collections.Generic.IEnumerable_System.Type_).types'></a>

`types` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of types to convert\.

#### Returns
[System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')  
A JsonArray containing the full type names, or null if the input is null\.

<a name='DiGi.Core.Parameter.Create.Parameter(string,object)'></a>

## Create\.Parameter\(string, object\) Method

Creates a parameter using a specified name and value\.

```csharp
public static DiGi.Core.Parameter.Classes.Parameter? Parameter(string? name, object? value);
```
#### Parameters

<a name='DiGi.Core.Parameter.Create.Parameter(string,object).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the parameter\.

<a name='DiGi.Core.Parameter.Create.Parameter(string,object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to assign to the parameter\.

#### Returns
[Parameter](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.Parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')  
A [Parameter](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.Parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter') instance, or null\.

<a name='DiGi.Core.Parameter.Create.Parameter(thisDiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings)'></a>

## Create\.Parameter\(this IParameterDefinition, object, SetValueSettings\) Method

Creates a parameter based on the provided definition and value\.

```csharp
public static DiGi.Core.Parameter.Classes.Parameter? Parameter(this DiGi.Core.Parameter.Interfaces.IParameterDefinition? parameterDefinition, object? value, DiGi.Core.Parameter.Classes.SetValueSettings? setValueSettings=null);
```
#### Parameters

<a name='DiGi.Core.Parameter.Create.Parameter(thisDiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings).parameterDefinition'></a>

`parameterDefinition` [IParameterDefinition](DiGi.Core.Parameter.Interfaces.md#DiGi.Core.Parameter.Interfaces.IParameterDefinition 'DiGi\.Core\.Parameter\.Interfaces\.IParameterDefinition')

The definition of the parameter\.

<a name='DiGi.Core.Parameter.Create.Parameter(thisDiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to assign to the parameter\.

<a name='DiGi.Core.Parameter.Create.Parameter(thisDiGi.Core.Parameter.Interfaces.IParameterDefinition,object,DiGi.Core.Parameter.Classes.SetValueSettings).setValueSettings'></a>

`setValueSettings` [SetValueSettings](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.SetValueSettings 'DiGi\.Core\.Parameter\.Classes\.SetValueSettings')

Optional settings for setting the value\.

#### Returns
[Parameter](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.Parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter')  
A [Parameter](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.Parameter 'DiGi\.Core\.Parameter\.Classes\.Parameter') instance, or null\.

<a name='DiGi.Core.Parameter.Create.Types(thisSystem.Text.Json.Nodes.JsonArray)'></a>

## Create\.Types\(this JsonArray\) Method

Converts a JsonArray to a list of types\.

```csharp
public static System.Collections.Generic.List<System.Type>? Types(this System.Text.Json.Nodes.JsonArray? jsonArray);
```
#### Parameters

<a name='DiGi.Core.Parameter.Create.Types(thisSystem.Text.Json.Nodes.JsonArray).jsonArray'></a>

`jsonArray` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The JsonArray to convert\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of types, or null if the input is null\.

<a name='DiGi.Core.Parameter.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.Core.Parameter.Query.AssociatedTypes(System.Type)'></a>

## Query\.AssociatedTypes\(Type\) Method

Retrieves the associated types for the specified type\.

```csharp
public static DiGi.Core.Parameter.Classes.AssociatedTypes? AssociatedTypes(System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Parameter.Query.AssociatedTypes(System.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type for which to retrieve associated types\.

#### Returns
[AssociatedTypes](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.AssociatedTypes 'DiGi\.Core\.Parameter\.Classes\.AssociatedTypes')  
The associated types for the specified type, or null if none are found\.

<a name='DiGi.Core.Parameter.Query.Description(thisSystem.Enum)'></a>

## Query\.Description\(this Enum\) Method

Gets the description of the specified enumeration value\.

```csharp
public static string? Description(this System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Core.Parameter.Query.Description(thisSystem.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value for which to get the description\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The description of the specified enumeration value, or null if no description is found\.

<a name='DiGi.Core.Parameter.Query.Description(thisSystem.Type)'></a>

## Query\.Description\(this Type\) Method

Gets the description of the specified type\.

```csharp
public static string? Description(this System.Type? type);
```
#### Parameters

<a name='DiGi.Core.Parameter.Query.Description(thisSystem.Type).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type for which to get the description\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The description of the specified type, or null if no description is found\.

<a name='DiGi.Core.Parameter.Query.IsValid(thisDiGi.Core.Parameter.Enums.ParameterType,object)'></a>

## Query\.IsValid\(this ParameterType, object\) Method

Validates whether the provided value is valid for the given parameter type\.

```csharp
public static bool IsValid(this DiGi.Core.Parameter.Enums.ParameterType parameterType, object? value);
```
#### Parameters

<a name='DiGi.Core.Parameter.Query.IsValid(thisDiGi.Core.Parameter.Enums.ParameterType,object).parameterType'></a>

`parameterType` [ParameterType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.ParameterType 'DiGi\.Core\.Parameter\.Enums\.ParameterType')

The parameter type to validate against\.

<a name='DiGi.Core.Parameter.Query.IsValid(thisDiGi.Core.Parameter.Enums.ParameterType,object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The value to be validated\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value is valid for the specified parameter type; otherwise, false\.

<a name='DiGi.Core.Parameter.Query.ParameterProperties(System.Enum)'></a>

## Query\.ParameterProperties\(Enum\) Method

Retrieves the properties associated with the specified enumeration value\.

```csharp
public static DiGi.Core.Parameter.Classes.ParameterProperties? ParameterProperties(System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Core.Parameter.Query.ParameterProperties(System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value to retrieve properties for\.

#### Returns
[ParameterProperties](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterProperties 'DiGi\.Core\.Parameter\.Classes\.ParameterProperties')  
The [ParameterProperties](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterProperties 'DiGi\.Core\.Parameter\.Classes\.ParameterProperties') associated with the specified enumeration, or `null` if not found\.

<a name='DiGi.Core.Parameter.Query.ParameterProperties(System.Type,string)'></a>

## Query\.ParameterProperties\(Type, string\) Method

Retrieves the properties associated with the specified type and identifier\.

```csharp
public static DiGi.Core.Parameter.Classes.ParameterProperties? ParameterProperties(System.Type? type, string? text);
```
#### Parameters

<a name='DiGi.Core.Parameter.Query.ParameterProperties(System.Type,string).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to retrieve properties for\.

<a name='DiGi.Core.Parameter.Query.ParameterProperties(System.Type,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The identifier text used to look up the properties\.

#### Returns
[ParameterProperties](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterProperties 'DiGi\.Core\.Parameter\.Classes\.ParameterProperties')  
The [ParameterProperties](DiGi.Core.Parameter.Classes.md#DiGi.Core.Parameter.Classes.ParameterProperties 'DiGi\.Core\.Parameter\.Classes\.ParameterProperties') associated with the specified type and text, or `null` if not found\.

<a name='DiGi.Core.Parameter.Query.ParameterType(System.Enum)'></a>

## Query\.ParameterType\(Enum\) Method

Gets the parameter type for the specified enumeration value\.

```csharp
public static DiGi.Core.Parameter.Enums.ParameterType ParameterType(System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Core.Parameter.Query.ParameterType(System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration value\.

#### Returns
[ParameterType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.ParameterType 'DiGi\.Core\.Parameter\.Enums\.ParameterType')  
The corresponding [ParameterType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.ParameterType 'DiGi\.Core\.Parameter\.Enums\.ParameterType')\.

<a name='DiGi.Core.Parameter.Query.ParameterType(System.Type,string)'></a>

## Query\.ParameterType\(Type, string\) Method

Gets the parameter type for the specified type and identifier\.

```csharp
public static DiGi.Core.Parameter.Enums.ParameterType ParameterType(System.Type? type, string? text);
```
#### Parameters

<a name='DiGi.Core.Parameter.Query.ParameterType(System.Type,string).type'></a>

`type` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to evaluate\.

<a name='DiGi.Core.Parameter.Query.ParameterType(System.Type,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The identifier text\.

#### Returns
[ParameterType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.ParameterType 'DiGi\.Core\.Parameter\.Enums\.ParameterType')  
The corresponding [ParameterType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.ParameterType 'DiGi\.Core\.Parameter\.Enums\.ParameterType')\.

<a name='DiGi.Core.Parameter.Query.ParameterValue_TParameterValue_(System.Enum)'></a>

## Query\.ParameterValue\<TParameterValue\>\(Enum\) Method

Retrieves the parameter value associated with the specified enumeration\.

```csharp
public static TParameterValue? ParameterValue<TParameterValue>(System.Enum? @enum)
    where TParameterValue : DiGi.Core.Parameter.Classes.ParameterValue;
```
#### Type parameters

<a name='DiGi.Core.Parameter.Query.ParameterValue_TParameterValue_(System.Enum).TParameterValue'></a>

`TParameterValue`

The type of the parameter value\.
#### Parameters

<a name='DiGi.Core.Parameter.Query.ParameterValue_TParameterValue_(System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration for which to retrieve the parameter value\.

#### Returns
[TParameterValue](DiGi.Core.Parameter.md#DiGi.Core.Parameter.Query.ParameterValue_TParameterValue_(System.Enum).TParameterValue 'DiGi\.Core\.Parameter\.Query\.ParameterValue\<TParameterValue\>\(System\.Enum\)\.TParameterValue')  
The parameter value associated with the specified enumeration, or null if not found\.

<a name='DiGi.Core.Parameter.Query.Read(thisDiGi.Core.Parameter.Enums.AccessType)'></a>

## Query\.Read\(this AccessType\) Method

Determines whether the specified access type allows read operations\.

```csharp
public static bool Read(this DiGi.Core.Parameter.Enums.AccessType accessType);
```
#### Parameters

<a name='DiGi.Core.Parameter.Query.Read(thisDiGi.Core.Parameter.Enums.AccessType).accessType'></a>

`accessType` [AccessType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.AccessType 'DiGi\.Core\.Parameter\.Enums\.AccessType')

The access type to check for read permissions\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the access type allows read operations; otherwise, false\.

<a name='DiGi.Core.Parameter.Query.Types(System.Enum)'></a>

## Query\.Types\(Enum\) Method

Retrieves the types associated with the specified enumeration\.

```csharp
public static System.Type[]? Types(System.Enum? @enum);
```
#### Parameters

<a name='DiGi.Core.Parameter.Query.Types(System.Enum).enum'></a>

`enum` [System\.Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum 'System\.Enum')

The enumeration to retrieve types for\.

#### Returns
[System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type') objects associated with the specified enumeration, or `null`\.

<a name='DiGi.Core.Parameter.Query.Write(thisDiGi.Core.Parameter.Enums.AccessType)'></a>

## Query\.Write\(this AccessType\) Method

Determines whether the specified access type allows write operations\.

```csharp
public static bool Write(this DiGi.Core.Parameter.Enums.AccessType accessType);
```
#### Parameters

<a name='DiGi.Core.Parameter.Query.Write(thisDiGi.Core.Parameter.Enums.AccessType).accessType'></a>

`accessType` [AccessType](DiGi.Core.Parameter.Enums.md#DiGi.Core.Parameter.Enums.AccessType 'DiGi\.Core\.Parameter\.Enums\.AccessType')

The access type to evaluate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the specified access type allows write operations; otherwise, false\.