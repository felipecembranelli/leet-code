using System;

public static class KLargestElement {
    public static void kLargest(int[] arr, int k)
    {
        // Sort the given array arr in reverse order
        // This method doesn't work with primitive data
        // types. So, instead of int, Integer type
        // array will be used
        Array.Sort(arr);
        Array.Reverse(arr);

        // Print the first kth largest elements
        for (int i = 0; i < k; i++)
            Console.Write(arr[i] + " ");
    }

    // Driver code
 public static void Main()
    {
        int[] arr = new int[] { 1, 23, 12, 9, 30, 2, 50 };
        int k = 3;
        kLargest(arr, k);
    }
}