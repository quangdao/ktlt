using System;

namespace Bai191
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            float[] arr = new float[] { 2, 3, 2, 5, 28, 3, 6, 3, 15, 8, 29, 5 };
            LietKeMax(arr);
        }

        public static void LietKeMax(float[] arr)
        {
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (CheckMax(arr[i], arr[i - 1], arr[i + 1]) == true)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        public static bool CheckMax(float mainNumber,float numberA, float numberB )
        {
            if (mainNumber > numberA  && mainNumber > numberB)
            {
                return true;
            }
            return false;
        }


    }
}
