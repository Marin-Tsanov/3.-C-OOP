using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Events
{
    public class Event
    {
        static void Main()
        {
            ListWithChangedEvent list = new ListWithChangedEvent();

            Console.WriteLine("----- Adding item 1");
            
            list.Changed += ListOnChanged; // subscribe for 
                                           // the event 
// we also define that Changed != null 
            list.Add("item 1");

            Console.WriteLine("----- Clear item 1");
            
            list.Clear();
        }

        private static void ListOnChanged(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("ListOnChanged(object sender, EventArgs eventArgs)");
        }
    }
}
