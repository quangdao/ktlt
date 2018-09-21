using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai221
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 501, 253, 250, 800, 4, 15, 22, 39, 56 };
            Console.WriteLine(TuongQuanChanLe(arr));
            Console.ReadLine();
        }

        public static int TuongQuanChanLe(int[] arr)
        {
            int even = CountEvenNumber(arr);
            int odd = CountOddNumber(arr);
            if (even < odd)
            {
                return 1;
            }
            else if (even > odd)
            {
                return -1;
            }
            else
                return 0;
        }

        public static int CountEvenNumber(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static int CountOddNumber(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
