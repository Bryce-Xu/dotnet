using System;
using System.Collections.Generic;
using System.Text;

namespace MyClassLibrary
{
    public class LibraryInfo
    {
        public static string About()
        {
#if NET45
            return "一个目标框架为.NET Framework 4.5的类库";
#elif NETSTANDARD2_0
            return "一个目标框架为.NET Standard的类库";
#endif
        }
    }
}
