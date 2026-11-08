#### [DiGi\.UI\.WPF](DiGi.UI.WPF.Overview.md 'DiGi\.UI\.WPF\.Overview')

## DiGi\.UI\.WPF\.Classes Namespace
### Classes

<a name='DiGi.UI.WPF.Classes.CancellableIndeterminateWindowWorker'></a>

## CancellableIndeterminateWindowWorker Class

Provides a worker implementation that manages indeterminate progress updates for a window, 
allowing the operation to be cancelled\.

```csharp
public class CancellableIndeterminateWindowWorker : DiGi.UI.WPF.Classes.CancellableProgressBarWindowWorker, DiGi.Core.Interfaces.IIndeterminateWorker, DiGi.Core.Interfaces.IWorker
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [VisualWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualWorker 'DiGi\.UI\.WPF\.Classes\.VisualWorker') → [DiGi\.UI\.WPF\.Classes\.WindowWorker&lt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.WindowWorker_TWindow_ 'DiGi\.UI\.WPF\.Classes\.WindowWorker\<TWindow\>')[CancellableProgressBarWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.CancellableProgressBarWindow 'DiGi\.UI\.WPF\.Windows\.CancellableProgressBarWindow')[&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.WindowWorker_TWindow_ 'DiGi\.UI\.WPF\.Classes\.WindowWorker\<TWindow\>') → [CancellableProgressBarWindowWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.CancellableProgressBarWindowWorker 'DiGi\.UI\.WPF\.Classes\.CancellableProgressBarWindowWorker') → CancellableIndeterminateWindowWorker

Implements [DiGi\.Core\.Interfaces\.IIndeterminateWorker](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iindeterminateworker 'DiGi\.Core\.Interfaces\.IIndeterminateWorker'), [DiGi\.Core\.Interfaces\.IWorker](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iworker 'DiGi\.Core\.Interfaces\.IWorker')
### Constructors

<a name='DiGi.UI.WPF.Classes.CancellableIndeterminateWindowWorker.CancellableIndeterminateWindowWorker()'></a>

## CancellableIndeterminateWindowWorker\(\) Constructor

Initializes a new instance of the [CancellableIndeterminateWindowWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.CancellableIndeterminateWindowWorker 'DiGi\.UI\.WPF\.Classes\.CancellableIndeterminateWindowWorker') class\.

```csharp
public CancellableIndeterminateWindowWorker();
```

<a name='DiGi.UI.WPF.Classes.CancellableIndeterminateWindowWorker.CancellableIndeterminateWindowWorker(System.Windows.Window)'></a>

## CancellableIndeterminateWindowWorker\(Window\) Constructor

Initializes a new instance of the [CancellableIndeterminateWindowWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.CancellableIndeterminateWindowWorker 'DiGi\.UI\.WPF\.Classes\.CancellableIndeterminateWindowWorker') class with a specified owner window\.

```csharp
public CancellableIndeterminateWindowWorker(System.Windows.Window? owner);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.CancellableIndeterminateWindowWorker.CancellableIndeterminateWindowWorker(System.Windows.Window).owner'></a>

`owner` [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window')

The window that owns this worker\.
### Methods

<a name='DiGi.UI.WPF.Classes.CancellableIndeterminateWindowWorker.Report(string)'></a>

## CancellableIndeterminateWindowWorker\.Report\(string\) Method

Reports a new progress status message to the associated window\.

```csharp
public void Report(string text);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.CancellableIndeterminateWindowWorker.Report(string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The text describing the current progress state\.

Implements [Report\(string\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iindeterminateworker.report#digi-core-interfaces-iindeterminateworker-report(system-string) 'DiGi\.Core\.Interfaces\.IIndeterminateWorker\.Report\(System\.String\)')

<a name='DiGi.UI.WPF.Classes.CancellableProgressBarWindowWorker'></a>

## CancellableProgressBarWindowWorker Class

Provides a worker implementation that manages a [CancellableProgressBarWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.CancellableProgressBarWindow 'DiGi\.UI\.WPF\.Windows\.CancellableProgressBarWindow'), allowing for progress reporting and operation cancellation\.

```csharp
public class CancellableProgressBarWindowWorker : DiGi.UI.WPF.Classes.WindowWorker<DiGi.UI.WPF.Windows.CancellableProgressBarWindow>, DiGi.Core.Interfaces.ICancellableWorker, DiGi.Core.Interfaces.IWorker
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [VisualWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualWorker 'DiGi\.UI\.WPF\.Classes\.VisualWorker') → [DiGi\.UI\.WPF\.Classes\.WindowWorker&lt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.WindowWorker_TWindow_ 'DiGi\.UI\.WPF\.Classes\.WindowWorker\<TWindow\>')[CancellableProgressBarWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.CancellableProgressBarWindow 'DiGi\.UI\.WPF\.Windows\.CancellableProgressBarWindow')[&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.WindowWorker_TWindow_ 'DiGi\.UI\.WPF\.Classes\.WindowWorker\<TWindow\>') → CancellableProgressBarWindowWorker

Derived  
↳ [CancellableIndeterminateWindowWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.CancellableIndeterminateWindowWorker 'DiGi\.UI\.WPF\.Classes\.CancellableIndeterminateWindowWorker')

Implements [DiGi\.Core\.Interfaces\.ICancellableWorker](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icancellableworker 'DiGi\.Core\.Interfaces\.ICancellableWorker'), [DiGi\.Core\.Interfaces\.IWorker](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iworker 'DiGi\.Core\.Interfaces\.IWorker')
### Constructors

<a name='DiGi.UI.WPF.Classes.CancellableProgressBarWindowWorker.CancellableProgressBarWindowWorker()'></a>

## CancellableProgressBarWindowWorker\(\) Constructor

Initializes a new instance of the [CancellableProgressBarWindowWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.CancellableProgressBarWindowWorker 'DiGi\.UI\.WPF\.Classes\.CancellableProgressBarWindowWorker') class\.

```csharp
public CancellableProgressBarWindowWorker();
```

<a name='DiGi.UI.WPF.Classes.CancellableProgressBarWindowWorker.CancellableProgressBarWindowWorker(System.Windows.Window)'></a>

## CancellableProgressBarWindowWorker\(Window\) Constructor

Initializes a new instance of the [CancellableProgressBarWindowWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.CancellableProgressBarWindowWorker 'DiGi\.UI\.WPF\.Classes\.CancellableProgressBarWindowWorker') class with the specified owner window\.

```csharp
public CancellableProgressBarWindowWorker(System.Windows.Window? owner);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.CancellableProgressBarWindowWorker.CancellableProgressBarWindowWorker(System.Windows.Window).owner'></a>

`owner` [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window')

The optional owner window for the progress bar window\.
### Properties

<a name='DiGi.UI.WPF.Classes.CancellableProgressBarWindowWorker.CancellationPending'></a>

## CancellableProgressBarWindowWorker\.CancellationPending Property

Gets a value indicating whether a cancellation is pending\.

```csharp
public bool CancellationPending { get; }
```

Implements [CancellationPending](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icancellableworker.cancellationpending 'DiGi\.Core\.Interfaces\.ICancellableWorker\.CancellationPending')

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.UI.WPF.Classes.CancellableProgressBarWindowWorker.Text'></a>

## CancellableProgressBarWindowWorker\.Text Property

Gets or sets the text displayed on the main label of the progress bar window\.

```csharp
public string? Text { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.UI.WPF.Classes.CancellableProgressBarWindowWorker.CancelAsync()'></a>

## CancellableProgressBarWindowWorker\.CancelAsync\(\) Method

Initiates an asynchronous cancellation of the worker's operation\.

```csharp
public void CancelAsync();
```

Implements [CancelAsync\(\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icancellableworker.cancelasync 'DiGi\.Core\.Interfaces\.ICancellableWorker\.CancelAsync')

<a name='DiGi.UI.WPF.Classes.CancellingEventArgs'></a>

## CancellingEventArgs Class

Provides data for events that can be cancelled\.

```csharp
public class CancellingEventArgs : System.EventArgs
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.EventArgs](https://learn.microsoft.com/en-us/dotnet/api/system.eventargs 'System\.EventArgs') → CancellingEventArgs
### Constructors

<a name='DiGi.UI.WPF.Classes.CancellingEventArgs.CancellingEventArgs()'></a>

## CancellingEventArgs\(\) Constructor

Initializes a new instance of the [CancellingEventArgs](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.CancellingEventArgs 'DiGi\.UI\.WPF\.Classes\.CancellingEventArgs') class\.

```csharp
public CancellingEventArgs();
```

<a name='DiGi.UI.WPF.Classes.CheckBoxTreeViewItemAddingEventArgs'></a>

## CheckBoxTreeViewItemAddingEventArgs Class

Provides data for the event that occurs when a check box tree view item is being added\.

```csharp
public class CheckBoxTreeViewItemAddingEventArgs : DiGi.UI.WPF.Classes.TreeViewItemAddingEventArgs
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.EventArgs](https://learn.microsoft.com/en-us/dotnet/api/system.eventargs 'System\.EventArgs') → [ItemAddingEventArgs](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemAddingEventArgs 'DiGi\.UI\.WPF\.Classes\.ItemAddingEventArgs') → [TreeViewItemAddingEventArgs](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.TreeViewItemAddingEventArgs 'DiGi\.UI\.WPF\.Classes\.TreeViewItemAddingEventArgs') → CheckBoxTreeViewItemAddingEventArgs
### Constructors

<a name='DiGi.UI.WPF.Classes.CheckBoxTreeViewItemAddingEventArgs.CheckBoxTreeViewItemAddingEventArgs(object)'></a>

## CheckBoxTreeViewItemAddingEventArgs\(object\) Constructor

Initializes a new instance of the [CheckBoxTreeViewItemAddingEventArgs](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.CheckBoxTreeViewItemAddingEventArgs 'DiGi\.UI\.WPF\.Classes\.CheckBoxTreeViewItemAddingEventArgs') class\.

```csharp
public CheckBoxTreeViewItemAddingEventArgs(object? item);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.CheckBoxTreeViewItemAddingEventArgs.CheckBoxTreeViewItemAddingEventArgs(object).item'></a>

`item` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The item being added to the tree view\.
### Properties

<a name='DiGi.UI.WPF.Classes.CheckBoxTreeViewItemAddingEventArgs.IsChecked'></a>

## CheckBoxTreeViewItemAddingEventArgs\.IsChecked Property

Gets or sets a value indicating whether the check box associated with the tree view item is checked\.
Setting this value marks the event as handled\.

```csharp
public System.Nullable<bool> IsChecked { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.UI.WPF.Classes.ControlWorker_TControl_'></a>

## ControlWorker\<TControl\> Class

Provides an abstract base implementation for a worker that manages a specific type of WPF control\.

```csharp
public abstract class ControlWorker<TControl> : DiGi.UI.WPF.Classes.VisualWorker
    where TControl : System.Windows.Controls.Control
```
#### Type parameters

<a name='DiGi.UI.WPF.Classes.ControlWorker_TControl_.TControl'></a>

`TControl`

The type of the WPF control this worker operates on, which must derive from [System\.Windows\.Controls\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.control 'System\.Windows\.Controls\.Control')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [VisualWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualWorker 'DiGi\.UI\.WPF\.Classes\.VisualWorker') → ControlWorker\<TControl\>

Derived  
↳ [ProgressBarControlWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ProgressBarControlWorker 'DiGi\.UI\.WPF\.Classes\.ProgressBarControlWorker')
### Constructors

<a name='DiGi.UI.WPF.Classes.ControlWorker_TControl_.ControlWorker(TControl)'></a>

## ControlWorker\(TControl\) Constructor

Initializes a new instance of the [ControlWorker&lt;TControl&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ControlWorker_TControl_ 'DiGi\.UI\.WPF\.Classes\.ControlWorker\<TControl\>') class\.

```csharp
public ControlWorker(TControl control);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.ControlWorker_TControl_.ControlWorker(TControl).control'></a>

`control` [TControl](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ControlWorker_TControl_.TControl 'DiGi\.UI\.WPF\.Classes\.ControlWorker\<TControl\>\.TControl')

The [System\.Windows\.Controls\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.control 'System\.Windows\.Controls\.Control') instance to be associated with this worker\.
### Fields

<a name='DiGi.UI.WPF.Classes.ControlWorker_TControl_.control'></a>

## ControlWorker\<TControl\>\.control Field

The reference to the WPF control instance managed by this worker\.

```csharp
protected TControl control;
```

#### Field Value
[TControl](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ControlWorker_TControl_.TControl 'DiGi\.UI\.WPF\.Classes\.ControlWorker\<TControl\>\.TControl')

<a name='DiGi.UI.WPF.Classes.DeterminateControlWorker'></a>

## DeterminateControlWorker Class

Provides an implementation of a worker that manages determinate progress updates for a ProgressBarControl\.

```csharp
public class DeterminateControlWorker : DiGi.UI.WPF.Classes.ProgressBarControlWorker, DiGi.Core.Interfaces.IDeterminateWorker, DiGi.Core.Interfaces.IWorker
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [VisualWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualWorker 'DiGi\.UI\.WPF\.Classes\.VisualWorker') → [DiGi\.UI\.WPF\.Classes\.ControlWorker&lt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ControlWorker_TControl_ 'DiGi\.UI\.WPF\.Classes\.ControlWorker\<TControl\>')[ProgressBarControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ProgressBarControl 'DiGi\.UI\.WPF\.Controls\.ProgressBarControl')[&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ControlWorker_TControl_ 'DiGi\.UI\.WPF\.Classes\.ControlWorker\<TControl\>') → [ProgressBarControlWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ProgressBarControlWorker 'DiGi\.UI\.WPF\.Classes\.ProgressBarControlWorker') → DeterminateControlWorker

Implements [DiGi\.Core\.Interfaces\.IDeterminateWorker](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ideterminateworker 'DiGi\.Core\.Interfaces\.IDeterminateWorker'), [DiGi\.Core\.Interfaces\.IWorker](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iworker 'DiGi\.Core\.Interfaces\.IWorker')
### Constructors

<a name='DiGi.UI.WPF.Classes.DeterminateControlWorker.DeterminateControlWorker(DiGi.UI.WPF.Controls.ProgressBarControl)'></a>

## DeterminateControlWorker\(ProgressBarControl\) Constructor

Initializes a new instance of the [DeterminateControlWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.DeterminateControlWorker 'DiGi\.UI\.WPF\.Classes\.DeterminateControlWorker') class\.

```csharp
public DeterminateControlWorker(DiGi.UI.WPF.Controls.ProgressBarControl progressBarControl);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.DeterminateControlWorker.DeterminateControlWorker(DiGi.UI.WPF.Controls.ProgressBarControl).progressBarControl'></a>

`progressBarControl` [ProgressBarControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ProgressBarControl 'DiGi\.UI\.WPF\.Controls\.ProgressBarControl')

The progress bar control to be updated by this worker\.
### Properties

<a name='DiGi.UI.WPF.Classes.DeterminateControlWorker.Maximum'></a>

## DeterminateControlWorker\.Maximum Property

Gets or sets the maximum value for progress reporting\.

```csharp
public double Maximum { get; set; }
```

Implements [Maximum](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ideterminateworker.maximum 'DiGi\.Core\.Interfaces\.IDeterminateWorker\.Maximum')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.UI.WPF.Classes.DeterminateControlWorker.Report(double)'></a>

## DeterminateControlWorker\.Report\(double\) Method

Reports a new progress value\.

```csharp
public void Report(double value);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.DeterminateControlWorker.Report(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The progress value to report\.

Implements [Report\(double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ideterminateworker.report#digi-core-interfaces-ideterminateworker-report(system-double) 'DiGi\.Core\.Interfaces\.IDeterminateWorker\.Report\(System\.Double\)')

<a name='DiGi.UI.WPF.Classes.DeterminateControlWorker.Report(double,string)'></a>

## DeterminateControlWorker\.Report\(double, string\) Method

Reports a new progress value along with a descriptive status message\.

```csharp
public void Report(double value, string text);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.DeterminateControlWorker.Report(double,string).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The progress value to report\.

<a name='DiGi.UI.WPF.Classes.DeterminateControlWorker.Report(double,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The status message to display alongside the progress\.

Implements [Report\(double, string\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ideterminateworker.report#digi-core-interfaces-ideterminateworker-report(system-double-system-string) 'DiGi\.Core\.Interfaces\.IDeterminateWorker\.Report\(System\.Double,System\.String\)')

<a name='DiGi.UI.WPF.Classes.DeterminateControlWorker.Run()'></a>

## DeterminateControlWorker\.Run\(\) Method

Starts the execution of the worker and configures the associated control's maximum value\.

```csharp
public override void Run();
```

<a name='DiGi.UI.WPF.Classes.DeterminateWindowWorker'></a>

## DeterminateWindowWorker Class

Provides a window\-based worker implementation that supports determinate progress reporting\.

```csharp
public class DeterminateWindowWorker : DiGi.UI.WPF.Classes.ProgressBarWindowWorker, DiGi.Core.Interfaces.IDeterminateWorker, DiGi.Core.Interfaces.IWorker
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [VisualWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualWorker 'DiGi\.UI\.WPF\.Classes\.VisualWorker') → [DiGi\.UI\.WPF\.Classes\.WindowWorker&lt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.WindowWorker_TWindow_ 'DiGi\.UI\.WPF\.Classes\.WindowWorker\<TWindow\>')[ProgressBarWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.ProgressBarWindow 'DiGi\.UI\.WPF\.Windows\.ProgressBarWindow')[&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.WindowWorker_TWindow_ 'DiGi\.UI\.WPF\.Classes\.WindowWorker\<TWindow\>') → [ProgressBarWindowWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ProgressBarWindowWorker 'DiGi\.UI\.WPF\.Classes\.ProgressBarWindowWorker') → DeterminateWindowWorker

Implements [DiGi\.Core\.Interfaces\.IDeterminateWorker](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ideterminateworker 'DiGi\.Core\.Interfaces\.IDeterminateWorker'), [DiGi\.Core\.Interfaces\.IWorker](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iworker 'DiGi\.Core\.Interfaces\.IWorker')
### Constructors

<a name='DiGi.UI.WPF.Classes.DeterminateWindowWorker.DeterminateWindowWorker()'></a>

## DeterminateWindowWorker\(\) Constructor

Initializes a new instance of the [DeterminateWindowWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.DeterminateWindowWorker 'DiGi\.UI\.WPF\.Classes\.DeterminateWindowWorker') class\.

```csharp
public DeterminateWindowWorker();
```
### Properties

<a name='DiGi.UI.WPF.Classes.DeterminateWindowWorker.Maximum'></a>

## DeterminateWindowWorker\.Maximum Property

Gets or sets the maximum value for progress reporting\.

```csharp
public double Maximum { get; set; }
```

Implements [Maximum](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ideterminateworker.maximum 'DiGi\.Core\.Interfaces\.IDeterminateWorker\.Maximum')

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.UI.WPF.Classes.DeterminateWindowWorker.Report(double)'></a>

## DeterminateWindowWorker\.Report\(double\) Method

Reports a new progress value\.

```csharp
public void Report(double value);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.DeterminateWindowWorker.Report(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The progress value to report\.

Implements [Report\(double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ideterminateworker.report#digi-core-interfaces-ideterminateworker-report(system-double) 'DiGi\.Core\.Interfaces\.IDeterminateWorker\.Report\(System\.Double\)')

<a name='DiGi.UI.WPF.Classes.DeterminateWindowWorker.Report(double,string)'></a>

## DeterminateWindowWorker\.Report\(double, string\) Method

Reports a new progress value along with a status message\.

```csharp
public void Report(double value, string text);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.DeterminateWindowWorker.Report(double,string).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The progress value to report\.

<a name='DiGi.UI.WPF.Classes.DeterminateWindowWorker.Report(double,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The status text to display\.

Implements [Report\(double, string\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ideterminateworker.report#digi-core-interfaces-ideterminateworker-report(system-double-system-string) 'DiGi\.Core\.Interfaces\.IDeterminateWorker\.Report\(System\.Double,System\.String\)')

<a name='DiGi.UI.WPF.Classes.DeterminateWindowWorker.Run()'></a>

## DeterminateWindowWorker\.Run\(\) Method

Executes the worker operation and synchronizes the maximum progress value with the associated window\.

```csharp
public override void Run();
```

<a name='DiGi.UI.WPF.Classes.IndeterminateControlWorker'></a>

## IndeterminateControlWorker Class

Provides an implementation of a worker that handles indeterminate progress updates for a progress bar control\.

```csharp
public class IndeterminateControlWorker : DiGi.UI.WPF.Classes.ProgressBarControlWorker, DiGi.Core.Interfaces.IIndeterminateWorker, DiGi.Core.Interfaces.IWorker
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [VisualWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualWorker 'DiGi\.UI\.WPF\.Classes\.VisualWorker') → [DiGi\.UI\.WPF\.Classes\.ControlWorker&lt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ControlWorker_TControl_ 'DiGi\.UI\.WPF\.Classes\.ControlWorker\<TControl\>')[ProgressBarControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ProgressBarControl 'DiGi\.UI\.WPF\.Controls\.ProgressBarControl')[&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ControlWorker_TControl_ 'DiGi\.UI\.WPF\.Classes\.ControlWorker\<TControl\>') → [ProgressBarControlWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ProgressBarControlWorker 'DiGi\.UI\.WPF\.Classes\.ProgressBarControlWorker') → IndeterminateControlWorker

Implements [DiGi\.Core\.Interfaces\.IIndeterminateWorker](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iindeterminateworker 'DiGi\.Core\.Interfaces\.IIndeterminateWorker'), [DiGi\.Core\.Interfaces\.IWorker](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iworker 'DiGi\.Core\.Interfaces\.IWorker')
### Constructors

<a name='DiGi.UI.WPF.Classes.IndeterminateControlWorker.IndeterminateControlWorker(DiGi.UI.WPF.Controls.ProgressBarControl)'></a>

## IndeterminateControlWorker\(ProgressBarControl\) Constructor

Initializes a new instance of the [IndeterminateControlWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.IndeterminateControlWorker 'DiGi\.UI\.WPF\.Classes\.IndeterminateControlWorker') class\.

```csharp
public IndeterminateControlWorker(DiGi.UI.WPF.Controls.ProgressBarControl progressBarControl);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.IndeterminateControlWorker.IndeterminateControlWorker(DiGi.UI.WPF.Controls.ProgressBarControl).progressBarControl'></a>

`progressBarControl` [ProgressBarControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ProgressBarControl 'DiGi\.UI\.WPF\.Controls\.ProgressBarControl')

The progress bar control to be managed by this worker\.
### Methods

<a name='DiGi.UI.WPF.Classes.IndeterminateControlWorker.Report(string)'></a>

## IndeterminateControlWorker\.Report\(string\) Method

Reports a status message for the indeterminate progress operation\.

```csharp
public void Report(string text);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.IndeterminateControlWorker.Report(string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The text message to report as current progress status\.

Implements [Report\(string\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iindeterminateworker.report#digi-core-interfaces-iindeterminateworker-report(system-string) 'DiGi\.Core\.Interfaces\.IIndeterminateWorker\.Report\(System\.String\)')

<a name='DiGi.UI.WPF.Classes.IndeterminateWindowWorker'></a>

## IndeterminateWindowWorker Class

Provides a worker implementation that manages a window with indeterminate progress\.

```csharp
public class IndeterminateWindowWorker : DiGi.UI.WPF.Classes.ProgressBarWindowWorker, DiGi.Core.Interfaces.IIndeterminateWorker, DiGi.Core.Interfaces.IWorker
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [VisualWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualWorker 'DiGi\.UI\.WPF\.Classes\.VisualWorker') → [DiGi\.UI\.WPF\.Classes\.WindowWorker&lt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.WindowWorker_TWindow_ 'DiGi\.UI\.WPF\.Classes\.WindowWorker\<TWindow\>')[ProgressBarWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.ProgressBarWindow 'DiGi\.UI\.WPF\.Windows\.ProgressBarWindow')[&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.WindowWorker_TWindow_ 'DiGi\.UI\.WPF\.Classes\.WindowWorker\<TWindow\>') → [ProgressBarWindowWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ProgressBarWindowWorker 'DiGi\.UI\.WPF\.Classes\.ProgressBarWindowWorker') → IndeterminateWindowWorker

Implements [DiGi\.Core\.Interfaces\.IIndeterminateWorker](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iindeterminateworker 'DiGi\.Core\.Interfaces\.IIndeterminateWorker'), [DiGi\.Core\.Interfaces\.IWorker](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iworker 'DiGi\.Core\.Interfaces\.IWorker')
### Constructors

<a name='DiGi.UI.WPF.Classes.IndeterminateWindowWorker.IndeterminateWindowWorker()'></a>

## IndeterminateWindowWorker\(\) Constructor

Initializes a new instance of the [IndeterminateWindowWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.IndeterminateWindowWorker 'DiGi\.UI\.WPF\.Classes\.IndeterminateWindowWorker') class without specifying an owner window\.

```csharp
public IndeterminateWindowWorker();
```

<a name='DiGi.UI.WPF.Classes.IndeterminateWindowWorker.IndeterminateWindowWorker(System.Windows.Window)'></a>

## IndeterminateWindowWorker\(Window\) Constructor

Initializes a new instance of the [IndeterminateWindowWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.IndeterminateWindowWorker 'DiGi\.UI\.WPF\.Classes\.IndeterminateWindowWorker') class with a specified owner window\.

```csharp
public IndeterminateWindowWorker(System.Windows.Window? owner);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.IndeterminateWindowWorker.IndeterminateWindowWorker(System.Windows.Window).owner'></a>

`owner` [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window')

The window that owns this worker\.
### Methods

<a name='DiGi.UI.WPF.Classes.IndeterminateWindowWorker.Report(string)'></a>

## IndeterminateWindowWorker\.Report\(string\) Method

Reports progress by updating the status text while maintaining an indeterminate state\.

```csharp
public void Report(string text);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.IndeterminateWindowWorker.Report(string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The text to be displayed as the current progress status\.

Implements [Report\(string\)](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iindeterminateworker.report#digi-core-interfaces-iindeterminateworker-report(system-string) 'DiGi\.Core\.Interfaces\.IIndeterminateWorker\.Report\(System\.String\)')

<a name='DiGi.UI.WPF.Classes.ItemAddingEventArgs'></a>

## ItemAddingEventArgs Class

Provides data for events that occur when an item is being added\.

```csharp
public abstract class ItemAddingEventArgs : System.EventArgs
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.EventArgs](https://learn.microsoft.com/en-us/dotnet/api/system.eventargs 'System\.EventArgs') → ItemAddingEventArgs

Derived  
↳ [ListBoxItemAddingEventArgs](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ListBoxItemAddingEventArgs 'DiGi\.UI\.WPF\.Classes\.ListBoxItemAddingEventArgs')  
↳ [TreeViewItemAddingEventArgs](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.TreeViewItemAddingEventArgs 'DiGi\.UI\.WPF\.Classes\.TreeViewItemAddingEventArgs')
### Constructors

<a name='DiGi.UI.WPF.Classes.ItemAddingEventArgs.ItemAddingEventArgs(object)'></a>

## ItemAddingEventArgs\(object\) Constructor

Initializes a new instance of the [ItemAddingEventArgs](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemAddingEventArgs 'DiGi\.UI\.WPF\.Classes\.ItemAddingEventArgs') class\.

```csharp
public ItemAddingEventArgs(object? item);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.ItemAddingEventArgs.ItemAddingEventArgs(object).item'></a>

`item` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The item being added\.
### Properties

<a name='DiGi.UI.WPF.Classes.ItemAddingEventArgs.Handled'></a>

## ItemAddingEventArgs\.Handled Property

Gets a value indicating whether the event has been handled\.

```csharp
public bool Handled { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.UI.WPF.Classes.ItemAddingEventArgs.Item'></a>

## ItemAddingEventArgs\.Item Property

Gets the item being added\.

```csharp
public object? Item { get; }
```

#### Property Value
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

<a name='DiGi.UI.WPF.Classes.ItemAddingEventArgs.Name'></a>

## ItemAddingEventArgs\.Name Property

Gets or sets the name of the item being added\. Setting this value marks the event as handled\.

```csharp
public string? Name { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.UI.WPF.Classes.ItemPath'></a>

## ItemPath Class

Represents a hierarchical path to an item\.

```csharp
public class ItemPath : DiGi.Core.Classes.ObjectPath<DiGi.UI.WPF.Classes.ItemPath>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.ObjectPath&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.objectpath-1 'DiGi\.Core\.Classes\.ObjectPath\`1')[ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPath')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.objectpath-1 'DiGi\.Core\.Classes\.ObjectPath\`1') → ItemPath
### Constructors

<a name='DiGi.UI.WPF.Classes.ItemPath.ItemPath(DiGi.UI.WPF.Classes.ItemPath)'></a>

## ItemPath\(ItemPath\) Constructor

Initializes a new instance of the [ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPath') class by copying an existing path\.

```csharp
public ItemPath(DiGi.UI.WPF.Classes.ItemPath? path);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.ItemPath.ItemPath(DiGi.UI.WPF.Classes.ItemPath).path'></a>

`path` [ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPath')

The hierarchical path to copy\.

<a name='DiGi.UI.WPF.Classes.ItemPath.ItemPath(string)'></a>

## ItemPath\(string\) Constructor

Initializes a new instance of the [ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPath') class using the specified name\.

```csharp
public ItemPath(string? name);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.ItemPath.ItemPath(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the item path segment\.

<a name='DiGi.UI.WPF.Classes.ItemPath.ItemPath(string,DiGi.UI.WPF.Classes.ItemPath)'></a>

## ItemPath\(string, ItemPath\) Constructor

Initializes a new instance of the [ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPath') class by appending a name to an existing path\.

```csharp
public ItemPath(string? name, DiGi.UI.WPF.Classes.ItemPath? path);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.ItemPath.ItemPath(string,DiGi.UI.WPF.Classes.ItemPath).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the item path segment to append\.

<a name='DiGi.UI.WPF.Classes.ItemPath.ItemPath(string,DiGi.UI.WPF.Classes.ItemPath).path'></a>

`path` [ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPath')

The base hierarchical path\.

<a name='DiGi.UI.WPF.Classes.ItemPath.ItemPath(System.Collections.Generic.IEnumerable_string_)'></a>

## ItemPath\(IEnumerable\<string\>\) Constructor

Initializes a new instance of the [ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPath') class using a collection of names\.

```csharp
public ItemPath(System.Collections.Generic.IEnumerable<string>? names);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.ItemPath.ItemPath(System.Collections.Generic.IEnumerable_string_).names'></a>

`names` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An enumerable collection of names that define the hierarchical path segments\.

<a name='DiGi.UI.WPF.Classes.ItemPath.ItemPath(System.Text.Json.Nodes.JsonObject)'></a>

## ItemPath\(JsonObject\) Constructor

Initializes a new instance of the [ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPath') class from a JSON object\.

```csharp
public ItemPath(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.ItemPath.ItemPath(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the path data\.
### Methods

<a name='DiGi.UI.WPF.Classes.ItemPath.Create(string)'></a>

## ItemPath\.Create\(string\) Method

Creates a new instance of the [ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPath') class\.

```csharp
protected override DiGi.UI.WPF.Classes.ItemPath Create(string? name);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.ItemPath.Create(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the item path segment\.

#### Returns
[ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPath')  
A new [ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPath') instance\.

<a name='DiGi.UI.WPF.Classes.ItemPathTreeViewItem'></a>

## ItemPathTreeViewItem Class

Represents a [System\.Windows\.Controls\.TreeViewItem](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.treeviewitem 'System\.Windows\.Controls\.TreeViewItem') that is associated with a specific [ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPathTreeViewItem.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPathTreeViewItem\.ItemPath')\.

```csharp
public class ItemPathTreeViewItem : System.Windows.Controls.TreeViewItem
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Windows\.Threading\.DispatcherObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.threading.dispatcherobject 'System\.Windows\.Threading\.DispatcherObject') → [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') → [System\.Windows\.Media\.Visual](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.visual 'System\.Windows\.Media\.Visual') → [System\.Windows\.UIElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.uielement 'System\.Windows\.UIElement') → [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement') → [System\.Windows\.Controls\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.control 'System\.Windows\.Controls\.Control') → [System\.Windows\.Controls\.ItemsControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.itemscontrol 'System\.Windows\.Controls\.ItemsControl') → [System\.Windows\.Controls\.HeaderedItemsControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.headereditemscontrol 'System\.Windows\.Controls\.HeaderedItemsControl') → [System\.Windows\.Controls\.TreeViewItem](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.treeviewitem 'System\.Windows\.Controls\.TreeViewItem') → ItemPathTreeViewItem
### Constructors

<a name='DiGi.UI.WPF.Classes.ItemPathTreeViewItem.ItemPathTreeViewItem(DiGi.UI.WPF.Classes.ItemPath)'></a>

## ItemPathTreeViewItem\(ItemPath\) Constructor

Initializes a new instance of the [ItemPathTreeViewItem](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPathTreeViewItem 'DiGi\.UI\.WPF\.Classes\.ItemPathTreeViewItem') class\.

```csharp
public ItemPathTreeViewItem(DiGi.UI.WPF.Classes.ItemPath itemPath);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.ItemPathTreeViewItem.ItemPathTreeViewItem(DiGi.UI.WPF.Classes.ItemPath).itemPath'></a>

`itemPath` [ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPath')

The [ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPathTreeViewItem.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPathTreeViewItem\.ItemPath') associated with this tree view item\.
### Properties

<a name='DiGi.UI.WPF.Classes.ItemPathTreeViewItem.ItemPath'></a>

## ItemPathTreeViewItem\.ItemPath Property

Gets the [ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPathTreeViewItem.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPathTreeViewItem\.ItemPath') associated with this tree view item\.

```csharp
public DiGi.UI.WPF.Classes.ItemPath? ItemPath { get; }
```

#### Property Value
[ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPath')

<a name='DiGi.UI.WPF.Classes.ListBoxItemAddingEventArgs'></a>

## ListBoxItemAddingEventArgs Class

Provides data for events that occur when an item is being added to a [System\.Windows\.Controls\.ListBox](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.listbox 'System\.Windows\.Controls\.ListBox')\.

```csharp
public class ListBoxItemAddingEventArgs : DiGi.UI.WPF.Classes.ItemAddingEventArgs
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.EventArgs](https://learn.microsoft.com/en-us/dotnet/api/system.eventargs 'System\.EventArgs') → [ItemAddingEventArgs](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemAddingEventArgs 'DiGi\.UI\.WPF\.Classes\.ItemAddingEventArgs') → ListBoxItemAddingEventArgs
### Constructors

<a name='DiGi.UI.WPF.Classes.ListBoxItemAddingEventArgs.ListBoxItemAddingEventArgs(object)'></a>

## ListBoxItemAddingEventArgs\(object\) Constructor

Initializes a new instance of the [ListBoxItemAddingEventArgs](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ListBoxItemAddingEventArgs 'DiGi\.UI\.WPF\.Classes\.ListBoxItemAddingEventArgs') class\.

```csharp
public ListBoxItemAddingEventArgs(object? item);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.ListBoxItemAddingEventArgs.ListBoxItemAddingEventArgs(object).item'></a>

`item` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The item that is being added to the [System\.Windows\.Controls\.ListBox](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.listbox 'System\.Windows\.Controls\.ListBox')\.

<a name='DiGi.UI.WPF.Classes.ProgressBarControlWorker'></a>

## ProgressBarControlWorker Class

Provides a base implementation for worker classes that manage the operational state and updates of a [ProgressBarControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ProgressBarControl 'DiGi\.UI\.WPF\.Controls\.ProgressBarControl')\.

```csharp
public abstract class ProgressBarControlWorker : DiGi.UI.WPF.Classes.ControlWorker<DiGi.UI.WPF.Controls.ProgressBarControl>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [VisualWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualWorker 'DiGi\.UI\.WPF\.Classes\.VisualWorker') → [DiGi\.UI\.WPF\.Classes\.ControlWorker&lt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ControlWorker_TControl_ 'DiGi\.UI\.WPF\.Classes\.ControlWorker\<TControl\>')[ProgressBarControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ProgressBarControl 'DiGi\.UI\.WPF\.Controls\.ProgressBarControl')[&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ControlWorker_TControl_ 'DiGi\.UI\.WPF\.Classes\.ControlWorker\<TControl\>') → ProgressBarControlWorker

Derived  
↳ [DeterminateControlWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.DeterminateControlWorker 'DiGi\.UI\.WPF\.Classes\.DeterminateControlWorker')  
↳ [IndeterminateControlWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.IndeterminateControlWorker 'DiGi\.UI\.WPF\.Classes\.IndeterminateControlWorker')
### Constructors

<a name='DiGi.UI.WPF.Classes.ProgressBarControlWorker.ProgressBarControlWorker(DiGi.UI.WPF.Controls.ProgressBarControl)'></a>

## ProgressBarControlWorker\(ProgressBarControl\) Constructor

Initializes a new instance of the [ProgressBarControlWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ProgressBarControlWorker 'DiGi\.UI\.WPF\.Classes\.ProgressBarControlWorker') class\.

```csharp
public ProgressBarControlWorker(DiGi.UI.WPF.Controls.ProgressBarControl progressBarControl);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.ProgressBarControlWorker.ProgressBarControlWorker(DiGi.UI.WPF.Controls.ProgressBarControl).progressBarControl'></a>

`progressBarControl` [ProgressBarControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ProgressBarControl 'DiGi\.UI\.WPF\.Controls\.ProgressBarControl')

The progress bar control instance that this worker will manage\.
### Properties

<a name='DiGi.UI.WPF.Classes.ProgressBarControlWorker.Text'></a>

## ProgressBarControlWorker\.Text Property

Gets or sets the text content displayed in the main label of the associated progress bar control\.

```csharp
public string? Text { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.UI.WPF.Classes.ProgressBarWindowWorker'></a>

## ProgressBarWindowWorker Class

Provides functionality to manage and control a [ProgressBarWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.ProgressBarWindow 'DiGi\.UI\.WPF\.Windows\.ProgressBarWindow') from a background worker context\.

```csharp
public class ProgressBarWindowWorker : DiGi.UI.WPF.Classes.WindowWorker<DiGi.UI.WPF.Windows.ProgressBarWindow>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [VisualWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualWorker 'DiGi\.UI\.WPF\.Classes\.VisualWorker') → [DiGi\.UI\.WPF\.Classes\.WindowWorker&lt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.WindowWorker_TWindow_ 'DiGi\.UI\.WPF\.Classes\.WindowWorker\<TWindow\>')[ProgressBarWindow](DiGi.UI.WPF.Windows.md#DiGi.UI.WPF.Windows.ProgressBarWindow 'DiGi\.UI\.WPF\.Windows\.ProgressBarWindow')[&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.WindowWorker_TWindow_ 'DiGi\.UI\.WPF\.Classes\.WindowWorker\<TWindow\>') → ProgressBarWindowWorker

Derived  
↳ [DeterminateWindowWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.DeterminateWindowWorker 'DiGi\.UI\.WPF\.Classes\.DeterminateWindowWorker')  
↳ [IndeterminateWindowWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.IndeterminateWindowWorker 'DiGi\.UI\.WPF\.Classes\.IndeterminateWindowWorker')
### Constructors

<a name='DiGi.UI.WPF.Classes.ProgressBarWindowWorker.ProgressBarWindowWorker()'></a>

## ProgressBarWindowWorker\(\) Constructor

Initializes a new instance of the [ProgressBarWindowWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ProgressBarWindowWorker 'DiGi\.UI\.WPF\.Classes\.ProgressBarWindowWorker') class\.

```csharp
public ProgressBarWindowWorker();
```

<a name='DiGi.UI.WPF.Classes.ProgressBarWindowWorker.ProgressBarWindowWorker(System.Windows.Window)'></a>

## ProgressBarWindowWorker\(Window\) Constructor

Initializes a new instance of the [ProgressBarWindowWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ProgressBarWindowWorker 'DiGi\.UI\.WPF\.Classes\.ProgressBarWindowWorker') class with a specified owner window\.

```csharp
public ProgressBarWindowWorker(System.Windows.Window? owner);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.ProgressBarWindowWorker.ProgressBarWindowWorker(System.Windows.Window).owner'></a>

`owner` [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window')

The optional owner window for the progress bar window\.
### Properties

<a name='DiGi.UI.WPF.Classes.ProgressBarWindowWorker.Text'></a>

## ProgressBarWindowWorker\.Text Property

Gets or sets the text displayed in the main label of the progress bar window\.

```csharp
public string? Text { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.UI.WPF.Classes.ToggleCommand'></a>

## ToggleCommand Class

Implements the [System\.Windows\.Input\.ICommand](https://learn.microsoft.com/en-us/dotnet/api/system.windows.input.icommand 'System\.Windows\.Input\.ICommand') interface to provide a command that executes a specified action\.

```csharp
public class ToggleCommand : System.Windows.Input.ICommand
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → ToggleCommand

Implements [System\.Windows\.Input\.ICommand](https://learn.microsoft.com/en-us/dotnet/api/system.windows.input.icommand 'System\.Windows\.Input\.ICommand')
### Constructors

<a name='DiGi.UI.WPF.Classes.ToggleCommand.ToggleCommand(System.Action_object_)'></a>

## ToggleCommand\(Action\<object\>\) Constructor

Initializes a new instance of the [ToggleCommand](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ToggleCommand 'DiGi\.UI\.WPF\.Classes\.ToggleCommand') class\.

```csharp
public ToggleCommand(System.Action<object?> execute);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.ToggleCommand.ToggleCommand(System.Action_object_).execute'></a>

`execute` [System\.Action&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.action-1 'System\.Action\`1')

The action to perform when the command is executed\.
### Methods

<a name='DiGi.UI.WPF.Classes.ToggleCommand.CanExecute(object)'></a>

## ToggleCommand\.CanExecute\(object\) Method

Determines whether the command can execute in its current state\.

```csharp
public bool CanExecute(object? parameter);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.ToggleCommand.CanExecute(object).parameter'></a>

`parameter` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The parameter to check for execution capability\.

Implements [CanExecute\(object\)](https://learn.microsoft.com/en-us/dotnet/api/system.windows.input.icommand.canexecute#system-windows-input-icommand-canexecute(system-object) 'System\.Windows\.Input\.ICommand\.CanExecute\(System\.Object\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
Always returns `true`, indicating that the command is always available for execution\.

<a name='DiGi.UI.WPF.Classes.ToggleCommand.Execute(object)'></a>

## ToggleCommand\.Execute\(object\) Method

Executes the command logic\.

```csharp
public void Execute(object? parameter);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.ToggleCommand.Execute(object).parameter'></a>

`parameter` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The parameter to pass to the execute action\.

Implements [Execute\(object\)](https://learn.microsoft.com/en-us/dotnet/api/system.windows.input.icommand.execute#system-windows-input-icommand-execute(system-object) 'System\.Windows\.Input\.ICommand\.Execute\(System\.Object\)')
### Events

<a name='DiGi.UI.WPF.Classes.ToggleCommand.CanExecuteChanged'></a>

## ToggleCommand\.CanExecuteChanged Event

Occurs when conditions change that affect whether the command can be executed\.

```csharp
public event EventHandler? CanExecuteChanged;
```

Implements [CanExecuteChanged](https://learn.microsoft.com/en-us/dotnet/api/system.windows.input.icommand.canexecutechanged 'System\.Windows\.Input\.ICommand\.CanExecuteChanged')

#### Event Type
[System\.EventHandler](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler 'System\.EventHandler')

<a name='DiGi.UI.WPF.Classes.ToggleCommandAsync'></a>

## ToggleCommandAsync Class

Provides an asynchronous implementation of the [System\.Windows\.Input\.ICommand](https://learn.microsoft.com/en-us/dotnet/api/system.windows.input.icommand 'System\.Windows\.Input\.ICommand') interface that prevents concurrent execution of the command logic\.

```csharp
public class ToggleCommandAsync : System.Windows.Input.ICommand
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → ToggleCommandAsync

Implements [System\.Windows\.Input\.ICommand](https://learn.microsoft.com/en-us/dotnet/api/system.windows.input.icommand 'System\.Windows\.Input\.ICommand')
### Constructors

<a name='DiGi.UI.WPF.Classes.ToggleCommandAsync.ToggleCommandAsync(System.Func_object,System.Threading.Tasks.Task_,System.Predicate_object_)'></a>

## ToggleCommandAsync\(Func\<object,Task\>, Predicate\<object\>\) Constructor

Initializes a new instance of the [ToggleCommandAsync](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ToggleCommandAsync 'DiGi\.UI\.WPF\.Classes\.ToggleCommandAsync') class\.

```csharp
public ToggleCommandAsync(System.Func<object?,System.Threading.Tasks.Task> execute, System.Predicate<object?>? canExecute=null);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.ToggleCommandAsync.ToggleCommandAsync(System.Func_object,System.Threading.Tasks.Task_,System.Predicate_object_).execute'></a>

`execute` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The asynchronous delegate that defines the logic to be executed\.

<a name='DiGi.UI.WPF.Classes.ToggleCommandAsync.ToggleCommandAsync(System.Func_object,System.Threading.Tasks.Task_,System.Predicate_object_).canExecute'></a>

`canExecute` [System\.Predicate&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.predicate-1 'System\.Predicate\`1')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.predicate-1 'System\.Predicate\`1')

An optional predicate that determines whether the command can be executed based on the provided parameter\.
### Methods

<a name='DiGi.UI.WPF.Classes.ToggleCommandAsync.CanExecute(object)'></a>

## ToggleCommandAsync\.CanExecute\(object\) Method

Determines whether the command can be executed in its current state\.

```csharp
public bool CanExecute(object? parameter);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.ToggleCommandAsync.CanExecute(object).parameter'></a>

`parameter` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to pass as a parameter to determine if the command can execute\.

Implements [CanExecute\(object\)](https://learn.microsoft.com/en-us/dotnet/api/system.windows.input.icommand.canexecute#system-windows-input-icommand-canexecute(system-object) 'System\.Windows\.Input\.ICommand\.CanExecute\(System\.Object\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the command is not currently executing and the optional `canExecute` predicate returns true; otherwise, false\.

<a name='DiGi.UI.WPF.Classes.ToggleCommandAsync.Execute(object)'></a>

## ToggleCommandAsync\.Execute\(object\) Method

Executes the asynchronous logic associated with this command\.

```csharp
public void Execute(object? parameter);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.ToggleCommandAsync.Execute(object).parameter'></a>

`parameter` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to pass as a parameter to the execution logic\.

Implements [Execute\(object\)](https://learn.microsoft.com/en-us/dotnet/api/system.windows.input.icommand.execute#system-windows-input-icommand-execute(system-object) 'System\.Windows\.Input\.ICommand\.Execute\(System\.Object\)')
### Events

<a name='DiGi.UI.WPF.Classes.ToggleCommandAsync.CanExecuteChanged'></a>

## ToggleCommandAsync\.CanExecuteChanged Event

Occurs when there is a change in the can\-execute status of the command\.

```csharp
public event EventHandler? CanExecuteChanged;
```

Implements [CanExecuteChanged](https://learn.microsoft.com/en-us/dotnet/api/system.windows.input.icommand.canexecutechanged 'System\.Windows\.Input\.ICommand\.CanExecuteChanged')

#### Event Type
[System\.EventHandler](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler 'System\.EventHandler')

<a name='DiGi.UI.WPF.Classes.TreeViewItemAddingEventArgs'></a>

## TreeViewItemAddingEventArgs Class

Provides data for events that occur when an item is being added to a tree view\.

```csharp
public class TreeViewItemAddingEventArgs : DiGi.UI.WPF.Classes.ItemAddingEventArgs
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.EventArgs](https://learn.microsoft.com/en-us/dotnet/api/system.eventargs 'System\.EventArgs') → [ItemAddingEventArgs](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemAddingEventArgs 'DiGi\.UI\.WPF\.Classes\.ItemAddingEventArgs') → TreeViewItemAddingEventArgs

Derived  
↳ [CheckBoxTreeViewItemAddingEventArgs](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.CheckBoxTreeViewItemAddingEventArgs 'DiGi\.UI\.WPF\.Classes\.CheckBoxTreeViewItemAddingEventArgs')
### Constructors

<a name='DiGi.UI.WPF.Classes.TreeViewItemAddingEventArgs.TreeViewItemAddingEventArgs(object)'></a>

## TreeViewItemAddingEventArgs\(object\) Constructor

Initializes a new instance of the [TreeViewItemAddingEventArgs](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.TreeViewItemAddingEventArgs 'DiGi\.UI\.WPF\.Classes\.TreeViewItemAddingEventArgs') class\.

```csharp
public TreeViewItemAddingEventArgs(object? item);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.TreeViewItemAddingEventArgs.TreeViewItemAddingEventArgs(object).item'></a>

`item` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The item that is being added to the tree view\.
### Properties

<a name='DiGi.UI.WPF.Classes.TreeViewItemAddingEventArgs.Path'></a>

## TreeViewItemAddingEventArgs\.Path Property

Gets or sets the path associated with the tree view item\. 
Setting this property creates a clone of the provided path and marks the event as handled\.

```csharp
public DiGi.UI.WPF.Classes.ItemPath? Path { get; set; }
```

#### Property Value
[ItemPath](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ItemPath 'DiGi\.UI\.WPF\.Classes\.ItemPath')

<a name='DiGi.UI.WPF.Classes.ValueTreeViewItem'></a>

## ValueTreeViewItem Class

Represents a tree view item that encapsulates an underlying value\.

```csharp
public class ValueTreeViewItem : System.Windows.Controls.TreeViewItem
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Windows\.Threading\.DispatcherObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.threading.dispatcherobject 'System\.Windows\.Threading\.DispatcherObject') → [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') → [System\.Windows\.Media\.Visual](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.visual 'System\.Windows\.Media\.Visual') → [System\.Windows\.UIElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.uielement 'System\.Windows\.UIElement') → [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement') → [System\.Windows\.Controls\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.control 'System\.Windows\.Controls\.Control') → [System\.Windows\.Controls\.ItemsControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.itemscontrol 'System\.Windows\.Controls\.ItemsControl') → [System\.Windows\.Controls\.HeaderedItemsControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.headereditemscontrol 'System\.Windows\.Controls\.HeaderedItemsControl') → [System\.Windows\.Controls\.TreeViewItem](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.treeviewitem 'System\.Windows\.Controls\.TreeViewItem') → ValueTreeViewItem
### Constructors

<a name='DiGi.UI.WPF.Classes.ValueTreeViewItem.ValueTreeViewItem(object)'></a>

## ValueTreeViewItem\(object\) Constructor

Initializes a new instance of the [ValueTreeViewItem](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ValueTreeViewItem 'DiGi\.UI\.WPF\.Classes\.ValueTreeViewItem') class with the specified value\.

```csharp
public ValueTreeViewItem(object? value);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.ValueTreeViewItem.ValueTreeViewItem(object).value'></a>

`value` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The underlying value to be associated with this tree view item\.
### Properties

<a name='DiGi.UI.WPF.Classes.ValueTreeViewItem.Value'></a>

## ValueTreeViewItem\.Value Property

Gets the underlying value associated with this tree view item\.

```csharp
public object? Value { get; }
```

#### Property Value
[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask'></a>

## VisualBackgroundTask Class

A non\-generic implementation of [VisualBackgroundTask&lt;TBackgroundTask&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_ 'DiGi\.UI\.WPF\.Classes\.VisualBackgroundTask\<TBackgroundTask\>') using the base [DiGi\.Core\.Interfaces\.IBackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ibackgroundtask 'DiGi\.Core\.Interfaces\.IBackgroundTask') interface\.

```csharp
public class VisualBackgroundTask : DiGi.UI.WPF.Classes.VisualBackgroundTask<DiGi.Core.Interfaces.IBackgroundTask>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.UI\.WPF\.Classes\.VisualBackgroundTask&lt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_ 'DiGi\.UI\.WPF\.Classes\.VisualBackgroundTask\<TBackgroundTask\>')[DiGi\.Core\.Interfaces\.IBackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ibackgroundtask 'DiGi\.Core\.Interfaces\.IBackgroundTask')[&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_ 'DiGi\.UI\.WPF\.Classes\.VisualBackgroundTask\<TBackgroundTask\>') → VisualBackgroundTask
### Constructors

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask.VisualBackgroundTask(DiGi.Core.Interfaces.IBackgroundTask,string,string)'></a>

## VisualBackgroundTask\(IBackgroundTask, string, string\) Constructor

Initializes a new instance of the [VisualBackgroundTask](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualBackgroundTask 'DiGi\.UI\.WPF\.Classes\.VisualBackgroundTask') class\.

```csharp
public VisualBackgroundTask(DiGi.Core.Interfaces.IBackgroundTask backgroundTask, string name, string description);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask.VisualBackgroundTask(DiGi.Core.Interfaces.IBackgroundTask,string,string).backgroundTask'></a>

`backgroundTask` [DiGi\.Core\.Interfaces\.IBackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ibackgroundtask 'DiGi\.Core\.Interfaces\.IBackgroundTask')

The background task instance to be wrapped\.

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask.VisualBackgroundTask(DiGi.Core.Interfaces.IBackgroundTask,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display name of the background task\.

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask.VisualBackgroundTask(DiGi.Core.Interfaces.IBackgroundTask,string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

A detailed description of the background task\.

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_'></a>

## VisualBackgroundTask\<TBackgroundTask\> Class

Provides a visual wrapper for a background task, enabling integration with WPF UI components and providing properties for monitoring execution status and time\.

```csharp
public class VisualBackgroundTask<TBackgroundTask> : DiGi.UI.WPF.Interfaces.IVisualBackgroundTask, DiGi.UI.WPF.Interfaces.IWPFObject, DiGi.Core.Interfaces.IObject, System.ComponentModel.INotifyPropertyChanged, DiGi.Core.Interfaces.INamedObject, DiGi.Core.Interfaces.IDescribableObject
    where TBackgroundTask : DiGi.Core.Interfaces.IBackgroundTask
```
#### Type parameters

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.TBackgroundTask'></a>

`TBackgroundTask`

The type of the background task, which must implement [DiGi\.Core\.Interfaces\.IBackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ibackgroundtask 'DiGi\.Core\.Interfaces\.IBackgroundTask')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → VisualBackgroundTask\<TBackgroundTask\>

Derived  
↳ [VisualBackgroundTask](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualBackgroundTask 'DiGi\.UI\.WPF\.Classes\.VisualBackgroundTask')  
↳ [VisualReportableBackgroundTask&lt;T,TReportableBackgroundTask&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T,TReportableBackgroundTask_ 'DiGi\.UI\.WPF\.Classes\.VisualReportableBackgroundTask\<T,TReportableBackgroundTask\>')

Implements [IVisualBackgroundTask](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IVisualBackgroundTask 'DiGi\.UI\.WPF\.Interfaces\.IVisualBackgroundTask'), [IWPFObject](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IWPFObject 'DiGi\.UI\.WPF\.Interfaces\.IWPFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [System\.ComponentModel\.INotifyPropertyChanged](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged 'System\.ComponentModel\.INotifyPropertyChanged'), [DiGi\.Core\.Interfaces\.INamedObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject 'DiGi\.Core\.Interfaces\.INamedObject'), [DiGi\.Core\.Interfaces\.IDescribableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject 'DiGi\.Core\.Interfaces\.IDescribableObject')
### Constructors

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.VisualBackgroundTask(TBackgroundTask,string,string)'></a>

## VisualBackgroundTask\(TBackgroundTask, string, string\) Constructor

Initializes a new instance of the [VisualBackgroundTask&lt;TBackgroundTask&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_ 'DiGi\.UI\.WPF\.Classes\.VisualBackgroundTask\<TBackgroundTask\>') class\.

```csharp
public VisualBackgroundTask(TBackgroundTask backgroundTask, string name, string description);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.VisualBackgroundTask(TBackgroundTask,string,string).backgroundTask'></a>

`backgroundTask` [TBackgroundTask](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.TBackgroundTask 'DiGi\.UI\.WPF\.Classes\.VisualBackgroundTask\<TBackgroundTask\>\.TBackgroundTask')

The background task instance to be wrapped\.

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.VisualBackgroundTask(TBackgroundTask,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display name of the background task\.

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.VisualBackgroundTask(TBackgroundTask,string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

A detailed description of the background task\.
### Properties

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.CanToggle'></a>

## VisualBackgroundTask\<TBackgroundTask\>\.CanToggle Property

Gets a value indicating whether the background task can currently be toggled \(started or stopped\)\.

```csharp
public bool CanToggle { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.Description'></a>

## VisualBackgroundTask\<TBackgroundTask\>\.Description Property

Gets the description of the background task\.

```csharp
public string? Description { get; }
```

Implements [Description](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.idescribableobject.description 'DiGi\.Core\.Interfaces\.IDescribableObject\.Description')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.ExceptionText'></a>

## VisualBackgroundTask\<TBackgroundTask\>\.ExceptionText Property

Gets the type and message of the exception that caused the task to fail, with the message of every inner exception appended, or null if no exception occurred\.

The message alone leaves a reader guessing: "Object reference not set to an instance of an object." names neither what threw nor which call it came from. The type is what makes it actionable at a glance.

This is what the task list shows on hover, so it deliberately stops short of the stack trace. [StatusText](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.StatusText 'DiGi\.UI\.WPF\.Classes\.VisualBackgroundTask\<TBackgroundTask\>\.StatusText') carries the full detail for copying.

```csharp
public string? ExceptionText { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.ExecutionTimeSpanText'></a>

## VisualBackgroundTask\<TBackgroundTask\>\.ExecutionTimeSpanText Property

Gets the total execution time of the task formatted as a string in "HH:mm:ss" format\.

```csharp
public string ExecutionTimeSpanText { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.IsRunning'></a>

## VisualBackgroundTask\<TBackgroundTask\>\.IsRunning Property

Gets a value indicating whether the underlying background task is currently running\.

```csharp
public bool IsRunning { get; }
```

Implements [IsRunning](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IVisualBackgroundTask.IsRunning 'DiGi\.UI\.WPF\.Interfaces\.IVisualBackgroundTask\.IsRunning')

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.Name'></a>

## VisualBackgroundTask\<TBackgroundTask\>\.Name Property

Gets the display name of the background task\.

```csharp
public string? Name { get; }
```

Implements [Name](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.inamedobject.name 'DiGi\.Core\.Interfaces\.INamedObject\.Name')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.Status'></a>

## VisualBackgroundTask\<TBackgroundTask\>\.Status Property

Gets the current status description of the background task\.

```csharp
public virtual string Status { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.StatusText'></a>

## VisualBackgroundTask\<TBackgroundTask\>\.StatusText Property

Gets the text the status cell contributes to the clipboard: the exception in full when the task failed, the status otherwise\.

[System\.Exception\.ToString](https://learn.microsoft.com/en-us/dotnet/api/system.exception.tostring 'System\.Exception\.ToString') carries the type, the message, the stack trace and every inner exception in one string, which is what makes a failure reportable by selecting the row and pressing Ctrl+C rather than reading a tooltip and retyping it.

The fallback to the status is what keeps a successful row worth copying - without it the status field would come out empty.

```csharp
public string? StatusText { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.ToggleCommandAsync'></a>

## VisualBackgroundTask\<TBackgroundTask\>\.ToggleCommandAsync Property

Gets the command used to asynchronously toggle the execution state of the background task\.

```csharp
public System.Windows.Input.ICommand ToggleCommandAsync { get; }
```

#### Property Value
[System\.Windows\.Input\.ICommand](https://learn.microsoft.com/en-us/dotnet/api/system.windows.input.icommand 'System\.Windows\.Input\.ICommand')

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.ToggleText'></a>

## VisualBackgroundTask\<TBackgroundTask\>\.ToggleText Property

Gets the text to be displayed on the toggle button, indicating whether the next action is to "Start" or "Stop"\.

```csharp
public string ToggleText { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.ToolTipText'></a>

## VisualBackgroundTask\<TBackgroundTask\>\.ToolTipText Property

Gets the text the Task Name cell shows on hover: the name, followed by the description on a second line\.

The name is repeated here rather than only the description, because the cell that shows it is the one column sized from what the fixed columns leave over, so it is the one that can still trim its text. A trimmed name is then unreadable and the description alone does not carry it.

Returns null, not an empty string, when there is nothing to show - a null tooltip is not displayed at all, while an empty one hovers as an empty box.

```csharp
public string? ToolTipText { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.TypeName'></a>

## VisualBackgroundTask\<TBackgroundTask\>\.TypeName Property

Gets the name of the type of the underlying background task\.

```csharp
public string? TypeName { get; }
```

Implements [TypeName](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IVisualBackgroundTask.TypeName 'DiGi\.UI\.WPF\.Interfaces\.IVisualBackgroundTask\.TypeName')

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.Start()'></a>

## VisualBackgroundTask\<TBackgroundTask\>\.Start\(\) Method

Starts the execution of the background task if it is not already running\.

```csharp
public void Start();
```

Implements [Start\(\)](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IVisualBackgroundTask.Start() 'DiGi\.UI\.WPF\.Interfaces\.IVisualBackgroundTask\.Start\(\)')
### Events

<a name='DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_.PropertyChanged'></a>

## VisualBackgroundTask\<TBackgroundTask\>\.PropertyChanged Event

Occurs when a property value changes\.

```csharp
public event PropertyChangedEventHandler? PropertyChanged;
```

Implements [PropertyChanged](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged.propertychanged 'System\.ComponentModel\.INotifyPropertyChanged\.PropertyChanged')

#### Event Type
[System\.ComponentModel\.PropertyChangedEventHandler](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.propertychangedeventhandler 'System\.ComponentModel\.PropertyChangedEventHandler')

<a name='DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T,TReportableBackgroundTask_'></a>

## VisualReportableBackgroundTask\<T,TReportableBackgroundTask\> Class

A visual representation of a reportable background task that tracks and displays reported values\.

```csharp
public class VisualReportableBackgroundTask<T,TReportableBackgroundTask> : DiGi.UI.WPF.Classes.VisualBackgroundTask<TReportableBackgroundTask>
    where TReportableBackgroundTask : DiGi.Core.Interfaces.IReportableBackgroundTask<T>
```
#### Type parameters

<a name='DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T,TReportableBackgroundTask_.T'></a>

`T`

The type of the progress data reported by the background task\.

<a name='DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T,TReportableBackgroundTask_.TReportableBackgroundTask'></a>

`TReportableBackgroundTask`

The specific type of the reportable background task implementation\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.UI\.WPF\.Classes\.VisualBackgroundTask&lt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_ 'DiGi\.UI\.WPF\.Classes\.VisualBackgroundTask\<TBackgroundTask\>')[TReportableBackgroundTask](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T,TReportableBackgroundTask_.TReportableBackgroundTask 'DiGi\.UI\.WPF\.Classes\.VisualReportableBackgroundTask\<T,TReportableBackgroundTask\>\.TReportableBackgroundTask')[&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_ 'DiGi\.UI\.WPF\.Classes\.VisualBackgroundTask\<TBackgroundTask\>') → VisualReportableBackgroundTask\<T,TReportableBackgroundTask\>

Derived  
↳ [VisualReportableBackgroundTask&lt;T&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T_ 'DiGi\.UI\.WPF\.Classes\.VisualReportableBackgroundTask\<T\>')
### Constructors

<a name='DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T,TReportableBackgroundTask_.VisualReportableBackgroundTask(TReportableBackgroundTask,string,string)'></a>

## VisualReportableBackgroundTask\(TReportableBackgroundTask, string, string\) Constructor

Initializes a new instance of the [VisualReportableBackgroundTask&lt;T,TReportableBackgroundTask&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T,TReportableBackgroundTask_ 'DiGi\.UI\.WPF\.Classes\.VisualReportableBackgroundTask\<T,TReportableBackgroundTask\>') class\.

```csharp
public VisualReportableBackgroundTask(TReportableBackgroundTask reportableBackgroundTask, string name, string description);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T,TReportableBackgroundTask_.VisualReportableBackgroundTask(TReportableBackgroundTask,string,string).reportableBackgroundTask'></a>

`reportableBackgroundTask` [TReportableBackgroundTask](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T,TReportableBackgroundTask_.TReportableBackgroundTask 'DiGi\.UI\.WPF\.Classes\.VisualReportableBackgroundTask\<T,TReportableBackgroundTask\>\.TReportableBackgroundTask')

The reportable background task to be visually tracked\.

<a name='DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T,TReportableBackgroundTask_.VisualReportableBackgroundTask(TReportableBackgroundTask,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display name of the task\.

<a name='DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T,TReportableBackgroundTask_.VisualReportableBackgroundTask(TReportableBackgroundTask,string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

A description of the task\.
### Properties

<a name='DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T,TReportableBackgroundTask_.Status'></a>

## VisualReportableBackgroundTask\<T,TReportableBackgroundTask\>\.Status Property

Gets the status of the background task, appended with the current reported value if the task is running and the value is a non\-empty string\.

```csharp
public override string Status { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T,TReportableBackgroundTask_.Value'></a>

## VisualReportableBackgroundTask\<T,TReportableBackgroundTask\>\.Value Property

Gets or sets the current value reported by the background task\.

```csharp
public T? Value { get; set; }
```

#### Property Value
[T](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T,TReportableBackgroundTask_.T 'DiGi\.UI\.WPF\.Classes\.VisualReportableBackgroundTask\<T,TReportableBackgroundTask\>\.T')

<a name='DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T_'></a>

## VisualReportableBackgroundTask\<T\> Class

A visual representation of a reportable background task using the generic [DiGi\.Core\.Interfaces\.IReportableBackgroundTask&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireportablebackgroundtask-1 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask\`1') interface\.

```csharp
public class VisualReportableBackgroundTask<T> : DiGi.UI.WPF.Classes.VisualReportableBackgroundTask<T, DiGi.Core.Interfaces.IReportableBackgroundTask<T>>
```
#### Type parameters

<a name='DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T_.T'></a>

`T`

The type of the progress data reported by the background task\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.UI\.WPF\.Classes\.VisualBackgroundTask&lt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_ 'DiGi\.UI\.WPF\.Classes\.VisualBackgroundTask\<TBackgroundTask\>')[DiGi\.Core\.Interfaces\.IReportableBackgroundTask&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireportablebackgroundtask-1 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask\`1')[T](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T_.T 'DiGi\.UI\.WPF\.Classes\.VisualReportableBackgroundTask\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireportablebackgroundtask-1 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask\`1')[&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualBackgroundTask_TBackgroundTask_ 'DiGi\.UI\.WPF\.Classes\.VisualBackgroundTask\<TBackgroundTask\>') → [DiGi\.UI\.WPF\.Classes\.VisualReportableBackgroundTask&lt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T,TReportableBackgroundTask_ 'DiGi\.UI\.WPF\.Classes\.VisualReportableBackgroundTask\<T,TReportableBackgroundTask\>')[T](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T_.T 'DiGi\.UI\.WPF\.Classes\.VisualReportableBackgroundTask\<T\>\.T')[,](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T,TReportableBackgroundTask_ 'DiGi\.UI\.WPF\.Classes\.VisualReportableBackgroundTask\<T,TReportableBackgroundTask\>')[DiGi\.Core\.Interfaces\.IReportableBackgroundTask&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireportablebackgroundtask-1 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask\`1')[T](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T_.T 'DiGi\.UI\.WPF\.Classes\.VisualReportableBackgroundTask\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireportablebackgroundtask-1 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask\`1')[&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T,TReportableBackgroundTask_ 'DiGi\.UI\.WPF\.Classes\.VisualReportableBackgroundTask\<T,TReportableBackgroundTask\>') → VisualReportableBackgroundTask\<T\>
### Constructors

<a name='DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T_.VisualReportableBackgroundTask(DiGi.Core.Interfaces.IReportableBackgroundTask_T_,string,string)'></a>

## VisualReportableBackgroundTask\(IReportableBackgroundTask\<T\>, string, string\) Constructor

Initializes a new instance of the [VisualReportableBackgroundTask&lt;T&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T_ 'DiGi\.UI\.WPF\.Classes\.VisualReportableBackgroundTask\<T\>') class\.

```csharp
public VisualReportableBackgroundTask(DiGi.Core.Interfaces.IReportableBackgroundTask<T> reportableBackgroundTask, string name, string description);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T_.VisualReportableBackgroundTask(DiGi.Core.Interfaces.IReportableBackgroundTask_T_,string,string).reportableBackgroundTask'></a>

`reportableBackgroundTask` [DiGi\.Core\.Interfaces\.IReportableBackgroundTask&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireportablebackgroundtask-1 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask\`1')[T](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T_.T 'DiGi\.UI\.WPF\.Classes\.VisualReportableBackgroundTask\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireportablebackgroundtask-1 'DiGi\.Core\.Interfaces\.IReportableBackgroundTask\`1')

The reportable background task to be visually tracked\.

<a name='DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T_.VisualReportableBackgroundTask(DiGi.Core.Interfaces.IReportableBackgroundTask_T_,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The display name of the task\.

<a name='DiGi.UI.WPF.Classes.VisualReportableBackgroundTask_T_.VisualReportableBackgroundTask(DiGi.Core.Interfaces.IReportableBackgroundTask_T_,string,string).description'></a>

`description` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

A description of the task\.

<a name='DiGi.UI.WPF.Classes.VisualWorker'></a>

## VisualWorker Class

Provides an abstract base implementation of a visual worker that wraps a [System\.ComponentModel\.BackgroundWorker](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.backgroundworker 'System\.ComponentModel\.BackgroundWorker') to handle asynchronous operations\.

```csharp
public abstract class VisualWorker : DiGi.UI.WPF.Interfaces.IVisualWorker, DiGi.UI.WPF.Interfaces.IWPFObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.IWorker
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → VisualWorker

Derived  
↳ [ControlWorker&lt;TControl&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ControlWorker_TControl_ 'DiGi\.UI\.WPF\.Classes\.ControlWorker\<TControl\>')  
↳ [WindowWorker&lt;TWindow&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.WindowWorker_TWindow_ 'DiGi\.UI\.WPF\.Classes\.WindowWorker\<TWindow\>')

Implements [IVisualWorker](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IVisualWorker 'DiGi\.UI\.WPF\.Interfaces\.IVisualWorker'), [IWPFObject](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IWPFObject 'DiGi\.UI\.WPF\.Interfaces\.IWPFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.IWorker](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iworker 'DiGi\.Core\.Interfaces\.IWorker')
### Constructors

<a name='DiGi.UI.WPF.Classes.VisualWorker.VisualWorker()'></a>

## VisualWorker\(\) Constructor

Initializes a new instance of the [VisualWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualWorker 'DiGi\.UI\.WPF\.Classes\.VisualWorker') class and attaches internal handlers to the background worker's events\.

```csharp
public VisualWorker();
```
### Properties

<a name='DiGi.UI.WPF.Classes.VisualWorker.IsBusy'></a>

## VisualWorker\.IsBusy Property

Gets a value indicating whether the worker is currently busy\.

```csharp
public bool IsBusy { get; }
```

Implements [IsBusy](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iworker.isbusy 'DiGi\.Core\.Interfaces\.IWorker\.IsBusy')

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')
### Methods

<a name='DiGi.UI.WPF.Classes.VisualWorker.Run()'></a>

## VisualWorker\.Run\(\) Method

Starts the asynchronous execution of the background worker\.

```csharp
public virtual void Run();
```
### Events

<a name='DiGi.UI.WPF.Classes.VisualWorker.DoWork'></a>

## VisualWorker\.DoWork Event

Occurs when the background worker begins its operation\.

```csharp
public event DoWorkEventHandler? DoWork;
```

#### Event Type
[System\.ComponentModel\.DoWorkEventHandler](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.doworkeventhandler 'System\.ComponentModel\.DoWorkEventHandler')

<a name='DiGi.UI.WPF.Classes.VisualWorker.RunWorkerCompleted'></a>

## VisualWorker\.RunWorkerCompleted Event

Occurs when the background worker completes its operation\.

```csharp
public event RunWorkerCompletedEventHandler? RunWorkerCompleted;
```

#### Event Type
[System\.ComponentModel\.RunWorkerCompletedEventHandler](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.runworkercompletedeventhandler 'System\.ComponentModel\.RunWorkerCompletedEventHandler')

<a name='DiGi.UI.WPF.Classes.WindowWorker_TWindow_'></a>

## WindowWorker\<TWindow\> Class

Provides an abstract base implementation for a worker that manages the lifecycle and display of a WPF window\.

```csharp
public abstract class WindowWorker<TWindow> : DiGi.UI.WPF.Classes.VisualWorker
    where TWindow : System.Windows.Window
```
#### Type parameters

<a name='DiGi.UI.WPF.Classes.WindowWorker_TWindow_.TWindow'></a>

`TWindow`

The type of the window managed by this worker, which must derive from [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [VisualWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.VisualWorker 'DiGi\.UI\.WPF\.Classes\.VisualWorker') → WindowWorker\<TWindow\>

Derived  
↳ [CancellableProgressBarWindowWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.CancellableProgressBarWindowWorker 'DiGi\.UI\.WPF\.Classes\.CancellableProgressBarWindowWorker')  
↳ [ProgressBarWindowWorker](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.ProgressBarWindowWorker 'DiGi\.UI\.WPF\.Classes\.ProgressBarWindowWorker')
### Constructors

<a name='DiGi.UI.WPF.Classes.WindowWorker_TWindow_.WindowWorker()'></a>

## WindowWorker\(\) Constructor

Initializes a new instance of the [WindowWorker&lt;TWindow&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.WindowWorker_TWindow_ 'DiGi\.UI\.WPF\.Classes\.WindowWorker\<TWindow\>') class\.

```csharp
public WindowWorker();
```

<a name='DiGi.UI.WPF.Classes.WindowWorker_TWindow_.WindowWorker(TWindow)'></a>

## WindowWorker\(TWindow\) Constructor

Initializes a new instance of the [WindowWorker&lt;TWindow&gt;](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.WindowWorker_TWindow_ 'DiGi\.UI\.WPF\.Classes\.WindowWorker\<TWindow\>') class with a specified window\.

```csharp
public WindowWorker(TWindow? window);
```
#### Parameters

<a name='DiGi.UI.WPF.Classes.WindowWorker_TWindow_.WindowWorker(TWindow).window'></a>

`window` [TWindow](DiGi.UI.WPF.Classes.md#DiGi.UI.WPF.Classes.WindowWorker_TWindow_.TWindow 'DiGi\.UI\.WPF\.Classes\.WindowWorker\<TWindow\>\.TWindow')

The window instance to be managed by this worker\.
### Properties

<a name='DiGi.UI.WPF.Classes.WindowWorker_TWindow_.Owner'></a>

## WindowWorker\<TWindow\>\.Owner Property

Gets or sets the owner of the managed window\.

```csharp
public System.Windows.Window? Owner { get; set; }
```

#### Property Value
[System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window')  
The [System\.Windows\.Window](https://learn.microsoft.com/en-us/dotnet/api/system.windows.window 'System\.Windows\.Window') that owns the managed window, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no owner is set\.
### Methods

<a name='DiGi.UI.WPF.Classes.WindowWorker_TWindow_.Run()'></a>

## WindowWorker\<TWindow\>\.Run\(\) Method

Executes the worker's logic and invokes the display of the managed window on the UI thread\.

```csharp
public override void Run();
```