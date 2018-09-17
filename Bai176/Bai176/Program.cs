using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai176
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] { 35, -500, -256, 258, -800, 4, 15, 22, 39, 56 };
            LietKeAm(arr); 
            Console.ReadLine();
        }

        public static void LietKeAm(float[] arr)
        {
            foreach (var number in arr)
            {
                if (number < 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
