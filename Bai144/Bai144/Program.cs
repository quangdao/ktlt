using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai144
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1, 0, 0 };
            Console.WriteLine(songuyentodautien(arr));
            Console.ReadLine();
        }

        public static int songuyentodautien(int[] arr)
        {
            int nguyentodau = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (kiemtranguyento(arr[i]) == true)
                {
                    nguyentodau = arr[i];
                    return nguyentodau;
                }
            }
            return nguyentodau;
        }

        public static bool kiemtranguyento(int number)
        {
            int dem = 0;
            if (number <= 1)
                return false;
            
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    dem = dem + 1;
                }
            }
            if (dem == 2) {
                return true;
            }
            return false;
        }

    }
}
