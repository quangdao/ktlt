using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai142
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr1 = new float[] { 1.3f, 2.3f, 3.4f, 0.7f };
            Console.WriteLine(nhonhat(arr1));
            Console.ReadLine();
        }

        private static float nhonhat(float[] arr)
        {
            float nn = 9;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<nn)
                {
                    nn = arr[i];
                }
            }
            return nn;
        }
    }
}
