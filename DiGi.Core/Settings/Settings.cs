using DiGi.Core.Classes;

namespace DiGi.Core
{
    public static partial class Settings
    {
        public static SerializationManager SerializationManager { get; } = new SerializationManager();

        public static ConversionManager ConversionManager { get; } = new ConversionManager();
    }
}