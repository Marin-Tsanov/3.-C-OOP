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
            IPerson person = new Person(); // this is possible
                                           // cause we have jerarchic
                                           // structure     

            person.HairColor="red";                        // person is created through
                                                           // IPerson so it has the specifics
                                                           // of it,it does not have Age
                                                           // if we create it through Person
                                                           // it will have IPerson and Person's
                                                           // properties   

            Student student = new Student();               // student is created through Student
                                                           // so it has the properties of both 
                                                           // IPerson and Student                        
        }
    }

    public class Person : IPerson // Person inherits IPerson 
    {
        public int Age { get; set; }

        public string FullName { get; set; }

        public string HairColor { get; set; }
    }

    public class Student : IPerson // Student inherits IPerson 
    {
        public string FacNumber { get; set; }

        public string FullName { get; set; }

        public string HairColor { get; set; }
    }


    public interface IPerson // interface is public,so we do not
                             // set the properties as public
                             // the system will thow an error 
    {
        string FullName { get; set; }

        string HairColor { get; set; }
    }
}

