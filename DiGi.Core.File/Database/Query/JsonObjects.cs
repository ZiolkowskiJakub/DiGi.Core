using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Database
{
    public static partial class Query
    {
        public static List<JsonObject> JsonObjects(this JsonArray jsonArray)
        {
            if (jsonArray == null)
            {
                return null;
            }

            List<JsonObject> result = new List<JsonObject>();
            foreach (JsonNode jsonNode in jsonArray)
            {
                if (jsonNode == null)
                {
                    continue;
                }

                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Object:
                        result.Add(jsonNode.AsObject());
                        break;

                    case System.Text.Json.JsonValueKind.Array:
                        List<JsonObject> jsonObjects = JsonObjects(jsonNode.AsArray());
                        if (jsonObjects != null)
                        {
                            result.AddRange(jsonObjects);
                        }
                        break;
                }
            }

            return result;
        }
    }
}

