using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemos
{
    //class Person
    //{
    //    public string Name
    //    {
    //        get;
    //        set;
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person();

            //p1.Name = "Pesho";
            //Console.WriteLine(p1.Name);
            //Person p2 = new Person();

            Student student = new Student();

            student.FirstName = "Pesho";
            student.MiddleName = "Kolev";
            student.LastName = "Kolev";

            Console.WriteLine(student.FullName);

            student.MiddleName = "Ganchev";
            Console.WriteLine(student.FullName);
        }
    }

    class Student
    {
        /*public string facultyNumber;*/ // fields,their values define the state of the class
        private string firstName;
        private string middleName;
        private string lastName;

        //public void GoToClass()
        //{
        //    // Go to class
        //    // Sit on the desk
        //    // Listen to the lecturer


        //}


            public string FirstName // property
        {
            set
            {
                if (value.Length >= 5)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("First name argument must be greater than 5 symbols");
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

        public string FullName
        {
            get
            {
                return $"{firstName} {middleName} {lastName}";
            }
        }
    }

}
