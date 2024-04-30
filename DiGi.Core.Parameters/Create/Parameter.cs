using DiGi.Core.Parameters.Interfaces;

namespace DiGi.Core.Parameters
{
    public static partial class Create
    {
        public static Parameter Parameter(this IParameterDefinition parameterDefinition, object value, SetValueSettings setValueSettings = null)
        {
            if(parameterDefinition == null)
            {
                return null;
            }

            Parameter result = new Parameter(parameterDefinition);
            if(!result.SetValue(value, setValueSettings))
            {
                return null;
            }

            return result;
        }

        public static Parameter Parameter(string name, object value)
        {
            if(name == null)
            {
                return null;
            }

            SimpleParameterDefinition simpleParameterDefinition  = new SimpleParameterDefinition(name);
            if(simpleParameterDefinition == null || !simpleParameterDefinition.IsValid(value))
            {
                return null;
            }

            return new Parameter(simpleParameterDefinition, value);
        }
    }

}
