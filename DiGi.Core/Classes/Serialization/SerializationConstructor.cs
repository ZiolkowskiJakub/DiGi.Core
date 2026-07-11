using DiGi.Core.Interfaces;
using System;
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
        private readonly bool jsonObjectParameter;
        private readonly bool valid;

        internal SerializationConstructor(string? fullTypeName, ConstructorInfo? constructorInfo)
        {
            this.fullTypeName = fullTypeName;
            this.constructorInfo = constructorInfo;

            if (constructorInfo != null)
            {
                ParameterInfo[] parameterInfos = constructorInfo.GetParameters();
                if (parameterInfos.Length == 0)
                {
                    valid = true;
                }
                else if (parameterInfos.Length == 1 && parameterInfos[0].ParameterType == typeof(JsonObject))
                {
                    valid = true;
                    jsonObjectParameter = true;
                }
            }
        }

        /// <summary>
        /// Gets the full type name of the type instantiated by this constructor.
        /// </summary>
        public string? FullTypeName
        {
            get
            {
                return fullTypeName;
            }
        }

        /// <summary>
        /// Creates an instance of the serializable object from a JsonObject.
        /// </summary>
        /// <typeparam name="T">The type of the object to create.</typeparam>
        /// <param name="jsonObject">The JSON object used to populate the created instance.</param>
        /// <returns>The created instance of type <typeparam ref="T"/>, or null if creation fails.</returns>
        public T? Create<T>(JsonObject? jsonObject) where T : ISerializableObject
        {
            if (jsonObject == null || constructorInfo == null || !valid)
            {
                return default;
            }

            if (jsonObjectParameter)
            {
                if (constructorInfo.Invoke([jsonObject]) is not T result)
                {
                    return default;
                }

                return result;
            }

            if (constructorInfo.Invoke(Array.Empty<object>()) is not T result_Parameterless)
            {
                return default;
            }

            Modify.FromJsonObject(result_Parameterless, jsonObject);

            return result_Parameterless;
        }
    }
}