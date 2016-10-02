using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd,
    }

   public class Battery
    {
        // Fields

        private string model;
        private int hoursidle;
        private int hourstalk;
        private BatteryType batteryType;

        // Constructors

        public Battery()
        {
        }
        
        public Battery(string model, int hoursidle, 
            int hourstalk,BatteryType batteryType)
        : this()
        {
            this.Model = model;
            this.Hoursidle = hoursidle;
            this.Hourstalk = hourstalk;
            this.BatteryType = batteryType;
        }


        // Properties

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Hoursidle
        {
            get { return this.hoursidle; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hoursidle must be a posivite value, greater than 0");
                }
                this.hoursidle = value;
            }
        }

        public int Hourstalk
        {
            get { return this.hourstalk; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hourstalk must be a posivite value, greater than 0");
                }
                this.hourstalk = value;
            }
        }

        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set
            {
                if (!Enum.IsDefined(typeof(BatteryType), value))

                { 
                    throw new ArgumentException("BatteryType can only be : LiIon, NiMH, NiCd");
                }

                this.batteryType = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}",
                this.model, this.hoursidle, this.hourstalk, this.batteryType);
        }

    }
}