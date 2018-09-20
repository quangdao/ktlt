using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai206
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
            Console.WriteLine(TongCucDai(arr));
            Console.ReadLine();
        }

        public static int TongCucDai(int[] arr)
        {
            int sum = 0;
            for (int i = 1; i < arr.Length - 2; i++)
            {
                if (CheckCucDai(arr[i],arr[i-1],arr[i+1]) == true)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        public static bool CheckCucDai(int currentNumber,int prevNumber, int nextNumber)
        {
            if (currentNumber > prevNumber && currentNumber > nextNumber)
                return true;
            return false;
        }
    }
}
