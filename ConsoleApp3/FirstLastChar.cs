using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class FirstLastChar
    {
        public static string Remove_char(string s)
        {
            if (s.Length <= 2)
            {
                return "";
            }


            //StringBuilder sb = new StringBuilder(s);
            //sb.Remove(0, 1);
            //sb.Remove(sb.Length - 1,1);

            return s.Remove(s.Length-1,1).Remove(0,1);

        }
    }
}
