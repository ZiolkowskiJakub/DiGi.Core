﻿using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Relation.Classes
{
    public abstract class OneToOneRelation : OneToOneRelation<IUniqueObject, IUniqueObject>
    {
        public OneToOneRelation(OneToOneRelation oneToOneRelation)
            : base(oneToOneRelation)
        {

        }

        public OneToOneRelation(UniqueReference uniqueReference_From, UniqueReference uniqueReference_To)
            : base(uniqueReference_From, uniqueReference_To)
        {

        }

        public OneToOneRelation(IUniqueObject uniqueObject_From, IUniqueObject uniqueObject_To)
            : base(uniqueObject_From, uniqueObject_To)
        {

        }

        public OneToOneRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }

    public abstract class OneToOneRelation<X, Y> : Relation<X, Y>, IOneToOneRelation<X, Y> where X : IUniqueObject where Y : IUniqueObject
    {
        [JsonInclude, JsonPropertyName("UniqueReference_From")]
        private UniqueReference uniqueReference_From;

        [JsonInclude, JsonPropertyName("UniqueReference_To")]
        private UniqueReference uniqueReference_To;

        public OneToOneRelation(OneToOneRelation<X, Y> oneToOneRelation)
            : base()
        {
            uniqueReference_From = oneToOneRelation.uniqueReference_From?.Clone<UniqueReference>();
            uniqueReference_To = oneToOneRelation.uniqueReference_To?.Clone<UniqueReference>();
        }

        public OneToOneRelation(UniqueReference uniqueReference_From, UniqueReference uniqueReference_To)
        {
            uniqueReference_From = uniqueReference_From?.Clone<UniqueReference>();
            uniqueReference_To = uniqueReference_To?.Clone<UniqueReference>();
        }

        public OneToOneRelation(X uniqueObject_From, Y uniqueObject_To)
        {
            uniqueReference_From = uniqueObject_From == null ? null : new GuidReference(uniqueObject_From);
            uniqueReference_To = uniqueObject_To == null ? null : new GuidReference(uniqueObject_To);
        }

        public OneToOneRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public override List<UniqueReference> UniqueReferences
        {
            get
            {
                List<UniqueReference> result = new List<UniqueReference>();
                if (uniqueReference_From != null)
                {
                    result.Add(uniqueReference_From.Clone<UniqueReference>());
                }

                if (uniqueReference_To != null)
                {
                    result.Add(uniqueReference_To.Clone<UniqueReference>());
                }

                return result;
            }
        }

        [JsonIgnore]
        public UniqueReference UniqueReference_From
        {
            get
            {
                return uniqueReference_From?.Clone<UniqueReference>();
            }
        }

        [JsonIgnore]
        public UniqueReference UniqueReference_To
        {
            get
            {
                return uniqueReference_To?.Clone<UniqueReference>();
            }
        }

        public override bool Contains_From(UniqueReference uniqueReference)
        {
            return uniqueReference_From == uniqueReference;
        }

        public override bool Contains_To(UniqueReference uniqueReference)
        {
            return uniqueReference_To == uniqueReference;
        }

        public override bool Remove(UniqueReference uniqueReference)
        {
            if (uniqueReference == null)
            {
                return false;
            }

            bool result = false;
            if (uniqueReference_From == uniqueReference)
            {
                uniqueReference_From = null;
                result = true;
            }

            if (uniqueReference_To == uniqueReference)
            {
                uniqueReference_To = null;
                result = true;
            }

            return result;
        }

        public override bool Remove_From(UniqueReference uniqueReference)
        {
            if (uniqueReference_From == uniqueReference)
            {
                uniqueReference_From = null;
                return true;
            }

            return false;
        }

        public override bool Remove_To(UniqueReference uniqueReference)
        {
            if (uniqueReference_To == uniqueReference)
            {
                uniqueReference_To = null;
                return true;
            }

            return false;
        }
    }
}
