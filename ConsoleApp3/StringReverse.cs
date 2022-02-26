using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class StringReverse
    {
		public string ReverseWordsInString(string str)
		{
			// Write your code here.
			//Reversing the string
			//StringBuilder sb = new StringBuilder();
			//for (int i = str.Length - 1; i >= 0; i--)
			//{
			//	sb.Append(str[i]);
			//}
			List<string> ls = new List<string>();

			int Startword = 0;

			for (int i = 0; i < str.Length; i++)
			{
				char c = str[i];

				if (c == ' ')
				{
					ls.Add(str.Substring(Startword, i - Startword));
					Startword = i;
				}
				else if (str[Startword] == ' ')
				{
					ls.Add(" ");
					Startword = i;
				}
			}

			ls.Add(str.Substring(Startword));
			ls.Reverse();




			return String.Join("", ls);
		}
	}
}
