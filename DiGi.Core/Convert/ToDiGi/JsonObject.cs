using DiGi.Core.Classes;

namespace DiGi.Core
{
    public static partial class Convert
    {
        public static Color ToDiGi(this System.Drawing.Color color)
        {
            return new Color(color);
        }
    }
}
