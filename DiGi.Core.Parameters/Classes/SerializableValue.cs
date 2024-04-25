namespace DiGi.Core.Parameters
{
    public struct SerializableValue
    {
        private object value;

        private SerializableValue(object value)
        {
            this.value = value;
        }

        public static implicit operator SerializableValue(string value)
        {
            return new SerializableValue(value);
        }


        public static implicit operator string(SerializableValue serializableValue)
        {
            return serializableValue.value as string;
        }

        public static bool operator !=(SerializableValue serializableValue_1, SerializableValue serializableValue_2)
        {
            if (ReferenceEquals(serializableValue_1, null) && ReferenceEquals(serializableValue_2, null))
            {
                return false;
            }

            if (ReferenceEquals(serializableValue_1, null) || ReferenceEquals(serializableValue_2, null))
            {
                return true;
            }

            return serializableValue_1.value != serializableValue_2.value;
        }

        public static bool operator ==(SerializableValue serializableValue_1, SerializableValue serializableValue_2)
        {
            if (ReferenceEquals(serializableValue_1, null) && ReferenceEquals(serializableValue_2, null))
            {
                return true;
            }

            if (ReferenceEquals(serializableValue_1, null) || ReferenceEquals(serializableValue_2, null))
            {
                return false;
            }

            return serializableValue_1.value == serializableValue_2.value;
        }
    }
}
