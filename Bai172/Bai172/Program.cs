using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai172
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {3,2,8,1};
            Console.WriteLine(FindLowestCommonMultiplierInArray(arr));
            Console.ReadLine();
        }


        public static int FindLowestCommonMultiplierInArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    return 0;
            }

            int greatestNumber = GreatestNumberInArray(arr);
            int lcmOfGreatestNumer = LowestCommonMultiplier(greatestNumber);
            int lcm = lcmOfGreatestNumer;

            while (IsLowestCommonMultiplier(arr, lcmOfGreatestNumer++) == false)
            {
                lcm = lcmOfGreatestNumer;
                if (IsLowestCommonMultiplier(arr, lcm ) == true)
                    return lcm;
            }
            return lcm;

        }

        public static bool IsLowestCommonMultiplier(int[] arr, int multiplier)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (multiplier % arr[i] != 0)
                    return false;
            }
            return true;
        }

        public static int GreatestNumberInArray(int[] arr)
        {
            int greatest = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= greatest)
                {
                    greatest = arr[i];
                }
            }
            return greatest;
        }

        public static int LowestCommonMultiplier(int number)
        {
            int cm = 1;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    cm = i;
                }
            }
            return cm;
        }


    }
}
