using System;

class LCS2
{
    public static void Main()
    {
        int s1 = Int32.Parse(Console.ReadLine());
        string y = Console.ReadLine();
        string[] tokens = y.Split(' '); /* all the spaces between the integers will be removed and they will assign into an array accordingly */
        int[] X = new int[tokens.Length];

        for (int i = 0; i < tokens.Length; i++)
        {
            X[i] = int.Parse(tokens[i]);
        }
        int s2 = Int32.Parse(Console.ReadLine());
        string z = Console.ReadLine();
        string[] tokenss = z.Split(' '); /* all the spaces between the integers will be removed and they will assign into an array accordingly */
        int[] Y = new int[tokenss.Length];

        for (int j = 0; j < tokenss.Length; j++)
        {
            Y[j] = int.Parse(tokenss[j]);
        }
        int m = X.Length;
        int n = Y.Length;

        Console.Write(lcs(X, Y, m, n));
        Console.ReadKey();
    }
    /* Returns length of LCS for X[0..m-1], Y[0..n-1] */
    static int lcs(int[] X, int[] Y, int m, int n)
    {
        int[,] L = new int[m + 1, n + 1];

        /* Following steps build L[m+1][n+1]  
        in bottom up fashion. Note 
        that L[i][j] contains length of  
        LCS of X[0..i-1] and Y[0..j-1] */
        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                    L[i, j] = 0;
                else if (X[i - 1] == Y[j - 1])
                    L[i, j] = L[i - 1, j - 1] + 1;
                else
                    L[i, j] = max(L[i - 1, j], L[i, j - 1]);
            }
        }
        return L[m, n];
    }

    /* Utility function to get max of 2 integers */
    static int max(int a, int b)
    {
        return (a > b) ? a : b;
    }


}

