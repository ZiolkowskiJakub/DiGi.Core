using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public abstract class VolatileObject<T> : ISerializableObject where T: ISerializableObject
    {
        protected T @object; 

        public VolatileObject(T @object)
            :base()
        {
            this.@object = @object; 
        }

        public VolatileObject(VolatileObject<T> volatileObject)
            : base()
        {
            if(volatileObject != null && volatileObject.@object != null)
            {
                @object = volatileObject.@object.Clone<T>();
            }
        }

        public VolatileObject(JsonObject jsonObject) 
        {
            @object = Create.SerializableObject<T>(jsonObject);
        }

        public virtual bool FromJsonObject(JsonObject jsonObject)
        {
            return Modify.FromJsonObject(@object, jsonObject);
        }

        public virtual JsonObject ToJsonObject()
        {
            return Convert.ToJson(@object);
        }

        public abstract ISerializableObject Clone();

        public static implicit operator T(VolatileObject<T> volatileObject)
        {
            if (volatileObject == null)
            {
                return default;
            }

            return Query.Clone(volatileObject.@object);
        }
    }
}
