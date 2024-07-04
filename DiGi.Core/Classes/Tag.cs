using DiGi.Core.Interfaces;
using System;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class Tag : SerializableObject
    {
        [JsonInclude, JsonPropertyName("Value"), Description("Value")]
        public object Value;

        private Tag(object value)
        {
            Value = value;
        }

        private Tag(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        private Tag()
            : base()
        {

        }

        private Tag(Tag tag)
            : base()
        {
            if(tag != null)
            {
                Value = tag.Value;
            }
        }

        public Tag(string value)
        {
            Value = value;
        }

        public Tag(double value)
        {
            Value = value;
        }

        public Tag(DateTime value)
        {
            Value = value;
        }

        public Tag(int value)
        {
            Value = value;
        }

        public Tag(ISerializableObject value)
        {
            Value = value;
        }

        public override ISerializableObject Clone()
        {
            return new Tag(Value);
        }
    }
}
