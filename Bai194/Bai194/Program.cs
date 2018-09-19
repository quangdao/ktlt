using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai194
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
            GanNhauNhat(arr);
            Console.ReadLine();
        }

       

        public static void GanNhauNhat(int[] arr)
        {
            int ganNhauNhat = Distance(arr[0],arr[1]);
            int numberA = arr[0];
            int numberB = arr[1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (Distance(arr[i], arr[i + 1]) < ganNhauNhat)
                {
                    ganNhauNhat = Distance(arr[i], arr[i + 1]);
                    numberA = arr[i];
                    numberB = arr[i + 1];
                }
            }
            Console.WriteLine("Cap ({0}) va ({1}) co khoang cach la: {2}", numberA, numberB, ganNhauNhat);

        }

        public static int Distance(int numberA, int numberB)
        {
            int distance = 0;
            distance = Math.Abs(Math.Abs(numberB) - Math.Abs(numberA));
            return distance;
        }
    }
}
