﻿using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Enums;
using System.Collections.Generic;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Modify
    {
        internal static bool Add(this HashSet<WrapperNode> wrapperNodes, WrapperNode wrapperNode, WrapState wrapState)
        {
            if (wrapperNodes == null || wrapperNode == null)
            {
                return false;
            }

            if (wrapState == WrapState.Undefined)
            {
                return wrapperNodes.Add(wrapperNode);
            }

            bool isWrapperReference = wrapperNode.IsWrapperReference();
            switch (wrapState)
            {
                case WrapState.Wrapped:
                    if (!isWrapperReference)
                    {
                        return false;
                    }
                    break;

                case WrapState.Unwrapped:
                    if (isWrapperReference)
                    {
                        return false;
                    }
                    break;
            }

            return wrapperNodes.Add(wrapperNode);
        }
    }
}

