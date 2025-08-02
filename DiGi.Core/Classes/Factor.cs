using DiGi.Core.Interfaces;
using System;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public struct Factor : IObject, ISerializableObject
    {
        [JsonInclude, JsonPropertyName("Value"), Description("Value [0-1]")]
        private double value = double.NaN;

        public Factor()
        {

        }
        
        public Factor(double value)
        {
            this.value = double.IsNaN(value) ? double.NaN : Query.Clamp(value, 0, 1);
        }

        public Factor(Factor factor)
        {
            value = factor.value;
        }

        public Factor(JsonObject jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        public static implicit operator double(Factor factor)
        {
            return factor.value;
        }

        public static implicit operator Factor(double value)
        {

            return new Factor(value);
        }

        public static implicit operator Factor(float value)
        {

            return new Factor(System.Convert.ToDouble(value));
        }

        public static implicit operator float(Factor factor)
        {
            return System.Convert.ToSingle(factor.value);
        }

        public ISerializableObject Clone()
        {
            return new Factor(value);
        }

        public bool FromJsonObject(JsonObject jsonObject)
        {
            return Modify.FromJsonObject(this, jsonObject);
        }

        public JsonObject ToJsonObject()
        {
            return Convert.ToJson(this);
        }
    }
}
