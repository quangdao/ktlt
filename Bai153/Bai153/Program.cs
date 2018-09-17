using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai153
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1,1,2,3,-3,7,6,21};
            Console.WriteLine(SmallestEvenNumber(arr));
            Console.ReadLine();
        }

        public static int SmallestEvenNumber(int[] arr)
        {
            int result = arr[0];
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count++;
                    result = arr[i];
                    break;
                }
            }

            if (count == 0)
            {
                return -1;
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] < result)
                {
                    result = arr[i];
                }


            }
            return result;
        }


    }
}
