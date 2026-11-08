using DiGi.Core.Interfaces;
using System.ComponentModel;

namespace DiGi.UI.WPF.Interfaces
{
    /// <summary>
    /// Defines a contract for a background task that provides visual updates or interactions within the WPF user interface.
    /// </summary>
    public interface IVisualBackgroundTask : IWPFObject, INotifyPropertyChanged, INamedObject, IDescribableObject
    {
        /// <summary>
        /// Gets the name of the type associated with this visual background task.
        /// </summary>
        string? TypeName { get; }

        /// <summary>
        /// Gets a value indicating whether the underlying background task is currently running.
        /// <para>Raised through <see cref="INotifyPropertyChanged.PropertyChanged"/> when the task starts and after it stops - finished, failed or cancelled alike.</para>
        /// </summary>
        bool IsRunning { get; }

        /// <summary>
        /// Gets the short status of the task (e.g. running, completed, failed), with the latest reported progress appended while a reportable task runs.
        /// </summary>
        string Status { get; }

        /// <summary>
        /// Gets the execution time of the current or last run, formatted for display.
        /// </summary>
        string ExecutionTimeSpanText { get; }

        /// <summary>
        /// Starts the execution of the visual background task.
        /// </summary>
        void Start();
    }
}