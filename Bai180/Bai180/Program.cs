using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai180
{
    class Program
    {
        static void Main(string[] args)
        {
              int[] arr = new int[] { 35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
        GiaTriNhoSauLonTruoc(arr);
	    Console.ReadLine();
        }
      


        public static void GiaTriNhoSauLonTruoc(int[] arr)
        {
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] < Math.Abs(arr[i+1]) && arr[i] > Math.Abs(arr[i-1]))
                {
                    Console.WriteLine("{1} < {0} < {2}", arr[i], arr[i-1], arr[i+1]);
                }
            }
        }
    }
}
