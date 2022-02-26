using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class ValidIP
    {
        public List<string> ValidIPAddresses(string str)
        {
            // Write your code here. 1.9.216.80  xxx.xxx.xxx.xxx 0<=n<=255 4 digit undalevu so length ki condition dorkindi

            List<string> address = new List<string>();

            string[] arr = new string[] { "", "", "", "" };

            for (int i = 1; i < Math.Min(str.Length,4); i++)
            {
                

                arr[0] = str.Substring(0,i);
                if (!Iscorrect(arr[0]))
                    continue;

                for (int j = i + 1; j < i + Math.Min(str.Length-i,4); j++)
                {
                    arr[1] = str.Substring(i, j-i);
                    if (!Iscorrect(arr[1]))
                        continue;

                    for (int k = j + 1; k < j + Math.Min(str.Length-j,4); k++)
                    {
                        arr[2] = str.Substring(j, k-j);
                        arr[3] = str.Substring(k);
                        if (Iscorrect(arr[2]) && Iscorrect(arr[3]))
                            address.Add(join(arr));
                    }
                }

               
            }
            return address;
        }

        public bool Iscorrect(string str1)
        {
            int n = Int32.Parse(str1);
            if (n > 255 || n < 0)
                return false;
            return str1.Length == n.ToString().Length;

        }

        public string join(string[] arr)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            { 
               sb.Append(arr[i]);
                if (i < arr.Length - 1)
                    sb.Append('.');
            }
            return sb.ToString();
        }
    }
}
