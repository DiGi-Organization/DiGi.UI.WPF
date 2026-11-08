using Microsoft.Win32;
using System.Globalization;

namespace DiGi.UI.WPF
{
    public static partial class Query
    {
        /// <summary>
        /// Opens an open file dialog to select one or more files based on the specified type name and extension.
        /// </summary>
        /// <param name="window">The owner window that will display the dialog.</param>
        /// <param name="fileTypeName">The descriptive name of the file type to be displayed in the dialog title and filter.</param>
        /// <param name="fileExtension">The file extension used for filtering files (e.g., "txt").</param>
        /// <returns>An array of strings containing the paths of the selected files, or <c>null</c> if the dialog was cancelled or closed.</returns>
        public static string[]? Paths(this System.Windows.Window window, string fileTypeName, string fileExtension)
        {
            OpenFileDialog openFileDialog = new()
            {
                Title = string.Format(CultureInfo.CurrentCulture, "Select {0}", fileTypeName),
                Filter = string.Format(CultureInfo.CurrentCulture, "{0} (*.{1})|*.{1}|All Files (*.*)|*.*", fileTypeName, fileExtension),
                FilterIndex = 1,
                Multiselect = true
            };

            bool? result = openFileDialog.ShowDialog(window);
            if (result == null || !result.HasValue || !result.Value)
            {
                return null;
            }

            return openFileDialog.FileNames;
        }
    }
}