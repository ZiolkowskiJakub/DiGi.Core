using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    public class ObjectParameterValue : ParameterValue
    {
        [JsonInclude, JsonPropertyName("Inheritance")]
        private readonly bool inheritance = true;

        [JsonInclude, JsonPropertyName("Types")]
        private readonly Type[]? types;

        public ObjectParameterValue()
            : base()
        {

        }

        public ObjectParameterValue(bool nullable, bool inheritance, params Type[] types)
            : base(nullable)
        {
            this.types = types?.ToArray();
            this.inheritance = inheritance;
        }

        public ObjectParameterValue(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public ObjectParameterValue(ObjectParameterValue? objectParameterValue)
            : base(objectParameterValue)
        {
            if (objectParameterValue != null)
            {
                inheritance = objectParameterValue.inheritance;
                types = objectParameterValue.types?.ToArray();
            }

        }

        [JsonIgnore]
        public override ParameterType ParameterType => ParameterType.Object;

        public override ISerializableObject? Clone()
        {
            return new ObjectParameterValue(this);
        }

        public override bool IsValid(object? value)
        {
            bool result = base.IsValid(value);
            if (!result)
            {
                return result;
            }

            Type? type = value?.GetType();
            if (type == null)
            {
                return true;
            }

            if (types == null || types.Length == 0)
            {
                return true;
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

                if (inheritance && type_Temp.IsAssignableFrom(type))
                {
                    return true;
                }
            }

            return result;
        }

        public override bool TryConvert(object? value_In, out object? value_Out)
        {
            if (!base.TryConvert(value_In, out value_Out))
            {
                return false;
            }

            return IsValid(value_Out);
        }
    }
}
