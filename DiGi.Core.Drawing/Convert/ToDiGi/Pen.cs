using DiGi.Core.Classes;

namespace DiGi.Core.Drawing
{
    public static partial class Convert
    {
        public static Classes.Pen ToDiGi(this System.Drawing.Pen pen)
        {
            if(pen == null)
            {
                return null;
            }

            return new Classes.Pen(pen.Color.ToDiGi(), pen.Width);
        }
    }
}
