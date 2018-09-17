using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai162
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] arr = new float[] { 50, 25, 85, 258, 4, 40, 10, 22, 39, 56 };
            Console.WriteLine(ViTriGiaTriTich2LanCan(arr));
            Console.ReadLine();
        }


        public static float ViTriGiaTriTich2LanCan(float[] arr)
        {
            int index = 0;
            for (int i = 1; i < arr.Length - 2; i++)
            {
                if (arr[i] == arr[i+1] * arr[i-1])
                {
                    index = i;
                    return index;
                }
            }
            return -1;
        }
    }
}
