using DiGi.Core.Interfaces;
using System.Reflection;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public class SerializationConstructor
    {
        private readonly ConstructorInfo? constructorInfo;
        private readonly string? fullTypeName;

        internal SerializationConstructor(string? fullTypeName, ConstructorInfo? constructorInfo)
        {
            this.fullTypeName = fullTypeName;
            this.constructorInfo = constructorInfo;
        }

        public T? Create<T>(JsonObject? jsonObject) where T : ISerializableObject
        {
            if (jsonObject == null || constructorInfo == null)
            {
                return default;
            }


            ParameterInfo[] parameterInfos = constructorInfo.GetParameters();
            parameterInfos ??= [];

            if (parameterInfos.Length > 1)
            {
                return default;
            }

            T? result = default;

            if (parameterInfos.Length != 0 && parameterInfos[0].ParameterType == typeof(JsonObject))
            {
                object @object = constructorInfo.Invoke([jsonObject]);
                if (@object is not T)
                {
                    return result;
                }

                result = (T)@object;
            }
            else
            {
                object @object = constructorInfo.Invoke([]);
                if (@object is not T)
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
