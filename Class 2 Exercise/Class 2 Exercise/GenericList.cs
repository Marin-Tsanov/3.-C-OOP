using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2_Exercise
{
    public class GenericList<T> /*where T : Animal*/ // List is strictly for Animal type
    {
        private T[] elements;
        private int index;

        public GenericList()
        {
            this.elements = new T[16];
            this.index = 0;
        }

        public void Add(T element)
        {
            this.elements[this.index] = element;
            this.index++;
        }

        // indexer looks like property

        public T this[int index]
        {
            get
            {
                return this.elements[index];
            }
            set
            {
                if (index<0 || index>= this.elements.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                this.elements[index] = value;
            }
        }
    }
}
