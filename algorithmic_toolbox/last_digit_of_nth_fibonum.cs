using System;

class GFG
{

    // Filongs f[] with first  
    // 60 Fibonacci numbers 
    static void fib(int[] f)
    {

        // 0th and 1st number of  
        // the series are 0 and 1 
        f[0] = 0;
        f[1] = 1;

        // Add the previous 2 numbers  
        // in the series and store 
        // last digit of result  
        for (int i = 2; i <= 59; i++)
            f[i] = (f[i - 1] + f[i - 2]) % 10;
    }

    // Returns last digit of n'th  
    // Fibonacci Number 
    static int findLastDigit(long n)
    {
        int[] f = new int[60];

        // Precomputing units digit of  
        // first 60 Fibonacci numbers 
        fib(f);

        int index = (int)(n % 60L);

        return f[index];
    }
    public static void Main()
    {
        string[] tokens = Console.ReadLine().Split(' ');
        long n = long.Parse(tokens[0]); ;
        Console.WriteLine(findLastDigit(n));
        Console.ReadKey();

    }
}