using DiGi.UI.WPF.Delegates;
using DiGi.UI.WPF.Interfaces;
using System.Windows;

namespace DiGi.UI.WPF.Windows
{
    /// <summary>
    /// Interaction logic for CancellableProgressBarWindow.xaml
    /// </summary>
    public partial class CancellableProgressBarWindow : Window, IWindow
    {
        private bool cancellationPending;

        /// <summary>
        /// Initializes a new instance of the <see cref="CancellableProgressBarWindow"/> class.
        /// </summary>
        public CancellableProgressBarWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Occurs when the user requests to cancel the current operation.
        /// </summary>
        public event CancellingEventHandler? Cancelling;

        /// <summary>
        /// Gets a value indicating whether a cancellation is pending.
        /// </summary>
        public bool CancellationPending
        {
            get
            {
                return cancellationPending;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the progress bar is in an indeterminate state.
        /// </summary>
        public bool IsIndeterminate
        {
            get
            {
                return ProgressBar_Main.IsIndeterminate;
            }

            set
            {
                ProgressBar_Main.IsIndeterminate = value;
                StackPanel_Main.Visibility = value ? Visibility.Hidden : Visibility.Visible;
            }
        }

        /// <summary>
        /// Gets or sets the maximum value for progress reporting.
        /// </summary>
        public double Maximum
        {
            get
            {
                return ProgressBar_Main.Maximum;
            }

            set
            {
                ProgressBar_Main.Maximum = value;
            }
        }

        /// <summary>
        /// Updates the progress bar value and the associated status text.
        /// </summary>
        /// <param name="value">The current progress value.</param>
        /// <param name="text">The optional status text to display.</param>
        public void Update(double value, string? text = null)
        {
            ProgressBar_Main.Value = value;
            Label_Main.Content = text;
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            cancellationPending = true;

            Cancelling?.Invoke(sender, new Classes.CancellingEventArgs());
        }
    }
}