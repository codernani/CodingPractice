using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class OddCount
    {

        public string GenerateTheString(int n)
        {

            return n % 2 == 0 ? new string('a', n - 1) + "b" : new string('a', n);
        }
    }
            
    }

// Alternate solution and perfect one when n>0
//public string GenerateTheString(int n)
//{
//    return n % 2 == 0 ? new string('a', n - 1) + "b" : new string('a', n);
//}