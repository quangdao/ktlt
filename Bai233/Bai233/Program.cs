using System;

namespace Bai233
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 43, 12, 34, 43, 12, 5 };
            LietKe(arr);
            Console.ReadLine();
        }

        public static void LietKe(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckTrung(arr,i) == false)
                {
                    Console.WriteLine("Value ({0}): {1} time(s)",arr[i],CountNumber(arr,arr[i]));
                    //Console.WriteLine(arr[i]);
                }
            }

        }

        public static int CountNumber(int[] arr, int number)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                }
            }
            return count;
        }

        public static bool CheckTrung(int[] arr, int index)
        {

            for (int i = index - 1; i >= 0; i--)
            {
                if (arr[i] == arr[index])
                {
                    return true;
                }
            }
           return false;

        }
    }
}
