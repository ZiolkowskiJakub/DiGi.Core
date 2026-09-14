using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>
        /// Generates a deterministic list of colors for a typology scheme, one color per bucket.
        /// <para>Sequential returns an end-point-inclusive OKLab ramp between the two anchors; with a single bucket the result is the end anchor. Diverging returns two OKLab ramps meeting at the neutral middle, which sits on the centre bucket for odd counts and is the single element for a single bucket. Categorical returns the curated palette up to 12 buckets and golden-angle hues beyond, and legends past roughly 24 buckets are not readable.</para>
        /// <para>Every generated color is clamped to the OKLab lightness band [Constants.ColorScheme.LightnessMin, Constants.ColorScheme.LightnessMax], so an anchor outside the band is clamped to it rather than returned as given.</para>
        /// <para>The result is deterministic: no randomness and no culture-dependent formatting anywhere in the path.</para>
        /// </summary>
        /// <param name="colorSchemeType">The scheme the color list follows.</param>
        /// <param name="count">The number of colors, one per typology bucket.</param>
        /// <param name="color_Start">Optional start anchor replacing the scheme default; null uses the default.</param>
        /// <param name="color_End">Optional end anchor replacing the scheme default; null uses the default.</param>
        /// <returns>The colors, or null if count is below 1.</returns>
        public static List<Classes.Color>? Colors(this Enums.ColorSchemeType colorSchemeType, int count, Classes.Color? color_Start = null, Classes.Color? color_End = null)
        {
            if (count < 1)
            {
                return null;
            }

            switch (colorSchemeType)
            {
                case Enums.ColorSchemeType.Sequential:
                {
                    Classes.OKLab okLab_Start = ClampLightness(new Classes.Color(color_Start is null ? Constants.ColorScheme.SequentialStart : color_Start.Value).ToOKLab());
                    Classes.OKLab okLab_End = ClampLightness(new Classes.Color(color_End is null ? Constants.ColorScheme.SequentialEnd : color_End.Value).ToOKLab());

                    if (count == 1)
                    {
                        return [okLab_End.ToDiGi()];
                    }

                    return Ramp(okLab_Start, okLab_End, count);
                }

                case Enums.ColorSchemeType.Diverging:
                {
                    Classes.OKLab okLab_Start = ClampLightness(new Classes.Color(color_Start is null ? Constants.ColorScheme.DivergingStart : color_Start.Value).ToOKLab());
                    Classes.OKLab okLab_Middle = ClampLightness(new Classes.Color(Constants.ColorScheme.DivergingMiddle).ToOKLab());
                    Classes.OKLab okLab_End = ClampLightness(new Classes.Color(color_End is null ? Constants.ColorScheme.DivergingEnd : color_End.Value).ToOKLab());

                    if (count == 1)
                    {
                        return [okLab_Middle.ToDiGi()];
                    }

                    List<Classes.Color> colors = [];

                    for (int i = 0; i < count; i++)
                    {
                        double u = (double)i / (count - 1);
                        Classes.OKLab okLab = u <= 0.5 ? LerpOKLab(okLab_Start, okLab_Middle, u / 0.5) : LerpOKLab(okLab_Middle, okLab_End, (u - 0.5) / 0.5);

                        colors.Add(okLab.ToDiGi());
                    }

                    return colors;
                }

                case Enums.ColorSchemeType.Categorical:
                {
                    List<Classes.Color> colors = [];

                    for (int i = 0; i < count; i++)
                    {
                        Classes.Color color;

                        if (i < Constants.ColorScheme.CategoricalPaletteSize)
                        {
                            color = new Classes.Color(Constants.ColorScheme.CategoricalPalette[i]);
                        }
                        else
                        {
                            double hue = (i * Constants.ColorScheme.CategoricalGoldenAngleDegrees) % 360.0;
                            double turn = (i - Constants.ColorScheme.CategoricalPaletteSize) / Constants.ColorScheme.CategoricalTurnSize;
                            double lightness = turn % 2 == 0 ? Constants.ColorScheme.CategoricalGoldenAngleLightness_0 : Constants.ColorScheme.CategoricalGoldenAngleLightness_1;
                            double angle = hue * System.Math.PI / 180.0;

                            color = new Classes.OKLab(lightness, Constants.ColorScheme.CategoricalGoldenAngleChroma * System.Math.Cos(angle), Constants.ColorScheme.CategoricalGoldenAngleChroma * System.Math.Sin(angle)).ToDiGi();
                        }

                        colors.Add(color);
                    }

                    return colors;
                }

                default:
                {
                    return null;
                }
            }

            Classes.OKLab ClampLightness(Classes.OKLab okLab)
            {
                double lightness = System.Math.Max(Constants.ColorScheme.LightnessMin, System.Math.Min(Constants.ColorScheme.LightnessMax, okLab.L));

                return new Classes.OKLab(lightness, okLab.A, okLab.B);
            }

            Classes.OKLab LerpOKLab(Classes.OKLab okLab_1, Classes.OKLab okLab_2, double value)
            {
                return new Classes.OKLab(
                    okLab_1.L + (okLab_2.L - okLab_1.L) * value,
                    okLab_1.A + (okLab_2.A - okLab_1.A) * value,
                    okLab_1.B + (okLab_2.B - okLab_1.B) * value);
            }

            List<Classes.Color> Ramp(Classes.OKLab okLab_Start, Classes.OKLab okLab_End, int count)
            {
                List<Classes.Color> colors = [];

                for (int i = 0; i < count; i++)
                {
                    double value = (double)i / (count - 1);

                    colors.Add(LerpOKLab(okLab_Start, okLab_End, value).ToDiGi());
                }

                return colors;
            }
        }
    }
}
