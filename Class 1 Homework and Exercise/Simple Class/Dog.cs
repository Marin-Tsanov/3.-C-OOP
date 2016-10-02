using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Class
{
    public class Dog
    {
        private string name;
        private string breed;

        private string owner;

        //public Dog()
        //{
        //}

        public Dog(string name, string breed)
        {
            this.name/* field*/ = name; /* string name*/
            this.breed/* field*/ = breed; /* string breed*/
        }

        public string Name
        {
            get {return this.name; }
            set {this.name = value; }
        }

        public string Breed
        {
            get {return this.breed; }
            set {this.breed = value; }
        }

        public string Owner
        {
            get {return this.owner; }
            set {this.owner = value; }
        }

        public string BauBau()
        {
            string result = this.breed + " said bau";  
            return result;
        }

    }
}
