using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai189
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, -358, 800, 3, 0, 15, 22, 39, 56, -3, -95338 };
            LietKeDauLe(arr);
           // Console.WriteLine(FirstDigit(-58));
            Console.ReadLine();
        }

        public static void LietKeDauLe(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    if (FirstDigit(arr[i]) % 2 != 0)
                        Console.Write(" {0}", arr[i]);
                }
                else
                {
                    if (FirstDigit(Math.Abs(arr[i])) % 2 != 0)
                        Console.Write(" {0}", arr[i]);
                }
            }
        }

        public static int FirstDigit(int number)
        {
            if (number < 10)
            {
                return number;
            }
            return FirstDigit(number / 10);
        }

    
       
    }
}
