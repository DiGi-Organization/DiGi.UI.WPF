using DiGi.Core.Interfaces;
using DiGi.UI.WPF.Classes;
using DiGi.UI.WPF.Interfaces;

namespace DiGi.UI.WPF
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a visual wrapper for the specified background task, automatically determining if it is reportable to provide the appropriate visual implementation.
        /// </summary>
        /// <param name="backgroundTask">The background task instance to be wrapped.</param>
        /// <param name="name">The display name of the task.</param>
        /// <param name="description">A description of the task's operation.</param>
        /// <returns>An implementation of <see cref="IVisualBackgroundTask"/> that provides visual tracking for the background task.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown when <paramref name="backgroundTask"/> is null.</exception>
        public static IVisualBackgroundTask VisualBackgroundTask(IBackgroundTask backgroundTask, string name, string description)
        {
            ArgumentNullException.ThrowIfNull(backgroundTask);

            // 1. Check if the task implements IReportableBackgroundTask<T>
            Type type_Task = backgroundTask.GetType();
            Type[] types_Interfaces = type_Task.GetInterfaces();

            Type? type_Interface = types_Interfaces.FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IReportableBackgroundTask<>));

            if (type_Interface != null)
            {
                // Extract the progress type T from IReportableBackgroundTask<T>
                Type type_Progress = type_Interface.GetGenericArguments()[0];

                // Construct the type: VisualReportableBackgroundTask<T, TReportableBackgroundTask>
                // We use the specific task type to satisfy the generic constraints
                Type type_Visual = typeof(VisualReportableBackgroundTask<,>).MakeGenericType(type_Progress, type_Task);

                // Create instance using reflection
                object? @object = Activator.CreateInstance(type_Visual, backgroundTask, name, description);

                if (@object is IVisualBackgroundTask result)
                {
                    return result;
                }
            }

            // 2. Fallback for CancelableBackgroundTask and standard BackgroundTask
            // Both are handled by the standard VisualBackgroundTask wrapper
            return new VisualBackgroundTask(backgroundTask, name, description);
        }
    }
}