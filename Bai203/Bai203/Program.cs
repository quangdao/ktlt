using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai203
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
            Console.WriteLine(SumHangChuc5(arr));
            Console.ReadLine();
        }

        public static int SumHangChuc5(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckChuc5(arr[i]) == true)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        public static bool CheckChuc5(int number)
        {
            int temp = Math.Abs(number);
            int hangChuc = temp;
            while (temp >= 100)
            {
                hangChuc = temp / 10;
                temp /= 10; 
            }
            if (hangChuc  % 10 == 5)
            {
                return true;
            }
            return false;
        }
    }
}
