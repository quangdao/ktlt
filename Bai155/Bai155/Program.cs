using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai155
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] { 24,45,23,13,43,-12 };
            Console.WriteLine(GiaTriXaNhat(arr, 15));
            Console.ReadLine();

        }

        public static float GiaTriXaNhat(float[] arr, float x)
        {
            float xanhat = arr[0];
            float distance = Math.Abs(arr[0] - x);
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i] - x) > distance)
                {
                    xanhat = arr[i];
                    distance = Math.Abs(arr[i] - x);
                    
                }
            }
            return xanhat;
        }
    }
}
