
namespace Exercise1_Attributes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [AttributeUsage(AttributeTargets.Struct |
     AttributeTargets.Class | AttributeTargets.Interface,
     AllowMultiple = true)]
    public class AuthorAttribute : System.Attribute
    {
        public string Name { get; private set; }

        public AuthorAttribute(string name)
        {
            this.Name = name;
        }

        [Author("Doncho Minkov")]
        [Author("Nikolay Kostov")]
        class CustomAttributesDemo
        {
            static void Main(string[] args)
            {
                Type type = typeof(CustomAttributesDemo);
                object[] allAttributes =
                  type.GetCustomAttributes(false);
                foreach (AuthorAttribute attr in allAttributes)
                {
                    Console.WriteLine(
                      "This class is written by {0}. ", attr.Name);
                }
            }
        }
    }
}
