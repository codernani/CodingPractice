using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class PrimeOrNot
    {
        // if prime return 1 else return the smallest divisor of the number

        public static int prime(int n)
        {
            int count = 0;
            List<int> list = new List<int>();
            // prime ante divisible by 2 numbers  n= 5
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count = count + 1;
                    list.Add(i);
                }

            }

            if (count == 2)
                return 1;
            else
                return list[1];




        }
    }
}
