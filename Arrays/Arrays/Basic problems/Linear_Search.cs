using System;

//Time complexity: O(n)
//Space complexity: O(1)
class LinearSearch()
{
    public static int Search(int[] arr, int key)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key)
            {
                return i;
            }
        }
        return -1;
    }
    //public static void Main(String[] args)
    //{
    //    int[] arr = { 1, 2, 54, 23, 10, 21, 47, 10, 8, 20 };
    //    int key = 7;
    //    int index = Search(arr, key);
    //    if(index == -1)
    //    {
    //        Console.WriteLine("Value not found in array");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Value found at " + index);
    //    }
    //}
}
