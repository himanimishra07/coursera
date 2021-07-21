using System;

class UboundedKnapsack
{

    private static int max(int i, int j)
    {
        return (i > j) ? i : j;
    }

    // Returns the maximum value  
    // with knapsack of W capacity 
    private static int unboundedKnapsack(int W, int n,
                                   int[] wt)
    {

        // dp[i] is going to store maximum value 
        // with knapsack capacity i. 
        int[] dp = new int[W + 1];

        // Fill dp[] using above recursive formula 
        for (int i = 0; i <= W; i++)
        {
           
                    dp[i] = Math.Max(dp[i], dp[i - wt[0]] );
                
            
        }
        return dp[W];
    }

    // Driver program 
    public static void Main()
    {
        int n = 0;
        int W;
        string n1 = Console.ReadLine();
        n = Convert.ToInt32(n1.Split(' ')[0]);
        W = int.Parse(n1.Split(' ')[1]);
        string y = Console.ReadLine();
        string[] tokens = y.Split(' '); /* all the spaces between the integers will be removed and they will assign into an array accordingly */
        int[] wt = new int[tokens.Length];

        for (int i = 0; i < tokens.Length; i++)
        {
            wt[i] = int.Parse(tokens[i]);
        }
        string y1 = Console.ReadLine();
        string[] tokens1 = y1.Split(' '); /* all the spaces between the integers will be removed and they will assign into an array accordingly */
        //int[] val = new int[tokens1.Length];

        //for (int i = 0; i < tokens1.Length; i++)
        //{
          //  val[i] = int.Parse(tokens1[i]);
        //}
        
        Console.WriteLine(unboundedKnapsack(W, n, wt));
        Console.ReadKey();
    }
}