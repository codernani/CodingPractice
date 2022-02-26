using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class smallDiff
    {
		public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
		{
			// Write your code here.
			// difference closest to 0   -1, 2 ,4, 5,   -1 closest dani integers kavali
			// [28,26]....
			Dictionary<string, int> ds = new Dictionary<string, int>();
			
			int minDiff = int.MaxValue;

			int[] x = new int[2];

			for (int i = 0; i < arrayOne.Length; i++)
			{
				for (int j = 0; j < arrayTwo.Length; j++)
				{
					int diff = Math.Abs(arrayOne[i] - arrayTwo[j]);

					if (diff < minDiff)
					{
						minDiff = diff;
						x[0] = arrayOne[i];
						x[1] = arrayTwo[j];
					}
				
			    }
				
			}
			return x;
		}
	}
}
