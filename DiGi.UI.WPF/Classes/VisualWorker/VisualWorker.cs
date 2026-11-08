using DiGi.UI.WPF.Interfaces;
using System.ComponentModel;

namespace DiGi.UI.WPF.Classes
{
    /// <summary>
    /// Provides an abstract base implementation of a visual worker that wraps a <see cref="BackgroundWorker"/> to handle asynchronous operations.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1001:Types that own disposable fields should be disposable", Justification = "BackgroundWorker holds no unmanaged resource; Component.Dispose only detaches it from a container it never joins.")]
    public abstract class VisualWorker : IVisualWorker
    {
        protected BackgroundWorker backgroundWorker = new() { WorkerReportsProgress = false };

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualWorker"/> class and attaches internal handlers to the background worker's events.
        /// </summary>
        public VisualWorker()
        {
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        /// <summary>
        /// Occurs when the background worker begins its operation.
        /// </summary>
        public event DoWorkEventHandler? DoWork;

        /// <summary>
        /// Occurs when the background worker completes its operation.
        /// </summary>
        public event RunWorkerCompletedEventHandler? RunWorkerCompleted;

        /// <summary>
        /// Gets a value indicating whether the worker is currently busy.
        /// </summary>
        public bool IsBusy
        {
            get
            {
                return backgroundWorker == null ? false : backgroundWorker.IsBusy;
            }
        }

        /// <summary>
        /// Starts the asynchronous execution of the background worker.
        /// </summary>
        public virtual void Run()
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            DoWork?.Invoke(this, e);
        }

        private void BackgroundWorker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            RunWorkerCompleted?.Invoke(this, e);
        }
    }
}