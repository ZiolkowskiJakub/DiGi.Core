namespace DiGi.Core.Drawing
{
    public static partial class Convert
    {
        public static System.Drawing.Pen ToDrawing(this Classes.Pen pen)
        {
            if(pen == null)
            {
                return null;
            }

            return new System.Drawing.Pen(Core.Convert.ToDrawing(pen.Color), System.Convert.ToSingle(pen.Thickness));
        }
    }
}
