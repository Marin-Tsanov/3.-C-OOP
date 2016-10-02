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
            Student student = new Student();
            student.IntroduceYourself();
        }
    }
    
    public class Person
    {
        protected string Name { get; set; } = "Pesho"; // this way we give default value to the property
                                                       // protected can be used only in the current scope 
                                                       // or by the classes,that inherit its class
                                                       // Like the Example Student inherits from Person    
    }

    public class Student : Person // Student inherits from Person
    {
        public void IntroduceYourself()
        {
            Console.WriteLine(this.Name); // Name exists here in this method
        }     
    }
}

