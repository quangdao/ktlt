using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai186
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] { 35, 500, -256, 258, 800, 4, 15,-256, 22, 39, 56 };
            LietKeViTri(arr);
            Console.ReadLine();
        }

        public static void LietKeViTri(float[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == AmDau(arr))
                {
                    Console.WriteLine("Vi tri gia tri ({0}) là {1}",arr[i],i);
                }
            }
        }

        public static float AmDau(float[] arr)
        {
           
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<0)
                {
                    return arr[i];
                }
            }
            return 0;
        }
    }
}
