using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai187
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] { 35, 4, 256, 258, 800, 4, 15, 22, 39, 56 };
            LietKeDuongNhoNhat(arr);
            Console.ReadLine();
        }

        public static void LietKeDuongNhoNhat(float[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0 && arr[i] == DuongNhoNhat(arr) )
                {
                    Console.WriteLine("Vi tri gia tri bang voi duong nho nhat ({0}) la {1}", DuongNhoNhat(arr),i);
                }
            }
        }

        public static float DuongNhoNhat(float[] arr)
        {
            float min = DuongDau(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0 && arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public static float DuongDau(float[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    return arr[i];
                }
            }
            return 0;
        }
    }
}
