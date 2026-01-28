using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class Tag : Value
    {
        private Tag(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        private Tag(Tag? tag)
            : base(tag)
        {
        }

        private Tag(object? tag)
            : base(tag)
        {
        }

        public Tag(string? value)
            : base(value)
        {
        }

        public Tag(double value)
            : base(value)
        {
        }

        public Tag(DateTime value)
            : base(value)
        {
        }

        public Tag(bool value)
            : base(value)
        {
        }

        public Tag(int value)
            : base(value)
        {
        }

        public Tag(ISerializableObject? value)
            : base(value)
        {
        }

        [JsonIgnore]
        public object? Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }

        public override ISerializableObject? Clone()
        {
            return new Tag(Value);
        }
    }
}