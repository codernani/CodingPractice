using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class UnderscorifySubstring
    {
        // string = "testthis is a testtest to see if testestest it works", ss = "test"
        // string lo asalu substring unda leda chudali (idi na biggest problem) ans: IndexOf(). next okavela unte ah substring start and end index
        public static string UnderscorifySubstring1(string str, string substr)
        {
            // Write your code here.
            List<int[]> locations = new List<int[]>();

            int stidx = 0;

            while(stidx < str.Length)
            {
               int nxtidx = str.IndexOf(substr, stidx);
                if (nxtidx != -1)
                {
                    locations.Add(new int[] { nxtidx, nxtidx + substr.Length });
                }
                else
                {
                    break;
                }
            }
            
            
            return null;
        }
        
    }
}
