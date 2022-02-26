using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Anagrams
    {
        //// quick test case: ["yo", "act", "flop", "tac", "foo", "cat", "oy", "olfp"]
        //public static List<List<string>> groupAnagrams(List<string> words)
        //{
        //    // Write your code here.
        //    Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

        //    foreach (string word in words)
        //    { 
        //      char[] vs = word.ToCharArray(); // what could this value be?
        //        Array.Sort(vs); // after sorting what do we store this in?? a string or a list??
        //        string sorted = new string(vs); // here we will get a sorted string
        //        if (result.ContainsKey(sorted))
        //        {
        //            result[sorted].Add(word);
        //        }
        //        else { 
        //          result[sorted] = new List<string> { word };
        //        }

        //    }
        //    return result.Values.ToList();
        //}
        
            public bool IsAnagram(string s, string t)
            {
                Dictionary<char, int> s1 = new Dictionary<char, int>();
                Dictionary<char, int> t1 = new Dictionary<char, int>();
                int count = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s1.ContainsKey(s[i]))
                        s1[s[i]]++;
                    else
                        s1.TryGetValue(s[i], out count);
                        s1[s[i]] = count + 1;
                }

                for (int j = 0; j < t.Length; j++)
                {
                    if (t1.ContainsKey(t[j]))
                        t1[t[j]]++;
                    else
                        t1.TryGetValue(t[j], out count);
                    t1[t[j]] = count + 1;
                }
            int countBool = 0;
                foreach (KeyValuePair<char, int> kvp in s1)
                {
                if (t1[kvp.Key] == s1[kvp.Key])
                    countBool++;
                else
                    continue;
                }
                if (countBool == s1.Count)
                return true;
                else
                return false;
            }
        
    }
}
