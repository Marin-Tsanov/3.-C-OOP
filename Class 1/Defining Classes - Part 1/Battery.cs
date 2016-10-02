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
        NiCd
    }

    public class Battery
    {
        #region Fields
        private string model;
        private string hoursIdle;
        private string hoursTalk;

        #endregion

        #region Constructors

        public Battery( string model) // constructor 1
        {
            this.model = model;
        }

        public Battery(string model,string hoursIdle):this(model) // constructor 2
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
        }

        public Battery(string model, string hoursIdle,string housTalk):this(model,hoursIdle) // constructor 3
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = housTalk;
        }

        #endregion

        #region Properties

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public string HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public BatteryType batteryType { get; set; }

        #endregion
    }
}
