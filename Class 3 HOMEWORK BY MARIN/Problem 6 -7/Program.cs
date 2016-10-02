using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6__7
{
    class Program
    {
        static void Main()
        {
            // task 6 

            // using Lambda

            List<int> a = new List<int> { 1, 3, 21, 48, 63 };

            List<int> b = a.FindAll(i => i % 3 == 0 & i % 7 == 0);

            foreach (var item in b)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------");

            // using LINQ

            var c =
                from item in a
                where item % 3 == 0 & item % 7 == 0
                select item;

            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
        }
    }
}
