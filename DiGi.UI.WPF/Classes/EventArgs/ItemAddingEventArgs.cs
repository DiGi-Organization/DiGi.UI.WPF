namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Provides data for events that occur when an item is being added.
    /// </summary>
    public abstract class ItemAddingEventArgs : EventArgs
    {
        protected bool handled;

        private string? name;

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemAddingEventArgs"/> class.
        /// </summary>
        /// <param name="item">The item being added.</param>
        public ItemAddingEventArgs(object? item)
        {
            Item = item;
        }

        /// <summary>
        /// Gets a value indicating whether the event has been handled.
        /// </summary>
        public bool Handled
        {
            get
            {
                return handled;
            }
        }

        /// <summary>
        /// Gets the item being added.
        /// </summary>
        public object? Item { get; }

        /// <summary>
        /// Gets or sets the name of the item being added. Setting this value marks the event as handled.
        /// </summary>
        public string? Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                handled = true;
            }
        }
    }
}