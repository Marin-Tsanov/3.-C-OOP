using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_Exercise
{
    public class Cat: Animal
    {
        public static int NumberOfLegs
        {
            get
            {
                return 4;
            }
        }

		public Cat(CatColor color)
        {
            this.Color = color;
        }

        //public string Name { get; set; } placed in comment because inherites name from Animal

        public Gender Gender { get; set; }

        public int Age { get; private set; }

		public Owner Owner { get; set; } 

        public CatColor Color { get; private set; }

        public static string WhatDoesTheCatSay()
        {
            return "Mew!";
        }

        // Overloading 

        public static Cat operator +(Cat first, Cat second)
        {
            if (first.Gender == Gender.Male && second.Gender==Gender.Female)
            {
                if (first.Color == second.Color)
                {
                    return new Cat(first.Color);
                }
                return new Cat(CatColor.Mixed);
            }
            throw new ArgumentException();
        }

        public static int operator *(Cat first, Cat second)
        {
            return first.Age * second.Age;
        }

        public static bool operator true(Cat cat) // when you write for operator true 
                                                  // you have to write for the other operator false 
        {
            if (cat.Color == CatColor.Black)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator false(Cat cat)
        {
            if (cat.Color == CatColor.Black)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void GenerateGender()
        {
            var random = new Random();
            var genderIndex = random.Next(0, 2);
            this.Gender = (Gender)genderIndex;

        }
    }
}
