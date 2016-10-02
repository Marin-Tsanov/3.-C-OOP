using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.firstName  = "Ivan";
            student.middleName = "Kolev";
            student.lastName   = "Kolev";

            student.FullName();

            student.middleName = "Ganchev";
            student.FullName();
        }
    }

    public class Student
    {
        public string firstName;
        public string middleName;
        public string lastName;
        
        public string FisrtName
        {
            set
            {
                if (value.Length >= 5)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("Fisrt must be ge");
                }
            }
        }
            public string MiddleName
        {
            set
            {
                this.middleName = value;
            }
        }

        public string LastName
        {
            set
            {
                this.lastName = value;
            }
        }

        public void FullName()
        {
            Console.WriteLine($"{firstName} {middleName} {lastName}");
        }
    }
}