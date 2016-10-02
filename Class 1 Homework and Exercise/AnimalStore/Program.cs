
namespace AnimalStore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            var ivan = new Horse();
            ivan.name = "Ivan";
            ivan.SayMyName();

            var pesho = new Horse() { name = "Pesho" };
            pesho.SayMyName();

        }
    }
}
