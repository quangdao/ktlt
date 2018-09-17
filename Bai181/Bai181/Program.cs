using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai181
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] { 36, 500, 256, 258, 800, 4, 15, 22, 32, 56 };
            GiaTriChanCoLanCanChan(arr);
            Console.ReadLine();
        }

        public static void GiaTriChanCoLanCanChan(float[] arr)
        {

            if (arr[0] % 2 == 0 && arr[1] % 2 == 0)
                Console.WriteLine("{0} {1}", arr[0], arr[1]);
            if (arr[arr.Length -1 ] % 2 == 0 && arr[arr.Length - 2] % 2 == 0)
                Console.WriteLine("{0} {1}", arr[arr.Length - 1], arr[arr.Length - 2]);

            for (int i = 1; i < arr.Length - 1 ; i++)
            {
                if (arr[i] % 2 == 0 && (arr[i + 1] % 2 == 0 || arr[i - 1] % 2 == 0))
                    Console.WriteLine("{0} {1} {2}", arr[i - 1], arr[i], arr[i + 1]);
            }
        }
    }
}
