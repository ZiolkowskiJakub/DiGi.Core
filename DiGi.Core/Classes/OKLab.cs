namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a color in the OKLab perceptual color space, with lightness L and chromatic axes A and B.
    /// <para>OKLab (Ottosson, 2021) is a perceptually uniform color space: equal Euclidean distances read as equal visual differences, which is why the color ramps interpolate on it and the categorical distance check asserts on it instead of RGB.</para>
    /// </summary>
    public readonly struct OKLab
    {
        private readonly double l;
        private readonly double a;
        private readonly double b;

        /// <summary>
        /// Initializes a new instance of the OKLab struct with specified lightness and chromatic axes.
        /// </summary>
        /// <param name="l">The OKLab lightness L.</param>
        /// <param name="a">The OKLab A chromatic axis.</param>
        /// <param name="b">The OKLab B chromatic axis.</param>
        public OKLab(double l, double a, double b)
        {
            this.l = l;
            this.a = a;
            this.b = b;
        }

        /// <summary>
        /// Gets the OKLab lightness L.
        /// </summary>
        public double L
        {
            get
            {
                return l;
            }
        }

        /// <summary>
        /// Gets the OKLab A chromatic axis.
        /// </summary>
        public double A
        {
            get
            {
                return a;
            }
        }

        /// <summary>
        /// Gets the OKLab B chromatic axis.
        /// </summary>
        public double B
        {
            get
            {
                return b;
            }
        }
    }
}
