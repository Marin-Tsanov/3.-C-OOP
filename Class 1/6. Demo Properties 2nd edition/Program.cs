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
            person.MyProperty = 22;
            Console.WriteLine(person.MyProperty);
        }
    }

    public class Person
    {
        public string fullName;

        public string FullName          // default condition of property
                                        // if we haven't set it from the system
                                        // check example below property set 
                                        // through the system
        {
            get
            {
                return this.fullName;
            }
            set
            {
                this.fullName = value;
            }
        }
        public int MyProperty { get; set; } // created with prop and double tab
                                            // it created the field and default 
                                            // values of get and set
    }
}

