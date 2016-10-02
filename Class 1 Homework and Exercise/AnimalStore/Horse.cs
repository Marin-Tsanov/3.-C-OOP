using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalStore
{
    class Horse : Mammal
    {
        public string name;

        public Horse()
        {
            this.Age = 5;
        }

        public void SayMyName()
        {
            Console.WriteLine("My name is {0} and I'm {1} years old",
                               this.name,this.Age);
        }
    }
}
