using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Age = new List<int>();

            Age.Add(17);
            Age.Add(18);

            List<string> name = new List<string>();

            name.Add("Kelly");

            CustomList<string> carList = new CustomList<string>();

            carList.Add("Honda");
            carList.Add("Jeep");


        }
    }
}

