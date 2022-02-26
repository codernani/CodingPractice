using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class MaxAvg
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            // [1,12,-5,-6,50,3]  [-1], 1

            int winst = 0;
            double sum = 0;
            double maxavg = 0;

            for (int winen=0;winen<nums.Length;winen++)
            {
                sum += nums[winen];

                if (winen >= k - 1)
                {
                    
                    
                        maxavg = Math.Max(maxavg, sum);

                        sum -= nums[winst];
                        winst++;
                    
                   
                }
            }

            return maxavg/k;

        }
    }
}
