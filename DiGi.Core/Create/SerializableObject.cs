﻿using System.Text.Json.Nodes;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;


namespace DiGi.Core
{
    public static partial class Create
    {
        public static T SerializableObject<T>(this JsonObject jsonObject) where T : ISerializableObject
        {
            if (jsonObject == null)
            {
                return default;
            }

            string fullTypeName = Query.FullTypeName(jsonObject);
            if (string.IsNullOrWhiteSpace(fullTypeName))
            {
                return default;
            }

            SerializationConstructor serializationConstructor = Settings.SerializationManager.GetSerializationConstructor(fullTypeName);
            if (serializationConstructor == null)
            {
                return default;
            }

            return serializationConstructor.Create<T>(jsonObject);
        }
    }
}