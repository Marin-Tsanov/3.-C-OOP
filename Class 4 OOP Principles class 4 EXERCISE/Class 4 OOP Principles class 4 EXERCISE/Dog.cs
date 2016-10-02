using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_4_OOP_Principles_class_4_EXERCISE
{
    public class Dog : Mammal
    {
        public string Breed { get; set; }

        public Dog(string name ,int age): base(name,age) 
        {

        }

        public override void Move()
        {
            Console.WriteLine("The dog is moving");
        }

        //public Dog(string  name,int age,string breed) : base(age, name)
        //{
        //    this.Breed = breed;
        //}

        //public void WagTail()
        //{
        //    Console.WriteLine("Tail wagging...");
        //}
    }
}
