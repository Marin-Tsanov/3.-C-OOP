using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            var myCar = new Car()
            {
                Brand = "BMW",
                Color = "black",
                Engine = new Engine { HorsePowers = 300 } 
            };

            Console.WriteLine(myCar.Engine.HorsePowers); // car has class engine and class engine has property HorsePowers
                                                         // this is the way to access it.
        }
    }
}
