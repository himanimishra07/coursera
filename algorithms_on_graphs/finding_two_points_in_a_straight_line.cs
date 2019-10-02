// C# Program to find m and c for a 
// straight line given, x and y 
using System;

class finding_straight_line
{

    // function to calculate m and c that 
    // best fit points represented by x[] and y[] 
    static void bestApproximate(int[] x, int[] y)
    {
        int n = x.Length;
        double m, c, sum_x = 0, sum_y = 0,
                     sum_xy = 0, sum_x2 = 0;

        for (int i = 0; i < n; i++)
        {
            sum_x += x[i];
            sum_y += y[i];
            sum_xy += x[i] * y[i];
            sum_x2 += Math.Pow(x[i], 2);
        }

        m = (n * sum_xy - sum_x * sum_y) / (n * sum_x2 - Math.Pow(sum_x, 2));

        c = (sum_y - m * sum_x) / n;

        Console.WriteLine("m = " + m);
        Console.WriteLine("c = " + c);
    }

    // Driver main function 
    public static void Main()
    {
        int[] x = { 1, 2, 3, 4, 5 };
        int[] y = { 14, 27, 40, 55, 68 };

        // Function calling 
        bestApproximate(x, y);
    }
}