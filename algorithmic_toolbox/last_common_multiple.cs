using System;

class lcm
{


    public static void Main()
    {
        Int64 l;
        string[] tokens = Console.ReadLine().Split(' ');
        Int64 a = Int64.Parse(tokens[0]);
        Int64 b = Int64.Parse(tokens[1]);
        l = findLCM(a, b);
        Console.WriteLine(l);
        Console.ReadKey();
    }

    // Function to return 
    // LCM of two numbers 
    public static Int64 findLCM(Int64 a, Int64 b)
    {
        Int64 lar = Math.Max(a, b);
        Int64 small = Math.Min(a, b);
        for (Int64 i = lar; ; i += lar)
        {
            if (i % small == 0)
                return i;
        }
    }
}