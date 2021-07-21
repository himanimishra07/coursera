using System;
class LCM
{
    public static void Main()
    {
        string[] tokens = Console.ReadLine().Split(' ');
        long n1 = long.Parse(tokens[0]);
        long n2 = long.Parse(tokens[1]);
        Console.WriteLine(lcm(n1, n2));
        Console.ReadKey();
    }
    static long gcd(long n1, long n2)
    {

        if (n1 == 0)
            return n2;

        return gcd(n2 % n1, n1);
    }

    // LCM of two numbers 
    static long lcm(long n1, long n2)
    {

        return (n1 * n2) / gcd(n1, n2);
    }

}