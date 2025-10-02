using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class Value<TObject> : SerializableObject, IValue<TObject>
    {
        [JsonInclude, JsonPropertyName(Constans.Serialization.PropertyName.Value)]
        protected TObject? value;

        public Value(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        protected Value(TObject? value)
        {
            this.value = value;
        }

        protected Value(Value<TObject>? value)
        {
            if(value is not null)
            {
                this.value = value.value;
            }
        }
        TObject? IValue<TObject>.Value => value;

        [JsonInclude, JsonPropertyName(Constans.Serialization.PropertyName.ValueType)]
        public Type? ValueType
        {
            get
            {
                return value?.GetType();
            }
        }
        public override bool FromJsonObject(JsonObject? jsonObject)
        {
            return base.FromJsonObject(jsonObject);
        }

        public XObject? GetValue<XObject>() where XObject : TObject
        {
            if (value is XObject)
            {
                return (XObject)value;
            }

            return default;
        }

        public override JsonObject? ToJsonObject()
        {
            return base.ToJsonObject();
        }
    }

    public class Value : Value<object>
    {
        public Value(Value? value)
            : base(value)
        {

        }

        public Value(double value)
            : base(value)
        {

        }

        public Value(DateTime value)
            : base(value)
        {

        }

        public Value(int value)
            : base(value)
        {

        }

        public Value(byte value)
            : base(value)
        {

        }

        public Value(float value)
            : base(value)
        {

        }

        public Value(long value)
            : base(value)
        {

        }

        public Value(Guid value)
            : base(value)
        {

        }

        public Value(string? value)
            : base(value)
        {

        }

        public Value(string[]? value)
            : base(value)
        {

        }

        public Value(double[]? value)
            : base(value)
        {

        }

        public Value(long[]? value)
            : base(value)
        {

        }

        public Value(Guid[]? value)
            : base(value)
        {

        }

        public Value(int[]? value)
            : base(value)
        {

        }

        public Value(byte[]? value)
            : base(value)
        {

        }

        public Value(DateTime[]? value)
            : base(value)
        {

        }

        public Value(float[]? value)
            : base(value)
        {

        }

        public Value(ISerializableObject? value)
            : base(value)
        {

        }

        public Value(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        protected Value(object? value)
                                                                                                                                                                    : base(value)
        {

        }
        public override ISerializableObject? Clone()
        {
            return new Value(value);
        }
    }
}
