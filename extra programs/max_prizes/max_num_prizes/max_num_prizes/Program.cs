using System;

class Max_Prize
{
    public static void Main()
    {
        int candies = Int32.Parse(Console.ReadLine());

        printAllUniqueParts(candies);
        Console.ReadKey();
    }


    // Function to print an array p[]  
    // of size n 
    static void printArray(int[] p, int n)
    {
        for (int i = 0; i < n; i++)
            Console.Write(p[i] + " ");

        Console.WriteLine();
    }

    // Function to generate all unique  
    // partitions of an integer 
    static void printAllUniqueParts(int n)
    {

        // An array to store a partition 
        int[] p = new int[n];

        // Index of last element in a  
        // partition 
        int k = 0;

        // Initialize first partition as  
        // number itself 
        p[k] = n;

        // This loop first prints current  
        // partition, then generates next 
        // partition. The loop stops when  
        // the current partition has all 1s 
        while (true)
        { // print current partition 
            printArray(p, k + 1);

            // Generate next partition 

            // Find the rightmost non-one  
            // value in p[]. Also, update  
            // the rem_val so that we know 
            // how much value can be  
            // substituted
            int rem_val = 0;

            while (k >= 0 && p[k] == 1)
            {
                rem_val += p[k];
                k--;
            }

            // if k < 0, all the values are 1 so 
            // there are no more partitions 
            if (k < 0)
                return;

            // Decrease the p[k] found above  
            // and adjust the rem_val 
            p[k]--;
            rem_val++;


            // If rem_val is more, then the sorted 
            // order will be wrong. Divide rem_val in 
            // differnt values of size p[k] and copy 
            // these values at different positions 
            // after p[k] 
            while (rem_val > p[k])
            {
                p[k + 1] = p[k];
                rem_val = rem_val - p[k];
                k++;
            }

            // Copy rem_val to next position and  
            // increment position 
            p[k + 1] = rem_val;
            k++;
        }
    }
    
}