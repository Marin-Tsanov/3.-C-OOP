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
            //var p1 = new Person();
            //var p2 = new Person(21);
            //var p3 = new Person("Pesho",21);

            var p4 = new Person("Pesho");
        }
    }

    public class Person
    {
        public const string Name = "12421";   // const can be initialized only here
        public readonly string FullName = ""; // OK for the readnoly field

        public Person() :this(21) // calls another constructor first in this case the one with years
        {
            Console.WriteLine("Default empty constructor");
        }

        public Person(string name) : this( )
        {
            Console.WriteLine("Priemam samo ime");
        }

        public Person(string name,int age)
        {
            Console.WriteLine("Priemam ime i godini");
        }

        public Person(int age)
        {
            Console.WriteLine("Priemam samo godini");
        }
    }
}
