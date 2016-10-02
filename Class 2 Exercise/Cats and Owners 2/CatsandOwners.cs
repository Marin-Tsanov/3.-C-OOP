

namespace Cats_and_Owners_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CatsAndOwners
    {
        public static void Main()
        {
            var peshoOwner = new Owner("Pesho", "Ivanov");
            var goshoOwner = new Owner("Gosho", "Petrov");
            
            var age = peshoOwner.Age;

            peshoOwner.IncreaseAge();
            Console.WriteLine(peshoOwner.FullName); 

            Console.WriteLine(peshoOwner.Age);

            var cat = new Cat(CatColor.Mixed);
            var anotherCat = new Cat(CatColor.Black);
            var yetAnotherCat = new Cat(CatColor.Brown);

            peshoOwner.AddCat(cat, "Maca");
            peshoOwner.AddCat(anotherCat, "Silvester");

            Console.WriteLine(peshoOwner.AllCats);

            //List<int> numbers = new List<int>();
            //numbers.Add(5);


        }
    }
}
