using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai185
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
            SquareNumber(arr);
            Console.ReadLine();
        }

        public static void SquareNumber(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckSquareNumber(arr[i]) == true)
                {
                    Console.WriteLine("Vi tri so chinh phuong ({0}) la: {1}",arr[i],i);
                }
            }
        } 

        public static bool CheckSquareNumber(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                if (Math.Pow(i,2) == number)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
