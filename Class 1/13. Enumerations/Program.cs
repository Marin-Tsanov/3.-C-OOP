using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(9999, ModelType.GTR, BrandType.Nissan/*10*/);

            car.Introduce(); 
        }
    }
}
