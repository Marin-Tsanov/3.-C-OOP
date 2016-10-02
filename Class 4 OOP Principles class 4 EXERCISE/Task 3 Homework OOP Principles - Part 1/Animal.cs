using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Homework_OOP_Principles___Part_1
{
   public class Animal : ISound
    {
        // Fields 
        private int age;
        private string name;
        private string sex;
        private int id;
        // Constructors
        public Animal(int age, string name, string sex, int id)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
            this.ID = id;
        }

        // Properties 

        public int Age
        {
            get { return this.age; }
            set {

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age can not be less than 0");
                }

                this.age = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Sex
        {
            get { return this.sex; }
            set {
                if (value != "Male" && value != "Female" )
                {
                    throw new ArgumentException("Sex can only be Male or Female with first capital letter");
                }
                this.sex = value; }
        }

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        //Methods

        public virtual void Sound()
        {
            Console.WriteLine("Animal is making sound ...");
        }
    }
}

public interface ISound
{
    void Sound();
}