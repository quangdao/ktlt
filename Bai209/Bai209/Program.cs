using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai209
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 256, 500, -256, 258, 800, 4, -35, 22, 35};
            Console.WriteLine(SumSymmetry(arr));
            Console.ReadLine();
        }

        public static int SumSymmetry(int[] arr)
        {
            int sum = 0;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (IsSymetric(arr[i-1],arr[i+1]) == true)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        public static bool IsSymetric(int numberA, int numberB)
        {

            if (Math.Abs(numberA) == Math.Abs(numberB))
            {
                if (numberA < numberB || numberA > numberB)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
