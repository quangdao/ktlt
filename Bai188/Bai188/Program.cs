using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai188
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, 258, 800, 4, 15, 800, 39, 56 };
            CacViTriChanLonNhat(arr);
            Console.ReadLine();
        }

        public static void CacViTriChanLonNhat(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ChanLonNhat(arr))
                {
                    Console.WriteLine("Cac vi tri chan lon nhat la: {0}", i);
                }
            }
        }

        public static int ChanLonNhat(int[] arr)
        {
            int lonNhat = ChanDau(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] > lonNhat)
                {
                    lonNhat = arr[i];
                }
            }
            return lonNhat;
        }

        public static int ChanDau(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    return arr[i];
                }
            }
            return 1;
        }

    }
}
