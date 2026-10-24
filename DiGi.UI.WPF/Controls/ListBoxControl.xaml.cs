using DiGi.UI.WPF.Classes;
using DiGi.UI.WPF.Delegates;
using DiGi.UI.WPF.Interfaces;
using System.Windows;
using System.Windows.Controls;

namespace DiGi.UI.WPF.Controls
{
    /// <summary>
    /// Interaction logic for ListBoxControl.xaml
    /// </summary>
    public partial class ListBoxControl : UserControl, IControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListBoxControl"/> class.
        /// </summary>
        public ListBoxControl()
        {
            InitializeComponent();
            SetEnabled();
        }

        /// <summary>
        /// Occurs when an item is about to be added to the list box.
        /// </summary>
        public event ListBoxItemAddingEventHandler? ItemAdding;

        /// <summary>
        /// Occurs when the selection within the list box changes.
        /// </summary>
        public event SelectionChangedEventHandler? SelectionChanged;

        /// <summary>
        /// Gets or sets the <see cref="SelectionMode"/> of the list box.
        /// </summary>
        public SelectionMode SelectionMode
        {
            get
            {
                return ListBox_Main.SelectionMode;
            }

            set
            {
                ListBox_Main.SelectionMode = value;
                SetEnabled();
            }
        }

        /// <summary>
        /// Clears all items from the list box.
        /// </summary>
        public void ClearItems()
        {
            ListBox_Main.Items.Clear();
        }

        /// <summary>
        /// Retrieves a list of items of type <typeparamref name="T"/> from the list box.
        /// </summary>
        /// <typeparam name="T">The type of items to retrieve.</typeparam>
        /// <param name="selected">If set to <c>true</c>, only selected items are returned; otherwise, all items are returned.</param>
        /// <returns>A list containing the retrieved items of type <typeparamref name="T"/>, or <c>null</c> if no items match the criteria.</returns>
        public List<T>? GetItems<T>(bool selected = true)
        {
            return Query.TagItems<T, ListBoxItem>(ListBox_Main.Items, true, selected, x => x != null && x.IsSelected);
        }

        /// <summary>
        /// Selects the items whose value satisfies the given function, and deselects the rest.
        /// <para>Matching is on the value the item was added with through <see cref="SetItems{T}(IEnumerable{T})"/>, not on the text shown for it. An item whose value is not a <typeparamref name="T"/> is passed over.</para>
        /// <para>In <see cref="System.Windows.Controls.SelectionMode.Single"/> only the first match can be held, so the rest are ignored. <see cref="SelectionChanged"/> is raised once for the whole selection rather than once per item.</para>
        /// </summary>
        /// <typeparam name="T">The type of the values to test.</typeparam>
        /// <param name="function">The function deciding whether a value is selected. Nothing is selected or deselected when it is null.</param>
        public void SelectItems<T>(Func<T, bool>? function)
        {
            if (function == null)
            {
                return;
            }

            List<ListBoxItem> listBoxItems = [];
            foreach (object @object in ListBox_Main.Items)
            {
                if (@object is ListBoxItem listBoxItem && listBoxItem.Tag is T value && function.Invoke(value))
                {
                    listBoxItems.Add(listBoxItem);
                }
            }

            if (SelectionMode == SelectionMode.Single)
            {
                ListBox_Main.SelectedItem = listBoxItems.Count == 0 ? null : listBoxItems[0];
                return;
            }

            // Cleared with the handler still attached, so that a selection that ends up empty is still reported.
            SelectNone();

            if (listBoxItems.Count == 0)
            {
                return;
            }

            // The last item is added on its own, with the handler back in place, so the whole selection raises
            // one event instead of one per item - the same way SelectAll does it.
            ListBox_Main.SelectionChanged -= ListBox_Main_SelectionChanged;
            for (int i = 0; i < listBoxItems.Count - 1; i++)
            {
                ListBox_Main.SelectedItems.Add(listBoxItems[i]);
            }
            ListBox_Main.SelectionChanged += ListBox_Main_SelectionChanged;

            ListBox_Main.SelectedItems.Add(listBoxItems[^1]);
        }

        /// <summary>
        /// Selects the items holding one of the given values, and deselects the rest.
        /// <para>Values are compared with the default comparer of <typeparamref name="T"/>, which for a type that does not implement its own equality means the very instances that were passed to <see cref="SetItems{T}(IEnumerable{T})"/>. Use <see cref="SelectItems{T}(Func{T, bool})"/> to match on something the values carry instead, such as an identifier.</para>
        /// </summary>
        /// <typeparam name="T">The type of the values to select.</typeparam>
        /// <param name="values">The values to be selected. Nothing is selected or deselected when it is null.</param>
        public void SelectItems<T>(IEnumerable<T>? values)
        {
            if (values == null)
            {
                return;
            }

            HashSet<T> values_HashSet = [.. values];

            SelectItems<T>(values_HashSet.Contains);
        }

        /// <summary>
        /// Sets the items in the list box using the provided collection of values.
        /// </summary>
        /// <typeparam name="T">The type of items to be added to the list box.</typeparam>
        /// <param name="values">An enumerable collection of values to populate the list box with.</param>
        public void SetItems<T>(IEnumerable<T> values)
        {
            ListBox_Main.Items.Clear();

            if (values == null)
            {
                return;
            }

            foreach (T value in values)
            {
                ListBox_Main.Items.Add(new ListBoxItem() { Content = Text(value), Tag = value });
            }
        }

        /// <summary>
        /// Recomputes the text shown for every item by raising <see cref="ItemAdding"/> again for each of them, in place.
        /// <para>For text that depends on something learnt after <see cref="SetItems{T}(IEnumerable{T})"/> - a figure fetched in the background, say. The items, their values, the selection and the scroll position are left as they are, and <see cref="SelectionChanged"/> is not raised; calling <see cref="SetItems{T}(IEnumerable{T})"/> again instead would clear the selection the user may already be making.</para>
        /// </summary>
        public void RefreshItems()
        {
            foreach (object @object in ListBox_Main.Items)
            {
                if (@object is ListBoxItem listBoxItem)
                {
                    listBoxItem.Content = Text(listBoxItem.Tag);
                }
            }
        }

        private void Button_SelectAll_Click(object sender, RoutedEventArgs e)
        {
            SelectAll();
        }

        private void Button_SelectNone_Click(object sender, RoutedEventArgs e)
        {
            SelectNone();
        }

        private void ListBox_Main_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectionChanged?.Invoke(this, e);
        }

        private void SelectAll()
        {
            ListBox_Main.SelectionChanged -= ListBox_Main_SelectionChanged;
            for (int i = 0; i < ListBox_Main.Items.Count - 1; i++)
            {
                ListBox_Main.SelectedItems.Add(ListBox_Main.Items[i]);
            }
            ListBox_Main.SelectionChanged += ListBox_Main_SelectionChanged;

            if (ListBox_Main.Items.Count != 0)
            {
                ListBox_Main.SelectedItems.Add(ListBox_Main.Items[^1]);
            }
        }

        private void SelectNone()
        {
            if (SelectionMode == SelectionMode.Single)
            {
                // Single selection mode – use SelectedItem
                ListBox_Main.SelectedItem = null;
            }
            else
            {
                // Multiple or extended selection mode – use SelectedItems
                ListBox_Main.SelectedItems.Clear();
            }
        }

        private string? Text(object? value)
        {
            ListBoxItemAddingEventArgs itemAddingEventArgs = new(value);
            ItemAdding?.Invoke(this, itemAddingEventArgs);

            return itemAddingEventArgs.Handled ? itemAddingEventArgs.Name : value?.ToString();
        }

        private void SetEnabled()
        {
            Button_SelectAll.IsEnabled = ListBox_Main.SelectionMode != SelectionMode.Single;
        }
    }
}