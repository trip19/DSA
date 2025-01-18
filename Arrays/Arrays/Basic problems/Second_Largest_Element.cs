using System;
//Time complexity: O(n)
//Space complexity: O(1)
class SecondLargestElement
{
    public static int SecondLargest(int[] arr)
    {
        int max = -1;
        int secMax = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                secMax = max;
                max = arr[i];
            }
            else if (arr[i] < max && arr[i] > secMax)
            {
                secMax = arr[i];
            }
        }
        return secMax;
    }
    //public static void Main(String[] args)
    //{
    //    int[] arr = { 10, 10, 10 };
    //    int result = SecondLargest(arr);
    //    if(result == -1)
    //    {
    //        Console.WriteLine("The second largest element does not exist");
    //    }
    //    else
    //    {
    //        Console.WriteLine("The second largest element is: " + result);
    //    }
    //}
}
