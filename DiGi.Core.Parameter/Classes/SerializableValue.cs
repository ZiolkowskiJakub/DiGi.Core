namespace DiGi.Core.Parameter.Classes
{
    public readonly struct SerializableValue
    {
        private readonly object? value;

        private SerializableValue(object? value)
        {
            this.value = value;
        }

        public static implicit operator SerializableValue?(string? value)
        {
            return new SerializableValue(value);
        }

        public static implicit operator string?(SerializableValue? serializableValue)
        {
            if (serializableValue == null)
            {
                return null;
            }

            return serializableValue.Value.value as string;
        }

        public static bool operator !=(SerializableValue? serializableValue_1, SerializableValue? serializableValue_2)
        {
            if (serializableValue_1 is null && serializableValue_2 is null)
            {
                return false;
            }

            if (serializableValue_1 is null || serializableValue_2 is null)
            {
                return true;
            }

            return serializableValue_1.Value.value != serializableValue_2.Value.value;
        }

        public static bool operator ==(SerializableValue? serializableValue_1, SerializableValue? serializableValue_2)
        {
            if (serializableValue_1 is null && serializableValue_2 is null)
            {
                return true;
            }

            if (serializableValue_1 is null || serializableValue_2 is null)
            {
                return false;
            }

            return serializableValue_1.Value.value == serializableValue_2.Value.value;
        }

        public override readonly bool Equals(object? obj)
        {
            if (obj is SerializableValue serializableValue)
            {
                return serializableValue.GetHashCode() == GetHashCode();
            }

            return false;
        }

        public override readonly int GetHashCode()
        {
            return value?.GetHashCode() ?? -1;
        }
    }
}