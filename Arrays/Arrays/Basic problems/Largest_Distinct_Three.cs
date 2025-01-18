using System;

//Time complexity: O(n)
//Space complexity: O(1)
class LargestDistinctThree
{
    public static void LargestThree(int[] arr)
    {
        int max = -1, secMax = -1, thirdMax = -1;
        int i;
        if (arr.Length < 3)
        {
            Console.WriteLine("Invalid input");
            return;
        }
        for (i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine("the three distinct largest values are: " + max);
        for (i = 0; i < arr.Length; i++)
        {
            if (arr[i] > secMax && arr[i] != max)
            {
                secMax = arr[i];
            }
        }
        if (secMax != -1)
        {
            Console.WriteLine("second max: " + secMax);
        }
        for (i = 0; i < arr.Length; i++)
        {
            if (arr[i] > thirdMax && arr[i] != secMax && arr[i] != max)
            {
                thirdMax = arr[i];
            }
        }
        if (secMax != -1)
        {
            Console.WriteLine("third max: " + thirdMax);
        }
    }
    //public static void Main(String[] args)
    //{
    //    int[] arr = { 10, 4, 3, 50, 23, 90 };
    //    LargestThree(arr);
    //}
}