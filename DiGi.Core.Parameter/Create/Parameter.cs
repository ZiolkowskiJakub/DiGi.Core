using DiGi.Core.Parameter.Interfaces;
using DiGi.Core.Parameter.Classes;

namespace DiGi.Core.Parameter
{
    public static partial class Create
    {
        public static Classes.Parameter Parameter(this IParameterDefinition parameterDefinition, object value, SetValueSettings setValueSettings = null)
        {
            if(parameterDefinition == null)
            {
                return null;
            }

            Classes.Parameter result = new Classes.Parameter(parameterDefinition);
            if(!result.SetValue(value, setValueSettings))
            {
                return null;
            }

            return result;
        }

        public static Classes.Parameter Parameter(string name, object value)
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

            return new Classes.Parameter(simpleParameterDefinition, value);
        }
    }

}
