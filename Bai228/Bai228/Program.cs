using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai228
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -35, 500, -256, -258, 800, 4, -15, 22, 39, 56 };
            Console.WriteLine(Count(arr));
            Console.ReadLine();
        }

        public static int Count(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (CheckNextNumber(arr[i], arr[i+1]) == true)
                {
                    count++;
                }
            }
            return count;
        }

        public static bool CheckNextNumber(int currentNumber, int nextNumber)
        {
            if ((currentNumber > 0 &&  nextNumber > 0) || (currentNumber < 0 && nextNumber < 0))
            {
                if (Math.Abs(currentNumber) < Math.Abs(nextNumber))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
