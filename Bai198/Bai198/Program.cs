using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai198
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 800, 256, 258, 800, 4, 15, 22, 39, 56 };
            LietKeViTriLonNhat(arr);
            Console.ReadLine();
        }

        public static void LietKeViTriLonNhat(int[] arr)
        {
            int lonNhat = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > lonNhat)
                {
                    lonNhat = arr[i];
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == lonNhat)
                {
                    Console.Write(" {0} ",i);
                }
            }
        }

        
    }
}
