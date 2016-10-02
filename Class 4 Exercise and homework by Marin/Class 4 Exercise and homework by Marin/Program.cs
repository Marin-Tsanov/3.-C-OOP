using MyExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_4_Exercise_and_homework_by_Marin
{
    class Program
    {
        static void Main()
        {
            //List<int> a = new List<int>();

            //var str = "Hello test testing Extension Methods Again";
            //str.PrintOnConsole();
            //Console.ReadLine();

            var car = new Car("BMW", "320d", 200);

            var carViewModel = new { CarModel = car.Model, CarMake = car.Make };
            Console.WriteLine(carViewModel.CarMake);

            List<int> list = new List<int>() { 1, 2, 3, 4 };
            //List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);

            //List<int> oddNumbers = list.FindAll(x => (x % 2) == 1);

            List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);
            List<int> oddNumbers = list.FindAll(x => (x % 2) == 1);

            foreach (var num in evenNumbers)
            {
                Console.Write("{0} ",num);
            }

            foreach (var num in oddNumbers)
            {
                Console.Write("{0} ", num);
            }

            Console.WriteLine();

            Action<int> act = (number) =>
            {
                Console.WriteLine(number);
            };
act(10);
            Func<string, int, string> greet = (name, age) =>
            {
                return "Name: " + name + " Age: " + age;
            };
Console.WriteLine(greet("Ivaylo", 10));

            string[] games = {"Morrowind", "BioShock", "Half Life",
  "The Darkness", "Daxter", "System Shock 2"};

            // Build a query expression using extension methods
            // granted to the Array via the Enumerable type

            var subset = games
                        .Where(game => game.Length > 6)
                        .OrderBy(game => game)
                        .Select(game => game);

            foreach (var game in subset)
                Console.WriteLine(game);

        }
    }
}
