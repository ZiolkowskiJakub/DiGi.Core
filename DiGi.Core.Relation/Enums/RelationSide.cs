using System.ComponentModel;

namespace DiGi.Core.Relation.Enums
{
    /// <summary>Specifies the side of a relation.</summary>
    [Description("Relation Side")]
    public enum RelationSide
    {
        /// <summary>The side is undefined.</summary>
        [Description("Undefined")] Undefined,

        /// <summary>The "from" side of the relation.</summary>
        [Description("From")] From,

        /// <summary>The "to" side of the relation.</summary>
        [Description("To")] To,
    }
}