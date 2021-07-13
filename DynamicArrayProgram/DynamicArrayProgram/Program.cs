using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray _dynamicArray = new DynamicArray(6);

            _dynamicArray[0] = 10;
            _dynamicArray[1] = 20;
            _dynamicArray[2] = 30;
            _dynamicArray[3] = 40;
            _dynamicArray[4] = 50;
            _dynamicArray[5] = 60;
            _dynamicArray[6] = 70;
            int count = _dynamicArray[6];
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
