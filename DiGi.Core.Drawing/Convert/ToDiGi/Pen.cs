using DiGi.Core.Classes;

namespace DiGi.Core.Drawing
{
    public static partial class Convert
    {
        public static Pen ToDiGi(this System.Drawing.Pen pen)
        {
            if(pen == null)
            {
                return null;
            }

            return new Pen(pen.Color.ToDiGi(), pen.Width);
        }
    }
}
