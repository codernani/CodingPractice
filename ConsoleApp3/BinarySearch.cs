using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class BinarySearch
    {
        public static int BinarySearch1(int[] array, int target)
        {
            // Write your code here.
            // [0, 1, 21, 33, 45, 45, 61, 71, 72, 73]   target = 32 

               
               int stidx = 0;
               int endidx = array.Length - 1;
                int mid = (stidx + endidx) / 2;

            while (stidx <= endidx)
            {
                 mid = (stidx + endidx) / 2;
                int potentialMatch = array[mid];
                if (potentialMatch > target)
                {
                    endidx = mid-1;


                }
                else if (potentialMatch < target)
                {
                    stidx = mid+1;
                }
                else if (potentialMatch == target)
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}
