using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ThreeSum
    {
        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            // Write your code here.   i/p: [12, 3, 1, 2, -6, 5, -8, 6], 0     o/p = [[-8,2,6],[-8,3,5],[-6,1,5]]
            // targetsum 8 aithe idi work avvadhu :: a+b+c=ts ante ts-c = a+b
            // a = -8, b=2, c=6 ts = 0... a+b = tmpsum, pairs osthai 
            // sum = a+b+c  array iterate chesi each number tiskunte? 
            // first array sort chesthe [-8,-6,1,2,3,5,6,12] 
            // a+b = sum .....  sum telsu, a = arr[j], b vasthadi 
            // 12 , sum = -12, 
            // 3, b = -12-3 = -15,     a+b = sum 
            // TO BE COMPLETED
            List<int[]> result = new List<int[]>();
            int ts = targetSum;
            List<int> cont = array.ToList();
            

            for (int i = 0; i < array.Length; i++)
            {
                //int c = array[i];

                //int sum = ts - c;

                for (int j = 0; j < array.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {


                        int match = -array[i] - array[j];

                        if (cont.Contains(match) && i != Array.IndexOf(array,match) && j!= Array.IndexOf(array, match))
                        { 
                          result.Add( new int[] { array[i], match, array[j] });
                            result = result.Distinct().ToList();
                        }
                    }
                }

            }

            foreach (int[] i in result)
            {
                Console.WriteLine(i[0] + " " + i[1]+ " "+i[2]);
            }

            return result;
        }
    }
}
