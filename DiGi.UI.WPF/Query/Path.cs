using Microsoft.Win32;
using System.Globalization;

namespace DiGi.UI.WPF
{
    public static partial class Query
    {
        /// <summary>
        /// Opens an open file dialog to select a file based on a specific type name and extension.
        /// </summary>
        /// <param name="window">The owner window for the dialog.</param>
        /// <param name="fileTypeName">The descriptive name of the file type.</param>
        /// <param name="fileExtension">The file extension to filter by.</param>
        /// <returns>The full path of the selected file, or null if the dialog was cancelled or closed.</returns>
        public static string? Path(this System.Windows.Window? window, string fileTypeName, string fileExtension)
        {
            OpenFileDialog openFileDialog = new()
            {
                Title = string.Format(CultureInfo.CurrentCulture, "Select {0}", fileTypeName),
                Filter = string.Format(CultureInfo.CurrentCulture, "{0} (*.{1})|*.{1}|All Files (*.*)|*.*", fileTypeName, fileExtension),
                FilterIndex = 1,
                Multiselect = false
            };

            bool? result = openFileDialog.ShowDialog(window);
            if (result == null || !result.HasValue || !result.Value)
            {
                return null;
            }

            return openFileDialog.FileName;
        }

        /// <summary>
        /// Opens an open file dialog to select a file using a provided file filter and optionally including all files.
        /// </summary>
        /// <param name="window">The owner window for the dialog.</param>
        /// <param name="fileFilter">An optional <see cref="DiGi.Core.IO.Classes.FileFilter"/> used to filter the files.</param>
        /// <param name="allFiles">A boolean indicating whether to include a filter for all files (*.*).</param>
        /// <returns>The full path of the selected file, or null if the dialog was cancelled or closed.</returns>
        public static string? Path(this System.Windows.Window? window, DiGi.Core.IO.Classes.FileFilter? fileFilter = null, bool allFiles = false)
        {
            List<DiGi.Core.IO.Classes.FileFilter> fileFilters = [];
            if (fileFilter == null)
            {
                fileFilters.Add(DiGi.Core.IO.Create.FileFilter_AllFiles());
            }
            else
            {
                fileFilters.Add(fileFilter);
                if (allFiles)
                {
                    fileFilters.Add(DiGi.Core.IO.Create.FileFilter_AllFiles());
                }
            }

            OpenFileDialog openFileDialog = new()
            {
                Title = string.Format(CultureInfo.CurrentCulture, "Select {0}", fileFilter?.Name),
                Filter = DiGi.Core.IO.Query.Filter(fileFilters?.ToArray()),
                FilterIndex = 1,
                Multiselect = false
            };

            bool? result = openFileDialog.ShowDialog(window);
            if (result == null || !result.HasValue || !result.Value)
            {
                return null;
            }

            return openFileDialog.FileName;
        }

        /// <summary>
        /// Opens an open file dialog to select a file using a custom title and a collection of file filters.
        /// </summary>
        /// <param name="window">The owner window for the dialog.</param>
        /// <param name="title">An optional custom title for the dialog window.</param>
        /// <param name="fileFilters">A collection of <see cref="DiGi.Core.IO.Classes.FileFilter"/> objects to define the file selection filters.</param>
        /// <returns>The full path of the selected file, or null if the dialog was cancelled or closed.</returns>
        public static string? Path(this System.Windows.Window? window, string? title, IEnumerable<DiGi.Core.IO.Classes.FileFilter>? fileFilters)
        {
            OpenFileDialog openFileDialog = new()
            {
                Title = title ?? "Select file",
                Filter = DiGi.Core.IO.Query.Filter(fileFilters?.ToArray()),
                FilterIndex = 1,
                Multiselect = false
            };

            bool? result = openFileDialog.ShowDialog(window);
            if (result == null || !result.HasValue || !result.Value)
            {
                return null;
            }

            return openFileDialog.FileName;
        }
    }
}