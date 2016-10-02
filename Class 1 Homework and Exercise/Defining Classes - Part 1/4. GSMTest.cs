
namespace Defining_Classes___Part_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class GSMTest
    {
        public static void GSMTest1()
        {
            GSM[] phones = new GSM[]
            {
                new GSM("Galaxy S4", "Samsung", 300, "Johny Penkov", new Battery("Li-Po", 200, 14,BatteryType.LiIon), new Display (5, 12,1200)),
                new GSM("Galaxy S", "Samsung", 500, "Radka Piratka", new Battery("Li-Po", 300, 24,BatteryType.NiCd), new Display (3, 14,1000))
            };
            
            foreach (var phone in phones)
            {
                Console.WriteLine(phone.ToString());
            }

            Console.WriteLine(GSM.iPhone4S);
        }
        
    }
}
