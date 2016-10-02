using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Dog myDog = new Dog();
            myDog.Name = "Sharo";
            Console.WriteLine(Dog.NumOfLegs);

            Console.WriteLine(myDog.Name);
        }
    }
}
