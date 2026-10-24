#### [DiGi\.UI\.WPF](DiGi.UI.WPF.Overview.md 'DiGi\.UI\.WPF\.Overview')

## DiGi\.UI\.WPF\.Controls Namespace
### Classes

<a name='DiGi.UI.WPF.Controls.CheckBoxTreeViewControl'></a>

## CheckBoxTreeViewControl Class

Interaction logic for CheckBoxTreeViewControl\.xaml

```csharp
public class CheckBoxTreeViewControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Windows\.Threading\.DispatcherObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.threading.dispatcherobject 'System\.Windows\.Threading\.DispatcherObject') → [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') → [System\.Windows\.Media\.Visual](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.visual 'System\.Windows\.Media\.Visual') → [System\.Windows\.UIElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.uielement 'System\.Windows\.UIElement') → [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement') → [System\.Windows\.Controls\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.control 'System\.Windows\.Controls\.Control') → [System\.Windows\.Controls\.ContentControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.contentcontrol 'System\.Windows\.Controls\.ContentControl') → [System\.Windows\.Controls\.UserControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.usercontrol 'System\.Windows\.Controls\.UserControl') → CheckBoxTreeViewControl

Implements [System\.Windows\.Markup\.IComponentConnector](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector 'System\.Windows\.Markup\.IComponentConnector')
### Constructors

<a name='DiGi.UI.WPF.Controls.CheckBoxTreeViewControl.CheckBoxTreeViewControl()'></a>

## CheckBoxTreeViewControl\(\) Constructor

Initializes a new instance of the [CheckBoxTreeViewControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.CheckBoxTreeViewControl 'DiGi\.UI\.WPF\.Controls\.CheckBoxTreeViewControl') class\.

```csharp
public CheckBoxTreeViewControl();
```
### Methods

<a name='DiGi.UI.WPF.Controls.CheckBoxTreeViewControl.CollapseAll()'></a>

## CheckBoxTreeViewControl\.CollapseAll\(\) Method

Collapses all nodes within the tree view\.

```csharp
public void CollapseAll();
```

<a name='DiGi.UI.WPF.Controls.CheckBoxTreeViewControl.ExpandaAll()'></a>

## CheckBoxTreeViewControl\.ExpandaAll\(\) Method

Expands all nodes within the tree view\.

```csharp
public void ExpandaAll();
```

<a name='DiGi.UI.WPF.Controls.CheckBoxTreeViewControl.GetItems_T_(bool)'></a>

## CheckBoxTreeViewControl\.GetItems\<T\>\(bool\) Method

Retrieves a list of items of type [T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.CheckBoxTreeViewControl.GetItems_T_(bool).T 'DiGi\.UI\.WPF\.Controls\.CheckBoxTreeViewControl\.GetItems\<T\>\(bool\)\.T') from the tree view, optionally filtered by their selection state\.

```csharp
public System.Collections.Generic.List<T>? GetItems<T>(bool selected=true);
```
#### Type parameters

<a name='DiGi.UI.WPF.Controls.CheckBoxTreeViewControl.GetItems_T_(bool).T'></a>

`T`

The type of items to retrieve\.
#### Parameters

<a name='DiGi.UI.WPF.Controls.CheckBoxTreeViewControl.GetItems_T_(bool).selected'></a>

`selected` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A boolean indicating whether only selected items should be returned\. Defaults to `true`\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.CheckBoxTreeViewControl.GetItems_T_(bool).T 'DiGi\.UI\.WPF\.Controls\.CheckBoxTreeViewControl\.GetItems\<T\>\(bool\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of items of type [T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.CheckBoxTreeViewControl.GetItems_T_(bool).T 'DiGi\.UI\.WPF\.Controls\.CheckBoxTreeViewControl\.GetItems\<T\>\(bool\)\.T'), or `null` if no matching items are found\.

<a name='DiGi.UI.WPF.Controls.CheckBoxTreeViewControl.InitializeComponent()'></a>

## CheckBoxTreeViewControl\.InitializeComponent\(\) Method

InitializeComponent

```csharp
public void InitializeComponent();
```

Implements [InitializeComponent\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector.initializecomponent 'System\.Windows\.Markup\.IComponentConnector\.InitializeComponent')

<a name='DiGi.UI.WPF.Controls.CheckBoxTreeViewControl.SetItems_T_(System.Collections.Generic.IEnumerable_T_)'></a>

## CheckBoxTreeViewControl\.SetItems\<T\>\(IEnumerable\<T\>\) Method

Populates the tree view with a collection of items\.

```csharp
public void SetItems<T>(System.Collections.Generic.IEnumerable<T> values);
```
#### Type parameters

<a name='DiGi.UI.WPF.Controls.CheckBoxTreeViewControl.SetItems_T_(System.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of values to be added to the tree view\.
#### Parameters

<a name='DiGi.UI.WPF.Controls.CheckBoxTreeViewControl.SetItems_T_(System.Collections.Generic.IEnumerable_T_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.CheckBoxTreeViewControl.SetItems_T_(System.Collections.Generic.IEnumerable_T_).T 'DiGi\.UI\.WPF\.Controls\.CheckBoxTreeViewControl\.SetItems\<T\>\(System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An enumerable collection of values to populate the control\.
### Events

<a name='DiGi.UI.WPF.Controls.CheckBoxTreeViewControl.ItemAdding'></a>

## CheckBoxTreeViewControl\.ItemAdding Event

Occurs when an item is being added to the tree view, allowing for customization of the item's path and name\.

```csharp
public event CheckBoxTreeViewItemAddingEventHandler? ItemAdding;
```

#### Event Type
[CheckBoxTreeViewItemAddingEventHandler\(object, CheckBoxTreeViewItemAddingEventArgs\)](DiGi.UI.WPF.Delegates.md#DiGi.UI.WPF.Delegates.CheckBoxTreeViewItemAddingEventHandler(object,DiGi.UI.WPF.Classes.CheckBoxTreeViewItemAddingEventArgs) 'DiGi\.UI\.WPF\.Delegates\.CheckBoxTreeViewItemAddingEventHandler\(object, DiGi\.UI\.WPF\.Classes\.CheckBoxTreeViewItemAddingEventArgs\)')

<a name='DiGi.UI.WPF.Controls.ListBoxControl'></a>

## ListBoxControl Class

Interaction logic for ListBoxControl\.xaml

```csharp
public class ListBoxControl : System.Windows.Controls.UserControl, DiGi.UI.WPF.Interfaces.IControl, DiGi.UI.WPF.Interfaces.IWPFObject, DiGi.Core.Interfaces.IObject, System.Windows.Markup.IComponentConnector
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Windows\.Threading\.DispatcherObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.threading.dispatcherobject 'System\.Windows\.Threading\.DispatcherObject') → [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') → [System\.Windows\.Media\.Visual](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.visual 'System\.Windows\.Media\.Visual') → [System\.Windows\.UIElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.uielement 'System\.Windows\.UIElement') → [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement') → [System\.Windows\.Controls\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.control 'System\.Windows\.Controls\.Control') → [System\.Windows\.Controls\.ContentControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.contentcontrol 'System\.Windows\.Controls\.ContentControl') → [System\.Windows\.Controls\.UserControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.usercontrol 'System\.Windows\.Controls\.UserControl') → ListBoxControl

Implements [IControl](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IControl 'DiGi\.UI\.WPF\.Interfaces\.IControl'), [IWPFObject](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IWPFObject 'DiGi\.UI\.WPF\.Interfaces\.IWPFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [System\.Windows\.Markup\.IComponentConnector](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector 'System\.Windows\.Markup\.IComponentConnector')
### Constructors

<a name='DiGi.UI.WPF.Controls.ListBoxControl.ListBoxControl()'></a>

## ListBoxControl\(\) Constructor

Initializes a new instance of the [ListBoxControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl 'DiGi\.UI\.WPF\.Controls\.ListBoxControl') class\.

```csharp
public ListBoxControl();
```
### Properties

<a name='DiGi.UI.WPF.Controls.ListBoxControl.SelectionMode'></a>

## ListBoxControl\.SelectionMode Property

Gets or sets the [SelectionMode](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl.SelectionMode 'DiGi\.UI\.WPF\.Controls\.ListBoxControl\.SelectionMode') of the list box\.

```csharp
public System.Windows.Controls.SelectionMode SelectionMode { get; set; }
```

#### Property Value
[System\.Windows\.Controls\.SelectionMode](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.selectionmode 'System\.Windows\.Controls\.SelectionMode')
### Methods

<a name='DiGi.UI.WPF.Controls.ListBoxControl.ClearItems()'></a>

## ListBoxControl\.ClearItems\(\) Method

Clears all items from the list box\.

```csharp
public void ClearItems();
```

<a name='DiGi.UI.WPF.Controls.ListBoxControl.GetItems_T_(bool)'></a>

## ListBoxControl\.GetItems\<T\>\(bool\) Method

Retrieves a list of items of type [T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl.GetItems_T_(bool).T 'DiGi\.UI\.WPF\.Controls\.ListBoxControl\.GetItems\<T\>\(bool\)\.T') from the list box\.

```csharp
public System.Collections.Generic.List<T>? GetItems<T>(bool selected=true);
```
#### Type parameters

<a name='DiGi.UI.WPF.Controls.ListBoxControl.GetItems_T_(bool).T'></a>

`T`

The type of items to retrieve\.
#### Parameters

<a name='DiGi.UI.WPF.Controls.ListBoxControl.GetItems_T_(bool).selected'></a>

`selected` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, only selected items are returned; otherwise, all items are returned\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl.GetItems_T_(bool).T 'DiGi\.UI\.WPF\.Controls\.ListBoxControl\.GetItems\<T\>\(bool\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the retrieved items of type [T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl.GetItems_T_(bool).T 'DiGi\.UI\.WPF\.Controls\.ListBoxControl\.GetItems\<T\>\(bool\)\.T'), or `null` if no items match the criteria\.

<a name='DiGi.UI.WPF.Controls.ListBoxControl.InitializeComponent()'></a>

## ListBoxControl\.InitializeComponent\(\) Method

InitializeComponent

```csharp
public void InitializeComponent();
```

Implements [InitializeComponent\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector.initializecomponent 'System\.Windows\.Markup\.IComponentConnector\.InitializeComponent')

<a name='DiGi.UI.WPF.Controls.ListBoxControl.RefreshItems()'></a>

## ListBoxControl\.RefreshItems\(\) Method

Recomputes the text shown for every item by raising [ItemAdding](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl.ItemAdding 'DiGi\.UI\.WPF\.Controls\.ListBoxControl\.ItemAdding') again for each of them, in place\.

For text that depends on something learnt after [SetItems&lt;T&gt;\(IEnumerable&lt;T&gt;\)](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl.SetItems_T_(System.Collections.Generic.IEnumerable_T_) 'DiGi\.UI\.WPF\.Controls\.ListBoxControl\.SetItems\<T\>\(System\.Collections\.Generic\.IEnumerable\<T\>\)') - a figure fetched in the background, say. The items, their values, the selection and the scroll position are left as they are, and [SelectionChanged](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl.SelectionChanged 'DiGi\.UI\.WPF\.Controls\.ListBoxControl\.SelectionChanged') is not raised; calling [SetItems&lt;T&gt;\(IEnumerable&lt;T&gt;\)](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl.SetItems_T_(System.Collections.Generic.IEnumerable_T_) 'DiGi\.UI\.WPF\.Controls\.ListBoxControl\.SetItems\<T\>\(System\.Collections\.Generic\.IEnumerable\<T\>\)') again instead would clear the selection the user may already be making.

```csharp
public void RefreshItems();
```

<a name='DiGi.UI.WPF.Controls.ListBoxControl.SelectItems_T_(System.Collections.Generic.IEnumerable_T_)'></a>

## ListBoxControl\.SelectItems\<T\>\(IEnumerable\<T\>\) Method

Selects the items holding one of the given values, and deselects the rest\.

Values are compared with the default comparer of [T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl.SelectItems_T_(System.Collections.Generic.IEnumerable_T_).T 'DiGi\.UI\.WPF\.Controls\.ListBoxControl\.SelectItems\<T\>\(System\.Collections\.Generic\.IEnumerable\<T\>\)\.T'), which for a type that does not implement its own equality means the very instances that were passed to [SetItems&lt;T&gt;\(IEnumerable&lt;T&gt;\)](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl.SetItems_T_(System.Collections.Generic.IEnumerable_T_) 'DiGi\.UI\.WPF\.Controls\.ListBoxControl\.SetItems\<T\>\(System\.Collections\.Generic\.IEnumerable\<T\>\)'). Use [SelectItems&lt;T&gt;\(Func&lt;T,bool&gt;\)](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl.SelectItems_T_(System.Func_T,bool_) 'DiGi\.UI\.WPF\.Controls\.ListBoxControl\.SelectItems\<T\>\(System\.Func\<T,bool\>\)') to match on something the values carry instead, such as an identifier.

```csharp
public void SelectItems<T>(System.Collections.Generic.IEnumerable<T>? values);
```
#### Type parameters

<a name='DiGi.UI.WPF.Controls.ListBoxControl.SelectItems_T_(System.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of the values to select\.
#### Parameters

<a name='DiGi.UI.WPF.Controls.ListBoxControl.SelectItems_T_(System.Collections.Generic.IEnumerable_T_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl.SelectItems_T_(System.Collections.Generic.IEnumerable_T_).T 'DiGi\.UI\.WPF\.Controls\.ListBoxControl\.SelectItems\<T\>\(System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The values to be selected\. Nothing is selected or deselected when it is null\.

<a name='DiGi.UI.WPF.Controls.ListBoxControl.SelectItems_T_(System.Func_T,bool_)'></a>

## ListBoxControl\.SelectItems\<T\>\(Func\<T,bool\>\) Method

Selects the items whose value satisfies the given function, and deselects the rest\.

Matching is on the value the item was added with through [SetItems&lt;T&gt;\(IEnumerable&lt;T&gt;\)](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl.SetItems_T_(System.Collections.Generic.IEnumerable_T_) 'DiGi\.UI\.WPF\.Controls\.ListBoxControl\.SetItems\<T\>\(System\.Collections\.Generic\.IEnumerable\<T\>\)'), not on the text shown for it. An item whose value is not a [T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl.SelectItems_T_(System.Func_T,bool_).T 'DiGi\.UI\.WPF\.Controls\.ListBoxControl\.SelectItems\<T\>\(System\.Func\<T,bool\>\)\.T') is passed over.

In [System\.Windows\.Controls\.SelectionMode\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.selectionmode.single 'System\.Windows\.Controls\.SelectionMode\.Single') only the first match can be held, so the rest are ignored. [SelectionChanged](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl.SelectionChanged 'DiGi\.UI\.WPF\.Controls\.ListBoxControl\.SelectionChanged') is raised once for the whole selection rather than once per item.

```csharp
public void SelectItems<T>(System.Func<T,bool>? function);
```
#### Type parameters

<a name='DiGi.UI.WPF.Controls.ListBoxControl.SelectItems_T_(System.Func_T,bool_).T'></a>

`T`

The type of the values to test\.
#### Parameters

<a name='DiGi.UI.WPF.Controls.ListBoxControl.SelectItems_T_(System.Func_T,bool_).function'></a>

`function` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl.SelectItems_T_(System.Func_T,bool_).T 'DiGi\.UI\.WPF\.Controls\.ListBoxControl\.SelectItems\<T\>\(System\.Func\<T,bool\>\)\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The function deciding whether a value is selected\. Nothing is selected or deselected when it is null\.

<a name='DiGi.UI.WPF.Controls.ListBoxControl.SetItems_T_(System.Collections.Generic.IEnumerable_T_)'></a>

## ListBoxControl\.SetItems\<T\>\(IEnumerable\<T\>\) Method

Sets the items in the list box using the provided collection of values\.

```csharp
public void SetItems<T>(System.Collections.Generic.IEnumerable<T> values);
```
#### Type parameters

<a name='DiGi.UI.WPF.Controls.ListBoxControl.SetItems_T_(System.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of items to be added to the list box\.
#### Parameters

<a name='DiGi.UI.WPF.Controls.ListBoxControl.SetItems_T_(System.Collections.Generic.IEnumerable_T_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ListBoxControl.SetItems_T_(System.Collections.Generic.IEnumerable_T_).T 'DiGi\.UI\.WPF\.Controls\.ListBoxControl\.SetItems\<T\>\(System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An enumerable collection of values to populate the list box with\.
### Events

<a name='DiGi.UI.WPF.Controls.ListBoxControl.ItemAdding'></a>

## ListBoxControl\.ItemAdding Event

Occurs when an item is about to be added to the list box\.

```csharp
public event ListBoxItemAddingEventHandler? ItemAdding;
```

#### Event Type
[ListBoxItemAddingEventHandler\(object, ListBoxItemAddingEventArgs\)](DiGi.UI.WPF.Delegates.md#DiGi.UI.WPF.Delegates.ListBoxItemAddingEventHandler(object,DiGi.UI.WPF.Classes.ListBoxItemAddingEventArgs) 'DiGi\.UI\.WPF\.Delegates\.ListBoxItemAddingEventHandler\(object, DiGi\.UI\.WPF\.Classes\.ListBoxItemAddingEventArgs\)')

<a name='DiGi.UI.WPF.Controls.ListBoxControl.SelectionChanged'></a>

## ListBoxControl\.SelectionChanged Event

Occurs when the selection within the list box changes\.

```csharp
public event SelectionChangedEventHandler? SelectionChanged;
```

#### Event Type
[System\.Windows\.Controls\.SelectionChangedEventHandler](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.selectionchangedeventhandler 'System\.Windows\.Controls\.SelectionChangedEventHandler')

<a name='DiGi.UI.WPF.Controls.ProgressBarControl'></a>

## ProgressBarControl Class

Interaction logic for ProgressBarControl\.xaml

```csharp
public class ProgressBarControl : System.Windows.Controls.UserControl, DiGi.UI.WPF.Interfaces.IControl, DiGi.UI.WPF.Interfaces.IWPFObject, DiGi.Core.Interfaces.IObject, System.Windows.Markup.IComponentConnector
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Windows\.Threading\.DispatcherObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.threading.dispatcherobject 'System\.Windows\.Threading\.DispatcherObject') → [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') → [System\.Windows\.Media\.Visual](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.visual 'System\.Windows\.Media\.Visual') → [System\.Windows\.UIElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.uielement 'System\.Windows\.UIElement') → [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement') → [System\.Windows\.Controls\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.control 'System\.Windows\.Controls\.Control') → [System\.Windows\.Controls\.ContentControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.contentcontrol 'System\.Windows\.Controls\.ContentControl') → [System\.Windows\.Controls\.UserControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.usercontrol 'System\.Windows\.Controls\.UserControl') → ProgressBarControl

Implements [IControl](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IControl 'DiGi\.UI\.WPF\.Interfaces\.IControl'), [IWPFObject](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IWPFObject 'DiGi\.UI\.WPF\.Interfaces\.IWPFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [System\.Windows\.Markup\.IComponentConnector](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector 'System\.Windows\.Markup\.IComponentConnector')
### Constructors

<a name='DiGi.UI.WPF.Controls.ProgressBarControl.ProgressBarControl()'></a>

## ProgressBarControl\(\) Constructor

Initializes a new instance of the [ProgressBarControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.ProgressBarControl 'DiGi\.UI\.WPF\.Controls\.ProgressBarControl') class\.

```csharp
public ProgressBarControl();
```
### Properties

<a name='DiGi.UI.WPF.Controls.ProgressBarControl.IsIndeterminate'></a>

## ProgressBarControl\.IsIndeterminate Property

Gets or sets a value indicating whether the progress bar is in an indeterminate state\.

```csharp
public bool IsIndeterminate { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.UI.WPF.Controls.ProgressBarControl.Maximum'></a>

## ProgressBarControl\.Maximum Property

Gets or sets the maximum value for progress reporting\.

```csharp
public double Maximum { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.UI.WPF.Controls.ProgressBarControl.Value'></a>

## ProgressBarControl\.Value Property

Gets or sets the current progress value\.

```csharp
public double Value { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.UI.WPF.Controls.ProgressBarControl.InitializeComponent()'></a>

## ProgressBarControl\.InitializeComponent\(\) Method

InitializeComponent

```csharp
public void InitializeComponent();
```

Implements [InitializeComponent\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector.initializecomponent 'System\.Windows\.Markup\.IComponentConnector\.InitializeComponent')

<a name='DiGi.UI.WPF.Controls.ProgressBarControl.Update(double,string)'></a>

## ProgressBarControl\.Update\(double, string\) Method

Updates the progress bar with a specific value and optional descriptive text\.

```csharp
public void Update(double value, string? text=null);
```
#### Parameters

<a name='DiGi.UI.WPF.Controls.ProgressBarControl.Update(double,string).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The current progress value to be displayed\.

<a name='DiGi.UI.WPF.Controls.ProgressBarControl.Update(double,string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Optional text to display as a label for the progress bar\.

<a name='DiGi.UI.WPF.Controls.TextBoxControl'></a>

## TextBoxControl Class

Interaction logic for TextBoxControl\.xaml

```csharp
public class TextBoxControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Windows\.Threading\.DispatcherObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.threading.dispatcherobject 'System\.Windows\.Threading\.DispatcherObject') → [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') → [System\.Windows\.Media\.Visual](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.visual 'System\.Windows\.Media\.Visual') → [System\.Windows\.UIElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.uielement 'System\.Windows\.UIElement') → [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement') → [System\.Windows\.Controls\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.control 'System\.Windows\.Controls\.Control') → [System\.Windows\.Controls\.ContentControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.contentcontrol 'System\.Windows\.Controls\.ContentControl') → [System\.Windows\.Controls\.UserControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.usercontrol 'System\.Windows\.Controls\.UserControl') → TextBoxControl

Implements [System\.Windows\.Markup\.IComponentConnector](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector 'System\.Windows\.Markup\.IComponentConnector')
### Constructors

<a name='DiGi.UI.WPF.Controls.TextBoxControl.TextBoxControl()'></a>

## TextBoxControl\(\) Constructor

Initializes a new instance of the [TextBoxControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.TextBoxControl 'DiGi\.UI\.WPF\.Controls\.TextBoxControl') class\.

```csharp
public TextBoxControl();
```
### Properties

<a name='DiGi.UI.WPF.Controls.TextBoxControl.Text'></a>

## TextBoxControl\.Text Property

Gets or sets the text content displayed in the control's label\.

```csharp
public string? Text { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.UI.WPF.Controls.TextBoxControl.Validation'></a>

## TextBoxControl\.Validation Property

Gets or sets the validation function used to determine if a string input is valid\.

```csharp
public System.Func<string,bool>? Validation { get; set; }
```

#### Property Value
[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

<a name='DiGi.UI.WPF.Controls.TextBoxControl.Value'></a>

## TextBoxControl\.Value Property

Gets or sets the text value of the internal text box\.

```csharp
public string? Value { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.UI.WPF.Controls.TextBoxControl.GetValue_T_()'></a>

## TextBoxControl\.GetValue\<T\>\(\) Method

Retrieves the current value of the control converted to the specified type\.

```csharp
public T? GetValue<T>();
```
#### Type parameters

<a name='DiGi.UI.WPF.Controls.TextBoxControl.GetValue_T_().T'></a>

`T`

The target type for conversion\.

#### Returns
[T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.TextBoxControl.GetValue_T_().T 'DiGi\.UI\.WPF\.Controls\.TextBoxControl\.GetValue\<T\>\(\)\.T')  
The converted value if successful; otherwise, the default value of type [T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.TextBoxControl.GetValue_T_().T 'DiGi\.UI\.WPF\.Controls\.TextBoxControl\.GetValue\<T\>\(\)\.T')\.

<a name='DiGi.UI.WPF.Controls.TextBoxControl.GetValue_T_(T)'></a>

## TextBoxControl\.GetValue\<T\>\(T\) Method

Retrieves the current value of the control converted to the specified type, or returns a provided default value if conversion fails\.

```csharp
public T? GetValue<T>(T? defaultValue);
```
#### Type parameters

<a name='DiGi.UI.WPF.Controls.TextBoxControl.GetValue_T_(T).T'></a>

`T`

The target type for conversion\.
#### Parameters

<a name='DiGi.UI.WPF.Controls.TextBoxControl.GetValue_T_(T).defaultValue'></a>

`defaultValue` [T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.TextBoxControl.GetValue_T_(T).T 'DiGi\.UI\.WPF\.Controls\.TextBoxControl\.GetValue\<T\>\(T\)\.T')

The value to return if the conversion cannot be performed\.

#### Returns
[T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.TextBoxControl.GetValue_T_(T).T 'DiGi\.UI\.WPF\.Controls\.TextBoxControl\.GetValue\<T\>\(T\)\.T')  
The converted value if successful; otherwise, the specified [defaultValue](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.TextBoxControl.GetValue_T_(T).defaultValue 'DiGi\.UI\.WPF\.Controls\.TextBoxControl\.GetValue\<T\>\(T\)\.defaultValue')\.

<a name='DiGi.UI.WPF.Controls.TextBoxControl.InitializeComponent()'></a>

## TextBoxControl\.InitializeComponent\(\) Method

InitializeComponent

```csharp
public void InitializeComponent();
```

Implements [InitializeComponent\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector.initializecomponent 'System\.Windows\.Markup\.IComponentConnector\.InitializeComponent')

<a name='DiGi.UI.WPF.Controls.TextBoxControl.TryGetValue_T_(T)'></a>

## TextBoxControl\.TryGetValue\<T\>\(T\) Method

Attempts to convert the current value of the control to the specified type\.

```csharp
public bool TryGetValue<T>(out T? value);
```
#### Type parameters

<a name='DiGi.UI.WPF.Controls.TextBoxControl.TryGetValue_T_(T).T'></a>

`T`

The target type for conversion\.
#### Parameters

<a name='DiGi.UI.WPF.Controls.TextBoxControl.TryGetValue_T_(T).value'></a>

`value` [T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.TextBoxControl.TryGetValue_T_(T).T 'DiGi\.UI\.WPF\.Controls\.TextBoxControl\.TryGetValue\<T\>\(T\)\.T')

When this method returns, contains the converted value if successful; otherwise, the default value of type [T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.TextBoxControl.TryGetValue_T_(T).T 'DiGi\.UI\.WPF\.Controls\.TextBoxControl\.TryGetValue\<T\>\(T\)\.T')\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the value was successfully converted; otherwise, `false`\.

<a name='DiGi.UI.WPF.Controls.TreeViewControl'></a>

## TreeViewControl Class

Interaction logic for TreeViewControl\.xaml

```csharp
public class TreeViewControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Windows\.Threading\.DispatcherObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.threading.dispatcherobject 'System\.Windows\.Threading\.DispatcherObject') → [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') → [System\.Windows\.Media\.Visual](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.visual 'System\.Windows\.Media\.Visual') → [System\.Windows\.UIElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.uielement 'System\.Windows\.UIElement') → [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement') → [System\.Windows\.Controls\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.control 'System\.Windows\.Controls\.Control') → [System\.Windows\.Controls\.ContentControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.contentcontrol 'System\.Windows\.Controls\.ContentControl') → [System\.Windows\.Controls\.UserControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.usercontrol 'System\.Windows\.Controls\.UserControl') → TreeViewControl

Implements [System\.Windows\.Markup\.IComponentConnector](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector 'System\.Windows\.Markup\.IComponentConnector')
### Constructors

<a name='DiGi.UI.WPF.Controls.TreeViewControl.TreeViewControl()'></a>

## TreeViewControl\(\) Constructor

Initializes a new instance of the [TreeViewControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.TreeViewControl 'DiGi\.UI\.WPF\.Controls\.TreeViewControl') class\.

```csharp
public TreeViewControl();
```
### Methods

<a name='DiGi.UI.WPF.Controls.TreeViewControl.ClearItems()'></a>

## TreeViewControl\.ClearItems\(\) Method

Clears all items from the main TreeView control\.

```csharp
public void ClearItems();
```

<a name='DiGi.UI.WPF.Controls.TreeViewControl.CollapseAll()'></a>

## TreeViewControl\.CollapseAll\(\) Method

Collapses all expandable nodes within the tree view\.

```csharp
public void CollapseAll();
```

<a name='DiGi.UI.WPF.Controls.TreeViewControl.ExpandaAll()'></a>

## TreeViewControl\.ExpandaAll\(\) Method

Expands all expandable nodes within the tree view\.

```csharp
public void ExpandaAll();
```

<a name='DiGi.UI.WPF.Controls.TreeViewControl.GetItems_T_(bool)'></a>

## TreeViewControl\.GetItems\<T\>\(bool\) Method

Retrieves a list of items of the specified type from the tree view\.

```csharp
public System.Collections.Generic.List<T>? GetItems<T>(bool selected=true);
```
#### Type parameters

<a name='DiGi.UI.WPF.Controls.TreeViewControl.GetItems_T_(bool).T'></a>

`T`

The type of items to retrieve\.
#### Parameters

<a name='DiGi.UI.WPF.Controls.TreeViewControl.GetItems_T_(bool).selected'></a>

`selected` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, only retrieves items that are currently selected; otherwise, retrieves all items of type [T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.TreeViewControl.GetItems_T_(bool).T 'DiGi\.UI\.WPF\.Controls\.TreeViewControl\.GetItems\<T\>\(bool\)\.T')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.TreeViewControl.GetItems_T_(bool).T 'DiGi\.UI\.WPF\.Controls\.TreeViewControl\.GetItems\<T\>\(bool\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of items of type [T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.TreeViewControl.GetItems_T_(bool).T 'DiGi\.UI\.WPF\.Controls\.TreeViewControl\.GetItems\<T\>\(bool\)\.T'), or null if no matching items are found\.

<a name='DiGi.UI.WPF.Controls.TreeViewControl.InitializeComponent()'></a>

## TreeViewControl\.InitializeComponent\(\) Method

InitializeComponent

```csharp
public void InitializeComponent();
```

Implements [InitializeComponent\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector.initializecomponent 'System\.Windows\.Markup\.IComponentConnector\.InitializeComponent')

<a name='DiGi.UI.WPF.Controls.TreeViewControl.SetItems_T_(System.Collections.Generic.IEnumerable_T_)'></a>

## TreeViewControl\.SetItems\<T\>\(IEnumerable\<T\>\) Method

Populates the tree view with a collection of values, organizing them by path and allowing custom item creation via the [ItemAdding](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.TreeViewControl.ItemAdding 'DiGi\.UI\.WPF\.Controls\.TreeViewControl\.ItemAdding') event\.

```csharp
public void SetItems<T>(System.Collections.Generic.IEnumerable<T> values);
```
#### Type parameters

<a name='DiGi.UI.WPF.Controls.TreeViewControl.SetItems_T_(System.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of values to be added to the tree view\.
#### Parameters

<a name='DiGi.UI.WPF.Controls.TreeViewControl.SetItems_T_(System.Collections.Generic.IEnumerable_T_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.TreeViewControl.SetItems_T_(System.Collections.Generic.IEnumerable_T_).T 'DiGi\.UI\.WPF\.Controls\.TreeViewControl\.SetItems\<T\>\(System\.Collections\.Generic\.IEnumerable\<T\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of values to set in the tree view\.
### Events

<a name='DiGi.UI.WPF.Controls.TreeViewControl.ItemAdding'></a>

## TreeViewControl\.ItemAdding Event

Occurs when an item is being added to the tree view, allowing for modification of the item's path or name\.

```csharp
public event TreeViewItemAddingEventHandler? ItemAdding;
```

#### Event Type
[TreeViewItemAddingEventHandler\(object, TreeViewItemAddingEventArgs\)](DiGi.UI.WPF.Delegates.md#DiGi.UI.WPF.Delegates.TreeViewItemAddingEventHandler(object,DiGi.UI.WPF.Classes.TreeViewItemAddingEventArgs) 'DiGi\.UI\.WPF\.Delegates\.TreeViewItemAddingEventHandler\(object, DiGi\.UI\.WPF\.Classes\.TreeViewItemAddingEventArgs\)')

<a name='DiGi.UI.WPF.Controls.TreeViewControl.SelectedItemChanged'></a>

## TreeViewControl\.SelectedItemChanged Event

Occurs when the selected item in the tree view changes\.

```csharp
public event RoutedPropertyChangedEventHandler<object>? SelectedItemChanged;
```

#### Event Type
[System\.Windows\.RoutedPropertyChangedEventHandler&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.windows.routedpropertychangedeventhandler-1 'System\.Windows\.RoutedPropertyChangedEventHandler\`1')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.windows.routedpropertychangedeventhandler-1 'System\.Windows\.RoutedPropertyChangedEventHandler\`1')

<a name='DiGi.UI.WPF.Controls.VisualBackgroundTasksControl'></a>

## VisualBackgroundTasksControl Class

VisualBackgroundTasksControl

```csharp
public class VisualBackgroundTasksControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [System\.Windows\.Threading\.DispatcherObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.threading.dispatcherobject 'System\.Windows\.Threading\.DispatcherObject') → [System\.Windows\.DependencyObject](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyobject 'System\.Windows\.DependencyObject') → [System\.Windows\.Media\.Visual](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.visual 'System\.Windows\.Media\.Visual') → [System\.Windows\.UIElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.uielement 'System\.Windows\.UIElement') → [System\.Windows\.FrameworkElement](https://learn.microsoft.com/en-us/dotnet/api/system.windows.frameworkelement 'System\.Windows\.FrameworkElement') → [System\.Windows\.Controls\.Control](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.control 'System\.Windows\.Controls\.Control') → [System\.Windows\.Controls\.ContentControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.contentcontrol 'System\.Windows\.Controls\.ContentControl') → [System\.Windows\.Controls\.UserControl](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.usercontrol 'System\.Windows\.Controls\.UserControl') → VisualBackgroundTasksControl

Implements [System\.Windows\.Markup\.IComponentConnector](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector 'System\.Windows\.Markup\.IComponentConnector')
### Constructors

<a name='DiGi.UI.WPF.Controls.VisualBackgroundTasksControl.VisualBackgroundTasksControl()'></a>

## VisualBackgroundTasksControl\(\) Constructor

Initializes a new instance of the [VisualBackgroundTasksControl](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.VisualBackgroundTasksControl 'DiGi\.UI\.WPF\.Controls\.VisualBackgroundTasksControl') class\.

```csharp
public VisualBackgroundTasksControl();
```
### Fields

<a name='DiGi.UI.WPF.Controls.VisualBackgroundTasksControl.VisualBackgroundTasksProperty'></a>

## VisualBackgroundTasksControl\.VisualBackgroundTasksProperty Field

Identifies the [VisualBackgroundTasks](DiGi.UI.WPF.Controls.md#DiGi.UI.WPF.Controls.VisualBackgroundTasksControl.VisualBackgroundTasks 'DiGi\.UI\.WPF\.Controls\.VisualBackgroundTasksControl\.VisualBackgroundTasks') dependency property\.

```csharp
public static readonly DependencyProperty VisualBackgroundTasksProperty;
```

#### Field Value
[System\.Windows\.DependencyProperty](https://learn.microsoft.com/en-us/dotnet/api/system.windows.dependencyproperty 'System\.Windows\.DependencyProperty')
### Properties

<a name='DiGi.UI.WPF.Controls.VisualBackgroundTasksControl.VisualBackgroundTasks'></a>

## VisualBackgroundTasksControl\.VisualBackgroundTasks Property

Gets or sets the collection of visual background tasks to be displayed and managed by the control\.

```csharp
public System.Collections.ObjectModel.ObservableCollection<DiGi.UI.WPF.Interfaces.IVisualBackgroundTask>? VisualBackgroundTasks { get; set; }
```

#### Property Value
[System\.Collections\.ObjectModel\.ObservableCollection&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1 'System\.Collections\.ObjectModel\.ObservableCollection\`1')[IVisualBackgroundTask](DiGi.UI.WPF.Interfaces.md#DiGi.UI.WPF.Interfaces.IVisualBackgroundTask 'DiGi\.UI\.WPF\.Interfaces\.IVisualBackgroundTask')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1 'System\.Collections\.ObjectModel\.ObservableCollection\`1')
### Methods

<a name='DiGi.UI.WPF.Controls.VisualBackgroundTasksControl.InitializeComponent()'></a>

## VisualBackgroundTasksControl\.InitializeComponent\(\) Method

InitializeComponent

```csharp
public void InitializeComponent();
```

Implements [InitializeComponent\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.windows.markup.icomponentconnector.initializecomponent 'System\.Windows\.Markup\.IComponentConnector\.InitializeComponent')