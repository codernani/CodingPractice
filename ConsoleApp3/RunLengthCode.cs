using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class RunLengthCode
    {
		public string RunLengthEncoding(string str)
		{
			// Write your code here.
			StringBuilder cls = new StringBuilder(); // stringbuilder is used in place of list because it is easy to
													 // convert to string at the end as we return a string as result...
			int currentLength = 1;
			for (int i = 1; i < str.Length; i++)
			{
				char currentChar = str[i];
				char prevChar = str[i - 1];

				if ((currentChar != prevChar) || (currentLength == 9))
				{
					cls.Append(currentLength.ToString());
					cls.Append(prevChar);
					currentLength = 0;
				}

				currentLength += 1;
			}
			cls.Append(currentLength.ToString());
			cls.Append(str[str.Length - 1]);
			return cls.ToString();
		}
	}
}
