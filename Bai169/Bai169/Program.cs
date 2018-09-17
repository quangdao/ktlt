using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai169
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {35, 45, 25, 10, 12, 8};
            Console.WriteLine(ChanNhoHonLe(arr));
            Console.ReadLine();
        }
        public static int LeNhoNhat(int[] arr)
        {
            int leNN = 0;
            for (int i = 0; i < arr.Length ; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    leNN = arr[i];
                    break;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] < leNN)
                {
                    leNN = arr[i];
                }
            }
            return leNN;
        }

        public static int ChanNhoHonLe(int[] arr)
        {
            int leNhoNhat = LeNhoNhat(arr);
            int chanLonNhat = 0;

            if (leNhoNhat == 0)
            {
                return 0;
            }

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] % 2 == 0)
                {
                    chanLonNhat = arr[j];
                    break;
                }
            }

            for (int k = 0; k < arr.Length; k++)
            {
                if (arr[k] % 2 == 0  && arr[k] > chanLonNhat && arr[k] < leNhoNhat)
                {
                    chanLonNhat = arr[k];
                }
            }

            if (chanLonNhat == 0)
                return 0;
            if (chanLonNhat > leNhoNhat)
                return 0;
            return chanLonNhat;
        }
    }
}
