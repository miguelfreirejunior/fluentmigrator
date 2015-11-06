#if DNXCORE50

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System.Data
{
    public enum Rule
    {
        None = 0,
        Cascade = 1,
        SetNull = 2,
        SetDefault = 3
    }
}
#endif
