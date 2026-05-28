namespace DiGi.Core.Drawing
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a DiGi Pen to a System.Drawing.Pen.
        /// </summary>
        /// <param name="pen">The Pen to convert.</param>
        /// <returns>A System.Drawing.Pen instance, or null if the source pen is null.</returns>
        public static System.Drawing.Pen? ToDrawing(this Classes.Pen? pen)
        {
            if (pen == null)
            {
                return null;
            }

            return new System.Drawing.Pen(Core.Convert.ToDrawing(pen.Color), System.Convert.ToSingle(pen.Thickness));
        }
    }
}