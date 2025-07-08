using DiGi.Core.Enums;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static UTC UTC(float timeOffset)
        {
            return UTC(System.Convert.ToDouble(timeOffset));
        }

        public static UTC UTC(double timeOffset)
        {
            if (double.IsNaN(timeOffset))
            {
                return Enums.UTC.Undefined;
            }

            foreach(UTC uTC in System.Enum.GetValues(typeof(UTC)))
            {
                double timeOffset_Temp = uTC.TimeOffset();
                if(timeOffset.Equals(timeOffset_Temp))
                {
                    return uTC;
                }
            }

            return Enums.UTC.Undefined;
        }

        public static UTC UTC(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return Enums.UTC.Undefined;
            }

            if (Enums.UTC.Undefined.ToString().ToUpper().Equals(value.ToUpper().Trim()))
            {
                return Enums.UTC.Undefined;
            }

            UTC result = Query.Enum<UTC>(value);
            if (result != Enums.UTC.Undefined)
            {
                return result;
            }

            if (Query.TryConvert(value, out double timeOffset))
            {
                result = UTC(timeOffset);
                if (result != Enums.UTC.Undefined)
                {
                    return result;
                }
            }

            return Enums.UTC.Undefined;
        }
    }
}
