using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Homework_OOP_Principles___Part_1
{
   public class Dog : Animal
    {
        // Constructors
        public Dog(int age, string name, string sex,int id) : base(age,name,sex,id)
        {
        }

        // Methods
        public override void Sound()
        {
            Console.WriteLine("The dog said Bau");
        }
    }
}
