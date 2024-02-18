﻿using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class UniqueObject : SerializableObject, IUniqueObject
    {
        [JsonInclude, JsonPropertyName("Guid")]
        private Guid guid;

        public UniqueObject()
            : base()
        {
            this.guid = Guid.NewGuid();
        }

        public UniqueObject(Guid guid)
            :base()
        {
            this.guid = guid;
        }

        public UniqueObject(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        [JsonIgnore]
        public Guid Guid
        {
            get
            {
                return guid;
            }
        }
    }
}
