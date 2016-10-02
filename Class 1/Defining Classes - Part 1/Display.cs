using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    class Display
    {
        private string size;
        private string numberOfColors;

        public Display (string size) // constructor 1
        {
            this.size = size;
        }

        public Display (string size,string numberOfColors)  // constructor 2
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        public string Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public string NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value;}
        }
    }
}
