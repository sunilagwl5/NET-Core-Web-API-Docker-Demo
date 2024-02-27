using System;

class BubbleSort
{
    // Main method to execute the program
    static void Sample(string[] args)
    {   
        int[] arr = { 78, 55, 45, 98, 13 };
        int n = arr.Length;

        Console.WriteLine("Original array:");
        foreach (int value in arr)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();

        BubbleSortArray(arr, n);

        Console.WriteLine("Sorted array:");
        foreach (int value in arr)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Performs the Bubble Sort algorithm on an array.
    /// </summary>
    /// <param name="arr">The array to be sorted.</param>
    /// <param name="n">The length of the array.</param>
    static void BubbleSortArray(int[] arr, int n)
    {
        for (int i = 0; i < n - 1; i++)
        {
            // Flag to detect any swap
            bool swapped = false;

            // Perform a pass through the array
            for (int j = 0; j < n - i - 1; j++)
            {
                // Compare adjacent elements and swap them if in wrong order
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            // If no two elements were swapped by inner loop, then break
            if (!swapped)
                break;
        }
    }
}
