using System;

class Leaders
{
    //Time complexity: O(n^2)
    //Space complexity: O(1)
    //public static void LeadersArray(int[] arr)
    //{
    //    int flag;
    //    for(int i = 0; i < arr.Length; i++)
    //    {
    //        flag = 0;
    //        for(int j = i+1; j < arr.Length; j++)
    //        {
    //            if (arr[j] >= arr[i])
    //            {
    //                flag++;
    //            }
    //            if (flag > 0)
    //            {
    //                break;
    //            }
    //        }
    //        if (flag == 0)
    //        {
    //            Console.Write(" " + arr[i]);
    //        }
    //    }
    //}

    //Time complexity: O(n)
    //Space complexity: O(1)
    public static void LeadersArray(int[] arr)
    {
        int n = arr.Length;
        int maxRight = arr[n - 1];
        List<int> leaders = new List<int>();
        leaders.Add(maxRight);
        for(int i = n - 2; i >= 0; i--)
        {
            if (arr[i] > maxRight)
            {
                maxRight = arr[i];
                leaders.Add(maxRight);
            }
        }
        leaders.Reverse();
        foreach (int res in leaders)
        {
            Console.Write(res + " ");
        }
    }
    //public static void Main()
    //{
    //    int[] arr = { 16, 17, 4, 3, 5, 2 };
    //    LeadersArray(arr);
    //}
}