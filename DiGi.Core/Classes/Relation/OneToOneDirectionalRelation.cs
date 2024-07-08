﻿using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public class OneToOneDirectionalRelation : OneToOneRelation, IDirectionalRelation
    {
        public OneToOneDirectionalRelation(UniqueReference uniqueReference_From, UniqueReference uniqueReference_To)
            :base(uniqueReference_From, uniqueReference_To)
        {

        }

        public OneToOneDirectionalRelation(OneToOneDirectionalRelation oneToOneDirectionalRelation)
            : base(oneToOneDirectionalRelation)
        {

        }

        public OneToOneDirectionalRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public override ISerializableObject Clone()
        {
            return new OneToOneDirectionalRelation(this);
        }
    }
}
