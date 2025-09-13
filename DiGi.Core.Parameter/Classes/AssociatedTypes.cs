using DiGi.Core.Interfaces;
using System;
using System.Collections;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    [AttributeUsage(AttributeTargets.Enum, AllowMultiple = false)]
    public class AssociatedTypes : Attribute, IEnumerable, ISerializableObject
    {
        [JsonInclude, JsonPropertyName("Types")]
        private readonly Type[]? types;

        public AssociatedTypes(params Type[]? values)
        {
            types = values;
        }

        public AssociatedTypes(JsonObject? jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        public AssociatedTypes(AssociatedTypes? associatedTypes)
        {
            if(associatedTypes != null)
            {
                types = associatedTypes.Types?.ToArray();
            }
        }

        [JsonIgnore]
        public Type[]? Types
        {
            get
            {
                return types?.ToArray();
            }
        }

        public virtual ISerializableObject? Clone()
        {
            return new AssociatedTypes(types);
        }

        public virtual bool FromJsonObject(JsonObject? jsonObject)
        {
            return Modify.FromJsonObject(this, jsonObject);
        }

        public IEnumerator GetEnumerator()
        {
            if(types == null)
            {
                return Enumerable.Empty<Type>().GetEnumerator();
            }

            return types.GetEnumerator();
        }

        public virtual bool IsValid(Type? type)
        {
            if (types == null || types.Length == 0 || type == null)
            {
                return false;
            }

            foreach (Type? type_Temp in types)
            {
                if (type_Temp == null)
                {
                    continue;
                }

                if (type.Equals(type_Temp))
                {
                    return true;
                }

                if (type.IsAssignableFrom(type_Temp))
                {
                    return true;
                }
            }

            return false;
        }

        public virtual JsonObject? ToJsonObject()
        {
            return Convert.ToJson(this);
        }
    }
}
