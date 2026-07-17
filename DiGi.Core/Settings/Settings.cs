using DiGi.Core.Classes;

namespace DiGi.Core
{
    /// <summary>
    /// Provides global settings and managers for the DiGi.Core library.
    /// </summary>
    public static partial class Settings
    {
        /// <summary>
        /// Gets the manager responsible for serialization tasks.
        /// </summary>
        public static SerializationManager SerializationManager { get; } = new SerializationManager();

        /// <summary>
        /// Gets the manager responsible for conversion tasks.
        /// </summary>
        public static ConversionManager ConversionManager { get; } = new ConversionManager();

        /// <summary>
        /// Gets the manager responsible for resolving reference discriminators to the factories that rebuild them.
        /// </summary>
        public static ReferenceManager ReferenceManager { get; } = new ReferenceManager();
    }
}