using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai205
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 50, -256, 258, 800, 4, 35, 22, 39, 6 };
            Console.WriteLine(SumNumbers(arr));
            Console.ReadLine();
        }

        public static int SumNumbers(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (Compare2Numbers(arr[i], arr[i+1])==true)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        public static bool Compare2Numbers(int currentNumber, int nextNumber)
        {
            if (currentNumber > Math.Abs(nextNumber))
            {
                return true;
            }
            return false;
        }


    }
}
