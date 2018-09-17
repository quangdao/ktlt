using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai150
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] {1,5,0,-20,0,-43,-4};
            Console.WriteLine(giatriamlonnhat(arr));
            Console.ReadLine();

        }

        public static float giatriamlonnhat(float[] arr) {
            float amlonnhat = arr[0];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0) {
                    count++;
                    amlonnhat = arr[i];
                    break;
                }
            }

            if (count == 0) {
                return 0;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (amlonnhat < arr[i] && arr[i]<0)
                {
                    amlonnhat= arr[i];
                }
            }
            return amlonnhat;
      
        }
    }
}
