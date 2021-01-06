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

        private int count;
        

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
        public  int Capacity
        {
            get; set;
        }
        
        
        public int Count
        {
            get { return count; }
        }
        
        //constructor
        public CustomList()
        {
            count = 0;
            Capacity = 4;
            items = new T[Capacity];
        }

        //member methods (CAN DO)
        //1. Add item to next available index
        //2. Increment count, assuming item was added successfully
        //3. If count and capacity are the same, then create more space
        //4. 
        public void Add(T Value)
        {
            string[] carList = new string[5];
            carList[0] = "Toyota";
            carList[1] = "Honda";
            carList[2] = "Jeep";
            carList[3] = "Mazda";
            carList[4] = "Nissan";



        }
        
            
        //public void Remove(int index, T Value)
        //{
            
        //    if(index >= 0 && index < Count)
        //    {
        //        for (int i = index; i < Count; i++)
        //        {
        //            if (i != Count - 1)
        //            {
        //                Count[i] = Count[i + 1];
        //            }
        //            else
        //            {
        //                Count[i] = default(T);
        //            }
        //            else
        //            {
        //                throw new ArgumentOutOfRangeException();
        //            }


        //            items[Count] = Count;
        //            Count--;




        //        }


            }
            
            
            
        }
            


            


            

          





            
            








        
	{

	}
    }





}
