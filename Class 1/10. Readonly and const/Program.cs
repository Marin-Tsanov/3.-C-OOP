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

        }
    }

    public class Person
    {
        public const string Name = "12421";   // const can be initialized only here
        public readonly string FullName = ""; // OK for the readnoly field

        public Person(string fullName) // OK for the readnoly field
        {
            this.FullName = fullName;
        }

        public void ChangeName()
        {
            this.FullName = "neshto novo"; // NOT OK we have set it and can not set it again
            Console.WriteLine(this.FullName);
        } 

    }
}
