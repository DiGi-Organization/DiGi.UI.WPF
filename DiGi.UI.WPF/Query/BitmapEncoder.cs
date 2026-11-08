using DiGi.Core.IO.Classes;
using System.Globalization;
using System.Windows.Media.Imaging;

namespace DiGi.UI.WPF
{
    public static partial class Query
    {
        /// <summary>
        /// Determines the appropriate <see cref="BitmapEncoder"/> based on the file extensions provided in the specified file filter.
        /// </summary>
        /// <param name="fileFilter">The file filter containing the list of extensions to evaluate.</param>
        /// <returns>A <see cref="BitmapEncoder"/> instance (such as <see cref="JpegBitmapEncoder"/> or <see cref="PngBitmapEncoder"/>) if a matching image extension is found; otherwise, null.</returns>
        public static BitmapEncoder? BitmapEncoder(this FileFilter? fileFilter)
        {
            List<string>? extensions = fileFilter?.Extensions;
            if (extensions == null || extensions.Count == 0)
            {
                return null;
            }

            foreach (string extension in extensions)
            {
                string? value = extension?.ToLower(CultureInfo.CurrentCulture)?.Trim();
                if (string.IsNullOrWhiteSpace(value))
                {
                    continue;
                }

                if (value.Equals(Constants.FileExtension.Jpeg_1, StringComparison.Ordinal) || value.Equals(Constants.FileExtension.Jpeg_2, StringComparison.Ordinal) || value.Equals(Constants.FileExtension.Jpeg_3, StringComparison.Ordinal) || value.Equals(Constants.FileExtension.Jpeg_4, StringComparison.Ordinal))
                {
                    return new JpegBitmapEncoder();
                }

                if (value.Equals(Constants.FileExtension.Png, StringComparison.Ordinal))
                {
                    return new PngBitmapEncoder();
                }
            }

            return null;
        }
    }
}