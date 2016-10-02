

namespace Defining_Classes___Part_1
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
        }
    }

    class GSM
    {
        #region Fields

        private string model;
        private string manufacturer;
        private string price;
        private string owner;

        private Battery battery;
        private Display display;
       
        #endregion 

        public GSM (string model, string manufacturer) // constructor 1
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public GSM (string model, string manufacturer, string price,string owner) : this(model,manufacturer) // constructor 2
        {
            this.model=model;
            this.manufacturer=manufacturer;
            this.price = price;
            this.owner = owner;
        }
        
        public string Model                             // property
        {
            get { return this.model; }

            set { this.model = value; }
        }

        public string Manufacturer                      // property
        {
            get { return this.manufacturer; }

            set { this.manufacturer = value; }
        }

        public string Price                             // property
        {
            get { return this.price; }

            set { this.price = value; }
        }

        public string Owner                             // property
        {
            get { return this.owner; }

            set { this.owner = value; }
        }

        public Battery Battery                          // property
        {
            get { return this.battery; }
        }

        public Display Display                          // property
        {
            get { return this.display; }
        }
    }

}
