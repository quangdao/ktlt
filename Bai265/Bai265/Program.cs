using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai265
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrA = new int[] { 2,4,9,17 };
            int[] arrB = new int[] { 5,10,19,78};

            Merge(arrA,arrB);
            Console.ReadLine();
        }

        public static void Merge(int[] arrA, int[] arrB)
        {
            //List<int> temp = new List<int>();

            int[] res = new int[arrA.Length + arrB.Length];
            int l = 0, r = 0;

            for (int i = 0; i < arrA.Length + arrB.Length; ++i)
            {
                if (l >= arrA.Length)
                    res[i] = arrB[r++];
                else if (r >= arrB.Length)
                    res[i] = arrA[l++];
                else if (arrA[l] < arrB[r])
                    res[i] = arrA[l++];
                else
                    res[i] = arrB[r++];
            }

            //for (int i = 0; i < arrA.Length + arrB.Length; i++)
            //{
            //    if (arrA[l] < arrB[r])
            //    {
            //        temp.Add(arrA[l++]);
      
            //        if (l >= arrA.Length)
            //        {
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        temp.Add(arrB[r++]);
                
            //        if (r >= arrB.Length)
            //        {
            //            break;
            //        }
            //    }
            //}

            //while (l < arrA.Length)
            //{
            //    temp.Add(arrA[l++]);
            //}
            //while (r < arrB.Length)
            //{
            //    temp.Add(arrB[r++]);
            //}
            //while (l > r)
            //{
            //    temp.Add(arrB[r++]);
            //}
            //while (l < r)
            //{
            //    temp.Add(arrA[l++]);
            //}
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
}
