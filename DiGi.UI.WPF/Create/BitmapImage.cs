using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DiGi.UI.WPF
{
    public static partial class Create
    {
        /// <summary>
        /// Converts a byte array into a <see cref="System.Windows.Media.Imaging.BitmapImage"/>.
        /// </summary>
        /// <param name="bytes">The byte array containing the image data.</param>
        /// <returns>A <see cref="System.Windows.Media.Imaging.BitmapImage"/> created from the provided bytes, or null if the input is null.</returns>
        public static BitmapImage? BitmapImage(this byte[]? bytes)
        {
            if (bytes == null)
            {
                return null;
            }

            using MemoryStream memoryStream = new(bytes);

            BitmapImage result = new();
            result.BeginInit();
            result.CacheOption = BitmapCacheOption.OnLoad;
            result.StreamSource = memoryStream;
            result.EndInit();
            result.Freeze();
            return result;
        }

        /// <summary>
        /// Converts a <see cref="Image"/> object into a <see cref="System.Windows.Media.Imaging.BitmapImage"/>.
        /// </summary>
        /// <param name="image">The source image to convert.</param>
        /// <returns>A <see cref="System.Windows.Media.Imaging.BitmapImage"/> created from the provided image, or null if the input is null.</returns>
        public static BitmapImage? BitmapImage(Image? image)
        {
            if (image is null)
            {
                return null;
            }

            using MemoryStream memoryStream = new();

            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);

            memoryStream.Position = 0;

            BitmapImage result = new();
            result.BeginInit();
            result.CacheOption = BitmapCacheOption.OnLoad;
            result.StreamSource = memoryStream;
            result.EndInit();
            result.Freeze();

            return result;
        }

        /// <summary>
        /// Creates a solid color <see cref="System.Windows.Media.Imaging.BitmapImage"/> with the specified dimensions.
        /// </summary>
        /// <param name="width">The width of the resulting image in pixels.</param>
        /// <param name="height">The height of the resulting image in pixels.</param>
        /// <param name="color">The <see cref="System.Drawing.Color"/> to fill the image with.</param>
        /// <returns>A <see cref="System.Windows.Media.Imaging.BitmapImage"/> representing a solid color rectangle.</returns>
        public static BitmapImage BitmapImage(int width, int height, System.Drawing.Color color)
        {
            WriteableBitmap bitmap = new(width, height, 96, 96, PixelFormats.Bgra32, null);

            // Create pixel data (BGRA format, 4 bytes per pixel)
            int stride = width * 4; // 4 bytes per pixel
            byte[] pixels = new byte[height * stride];

            // Fill with white (BGRA: 255,255,255,255)
            for (int i = 0; i < pixels.Length; i += 4)
            {
                pixels[i] = color.B;     // Blue
                pixels[i + 1] = color.G; // Green
                pixels[i + 2] = color.R; // Red
                pixels[i + 3] = color.A; // Alpha (fully opaque)
            }

            // Write pixels to the bitmap
            bitmap.WritePixels(new Int32Rect(0, 0, width, height), pixels, stride, 0);

            using MemoryStream stream = new();
            BitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bitmap));
            encoder.Save(stream);

            BitmapImage result = new();
            result.BeginInit();
            result.CacheOption = BitmapCacheOption.OnLoad;
            result.StreamSource = new MemoryStream(stream.ToArray());
            result.EndInit();
            result.Freeze();

            return result;
        }
    }
}