using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai156
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 24,45,23,13,43,-12 };
            Console.WriteLine(GiaTriGanNhat(arr, 15));
            Console.ReadLine();
        }

        public static int GiaTriGanNhat(int[] arr, int x)
        {
            int gannhat = arr[0];
            int distance = Math.Abs(arr[0] - x);
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i] - x) < distance)
                {
                    gannhat = arr[i];
                    distance = Math.Abs(arr[i] - x);
                }
            }

            return gannhat;
        }
    }
}
