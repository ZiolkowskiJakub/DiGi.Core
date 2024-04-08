using System.Text.Json.Nodes;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;


namespace DiGi.Core
{
    public static partial class Modify
    {
        public static bool FromJsonObject(this ISerializableObject serializableObject, JsonObject jsonObject)
        {
            if(serializableObject == null || jsonObject == null)
            {
                return false;
            }

            SerializationMethodCollection serializationMethodCollection = Settings.SerializationManager.GetSerializationMethodCollection(serializableObject);
            if (serializationMethodCollection == null )
            {
                return false;
            }

            return serializationMethodCollection.Update(serializableObject, jsonObject);


            //Type type = serializableObject.GetType();

            //List<MemberInfo> memberInfos = Query.SerializableMemberInfos(type);
            //if(memberInfos == null || memberInfos.Count == 0)
            //{
            //    return false;
            //}

            //List<Tuple<string, MemberInfo>> tuples = new List<Tuple<string, MemberInfo>>();
            //for(int i =0; i < memberInfos.Count; i++)
            //{
            //    tuples.Add(new Tuple<string, MemberInfo>(Query.SerializableName(memberInfos[i]), memberInfos[i]));
            //}

            //foreach(KeyValuePair<string, JsonNode> keyValuePair in jsonObject)
            //{
            //    List<MemberInfo> memberInfos_Name = tuples.FindAll(x => x.Item1 == keyValuePair.Key).ConvertAll(x => x.Item2);
            //    if(memberInfos_Name == null || memberInfos_Name.Count == 0 )
            //    {
            //        continue;
            //    }

            //    JsonNode jsonNode = keyValuePair.Value;

            //    for (int i = 0; i < memberInfos_Name.Count; i++)
            //    {
            //        MemberInfo memberInfo = memberInfos_Name[i];

            //        if (memberInfo is PropertyInfo)
            //        {
            //            PropertyInfo propertyInfo = (PropertyInfo)memberInfo;
            //            if(propertyInfo.SetMethod == null)
            //            {
            //                continue;
            //            }

            //            Type valueType = propertyInfo.PropertyType;

            //            propertyInfo.SetValue(serializableObject, jsonNode.Value(propertyInfo.PropertyType));
            //        }
            //        else if (memberInfo is FieldInfo)
            //        {
            //            FieldInfo fieldInfo = (FieldInfo)memberInfo;
                        
            //            fieldInfo.SetValue(serializableObject, jsonNode.Value(fieldInfo.FieldType));
            //        }
            //    }
            //}

            //return true;
        }
    }
}
