using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_4_OOP_Principles_class_4_EXERCISE
{
    public class Cat : Mammal
    {
        public Cat(string name, int age) : base(name,age)
        {
        }

        public void SayMyaau()
        {
            Console.WriteLine("Myaau...");
        }

        //public override void Move()
        //{
        //    Console.WriteLine("The cat is moving");
        //}
    }
}
