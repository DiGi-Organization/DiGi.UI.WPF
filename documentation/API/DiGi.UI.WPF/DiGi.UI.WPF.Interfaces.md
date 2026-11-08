#### [DiGi\.UI\.WPF](DiGi.UI.WPF.Overview.md 'DiGi\.UI\.WPF\.Overview')

## DiGi\.UI\.WPF\.Interfaces Namespace
### Interfaces

<a name='DiGi.UI.WPF.Interfaces.IControl'></a>

## IControl Interface

Defines the base contract for all control elements within the WPF user interface framework\.

```csharp
public interface IControl : DiGi.UI.WPF.Interfaces.IWPFObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [ListBoxControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl 'DiGi\.UI\.WPF\.Controls\.ListBoxControl')  
↳ [ProgressBarControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ProgressBarControl 'DiGi\.UI\.WPF\.Controls\.ProgressBarControl')

Implements [IWPFObject](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IWPFObject 'DiGi\.UI\.WPF\.Interfaces\.IWPFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.UI.WPF.Interfaces.IVisualBackgroundTask'></a>

## IVisualBackgroundTask Interface

Defines a contract for a background task that provides visual updates or interactions within the WPF user interface\.

```csharp
public interface IVisualBackgroundTask : DiGi.UI.WPF.Interfaces.IWPFObject, DiGi.Core.Interfaces.IObject, System.ComponentModel.INotifyPropertyChanged, DiGi.Core.Interfaces.INamedObject, DiGi.Core.Interfaces.IDescribableObject
```

Derived  
↳ [VisualBackgroundTask&lt;TBackgroundTask&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_ 'DiGi\.UI\.WPF\.Classes\.VisualBackgroundTask\<TBackgroundTask\>')

Implements [IWPFObject](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IWPFObject 'DiGi\.UI\.WPF\.Interfaces\.IWPFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [System\.ComponentModel\.INotifyPropertyChanged](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged 'System\.ComponentModel\.INotifyPropertyChanged'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Core\.Interfaces\.IDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject 'DiGi\.Core\.Interfaces\.IDescribableObject')
### Properties

<a name='DiGi.UI.WPF.Interfaces.IVisualBackgroundTask.IsRunning'></a>

## IVisualBackgroundTask\.IsRunning Property

Gets a value indicating whether the underlying background task is currently running\.

Raised through [System\.ComponentModel\.INotifyPropertyChanged\.PropertyChanged](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged.propertychanged 'System\.ComponentModel\.INotifyPropertyChanged\.PropertyChanged') when the task starts and after it stops - finished, failed or cancelled alike.

```csharp
bool IsRunning { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.UI.WPF.Interfaces.IVisualBackgroundTask.TypeName'></a>

## IVisualBackgroundTask\.TypeName Property

Gets the name of the type associated with this visual background task\.

```csharp
string? TypeName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.UI.WPF.Interfaces.IVisualBackgroundTask.Start()'></a>

## IVisualBackgroundTask\.Start\(\) Method

Starts the execution of the visual background task\.

```csharp
void Start();
```

<a name='DiGi.UI.WPF.Interfaces.IVisualWorker'></a>

## IVisualWorker Interface

Defines a contract for a visual worker that combines the properties of a WPF object with the operational capabilities of a worker\.

```csharp
public interface IVisualWorker : DiGi.UI.WPF.Interfaces.IWPFObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IWorker
```

Derived  
↳ [VisualWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualWorker 'DiGi\.UI\.WPF\.Classes\.VisualWorker')

Implements [IWPFObject](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IWPFObject 'DiGi\.UI\.WPF\.Interfaces\.IWPFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.IWorker](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iworker 'DiGi\.Core\.Interfaces\.IWorker')

<a name='DiGi.UI.WPF.Interfaces.IWindow'></a>

## IWindow Interface

Defines the contract for a window object within the WPF user interface framework\.

```csharp
public interface IWindow : DiGi.UI.WPF.Interfaces.IWPFObject, DiGi.Core.Interfaces.IObject
```

Derived  
↳ [CancellableProgressBarWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.CancellableProgressBarWindow 'DiGi\.UI\.WPF\.Windows\.CancellableProgressBarWindow')  
↳ [ListBoxWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.ListBoxWindow 'DiGi\.UI\.WPF\.Windows\.ListBoxWindow')  
↳ [ProgressBarWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.ProgressBarWindow 'DiGi\.UI\.WPF\.Windows\.ProgressBarWindow')

Implements [IWPFObject](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IWPFObject 'DiGi\.UI\.WPF\.Interfaces\.IWPFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.UI.WPF.Interfaces.IWPFObject'></a>

## IWPFObject Interface

Defines the contract for objects compatible with WPF \(Windows Presentation Foundation\) 
that extend the base system object functionality\.

```csharp
public interface IWPFObject : DiGi.Core.Interfaces.IObject
```

Derived  
↳ [VisualBackgroundTask&lt;TBackgroundTask&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_ 'DiGi\.UI\.WPF\.Classes\.VisualBackgroundTask\<TBackgroundTask\>')  
↳ [VisualWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualWorker 'DiGi\.UI\.WPF\.Classes\.VisualWorker')  
↳ [ListBoxControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl 'DiGi\.UI\.WPF\.Controls\.ListBoxControl')  
↳ [ProgressBarControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ProgressBarControl 'DiGi\.UI\.WPF\.Controls\.ProgressBarControl')  
↳ [IControl](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IControl 'DiGi\.UI\.WPF\.Interfaces\.IControl')  
↳ [IVisualBackgroundTask](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IVisualBackgroundTask 'DiGi\.UI\.WPF\.Interfaces\.IVisualBackgroundTask')  
↳ [IVisualWorker](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IVisualWorker 'DiGi\.UI\.WPF\.Interfaces\.IVisualWorker')  
↳ [IWindow](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IWindow 'DiGi\.UI\.WPF\.Interfaces\.IWindow')  
↳ [CancellableProgressBarWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.CancellableProgressBarWindow 'DiGi\.UI\.WPF\.Windows\.CancellableProgressBarWindow')  
↳ [ListBoxWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.ListBoxWindow 'DiGi\.UI\.WPF\.Windows\.ListBoxWindow')  
↳ [ProgressBarWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.ProgressBarWindow 'DiGi\.UI\.WPF\.Windows\.ProgressBarWindow')

Implements [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')