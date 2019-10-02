using System;

class majority_elements
{
    static public void Main()
    {

        int n = Int32.Parse(Console.ReadLine());
        string y = Console.ReadLine();
        string[] tokens = y.Split(' '); /* all the spaces between the integers will be removed and they will assign into an array accordingly */
        int[] arr = new int[tokens.Length];

        for (int i = 0; i < tokens.Length; i++)
        {
            arr[i] = int.Parse(tokens[i]);
        }

        // Function calling  
        printMajority(arr, n);
    }
    /* Function to print Majority Element */
    static void printMajority(int[] a, int size)
    {
        /* Find the candidate for Majority*/
        int cand = findCandidate(a, size);

        /* Print the candidate if it is Majority*/
        if (isMajority(a, size, cand))
            Console.Write(1);
        else
            Console.Write(0);
    }

    /* Function to find the candidate for Majority */
    static int findCandidate(int[] a, int size)
    {
        int maj_index = 0, count = 1;
        int i;
        for (i = 1; i < size; i++)
        {
            if (a[maj_index] == a[i])
                count++;
            else
                count--;

            if (count == 0)
            {
                maj_index = i;
                count = 1;
            }
        }
        return a[maj_index];
    }

    // Function to check if the candidate  
    // occurs more than n/2 times 
    static bool isMajority(int[] a, int size, int cand)
    {
        int i, count = 0;
        for (i = 0; i < size; i++)
        {
            if (a[i] == cand)
                count++;
        }
        if (count > size / 2)
            return true;
        else
            return false;
    }
   
}