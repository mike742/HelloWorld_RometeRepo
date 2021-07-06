using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HelloWorld
{
    class Task_02
    {
        /*
        Write a small function that returns the values of an array that are not odd.
        All values in the array will be integers. 
        Return the good values in the order they are given.
        */
        public static int[] NoOdds(int[] values)
        {
            //var res = (from v in  values
            //             where v % 2 == 0
            //             select v).ToArray();

            var res2 = values.Where(v => v % 2 == 0).ToArray();

            Console.WriteLine(string.Join(", ", res2));
            /*
            // 1. number of evens
            int noe = 0;
            foreach (int el in values)
            {
                if (el % 2 == 0)
                    noe++;
            }

            // 2. Array[noe]
            int[] res = new int[noe];
            for (int i = 0, j = 0; i < values.Length; ++i)
            {
                if (values[i] % 2 == 0)
                    res[j++] = values[i];
            }

            Console.WriteLine( string.Join(", ", res) );
            */
            return values.Where(v => v % 2 == 0).ToArray();
        }


        /*
        Some people are standing in a row in a park. 
        There are trees (-1) between them which cannot be moved.
        Your task is to rearrange the people by their heights 
        in a non-descending order without moving the trees.

        Example
          For a = [-1, 150, 190, 170, -1, -1, 160, 180], 
        should be [-1, 150, 160, 170, -1, -1, 180, 190].
         */

        public static int[] SortByHeight(int[] a)
        {
            string logFile = "test1.log";

            try
            {
                var arr = a.Where(e => e != -1).ToArray();
                Array.Sort(arr);

                for (int i = 0, j = 0; i < a.Length; ++i)
                {
                    if (a[i] != -1)
                    {
                        a[i] = arr[j++];
                    }
                }
                return a;
            }
            catch (Exception e)
            {
                File.AppendAllText(logFile, e.Message);
            }
            return new int[] { };
        }
    }
}
