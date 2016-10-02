

namespace _13.Enumerations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public enum BrandType
    {
        BMW = 10,       // numbers are given to the cars,if not 
        Mercedes = 20,  // the complier would set automatically
        Ferrari = 2,    // numbers to them from top to bottom 
        Nissan = 3,     // starting from 0 to 4
        Lada = 4
    }

    public enum ModelType
    {
        BMW355 = 355,
        BMW354 = 354,
        GTR = 2
    }
}
