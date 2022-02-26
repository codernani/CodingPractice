using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Caesar
    {
		public static string CaesarCypherEncryptor(string str, int key)
		{
			// Write your code here.
			string str1 = "abcdefghijklmnopqrstuvwxyz";
			string str2 = "";
			int newkey = key % 26;
			for (int i = 0; i < str.Length; i++)
			{
				char letter = str[i];
				int indx = (str1.IndexOf(letter) + newkey) % 26;
				str2 += str1[indx];
			}
			return str2;
		}
	}
}
