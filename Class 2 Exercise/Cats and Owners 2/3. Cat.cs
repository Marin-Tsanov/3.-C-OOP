

namespace Cats_and_Owners_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Cat
    {
        // Fields

        // Constructors

        public Cat(CatColor color)
        {
            this.Color = color;
        }

        // Properties

        public string Name { get; set; }

        public int Age { get; private set; }

        public CatColor Color { get; private set; }

        public Owner Owner { get; set; }
    }
}
