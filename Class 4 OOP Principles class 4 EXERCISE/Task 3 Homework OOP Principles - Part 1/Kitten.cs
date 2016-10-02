using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Homework_OOP_Principles___Part_1
{
    public class Kitten : Cat
    {
        // Constructors

        public Kitten(int age, string name, string sex,int id) : base(age, name, sex,id)
        {
            if (sex != "Female")
            {
                throw new ArgumentException("Sex of Kittens can only be Female with first capital letter");
            }
        }

        // Methods

        public override void Sound()
        {
            Console.WriteLine("The kitten said Myau Myau");
        }

    }
}
