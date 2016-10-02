using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.LambdaExpressions
{
    class Program
    {
        public static void Main()
        {
            var list = new List<int>() { 1, 2, 3, 4 };
            var evenNumbers = list.FindAll(x => x % 2 == 0);
            foreach (var num in evenNumbers)
            {
                Console.Write("{0} ",num);
            }
            Console.WriteLine();

            list.RemoveAll(x => x > 3);
            foreach (var num in list)
            {
                Console.Write("{0} ", num);
            }

            var pets = new Pet[]
            {
                new Pet { Name = "Sharo", Age = 8 },
                new Pet {Name = "Rex", Age = 4 },
                new Pet {Name = "Strela", Age = 1 },
                new Pet {Name = "Odin", Age = 5 }
            };

            var sortedPets = pets.OrderBy(pet => pet.Age);
            foreach (Pet pet in sortedPets)
            {
                Console.WriteLine("{0} -> {1}", pet.Name, pet.Age);
            }

            Console.WriteLine();

            list = new List<int>() { 20, 1, 4, 8, 9, 44 };
            foreach (var number in list)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();

            evenNumbers = list.FindAll(
                (i) =>
                {
                    Console.WriteLine("value of i is: {0}", i);
                    return (i % 2) == 0;
                });
            Console.WriteLine("here are your even numbers");

            foreach (var even in evenNumbers)
            {
                Console.WriteLine(even);
            }

            Console.WriteLine();
        }

        // Lambda by Marto

        Func<string, string, int> action = (x, y) =>
         {
             Console.WriteLine(x + y);
             return 42;
         };

            public int TestMethod(string str1, string str2)
        {
            Console.WriteLine(str1+str2);
            return 42;
        }

        }
    }

