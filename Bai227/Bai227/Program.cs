using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai227
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, -500, -256, 258, -800, 4, -15, 22, -39, 56 };
            Console.WriteLine(CountTraiDau(arr));
            Console.ReadLine();
        }

        public static int CountTraiDau(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (CheckTraiDau(arr[i], arr[i+1]) == true)
                {
                    count++;
                }
            }
            return count;
        }

        public static bool CheckTraiDau(int currentNumber, int nextNumber)
        {
            if ((currentNumber < 0 && nextNumber > 0) || (currentNumber > 0 && nextNumber < 0))
            {
                return true;
            }
            return false;
        }


    }
}
