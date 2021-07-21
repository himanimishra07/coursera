
using System;

public class GFG
{
    static public void Main()
    {
        int number = Int32.Parse(Console.ReadLine());
        string y = Console.ReadLine();
        string[] tokens = y.Split(' '); /* all the spaces between the integers will be removed and they will assign into an array accordingly */
        int[] arr = new int[tokens.Length];

        for (int i = 0; i < tokens.Length; i++)
        {
            arr[i] = int.Parse(tokens[i]);
        }

        int n = arr.Length;

        // Function calling  
        findMajority(arr, n);

        Console.ReadKey();
    }

    // Function to find Majority element  
    // in an array  
    static void findMajority(int[] arr, int n)
    {
        int maxCount = 0;
        int index = -1; // sentinels  that avoid branches
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < n; j++)
            {
                if (arr[i] == arr[j])
                    count++;
            }

            // update maxCount if count of  
            // current element is greater  
            if (count > maxCount)
            {
                maxCount = count;
                index = i;
            }
        }

        // if maxCount is greater than n/2  
        // return the corresponding element  
        if (maxCount > n / 2)
            Console.WriteLine(arr[index]);
        else
            Console.WriteLine(0);
    }
    
}