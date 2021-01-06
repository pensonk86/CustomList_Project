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
        public  int capacity
        {
            get { return capacity; }
        }
        public int CapacityIncrementor
        {
            get { return CapacityIncrementor; }
        }
        
        public int Count
        {
            get { return Count; }
        }
        
        //constructor
        public CustomList()
        {
            Count = 0;
            Capacity = 4;
            items = new T[Capacity];
        }

        //member methods (CAN DO)
        //1. Add item to next available index
        //2. Increment count, assuming item was added successfully
        //3. If count and capacity are the same, then create more space
        //4. 
        public void Add(int index, T Value)
        {
            if (index >= 0 && index < Count)
            {
                if (IsNearCapacity(1)) ;

                IncreaseCapacity(Count + 1);

            }    
                
            for (int i = count; i >= index; i--)
            {
                Count[index] = Count[i - 1];

            }
            Count[index] = Value;
            Count++;
            
                
            
            items[Count] = Count;
            Count++;
                
        }
            
        public void Remove(int index, T Value)
        {
            
            if(index >= 0 && index < Count)
            {
                for (int i = index; i < Count; i++)
                {
                    if (i != Count - 1)
                    {
                        Count[i] = Count[i + 1];
                    }
                    else
                    {
                        Count[i] = default(T);
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }


                    items[Count] = Count;
                    Count--;




                }


            }
            
            
            
        }
            


            


            

          





            
            








        
	{

	}
    }





}
