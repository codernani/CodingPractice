using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class GenerateDocument
    {
		public bool GenerateDocument1(string characters, string document)
		{
			// This program needs to be looked at again.
			int count = 0;
			char[] cs = characters.ToCharArray();
			for (int i = 0; i < document.Length; i++)
			{
				for (int j = 0; j < characters.Length; j++)
				{
					if (document[i] == characters[j])
					{
						count += 1;
					}
				}
				if (count != cs.Count(c => c == characters[i]))
					return false; // this is a question to be asked	
				  count = 0;
			}

			return true;
		}
	}
}
