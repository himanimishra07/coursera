using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace large_int_fibonacci_num
{
    class Program
    {
       
        public class Improve
        {

            static void Main(string[] args)
            {
                {

                    int n = Int32.Parse(Console.ReadLine());
                    Console.Write(calculateSquareSum(n));

                }
                Console.ReadKey();
            }
            
           
            // squares of Fibonacci numbers  
            static int calculateSquareSum(int n)
            {
                if (n <= 0)
                    return 0;

                int[] fibo = new int[n + 1];
                fibo[0] = 0;
                fibo[1] = 1;

                // Initialize result  
                int sum = (fibo[0] * fibo[0]) + (fibo[1] * fibo[1]);

                // Add remaining terms  
                for (int i = 2; i <= n; i++)
                {
                    fibo[i] = fibo[i - 1] + fibo[i - 2];
                    sum += (fibo[i] * fibo[i]);
                }

                return sum;
            }

            

        }


    }
}
        
    

