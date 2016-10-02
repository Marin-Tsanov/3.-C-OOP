using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Pesho",20);
            Console.WriteLine(person.Name);

            var person1 = new Person("Pesho",20);
            var otherClass = new OtherClass();

            person.InitializeData();
            otherClass.InitializeData();

        }
    }

    class Person // constructor
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.InitializeData();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
        }

        public void InitializeData() // method
        {
            Console.WriteLine("Initializing data");
            // initialize important data


        }
    }

    public class OtherClass
    {
        public void InitializeData()
        {
            Console.WriteLine("Other class initializing data");
        }
    }
}
