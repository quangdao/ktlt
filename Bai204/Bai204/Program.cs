using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai204
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
            Console.WriteLine(TongLonHonLienTruoc(arr));
            Console.ReadLine();
        }

        public static int TongLonHonLienTruoc(int[] arr)
        {
            int sum = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (CompareNumer(arr[i], arr[i-1])==true)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        public static bool CompareNumer(int soXet, int soTruoc)
        {
            if (soXet <= soTruoc)
            { 
                return false;
            }
            return true;
        }
    }
}
