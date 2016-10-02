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
            Person person = new Person();
            var rucksasck = new Person.Rucksasck(21);
        }
    }

    public class Person // inner class
    {
         public class Rucksasck
        {
            public int capacity;
            
            public Rucksasck(int capacity)
            {
                this.capacity = capacity;
            }    
        }
    }
}
