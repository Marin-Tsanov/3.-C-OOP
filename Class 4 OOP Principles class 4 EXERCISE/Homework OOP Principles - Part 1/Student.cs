using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Principles___Part_1
{
    public class Student: Human
    {
        private int grade;

        // Constructor

        public Student(string firstname, string lastname, int grade) : base(firstname,lastname) 
        {
            this.Grade = grade;
        }

        // Properties 

            public int Grade
        {
            get { return this.grade; }
            set
            {
                if (value <= 0 && value > 5)
                {
                    throw new ArgumentOutOfRangeException("Grade can not be smaller than 1 or bigger than 5");
                }
                this.grade = value;
            }
        }
            
        // Method

        public override string FullName()
        {
            return Firstname + " " + Lastname; 
        }
    }
}
