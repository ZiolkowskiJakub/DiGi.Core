using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Reflection;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static SerializationConstructor SerializationConstructor(this System.Type type)
        {
            if (type == null || !typeof(ISerializableObject).IsAssignableFrom(type))
            {
                return null;
            }

            string fullTypeName = Query.FullTypeName(type);
            if (string.IsNullOrWhiteSpace(fullTypeName))
            {
                return null;
            }

            ConstructorInfo constructorInfo = null;
            ConstructorInfo constructorInfo_Empty = null;

            ConstructorInfo[] constructorInfos = null;

            constructorInfos = type.GetConstructors();
            if (constructorInfos != null && constructorInfos.Length != 0)
            {
                for (int i = 0; i < constructorInfos.Length; i++)
                {
                    ConstructorInfo constructorInfo_Temp = constructorInfos[i];

                    ParameterInfo[] parameterInfos = constructorInfo_Temp.GetParameters();
                    if (parameterInfos == null || parameterInfos.Length == 0)
                    {
                        constructorInfo_Empty = constructorInfo_Temp;
                        continue;
                    }

                    if (parameterInfos.Length == 1 && parameterInfos[0].ParameterType == typeof(JsonObject))
                    {
                        constructorInfo = constructorInfo_Temp;
                        break;
                    }
                }
            }

            if(constructorInfo == null)
            {
                constructorInfos = type.GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance);
                if (constructorInfos != null && constructorInfos.Length != 0)
                {
                    for (int i = 0; i < constructorInfos.Length; i++)
                    {
                        ConstructorInfo constructorInfo_Temp = constructorInfos[i];

                        ParameterInfo[] parameterInfos = constructorInfo_Temp.GetParameters();
                        if (parameterInfos == null || parameterInfos.Length == 0)
                        {
                            if(constructorInfo_Empty == null)
                            {
                                constructorInfo_Empty = constructorInfo_Temp;
                            }

                            continue;
                        }

                        if (parameterInfos.Length == 1 && parameterInfos[0].ParameterType == typeof(JsonObject))
                        {
                            constructorInfo = constructorInfo_Temp;
                            break;
                        }
                    }
                }
            }

            if(constructorInfo == null && constructorInfo_Empty != null)
            {
                constructorInfo = constructorInfo_Empty;
            }

            if(constructorInfo == null)
            {
                return null;
            }

            return new SerializationConstructor(fullTypeName, constructorInfo);
        }
    }
}
