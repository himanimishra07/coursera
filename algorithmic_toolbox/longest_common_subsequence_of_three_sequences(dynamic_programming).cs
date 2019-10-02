using System;

class GFG
{

    /* Returns length of LCS  
    for X[0..m-1], Y[0..n-1] 
    and Z[0..o-1] */
    static int lcsOf3(int[] X, int[] Y,
                      int[] Z, int m,
                      int n, int o)
    {
        int[,,] L = new int[m + 1,
                            n + 1, o + 1];

        /* Following steps build  
        L[m+1][n+1][o+1] in bottom  
        up fashion. Note that  
        L[i][j][k] contains length  
        of LCS of X[0..i-1] and 
        Y[0..j-1] and Z[0.....k-1]*/
        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                for (int k = 0; k <= o; k++)
                {
                    if (i == 0 ||
                        j == 0 || k == 0)
                        L[i, j, k] = 0;

                    else if (X[i - 1] == Y[j - 1] &&
                             X[i - 1] == Z[k - 1])
                        L[i, j, k] = L[i - 1,
                                       j - 1,
                                       k - 1] + 1;

                    else
                        L[i, j, k] = Math.Max(Math.Max(L[i - 1, j, k],
                                                       L[i, j - 1, k]),
                                                       L[i, j, k - 1]);
                }
            }
        }

        /* L[m][n][o] contains length  
        of LCS for X[0..n-1] and 
        Y[0..m-1] and Z[0..o-1]*/
        return L[m, n, o];
    }

    // Driver Code 
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
        string y1 = Console.ReadLine();
        string[] tokens1 = y1.Split(' '); /* all the spaces between the integers will be removed and they will assign into an array accordingly */
        int[] Y = new int[tokens1.Length];

        for (int i = 0; i < tokens1.Length; i++)
        {
            Y[i] = int.Parse(tokens1[i]);
        }
        int s3 = Int32.Parse(Console.ReadLine());
        string y2 = Console.ReadLine();
        string[] tokens2 = y2.Split(' '); /* all the spaces between the integers will be removed and they will assign into an array accordingly */
        int[] Z = new int[tokens2.Length];

        for (int i = 0; i < tokens2.Length; i++)
        {
            Z[i] = int.Parse(tokens2[i]);
        }

        int m = X.Length;
        int n = Y.Length;
        int o = Z.Length;

        Console.Write(lcsOf3(X, Y, Z, m, n, o));
        Console.ReadKey();
    }
}
