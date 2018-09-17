﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai148
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 3, 5, 7, 11, 13, 12, 19, 20, 22 };
            Console.WriteLine(songuyentocuoi(arr));
            //Console.WriteLine(kiemtranguyento(13));
            Console.ReadLine();
        }

        public static int songuyentocuoi(int[] arr)
        {
            int nguyentocuoi = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (kiemtranguyento(arr[i]) == true)
                    nguyentocuoi = arr[i];
            }
            return nguyentocuoi;
        }

        public static bool kiemtranguyento(int number)
        {
            int dem = 0;
            bool result = false;

            if (number <= 1)
            {
                return result = false;
            }
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    dem++;
                }
            }
           
            if (dem == 2) {
                return result = true;    
            }
            return result;
           

        }
    }
}
