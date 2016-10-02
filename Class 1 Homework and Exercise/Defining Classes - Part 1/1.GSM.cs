using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
   public class GSM
    {
        // fields

        public static readonly GSM iPhone4S = new GSM("iPhone4s", "Apple", 500, "Marin Tsanov", new Battery("Li-Po", 200, 14,BatteryType.LiIon), new Display (3, 14,1000));
            
        private string model;
        private string manufacturer;  
        private int price;
        private string owner;

        private Battery battery;
        private Display display;

        private List<Call> callHitsory = new List<Call>();

        // Constructors

          
        public GSM (string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            //this.callHitsory = new List<Call>();
        }

        public GSM(string model, string manufacturer,int price, 
            string owner,Battery battery, Display display )
            : this(model,manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;/*new Battery();*/
            this.Display = display;
        }

        // Property 

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Manufacturer's lenght can't be less than 2 symbols");
                }
                this.manufacturer = value; }
        }

        public int Price
        {
            get { return this.price; }
            set {
                if (value <=0)
                {
                    throw new ArgumentException("Price can't be less or equal to 0 ");
                }
                this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set {
                if (!char.IsLetter(value[0]))
                {
                    throw new ArgumentException("Owner's first symbol must be a letter");
                }
                else
                {
                    if (!char.IsUpper(value[0]))
                    {
                        throw new ArgumentException("Owner's first symbol must be a capital letter");
                    }
                }
                this.owner = value; }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }

        }
        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public List<Call> CallHistory { get; set; }

        public string AllCalls
        {
            get
            {
                string callInfo = "";
                foreach (var item in this.callHitsory)
                {
                    Console.WriteLine(item);
                    //callInfo += item.ToString();
                    //callInfo += item.date + ", " + item.time + ", " + item.dialedphonenumber + ", "+ item.duration + "\n";
                }
                return callInfo; /*string.Join(", ", this.callHitsory);*/
            }
        }
        
        // Methods

        public override string ToString()
        {
         return string.Format("{0} {1} {2} {3} {4} {5}\n",
             this.model,this.manufacturer, this.price, this.owner,this.battery.ToString(),this.display.ToString()); 
        }

        public void AddCall(Call callToAdd)
        {
            this.callHitsory.Add(callToAdd);
        }
        
        public void RemoveCall()
        {
            this.callHitsory.OrderBy(x => x.duration);
            this.callHitsory.RemoveAt(this.callHitsory.Count - 1); 
        }

        public void clearCallHistory()
        {
            this.callHitsory.Clear();
        }
        
        public double CallPrice(double priceperminute)
        {
            double sum = 0;
            foreach (var call in this.callHitsory)
            {
                sum += priceperminute*call.duration/60;
            }
            return sum;
        }
    }
}
