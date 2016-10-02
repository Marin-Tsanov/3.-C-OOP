using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Homework_OOP_Principles___Part_1
{
   public class Tomcat : Cat
    {
        // Constructors

        public Tomcat(int age, string name, string sex,int id) : base(age, name, sex,id)
        {
            if (sex != "Male")
            {
                throw new ArgumentException("Sex of Kittens can only be Male with first capital letter");
            }
        }

        public override void Sound()
        {
            Console.WriteLine("The tomcat said Myauuuuuuuu Myauuuuuuuu");
        }

    }
}
