namespace DiGi.Core.Parameter.Enums
{
    /// <summary>
    /// Defines the type of a parameter.
    /// </summary>
    public enum ParameterType
    {
        /// <summary>Undefined</summary>
        Undefined,

        /// <summary>Double-precision floating-point number</summary>
        Double,

        /// <summary>String</summary>
        String,

        /// <summary>Globally Unique Identifier (GUID)</summary>
        Guid,

        /// <summary>General object</summary>
        Object,

        /// <summary>Integer</summary>
        Integer,

        /// <summary>Boolean</summary>
        Boolean,

        /// <summary>Date and time</summary>
        DateTime,

        /// <summary>Color value</summary>
        Color
    }
}