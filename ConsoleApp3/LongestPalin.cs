using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class LongestPalin
    {
		public static string LongestPalindromicSubstring(string str)
		{
			
			string longest = "";
			string str1 = "";
			
			for (int i = 0; i < str.Length; i++)
			{
				for (int j = i; j < str.Length; j++)
				{
					
					if (str[i] == str[j])
					{
						str1 = str.Substring(i, j+1-i); // this is a way to avoid indexoutofbound error while using substring in iteration
						
						

						if (longest.Length < str1.Length && IsPalindrome(str1))
						{ 
						 longest = str1;
						}
					}
				}
			}
			return longest;
		}

		public static bool IsPalindrome(string str)
		{
			
			int leftindex = 0;
			int rightindex = str.Length - 1;

			while (leftindex < rightindex)
			{
				if (str[leftindex] != str[rightindex])
					return false;
				leftindex++;
				rightindex--;
			}
			return true;
		}
	}
}
