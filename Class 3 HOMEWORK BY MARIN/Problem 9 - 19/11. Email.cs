using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_9___19
{
   public static class Email
    {
        public static List<Student> EmailList(this List<Student> list,string word)
        {
            //List<Student> Email = new List<Student>();
            //foreach (var item in list)
            //{
            //    Match match = Regex.Match(item.email, word);
            //    if (match.Success)
            //    {
            //        Email.Add(item);
            //    }
            //}
            
            var Email =
                from item in list
                where item.email.IndexOf("abv.bg") != -1
                select item;
            
            return Email.ToList<Student>();
        }
    }
}
