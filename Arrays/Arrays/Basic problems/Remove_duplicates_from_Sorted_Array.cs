using System;

class RemoveDuplicates
{
    //Time complexity: O(n)
    //Space complexity: O(n)
    public static int removeDuplicatesHashSet(int[] arr)
    {
        HashSet<int> temp = new HashSet<int>();
        int k = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (!temp.Contains(arr[i]))
            {
                temp.Add(arr[i]);
                arr[k] = arr[i];
                k++;
            }
        }
        return k;
    }

    //Time complexity: O(n)
    //Space complexity: O(1)
    public static int removeDuplicates(int[] arr)
    {
        int k = 1;
        int temp = arr[0];
        for(int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != temp)
            {
                temp = arr[i];
                arr[k] = arr[i];
                k++;
            }
        }
        return k;
    }
    //public static void Main()
    //{
    //    int[] arr = { 1, 2, 2, 3, 4, 4, 4, 5, 5 };
    //    int k = removeDuplicates(arr);
    //    for (int i = 0; i < k; i++)
    //    {
    //        Console.WriteLine(arr[i]+" ");
    //    }
    //}
}
