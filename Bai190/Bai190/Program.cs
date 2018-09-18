using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai190
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 35, 500, -153, 258, 800, 4, 15, 22, 39, 56 };
            LietKeToanLe(arr);
            Console.ReadLine();
        }

        public static void LietKeToanLe(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckToanLe(arr[i]) == true)
                {
                    Console.Write(" {0}", arr[i]);
                }
            }
        }

        public static bool CheckToanLe(int number)
        {
            bool flag = true;
            int temp = 0;
            while (Math.Abs(number) > 0)
            {
                temp = Math.Abs(number) % 10;
                number = Math.Abs(number) / 10;
                if (temp % 2 == 0)
                {
                     flag= false;
                }
            }
           
            return flag;
        }
    }

   

}
