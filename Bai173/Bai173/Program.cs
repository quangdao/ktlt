using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai173
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {35,35,15, 56, 15,39,39,15 };
            Console.WriteLine(FindNumber(arr));
            Console.ReadLine();
        }

        public static int FindNumber(int[] arr)
        {
            int count = CountNumber(arr, arr[0]);
            int result = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (CountNumber(arr,arr[i]) < count)
                {
                    result = arr[i];
                }
            }
            return result;
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
