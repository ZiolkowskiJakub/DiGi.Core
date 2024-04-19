using DiGi.Core.Interfaces;
using System.Reflection;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public class SerializationConstructor
    {
        private string fullTypeName;
        private ConstructorInfo constructorInfo;

        internal SerializationConstructor(string fullTypeName, ConstructorInfo constructorInfo)
        {
            this.fullTypeName = fullTypeName;
            this.constructorInfo = constructorInfo;
        }

        public T Create<T>(JsonObject jsonObject) where T : ISerializableObject
        {
            if(jsonObject == null || constructorInfo == null)
            {
                return default;
            }


            ParameterInfo[] parameterInfos = constructorInfo.GetParameters();
            parameterInfos = parameterInfos == null ? new ParameterInfo[0] : parameterInfos;

            if(parameterInfos.Length > 1)
            {
                return default;
            }

            T result = default;

            if(parameterInfos.Length != 0 && parameterInfos[0].ParameterType == typeof(JsonObject))
            {
                object @object = constructorInfo.Invoke(new object[] { jsonObject });
                if(!(@object is T))
                {
                    return result;
                }

                result = (T) @object;
            }
            else
            {
                object @object = constructorInfo.Invoke(new object[] { });
                if (!(@object is T))
                {
                    return result;
                }

                result = (T)@object;

                Modify.FromJsonObject(result, jsonObject);
            }

            return result;
        }


    }
}
