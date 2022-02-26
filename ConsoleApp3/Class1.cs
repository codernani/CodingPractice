namespace ConsoleApp3
{
    public class Class1
    {
        public static int[] IsReversed(int[] arr, int ts)
        {


            //Two number sum 

            //HashSet<int> set = new HashSet<int>();

            //foreach (int i in arr)
            //{ 
            //  int match = ts - i;

            //    if (set.Contains(match))
            //        return new int[] { match, i };
            //    else
            //        set.Add(i);
            //}
            //return new int[0];

            // To-Do this using lists and note the difference

            List<int> ls = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            { 
              int a = ts - arr[i];
                if (ls.Contains(a))
                    return new int[] { a, arr[i] };
                else
                    ls.Add(a);
            }
            return new int[0];

            //if (string.IsNullOrEmpty(s))
            //    Console.WriteLine("String " + s + " is null or empty..!!");
            //    //return s;

            ////Solution: 1;

            ////string s1 = "";

            ////for (int i = s.Length - 1; i>=0 ; i--)
            ////{
            ////    s1 += s[i];

            ////}

            //char[] c = s.ToCharArray();

            //char[] c2 = new char[c.Length];

            //int j = 0;

            //for (int i = s.Length - 1; i >= 0; i--)
            //{


            //    while (j < c.Length)
            //    {

            //        c2[j] = c[i];

            //        Console.WriteLine(c2[j]);

            //        j++;



            //        break;

            //    }



            //}


            //Array.Reverse(c);

            //return new String(c);


            // Union of two Arrays

            //List<int> ls = new List<int>();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    ls.Add(arr[i]);
            //}

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    ls.Add(arr1[i]);
            //}

            //foreach (int i in ls)
            //{
            //    Console.Write(i + " ");
            //}

            // Intersection of Arrays using Lists. This needs to be fixed    

            //List<int> ls1 = new List<int>();

            //for (int i = 0; i < arr.Length; i++)
            //{ 
            //    ls1.Add(arr[i]);
            //}


            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    if (ls1.Contains(arr1[i]))
            //    {
            //        Console.WriteLine(ls1[i]);
            //    }
            //}



            // Intersection of Arrays using HashSet

            //HashSet<int> hs = new HashSet<int>();

            //for (int i = 0; i < arr.Length; i++)
            //{ 
            //  hs.Add(arr[i]);
            //}


            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    if (hs.Contains(arr1[i]))
            //    { 
            //     Console.WriteLine(arr1[i]);
            //    }
            //}

        }
    }
}
