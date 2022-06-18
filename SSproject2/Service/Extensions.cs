using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSproject2.Service
{
    public static class Extensions
    {
        public static string CutController(this string str)//объявление откатного метода
        {
            return str.Replace("Controller", "");
        }
    }
}
