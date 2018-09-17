using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai160
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] arr = new float[] { 0,3,4,2,-1,-0.2f,8,-0.1f, -0.005f, 15};
            Console.WriteLine(AmCuoi(arr));
            Console.ReadLine();
        }

        public static float AmCuoi(float[] arr)
        {
            float amcuoi = arr[0];
            int indexAmdau = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    count++;
                    amcuoi = arr[i];
                    indexAmdau = i;
                    break;
                }
            }

            if (count == 0)
            {
                return 0;
            }
            
            for (int i = indexAmdau; i < arr.Length; i++)
            {
                if (arr[i] < 0 && arr[i] > -1)
                {
                    amcuoi = arr[i];
                }
            }
            return amcuoi;
        }
    }
}
