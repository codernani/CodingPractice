using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Nonrepeating
    {
        public int FirstNonRepeatingCharacter(string str)
        {
            // Need to know in detail about GetValueOrDefault method.
            Dictionary<char, int> result = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            { 
              char character = str[i];
              
                result[character] = result.GetValueOrDefault(character,0) + 1;

            }

            for (int i = 0; i < str.Length; i++)
            {
                char character = str[i];

                if(result[character] == 1)
                    return i;

            }
            return -1;
        }
    }
}
