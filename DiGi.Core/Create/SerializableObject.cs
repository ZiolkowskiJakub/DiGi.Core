using System.Reflection;
using System.Text.Json.Nodes;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;


namespace DiGi.Core
{
    public static partial class Create
    {
        public static T SerializableObject<T>(this JsonObject jsonObject) where T: ISerializableObject
        {
            if(jsonObject == null)
            {
                return default;
            }

            string fullTypeName = Query.FullTypeName(jsonObject);
            if (string.IsNullOrWhiteSpace(fullTypeName))
            {
                return default;
            }

            SerializationConstructor serializationConstructor = Settings.SerializationManager.GetSerializationConstructor(fullTypeName);
            if(serializationConstructor == null)
            {
                return default;
            }

            return serializationConstructor.Create<T>(jsonObject);


            //string fullTypeName = Query.FullTypeName(jsonObject);
            //if(string.IsNullOrWhiteSpace(fullTypeName))
            //{
            //    return default(T);
            //}

            //System.Type type = Query.Type(fullTypeName);
            //if(type == null)
            //{
            //    return default(T);
            //}

            //if(!typeof(T).IsAssignableFrom(type))
            //{
            //    return default(T);
            //}

            //ConstructorInfo[] constructorInfos =  type.GetConstructors();
            //if(constructorInfos == null || constructorInfos.Length == 0)
            //{
            //    return default(T);
            //}

            //ConstructorInfo constructorInfo_Empty = null;

            //for(int i =0; i < constructorInfos.Length; i++)
            //{
            //    ConstructorInfo constructorInfo = constructorInfos[i];

            //    ParameterInfo[] parameterInfos = constructorInfo.GetParameters();
            //    if(parameterInfos == null || parameterInfos.Length == 0)
            //    {
            //        constructorInfo_Empty = constructorInfo;
            //        continue;
            //    }

            //    if(parameterInfos.Length == 1 && parameterInfos[0].ParameterType == typeof(JsonObject))
            //    {
            //        object @object = constructorInfo.Invoke(new object[] { jsonObject});
            //        if(@object is T)
            //        {
            //            return (T)@object;
            //        }

            //        return default(T);
            //    }
            //}

            //if(constructorInfo_Empty != null)
            //{
            //    object @object = constructorInfo_Empty.Invoke(new object[] { jsonObject });
            //    if (@object is T)
            //    {
            //        T result = (T)@object;
            //        Modify.FromJsonObject(result, jsonObject);
            //        return result;
            //    }
            //}

            //return default(T);
        }
    }
}
