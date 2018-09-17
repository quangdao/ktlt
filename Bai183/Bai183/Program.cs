using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai183
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] { 35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
            IndexOfGreatestValue(arr);
            Console.ReadLine();
        }

        public static void IndexOfGreatestValue(float[] arr)
        {
            int index = 0;
            float value = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > value )
                {
                    value = arr[i];
                    index = i;
                }
            }
            Console.WriteLine("Index of Greatest Value({0}): {1} ",value,index);
        }
    }
}
