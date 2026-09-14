namespace DiGi.Core.Constants
{
    /// <summary>
    /// Color scheme parameters for Create.Colors: the OKLab lightness band, the default ramp anchors, the curated categorical palette, and the golden-angle fallback parameters.
    /// </summary>
    public static class ColorScheme
    {
        /// <summary>
        /// Minimum OKLab lightness L any generated color may reach.
        /// <para>Colors outside the band read as washed out or crushed on a light background, so every generated color clamps L to this band.</para>
        /// </summary>
        public const double LightnessMin = 0.15;

        /// <summary>
        /// Maximum OKLab lightness L any generated color may reach.
        /// <para>An anchor or middle point above this value is clamped down to it, for example the default sequential start #deebf7 (L = 0.9339) and the diverging middle #f7f7f7 (L = 0.9761).</para>
        /// </summary>
        public const double LightnessMax = 0.93;

        /// <summary>
        /// Default sequential ramp start anchor, a light blue #deebf7, in ARGB integer form.
        /// <para>Lightness-clamped at generation time, because its L = 0.9339 exceeds LightnessMax.</para>
        /// </summary>
        public const int SequentialStart = unchecked((int)0xFFDEEBF7);

        /// <summary>
        /// Default sequential ramp end anchor, a dark blue #08306b, in ARGB integer form.
        /// </summary>
        public const int SequentialEnd = unchecked((int)0xFF08306B);

        /// <summary>
        /// Default diverging ramp start anchor, a red #b2182b, in ARGB integer form.
        /// </summary>
        public const int DivergingStart = unchecked((int)0xFFB2182B);

        /// <summary>
        /// Default diverging ramp middle point, a near-white #f7f7f7, in ARGB integer form.
        /// <para>Lightness-clamped at generation time, because its L = 0.9761 exceeds LightnessMax.</para>
        /// </summary>
        public const int DivergingMiddle = unchecked((int)0xFFF7F7F7);

        /// <summary>
        /// Default diverging ramp end anchor, a blue #2166ac, in ARGB integer form.
        /// </summary>
        public const int DivergingEnd = unchecked((int)0xFF2166AC);

        /// <summary>
        /// Curated categorical palette in bucket order, the 12 colors a GIS typology page seeds its unique-value buckets with.
        /// <para>Tableau 10 extended with #393b79 and #e7ba52. Its minimum pairwise OKLab distance is 0.0778, between #bcbd22 and #e7ba52.</para>
        /// </summary>
        public static readonly int[] CategoricalPalette = [unchecked((int)0xFF1F77B4), unchecked((int)0xFFFF7F0E), unchecked((int)0xFF2CA02C), unchecked((int)0xFFD62728), unchecked((int)0xFF9467BD), unchecked((int)0xFF8C564B), unchecked((int)0xFFE377C2), unchecked((int)0xFF7F7F7F), unchecked((int)0xFFBCBD22), unchecked((int)0xFF17BECF), unchecked((int)0xFF393B79), unchecked((int)0xFFE7BA52)];

        /// <summary>
        /// Minimum OKLab distance any two categorical colors may sit apart.
        /// <para>Set to 0.075, below the 0.08 proposed in the issue, because the curated palette's own closest pair (#bcbd22 and #e7ba52) sits at 0.0778; the floor is set to the palette's achieved minimum so the exact palette the GIS page uses stays assertable and reproducible.</para>
        /// </summary>
        public const double CategoricalMinimumDistance = 0.075;

        /// <summary>
        /// Number of buckets the curated palette covers; Colors falls back to golden-angle generation above this count.
        /// </summary>
        public const int CategoricalPaletteSize = 12;

        /// <summary>
        /// Buckets per golden-angle turn; the lightness level flips at each turn boundary so turns differ in more than hue.
        /// </summary>
        public const int CategoricalTurnSize = 12;

        /// <summary>
        /// Golden angle in degrees, the hue step of the beyond-12 categorical fallback.
        /// </summary>
        public const double CategoricalGoldenAngleDegrees = 137.508;

        /// <summary>
        /// OKLab chroma of the beyond-12 categorical fallback, fixed so new buckets differ mostly in hue and lightness.
        /// </summary>
        public const double CategoricalGoldenAngleChroma = 0.10;

        /// <summary>
        /// OKLab lightness of the first and third golden-angle turns (i = 12-23, i = 36-47).
        /// </summary>
        public const double CategoricalGoldenAngleLightness_0 = 0.30;

        /// <summary>
        /// OKLab lightness of the second and fourth golden-angle turns (i = 24-35, i = 48-59).
        /// </summary>
        public const double CategoricalGoldenAngleLightness_1 = 0.65;
    }
}
