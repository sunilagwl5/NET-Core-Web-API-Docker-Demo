using System;

class BubbleSort
{

    /// <summary>
    /// Finds the maximum of two numbers and returns the result.
    /// </summary>
    /// <param name="num1">The first number to compare.</param>
    /// <param name="num2">The second number to compare.</param>
    /// <returns>The greater of the two numbers, <paramref name="num1"/> or <paramref name="num2"/>.</returns>
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
    /// Calculates the factorial of a given number.
    /// </summary>
    /// <param name="number">The number for which the factorial is to be calculated.</param>
    /// <returns>The factorial of the given <paramref name="number"/>.</returns>
    /// <exception cref="System.ArgumentException">Thrown when the input number is negative.</exception>
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
