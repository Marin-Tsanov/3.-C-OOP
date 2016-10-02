using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Homework_OOP_Principles___Part_1
{
   public class Cat : Animal
    {  
        // Constructors
        public Cat(int age, string name, string sex,int id) : base(age,name,sex,id)
        {
        }

        // Methods

        public override void Sound()
        {
            Console.WriteLine("The cat said Myau");
        }
    }
}
