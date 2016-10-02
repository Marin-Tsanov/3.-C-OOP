using MyExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Class_3_Exercise_and_Homework_by_Marin
{
    class Program
    {
        static void Main()
        {
            string s = "Hello Extension Methods";
            int i = s.WordCount();
            Console.WriteLine(i);

            List<int> myValues = new List<int>() { 1, 2, 3 };
            myValues.IncreaseWidth(1);
            foreach (var value in myValues)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine(myValues.ToString<int>());
            Console.WriteLine();
            Console.WriteLine(s.WordOccurences("hello"));
            s.Print();

            var car = new AnonymousType.Car("BMW", "320d", 200);

            var point = new { X = 3, Y = 5, };
            Console.WriteLine("{0} {1}", point.X, point.Y);

            var carViewModel = new { CarModel = car.Model, CarMake = car.Make };
            Console.WriteLine(carViewModel.CarMake);

            var myCar =
     new { Color = "Red", Brand = "BMW", Speed = 180 };
            Console.WriteLine("My car is a {0} {1}.",
              myCar.Color, myCar.Brand);

            Console.WriteLine();

            var p = new { X = 3, Y = 5 };
            var q = new { X = 3, Y = 5 };
            Console.WriteLine(p);
            Console.WriteLine(q);
            Console.WriteLine(p == q); // false
            Console.WriteLine(p.Equals(q)); // true

            Console.WriteLine();

            var combined = new { P = p, Q = q };
            Console.WriteLine(combined.P.X);

            var arr = new[]
{
    new { X = 3, Y = 5 },
    new { X = 1, Y = 2 },
    new { X = 0, Y = 7 }
};

            foreach (var item in arr)
            {
                Console.WriteLine("({0}, {1})", item.X, item.Y);
            }
        }
    }
}
