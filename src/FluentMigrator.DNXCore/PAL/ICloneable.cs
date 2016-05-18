#if NETSTANDARD

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System
{
    public interface ICloneable
    {
        object Clone();
    }
}

#endif