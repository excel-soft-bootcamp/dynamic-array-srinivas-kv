using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayProgram
{
    class DynamicArray
    {
        int[] bufferArray;


        public DynamicArray()
        {
            bufferArray = new int[6];
        }
        public DynamicArray(int add)
        {
            bufferArray = new int[add];
        }


        public int this[int index]
        {
            set
            {
                Array.Resize(ref bufferArray, index + 6);
                bufferArray[index] = value;
            }
            get
            {
                return bufferArray[index];
            }
        }
    }
}

