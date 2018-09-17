using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai170
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {  83, 89, 79, 97, 20, 72, 65 };
            Console.WriteLine(SmallesPrimeNumber(arr));
            Console.ReadLine(); 
        }

        public static int SmallesPrimeNumber(int[] arr) {
            int greatestNonPrime = GreatestNonPrime(arr);
            int smallestPrime = FirstPrime(arr);

            if (smallestPrime == 0)
                return 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckPrimeNumber(arr[i]) == true && arr[i] < smallestPrime && arr[i] > greatestNonPrime )
                {
                    smallestPrime = arr[i];
                }
            }

            if (smallestPrime < greatestNonPrime)
            {
                return 0;
            }
            return smallestPrime;
        }

        public static int FirstPrime(int[] arr)
        {
            int firstPrime = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckPrimeNumber(arr[i]) == true)
                {
                    firstPrime = arr[i];
                    break;
                }
            }
            return firstPrime;
        }

        public static int GreatestNonPrime(int[] arr)
        {
            int greatestNumber = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckPrimeNumber(arr[i]) == false && arr[i] > greatestNumber)
                {
                    greatestNumber = arr[i];
                }
            }
            return greatestNumber;
        }

        public static bool CheckPrimeNumber(int number)
        {
            int count = 0;
            if (number < 1 )
            {
                return false;
            }
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            return false;
            
        }


    }
}
