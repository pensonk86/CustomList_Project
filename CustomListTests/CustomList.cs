using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTests
{
    class CustomList<T>
    {   //member variables
        T[] items = new T[4];

        public int Count;
        public int Capacity;

        //constructor
        public CustomList()
        {
            Count = 0;
        }



    }





}
