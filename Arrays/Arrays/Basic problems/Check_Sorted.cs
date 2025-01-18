using System;

//Time complexity: O(n)
//Space complexity: O(1)
class CheckSorted()
{
    public static void CheckIfSorted(int[] arr)
    {
        int flag = 0;
        int max = arr[0];
        for(int i = 1; i < arr.Length; i++)
        {
            if (arr[i] >= max)
            {
                max = arr[i];
            }
            else
            {
                flag++;
                break;
            }
        }
        if (flag > 0)
        {
            Console.WriteLine("Array is not sorted");
        }
        else
        {
            Console.WriteLine("Array is sorted");
        }
    }
    //public static void Main()
    //{
    //    int[] arr = { 20, 20, 78, 98, 99, 97 };
    //    CheckIfSorted(arr);
    //}
}
