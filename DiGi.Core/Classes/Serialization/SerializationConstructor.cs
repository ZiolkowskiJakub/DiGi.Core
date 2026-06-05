using DiGi.Core.Interfaces;
using System.Reflection;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Encapsulates logic to instantiate an ISerializableObject from a JsonObject, supporting both parameterless and JSON-aware constructors.
    /// </summary>
    public class SerializationConstructor
    {
        private readonly ConstructorInfo? constructorInfo;
        private readonly string? fullTypeName;

        internal SerializationConstructor(string? fullTypeName, ConstructorInfo? constructorInfo)
        {
            this.fullTypeName = fullTypeName;
            this.constructorInfo = constructorInfo;
        }

        /// <summary>
        /// Creates an instance of the serializable object from a JsonObject.
        /// </summary>
        /// <typeparam name="T">The type of the object to create.</typeparam>
        /// <param name="jsonObject">The JSON object used to populate the created instance.</param>
        /// <returns>The created instance of type <typeparam ref="T"/>, or null if creation fails.</returns>
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