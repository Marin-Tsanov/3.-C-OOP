using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car(270, 20000, "335", "BMW");
            Car nissan = new Car(300, 100000, "GT-R 2015", "Nissan");
            Car lada = new Car(60, 2000, "1500-S", "Lada");

            List<Car> cars = new List<Car>()
            {
                bmw,
                nissan,
                lada
            };

            foreach(var car in cars)
            {
                car.Drive();
            }

        }
    }

    public class Car
    {
        public int MaxSpeed { get; set; }

        public decimal Price { get; set; }

        public string Model { get; set; }

        public string Brand { get; set; }

        public Car(int maxSpeed, decimal price, string model, string brand)
        {
            this.MaxSpeed = maxSpeed;
            this.Price = price;
            this.Model = model;
            this.Brand = brand;
        }

        public void Drive()
        {
            Console.WriteLine($"I am {this.Brand}-{this.Model}, and I can reach {this.MaxSpeed} kms/h.");
        }
    }
}
