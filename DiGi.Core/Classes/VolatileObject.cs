using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class VolatileObject<T> : ISerializableObject where T: ISerializableObject
    {
        protected T @object;

        public VolatileObject(T @object)
            : base()
        {
            this.@object = Query.Clone(@object);
        }

        public VolatileObject(VolatileObject<T> volatileObject)
            : base()
        {
            if (volatileObject != null && volatileObject.@object != null)
            {
                @object = volatileObject.@object.Clone<T>();
            }
        }

        public VolatileObject(JsonObject jsonObject)
        {
            @object = Create.SerializableObject<T>(jsonObject);
        }

        [JsonInclude, JsonPropertyName(Constans.Serialization.PropertyName.Type)]
        private string fullTypeName => Query.FullTypeName(GetType());
        
        public static implicit operator T(VolatileObject<T> volatileObject)
        {
            if (volatileObject == null)
            {
                return default;
            }

            return Query.Clone(volatileObject.@object);
        }

        public abstract ISerializableObject Clone();

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj is T)
            {
                return obj.GetHashCode() == @object?.GetHashCode();
            }

            VolatileObject<T> volatileObject = obj as VolatileObject<T>;
            if (volatileObject == null)
            {
                return false;
            }

            return GetHashCode() == volatileObject.GetHashCode();
        }

        public virtual bool FromJsonObject(JsonObject jsonObject)
        {
            return Modify.FromJsonObject(@object, jsonObject);
        }

        public override int GetHashCode()
        {
            return @object.GetHashCode();
        }

        public virtual JsonObject ToJsonObject()
        {
            return Convert.ToJson(@object);
        }
        
        public override string ToString()
        {
            return @object.ToString();
        }
    }
}
