using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_1
{
    class DogMeeting
    {
        static void Main()
        {
            //Console.Write("Enter first dog's name: ");
            //string dogName = Console.ReadLine();
            //Console.Write("Enter first dog's breed: ");
            //string dogBreed = Console.ReadLine();

            // Use the Dog constructor to assign name and breed
            Dog sharo = new Dog("sharo", "pomiar");
            Dog rex = new Dog("rex", "nemska ovcharka");
            var newDog = sharo + rex;
            Console.WriteLine(newDog.Name);
            Console.WriteLine(newDog.Breed);

            // Create a new dog using the parameterless constructor
            Dog secondDog = new Dog();

            // Use properties to set name and breed
            Console.Write("Enter second dog's name: ");
            secondDog.Name = Console.ReadLine();
            Console.Write("Enter second dog's breed: ");
            secondDog.Breed = Console.ReadLine();

            // Create a Dog with no name and breed
            Dog thirdDog = new Dog();

            // Save the dogs in an array
            Dog[] dogs = new Dog[] {secondDog, thirdDog };

            // Ask each of the dogs to bark
            foreach (Dog dog in dogs)
            {
                dog.SayBau();
            }
        }
    }
}