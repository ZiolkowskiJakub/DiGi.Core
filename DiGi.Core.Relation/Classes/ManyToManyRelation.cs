using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Enums;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Relation.Classes
{
    public abstract class ManyToManyRelation : ManyToManyRelation<IUniqueObject, IUniqueObject>
    {
        public ManyToManyRelation(IEnumerable<IUniqueReference>? uniqueReferences_From, IEnumerable<IUniqueReference>? uniqueReferences_To)
            : base(uniqueReferences_From, uniqueReferences_To)
        {
        }

        public ManyToManyRelation(ManyToManyRelation? manyToManyRelation)
            : base(manyToManyRelation)
        {
        }

        public ManyToManyRelation(IEnumerable<IUniqueObject>? uniqueObjects_From, IEnumerable<IUniqueObject>? uniqueObjects_To)
            : base(uniqueObjects_From, uniqueObjects_To)
        {
        }

        public ManyToManyRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }

    public abstract class ManyToManyRelation<From, To> : Relation<From, To>, IManyToManyRelation<From, To> where From : IUniqueObject where To : IUniqueObject
    {
        [JsonInclude, JsonPropertyName("UniqueReferences_From")]
        private List<IUniqueReference>? uniqueReferences_From;

        [JsonInclude, JsonPropertyName("UniqueReferences_To")]
        private List<IUniqueReference>? uniqueReferences_To;

        public ManyToManyRelation(IEnumerable<IUniqueReference>? uniqueReferences_From, IEnumerable<IUniqueReference>? uniqueReferences_To)
            : base()
        {
            if (uniqueReferences_To != null)
            {
                this.uniqueReferences_To = [];
                foreach (IUniqueReference? uniqueReference in uniqueReferences_To)
                {
                    IUniqueReference? uniqueReference_Temp = uniqueReference?.Clone<IUniqueReference>();
                    if (uniqueReference_Temp != null)
                    {
                        this.uniqueReferences_To.Add(uniqueReference_Temp);
                    }
                }
            }

            if (uniqueReferences_From != null)
            {
                this.uniqueReferences_From = [];
                foreach (IUniqueReference? uniqueReference in uniqueReferences_From)
                {
                    IUniqueReference? uniqueReference_Temp = uniqueReference?.Clone<IUniqueReference>();
                    if (uniqueReference_Temp != null)
                    {
                        this.uniqueReferences_From.Add(uniqueReference_Temp);
                    }
                }
            }
        }

        public ManyToManyRelation(ManyToManyRelation<From, To>? manyToManyRelation)
            : base()
        {
            if (manyToManyRelation != null)
            {
                if (manyToManyRelation.uniqueReferences_To != null)
                {
                    uniqueReferences_To = [];
                    foreach (IUniqueReference uniqueReference_To in manyToManyRelation.uniqueReferences_To)
                    {
                        IUniqueReference? uniqueReference = uniqueReference_To?.Clone<IUniqueReference>();
                        if (uniqueReference != null)
                        {
                            uniqueReferences_To.Add(uniqueReference);
                        }
                    }
                }

                if (manyToManyRelation.uniqueReferences_From != null)
                {
                    uniqueReferences_From = [];
                    foreach (IUniqueReference uniqueReference_From in manyToManyRelation.uniqueReferences_From)
                    {
                        IUniqueReference? uniqueReference = uniqueReference_From?.Clone<IUniqueReference>();
                        if (uniqueReference != null)
                        {
                            uniqueReferences_From.Add(uniqueReference);
                        }
                    }
                }
            }
        }

        public ManyToManyRelation(IEnumerable<From>? uniqueObjects_From, IEnumerable<To>? uniqueObjects_To)
            : base()
        {
            if (uniqueObjects_To != null)
            {
                uniqueReferences_To = [];
                foreach (To to in uniqueObjects_To)
                {
                    IUniqueReference? uniqueReference = Create.UniqueReference(to);
                    if (uniqueReference != null)
                    {
                        uniqueReferences_To.Add(uniqueReference);
                    }
                }
            }

            if (uniqueObjects_From != null)
            {
                uniqueReferences_From = [];
                foreach (From from in uniqueObjects_From)
                {
                    IUniqueReference? uniqueReference = Create.UniqueReference(from);
                    if (uniqueReference != null)
                    {
                        uniqueReferences_From.Add(uniqueReference);
                    }
                }
            }
        }

        public ManyToManyRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        [JsonIgnore]
        public override List<IUniqueReference>? UniqueReferences
        {
            get
            {
                List<IUniqueReference> result = [];
                if (uniqueReferences_To != null)
                {
                    foreach (IUniqueReference uniqueReference in uniqueReferences_To)
                    {
                        IUniqueReference? uniqueReference_Temp = uniqueReference.Clone<IUniqueReference>();
                        if (uniqueReference_Temp is null)
                        {
                            continue;
                        }

                        result.Add(uniqueReference_Temp);
                    }
                }

                if (uniqueReferences_From != null)
                {
                    foreach (IUniqueReference uniqueReference in uniqueReferences_From)
                    {
                        IUniqueReference? uniqueReference_Temp = uniqueReference.Clone<IUniqueReference>();
                        if (uniqueReference_Temp is null)
                        {
                            continue;
                        }

                        result.Add(uniqueReference_Temp);
                    }
                }

                return result;
            }
        }

        [JsonIgnore]
        public List<IUniqueReference>? UniqueReferences_From
        {
            get
            {
                if (uniqueReferences_From == null)
                {
                    return null;
                }

                List<IUniqueReference> result = [];
                foreach (IUniqueReference uniqueReference in uniqueReferences_From)
                {
                    IUniqueReference? uniqueReference_Temp = uniqueReference.Clone<IUniqueReference>();
                    if (uniqueReference_Temp != null)
                    {
                        result.Add(uniqueReference_Temp);
                    }
                }

                return result;
            }
        }

        [JsonIgnore]
        public List<IUniqueReference>? UniqueReferences_To
        {
            get
            {
                if (uniqueReferences_To == null)
                {
                    return null;
                }

                List<IUniqueReference> result = [];
                foreach (IUniqueReference uniqueReference in uniqueReferences_To)
                {
                    IUniqueReference? uniqueReference_Temp = uniqueReference.Clone<IUniqueReference>();
                    if (uniqueReference_Temp != null)
                    {
                        result.Add(uniqueReference_Temp);
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
                uniqueReferences_To ??= [];

                uniqueReferences_To.Add(uniqueReference);
                return true;
            }

            if (relationSide == RelationSide.From)
            {
                uniqueReferences_From ??= [];

                uniqueReferences_From.Add(uniqueReference);
                return true;
            }

            return false;
        }

        public override bool Contains(RelationSide relationSide, IUniqueReference? uniqueReference)
        {
            if (uniqueReference == null)
            {
                return false;
            }

            bool result = false;

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                result = uniqueReferences_From?.Find(x => uniqueReference.Equals(x)) != null;
            }

            if (result)
            {
                return result;
            }

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                result = uniqueReferences_To?.Find(x => uniqueReference.Equals(x)) != null;
            }

            return result;
        }

        public override bool Has(RelationSide relationSide)
        {
            bool result = false;

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                result = uniqueReferences_From != null && uniqueReferences_From.Count != 0;
            }

            if (result)
            {
                return result;
            }

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                result = uniqueReferences_To != null && uniqueReferences_To.Count != 0;
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
                if (Modify.RemoveFirst(uniqueReferences_To, uniqueReference))
                {
                    result = true;
                }
            }

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                if (Modify.RemoveFirst(uniqueReferences_From, uniqueReference))
                {
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

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                if (uniqueReferences_From != null)
                {
                    foreach (TUniqueReference uniqueReference in uniqueReferences)
                    {
                        if (Modify.RemoveFirst(uniqueReferences_From, uniqueReference))
                        {
                            result.Add(uniqueReference);
                            if (uniqueReferences_From.Count == 0)
                            {
                                break;
                            }
                        }
                    }
                }
            }

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                if (uniqueReferences_To == null)
                {
                    return result;
                }

                foreach (TUniqueReference uniqueReference in uniqueReferences)
                {
                    if (Modify.RemoveFirst(uniqueReferences_To, uniqueReference))
                    {
                        result.Add(uniqueReference);
                        if (uniqueReferences_To.Count == 0)
                        {
                            break;
                        }
                    }
                }
            }

            return result;
        }
    }
}