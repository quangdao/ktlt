using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai154
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] {2, -8,0,1,-4,5,7,3};
            Console.WriteLine("Index of greatest negative number: " + IndexOfGrNeNumber(arr));
            Console.ReadLine();
        }

        public static int IndexOfGrNeNumber(float[] arr)
        {
            float greatest = arr[0];
            int indexofgreatest = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    count++;
                    greatest = arr[i];
                    indexofgreatest = i;
                    break;
                }
            }

            if (count == 0) {
                return -1;
            }

            for (int i = indexofgreatest; i < arr.Length; i++)
            {
                if (arr[i] < 0 && arr[i] > greatest)
                {
                    greatest = arr[i];
                    indexofgreatest = i;
                }
            }
            return indexofgreatest;

        }
    }
}
