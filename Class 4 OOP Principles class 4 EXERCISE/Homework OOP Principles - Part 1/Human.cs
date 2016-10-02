using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Principles___Part_1
{
   public abstract class Human
    {
        // Fields 
        private string firstname;
        private string lastname;

        // Constructors
        public Human(string firstname, string lastname)
        {
            this.Firstname = firstname;
            this.Lastname  = lastname ;
        }
        
        //Properties
        public string Firstname
        {
            get { return this.firstname; }
            set
            {
                char[] array = value.ToCharArray();
                if (char.IsLetter(array[0]) && char.IsUpper(array[0]))
                {
                    foreach (var item in array)
                    {
                        if (!char.IsLetter(item))
                        {
                            throw new ArgumentException("The firstname must contain only letters.");
                        }
                    }
                }

                else
                {
                    throw new ArgumentException("The firstname's first letter must be a capital letter.");
                }

                this.firstname = value;
            }
        }

        public string Lastname
        {
            get { return this.lastname; }
            set
            {
                char[] array1 = value.ToCharArray();
                if (char.IsLetter(array1[0]) && char.IsUpper(array1[0]))
                {
                    foreach (var item in array1)
                    {
                        if (!char.IsLetter(item))
                        {
                            throw new ArgumentException("The lastname must contain only letters.");
                        }
                    }
                }

                else
                {
                    throw new ArgumentException("The lastname's first letter must be a capital letter.");
                }

                this.lastname = value;
            }
        }
        // Method 

        public abstract string FullName();
    }
}
