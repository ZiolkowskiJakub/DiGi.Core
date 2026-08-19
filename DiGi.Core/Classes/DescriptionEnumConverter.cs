using System;
using System.ComponentModel;
using System.Globalization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Type converter for enum types that resolves a string by member name or by the text of the member's <see cref="DescriptionAttribute"/>.
    /// <para>Attach it with <c>[TypeConverter(typeof(DescriptionEnumConverter))]</c> on the enum. ASP.NET Core binds query, route and form values through <see cref="TypeDescriptor"/>, so the attribute makes the description an accepted input token wherever the enum is bound - without renaming the member, and without changing how the value is written (enums still travel as their underlying integer). Anything the description matching does not resolve, including numeric text, is handed to <see cref="EnumConverter"/> and behaves exactly as before.</para>
    /// <para>Matching is delegated to <see cref="Query.TryGetEnum(string, Type, out Enum)"/>, the same matcher DiGi JSON deserialization uses, and walks the members in value order testing each member's name and then its description. Do <b>not</b> attach it to an enum where one member's description equals a different member's name - the member declared with the lower value would win.</para>
    /// </summary>
    public class DescriptionEnumConverter : EnumConverter
    {
        /// <summary>
        /// Initializes a new instance of the DescriptionEnumConverter class for the specified enum type.
        /// </summary>
        /// <param name="type">The enum type this converter is attached to. <see cref="TypeDescriptor"/> supplies it when the converter is created from a <see cref="TypeConverterAttribute"/>.</param>
        public DescriptionEnumConverter(Type type)
            : base(type)
        {
        }

        /// <summary>
        /// Converts the given value to an enum member of the converter's type.
        /// </summary>
        /// <param name="context">The format context.</param>
        /// <param name="culture">The culture used for the conversion.</param>
        /// <param name="value">The value to convert.</param>
        /// <returns>The enum member the value resolves to.</returns>
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string text && Query.TryGetEnum(text, EnumType, out Enum? @enum) && @enum is not null)
            {
                return @enum;
            }

            return base.ConvertFrom(context, culture, value);
        }
    }
}
