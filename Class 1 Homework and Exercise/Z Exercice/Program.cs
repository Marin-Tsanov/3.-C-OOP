using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Z_Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime today = DateTime.Today;
            //DateTime dt = DateTime.Now;
            //Console.WriteLine(dt.ToString("dd-MMM-yyyy"));
            //Console.WriteLine(dt.ToString("hh-mm"));

            string a = "5508255";

            int b = 0;




            //if (Regex.IsMatch(a, @"^\d+$"))
            //{
            //    Console.WriteLine("valid");
            //}
            //else
            //{
            //    Console.WriteLine("invalid");
            //}

            if (a[0] != '0' && a[1] != '1')
            {
                Console.WriteLine("Error Phone number must be 10 digit number starting  with \"08\"");
            }
            else
            {
                Console.WriteLine("Good");
            }
        }
    }
}
