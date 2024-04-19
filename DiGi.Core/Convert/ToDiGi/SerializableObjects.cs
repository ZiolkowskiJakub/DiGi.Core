﻿using DiGi.Core.Interfaces;
using System.Collections.Generic;

using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Convert
    {
        public static List<T> ToDiGi<T>(string json) where T : ISerializableObject
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                return null;
            }

            JsonNode jsonNode = JsonNode.Parse(json);
            if(jsonNode == null)
            {
                return null;
            }

            if(jsonNode is JsonObject)
            {
                T serializableObject = Create.SerializableObject<T>((JsonObject)jsonNode);
                if(serializableObject == null)
                {
                    return null;
                }

                return new List<T> { serializableObject };
            }

            List<T> result = null;

            if(jsonNode is JsonArray)
            {
                result = new List<T>();

                JsonArray jsonArray = (JsonArray)jsonNode;
                foreach(object @object in jsonArray)
                {
                    if(@object is JsonObject)
                    {
                        T serializableObject = Create.SerializableObject<T>((JsonObject)@object);
                        if (serializableObject == null)
                        {
                            continue;
                        }

                        result.Add(serializableObject);
                    }
                }
            }

            return result;
        }

        public static List<T> ToDiGi<T>(Classes.Path? path)
        {
            if(path == null || path.Value == null || !path.HasValue || !path.Value.IsValid())
            {
                return null;
            }

            Classes.Path path_Temp = path.Value;

            if (!path_Temp.FileExists)
            {
                return null;
            }

            string json = System.IO.File.ReadAllText(path);
            if(string.IsNullOrWhiteSpace(json))
            {
                return null;
            }

            return ToDiGi<T>(json);
        }
    }
}
