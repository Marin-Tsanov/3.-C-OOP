using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9___19
{
    public static class GroupedByGroupName
    {
        public static void GroupName( this List<Student> list)
        {
            var groupedByName =
                from item in list
                group item by item.firstName;

            foreach (var group in groupedByName)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine(item.lastName);
                }
                Console.WriteLine("---------");
            } 
        }
    }
}
