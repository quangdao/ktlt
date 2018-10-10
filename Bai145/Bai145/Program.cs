using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai145
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1,4,6,496 };
            Console.WriteLine(sohoanthiendautien(arr));
            Console.ReadLine();

        }


        public static int sohoanthiendautien(int[] arr)
        {
            int hoanthiendau = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (kiemtrasohoanthien(arr[i]) == true)
                {
                    hoanthiendau = arr[i];
                    return hoanthiendau;
                }
            }
            return hoanthiendau;

        }

        public static bool kiemtrasohoanthien(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == number)
            {
                return true;
            }
            return false;
        }
    }
}
