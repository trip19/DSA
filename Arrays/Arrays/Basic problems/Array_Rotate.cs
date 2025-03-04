using System;

class ArrayRotate
{
    //Time complexity: O(d*n)
    //Space complexity: O(1)
    //public static void RotateArray(int[] arr, int d)
    //{
    //    int n = arr.Length;
    //    while (d > 0)
    //    {
    //        var temp = arr[n - 1];
    //        for (int i = n - 1; i >= 0; i--)
    //        {
    //            if (i == 0)
    //            {
    //                arr[i] = temp;
    //            }
    //            else
    //            {
    //                arr[i] = arr[i - 1];
    //            }
    //        }
    //        d--;
    //    }
    //    Console.WriteLine($"Array after {d} rotation: ");
    //    for (int i = 0; i < n; i++)
    //    {
    //        Console.Write(arr[i] + " ");
    //    }
    //}
    //public static void Main()
    //{
    //    int[] arr = { 1, 2, 3 };
    //    int d = 4;
    //    RotateArray(arr, d);
    //}
}