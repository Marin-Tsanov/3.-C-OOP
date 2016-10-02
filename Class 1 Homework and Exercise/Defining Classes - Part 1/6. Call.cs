using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Defining_Classes___Part_1
{
    public class Call
    {
        // fields

        public string date;
        public string time;
        public string dialedphonenumber;
        public double duration;

        // Constructors

       public Call (string date,string time, 
					string dialedphonenumber,double duration)
        {
            this.Date = date;
            this.Time = time;
			this.Dialedphonenumber = dialedphonenumber;
            this.Duration = duration;
        }

		// Properties

        public string Date
        {
            get { return this.date; }
            set
            {
                //value = DateTime.Now.ToString("dd-MMM-yyyy");
                this.date = value;
            }
        }

        public string Time
        {
            get { return this.time; }
            set
            {
                //value = DateTime.Now.ToString("hh-mm-ss");
                this.time = value; }
        }

        public string Dialedphonenumber
        {
            get { return this.dialedphonenumber; }
            set
            {
                this.dialedphonenumber = value;
                if (value.Length<10 && Regex.IsMatch(value, @"^\d+$") 
					&& value[0]!='0' && value[1] != '8')
                {
                    throw new ArgumentException("Phone number must be 10 digit number starting  with \"08\"");
                }
            }
        }

		public double Duration
        {
            get { return this.duration; }
            set {
                if (value<=0)
                {
                    throw new ArgumentException("Duration can'be less than 0");
                }
                this.duration = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}",
                this.date, this.time, this.dialedphonenumber, this.duration);
        }
    }
}
