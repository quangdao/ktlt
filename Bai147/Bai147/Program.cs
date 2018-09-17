using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai147
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] { -2.4f, -4.5f, -5.3f, 7.3f, 9.1f, 3.4f };
            Console.WriteLine(duongcuoi(arr));
            Console.ReadLine();

        }

        public static float duongcuoi(float[] arr)
        {
            float duongcuoi = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>0)
                {
                    duongcuoi = arr[i];
                }
            }

            return duongcuoi;
        }
      

    }
}
