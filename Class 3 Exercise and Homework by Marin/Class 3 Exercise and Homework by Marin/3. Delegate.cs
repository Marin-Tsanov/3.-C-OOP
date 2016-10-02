using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_3_Exercise_and_Homework_by_Marin
{
    public delegate void SimpleDelegate(string param);

    public class Delegate
    {
        static void TestMethod(string param)
        {
            Console.WriteLine("I was called by a delegate");
            Console.WriteLine("I got parameter: {0}",param);
        }
    }
}
