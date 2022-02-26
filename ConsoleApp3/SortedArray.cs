using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class SortedArray
    {
        public int[] SortedSquaredArray(int[] array)
        {

            int[] array1 = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array1[i] = array[i] * array[i];
            }
            return array1;

            
            
        }
    }
}
