using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Twosum
    {
       
            public int[] TwoSum(int[] nums, int target)
            {

                HashSet<int> result = new HashSet<int>();
            for(int i=0;i<nums.Length;i++)
            { 
             int match = target - nums[i];
                if (result.Contains(match))
                    return new int[] { Array.IndexOf(nums, match), i };
                else if (!result.Contains(nums[i]))
                    result.Add(nums[i]); 
                
            }
            return new int[2];
            }
        }
    
}
