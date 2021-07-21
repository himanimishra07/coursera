using System;
using System.Collections.Generic;

class CNOISS
{

    static readonly int N = 10000;

    // Segment tree array 
    static int[] seg = new int[3 * N];

    // Function for point update In segment tree 
    static int update(int In, int l, int r,
                        int up_in, int val)
    {
        // Base case 
        if (r < up_in || l > up_in)
            return seg[In];

        // If l==r==up 
        if (l == up_in && r == up_in)
            return seg[In] = val;

        // Mid element 
        int m = (l + r) / 2;

        // Updating the segement tree 
        return seg[In] = update(2 * In + 1, l, m, up_in, val) +
                update(2 * In + 2, m + 1, r, up_in, val);
    }

    // Function for the range sum-query 
    static int query(int In, int l, int r, int l1, int r1)
    {
        // Base case 
        if (l > r)
            return 0;
        if (r < l1 || l > r1)
            return 0;
        if (l1 <= l && r <= r1)
            return seg[In];

        // Mid element 
        int m = (l + r) / 2;

        // Calling for the left and the right subtree 
        return query(2 * In + 1, l, m, l1, r1) +
                query(2 * In + 2, m + 1, r, l1, r1);
    }

    // Function to return the count 
    static int findCnt(int[] arr, int n)
    {
        // Copying array arr to sort it 
        int[] brr = new int[n];
        for (int i = 0; i < n; i++)
            brr[i] = arr[i];

        // Sorting array brr 
        Array.Sort(brr);

        // Map to store the rank of each element 
        Dictionary<int, int> r = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
            r.Add(brr[i], i + 1);

        // dp array 
        int[] dp = new int[n];

        // To store the readonly answer 
        int ans = 0;

        // Updating the dp array 
        for (int i = n - 1; i >= 0; i--)
        {

            // Rank of the element 
            int rank = r[arr[i]];

            // Solving the dp-states using segment tree 
            dp[i] = 1 + query(0, 0, n - 1, rank, n - 1);

            // Updating the readonly answer 
            ans += dp[i];

            // Updating the segment tree 
            update(0, 0, n - 1, rank - 1, dp[i] +
                    query(0, 0, n - 1, rank - 1, rank - 1));
        }

        // Returning the readonly answer 
        return ans;
    }

    // Driver code 
    public static void Main(String[] args)
    {
        int[] arr = { 1, 2, 10, 9 };
        int n = arr.Length;

        Console.Write(findCnt(arr, n));
        Console.ReadKey();

    }
}
