
namespace Defining_Classes___Part_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GSMCallHistoryTest
    {
        public static void Main()
        {
            var marinGSM = new GSM("Galaxy S4", "Samsung", 300, "Johny Penkov", new Battery("Li-Po", 200, 14, BatteryType.LiIon), new Display(5, 12, 1200));

            var firstCall = new Call("11-06-2016", "14-53-25", "0883356972", 60);
            var secondCall = new Call("12-06-2016", "14-53-25", "0883356972", 60);
            var thirdCall = new Call("14-06-2016", "14-53-25", "0883356972", 60);
            var fourthCall = new Call("15-06-2016", "14-53-25", "0883356972", 80);

            marinGSM.AddCall(firstCall);
            marinGSM.AddCall(secondCall);
            marinGSM.AddCall(thirdCall);
            marinGSM.AddCall(fourthCall);

            Console.WriteLine(marinGSM.AllCalls);

            Console.WriteLine(marinGSM.CallPrice(0.37));

            marinGSM.RemoveCall();

            Console.WriteLine(marinGSM.CallPrice(0.37));

            marinGSM.clearCallHistory();

            Console.WriteLine(marinGSM.AllCalls);
        }
    }
}