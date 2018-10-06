using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai261
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] arr = new float[] { 35, -500, 256, 258, -800, 4, 15, 22, -39, 56 };
            AscendingPosNumber(arr);
            Console.ReadLine();

        }

        

        public static void AscendingPosNumber(float[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > 0 && arr[j] > 0 && arr[i] > arr[j])
                    {
                        
                            float temp = arr[i];
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
