

namespace _13.Enumerations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Car
    {
        public decimal Price { get; set; }

        public ModelType Model { get; set; }

        public BrandType Brand { get; set; }

        public Car(decimal price, ModelType model, BrandType brand)
        {
            this.Price = price;
            this.Model = model;
            this.Brand = brand;
        }

        public void Introduce()
        {
            Console.WriteLine($"{this.Brand} - {this.Model} - {this.Price}");
        }
    }
}
