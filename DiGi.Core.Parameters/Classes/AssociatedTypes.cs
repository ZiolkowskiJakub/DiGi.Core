using DiGi.Core.Interfaces;
using System;
using System.Collections;
using System.Linq;
using System.Text.Json.Nodes;

namespace DiGi.Core.Parameters
{
    [AttributeUsage(AttributeTargets.Enum, AllowMultiple = false)]
    public class AssociatedTypes : Attribute, IEnumerable, ISerializableObject
    {
        private Type[] types;

        public AssociatedTypes(params Type[] values)
        {
            types = values;
        }

        public AssociatedTypes(JsonObject jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        public AssociatedTypes(AssociatedTypes associatedTypes)
        {
            if(associatedTypes != null)
            {
                types = associatedTypes.Types?.ToArray();
            }
        }

        public Type[] Types
        {
            get
            {
                return types?.ToArray();
            }
        }

        public virtual ISerializableObject Clone()
        {
            return new AssociatedTypes(types);
        }

        public virtual bool FromJsonObject(JsonObject jsonObject)
        {
            if(jsonObject == null)
            {
                return false;
            }

            if(jsonObject.ContainsKey("Types"))
            {
                types = Create.Types((JsonArray)jsonObject["Types"])?.ToArray();
            }

            return true;
        }

        public IEnumerator GetEnumerator()
        {
            return types?.GetEnumerator();
        }

        public virtual bool IsValid(Type type)
        {
            if (types == null || types.Length == 0)
            {
                return false;
            }

            foreach (Type type_Temp in types)
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

        public virtual JsonObject ToJsonObject()
        {
            JsonObject result = new JsonObject();
            result[Core.Constans.Serialization.PropertyName.Type] = Core.Query.FullTypeName(GetType());

            if(types != null)
            {
                result["Types"] = Create.JsonArray(types);
            }

            return result;
        }
    }
}
