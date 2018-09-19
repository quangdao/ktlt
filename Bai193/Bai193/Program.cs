using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai193
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 27, 800, 4, 9, 22, 39, 56 };
            //Console.WriteLine(Check3K(-27));
            LietKe3K(arr);
            Console.ReadLine();
        }

        public static void LietKe3K(int[] arr)
        {
            bool flag = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Check3K(arr[i]) == true)
                {
                    flag = true;
                    Console.WriteLine(arr[i]);
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Ko co gia tri nao 3^k");
            }
        }

        public static bool Check3K(int number)
        {
            if (number <= 0)
                return false;
            int logarith = Convert.ToInt32(Math.Log(number,3));
            if (Math.Pow(3,logarith) == number)
            {
                return true;
            }
            return false;
        }

    }
}
