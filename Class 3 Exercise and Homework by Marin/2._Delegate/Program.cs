using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._Delegate
{
    public delegate void SimpleDelegate(string param);

    public class DelegatesExample
    {
        public static void TestMethod(string param)
        {
            Console.WriteLine("I was called by a delegate.");
            Console.WriteLine("I got parameter: {0}.", param);
        }

       public static void Main()
        {
            SimpleDelegate d = new SimpleDelegate(TestMethod);
            d("test");
        }
    }
}
