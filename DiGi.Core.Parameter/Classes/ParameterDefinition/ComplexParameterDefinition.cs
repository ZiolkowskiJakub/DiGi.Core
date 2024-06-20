using DiGi.Core.Parameter.Enums;
using System.Text.Json.Nodes;

namespace DiGi.Core.Parameter.Classes
{
    public abstract class ComplexParameterDefinition : ParameterDefinition
    {
        public ComplexParameterDefinition(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ComplexParameterDefinition(ComplexParameterDefinition complexParameterDefinition)
            : base(complexParameterDefinition)
        {

        }

        public ComplexParameterDefinition()
            : base()
        {

        }

        public abstract string Description { get; }

        public abstract ParameterValue ParameterValue { get; }

        public abstract AssociatedTypes AssociatedTypes { get; }

        public abstract AccessType AccessType { get; }

        public override ParameterType ParameterType
        {
            get
            {
                ParameterValue parameterValue = ParameterValue;

                if(parameterValue == null)
                {
                    return ParameterType.Undefined;
                }

                return parameterValue.ParameterType;
            }
        }

        public override bool IsValid(object value)
        {
            bool result = base.IsValid(value);
            if (!result)
            {
                return result;
            }

            ParameterValue parameterValue = ParameterValue;
            if(parameterValue != null)
            {
                result = parameterValue.IsValid(value);
            }

            return result;
        }

    }
}
