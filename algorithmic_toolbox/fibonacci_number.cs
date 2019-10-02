using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_num
{
    class Program
    {
        public static void Main()
        {
            string[] tokens = Console.ReadLine().Split(' ');
            long n = long.Parse(tokens[0]); 

            Console.WriteLine(fib(n));
            Console.ReadKey();
        }
        static long fib(long n)
        {

            // Declare an array to  
            // store Fibonacci numbers. 
            // 1 extra to handle  
            // case, n = 0 
            long[] f = new long[n + 2];
            long i;

            /* 0th and 1st number of the  
               series are 0 and 1 */
            f[0] = 0;
            f[1] = 1;

            for (i = 2; i <= n; i++)
            {
                /* Add the previous 2 numbers 
                   in the series and store it */
                f[i] = f[i - 1] + f[i - 2];
            }

            return f[n];
        }
    }
}
