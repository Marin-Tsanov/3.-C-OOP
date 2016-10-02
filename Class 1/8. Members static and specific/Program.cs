using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Members_static_and_specific
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            Person.DoSomething(); // that's how we call static method or field        
                                  // through the class  

            person.DoSomethingNonStatic();

            Console.WriteLine(Person.name); // that's how we call static field
        }
    }

    public class Person
    {
        public static string name = "Pesho";

        public static void DoSomething()
        {
            Console.WriteLine("Do something");
        }

        public void DoSomethingNonStatic()
        {
            Console.WriteLine("Do something non-static");
        }
    }
}
