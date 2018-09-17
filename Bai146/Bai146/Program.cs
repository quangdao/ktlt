using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai146
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] { 1.2f,1.5f, 19f };
            Console.WriteLine(amdau(arr));
            Console.ReadLine();

        }

        public static float amdau(float[] arr)
        {
            float amdau = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    amdau = arr[i];
                    return amdau;
                }
                    
            }

            return amdau;
        }
    }
}
