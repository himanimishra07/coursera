using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_common_divisor
{
    static public void Main()
    {
        int g;
        string[] tokens = Console.ReadLine().Split(' ');
        int a = int.Parse(tokens[0]);
        int b = int.Parse(tokens[1]);
        g = gcd(a, b);
        Console.WriteLine(g);
        Console.ReadKey();


    }
    class Program
    {

        public static int gcd(int a, int b)
        {
            if (a == 0)
                return b;

            return gcd(b % a, a);
        }

    }
}

