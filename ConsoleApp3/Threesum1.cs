//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    internal class Threesum1
//    {
//        public IList<IList<int>> ThreeSum(int[] nums)
//        {

//            // a+b+c = 0.... a+b = -c  this becomes a 2sum?  a = -c-b
//            List<List<int>> triplet = new List<List<int>>();
//            List<int> sub = new List<int>();
//            for (int i = 0; i < nums.Length; i++)
//            {
//                for (int j = 0; j < nums.Length; j++)
//                {
//                    if (i != j)
//                    {
//                        int match = -nums[i] - nums[j];
//                        if (sub.Contains(match))
//                        {
//                            triplet.Add(sub.Add());
//                        }
//                    }
//                    else
//                        break;

//                }
//            }
//            return triplet;
//        }
//    }
//}
