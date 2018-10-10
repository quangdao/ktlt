using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(3);
            Console.Read();
        }

        public static void Print(int n)
        {
            if (n <= 0)
            {
                return;
            }
            Console.WriteLine("before {0} ", n);
            Print(n - 1);
            Console.WriteLine("after {0} ", n);
        }
    }
}
