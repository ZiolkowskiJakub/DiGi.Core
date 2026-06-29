using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace DiGi.Core.Drawing
{
    public static partial class Query
    {
        /// <summary>
        /// Compares two images by checking if all corresponding pixels are identical.
        /// </summary>
        /// <param name="image_1">The first image to compare.</param>
        /// <param name="image_2">The second image to compare.</param>
        /// <returns>True if both images are identical in size and pixel data; otherwise, false.</returns>
        public static bool CompareByPixels(this Image? image_1, Image? image_2)
        {
            if (image_1 == null && image_2 == null)
            {
                return true;
            }

            if (image_1 == null || image_2 == null)
            {
                return false;
            }

            using Bitmap bitmap_1 = new(image_1);
            using Bitmap bitmap_2 = new(image_2);

            if (bitmap_1.Width != bitmap_2.Width || bitmap_1.Height != bitmap_2.Height)
            {
                return false;
            }

            // Original implementation (kept for reference): called GetPixel(x, y) once per pixel per
            // bitmap. Each GetPixel call has real fixed overhead (internal locking and per-call format
            // conversion to Color), so for a W x H image this is W*H GetPixel calls on each side -
            // e.g. ~2,000,000 calls for a 1920x1080 comparison. Algorithmically O(W*H), but with a very
            // high per-call constant factor compared to a single bulk memory read.
            //
            // for (int x = 0; x < bitmap_1.Width; x++)
            // {
            //     for (int y = 0; y < bitmap_1.Height; y++)
            //     {
            //         if (bitmap_1.GetPixel(x, y) != bitmap_2.GetPixel(x, y))
            //         {
            //             return false;
            //         }
            //     }
            // }
            //
            // return true;

            // Optimized implementation: normalize both bitmaps to a single, fixed pixel format
            // (Format32bppArgb) by blitting them onto fresh bitmaps via Graphics.DrawImageUnscaled,
            // then read each bitmap's raw pixel buffer in one bulk copy and compare the bytes directly.
            // This avoids three separate pitfalls that a naive LockBits rewrite would hit:
            // 1. Source format mismatch: image_1/image_2 may originate from different native pixel
            //    formats (e.g. 8bpp indexed GIF vs 32bpp PNG). Comparing raw bytes across different
            //    formats would be meaningless. Normalizing both to the same format first (via GDI+'s
            //    own, well-tested rendering pipeline) removes this risk entirely.
            // 2. Row stride padding: BitmapData rows are padded to 4-byte boundaries for most formats,
            //    so naively comparing the full buffer can flag false mismatches in padding bytes that
            //    don't represent actual pixel data. Format32bppArgb uses exactly 4 bytes per pixel, so
            //    stride is always width * 4 with no padding - this format choice sidesteps the issue
            //    rather than requiring per-row trimming logic.
            // 3. Indexed formats: 8bpp/4bpp/1bpp images store a palette index per pixel, not a color
            //    value, so identical colors can have different raw byte values if the palettes differ.
            //    Normalizing to Format32bppArgb resolves indices to actual ARGB color values first.
            //
            // Note: Bitmap.Clone(Rectangle, PixelFormat) was deliberately NOT used here - it is a
            // documented GDI+ quirk that Clone can fail to produce a pixel-faithful copy even when the
            // target format matches the source format. Graphics.DrawImageUnscaled onto a freshly
            // created Format32bppArgb bitmap is the standard, reliable way to normalize pixel format.
            //
            // CompositingMode.SourceCopy is required here (not the default SourceOver): a freshly
            // allocated Bitmap's pixel buffer is not guaranteed to be zero-initialized, and SourceOver
            // alpha-blends the source over whatever is already in the destination - for fully
            // transparent source pixels (alpha = 0) that leaves the destination's uninitialized memory
            // untouched. Since bitmap_1_Argb and bitmap_2_Argb are two independently allocated buffers,
            // their uninitialized regions can differ, causing false mismatches. SourceCopy overwrites
            // every destination byte unconditionally from the source, removing that risk entirely.
            int width = bitmap_1.Width;
            int height = bitmap_1.Height;

            using Bitmap bitmap_1_Argb = new(width, height, PixelFormat.Format32bppArgb);
            using (Graphics graphics_1 = Graphics.FromImage(bitmap_1_Argb))
            {
                graphics_1.CompositingMode = CompositingMode.SourceCopy;
                graphics_1.DrawImageUnscaled(bitmap_1, 0, 0);
            }

            using Bitmap bitmap_2_Argb = new(width, height, PixelFormat.Format32bppArgb);
            using (Graphics graphics_2 = Graphics.FromImage(bitmap_2_Argb))
            {
                graphics_2.CompositingMode = CompositingMode.SourceCopy;
                graphics_2.DrawImageUnscaled(bitmap_2, 0, 0);
            }

            Rectangle rectangle = new(0, 0, width, height);

            BitmapData bitmapData_1 = bitmap_1_Argb.LockBits(rectangle, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            try
            {
                BitmapData bitmapData_2 = bitmap_2_Argb.LockBits(rectangle, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

                try
                {
                    int byteCount = bitmapData_1.Stride * bitmap_1_Argb.Height;

                    byte[] bytes_1 = new byte[byteCount];
                    byte[] bytes_2 = new byte[byteCount];

                    Marshal.Copy(bitmapData_1.Scan0, bytes_1, 0, byteCount);
                    Marshal.Copy(bitmapData_2.Scan0, bytes_2, 0, byteCount);

                    // Calling Core.Query.Equals explicitly as a static method here is required: byte[]
                    // inherits object.Equals(object), which is an instance method and therefore wins
                    // overload resolution over the Core.Query.Equals(byte[], byte[]) extension method -
                    // bytes_1.Equals(bytes_2) would silently call object.Equals (reference equality)
                    // instead, always returning false for two distinct array instances.
                    return DiGi.Core.Query.Equals(bytes_1, bytes_2);
                }
                finally
                {
                    bitmap_2_Argb.UnlockBits(bitmapData_2);
                }
            }
            finally
            {
                bitmap_1_Argb.UnlockBits(bitmapData_1);
            }
        }
    }
}
