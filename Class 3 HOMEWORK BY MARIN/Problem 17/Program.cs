using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_17
{
    public class Program
    {
       public static void Main()
        {
            string[] array = new string[]
            {
                "am",
                "ama",
                "amam",
                "ha"
            };

            var max =
                (from m in array
                 select m).Max();
            Console.WriteLine(max);
        }
    }
}
