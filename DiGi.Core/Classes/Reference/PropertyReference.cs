//using DiGi.Core.Interfaces;
//using System.Text.Json.Nodes;
//using System.Text.Json.Serialization;

//namespace DiGi.Core.Classes
//{
//    public abstract class PropertyReference : SerializableReference
//    {
//        [JsonInclude, JsonPropertyName("PropertyName")]
//        private string propertyName;

//        public string PropertyName
//        {
//            get
//            {
//                return propertyName;
//            }
//        }
//    }

//    public abstract class PropertyReference<UTypeReference> : PropertyReference where UTypeReference : TypeReference
//    {
//        [JsonInclude, JsonPropertyName("Reference")]
//        private UTypeReference reference;

//        public UTypeReference Reference { get; }
//    }

//    public class TypePropertyReference : PropertyReference<TypeReference>
//    {



//    }

//    public class UniqueIdPropertyReference : PropertyReference<UniqueIdReference>
//    {

//    }

//    public class GuidPropertyReference : PropertyReference<GuidReference>
//    {

//    }
//}