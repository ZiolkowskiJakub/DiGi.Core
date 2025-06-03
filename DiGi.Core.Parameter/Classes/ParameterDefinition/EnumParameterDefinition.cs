using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System;
using System.Text.Json.Nodes;

namespace DiGi.Core.Parameter.Classes
{
    public class EnumParameterDefinition : ComplexParameterDefinition
    {
        private Enum @enum;

        public EnumParameterDefinition(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public EnumParameterDefinition(EnumParameterDefinition enumParameterDefinition)
            : base(enumParameterDefinition)
        {
            if(enumParameterDefinition != null)
            {
                @enum = enumParameterDefinition.@enum;
            }
        }

        public EnumParameterDefinition(Enum @enum)
        {
            this.@enum = @enum;
        }

        public EnumParameterDefinition()
            : base()
        {

        }

        public override AccessType AccessType
        {
            get
            {
                ParameterProperties parameterProperties = Query.ParameterProperties(@enum);
                if (parameterProperties == null)
                {
                    return AccessType.ReadWrite;
                }

                return parameterProperties.AccessType;
            }
        }

        public override AssociatedTypes AssociatedTypes
        {
            get
            {
                return Query.AssociatedTypes(@enum.GetType());
            }
        }

        public override string Description
        {
            get
            {
                return Query.ParameterProperties(@enum)?.Description;
            }
        }
        
        public override string GroupName
        {
            get
            {
                string result = Query.ParameterProperties(@enum)?.GroupName;

                if (result == null)
                {
                    result = @enum?.GetType()?.Namespace;
                }

                if (result == null)
                {
                    result = Constans.Names.DefaultGroupName;
                }

                return result;
            }
        }

        public override string Name
        {
            get
            {
                return Query.ParameterProperties(@enum)?.Name;
            }
        }

        public override ParameterValue ParameterValue
        {
            get
            {
                return Query.ParameterValue<ParameterValue>(@enum);
            }
        }

        public override string UniqueId
        {
            get
            {
                return Query.ParameterProperties(@enum)?.UniqueId;
            }
        }
        
        public static explicit operator Enum(EnumParameterDefinition enumParameterDefinition)
        {
            if (enumParameterDefinition == null)
            {
                return null;
            }

            return enumParameterDefinition.@enum;
        }

        public static explicit operator EnumParameterDefinition(Enum @enum)
        {
            if (@enum == null)
            {
                return null;
            }

            return new EnumParameterDefinition(@enum);
        }

        public override ISerializableObject Clone()
        {
            return new EnumParameterDefinition(this);
        }

        public override bool FromJsonObject(JsonObject jsonObject)
        {
            if (jsonObject == null)
            {
                return false;
            }

            if (jsonObject.ContainsKey("Enum"))
            {
                Core.Query.TryGetEnum(jsonObject["Enum"].GetValue<string>(), out @enum);
            }

            return true;
        }

        public override JsonObject ToJsonObject()
        {
            JsonObject result = new JsonObject();
            result.Add(Core.Constans.Serialization.PropertyName.Type, Core.Query.FullTypeName(GetType()));
            result.Add("Enum", Core.Query.FullName(@enum));

            return result;
        }
    }
}
