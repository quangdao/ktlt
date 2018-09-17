using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai143
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 1, 7, 9, 6 };
            Console.WriteLine(sochandautien(arr));
            Console.ReadLine();
        }

        public static int sochandautien(int[] arr)
        {
            int chandau = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    chandau = arr[i];
                    return chandau;
                    
                }
            }
            
            return -1;
        }
    }
}
