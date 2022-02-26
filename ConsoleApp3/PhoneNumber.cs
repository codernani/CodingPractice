using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class PhoneNumber
    {
        //public static string CreatePhoneNumber(int[] numbers)
        //{
        //    StringBuilder sb = new StringBuilder();


        //    sb.Append("(" + numbers[0] + numbers[1] + numbers[2] + ") " + numbers[3] + numbers[4] + numbers[5] + "-" + numbers[6] + numbers[7] + numbers[8] + numbers[9]);

        //    return sb.ToString();
        //}
        // Best solution
        public static string CreatePhoneNumber(int[] numbers)
        {
            return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }
    }
}
