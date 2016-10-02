using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_4_OOP_Principles_class_4_EXERCISE
{
    class Program
    {
        static void Main()
        {
            //Dog joe = new Dog(8, "Labrador");
            //Cat kitty = new Cat(10);

            Dog joe = new Dog(8);
            Cat kitty = new Cat(10);

            Mammal[] mammals = { joe, kitty };
            foreach (var item in mammals)
            {
                item.Move();
            }

            //joe.Move();
            //kitty.Move();
            //kitty.
        }
    }
}
