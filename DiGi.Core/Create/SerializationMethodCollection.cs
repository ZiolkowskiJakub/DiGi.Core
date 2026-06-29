using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates a serialization method collection for the specified type.</summary>
        /// <param name="type">The type for which to create the serialization method collection.</param>
        /// <returns>A <see cref="SerializationMethodCollection"/> containing the serialization methods for the specified type, or null if none are found.</returns>
        public static SerializationMethodCollection? SerializationMethodCollection(this Type? type)
        {
            if (type == null || !typeof(ISerializableObject).IsAssignableFrom(type))
            {
                return null;
            }

            string? fullTypeName = Query.FullTypeName(type);
            if (string.IsNullOrWhiteSpace(fullTypeName))
            {
                return null;
            }

            List<MemberInfo>? memberInfos = Query.SerializableMemberInfos(type);
            if (memberInfos == null || memberInfos.Count == 0)
            {
                return new SerializationMethodCollection(fullTypeName);
            }

            List<Tuple<MemberInfo, string>> tuples = [];
            List<Tuple<MemberInfo, string, int>> tuples_Order = [];
            for (int i = 0; i < memberInfos.Count; i++)
            {
                MemberInfo memberInfo = memberInfos[i];

                int? order = Query.SerializableOrder(memberInfo);
                string? name = Query.SerializableName(memberInfo);
                if (string.IsNullOrEmpty(name))
                {
                    continue;
                }

                if (order == null || !order.HasValue)
                {
                    tuples.Add(new Tuple<MemberInfo, string>(memberInfo, name!));
                }
                else
                {
                    tuples_Order.Add(new Tuple<MemberInfo, string, int>(memberInfo, name!, order.Value));
                }
            }

            if (tuples_Order != null && tuples_Order.Count != 0)
            {
                tuples_Order.Sort((x, y) => x.Item3.CompareTo(y.Item3));

                List<Tuple<MemberInfo, string>> tuples_Order_Converted = tuples_Order.ConvertAll(x => new Tuple<MemberInfo, string>(x.Item1, x.Item2));

                tuples.InsertRange(0, tuples_Order_Converted);
            }

            List<SerializationMethod> serializationMethods = [];
            for (int i = 0; i < tuples.Count; i++)
            {
                serializationMethods.Add(new SerializationMethod(tuples[i].Item1, tuples[i].Item2));
            }

            return new SerializationMethodCollection(fullTypeName, serializationMethods);
        }
    }
}