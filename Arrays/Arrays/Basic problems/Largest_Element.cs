using System;

//Time complexity: O(n)
//Space complexity: O(1)
class LargestElement
{
    public static int Largest(int[] arr)
    {
        int max = Int32.MinValue;
        for(int i = 0; i < arr.Length; i++)
        {
            if (max <= arr[i])
            {
                max = arr[i];
            }
        }
        return max;
    }
    //public static void Main(String[] args)
    //{
    //    int[] arr = {1, -3, 6, 7, 3, 89, 32, -76, 2, 10};
    //    Console.WriteLine("The largest element in the array is: " + Largest(arr));
    //}
}
