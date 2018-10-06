using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai259
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 35, 6, 500, 496, 256, 258, 8128, 800, 4, 15, 22, 39, 56 };
            DescendingPerfectNumber(arr);
            Console.ReadLine();
        }


        public static void DescendingPerfectNumber(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (IsPerfectNumber(arr[i]) == true && IsPerfectNumber(arr[j]) == true)
                    {
                        if (arr[i] < arr[j])
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static bool IsPerfectNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == number)
            {
                return true;
            }
            return false;
        }
    }
}

