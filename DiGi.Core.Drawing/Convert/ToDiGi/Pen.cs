namespace DiGi.Core.Drawing
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a System.Drawing.Pen to a DiGi Pen.
        /// </summary>
        /// <param name="pen">The System.Drawing.Pen to convert.</param>
        /// <returns>A Pen instance, or null if the source pen is null.</returns>
        public static Classes.Pen? ToDiGi(this System.Drawing.Pen? pen)
        {
            if (pen == null)
            {
                return null;
            }

            return new Classes.Pen(pen.Color.ToDiGi(), pen.Width);
        }
    }
}