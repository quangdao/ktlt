using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai263
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 41, -29, -56, 23, -31, 37,35 };
            AscPosDescNegNumber(arr);
            Console.ReadLine();
        }

        public static void AscPosDescNegNumber(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[i] > 0 && arr[j] > 0 && arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                    else if (arr[i] < 0 && arr[j] < 0 && arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
