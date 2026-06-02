namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Converts a <see cref="Enums.UTC"/> enum value to its corresponding numeric hour offset from UTC.
        /// </summary>
        /// <param name="uTC">The UTC timezone enum value.</param>
        /// <returns>The numeric hour offset (e.g., 2.0 for UTC+2), or NaN if undefined.</returns>
        public static double TimeOffset(this Enums.UTC uTC)
        {
            if (uTC == Enums.UTC.Undefined)
            {
                return double.NaN;
            }

            switch (uTC)
            {
                case Enums.UTC.Minus1200:
                    return -12.0;

                case Enums.UTC.Minus1100:
                    return -11.0;

                case Enums.UTC.Minus1000:
                    return -10.0;

                case Enums.UTC.Minus0930:
                    return -9.5;

                case Enums.UTC.Minus0900:
                    return -9.0;

                case Enums.UTC.Minus0800:
                    return -8.0;

                case Enums.UTC.Minus0700:
                    return -7.0;

                case Enums.UTC.Minus0600:
                    return -6.0;

                case Enums.UTC.Minus0500:
                    return -5.0;

                case Enums.UTC.Minus0400:
                    return -4.0;

                case Enums.UTC.Minus0330:
                    return -3.5;

                case Enums.UTC.Minus0300:
                    return -3.0;

                case Enums.UTC.Minus0200:
                    return -2.0;

                case Enums.UTC.Minus0100:
                    return -1.0;

                case Enums.UTC.PlusMinus0000:
                    return 0.0;

                case Enums.UTC.Plus0100:
                    return 1.0;

                case Enums.UTC.Plus0200:
                    return 2.0;

                case Enums.UTC.Plus0300:
                    return 3.0;

                case Enums.UTC.Plus0330:
                    return 3.5;

                case Enums.UTC.Plus0400:
                    return 4.0;

                case Enums.UTC.Plus0430:
                    return 4.5;

                case Enums.UTC.Plus0500:
                    return 5.0;

                case Enums.UTC.Plus0530:
                    return 5.5;

                case Enums.UTC.Plus0545:
                    return 5.75;

                case Enums.UTC.Plus0600:
                    return 6.0;

                case Enums.UTC.Plus0630:
                    return 6.5;

                case Enums.UTC.Plus0700:
                    return 7.0;

                case Enums.UTC.Plus0800:
                    return 8.0;

                case Enums.UTC.Plus0845:
                    return 8.75;

                case Enums.UTC.Plus0900:
                    return 9.0;

                case Enums.UTC.Plus0930:
                    return 9.5;

                case Enums.UTC.Plus1000:
                    return 10.0;

                case Enums.UTC.Plus1030:
                    return 10.5;

                case Enums.UTC.Plus1100:
                    return 11.0;

                case Enums.UTC.Plus1200:
                    return 12.0;

                case Enums.UTC.Plus1245:
                    return 12.75;

                case Enums.UTC.Plus1300:
                    return 13.0;

                case Enums.UTC.Plus1400:
                    return 14.0;

                case Enums.UTC.Undefined:
                    break;

                default:
                    break;
            }

            return double.NaN;
        }
    }
}