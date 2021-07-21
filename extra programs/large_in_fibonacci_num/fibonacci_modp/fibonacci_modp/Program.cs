using System;

class Fibonacci_modp
{
    public static void Main()
    {
        string[] tokens = Console.ReadLine().Split(' ');
        long p = long.Parse(tokens[0]);
        Console.WriteLine(findMinZero(p));
        Console.ReadKey();
    }
    // Function that returns position 
    // of first Fibonacci number 
    // whose modulo p is 0 
    static long findMinZero(long p)
    {
        long first = 1, second = 1;
        long number = 2, next = 1;
        while (next > 0)
        {

            // add previous two  
            // remainders and then 
            // take its modulo p. 
            next = (first + second) % p;
            first = second;
            second = next;
            number++;
        }
        return number;
    }
}