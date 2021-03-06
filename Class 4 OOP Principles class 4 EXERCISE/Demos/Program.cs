﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            IPromotion employee = new Employee("Pesho", 1000);

            Console.WriteLine(employee);

            IPromotion newEmployee = employee;

            newEmployee.Promote();

            Console.WriteLine(newEmployee);
        }
    }

    interface IPromotion
    {
        void Promote();
    }

    struct Employee : IPromotion
    {
        public string Name;
        public int Salary;

        public void Promote()
        {
            this.Salary+=1000;
        }

        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", this.Name, this.Salary);
        }
    }
}
