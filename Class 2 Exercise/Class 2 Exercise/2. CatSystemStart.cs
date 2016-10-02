

namespace Class_2_Exercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CatSystemStart
    {
        public static void Main()
        {
            var peshoOwner = new Owner("Pesho", "Ivanov");
            var goshoOwner = new Owner("Gosho", "Petrov");

            var cat = new Cat(CatColor.Mixed);
            var anotherCat = new Cat(CatColor.Black);
            var yetAnotherCat = new Cat(CatColor.Brown);

            peshoOwner.IncreaseAge();
            Console.WriteLine(peshoOwner.FullName);

            peshoOwner.AddCat(cat, "Maca");
            peshoOwner.AddCat(anotherCat, "Silvestyr");

            Console.WriteLine(peshoOwner.AllCats);

            //Printer.PrintCat(yetAnotherCat);

            var point = new Point();

            point.X = 4.5M;
            point.Y = 18.9M;

            Console.WriteLine(point.GetCoordinates());

          /*  var myList = new GenericList<int>();*/ // you can input string,bool instead of int 
                                                 // Generic list is specified as Animal

            // code after Cat started to inherite from Animal

            var catAnimal = new Cat(CatColor.Brown);

            var dog = new Dog();
            dog.SayBau();

            var myListAnimal = new GenericList<Animal>();
            var anotherListCat = new GenericList<Cat>();
            var anotherListDog = new GenericList<Dog>();

            var min = Min<int>(5, 6); // invokes the method below the Main() 
            Console.WriteLine(min);


            GenericList<int> myList = new GenericList<int>();
            myList.Add(1);

            // StringCouple Exercise 

            StringCouple myStrings = new StringCouple();
            myStrings.Add("pesho", "peshov");
            myStrings.Add("ivan", "ivanov");

            Console.WriteLine(myStrings["pesho"]);

            // Overloading 

            var firstCat = new Cat(CatColor.Brown);
            firstCat.Gender = Gender.Male;
            var secondCat = new Cat(CatColor.Black);
            secondCat.Gender = Gender.Female;
            var result = firstCat + secondCat;
            Console.WriteLine(result.Color);

            if (firstCat)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.WriteLine(firstCat*secondCat);

        }

        public static T Min<T>(T first, T second) where T : IComparable<T>
        {
            if (first.CompareTo(second) <=0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
