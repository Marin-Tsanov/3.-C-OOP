

namespace Homework_by_Marin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public class GenericList<T>
    {
        private T[] elements;
        private int index;

        public GenericList()
        {
            this.elements = new T[2];
            this.index = 0;
        }

        // Methods

        public void Add(T element)
        {
            //while (index < elements.Length)
            //{
            //    this.elements[this.index] = element;
            //    this.index++;
            //}

            if (index < elements.Length)
            {
                this.elements[this.index] = element;
                this.index++;
            }
            else
            {
                //AutoGrow(elements);
                Array.Resize(ref elements, elements.Length * 2);

                this.elements[this.index] = element;
                this.index++;
            }

        }

        public T Access(int number)
        {
            T a =elements[number];
            return a;
        }

        public void RemoveAt(int indexToRemove)
        {
            elements=elements.Where((source,index) => index != indexToRemove).ToArray();
        }

        public void Insert()
        {
            
        }

        public void Clear()
        {
            Array.Clear(elements, 0, elements.Length);
        }

        public int Find(T element)
        {
            int result = Array.IndexOf(elements, element);
            return result;
        } 

        public override string ToString(/*T[] array*/)
        {
            //string concatenated = string.Join(",",
            //              array.Select(x => x.ToString()).ToArray());
            //return concatenated;
            string result = string.Join("", elements);
            return result;
        }

        public static void FindMin(T[] array)
        {
            T element = array.Min();
        }

        public static void FindMax(T[] array)
        {
            T element = array.Max();
        }

        //public void AutoGrow(T[] array)
        //{
        //    Array.Resize(ref array, array.Length * 2);
        //}

        // indexer looks like property

        public T this[int index]
        {
            get
            {
                return this.elements[index];
            }
            set
            {
                if (index < 0 || index >= this.elements.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                this.elements[index] = value;
            }
        }
    }
}
