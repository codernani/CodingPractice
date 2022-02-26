using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class LongestSubstring
    {
        public static string LongestSubstringWithoutDuplication(string str)
        {
            // Write your code here "clementisacap"

            Dictionary<char,int> lastseen = new Dictionary<char,int>();
            int[] longest = { 0, 1 };
            int stidx = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (lastseen.ContainsKey(c)) // idi teliyaledu 
                {
                    stidx = Math.Max(stidx, lastseen[c] + 1);
                }
                if (longest[1] - longest[0] < i + 1 - stidx) // idi teliyaledu 
                {
                    longest = new int[] {stidx,i+1 };
                }
                lastseen[c] = i;
            }
            
            return str.Substring(longest[0],longest[1]-longest[0]);
        }
    }
}
// because paina mark chesina teliyani points valla was not able to solve this problem.. this is actually not hard.
// length of substring ante index+1 - startindex chesina vasthadi.
