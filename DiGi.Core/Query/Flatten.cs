using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static JsonArray Flatten(this JsonArray jsonArray)
        {
            if(jsonArray == null)
            {
                return null;
            }

            List<JsonNode> jsonNodes = new List<JsonNode>();
            foreach(JsonNode jsonNode in jsonArray)
            {
                if(jsonNode == null)
                {
                    jsonNodes.Add(jsonNode);
                    continue;
                }

                if(jsonNode.GetValueKind() != System.Text.Json.JsonValueKind.Array)
                {
                    jsonNodes.Add(jsonNode);
                    continue;
                }

                JsonArray jsonArray_Temp = jsonNode.AsArray();
                if(jsonArray_Temp == null)
                {
                    jsonNodes.Add(jsonNode);
                    continue;
                }

                foreach(JsonNode jsonNode_Temp in jsonArray_Temp)
                {
                    if (jsonNode == null || jsonNode.GetValueKind() != System.Text.Json.JsonValueKind.Array)
                    {
                        jsonNodes.Add(jsonNode_Temp);
                        continue;
                    }

                    JsonArray jsonArray_Temp_Temp = jsonNode.AsArray();
                    if (jsonArray_Temp_Temp == null)
                    {
                        jsonNodes.Add(jsonNode_Temp);
                        continue;
                    }

                    jsonArray_Temp_Temp = Flatten(jsonArray_Temp_Temp);

                    foreach (JsonNode jsonNode_Temp_Temp in jsonArray_Temp_Temp)
                    {
                        jsonNodes.Add(jsonNode_Temp_Temp);
                    }
                }
            }

            JsonArray result = new JsonArray();
            foreach(JsonNode jsonNode in jsonNodes)
            {
                result.Add(jsonNode?.DeepClone());
            }

            return result;
        }
    }

}
