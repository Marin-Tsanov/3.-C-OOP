using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_4_Exercise_and_homework_by_Marin
{
    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Speed { get; set; }

        public Car(string make, string model, int speed)
        {
            this.Make = make;
            this.Model = model;
            this.Speed = speed;
        }

    }
}
