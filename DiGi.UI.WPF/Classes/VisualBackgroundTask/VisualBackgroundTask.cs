using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.UI.WPF.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Provides a visual wrapper for a background task, enabling integration with WPF UI components and providing properties for monitoring execution status and time.
    /// </summary>
    /// <typeparam name="TBackgroundTask">The type of the background task, which must implement <see cref="IBackgroundTask"/>.</typeparam>
    public class VisualBackgroundTask<TBackgroundTask> : IVisualBackgroundTask where TBackgroundTask : IBackgroundTask
    {
        protected readonly TBackgroundTask backgroundTask;
        private readonly string description;
        private readonly string name;
        
        private readonly System.Timers.Timer timer = new (1000);

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualBackgroundTask{TBackgroundTask}"/> class.
        /// </summary>
        /// <param name="backgroundTask">The background task instance to be wrapped.</param>
        /// <param name="name">The display name of the background task.</param>
        /// <param name="description">A detailed description of the background task.</param>
        public VisualBackgroundTask(TBackgroundTask backgroundTask, string name, string description)
        {
            this.backgroundTask = backgroundTask;
            this.name = name;
            this.description = description;

            // Initialize timer for live duration updates
            timer.Elapsed += (s, e) => OnPropertyChanged(nameof(ExecutionTimeSpanText));

            backgroundTask.Started += (s, e) =>
            {
                timer.Start();
                RefreshAll();
            };

            backgroundTask.Stopped += (s, e) =>
            {
                timer.Stop();
                RefreshAll();
            };

            backgroundTask.Starting += (s, e) => RefreshAll();
            backgroundTask.Stopping += (s, e) => RefreshAll();
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Gets a value indicating whether the background task can currently be toggled (started or stopped).
        /// </summary>
        public bool CanToggle
        {
            get
            {
                // If the task is not running, we can always start it.
                if (!backgroundTask.IsRunning)
                {
                    return true;
                }

                // If the task is running, we can only "Stop" it if it supports cancellation.
                return backgroundTask is ICancelableBackgroundTask;
            }
        }

        /// <summary>
        /// Gets the description of the background task.
        /// </summary>
        public string? Description
        {
            get
            {
                return description;
            }
        }

        /// <summary>
        /// Gets the type and message of the exception that caused the task to fail, with the message of every inner exception appended, or null if no exception occurred.
        /// <para>The message alone leaves a reader guessing: "Object reference not set to an instance of an object." names neither what threw nor which call it came from. The type is what makes it actionable at a glance.</para>
        /// <para>This is what the task list shows on hover, so it deliberately stops short of the stack trace. <see cref="StatusText"/> carries the full detail for copying.</para>
        /// </summary>
        public string? ExceptionText
        {
            get
            {
                System.Exception? exception = backgroundTask.Exception;
                if (exception is null)
                {
                    return null;
                }

                System.Text.StringBuilder stringBuilder = new();
                stringBuilder.Append(exception.GetType().Name).Append(": ").Append(exception.Message);

                System.Exception? exception_Inner = exception.InnerException;
                while (exception_Inner is not null)
                {
                    stringBuilder.AppendLine().Append("---> ").Append(exception_Inner.GetType().Name).Append(": ").Append(exception_Inner.Message);
                    exception_Inner = exception_Inner.InnerException;
                }

                return stringBuilder.ToString();
            }
        }

        /// <summary>
        /// Gets the text the status cell contributes to the clipboard: the exception in full when the task failed, the status otherwise.
        /// <para><see cref="System.Exception.ToString"/> carries the type, the message, the stack trace and every inner exception in one string, which is what makes a failure reportable by selecting the row and pressing Ctrl+C rather than reading a tooltip and retyping it.</para>
        /// <para>The fallback to the status is what keeps a successful row worth copying - without it the status field would come out empty.</para>
        /// </summary>
        public string? StatusText
        {
            get
            {
                return backgroundTask.Exception?.ToString() ?? Status.ToString();
            }
        }

        /// <summary>
        /// Gets the total execution time of the task formatted as a string in "HH:mm:ss" format.
        /// </summary>
        public string ExecutionTimeSpanText
        {
            get
            {
                TimeSpan duration = backgroundTask.ExecutionTimeSpan;

                // Format: HH:mm:ss
                return string.Format("{0:D2}:{1:D2}:{2:D2}", (int)duration.TotalHours, duration.Minutes, duration.Seconds);
            }
        }

        /// <summary>
        /// Gets the text the Task Name cell shows on hover: the name, followed by the description on a second line.
        /// <para>The name is repeated here rather than only the description, because the cell that shows it is the one column sized from what the fixed columns leave over, so it is the one that can still trim its text. A trimmed name is then unreadable and the description alone does not carry it.</para>
        /// <para>Returns null, not an empty string, when there is nothing to show - a null tooltip is not displayed at all, while an empty one hovers as an empty box.</para>
        /// </summary>
        public string? ToolTipText
        {
            get
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    return string.IsNullOrWhiteSpace(description) ? null : description;
                }

                return string.IsNullOrWhiteSpace(description) ? name : $"{name}{System.Environment.NewLine}{description}";
            }
        }

        /// <summary>
        /// Gets the display name of the background task.
        /// </summary>
        public string? Name
        {
            get
            {
                return name;
            }
        }
        
        /// <summary>
        /// Gets the current status description of the background task.
        /// </summary>
        public virtual string Status
        {
            get
            {
                return (backgroundTask is ICancelableBackgroundTask cancelableBackgroundTask ? cancelableBackgroundTask.CancelableBackgroundTaskStatus.Description() : backgroundTask.BackgroundTaskStatus.Description()) ?? "???";
            }
        }

        /// <summary>
        /// Gets the command used to asynchronously toggle the execution state of the background task.
        /// </summary>
        public ICommand ToggleCommandAsync => new ToggleCommandAsync(async _ =>
        {
            if (backgroundTask.IsRunning)
            {
                if (backgroundTask is ICancelableBackgroundTask cancelableBackgroundTask)
                {
                    await cancelableBackgroundTask.StopAsync();
                }
            }
            else
            {
                backgroundTask.Start();
            }

            RefreshAll();
        });

        /// <summary>
        /// Starts the execution of the background task if it is not already running.
        /// </summary>
        public void Start()
        {
            if (backgroundTask.IsRunning)
            {
                return;
            }

            backgroundTask.Start();
            RefreshAll();
        }

        /// <summary>
        /// Gets a value indicating whether the underlying background task is currently running.
        /// </summary>
        public bool IsRunning => backgroundTask.IsRunning;

        /// <summary>
        /// Gets the text to be displayed on the toggle button, indicating whether the next action is to "Start" or "Stop".
        /// </summary>
        public string ToggleText
        {
            get
            {
                return backgroundTask.IsRunning ? "Stop" : "Start";
            }
        }
        
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void RefreshAll()
        {
            Action action = new(() =>
            {
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Description));
                OnPropertyChanged(nameof(ToggleText));
                OnPropertyChanged(nameof(ExecutionTimeSpanText));
                OnPropertyChanged(nameof(Status));
                OnPropertyChanged(nameof(ExceptionText));
                OnPropertyChanged(nameof(StatusText));
                OnPropertyChanged(nameof(CanToggle));
                OnPropertyChanged(nameof(IsRunning));
            });

            // Sprawdzamy, czy jesteśmy w wątku UI (Windows 11 / WPF Threading Model)
            if (System.Windows.Application.Current.Dispatcher.CheckAccess())
            {
                action.Invoke();
            }
            else
            {
                // Jeśli nie, przesyłamy wykonanie do wątku UI
                System.Windows.Application.Current.Dispatcher.BeginInvoke(action);
            }
        }

        /// <summary>
        /// Gets the name of the type of the underlying background task.
        /// </summary>
        public string? TypeName
        {
            get
            {
                return backgroundTask?.GetType()?.Name;
            }
        }
    }

    /// <summary>
    /// A non-generic implementation of <see cref="VisualBackgroundTask{TBackgroundTask}"/> using the base <see cref="IBackgroundTask"/> interface.
    /// </summary>
    public class VisualBackgroundTask : VisualBackgroundTask<IBackgroundTask>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisualBackgroundTask"/> class.
        /// </summary>
        /// <param name="backgroundTask">The background task instance to be wrapped.</param>
        /// <param name="name">The display name of the background task.</param>
        /// <param name="description">A detailed description of the background task.</param>
        public VisualBackgroundTask(IBackgroundTask backgroundTask, string name, string description)
            : base(backgroundTask, name, description)
        {
        }
    }
}