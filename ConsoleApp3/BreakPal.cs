using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class BreakPal
    {
        
        public string BreakPalindrome(string palindrome)
        {
            // ex = aba    base condition is if palindrom is all a's bccb   sb = palidrome a , palindrome[0] = b
            //
            char[] c = palindrome.ToCharArray();
            int count = 0;
            for (int i = 0; i < palindrome.Length; i++)
            {

                if (c[i] != 'a')
                {
                    char d = c[i];
                    c[i] = 'a';
                    if (!IsPalindrome(c))
                    {
                        break;
                    }
                    else
                    {
                        c[i] = d;
                        continue;
                    }
                }
                else
                {
                    count++;
                }
            }
            if (count == palindrome.Length || IsPalindrome(c))
            {
                c[palindrome.Length - 1] = 'b';
            }
            else if (count == 1 && palindrome.Length == 1)
            {
                return "";
            }
            return String.Join("",c);
        }
        public bool IsPalindrome(char[] cha)
        {
            int stidx = 0;
            int endidx = cha.Length - 1;
            while (stidx < endidx)
            {
                if (cha[stidx] != cha[endidx])
                {
                    return false;
                }
                stidx++;
                endidx--;
            }
            return true;
        }
    }
}
