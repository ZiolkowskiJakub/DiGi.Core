﻿using System;


namespace DiGi.Core.Interfaces
{
    public interface IGuidObject : IUniqueObject
    {
        Guid Guid { get; }

        IGuidObject Duplicate(Guid? guid = null);
    }
}
