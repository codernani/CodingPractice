using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class MaxSum
    {
        // Given an array of numbers, find the maximum sum of any contiguous subarray of the array.
        //For example, given the array[34, -50, 42, 14, -5, 86],
        //the maximum sum would be 137, since we would take elements 42, 14, -5, and 86.
        //Given the array[-5, -1, -8, -9], the maximum sum would be 0, since we would not take any elements.

        public int sum(int[] arr) 
        {
            int sum = 0;
            int maxsum = Int32.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (arr[i] > sum)
                {
                    sum = arr[i];
                }
                if (sum > maxsum)
                { 
                   maxsum = sum;
                }
            }

            return maxsum;
        }
    }
}
