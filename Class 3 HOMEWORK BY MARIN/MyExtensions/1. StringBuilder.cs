using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtensions
{
    public static class Extension
    {
        public static StringBuilder SubstringExampleMarin(this string str, int index, int length)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(str.Substring(index, length));
            return builder;
        }
    }
}
