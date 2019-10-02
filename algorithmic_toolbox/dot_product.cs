using System;

class dot_product
{
    public static void Main()
    {
        //int max_ad = Int32.Parse(Console.ReadLine());
        long max_ad = long.Parse(Console.ReadLine());
        string y = Console.ReadLine();
        string[] tokens = y.Split(' '); /* all the spaces between the integers will be removed and they will assign into an array accordingly */
        long[] no_of_clicks = new long[tokens.Length];

        for (int i = 0; i < tokens.Length; i++)
        {
            no_of_clicks[i] = long.Parse(tokens[i]);
        }
        string s = Console.ReadLine();
        string[] token1 = s.Split(' '); /* all the spaces between the integers will be removed and they will assign into an array accordingly */
        long[] money_per_click = new long[token1.Length];

        for (int j = 0; j < token1.Length; j++)
        {
            money_per_click[j] = long.Parse(token1[j]);
        }

        int m = no_of_clicks.Length;
        int n = money_per_click.Length;
        
        Console.Write(maximumSOP(no_of_clicks, money_per_click));
        Console.ReadKey();
    }

    // Function that calculates maximum  
    // sum of products of two arrays 
    static long maximumSOP(long[] a, long[] b)
    {
        // Variable to store the sum of 
        // products of array elements 
        long sop = 0;

        // length of the arrays 
        int n = a.Length;

        // Sorting both the arrays 
        Array.Sort(a);
        Array.Sort(b);

        // Traversing both the arrays 
        // and calculating sum of product 
        for (int i = 0; i < n; i++)
        {
            sop += a[i] * b[i];
        }

        return sop;
    }
}