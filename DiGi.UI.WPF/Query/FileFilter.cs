using DiGi.Core.IO.Classes;
using System.Globalization;

namespace DiGi.UI.WPF
{
    public static partial class Query
    {
        /// <summary>
        /// Determines the appropriate file filter based on the provided file path's extension.
        /// </summary>
        /// <param name="path">The path of the file to evaluate.</param>
        /// <returns>A <see cref="FileFilter"/> instance if a matching filter is found; otherwise, null.</returns>
        public static FileFilter? FileFilter(string? path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            string extension = System.IO.Path.GetExtension(path).ToLower(CultureInfo.CurrentCulture).Trim();
            if (!string.IsNullOrWhiteSpace(extension) && extension.StartsWith('.'))
            {
                extension = extension[1..];
            }

            if (Constants.FileFilter.Jpeg.Extensions!.Contains(extension))
            {
                return Constants.FileFilter.Jpeg;
            }

            if (Constants.FileFilter.Png.Extensions!.Contains(extension))
            {
                return Constants.FileFilter.Png;
            }

            return null;
        }
    }
}