using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Enums;
using System.Collections.Generic;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Modify
    {
        public static bool Add(this HashSet<JsonNodeWrapper> jsonNodeWrappers, JsonNodeWrapper jsonNodeWrapper, WrapState wrapState)
        {
            if (jsonNodeWrappers == null || jsonNodeWrapper == null)
            {
                return false;
            }

            if (wrapState == WrapState.Undefined)
            {
                return jsonNodeWrappers.Add(jsonNodeWrapper);
            }

            bool isObjectReference = jsonNodeWrapper.IsObjectReference();
            switch (wrapState)
            {
                case WrapState.Wrapped:
                    if (!isObjectReference)
                    {
                        return false;
                    }
                    break;

                case WrapState.Unwrapped:
                    if (isObjectReference)
                    {
                        return false;
                    }
                    break;
            }

            return jsonNodeWrappers.Add(jsonNodeWrapper);
        }
    }
}

