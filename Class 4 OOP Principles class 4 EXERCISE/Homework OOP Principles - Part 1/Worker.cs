using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP_Principles___Part_1
{
    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;
        private double money;

        // Constructor

        public Worker(string firstname,string lastname, double weekSalary, double workHoursPerDay) : base(firstname,lastname)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.money = MoneyPerHour();
        }

        // Properties

            public double WeekSalary
        {
            get { return this.weekSalary; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("WeekSalary can not be less than 0");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("WorkHoursPerDay can not be less than 0");
                }
                this.workHoursPerDay = value;
            }
        }

        public double Money
        {
            get { return this.MoneyPerHour(); }
        }

        // Method 

        public override string FullName()
        {
            return Firstname + " " + Lastname;
        }

        public double MoneyPerHour()
        {
            return weekSalary/(workHoursPerDay*5);
        }
    }
}
