using DiGi.Core.Classes;

namespace DiGi.Core.Drawing
{
    public static partial class Convert
    {
        public static System.Drawing.Pen ToDrawing(this Pen pen)
        {
            if(pen == null)
            {
                return null;
            }

            return new System.Drawing.Pen(Core.Convert.ToDrawing(pen.Color), System.Convert.ToSingle(pen.Thickness));
        }
    }
}
