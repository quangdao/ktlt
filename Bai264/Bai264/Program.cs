using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai264
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 2,5,7 };
            int[] arr2 = new int[] { 4,6,9 };

            int[] arrA = new int[] { 2, 4, 9, 78 };
            int[] arrB = new int[] { 5, 10, 19};
            Merge(arrA, arrB);
            Console.Read();
        }

        public static void Merge(int[] arrA, int[] arrB)
        {
            //int arrLength = arrA.Length + arrB.Length;
            List<int> temp = new List<int>();

            int i = 0;
            int j = 0;
            //int k = 0;
            while (i < arrA.Length && j < arrB.Length)
            {
                if (arrA[i] <= arrB[j])
                {
                    temp.Add(arrA[i]);
                    i++;
                }
                else
                {
                    temp.Add(arrB[j]);
                    j++;
                }
                
            }

            while (i < arrA.Length)
                temp.Add(arrA[i++]);

            while (j < arrB.Length)
                temp.Add(arrB[j++]);

            for (int f = 0; f < temp.Count; f++)
            {
                Console.WriteLine(temp[f]);
            }
        }

    }
}
