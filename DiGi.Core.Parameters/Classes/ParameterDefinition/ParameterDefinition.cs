using DiGi.Core.Classes;
using DiGi.Core.Parameters.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameters
{
    public abstract class ParameterDefinition : SerializableObject, IParameterDefinition
    {
        public ParameterDefinition(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ParameterDefinition(ParameterDefinition parameterDefinition)
            : base()
        {

        }

        public ParameterDefinition()
            : base()
        {

        }

        [JsonIgnore]
        public abstract string Name { get; }

        [JsonIgnore]
        public abstract Enums.ParameterType ParameterType { get; }

        [JsonIgnore]
        public abstract string UniqueId { get; }

        [JsonIgnore]
        public abstract string GroupName { get; }

        public bool Equals(IParameterDefinition? parameterDefinition)
        {
            return parameterDefinition?.UniqueId == UniqueId;
        }

        public virtual bool IsValid(object value)
        {
            return Query.IsValid(ParameterType, value);
        }
    }
}
