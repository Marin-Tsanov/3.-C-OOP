using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var carTires = new Tire[]
            {
                new Tire("Brand1","Winter"),
                new Tire("Brand1","Winter"),
                new Tire("Brand1","Winter"),
                new Tire("Brand1","Winter")

            };

            var car = new Car(10000, "Model", "Brand", carTires);
        }
    }

    public class Car
    {
        private Tire[] tires;

        public decimal Price { get; set; }

        public string Model { get; set; }

        public string Brand { get; set; }

        public Tire[] Tires
        {
            get
            {
                return this.tires;
            }
            set
            {
                if (value.Length > 4)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.tires = value;
                }

            } 

        }

        public Car(decimal price, string model, string brand, Tire[] tires)
        {
            this.Tires = tires;
            this.Price = price;
            this.Model = model;
            this.Brand = brand;
        }
    }

    public class Tire
    {
        public string Brand { get; set; }

        public string Season { get; set; }

        public Tire( string brand, string season)
        {
            this.Brand = brand;
            this.Season = season;
        }
    }
}