using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai161
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
            Console.WriteLine(FirstValueInRange(arr, 200,400));
            Console.ReadLine();
        }

        public static int FirstValueInRange(int[] arr, int x, int y)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsInRange(arr[i],x,y) == true)
                {
                    return arr[i];
                }
            }

            return x;
        }
        public static bool IsInRange(int number ,int x , int y)
        {
            for ( int i = x; i < y; i++)
            {
                if (number > x && number < y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
