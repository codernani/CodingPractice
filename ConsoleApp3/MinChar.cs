using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class MinChar
    {
        public string[] MinCharForWords(String[] words)
        {
            // test case ["this", "that", "did", "deed", "them!", "a"]
            // Solution:1
            //List<char> result = new List<char>();
            
            //char[] c = new char[words.Length];

            //for (int i = 0; i < words.Length; i++)
            //{

            //    c = words[i].ToCharArray();

            //    for (int j = 0; j < c.Length; j++)
            //    {
            //        if (!result.Contains(c[j]))
            //        {
            //            result.Add(c[j]);
            //        }

            //        if (words[i].Count(s => s == c[j]) > result.Count(s => s == c[j]))
            //        {
            //            result.Add(c[j]);
            //        }
            //    }

            //}
            //String[] the_array = result.Select(i => i.ToString()).ToArray();

            // Solution:2

            Dictionary<String,int> ds = new Dictionary<String,int>();

            
            

            return null;
        }
    }
}
