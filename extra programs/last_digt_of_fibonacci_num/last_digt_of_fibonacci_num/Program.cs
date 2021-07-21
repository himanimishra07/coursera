﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace last_digt_of_fibonacci_num
{
    class Program
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(fib(n) % 10);
            Console.ReadKey();
        }
        static long fib(long n)
        {
            long[,] F = new long[,] { { 1, 1 }, { 1, 0 } };

            if (n == 0)
                return 0;

            power(F, n - 1);

            return F[0, 0];
        }

        // Utility function to multiply two  
        // matrices and store result in first. 
        static void multiply(long[,] F, long[,] M)
        {
            long x = F[0, 0] * M[0, 0] +
                     F[0, 1] * M[1, 0];
            long y = F[0, 0] * M[0, 1] +
                     F[0, 1] * M[1, 1];
            long z = F[1, 0] * M[0, 0] +
                     F[1, 1] * M[1, 0];
            long w = F[1, 0] * M[0, 1] +
                     F[1, 1] * M[1, 1];

            F[0, 0] = x;
            F[0, 1] = y;
            F[1, 0] = z;
            F[1, 1] = w;
        }

        // Optimized version of power()
        static void power(long[,] F, long n)
        {
            if (n == 0 || n == 1)
                return;
            long[,] M = new long[,] { { 1, 1 }, { 1, 0 } };

            power(F, n / 2);
            multiply(F, F);

            if (n % 2 != 0)
                multiply(F, M);
        }

        // Returns last digit of  
        // n'th Fibonacci Number 
        long lastnumber = 0;

        static long findLastDigit(long n)
       
            {
                return (fib(n) % 10);
            }
        
    }

}

