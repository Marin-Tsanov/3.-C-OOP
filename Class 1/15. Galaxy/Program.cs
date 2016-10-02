using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Galaxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Andromeda andromeda = new Andromeda();
            MilkyWay milkyWay = new MilkyWay();

            Console.WriteLine(Andromeda.PlanetsCount+
                              MilkyWay.PlanetNumber);
        }
    }
}
