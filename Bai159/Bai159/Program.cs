using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai159
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] { 2.4f,3,5.6f, 9000,2,4};
            Console.WriteLine(DauTienLonHon2003(arr));
            Console.ReadLine();

        }

        public static float DauTienLonHon2003(float[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 2003) {
                    return arr[i];
                }
            }
            return 0;
        }
    }
}
