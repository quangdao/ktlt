using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai230
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 15, 15, 256, 258, 800, 258, 4, 15, 15, 22, 39, 39, 56 };
            LietKe(arr);
            Console.ReadLine();

        }

        public static void LietKe(int[] arr)
        {
            List<int> newArray = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsUnique(newArray, arr[i]) == true)
                {
                    int count = CountNumber(arr, arr[i]);
                    newArray.Add(arr[i]);
                    Console.WriteLine("Number ({0}): {1} time(s)", arr[i], count);
                }

            }
        }



        public static bool IsUnique (List<int> arr, int number)
        {
           
            bool flag = true;
            for (int i = 0; i < arr.Count(); i++)
            {
                if (arr[i] == number)
                {
                    flag = false;
                }
            }
            return flag;
        }

        public static int CountNumber(int[] arr, int number)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                }
            }
            return count;
        }


    }
}
