using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai232
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {500,1, 500, 256, 258, 800, 4,1, 15, 22,256,258, 39, 56,35,35,35,800 };
            LietKe(arr);
            Console.ReadLine();

        }

        public static void LietKe(int[] arr)
        {
            //======dung mang phu
            //int[] distinctArr = arr.Distinct().ToArray();

            //-====ko dung mang phu

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                if (CheckTrung(arr, i) == false)
                {
                    if (IsNotDistinctValue(arr,arr[i]) == true)
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
        }

        public static bool IsNotDistinctValue(int[] arr, int number)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                }
            }

            if (count > 1)
            {
                return true;
            }
            else
                return false;
        }

        public static bool CheckTrung (int[] arr, int index)
        {
            
            for (int i = index - 1; i >= 0; i--)
            {
                if (arr[i] == arr[index])
                    return true;
            }
            return false;
        }
    }
}
