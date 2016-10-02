using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemos
{
    //class Person
    //{
    //    public string Name
    //    {
    //        get;
    //        set;
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            int planetSum = 
                AndromedaGalaxy.PlanetsCount 
              + MilkyWayGalaxy.PlanetsCount;

            Console.WriteLine(planetSum);
        }
    }

    class AndromedaGalaxy // const
    {
        public const int PlanetsCount = 1928;
    }

    class MilkyWayGalaxy
    {
        public const int PlanetsCount = 8;
    }
}
 