
namespace Class_2_Exercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StringCouple
    {
        private List<string> keys;
        private List<string> values;

        public StringCouple()
        {
            this.keys = new List<string>();
            this.values = new List<string>();
        }

        // Indexer

            public string this[string index]
        {
            get
            {
                var indexInKeys = this.keys.IndexOf(index);
                if (indexInKeys < 0)
                {
                    throw new ArgumentException("Index was not found");
                }
                return this.values[indexInKeys];
            }
            set
            {
                var indexInKeys = this.keys.IndexOf(index);
                this.values[indexInKeys] = value;
            }
        }

        // Method
        public void Add(string key, string value)
        {
            this.keys.Add(key);
            this.values.Add(value);
        }
    }
}
