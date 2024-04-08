using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System;
using System.Reflection;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static SerializationMethodCollection SerializationMethodCollection(this Type type)
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

            List<MemberInfo> memberInfos = Query.SerializableMemberInfos(type);
            if (memberInfos == null || memberInfos.Count == 0)
            {
                return new SerializationMethodCollection(fullTypeName);
            }

            List<Tuple<MemberInfo, string>> tuples = new List<Tuple<MemberInfo, string>>();
            List<Tuple<MemberInfo, string, int>> tuples_Order = new List<Tuple<MemberInfo, string, int>>();
            for (int i = 0; i < memberInfos.Count; i++)
            {
                MemberInfo memberInfo = memberInfos[i];

                int? order = Query.SerializableOrder(memberInfo);
                string name = Query.SerializableName(memberInfo);

                if (order == null || !order.HasValue)
                {
                    tuples.Add(new Tuple<MemberInfo, string>(memberInfo, name));
                }
                else
                {
                    tuples_Order.Add(new Tuple<MemberInfo, string, int>(memberInfo, name, order.Value));
                }
            }

            if (tuples_Order != null && tuples_Order.Count != 0)
            {
                tuples_Order.Sort((x, y) => x.Item3.CompareTo(y.Item3));

                for (int i = tuples_Order.Count - 1; i >= 0; i--)
                {
                    tuples.Insert(0, new Tuple<MemberInfo, string>(tuples_Order[i].Item1, tuples_Order[i].Item2));
                }
            }

            List<SerializationMethod> serializationMethods = new List<SerializationMethod>();
            for (int i = 0; i < tuples.Count; i++)
            {
                serializationMethods.Add(new SerializationMethod(tuples[i].Item1, tuples[i].Item2));
            }

            return new SerializationMethodCollection(fullTypeName, serializationMethods);
        }
    }
}
