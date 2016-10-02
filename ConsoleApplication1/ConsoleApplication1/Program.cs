using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "ba";
            string b = "ab";

            int c = string.Compare(a, b);
            Console.WriteLine(c);
        }
    }
}
