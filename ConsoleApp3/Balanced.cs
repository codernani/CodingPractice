using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Balanced
    {
        public int BalancedString(string s)
        {
            // okavela each substring of length n/4 tiskoni count check chesthe?
            int len = 0;
            int n = s.Length / 4;
            int count = 0;

            char[] c = s.ToCharArray();
            List<char> ls = new List<char>(c);

            int n1 = ls.Count(c => c == 'Q');
            int n2 = ls.Count(c => c == 'W');
            int n3 = ls.Count(c => c == 'E');
            int n4 = ls.Count(c => c == 'R');

            return 1;
        }
    }
}
