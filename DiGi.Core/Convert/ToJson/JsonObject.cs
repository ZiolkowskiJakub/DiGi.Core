using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json.Nodes;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;

namespace DiGi.Core
{
    public static partial class Convert
    {
        public static JsonObject ToJson(this ISerializableObject serializableObject)
        {
            if (serializableObject == null)
            {
                return null;
            }

            SerializationMethodCollection serializationMethodCollection = Settings.SerializationManager.GetSerializationMethodCollection(serializableObject);
            if(serializationMethodCollection == null)
            {
                return null;
            }

            return serializationMethodCollection.Create(serializableObject);

            //serializationMethodCollection.U


            //JsonObject result = new JsonObject();

            //Type type = serializableObject.GetType();

            //List<MemberInfo> memberInfos = Query.SerializableMemberInfos(type);
            //if (memberInfos == null || memberInfos.Count == 0)
            //{
            //    return result;
            //}

            //List<Tuple<MemberInfo, string>> tuples = new List<Tuple<MemberInfo, string>>();
            //List<Tuple<MemberInfo, string, int>> tuples_Order = new List<Tuple<MemberInfo, string, int>>();
            //for (int i = 0; i < memberInfos.Count; i++)
            //{
            //    MemberInfo memberInfo = memberInfos[i];

            //    int? order = Query.SerializableOrder(memberInfo);
            //    string name = Query.SerializableName(memberInfo);

            //    if (order == null || !order.HasValue)
            //    {
            //        tuples.Add(new Tuple<MemberInfo, string>(memberInfo, name));
            //    }
            //    else
            //    {
            //        tuples_Order.Add(new Tuple<MemberInfo, string, int>(memberInfo, name, order.Value));
            //    }
            //}

            //if (tuples_Order != null && tuples_Order.Count != 0)
            //{
            //    tuples_Order.Sort((x, y) => x.Item3.CompareTo(y.Item3));

            //    for (int i = tuples_Order.Count - 1; i >= 0; i--)
            //    {
            //        tuples.Insert(0, new Tuple<MemberInfo, string>(tuples_Order[i].Item1, tuples_Order[i].Item2));
            //    }
            //}

            //foreach (Tuple<MemberInfo, string> tuple in tuples)
            //{
            //    object value = null;

            //    if (tuple.Item1 is PropertyInfo)
            //    {
            //        PropertyInfo propertyInfo = (PropertyInfo)tuple.Item1;
            //        MethodInfo methodInfo = propertyInfo.GetMethod;
            //        if (methodInfo == null)
            //        {
            //            continue;
            //        }

            //        ParameterInfo[] parameterInfos = methodInfo.GetParameters();
            //        if (parameterInfos != null && parameterInfos.Length > 0)
            //        {
            //            continue;
            //        }

            //        value = propertyInfo.GetValue(serializableObject);
            //    }
            //    else if (tuple.Item1 is FieldInfo)
            //    {
            //        FieldInfo fieldInfo = (FieldInfo)tuple.Item1;
            //        value = fieldInfo.GetValue(serializableObject);
            //    }

            //    result[tuple.Item2] = Create.JsonNode(value);
            //}

            //return result;
        }
    }
}
