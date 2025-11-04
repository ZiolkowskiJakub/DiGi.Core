using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Enums;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Relation.Classes
{
    public abstract class OneToOneRelation : OneToOneRelation<IUniqueObject, IUniqueObject>
    {
        public OneToOneRelation(OneToOneRelation? oneToOneRelation)
            : base(oneToOneRelation)
        {

        }

        public OneToOneRelation(UniqueReference? uniqueReference_From, UniqueReference? uniqueReference_To)
            : base(uniqueReference_From, uniqueReference_To)
        {

        }

        public OneToOneRelation(IUniqueObject? uniqueObject_From, IUniqueObject? uniqueObject_To)
            : base(uniqueObject_From, uniqueObject_To)
        {

        }

        public OneToOneRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }
    }

    public abstract class OneToOneRelation<From, To> : Relation<From, To>, IOneToOneRelation<From, To> where From : IUniqueObject where To : IUniqueObject
    {
        [JsonInclude, JsonPropertyName("UniqueReference_From")]
        private IUniqueReference? uniqueReference_From;

        [JsonInclude, JsonPropertyName("UniqueReference_To")]
        private IUniqueReference? uniqueReference_To;

        public OneToOneRelation(OneToOneRelation<From, To>? oneToOneRelation)
            : base()
        {
            uniqueReference_From = oneToOneRelation?.uniqueReference_From?.Clone<IUniqueReference>();
            uniqueReference_To = oneToOneRelation?.uniqueReference_To?.Clone<IUniqueReference>();
        }

        public OneToOneRelation(IUniqueReference? uniqueReference_From, IUniqueReference? uniqueReference_To)
        {
            this.uniqueReference_From = uniqueReference_From?.Clone<IUniqueReference>();
            this.uniqueReference_To = uniqueReference_To?.Clone<IUniqueReference>();
        }

        public OneToOneRelation(From? uniqueObject_From, To? uniqueObject_To)
        {
            uniqueReference_From = uniqueObject_From == null ? null : Create.UniqueReference(uniqueObject_From);
            uniqueReference_To = uniqueObject_To == null ? null : Create.UniqueReference(uniqueObject_To);
        }

        public OneToOneRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public IUniqueReference? UniqueReference_From
        {
            get
            {
                return uniqueReference_From?.Clone<IUniqueReference>();
            }
        }

        [JsonIgnore]
        public IUniqueReference? UniqueReference_To
        {
            get
            {
                return uniqueReference_To?.Clone<IUniqueReference>();
            }
        }

        [JsonIgnore]
        public override List<IUniqueReference>? UniqueReferences
        {
            get
            {
                List<IUniqueReference> result = [];
                if (uniqueReference_From != null)
                {
                    IUniqueReference? uniqueReference = uniqueReference_From.Clone<IUniqueReference>();
                    if (uniqueReference != null)
                    {
                        result.Add(uniqueReference);
                    }
                }

                if (uniqueReference_To != null)
                {
                    IUniqueReference? uniqueReference = uniqueReference_To.Clone<IUniqueReference>();
                    if (uniqueReference != null)
                    {
                        result.Add(uniqueReference);
                    }
                }

                return result;
            }
        }

        public override bool Add(RelationSide relationSide, IUniqueReference? uniqueReference)
        {
            if (uniqueReference == null || relationSide == RelationSide.Undefined)
            {
                return false;
            }

            if (relationSide == RelationSide.To)
            {
                uniqueReference_To = uniqueReference;
                return true;
            }

            if (relationSide == RelationSide.From)
            {
                uniqueReference_From = uniqueReference;
                return true;
            }

            return true;
        }

        public override bool Contains(RelationSide relationSide, IUniqueReference? uniqueReference)
        {
            if(uniqueReference == null)
            {
                return false;
            }

            bool result = false;

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                if(uniqueReference_From != null)
                {
                    result = uniqueReference.Equals(uniqueReference_From);
                }
            }

            if (result || uniqueReference_To is null)
            {
                return result;
            }

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                result = uniqueReference.Equals(uniqueReference_To);
            }

            return result;
        }

        public override bool Has(RelationSide relationSide)
        {
            bool result = false;

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                result = uniqueReference_From != null;
            }

            if (result)
            {
                return result;
            }

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                result = uniqueReference_To != null;
            }

            return result;
        }

        public override bool Remove(RelationSide relationSide, IUniqueReference? uniqueReference)
        {
            if (uniqueReference == null)
            {
                return false;
            }

            bool result = false;
            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                if (uniqueReference_To != null && uniqueReference.Equals(uniqueReference_To))
                {
                    uniqueReference_To = null;
                    result = true;
                }
            }

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                if (uniqueReference_From != null && uniqueReference.Equals(uniqueReference_From))
                {
                    uniqueReference_From = null;
                    result = true;
                }
            }

            return result;
        }
        
        public override List<TUniqueReference>? Remove<TUniqueReference>(RelationSide relationSide, IEnumerable<TUniqueReference>? uniqueReferences)
        {
            if (uniqueReferences == null)
            {
                return null;
            }

            List<TUniqueReference> result = [];
            if (uniqueReferences.Count() == 0)
            {
                return result;
            }

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                if(uniqueReference_To is TUniqueReference uniqueReference_Temp_1)
                {
                    if (uniqueReferences.Find(x => x is not null && uniqueReference_To.Equals(x)) != null)
                    {
                        result.Add(uniqueReference_Temp_1);
                        uniqueReference_To = null;
                    }
                }
            }

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                if (uniqueReference_From is TUniqueReference uniqueReference_Temp_2)
                {
                    if (uniqueReferences.Find(x => x is not null && uniqueReference_From.Equals(x)) != null)
                    {
                        result.Add(uniqueReference_Temp_2);
                        uniqueReference_From = null;
                    }
                }
            }

            return result;
        }
    }
}
