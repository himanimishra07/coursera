using System;

public class CNOISOSK
{

    // function to count number of increasing 
    // subsequences of size k 
    static int numOfIncSubseqOfSizeK(int[] arr, int n, int k)
    {
        int[,] dp = new int[k, n]; int sum = 0;

        // count of increasing subsequences of size 1 
        // ending at each arr[i] 
        for (int i = 0; i < n; i++)
        {
            dp[0, i] = 1;
        }

        // building up the matrix dp[,] 
        // Here 'l' signifies the size of 
        // increassing subsequence of size (l+1). 
        for (int l = 1; l < k; l++)
        {

            // for each increasing subsequence of size 'l' 
            // ending with element arr[i] 
            for (int i = l; i < n; i++)
            {

                // count of increasing subsequences of size 'l' 
                // ending with element arr[i] 
                dp[l, i] = 0;
                for (int j = l - 1; j < i; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        dp[l, i] += dp[l - 1, j];
                    }
                }
            }
        }

        // sum up the count of increasing subsequences of 
        // size 'k' ending at each element arr[i] 
        for (int i = k - 1; i < n; i++)
        {
            sum += dp[k - 1, i];
        }

        // required number of increasing 
        // subsequences of size k 
        return sum;
    }

  
    public static void Main()
    {
        int[] arr = { 12, 8, 11, 13, 10, 15, 14, 16, 20 };
        int n = arr.Length;
        int k = 4;

        Console.Write("Number of Increasing Subsequences of size "
                + k + " = " + numOfIncSubseqOfSizeK(arr, n, k));
        Console.ReadKey();
    }
}