
namespace Simple_Class
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            Dog first = new Dog("Sharo", "Pomiar");
            //first.Name = "Sharo";
            //first.Breed = "Pomiar";

            Dog second = new Dog("Osman", "Kazak");
            //second.Name = "Osman";
            //second.Breed = "Kazak";

            Dog[] dogs = new Dog[] { first, second };

            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog.BauBau());
            }
        }
    }
}
