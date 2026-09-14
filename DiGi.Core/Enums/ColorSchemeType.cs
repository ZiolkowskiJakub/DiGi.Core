using System.ComponentModel;

namespace DiGi.Core.Enums
{
    /// <summary>
    /// Defines the color scheme a generated color list follows.
    /// </summary>
    [Description("Color Scheme Type")]
    public enum ColorSchemeType
    {
        /// <summary>Ordered range buckets (low to high), a perceptually even ramp between two anchors</summary>
        [Description("Sequential")] Sequential,

        /// <summary>Ranges centred on a meaningful middle, two ramps meeting at a neutral light middle</summary>
        [Description("Diverging")] Diverging,

        /// <summary>Unique-value buckets, a curated palette up to 12 and golden-angle rotation beyond</summary>
        [Description("Categorical")] Categorical
    }
}
