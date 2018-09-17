using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai182
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] { 35, -500, -256, -258, -800, 4, 15, -22, 39, -56 };
            GiaTriCoLanCanTraiDau(arr);
            Console.ReadLine();
        }

        public static void GiaTriCoLanCanTraiDau (float[] arr)
        {
            if (arr[0] * arr[1] < 0)
                Console.WriteLine("{0} {1}", arr[0], arr[1]);
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if ((arr[i] * arr[i + 1]) < 0 || (arr[i] * arr[i - 1]) < 0)
                    Console.WriteLine("{0} {1} {2}", arr[i - 1], arr[i], arr[i + 1]);
            }
            if (arr[arr.Length - 1] * arr[arr.Length - 2] < 0)
                Console.WriteLine("{0} {1}", arr[arr.Length - 1], arr[arr.Length - 2]);
        }
    }
}
