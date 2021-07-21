using System;

class InsertionSort
{
    public static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        string y = Console.ReadLine();
        string[] tokens = y.Split(' '); /* all the spaces between the integers will be removed and they will assign into an array accordingly */
        int[] arr = new int[tokens.Length];

        for (int i = 0; i < tokens.Length; i++)
        {
            arr[i] = int.Parse(tokens[i]);
        }

        InsertionSort ob = new InsertionSort();
        ob.sort(arr);
        printArray(arr);
        Console.ReadKey();
    }
    // Function to sort array 
    // using insertion sort 
    void sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;

            // Move elements of arr[0..i-1], 
            // that are greater than key, 
            // to one position ahead of 
            // their current position 
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    // A utility function to print 
    // array of size n 
    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");

        Console.Write("\n");
    }
   
}
