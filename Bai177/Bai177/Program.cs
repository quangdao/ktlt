using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai177
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] { 35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
            TimDoan(arr, 20, 800);
            Console.ReadLine();
        }

        public static void TimDoan(float[] arr, float x, float y)
        {
            foreach (var number in arr)
            {
                if (number >= x && number <= y)
                {
                    Console.WriteLine(number);
                }
            }
        }

        
    }
}
