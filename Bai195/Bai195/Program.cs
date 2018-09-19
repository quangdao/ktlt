using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai195
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 30, 5, 258, 254, 4, 3, 1 };
            LietKe3GiaTri(arr);
            Console.ReadLine();
        }

        public static void LietKe3GiaTri(int[] arr)
        {
            for (int i = 1; i < arr.Length-1; i++)
            {
                if (CheckTong3GiaTri(arr[i-1],arr[i],arr[i+1]) == true)
                {
                    Console.WriteLine("Tong cua 3 Gia Tri Lan Can : ({0}) = ({1}) + ({2})",arr[i-1],arr[i],arr[i+1]);
                }
            }
        }

        public static bool CheckTong3GiaTri(int numberA, int numberB, int numberC)
        {
            
                if (numberA == numberB + numberC)
                {
                    return true;
                }
            return false;
        }
    }
}
