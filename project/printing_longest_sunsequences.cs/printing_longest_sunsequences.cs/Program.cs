// C# program to find length of the 
// longest increasing subsequence 
// whose adjacent element differ by  
using System;
using System.Collections.Generic;

class printing_longest_subsequences
{

    // function that returns the length of the 
    // longest increasing subsequence 
    // whose adjacent element differ by 1 
    static void longestSubsequence(int[] a, int n)
    {

        // stores the index of elements 
        Dictionary<int,
                   int> mp = new Dictionary<int,
                                            int>();

        // stores the length of the longest 
        // subsequence that ends with a[i] 
        int[] dp = new int[n];

        int maximum = -100000000;

        // iterate for all element 
        int index = -1;
        for (int i = 0; i < n; i++)
        {

            // if a[i]-1 is present before i-th index 
            if (mp.ContainsKey(a[i] - 1) == true)
            {

                // last index of a[i]-1 
                int lastIndex = mp[a[i] - 1] - 1;

                // relation 
                dp[i] = 1 + dp[lastIndex];
            }
            else
                dp[i] = 1;

            // stores the index as 1-index as we need to 
            // check for occurrence, hence 0-th index 
            // will not be possible to check 
            mp[a[i]] = i + 1;

            // stores the longest length 
            if (maximum < dp[i])
            {
                maximum = dp[i];
                index = i;
            }
        }

        // last element of sequence is 
        // a[index].length 
        // of subsequence is "maximum". 
        // print these many consecutive elements 
        // starting from "a[index] - maximum + 1" 
        // to a[index]. 
        for (int curr = a[index] - maximum + 1;
            curr <= a[index]; curr++)
            Console.Write(curr + " ");
    }

    
    static void Main()
    {
        int[] a = { 3, 10, 3, 11, 4,
                    5, 6, 7, 8, 12 };
        int n = a.Length;
        longestSubsequence(a, n);
        Console.ReadKey();
    }
}