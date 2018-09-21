using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai214
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] {2,4,7};
            Console.WriteLine(GeometricMean(arr));
            Console.ReadLine();
        }


        public static float GeometricMean(float[] arr)
        {
            float geometric = 1;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    geometric *= arr[i];
                    count++;
                }
            }
            return (float)Math.Pow(geometric, (float) 1 / count);
        }
    }
}
