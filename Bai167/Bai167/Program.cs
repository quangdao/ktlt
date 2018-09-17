using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai167
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -35, 500, 256, -1119, 800, 4, 152, 22, 4550, 56 };
            Console.WriteLine(ToanLeLonNhat(arr));
            Console.ReadLine();
            //Console.WriteLine(CheckToanLe(111));
            
        }
        public static int ToanLeLonNhat(int[] arr)
        {
            int toanLe = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckToanLe(arr[i]) == true )
                {
                    toanLe = arr[i];
                    break;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckToanLe(arr[i]) == true && arr[i] > toanLe)
                {
                    toanLe = arr[i];
                }
            }
            return toanLe;
        }

        public static bool CheckToanLe(int number)
        {
            bool flag = true;
            int temp = 0;

            if (number % 2 == 0) {
                flag = false;
            }
            while (number >= 10)
            {
                temp = number % 10;
                number /= 10;
                if (temp % 2 == 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }


    }
}
