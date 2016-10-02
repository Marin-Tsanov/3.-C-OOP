using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Events
{
    public delegate void ChangeEventHandler(object sender, EventArgs e);

    public class ListWithChangedEvent : ArrayList
    {
        public event ChangeEventHandler Changed;

        public override int Add(object value)
        {
            this.OnChanged();

            return base.Add(value);
        }

        public override void Clear()
        {
            this.OnChanged();

            base.Clear();
        }

        private void OnChanged()
        {
            if (this.Changed != null)
            {
                this.Changed(this, EventArgs.Empty);
            }
        }
    }
}
