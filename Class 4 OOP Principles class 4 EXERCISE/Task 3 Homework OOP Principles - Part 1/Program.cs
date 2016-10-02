using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Homework_OOP_Principles___Part_1
{
   public class Program
    {
        static void Main(string[] args)
        {
            Animal[] array =
            {
                new Dog(1,"Sharo","Male",1),
                new Dog(3,"Love","Female",1),
                new Frog(5,"Kwak","Male",2),
                new Cat(2,"Matsa","Female",3),
                new Kitten(8,"Kitty","Female",4),
                new Tomcat(6,"Tom","Male",5)
            };

            var averageAge = (from animal in array
                              select animal.Age).Average();

            Console.WriteLine(averageAge);

            int[] arrayID = new int[] { 1, 2, 3, 4, 5 };

            foreach (var item in arrayID)
            {
                var result = (from animal in array
                              where animal.ID == item
                              select animal.Age).Average();
                Console.WriteLine(result);
            }

            //Animal animal = new Animal(3, "Lucky", "Male");

            //Console.WriteLine(animal.Age);
            //Console.WriteLine(animal.Name);
            //Console.WriteLine(animal.Sex);
            //animal.Sound();

            //Cat cat = new Cat(0, "Whiskas", "female");

            //Console.WriteLine(cat.Age);
            //Console.WriteLine(cat.Name);
            //Console.WriteLine(cat.Sex);
            //cat.Sound();

            //Kitten kitty = new Kitten(0, "Kitty", "Female");

            //Console.WriteLine(kitty.Age);
            //Console.WriteLine(kitty.Name);
            //Console.WriteLine(kitty.Sex);
            //kitty.Sound();

            //Tomcat tomcat = new Tomcat(1, "Tomy", "Male");

            //Console.WriteLine(tomcat.Age);
            //Console.WriteLine(tomcat.Name);
            //Console.WriteLine(tomcat.Sex);
            //tomcat.Sound();

        }
    }
}
