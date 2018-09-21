using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai215
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] { 1, 4, 7, 2 };
            Console.WriteLine(AverageDistance(arr));
            Console.ReadLine();
        }

        public static float AverageDistance(float[] arr)
        {
            float sum = 0;
            float distance = 0;
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    distance = Math.Abs(arr[j]) - Math.Abs(arr[i]);
                    sum += Math.Abs(distance);
                    count++;  
                }
            }
            return sum/count;
        }
    }
}
