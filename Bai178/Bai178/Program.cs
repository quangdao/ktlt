using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai178
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
            TimDoan(arr,2,500);
            Console.ReadLine();
        }

        public static void TimDoan(int[] arr, int x, int y)
        {
            foreach (var number in arr)
            {
                if (number % 2 == 0 && number >= x && number <=y)
                {
                    Console.WriteLine(number);
                }
            }
        }

    }
}
