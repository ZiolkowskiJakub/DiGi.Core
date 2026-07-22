#### [DiGi\.Core](DiGi.Core.Overview.md 'DiGi\.Core\.Overview')

## DiGi\.Core\.Interfaces Namespace
### Interfaces

<a name='DiGi.Core.Interfaces.IBackgroundTask'></a>

## IBackgroundTask Interface

Defines a contract for a task that runs in the background\.

```csharp
public interface IBackgroundTask : DiGi.Core.Interfaces.IObject
```

Derived  
↳ [BackgroundTask](DiGi.Core.Classes.md#DiGi.Core.Classes.BackgroundTask 'DiGi\.Core\.Classes\.BackgroundTask')  
↳ [CancelableBackgroundTask](DiGi.Core.Classes.md#DiGi.Core.Classes.CancelableBackgroundTask 'DiGi\.Core\.Classes\.CancelableBackgroundTask')  
↳ [ReportableBackgroundTask&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ReportableBackgroundTask_T_ 'DiGi\.Core\.Classes\.ReportableBackgroundTask\<T\>')  
↳ [ICancelableBackgroundTask](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICancelableBackgroundTask 'DiGi\.Core\.Interfaces\.ICancelableBackgroundTask')  
↳ [IReportableBackgroundTask](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReportableBackgroundTask 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask')  
↳ [IReportableBackgroundTask&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReportableBackgroundTask_T_ 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask\<T\>')

Implements [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Core.Interfaces.IBackgroundTask.BackgroundTaskStatus'></a>

## IBackgroundTask\.BackgroundTaskStatus Property

Gets the current status of the background task\.

```csharp
DiGi.Core.Enums.BackgroundTaskStatus BackgroundTaskStatus { get; }
```

#### Property Value
[BackgroundTaskStatus](DiGi.Core.Enums.md#DiGi.Core.Enums.BackgroundTaskStatus 'DiGi\.Core\.Enums\.BackgroundTaskStatus')

<a name='DiGi.Core.Interfaces.IBackgroundTask.Exception'></a>

## IBackgroundTask\.Exception Property

Gets the exception that occurred during execution, if any\.

```csharp
System.Exception? Exception { get; }
```

#### Property Value
[System\.Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception 'System\.Exception')

<a name='DiGi.Core.Interfaces.IBackgroundTask.ExecutionTimeSpan'></a>

## IBackgroundTask\.ExecutionTimeSpan Property

Gets the total time elapsed during execution\.

```csharp
System.TimeSpan ExecutionTimeSpan { get; }
```

#### Property Value
[System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan')

<a name='DiGi.Core.Interfaces.IBackgroundTask.IsRunning'></a>

## IBackgroundTask\.IsRunning Property

Gets a value indicating whether the task is currently running\.

```csharp
bool IsRunning { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')
### Methods

<a name='DiGi.Core.Interfaces.IBackgroundTask.Start()'></a>

## IBackgroundTask\.Start\(\) Method

Starts the execution of the background task\.

```csharp
void Start();
```
### Events

<a name='DiGi.Core.Interfaces.IBackgroundTask.Started'></a>

## IBackgroundTask\.Started Event

Occurs when the background task has started executing\.

```csharp
event EventHandler? Started;
```

#### Event Type
[System\.EventHandler](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler 'System\.EventHandler')

<a name='DiGi.Core.Interfaces.IBackgroundTask.Starting'></a>

## IBackgroundTask\.Starting Event

Occurs just before the background task starts executing\.

```csharp
event EventHandler? Starting;
```

#### Event Type
[System\.EventHandler](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler 'System\.EventHandler')

<a name='DiGi.Core.Interfaces.IBackgroundTask.Stopped'></a>

## IBackgroundTask\.Stopped Event

Occurs when the background task has stopped executing\.

```csharp
event EventHandler? Stopped;
```

#### Event Type
[System\.EventHandler](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler 'System\.EventHandler')

<a name='DiGi.Core.Interfaces.IBackgroundTask.Stopping'></a>

## IBackgroundTask\.Stopping Event

Occurs just before the background task stops executing\.

```csharp
event EventHandler? Stopping;
```

#### Event Type
[System\.EventHandler](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler 'System\.EventHandler')

<a name='DiGi.Core.Interfaces.ICancelableBackgroundTask'></a>

## ICancelableBackgroundTask Interface

Defines a contract for a background task that can be cancelled\.

```csharp
public interface ICancelableBackgroundTask : DiGi.Core.Interfaces.IBackgroundTask, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [CancelableBackgroundTask](DiGi.Core.Classes.md#DiGi.Core.Classes.CancelableBackgroundTask 'DiGi\.Core\.Classes\.CancelableBackgroundTask')  
↳ [ReportableBackgroundTask&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ReportableBackgroundTask_T_ 'DiGi\.Core\.Classes\.ReportableBackgroundTask\<T\>')  
↳ [IReportableBackgroundTask](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReportableBackgroundTask 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask')  
↳ [IReportableBackgroundTask&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReportableBackgroundTask_T_ 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask\<T\>')

Implements [IBackgroundTask](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IBackgroundTask 'DiGi\.Core\.Interfaces\.IBackgroundTask'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Core.Interfaces.ICancelableBackgroundTask.CancelableBackgroundTaskStatus'></a>

## ICancelableBackgroundTask\.CancelableBackgroundTaskStatus Property

Gets the current cancellation status of the background task\.

```csharp
DiGi.Core.Enums.CancelableBackgroundTaskStatus CancelableBackgroundTaskStatus { get; }
```

#### Property Value
[CancelableBackgroundTaskStatus](DiGi.Core.Enums.md#DiGi.Core.Enums.CancelableBackgroundTaskStatus 'DiGi\.Core\.Enums\.CancelableBackgroundTaskStatus')
### Methods

<a name='DiGi.Core.Interfaces.ICancelableBackgroundTask.StopAsync()'></a>

## ICancelableBackgroundTask\.StopAsync\(\) Method

Asynchronously stops the background task\.

```csharp
System.Threading.Tasks.Task StopAsync();
```

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')  
A task that represents the asynchronous stop operation\.

<a name='DiGi.Core.Interfaces.ICancellableWorker'></a>

## ICancellableWorker Interface

Defines a contract for a worker that can be cancelled\.

```csharp
public interface ICancellableWorker : DiGi.Core.Interfaces.IWorker
```

Implements [IWorker](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IWorker 'DiGi\.Core\.Interfaces\.IWorker')
### Properties

<a name='DiGi.Core.Interfaces.ICancellableWorker.CancellationPending'></a>

## ICancellableWorker\.CancellationPending Property

Gets a value indicating whether a cancellation is pending\.

```csharp
bool CancellationPending { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')
### Methods

<a name='DiGi.Core.Interfaces.ICancellableWorker.CancelAsync()'></a>

## ICancellableWorker\.CancelAsync\(\) Method

Initiates an asynchronous cancellation of the worker's operation\.

```csharp
void CancelAsync();
```

<a name='DiGi.Core.Interfaces.ICloneableObject'></a>

## ICloneableObject Interface

Defines a contract for objects that can be cloned\.

```csharp
public interface ICloneableObject : DiGi.Core.Interfaces.IObject
```

Derived  
↳ [Address](DiGi.Core.Classes.md#DiGi.Core.Classes.Address 'DiGi\.Core\.Classes\.Address')  
↳ [Coordinates](DiGi.Core.Classes.md#DiGi.Core.Classes.Coordinates 'DiGi\.Core\.Classes\.Coordinates')  
↳ [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection')  
↳ [DateTimeSeries](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeSeries 'DiGi\.Core\.Classes\.DateTimeSeries')  
↳ [Factor](DiGi.Core.Classes.md#DiGi.Core.Classes.Factor 'DiGi\.Core\.Classes\.Factor')  
↳ [GuidModel](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidModel 'DiGi\.Core\.Classes\.GuidModel')  
↳ [GuidObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidObject 'DiGi\.Core\.Classes\.GuidObject')  
↳ [GuidResult](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult 'DiGi\.Core\.Classes\.GuidResult')  
↳ [GuidResult&lt;TUniqueObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult_TUniqueObject_ 'DiGi\.Core\.Classes\.GuidResult\<TUniqueObject\>')  
↳ [SerializableModel](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableModel 'DiGi\.Core\.Classes\.SerializableModel')  
↳ [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject')  
↳ [SerializableObjectListCluster&lt;TKey\_1,TKey\_2,TValue&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>')  
↳ [SerializableObjectValueCluster&lt;TKey\_1,TKey\_2,TValue&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>')  
↳ [SerializableOptions](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableOptions 'DiGi\.Core\.Classes\.SerializableOptions')  
↳ [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference')  
↳ [SerializableResult](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult 'DiGi\.Core\.Classes\.SerializableResult')  
↳ [SerializableResult&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult_T_ 'DiGi\.Core\.Classes\.SerializableResult\<T\>')  
↳ [TypePropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypePropertyReference 'DiGi\.Core\.Classes\.TypePropertyReference')  
↳ [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')  
↳ [UniqueExternalReference&lt;TUniqueReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_ 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>')  
↳ [UniqueIdObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdObject 'DiGi\.Core\.Classes\.UniqueIdObject')  
↳ [UniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObject 'DiGi\.Core\.Classes\.UniqueObject')  
↳ [UniquePropertyReference&lt;UUniquePropertyReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_ 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>')  
↳ [UniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference 'DiGi\.Core\.Classes\.UniqueReference')  
↳ [UniqueResult](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult 'DiGi\.Core\.Classes\.UniqueResult')  
↳ [ICloneableObject&lt;TCloneableObject&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')  
↳ [ICoordinates](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICoordinates 'DiGi\.Core\.Interfaces\.ICoordinates')  
↳ [IGuidModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidModel 'DiGi\.Core\.Interfaces\.IGuidModel')  
↳ [IGuidObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidObject 'DiGi\.Core\.Interfaces\.IGuidObject')  
↳ [IGuidResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidResult 'DiGi\.Core\.Interfaces\.IGuidResult')  
↳ [IGuidResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidResult_T_ 'DiGi\.Core\.Interfaces\.IGuidResult\<T\>')  
↳ [IInstanceRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedSerializableReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedSerializableReference')  
↳ [ILocation](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ILocation 'DiGi\.Core\.Interfaces\.ILocation')  
↳ [ISerializableModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableModel 'DiGi\.Core\.Interfaces\.ISerializableModel')  
↳ [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
↳ [ISerializableOptions](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableOptions 'DiGi\.Core\.Interfaces\.ISerializableOptions')  
↳ [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference')  
↳ [ISerializableResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult 'DiGi\.Core\.Interfaces\.ISerializableResult')  
↳ [ISerializableResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult_T_ 'DiGi\.Core\.Interfaces\.ISerializableResult\<T\>')  
↳ [ITimeSeries](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITimeSeries 'DiGi\.Core\.Interfaces\.ITimeSeries')  
↳ [ITypeRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITypeRelatedSerializableReference 'DiGi\.Core\.Interfaces\.ITypeRelatedSerializableReference')  
↳ [IUniqueIdObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueIdObject 'DiGi\.Core\.Interfaces\.IUniqueIdObject')  
↳ [IUniqueObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject 'DiGi\.Core\.Interfaces\.IUniqueObject')  
↳ [IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference')  
↳ [IUniqueResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult 'DiGi\.Core\.Interfaces\.IUniqueResult')  
↳ [IUniqueResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult_T_ 'DiGi\.Core\.Interfaces\.IUniqueResult\<T\>')

Implements [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_'></a>

## ICloneableObject\<TCloneableObject\> Interface

Defines a generic contract for objects that can be cloned into a specific type\.

```csharp
public interface ICloneableObject<out TCloneableObject> : DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
    where TCloneableObject : DiGi.Core.Interfaces.ICloneableObject<TCloneableObject>
```
#### Type parameters

<a name='DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.TCloneableObject'></a>

`TCloneableObject`

The type of the clone\.

Derived  
↳ [Address](DiGi.Core.Classes.md#DiGi.Core.Classes.Address 'DiGi\.Core\.Classes\.Address')  
↳ [Coordinates](DiGi.Core.Classes.md#DiGi.Core.Classes.Coordinates 'DiGi\.Core\.Classes\.Coordinates')  
↳ [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection')  
↳ [DateTimeSeries](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeSeries 'DiGi\.Core\.Classes\.DateTimeSeries')  
↳ [Factor](DiGi.Core.Classes.md#DiGi.Core.Classes.Factor 'DiGi\.Core\.Classes\.Factor')  
↳ [GuidModel](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidModel 'DiGi\.Core\.Classes\.GuidModel')  
↳ [GuidObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidObject 'DiGi\.Core\.Classes\.GuidObject')  
↳ [GuidResult](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult 'DiGi\.Core\.Classes\.GuidResult')  
↳ [GuidResult&lt;TUniqueObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult_TUniqueObject_ 'DiGi\.Core\.Classes\.GuidResult\<TUniqueObject\>')  
↳ [SerializableModel](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableModel 'DiGi\.Core\.Classes\.SerializableModel')  
↳ [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject')  
↳ [SerializableObjectListCluster&lt;TKey\_1,TKey\_2,TValue&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>')  
↳ [SerializableObjectValueCluster&lt;TKey\_1,TKey\_2,TValue&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>')  
↳ [SerializableOptions](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableOptions 'DiGi\.Core\.Classes\.SerializableOptions')  
↳ [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference')  
↳ [SerializableResult](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult 'DiGi\.Core\.Classes\.SerializableResult')  
↳ [SerializableResult&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult_T_ 'DiGi\.Core\.Classes\.SerializableResult\<T\>')  
↳ [TypePropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypePropertyReference 'DiGi\.Core\.Classes\.TypePropertyReference')  
↳ [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')  
↳ [UniqueExternalReference&lt;TUniqueReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_ 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>')  
↳ [UniqueIdObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdObject 'DiGi\.Core\.Classes\.UniqueIdObject')  
↳ [UniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObject 'DiGi\.Core\.Classes\.UniqueObject')  
↳ [UniquePropertyReference&lt;UUniquePropertyReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_ 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>')  
↳ [UniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference 'DiGi\.Core\.Classes\.UniqueReference')  
↳ [UniqueResult](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult 'DiGi\.Core\.Classes\.UniqueResult')  
↳ [ICoordinates](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICoordinates 'DiGi\.Core\.Interfaces\.ICoordinates')  
↳ [IGuidModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidModel 'DiGi\.Core\.Interfaces\.IGuidModel')  
↳ [IGuidObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidObject 'DiGi\.Core\.Interfaces\.IGuidObject')  
↳ [IGuidResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidResult 'DiGi\.Core\.Interfaces\.IGuidResult')  
↳ [IGuidResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidResult_T_ 'DiGi\.Core\.Interfaces\.IGuidResult\<T\>')  
↳ [IInstanceRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedSerializableReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedSerializableReference')  
↳ [ILocation](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ILocation 'DiGi\.Core\.Interfaces\.ILocation')  
↳ [ISerializableModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableModel 'DiGi\.Core\.Interfaces\.ISerializableModel')  
↳ [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
↳ [ISerializableOptions](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableOptions 'DiGi\.Core\.Interfaces\.ISerializableOptions')  
↳ [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference')  
↳ [ISerializableResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult 'DiGi\.Core\.Interfaces\.ISerializableResult')  
↳ [ISerializableResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult_T_ 'DiGi\.Core\.Interfaces\.ISerializableResult\<T\>')  
↳ [ITimeSeries](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITimeSeries 'DiGi\.Core\.Interfaces\.ITimeSeries')  
↳ [ITypeRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITypeRelatedSerializableReference 'DiGi\.Core\.Interfaces\.ITypeRelatedSerializableReference')  
↳ [IUniqueIdObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueIdObject 'DiGi\.Core\.Interfaces\.IUniqueIdObject')  
↳ [IUniqueObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject 'DiGi\.Core\.Interfaces\.IUniqueObject')  
↳ [IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference')  
↳ [IUniqueResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult 'DiGi\.Core\.Interfaces\.IUniqueResult')  
↳ [IUniqueResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult_T_ 'DiGi\.Core\.Interfaces\.IUniqueResult\<T\>')

Implements [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Methods

<a name='DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.Clone()'></a>

## ICloneableObject\<TCloneableObject\>\.Clone\(\) Method

Creates a clone of the current object\.

```csharp
TCloneableObject? Clone();
```

#### Returns
[TCloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_.TCloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>\.TCloneableObject')  
A cloned instance of the object\.

<a name='DiGi.Core.Interfaces.IComplexReference'></a>

## IComplexReference Interface

Defines a contract for a complex reference to an object\.

```csharp
public interface IComplexReference : DiGi.Core.Interfaces.IReference, DiGi.Core.Interfaces.IObject, System.IEquatable<DiGi.Core.Interfaces.IReference>
```

Derived  
↳ [ComplexReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ComplexReference 'DiGi\.Core\.Classes\.ComplexReference')

Implements [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

<a name='DiGi.Core.Interfaces.ICoordinates'></a>

## ICoordinates Interface

Defines a contract for an object that represents geographic coordinates\.

```csharp
public interface ICoordinates : DiGi.Core.Interfaces.ILocation, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [Coordinates](DiGi.Core.Classes.md#DiGi.Core.Classes.Coordinates 'DiGi\.Core\.Classes\.Coordinates')

Implements [ILocation](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ILocation 'DiGi\.Core\.Interfaces\.ILocation'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Core.Interfaces.ICoordinates.Latitude'></a>

## ICoordinates\.Latitude Property

Gets the latitude coordinate\.

```csharp
double Latitude { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Interfaces.ICoordinates.Longitude'></a>

## ICoordinates\.Longitude Property

Gets the longitude coordinate\.

```csharp
double Longitude { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.Core.Interfaces.IDescribableObject'></a>

## IDescribableObject Interface

Defines a contract for an object that has a description\.

```csharp
public interface IDescribableObject : DiGi.Core.Interfaces.IObject
```

Implements [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Core.Interfaces.IDescribableObject.Description'></a>

## IDescribableObject\.Description Property

Gets the description of the object\.

```csharp
string? Description { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Interfaces.IDeterminateWorker'></a>

## IDeterminateWorker Interface

Defines a contract for a worker with determinate progress\.

```csharp
public interface IDeterminateWorker : DiGi.Core.Interfaces.IWorker
```

Implements [IWorker](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IWorker 'DiGi\.Core\.Interfaces\.IWorker')
### Properties

<a name='DiGi.Core.Interfaces.IDeterminateWorker.Maximum'></a>

## IDeterminateWorker\.Maximum Property

Gets or sets the maximum value for progress reporting\.

```csharp
double Maximum { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.Core.Interfaces.IDeterminateWorker.Report(double)'></a>

## IDeterminateWorker\.Report\(double\) Method

Reports progress with a numeric value\.

```csharp
void Report(double value);
```
#### Parameters

<a name='DiGi.Core.Interfaces.IDeterminateWorker.Report(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The current progress value\.

<a name='DiGi.Core.Interfaces.IDeterminateWorker.Report(double,string)'></a>

## IDeterminateWorker\.Report\(double, string\) Method

Reports progress with a numeric value and status text\.

```csharp
void Report(double value, string text);
```
#### Parameters

<a name='DiGi.Core.Interfaces.IDeterminateWorker.Report(double,string).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The current progress value\.

<a name='DiGi.Core.Interfaces.IDeterminateWorker.Report(double,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The status text to report\.

<a name='DiGi.Core.Interfaces.IEvaluator'></a>

## IEvaluator Interface

Base interface for all evaluation components\.

```csharp
public interface IEvaluator
```

Derived  
↳ [MultiUpdater&lt;TValue&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.MultiUpdater_TValue_ 'DiGi\.Core\.Classes\.MultiUpdater\<TValue\>')  
↳ [IOneToManySolver&lt;TInput,TOutput&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IOneToManySolver_TInput,TOutput_ 'DiGi\.Core\.Interfaces\.IOneToManySolver\<TInput,TOutput\>')  
↳ [IOneToOneSolver&lt;TInput,TOutput&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IOneToOneSolver_TInput,TOutput_ 'DiGi\.Core\.Interfaces\.IOneToOneSolver\<TInput,TOutput\>')  
↳ [ISolver](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISolver 'DiGi\.Core\.Interfaces\.ISolver')  
↳ [IUpdater](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUpdater 'DiGi\.Core\.Interfaces\.IUpdater')  
↳ [IUpdater&lt;TValue&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUpdater_TValue_ 'DiGi\.Core\.Interfaces\.IUpdater\<TValue\>')  
↳ [IValidator](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IValidator 'DiGi\.Core\.Interfaces\.IValidator')  
↳ [IValidator&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IValidator_T_ 'DiGi\.Core\.Interfaces\.IValidator\<T\>')

<a name='DiGi.Core.Interfaces.IExternalReference'></a>

## IExternalReference Interface

Defines a contract for a reference to an external object\.

```csharp
public interface IExternalReference : DiGi.Core.Interfaces.IReference, DiGi.Core.Interfaces.IObject, System.IEquatable<DiGi.Core.Interfaces.IReference>
```

Derived  
↳ [ExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference 'DiGi\.Core\.Classes\.ExternalReference')

Implements [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

<a name='DiGi.Core.Interfaces.IGuidModel'></a>

## IGuidModel Interface

Defines a contract for a model that is uniquely identified by a GUID\.

```csharp
public interface IGuidModel : DiGi.Core.Interfaces.ISerializableModel, DiGi.Core.Interfaces.IModel, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [GuidModel](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidModel 'DiGi\.Core\.Classes\.GuidModel')

Implements [ISerializableModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableModel 'DiGi\.Core\.Interfaces\.ISerializableModel'), [IModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IModel 'DiGi\.Core\.Interfaces\.IModel'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IGuidObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidObject 'DiGi\.Core\.Interfaces\.IGuidObject'), [IUniqueObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject 'DiGi\.Core\.Interfaces\.IUniqueObject')

<a name='DiGi.Core.Interfaces.IGuidObject'></a>

## IGuidObject Interface

Defines a contract for an object uniquely identified by a GUID\.

```csharp
public interface IGuidObject : DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [GuidModel](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidModel 'DiGi\.Core\.Classes\.GuidModel')  
↳ [GuidObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidObject 'DiGi\.Core\.Classes\.GuidObject')  
↳ [IGuidModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidModel 'DiGi\.Core\.Interfaces\.IGuidModel')

Implements [IUniqueObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Core.Interfaces.IGuidObject.Guid'></a>

## IGuidObject\.Guid Property

Gets the GUID of the object\.

```csharp
System.Guid Guid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')
### Methods

<a name='DiGi.Core.Interfaces.IGuidObject.Duplicate(System.Nullable_System.Guid_)'></a>

## IGuidObject\.Duplicate\(Nullable\<Guid\>\) Method

Creates a duplicate of the object with the specified GUID\.

```csharp
DiGi.Core.Interfaces.IGuidObject? Duplicate(System.Nullable<System.Guid> guid=null);
```
#### Parameters

<a name='DiGi.Core.Interfaces.IGuidObject.Duplicate(System.Nullable_System.Guid_).guid'></a>

`guid` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The GUID to use for the duplicated object\. If null, a new GUID is generated\.

#### Returns
[IGuidObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidObject 'DiGi\.Core\.Interfaces\.IGuidObject')  
A duplicated IGuidObject\.

<a name='DiGi.Core.Interfaces.IGuidResult'></a>

## IGuidResult Interface

Defines a contract for a result uniquely identified by a GUID\.

```csharp
public interface IGuidResult : DiGi.Core.Interfaces.IUniqueResult, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [GuidResult](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult 'DiGi\.Core\.Classes\.GuidResult')

Implements [IUniqueResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult 'DiGi\.Core\.Interfaces\.IUniqueResult'), [ISerializableResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [IResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IResult 'DiGi\.Core\.Interfaces\.IResult'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IUniqueObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject 'DiGi\.Core\.Interfaces\.IUniqueObject')

<a name='DiGi.Core.Interfaces.IGuidResult_T_'></a>

## IGuidResult\<T\> Interface

Defines a generic contract for a GUID\-identified result containing a value of type T\.

```csharp
public interface IGuidResult<T> : DiGi.Core.Interfaces.IUniqueResult<T>, DiGi.Core.Interfaces.IUniqueResult, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject
    where T : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Interfaces.IGuidResult_T_.T'></a>

`T`

The type of the GUID result value\.

Implements [DiGi\.Core\.Interfaces\.IUniqueResult&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult_T_ 'DiGi\.Core\.Interfaces\.IUniqueResult\<T\>')[T](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidResult_T_.T 'DiGi\.Core\.Interfaces\.IGuidResult\<T\>\.T')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult_T_ 'DiGi\.Core\.Interfaces\.IUniqueResult\<T\>'), [IUniqueResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult 'DiGi\.Core\.Interfaces\.IUniqueResult'), [ISerializableResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [IResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IResult 'DiGi\.Core\.Interfaces\.IResult'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IUniqueObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject 'DiGi\.Core\.Interfaces\.IUniqueObject')

<a name='DiGi.Core.Interfaces.IIndeterminateWorker'></a>

## IIndeterminateWorker Interface

Defines a contract for a worker with indeterminate progress\.

```csharp
public interface IIndeterminateWorker : DiGi.Core.Interfaces.IWorker
```

Implements [IWorker](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IWorker 'DiGi\.Core\.Interfaces\.IWorker')
### Methods

<a name='DiGi.Core.Interfaces.IIndeterminateWorker.Report(string)'></a>

## IIndeterminateWorker\.Report\(string\) Method

Reports status text during the operation\.

```csharp
void Report(string text);
```
#### Parameters

<a name='DiGi.Core.Interfaces.IIndeterminateWorker.Report(string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The status text to report\.

<a name='DiGi.Core.Interfaces.IIndexedObjects'></a>

## IIndexedObjects Interface

Defines a contract for an object that contains a collection of indexed objects\.

```csharp
public interface IIndexedObjects : DiGi.Core.Interfaces.IObject, System.Collections.IEnumerable
```

Derived  
↳ [IndexedObjects&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_ 'DiGi\.Core\.Classes\.IndexedObjects\<T\>')  
↳ [IIndexedObjects&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IIndexedObjects_T_ 'DiGi\.Core\.Interfaces\.IIndexedObjects\<T\>')

Implements [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')

<a name='DiGi.Core.Interfaces.IIndexedObjects_T_'></a>

## IIndexedObjects\<T\> Interface

Defines a generic contract for an object that contains a collection of indexed objects of type T\.

```csharp
public interface IIndexedObjects<T> : DiGi.Core.Interfaces.IIndexedObjects, DiGi.Core.Interfaces.IObject, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable<T>
```
#### Type parameters

<a name='DiGi.Core.Interfaces.IIndexedObjects_T_.T'></a>

`T`

The type of the indexed objects\.

Derived  
↳ [IndexedObjects&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_ 'DiGi\.Core\.Classes\.IndexedObjects\<T\>')

Implements [IIndexedObjects](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IIndexedObjects 'DiGi\.Core\.Interfaces\.IIndexedObjects'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable'), [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IIndexedObjects_T_.T 'DiGi\.Core\.Interfaces\.IIndexedObjects\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.Core.Interfaces.IInstanceRelatedReference'></a>

## IInstanceRelatedReference Interface

Defines a contract for a reference related to a specific object instance\.

```csharp
public interface IInstanceRelatedReference : DiGi.Core.Interfaces.IReference, DiGi.Core.Interfaces.IObject, System.IEquatable<DiGi.Core.Interfaces.IReference>
```

Derived  
↳ [UniqueExternalReference&lt;TUniqueReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_ 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>')  
↳ [UniquePropertyReference&lt;UUniquePropertyReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_ 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>')  
↳ [UniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference 'DiGi\.Core\.Classes\.UniqueReference')  
↳ [IInstanceRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedSerializableReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedSerializableReference')  
↳ [IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference')

Implements [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

<a name='DiGi.Core.Interfaces.IInstanceRelatedSerializableReference'></a>

## IInstanceRelatedSerializableReference Interface

Defines a contract for an instance\-related reference that can be serialized\.

```csharp
public interface IInstanceRelatedSerializableReference : DiGi.Core.Interfaces.IInstanceRelatedReference, DiGi.Core.Interfaces.IReference, DiGi.Core.Interfaces.IObject, System.IEquatable<DiGi.Core.Interfaces.IReference>, DiGi.Core.Interfaces.ISerializableReference, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [UniqueExternalReference&lt;TUniqueReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_ 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>')  
↳ [UniquePropertyReference&lt;UUniquePropertyReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_ 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>')  
↳ [UniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference 'DiGi\.Core\.Classes\.UniqueReference')  
↳ [IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference')

Implements [IInstanceRelatedReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedReference'), [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1'), [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject')

<a name='DiGi.Core.Interfaces.ILocation'></a>

## ILocation Interface

Defines a contract for an object that represents a location and is serializable\.

```csharp
public interface ILocation : DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [Address](DiGi.Core.Classes.md#DiGi.Core.Classes.Address 'DiGi\.Core\.Classes\.Address')  
↳ [Coordinates](DiGi.Core.Classes.md#DiGi.Core.Classes.Coordinates 'DiGi\.Core\.Classes\.Coordinates')  
↳ [ICoordinates](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICoordinates 'DiGi\.Core\.Interfaces\.ICoordinates')

Implements [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Core.Interfaces.IModel'></a>

## IModel Interface

Defines a contract for an object that represents a model\.

```csharp
public interface IModel : DiGi.Core.Interfaces.IObject
```

Derived  
↳ [GuidModel](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidModel 'DiGi\.Core\.Classes\.GuidModel')  
↳ [SerializableModel](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableModel 'DiGi\.Core\.Classes\.SerializableModel')  
↳ [IGuidModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidModel 'DiGi\.Core\.Interfaces\.IGuidModel')  
↳ [ISerializableModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableModel 'DiGi\.Core\.Interfaces\.ISerializableModel')

Implements [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Core.Interfaces.INamedObject'></a>

## INamedObject Interface

Defines a contract for objects that have a name\.

```csharp
public interface INamedObject : DiGi.Core.Interfaces.IObject
```

Implements [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Core.Interfaces.INamedObject.Name'></a>

## INamedObject\.Name Property

Gets the name of the object\.

```csharp
string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Interfaces.IObject'></a>

## IObject Interface

Base interface for all objects in the system\.

```csharp
public interface IObject
```

Derived  
↳ [Address](DiGi.Core.Classes.md#DiGi.Core.Classes.Address 'DiGi\.Core\.Classes\.Address')  
↳ [BackgroundTask](DiGi.Core.Classes.md#DiGi.Core.Classes.BackgroundTask 'DiGi\.Core\.Classes\.BackgroundTask')  
↳ [CancelableBackgroundTask](DiGi.Core.Classes.md#DiGi.Core.Classes.CancelableBackgroundTask 'DiGi\.Core\.Classes\.CancelableBackgroundTask')  
↳ [Cluster&lt;TKey\_1,TKey\_2,TValue&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Cluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.Cluster\<TKey\_1,TKey\_2,TValue\>')  
↳ [ComplexReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ComplexReference 'DiGi\.Core\.Classes\.ComplexReference')  
↳ [ConvertOptions](DiGi.Core.Classes.md#DiGi.Core.Classes.ConvertOptions 'DiGi\.Core\.Classes\.ConvertOptions')  
↳ [Coordinates](DiGi.Core.Classes.md#DiGi.Core.Classes.Coordinates 'DiGi\.Core\.Classes\.Coordinates')  
↳ [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection')  
↳ [DateTimeSeries](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeSeries 'DiGi\.Core\.Classes\.DateTimeSeries')  
↳ [ExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference 'DiGi\.Core\.Classes\.ExternalReference')  
↳ [Factor](DiGi.Core.Classes.md#DiGi.Core.Classes.Factor 'DiGi\.Core\.Classes\.Factor')  
↳ [GuidModel](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidModel 'DiGi\.Core\.Classes\.GuidModel')  
↳ [GuidObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidObject 'DiGi\.Core\.Classes\.GuidObject')  
↳ [GuidResult](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult 'DiGi\.Core\.Classes\.GuidResult')  
↳ [GuidResult&lt;TUniqueObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult_TUniqueObject_ 'DiGi\.Core\.Classes\.GuidResult\<TUniqueObject\>')  
↳ [IndexedObjects&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.IndexedObjects_T_ 'DiGi\.Core\.Classes\.IndexedObjects\<T\>')  
↳ [ListClusterReference&lt;TKey\_1,TKey\_2&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_ 'DiGi\.Core\.Classes\.ListClusterReference\<TKey\_1,TKey\_2\>')  
↳ [Object](DiGi.Core.Classes.md#DiGi.Core.Classes.Object 'DiGi\.Core\.Classes\.Object')  
↳ [ObjectPath&lt;TObjectPath&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath_TObjectPath_ 'DiGi\.Core\.Classes\.ObjectPath\<TObjectPath\>')  
↳ [ProgressWrapper&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ProgressWrapper_T_ 'DiGi\.Core\.Classes\.ProgressWrapper\<T\>')  
↳ [ReportableBackgroundTask&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ReportableBackgroundTask_T_ 'DiGi\.Core\.Classes\.ReportableBackgroundTask\<T\>')  
↳ [SerializableModel](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableModel 'DiGi\.Core\.Classes\.SerializableModel')  
↳ [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject')  
↳ [SerializableObjectListCluster&lt;TKey\_1,TKey\_2,TValue&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>')  
↳ [SerializableObjectValueCluster&lt;TKey\_1,TKey\_2,TValue&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>')  
↳ [SerializableOptions](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableOptions 'DiGi\.Core\.Classes\.SerializableOptions')  
↳ [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference')  
↳ [SerializableResult](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult 'DiGi\.Core\.Classes\.SerializableResult')  
↳ [SerializableResult&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult_T_ 'DiGi\.Core\.Classes\.SerializableResult\<T\>')  
↳ [TypePropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypePropertyReference 'DiGi\.Core\.Classes\.TypePropertyReference')  
↳ [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')  
↳ [UniqueExternalReference&lt;TUniqueReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_ 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>')  
↳ [UniqueIdObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdObject 'DiGi\.Core\.Classes\.UniqueIdObject')  
↳ [UniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObject 'DiGi\.Core\.Classes\.UniqueObject')  
↳ [UniquePropertyReference&lt;UUniquePropertyReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_ 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>')  
↳ [UniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference 'DiGi\.Core\.Classes\.UniqueReference')  
↳ [UniqueResult](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult 'DiGi\.Core\.Classes\.UniqueResult')  
↳ [UniqueResult&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult_T_ 'DiGi\.Core\.Classes\.UniqueResult\<T\>')  
↳ [Value&lt;TObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Value_TObject_ 'DiGi\.Core\.Classes\.Value\<TObject\>')  
↳ [IBackgroundTask](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IBackgroundTask 'DiGi\.Core\.Interfaces\.IBackgroundTask')  
↳ [ICancelableBackgroundTask](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICancelableBackgroundTask 'DiGi\.Core\.Interfaces\.ICancelableBackgroundTask')  
↳ [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject')  
↳ [ICloneableObject&lt;TCloneableObject&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')  
↳ [IComplexReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IComplexReference 'DiGi\.Core\.Interfaces\.IComplexReference')  
↳ [ICoordinates](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICoordinates 'DiGi\.Core\.Interfaces\.ICoordinates')  
↳ [IDescribableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IDescribableObject 'DiGi\.Core\.Interfaces\.IDescribableObject')  
↳ [IExternalReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IExternalReference 'DiGi\.Core\.Interfaces\.IExternalReference')  
↳ [IGuidModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidModel 'DiGi\.Core\.Interfaces\.IGuidModel')  
↳ [IGuidObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidObject 'DiGi\.Core\.Interfaces\.IGuidObject')  
↳ [IGuidResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidResult 'DiGi\.Core\.Interfaces\.IGuidResult')  
↳ [IGuidResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidResult_T_ 'DiGi\.Core\.Interfaces\.IGuidResult\<T\>')  
↳ [IIndexedObjects](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IIndexedObjects 'DiGi\.Core\.Interfaces\.IIndexedObjects')  
↳ [IIndexedObjects&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IIndexedObjects_T_ 'DiGi\.Core\.Interfaces\.IIndexedObjects\<T\>')  
↳ [IInstanceRelatedReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedReference')  
↳ [IInstanceRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedSerializableReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedSerializableReference')  
↳ [ILocation](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ILocation 'DiGi\.Core\.Interfaces\.ILocation')  
↳ [IModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IModel 'DiGi\.Core\.Interfaces\.IModel')  
↳ [INamedObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.INamedObject 'DiGi\.Core\.Interfaces\.INamedObject')  
↳ [IObjectPath](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObjectPath 'DiGi\.Core\.Interfaces\.IObjectPath')  
↳ [IObjectPath&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObjectPath_T_ 'DiGi\.Core\.Interfaces\.IObjectPath\<T\>')  
↳ [IOptions](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IOptions 'DiGi\.Core\.Interfaces\.IOptions')  
↳ [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')  
↳ [IReportableBackgroundTask](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReportableBackgroundTask 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask')  
↳ [IReportableBackgroundTask&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReportableBackgroundTask_T_ 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask\<T\>')  
↳ [IResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IResult 'DiGi\.Core\.Interfaces\.IResult')  
↳ [IResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IResult_T_ 'DiGi\.Core\.Interfaces\.IResult\<T\>')  
↳ [ISerializableModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableModel 'DiGi\.Core\.Interfaces\.ISerializableModel')  
↳ [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')  
↳ [ISerializableOptions](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableOptions 'DiGi\.Core\.Interfaces\.ISerializableOptions')  
↳ [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference')  
↳ [ISerializableResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult 'DiGi\.Core\.Interfaces\.ISerializableResult')  
↳ [ISerializableResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult_T_ 'DiGi\.Core\.Interfaces\.ISerializableResult\<T\>')  
↳ [ITimeSeries](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITimeSeries 'DiGi\.Core\.Interfaces\.ITimeSeries')  
↳ [ITypeRelatedReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITypeRelatedReference 'DiGi\.Core\.Interfaces\.ITypeRelatedReference')  
↳ [ITypeRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITypeRelatedSerializableReference 'DiGi\.Core\.Interfaces\.ITypeRelatedSerializableReference')  
↳ [IUniqueIdObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueIdObject 'DiGi\.Core\.Interfaces\.IUniqueIdObject')  
↳ [IUniqueObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject 'DiGi\.Core\.Interfaces\.IUniqueObject')  
↳ [IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference')  
↳ [IUniqueResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult 'DiGi\.Core\.Interfaces\.IUniqueResult')  
↳ [IUniqueResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult_T_ 'DiGi\.Core\.Interfaces\.IUniqueResult\<T\>')  
↳ [IValue](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IValue 'DiGi\.Core\.Interfaces\.IValue')  
↳ [IValue&lt;TValue&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IValue_TValue_ 'DiGi\.Core\.Interfaces\.IValue\<TValue\>')

<a name='DiGi.Core.Interfaces.IObjectPath'></a>

## IObjectPath Interface

Defines a contract for an object that represents a path to another object\.

```csharp
public interface IObjectPath : DiGi.Core.Interfaces.IObject
```

Derived  
↳ [ObjectPath&lt;TObjectPath&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath_TObjectPath_ 'DiGi\.Core\.Classes\.ObjectPath\<TObjectPath\>')  
↳ [IObjectPath&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObjectPath_T_ 'DiGi\.Core\.Interfaces\.IObjectPath\<T\>')

Implements [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Core.Interfaces.IObjectPath_T_'></a>

## IObjectPath\<T\> Interface

Defines a generic contract for an object path of type T\.

```csharp
public interface IObjectPath<T> : DiGi.Core.Interfaces.IObjectPath, DiGi.Core.Interfaces.IObject
    where T : DiGi.Core.Interfaces.IObjectPath<T>
```
#### Type parameters

<a name='DiGi.Core.Interfaces.IObjectPath_T_.T'></a>

`T`

The type of the object path\.

Derived  
↳ [ObjectPath&lt;TObjectPath&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ObjectPath_TObjectPath_ 'DiGi\.Core\.Classes\.ObjectPath\<TObjectPath\>')

Implements [IObjectPath](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObjectPath 'DiGi\.Core\.Interfaces\.IObjectPath'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Core.Interfaces.IOneToManySolver_TInput,TOutput_'></a>

## IOneToManySolver\<TInput,TOutput\> Interface

Defines a contract for a solver that takes one input and produces multiple outputs\.

```csharp
public interface IOneToManySolver<TInput,TOutput> : DiGi.Core.Interfaces.ISolver, DiGi.Core.Interfaces.IEvaluator
```
#### Type parameters

<a name='DiGi.Core.Interfaces.IOneToManySolver_TInput,TOutput_.TInput'></a>

`TInput`

The type of the input value\.

<a name='DiGi.Core.Interfaces.IOneToManySolver_TInput,TOutput_.TOutput'></a>

`TOutput`

The type of the output values\.

Implements [ISolver](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISolver 'DiGi\.Core\.Interfaces\.ISolver'), [IEvaluator](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IEvaluator 'DiGi\.Core\.Interfaces\.IEvaluator')
### Properties

<a name='DiGi.Core.Interfaces.IOneToManySolver_TInput,TOutput_.Input'></a>

## IOneToManySolver\<TInput,TOutput\>\.Input Property

Gets or sets the input value for the solver\.

```csharp
TInput? Input { set; }
```

#### Property Value
[TInput](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IOneToManySolver_TInput,TOutput_.TInput 'DiGi\.Core\.Interfaces\.IOneToManySolver\<TInput,TOutput\>\.TInput')

<a name='DiGi.Core.Interfaces.IOneToManySolver_TInput,TOutput_.Outputs'></a>

## IOneToManySolver\<TInput,TOutput\>\.Outputs Property

Gets the resulting list of output values from the solver\.

```csharp
System.Collections.Generic.List<TOutput>? Outputs { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[TOutput](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IOneToManySolver_TInput,TOutput_.TOutput 'DiGi\.Core\.Interfaces\.IOneToManySolver\<TInput,TOutput\>\.TOutput')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.Core.Interfaces.IOneToOneSolver_TInput,TOutput_'></a>

## IOneToOneSolver\<TInput,TOutput\> Interface

Defines a contract for a solver that takes one input and produces one output\.

```csharp
public interface IOneToOneSolver<TInput,TOutput> : DiGi.Core.Interfaces.ISolver, DiGi.Core.Interfaces.IEvaluator
```
#### Type parameters

<a name='DiGi.Core.Interfaces.IOneToOneSolver_TInput,TOutput_.TInput'></a>

`TInput`

The type of the input value\.

<a name='DiGi.Core.Interfaces.IOneToOneSolver_TInput,TOutput_.TOutput'></a>

`TOutput`

The type of the output value\.

Implements [ISolver](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISolver 'DiGi\.Core\.Interfaces\.ISolver'), [IEvaluator](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IEvaluator 'DiGi\.Core\.Interfaces\.IEvaluator')
### Properties

<a name='DiGi.Core.Interfaces.IOneToOneSolver_TInput,TOutput_.Input'></a>

## IOneToOneSolver\<TInput,TOutput\>\.Input Property

Gets or sets the input value for the solver\.

```csharp
TInput? Input { set; }
```

#### Property Value
[TInput](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IOneToOneSolver_TInput,TOutput_.TInput 'DiGi\.Core\.Interfaces\.IOneToOneSolver\<TInput,TOutput\>\.TInput')

<a name='DiGi.Core.Interfaces.IOneToOneSolver_TInput,TOutput_.Output'></a>

## IOneToOneSolver\<TInput,TOutput\>\.Output Property

Gets the resulting output value from the solver\.

```csharp
TOutput? Output { get; }
```

#### Property Value
[TOutput](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IOneToOneSolver_TInput,TOutput_.TOutput 'DiGi\.Core\.Interfaces\.IOneToOneSolver\<TInput,TOutput\>\.TOutput')

<a name='DiGi.Core.Interfaces.IOptions'></a>

## IOptions Interface

Defines a contract for an object that provides configuration options\.

```csharp
public interface IOptions : DiGi.Core.Interfaces.IObject
```

Derived  
↳ [ConvertOptions](DiGi.Core.Classes.md#DiGi.Core.Classes.ConvertOptions 'DiGi\.Core\.Classes\.ConvertOptions')  
↳ [SerializableOptions](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableOptions 'DiGi\.Core\.Classes\.SerializableOptions')  
↳ [ISerializableOptions](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableOptions 'DiGi\.Core\.Interfaces\.ISerializableOptions')

Implements [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Core.Interfaces.IReference'></a>

## IReference Interface

Defines a contract for an object that serves as a reference to another object\.

```csharp
public interface IReference : DiGi.Core.Interfaces.IObject, System.IEquatable<DiGi.Core.Interfaces.IReference>
```

Derived  
↳ [ComplexReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ComplexReference 'DiGi\.Core\.Classes\.ComplexReference')  
↳ [ExternalReference](DiGi.Core.Classes.md#DiGi.Core.Classes.ExternalReference 'DiGi\.Core\.Classes\.ExternalReference')  
↳ [ListClusterReference&lt;TKey\_1,TKey\_2&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ListClusterReference_TKey_1,TKey_2_ 'DiGi\.Core\.Classes\.ListClusterReference\<TKey\_1,TKey\_2\>')  
↳ [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference')  
↳ [TypePropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypePropertyReference 'DiGi\.Core\.Classes\.TypePropertyReference')  
↳ [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')  
↳ [UniqueExternalReference&lt;TUniqueReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_ 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>')  
↳ [UniquePropertyReference&lt;UUniquePropertyReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_ 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>')  
↳ [UniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference 'DiGi\.Core\.Classes\.UniqueReference')  
↳ [IComplexReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IComplexReference 'DiGi\.Core\.Interfaces\.IComplexReference')  
↳ [IExternalReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IExternalReference 'DiGi\.Core\.Interfaces\.IExternalReference')  
↳ [IInstanceRelatedReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedReference')  
↳ [IInstanceRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedSerializableReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedSerializableReference')  
↳ [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference')  
↳ [ITypeRelatedReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITypeRelatedReference 'DiGi\.Core\.Interfaces\.ITypeRelatedReference')  
↳ [ITypeRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITypeRelatedSerializableReference 'DiGi\.Core\.Interfaces\.ITypeRelatedSerializableReference')  
↳ [IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference')

Implements [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

### Remarks
Compare two [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference') values with [Equals\(this IReference, IReference\)](DiGi.Core.md#DiGi.Core.Query.Equals(thisDiGi.Core.Interfaces.IReference,DiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.Equals\(this DiGi\.Core\.Interfaces\.IReference, DiGi\.Core\.Interfaces\.IReference\)'), NEVER with
`==` or `!=`\. The equality operators are declared on [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') and
C\# gathers operator candidates from the static types of the operands \- an interface contributes none \- so
`reference_1 == reference_2` compiles to plain reference equality and is false for two equal references
held in separate instances\. The operators do apply, correctly, as soon as one operand is statically typed as a
[SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference') derived type\.

Beware of properties that return `Query.Clone(...)`: they hand back a new instance on every read, so
            even comparing such a property with itself using `==` yields false. Read it into a local first.

[System\.Collections\.Generic\.Dictionary&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2'), `HashSet` and `List.Contains`
            are safe - they route through [System\.IEquatable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1') and `GetHashCode`.

Not every implementation derives from [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference'), so do not cast to it.

<a name='DiGi.Core.Interfaces.IReportableBackgroundTask'></a>

## IReportableBackgroundTask Interface

Defines a contract for a background task that can report progress\.

```csharp
public interface IReportableBackgroundTask : DiGi.Core.Interfaces.ICancelableBackgroundTask, DiGi.Core.Interfaces.IBackgroundTask, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [ReportableBackgroundTask&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ReportableBackgroundTask_T_ 'DiGi\.Core\.Classes\.ReportableBackgroundTask\<T\>')  
↳ [IReportableBackgroundTask&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReportableBackgroundTask_T_ 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask\<T\>')

Implements [ICancelableBackgroundTask](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICancelableBackgroundTask 'DiGi\.Core\.Interfaces\.ICancelableBackgroundTask'), [IBackgroundTask](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IBackgroundTask 'DiGi\.Core\.Interfaces\.IBackgroundTask'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Core.Interfaces.IReportableBackgroundTask_T_'></a>

## IReportableBackgroundTask\<T\> Interface

Defines a generic contract for a background task that reports progress of type T\.

```csharp
public interface IReportableBackgroundTask<T> : DiGi.Core.Interfaces.IReportableBackgroundTask, DiGi.Core.Interfaces.ICancelableBackgroundTask, DiGi.Core.Interfaces.IBackgroundTask, DiGi.Core.Interfaces.IObject
```
#### Type parameters

<a name='DiGi.Core.Interfaces.IReportableBackgroundTask_T_.T'></a>

`T`

The type of the progress data reported\.

Derived  
↳ [ReportableBackgroundTask&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.ReportableBackgroundTask_T_ 'DiGi\.Core\.Classes\.ReportableBackgroundTask\<T\>')

Implements [IReportableBackgroundTask](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReportableBackgroundTask 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask'), [ICancelableBackgroundTask](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICancelableBackgroundTask 'DiGi\.Core\.Interfaces\.ICancelableBackgroundTask'), [IBackgroundTask](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IBackgroundTask 'DiGi\.Core\.Interfaces\.IBackgroundTask'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Events

<a name='DiGi.Core.Interfaces.IReportableBackgroundTask_T_.ProgressChanged'></a>

## IReportableBackgroundTask\<T\>\.ProgressChanged Event

Occurs when the progress of the background task changes\.

```csharp
event EventHandler<T>? ProgressChanged;
```

#### Event Type
[System\.EventHandler&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1 'System\.EventHandler\`1')[T](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReportableBackgroundTask_T_.T 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1 'System\.EventHandler\`1')

<a name='DiGi.Core.Interfaces.IResult'></a>

## IResult Interface

Defines a contract for an object that represents the result of an operation\.

```csharp
public interface IResult : DiGi.Core.Interfaces.IObject
```

Derived  
↳ [GuidResult](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult 'DiGi\.Core\.Classes\.GuidResult')  
↳ [GuidResult&lt;TUniqueObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult_TUniqueObject_ 'DiGi\.Core\.Classes\.GuidResult\<TUniqueObject\>')  
↳ [SerializableResult](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult 'DiGi\.Core\.Classes\.SerializableResult')  
↳ [SerializableResult&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult_T_ 'DiGi\.Core\.Classes\.SerializableResult\<T\>')  
↳ [UniqueResult](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult 'DiGi\.Core\.Classes\.UniqueResult')  
↳ [UniqueResult&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult_T_ 'DiGi\.Core\.Classes\.UniqueResult\<T\>')  
↳ [IGuidResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidResult 'DiGi\.Core\.Interfaces\.IGuidResult')  
↳ [IGuidResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidResult_T_ 'DiGi\.Core\.Interfaces\.IGuidResult\<T\>')  
↳ [IResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IResult_T_ 'DiGi\.Core\.Interfaces\.IResult\<T\>')  
↳ [ISerializableResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult 'DiGi\.Core\.Interfaces\.ISerializableResult')  
↳ [ISerializableResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult_T_ 'DiGi\.Core\.Interfaces\.ISerializableResult\<T\>')  
↳ [IUniqueResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult 'DiGi\.Core\.Interfaces\.IUniqueResult')  
↳ [IUniqueResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult_T_ 'DiGi\.Core\.Interfaces\.IUniqueResult\<T\>')

Implements [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Core.Interfaces.IResult_T_'></a>

## IResult\<T\> Interface

Defines a generic contract for a result containing a value of type T\.

```csharp
public interface IResult<T> : DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject
```
#### Type parameters

<a name='DiGi.Core.Interfaces.IResult_T_.T'></a>

`T`

The type of the result value\.

Derived  
↳ [UniqueResult&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult_T_ 'DiGi\.Core\.Classes\.UniqueResult\<T\>')

Implements [IResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IResult 'DiGi\.Core\.Interfaces\.IResult'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Core.Interfaces.ISerializableModel'></a>

## ISerializableModel Interface

Defines a contract for a model that can be serialized\.

```csharp
public interface ISerializableModel : DiGi.Core.Interfaces.IModel, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [GuidModel](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidModel 'DiGi\.Core\.Classes\.GuidModel')  
↳ [SerializableModel](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableModel 'DiGi\.Core\.Classes\.SerializableModel')  
↳ [IGuidModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidModel 'DiGi\.Core\.Interfaces\.IGuidModel')

Implements [IModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IModel 'DiGi\.Core\.Interfaces\.IModel'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject')

<a name='DiGi.Core.Interfaces.ISerializableObject'></a>

## ISerializableObject Interface

Defines the contract for objects that can be serialized to and from JSON\.

```csharp
public interface ISerializableObject : DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [Address](DiGi.Core.Classes.md#DiGi.Core.Classes.Address 'DiGi\.Core\.Classes\.Address')  
↳ [Coordinates](DiGi.Core.Classes.md#DiGi.Core.Classes.Coordinates 'DiGi\.Core\.Classes\.Coordinates')  
↳ [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection')  
↳ [DateTimeSeries](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeSeries 'DiGi\.Core\.Classes\.DateTimeSeries')  
↳ [Factor](DiGi.Core.Classes.md#DiGi.Core.Classes.Factor 'DiGi\.Core\.Classes\.Factor')  
↳ [GuidModel](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidModel 'DiGi\.Core\.Classes\.GuidModel')  
↳ [GuidObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidObject 'DiGi\.Core\.Classes\.GuidObject')  
↳ [GuidResult](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult 'DiGi\.Core\.Classes\.GuidResult')  
↳ [GuidResult&lt;TUniqueObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult_TUniqueObject_ 'DiGi\.Core\.Classes\.GuidResult\<TUniqueObject\>')  
↳ [SerializableModel](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableModel 'DiGi\.Core\.Classes\.SerializableModel')  
↳ [SerializableObject](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObject 'DiGi\.Core\.Classes\.SerializableObject')  
↳ [SerializableObjectListCluster&lt;TKey\_1,TKey\_2,TValue&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectListCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectListCluster\<TKey\_1,TKey\_2,TValue\>')  
↳ [SerializableObjectValueCluster&lt;TKey\_1,TKey\_2,TValue&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableObjectValueCluster_TKey_1,TKey_2,TValue_ 'DiGi\.Core\.Classes\.SerializableObjectValueCluster\<TKey\_1,TKey\_2,TValue\>')  
↳ [SerializableOptions](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableOptions 'DiGi\.Core\.Classes\.SerializableOptions')  
↳ [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference')  
↳ [SerializableResult](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult 'DiGi\.Core\.Classes\.SerializableResult')  
↳ [SerializableResult&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult_T_ 'DiGi\.Core\.Classes\.SerializableResult\<T\>')  
↳ [TypePropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypePropertyReference 'DiGi\.Core\.Classes\.TypePropertyReference')  
↳ [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')  
↳ [UniqueExternalReference&lt;TUniqueReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_ 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>')  
↳ [UniqueIdObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdObject 'DiGi\.Core\.Classes\.UniqueIdObject')  
↳ [UniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObject 'DiGi\.Core\.Classes\.UniqueObject')  
↳ [UniquePropertyReference&lt;UUniquePropertyReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_ 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>')  
↳ [UniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference 'DiGi\.Core\.Classes\.UniqueReference')  
↳ [UniqueResult](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult 'DiGi\.Core\.Classes\.UniqueResult')  
↳ [ICoordinates](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICoordinates 'DiGi\.Core\.Interfaces\.ICoordinates')  
↳ [IGuidModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidModel 'DiGi\.Core\.Interfaces\.IGuidModel')  
↳ [IGuidObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidObject 'DiGi\.Core\.Interfaces\.IGuidObject')  
↳ [IGuidResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidResult 'DiGi\.Core\.Interfaces\.IGuidResult')  
↳ [IGuidResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidResult_T_ 'DiGi\.Core\.Interfaces\.IGuidResult\<T\>')  
↳ [IInstanceRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedSerializableReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedSerializableReference')  
↳ [ILocation](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ILocation 'DiGi\.Core\.Interfaces\.ILocation')  
↳ [ISerializableModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableModel 'DiGi\.Core\.Interfaces\.ISerializableModel')  
↳ [ISerializableOptions](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableOptions 'DiGi\.Core\.Interfaces\.ISerializableOptions')  
↳ [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference')  
↳ [ISerializableResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult 'DiGi\.Core\.Interfaces\.ISerializableResult')  
↳ [ISerializableResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult_T_ 'DiGi\.Core\.Interfaces\.ISerializableResult\<T\>')  
↳ [ITimeSeries](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITimeSeries 'DiGi\.Core\.Interfaces\.ITimeSeries')  
↳ [ITypeRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITypeRelatedSerializableReference 'DiGi\.Core\.Interfaces\.ITypeRelatedSerializableReference')  
↳ [IUniqueIdObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueIdObject 'DiGi\.Core\.Interfaces\.IUniqueIdObject')  
↳ [IUniqueObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject 'DiGi\.Core\.Interfaces\.IUniqueObject')  
↳ [IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference')  
↳ [IUniqueResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult 'DiGi\.Core\.Interfaces\.IUniqueResult')  
↳ [IUniqueResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult_T_ 'DiGi\.Core\.Interfaces\.IUniqueResult\<T\>')

Implements [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Methods

<a name='DiGi.Core.Interfaces.ISerializableObject.FromJsonObject(System.Text.Json.Nodes.JsonObject)'></a>

## ISerializableObject\.FromJsonObject\(JsonObject\) Method

Populates the object from a JsonObject\.

```csharp
bool FromJsonObject(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.Core.Interfaces.ISerializableObject.FromJsonObject(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JsonObject to read values from\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object was successfully populated, false otherwise\.

<a name='DiGi.Core.Interfaces.ISerializableObject.ToJsonObject()'></a>

## ISerializableObject\.ToJsonObject\(\) Method

Serializes the object into a JsonObject\.

```csharp
System.Text.Json.Nodes.JsonObject? ToJsonObject();
```

#### Returns
[System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')  
A JsonObject representation of the object, or null if serialization fails\.

<a name='DiGi.Core.Interfaces.ISerializableOptions'></a>

## ISerializableOptions Interface

Defines a contract for options that are both serializable and behave as options\.

```csharp
public interface ISerializableOptions : DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IOptions
```

Derived  
↳ [SerializableOptions](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableOptions 'DiGi\.Core\.Classes\.SerializableOptions')

Implements [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [IOptions](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IOptions 'DiGi\.Core\.Interfaces\.IOptions')

<a name='DiGi.Core.Interfaces.ISerializableReference'></a>

## ISerializableReference Interface

Defines a contract for a reference object that can be serialized\.

```csharp
public interface ISerializableReference : DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IReference, System.IEquatable<DiGi.Core.Interfaces.IReference>
```

Derived  
↳ [SerializableReference](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableReference 'DiGi\.Core\.Classes\.SerializableReference')  
↳ [TypePropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypePropertyReference 'DiGi\.Core\.Classes\.TypePropertyReference')  
↳ [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')  
↳ [UniqueExternalReference&lt;TUniqueReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_ 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>')  
↳ [UniquePropertyReference&lt;UUniquePropertyReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniquePropertyReference_UUniquePropertyReference_ 'DiGi\.Core\.Classes\.UniquePropertyReference\<UUniquePropertyReference\>')  
↳ [UniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference 'DiGi\.Core\.Classes\.UniqueReference')  
↳ [IInstanceRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedSerializableReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedSerializableReference')  
↳ [ITypeRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITypeRelatedSerializableReference 'DiGi\.Core\.Interfaces\.ITypeRelatedSerializableReference')  
↳ [IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference')

Implements [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

<a name='DiGi.Core.Interfaces.ISerializableResult'></a>

## ISerializableResult Interface

Defines a contract for a result object that can be serialized\.

```csharp
public interface ISerializableResult : DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [GuidResult](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult 'DiGi\.Core\.Classes\.GuidResult')  
↳ [GuidResult&lt;TUniqueObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult_TUniqueObject_ 'DiGi\.Core\.Classes\.GuidResult\<TUniqueObject\>')  
↳ [SerializableResult](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult 'DiGi\.Core\.Classes\.SerializableResult')  
↳ [SerializableResult&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult_T_ 'DiGi\.Core\.Classes\.SerializableResult\<T\>')  
↳ [UniqueResult](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult 'DiGi\.Core\.Classes\.UniqueResult')  
↳ [IGuidResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidResult 'DiGi\.Core\.Interfaces\.IGuidResult')  
↳ [IGuidResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidResult_T_ 'DiGi\.Core\.Interfaces\.IGuidResult\<T\>')  
↳ [ISerializableResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult_T_ 'DiGi\.Core\.Interfaces\.ISerializableResult\<T\>')  
↳ [IUniqueResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult 'DiGi\.Core\.Interfaces\.IUniqueResult')  
↳ [IUniqueResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult_T_ 'DiGi\.Core\.Interfaces\.IUniqueResult\<T\>')

Implements [IResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IResult 'DiGi\.Core\.Interfaces\.IResult'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject')

<a name='DiGi.Core.Interfaces.ISerializableResult_T_'></a>

## ISerializableResult\<T\> Interface

Defines a generic contract for a serializable result containing a value of type T\.

```csharp
public interface ISerializableResult<T> : DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
    where T : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Core.Interfaces.ISerializableResult_T_.T'></a>

`T`

The type of the serializable result value\.

Derived  
↳ [SerializableResult&lt;T&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.SerializableResult_T_ 'DiGi\.Core\.Classes\.SerializableResult\<T\>')

Implements [ISerializableResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [IResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IResult 'DiGi\.Core\.Interfaces\.IResult'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject')

<a name='DiGi.Core.Interfaces.ISolver'></a>

## ISolver Interface

Defines a contract for an evaluator that solves a problem or calculates a result\.

```csharp
public interface ISolver : DiGi.Core.Interfaces.IEvaluator
```

Derived  
↳ [IOneToManySolver&lt;TInput,TOutput&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IOneToManySolver_TInput,TOutput_ 'DiGi\.Core\.Interfaces\.IOneToManySolver\<TInput,TOutput\>')  
↳ [IOneToOneSolver&lt;TInput,TOutput&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IOneToOneSolver_TInput,TOutput_ 'DiGi\.Core\.Interfaces\.IOneToOneSolver\<TInput,TOutput\>')

Implements [IEvaluator](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IEvaluator 'DiGi\.Core\.Interfaces\.IEvaluator')
### Methods

<a name='DiGi.Core.Interfaces.ISolver.Solve()'></a>

## ISolver\.Solve\(\) Method

Executes the solving operation\.

```csharp
bool Solve();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the solver successfully found a solution, false otherwise\.

<a name='DiGi.Core.Interfaces.ITaggable'></a>

## ITaggable Interface

Defines a contract for objects that can hold and manage metadata tag\.

```csharp
public interface ITaggable
```
### Properties

<a name='DiGi.Core.Interfaces.ITaggable.Tag'></a>

## ITaggable\.Tag Property

Gets tag associated with this object\.

```csharp
DiGi.Core.Classes.Tag Tag { get; set; }
```

#### Property Value
[Tag](DiGi.Core.Classes.md#DiGi.Core.Classes.Tag 'DiGi\.Core\.Classes\.Tag')

<a name='DiGi.Core.Interfaces.ITimeSeries'></a>

## ITimeSeries Interface

Defines a contract for an object that contains time\-series data\.

```csharp
public interface ITimeSeries : DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [DateTimeCollection](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeCollection 'DiGi\.Core\.Classes\.DateTimeCollection')  
↳ [DateTimeSeries](DiGi.Core.Classes.md#DiGi.Core.Classes.DateTimeSeries 'DiGi\.Core\.Classes\.DateTimeSeries')

Implements [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Methods

<a name='DiGi.Core.Interfaces.ITimeSeries.GetDateTimes()'></a>

## ITimeSeries\.GetDateTimes\(\) Method

Retrieves the date\-time stamps associated with the time series\.

```csharp
System.DateTime[]? GetDateTimes();
```

#### Returns
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of DateTimes, or null if none exist\.

<a name='DiGi.Core.Interfaces.ITypeRelatedReference'></a>

## ITypeRelatedReference Interface

Defines a contract for a reference related to a specific type\.

```csharp
public interface ITypeRelatedReference : DiGi.Core.Interfaces.IReference, DiGi.Core.Interfaces.IObject, System.IEquatable<DiGi.Core.Interfaces.IReference>
```

Derived  
↳ [TypePropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypePropertyReference 'DiGi\.Core\.Classes\.TypePropertyReference')  
↳ [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')  
↳ [ITypeRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITypeRelatedSerializableReference 'DiGi\.Core\.Interfaces\.ITypeRelatedSerializableReference')

Implements [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')
### Properties

<a name='DiGi.Core.Interfaces.ITypeRelatedReference.FullTypeName'></a>

## ITypeRelatedReference\.FullTypeName Property

Gets the full name of the referenced type\.

```csharp
string? FullTypeName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Interfaces.ITypeRelatedSerializableReference'></a>

## ITypeRelatedSerializableReference Interface

Defines a contract for a type\-related reference that can be serialized\.

```csharp
public interface ITypeRelatedSerializableReference : DiGi.Core.Interfaces.ITypeRelatedReference, DiGi.Core.Interfaces.IReference, DiGi.Core.Interfaces.IObject, System.IEquatable<DiGi.Core.Interfaces.IReference>, DiGi.Core.Interfaces.ISerializableReference, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [TypePropertyReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypePropertyReference 'DiGi\.Core\.Classes\.TypePropertyReference')  
↳ [TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')

Implements [ITypeRelatedReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ITypeRelatedReference 'DiGi\.Core\.Interfaces\.ITypeRelatedReference'), [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1'), [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject')

<a name='DiGi.Core.Interfaces.IUniqueIdObject'></a>

## IUniqueIdObject Interface

Defines a contract for an object uniquely identified by an ID\.

```csharp
public interface IUniqueIdObject : DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [UniqueIdObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdObject 'DiGi\.Core\.Classes\.UniqueIdObject')

Implements [IUniqueObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Core.Interfaces.IUniqueObject'></a>

## IUniqueObject Interface

Defines a contract for an object that has a unique identifier\.

```csharp
public interface IUniqueObject : DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [GuidModel](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidModel 'DiGi\.Core\.Classes\.GuidModel')  
↳ [GuidObject](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidObject 'DiGi\.Core\.Classes\.GuidObject')  
↳ [GuidResult](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult 'DiGi\.Core\.Classes\.GuidResult')  
↳ [GuidResult&lt;TUniqueObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult_TUniqueObject_ 'DiGi\.Core\.Classes\.GuidResult\<TUniqueObject\>')  
↳ [UniqueIdObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueIdObject 'DiGi\.Core\.Classes\.UniqueIdObject')  
↳ [UniqueObject](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueObject 'DiGi\.Core\.Classes\.UniqueObject')  
↳ [UniqueResult](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult 'DiGi\.Core\.Classes\.UniqueResult')  
↳ [IGuidModel](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidModel 'DiGi\.Core\.Interfaces\.IGuidModel')  
↳ [IGuidObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidObject 'DiGi\.Core\.Interfaces\.IGuidObject')  
↳ [IGuidResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidResult 'DiGi\.Core\.Interfaces\.IGuidResult')  
↳ [IGuidResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidResult_T_ 'DiGi\.Core\.Interfaces\.IGuidResult\<T\>')  
↳ [IUniqueIdObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueIdObject 'DiGi\.Core\.Interfaces\.IUniqueIdObject')  
↳ [IUniqueResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult 'DiGi\.Core\.Interfaces\.IUniqueResult')  
↳ [IUniqueResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult_T_ 'DiGi\.Core\.Interfaces\.IUniqueResult\<T\>')

Implements [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Core.Interfaces.IUniqueObject.UniqueId'></a>

## IUniqueObject\.UniqueId Property

Gets the unique identifier of the object\.

```csharp
string? UniqueId { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Interfaces.IUniqueReference'></a>

## IUniqueReference Interface

Defines a contract for a unique reference to an object\.

```csharp
public interface IUniqueReference : DiGi.Core.Interfaces.IInstanceRelatedSerializableReference, DiGi.Core.Interfaces.IInstanceRelatedReference, DiGi.Core.Interfaces.IReference, DiGi.Core.Interfaces.IObject, System.IEquatable<DiGi.Core.Interfaces.IReference>, DiGi.Core.Interfaces.ISerializableReference, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [UniqueExternalReference&lt;TUniqueReference&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueExternalReference_TUniqueReference_ 'DiGi\.Core\.Classes\.UniqueExternalReference\<TUniqueReference\>')  
↳ [UniqueReference](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueReference 'DiGi\.Core\.Classes\.UniqueReference')

Implements [IInstanceRelatedSerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedSerializableReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedSerializableReference'), [IInstanceRelatedReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IInstanceRelatedReference 'DiGi\.Core\.Interfaces\.IInstanceRelatedReference'), [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1'), [ISerializableReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableReference 'DiGi\.Core\.Interfaces\.ISerializableReference'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject')

### Remarks
Compare two [IUniqueReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueReference 'DiGi\.Core\.Interfaces\.IUniqueReference') values with [Equals\(this IReference, IReference\)](DiGi.Core.md#DiGi.Core.Query.Equals(thisDiGi.Core.Interfaces.IReference,DiGi.Core.Interfaces.IReference) 'DiGi\.Core\.Query\.Equals\(this DiGi\.Core\.Interfaces\.IReference, DiGi\.Core\.Interfaces\.IReference\)'),
NEVER with `==` or `!=` \- between two interface typed operands those operators are plain reference
equality\. See [IReference](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IReference 'DiGi\.Core\.Interfaces\.IReference') for the full explanation\.
### Properties

<a name='DiGi.Core.Interfaces.IUniqueReference.TypeReference'></a>

## IUniqueReference\.TypeReference Property

Gets the type reference associated with this unique reference\.

```csharp
DiGi.Core.Classes.TypeReference? TypeReference { get; }
```

#### Property Value
[TypeReference](DiGi.Core.Classes.md#DiGi.Core.Classes.TypeReference 'DiGi\.Core\.Classes\.TypeReference')

<a name='DiGi.Core.Interfaces.IUniqueReference.UniqueId'></a>

## IUniqueReference\.UniqueId Property

Gets the unique identifier of the referenced object\.

```csharp
string? UniqueId { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.Core.Interfaces.IUniqueResult'></a>

## IUniqueResult Interface

Defines a contract for a serializable result that is uniquely identified\.

```csharp
public interface IUniqueResult : DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject
```

Derived  
↳ [GuidResult](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult 'DiGi\.Core\.Classes\.GuidResult')  
↳ [GuidResult&lt;TUniqueObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult_TUniqueObject_ 'DiGi\.Core\.Classes\.GuidResult\<TUniqueObject\>')  
↳ [UniqueResult](DiGi.Core.Classes.md#DiGi.Core.Classes.UniqueResult 'DiGi\.Core\.Classes\.UniqueResult')  
↳ [IGuidResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidResult 'DiGi\.Core\.Interfaces\.IGuidResult')  
↳ [IGuidResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidResult_T_ 'DiGi\.Core\.Interfaces\.IGuidResult\<T\>')  
↳ [IUniqueResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult_T_ 'DiGi\.Core\.Interfaces\.IUniqueResult\<T\>')

Implements [ISerializableResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [IResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IResult 'DiGi\.Core\.Interfaces\.IResult'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IUniqueObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject 'DiGi\.Core\.Interfaces\.IUniqueObject')

<a name='DiGi.Core.Interfaces.IUniqueResult_T_'></a>

## IUniqueResult\<T\> Interface

Defines a generic contract for a uniquely identified result containing a value of type T\.

```csharp
public interface IUniqueResult<T> : DiGi.Core.Interfaces.IUniqueResult, DiGi.Core.Interfaces.ISerializableResult, DiGi.Core.Interfaces.IResult, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IUniqueObject
    where T : DiGi.Core.Interfaces.IUniqueObject
```
#### Type parameters

<a name='DiGi.Core.Interfaces.IUniqueResult_T_.T'></a>

`T`

The type of the unique result value\.

Derived  
↳ [GuidResult&lt;TUniqueObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.GuidResult_TUniqueObject_ 'DiGi\.Core\.Classes\.GuidResult\<TUniqueObject\>')  
↳ [IGuidResult&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IGuidResult_T_ 'DiGi\.Core\.Interfaces\.IGuidResult\<T\>')

Implements [IUniqueResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueResult 'DiGi\.Core\.Interfaces\.IUniqueResult'), [ISerializableResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableResult 'DiGi\.Core\.Interfaces\.ISerializableResult'), [IResult](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IResult 'DiGi\.Core\.Interfaces\.IResult'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject'), [ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>')[ISerializableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ISerializableObject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject_TCloneableObject_ 'DiGi\.Core\.Interfaces\.ICloneableObject\<TCloneableObject\>'), [ICloneableObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICloneableObject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [IUniqueObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUniqueObject 'DiGi\.Core\.Interfaces\.IUniqueObject')

<a name='DiGi.Core.Interfaces.IUpdater'></a>

## IUpdater Interface

Defines a contract for an evaluator that updates data\.

```csharp
public interface IUpdater : DiGi.Core.Interfaces.IEvaluator
```

Derived  
↳ [MultiUpdater&lt;TValue&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.MultiUpdater_TValue_ 'DiGi\.Core\.Classes\.MultiUpdater\<TValue\>')  
↳ [IUpdater&lt;TValue&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUpdater_TValue_ 'DiGi\.Core\.Interfaces\.IUpdater\<TValue\>')

Implements [IEvaluator](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IEvaluator 'DiGi\.Core\.Interfaces\.IEvaluator')
### Methods

<a name='DiGi.Core.Interfaces.IUpdater.Update()'></a>

## IUpdater\.Update\(\) Method

Performs the update operation\.

```csharp
bool Update();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the update was successful, false otherwise\.

<a name='DiGi.Core.Interfaces.IUpdater_TValue_'></a>

## IUpdater\<TValue\> Interface

Defines a generic contract for an updater that handles values of type TValue\.

```csharp
public interface IUpdater<TValue> : DiGi.Core.Interfaces.IUpdater, DiGi.Core.Interfaces.IEvaluator
```
#### Type parameters

<a name='DiGi.Core.Interfaces.IUpdater_TValue_.TValue'></a>

`TValue`

The type of value to be updated\.

Derived  
↳ [MultiUpdater&lt;TValue&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.MultiUpdater_TValue_ 'DiGi\.Core\.Classes\.MultiUpdater\<TValue\>')

Implements [IUpdater](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUpdater 'DiGi\.Core\.Interfaces\.IUpdater'), [IEvaluator](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IEvaluator 'DiGi\.Core\.Interfaces\.IEvaluator')
### Properties

<a name='DiGi.Core.Interfaces.IUpdater_TValue_.Value'></a>

## IUpdater\<TValue\>\.Value Property

Gets or sets the value to be used in the update operation\.

```csharp
TValue? Value { get; set; }
```

#### Property Value
[TValue](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IUpdater_TValue_.TValue 'DiGi\.Core\.Interfaces\.IUpdater\<TValue\>\.TValue')

<a name='DiGi.Core.Interfaces.IValidator'></a>

## IValidator Interface

Defines a contract for an evaluator that validates data\.

```csharp
public interface IValidator : DiGi.Core.Interfaces.IEvaluator
```

Derived  
↳ [IValidator&lt;T&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IValidator_T_ 'DiGi\.Core\.Interfaces\.IValidator\<T\>')

Implements [IEvaluator](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IEvaluator 'DiGi\.Core\.Interfaces\.IEvaluator')

<a name='DiGi.Core.Interfaces.IValidator_T_'></a>

## IValidator\<T\> Interface

Defines a generic contract for an evaluator that validates data of type T\.

```csharp
public interface IValidator<T> : DiGi.Core.Interfaces.IValidator, DiGi.Core.Interfaces.IEvaluator
```
#### Type parameters

<a name='DiGi.Core.Interfaces.IValidator_T_.T'></a>

`T`

The type of the data to validate\.

Implements [IValidator](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IValidator 'DiGi\.Core\.Interfaces\.IValidator'), [IEvaluator](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IEvaluator 'DiGi\.Core\.Interfaces\.IEvaluator')
### Methods

<a name='DiGi.Core.Interfaces.IValidator_T_.Validate(T)'></a>

## IValidator\<T\>\.Validate\(T\) Method

Validates the provided input\.

```csharp
bool Validate(T t);
```
#### Parameters

<a name='DiGi.Core.Interfaces.IValidator_T_.Validate(T).t'></a>

`t` [T](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IValidator_T_.T 'DiGi\.Core\.Interfaces\.IValidator\<T\>\.T')

The input to validate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the input is valid, false otherwise\.

<a name='DiGi.Core.Interfaces.IValue'></a>

## IValue Interface

Defines a contract for an object that represents a value\.

```csharp
public interface IValue : DiGi.Core.Interfaces.IObject
```

Derived  
↳ [Value&lt;TObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Value_TObject_ 'DiGi\.Core\.Classes\.Value\<TObject\>')  
↳ [IValue&lt;TValue&gt;](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IValue_TValue_ 'DiGi\.Core\.Interfaces\.IValue\<TValue\>')

Implements [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.Core.Interfaces.IValue_TValue_'></a>

## IValue\<TValue\> Interface

Defines a generic contract for an object that represents a value of type TValue\.

```csharp
public interface IValue<TValue> : DiGi.Core.Interfaces.IValue, DiGi.Core.Interfaces.IObject
```
#### Type parameters

<a name='DiGi.Core.Interfaces.IValue_TValue_.TValue'></a>

`TValue`

The type of the value\.

Derived  
↳ [Value&lt;TObject&gt;](DiGi.Core.Classes.md#DiGi.Core.Classes.Value_TObject_ 'DiGi\.Core\.Classes\.Value\<TObject\>')

Implements [IValue](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IValue 'DiGi\.Core\.Interfaces\.IValue'), [IObject](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IObject 'DiGi\.Core\.Interfaces\.IObject')
### Properties

<a name='DiGi.Core.Interfaces.IValue_TValue_.Value'></a>

## IValue\<TValue\>\.Value Property

Gets the underlying value\.

```csharp
TValue? Value { get; }
```

#### Property Value
[TValue](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IValue_TValue_.TValue 'DiGi\.Core\.Interfaces\.IValue\<TValue\>\.TValue')
### Methods

<a name='DiGi.Core.Interfaces.IValue_TValue_.GetValue_XValue_()'></a>

## IValue\<TValue\>\.GetValue\<XValue\>\(\) Method

Retrieves the value cast to a specific type XValue\.

```csharp
XValue? GetValue<XValue>()
    where XValue : TValue;
```
#### Type parameters

<a name='DiGi.Core.Interfaces.IValue_TValue_.GetValue_XValue_().XValue'></a>

`XValue`

The target type for casting\.

#### Returns
[XValue](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IValue_TValue_.GetValue_XValue_().XValue 'DiGi\.Core\.Interfaces\.IValue\<TValue\>\.GetValue\<XValue\>\(\)\.XValue')  
The value cast to XValue, or null if not possible\.

<a name='DiGi.Core.Interfaces.IWorker'></a>

## IWorker Interface

Defines a contract for a worker that performs an operation\.

```csharp
public interface IWorker
```

Derived  
↳ [ICancellableWorker](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.ICancellableWorker 'DiGi\.Core\.Interfaces\.ICancellableWorker')  
↳ [IDeterminateWorker](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IDeterminateWorker 'DiGi\.Core\.Interfaces\.IDeterminateWorker')  
↳ [IIndeterminateWorker](DiGi.Core.Interfaces.md#DiGi.Core.Interfaces.IIndeterminateWorker 'DiGi\.Core\.Interfaces\.IIndeterminateWorker')
### Properties

<a name='DiGi.Core.Interfaces.IWorker.IsBusy'></a>

## IWorker\.IsBusy Property

Gets a value indicating whether the worker is currently busy\.

```csharp
bool IsBusy { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')