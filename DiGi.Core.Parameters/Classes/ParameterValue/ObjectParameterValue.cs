using DiGi.Core.Interfaces;
using DiGi.Core.Parameters.Enums;
using System;
using System.Linq;
using System.Text.Json.Nodes;

namespace DiGi.Core.Parameters
{
    public class ObjectParameterValue : ParameterValue
    {
        private bool inheritance = true;
        private Type[] types;

        public override ParameterType ParameterType => ParameterType.Object;

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

        public ObjectParameterValue(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ObjectParameterValue(ObjectParameterValue objectParameterValue)
            : base(objectParameterValue)
        {
            if(objectParameterValue != null)
            {
                inheritance = objectParameterValue.inheritance;
                types = objectParameterValue.types?.ToArray();
            }

        }

        public override ISerializableObject Clone()
        {
            return new ObjectParameterValue(this);
        }

        public override bool FromJsonObject(JsonObject jsonObject)
        {
            bool result = base.FromJsonObject(jsonObject);
            if(!result)
            {
                return result;
            }

            if(jsonObject.ContainsKey("Inheritance"))
            {
                inheritance = (bool)jsonObject["Inheritance"];
            }

            if (jsonObject.ContainsKey("Types"))
            {
                types = Create.Types((JsonArray)jsonObject["Types"])?.ToArray();
            }

            return result;
        }

        public override JsonObject ToJsonObject()
        {
            JsonObject result = base.ToJsonObject();
            if(result == null)
            {
                return null;
            }

            if(!inheritance)
            {
                result["Inheritance"] = inheritance;
            }

            if(types != null)
            {
                result["Types"] = Create.JsonArray(types);
            }

            return result;
        }

        public override bool TryConvert(object value_In, out object value_Out)
        {
            if (!base.TryConvert(value_In, out value_Out))
            {
                return false;
            }

            return IsValid(value_Out);
        }

        public override bool IsValid(object value)
        {
            bool result = base.IsValid(value);
            if(!result)
            {
                return result;
            }

            Type type = value?.GetType();
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
    }
}
