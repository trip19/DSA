using System;

class ReverseArray
{
    //Time complexity: O(n)
    //Space complexity: O(1)
    public static void ReversenArray(int[] arr)
    {
        int temp = 0;
        int n = arr.Length;
        for(int i = 0; i < n/2; i++)
        {
            temp = arr[i];
            arr[i] = arr[n - 1 - i];
            arr[n - 1 - i] = temp;
        }
        Console.WriteLine("Array after reverse");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
    //public static void Main()
    //{
    //    int[] arr = { 4, 5, 1, 2 };
    //    ReverseArray(arr);
    //}
}
