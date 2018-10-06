using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai257
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] { 14, -5.7f, 23, 13.5f, 43.1f, -12.7f };
            AscendingOddNumbers(arr);
            Console.ReadLine();
        }

        public static void AscendingOddNumbers(float[] arr)
        {
            for (int i = 0; i < arr.Length - 1 ; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (IsOddNumber(i) == true && IsOddNumber(j) == true )
                    {
                        if (arr[i] > arr[j])
                        {
                            float temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                        
                    }
                }
                
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static bool IsOddNumber(float number)
        {
            if (number % 2 != 0)
            {
                return true;
            }
            return false;
        }
    }
}
