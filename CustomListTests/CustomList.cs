using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTests
{
    class CustomList<T>
    {   //member variables (HAS A)
        private T[] items;

        public int Count;
        public int Capacity;

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < Count)
                {
                    return items[index];
                }
                throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < Count)
                {
                    items[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

        }

        //constructor
        public CustomList()
        {
            Count = 0;
            Capacity = 4;
            items = new T[Capacity];
        }

        //member methods (CAN DO)
        public void Add(T item)
        {
            //1. Add item to next available index
            //2. Increment count, assuming item was added successfully
            //3. If count and capacity are the same, then create more space
            //4. 
            items[Count] = item;
            Count++;
        }








    }





}
