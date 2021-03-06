﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_Exercise
{
    public class Owner
    {
        // Fields

        private string firstName;
        private string lastName;

        private List<Cat> cats =new List<Cat>();
        
        // Constructor

        public Owner(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Age = 0;
        }

        //Properties

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public string FullName
        {
            get
            {
                return string.Format($"{firstName} {lastName}");
            }
        }

        public int Age { get; private set; }

        // Methods

        public string AllCats
        {
            get
            {
                return string.Join(", ", this.cats.Select(c => c.Name));
            }
        }

        public void IncreaseAge ()
        {
            this.Age ++;
        }

        public void AddCat(Cat cat, string name)
        {
            if (this.cats.Contains(cat))
            {
                throw new ArgumentException("This owner already owns this cat: " + cat.Name);
            }

            cat.Name = name;
            cat.Owner = this; // current owner becomes cat's owner
            this.cats.Add(cat);
        }
    }
}
