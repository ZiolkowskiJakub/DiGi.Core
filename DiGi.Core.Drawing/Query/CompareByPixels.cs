using System.Drawing;

namespace DiGi.Core.Drawing
{
    public static partial class Query
    {
        public static bool CompareByPixels(this Image image_1, Image image_2)
        {
            if(image_1 == null && image_2 == null)
            {
                return true;
            }

            if(image_1 == null || image_2 == null)
            {
                return false;
            }

            using Bitmap bitmap_1 = new Bitmap(image_1);
            using Bitmap bitmap_2 = new Bitmap(image_2);

            if (bitmap_1.Width != bitmap_2.Width || bitmap_1.Height != bitmap_2.Height)
            {
                return false;
            }

            for (int x = 0; x < bitmap_1.Width; x++)
            {
                for (int y = 0; y < bitmap_1.Height; y++)
                {
                    if (bitmap_1.GetPixel(x, y) != bitmap_2.GetPixel(x, y))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}