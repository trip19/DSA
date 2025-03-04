//Time complexity: O(n+m) where n and m are the sizes of countArray and input array respectively
//Space complexity: O(n+m)
class CountSort
{
    public int[] SortArray(int[] arr)
    {
        int max = MaxElement(arr);
        int[] countArr = new int[max + 1];
        int[] outputArr = new int[arr.Length];
        for(int i=0;i < arr.Length; i++)
        {
            countArr[arr[i]]++;
        }
        PrefixSum(ref countArr);
        for(int i = arr.Length-1; i >= 0; i--)
        {
            outputArr[countArr[arr[i]] - 1] = arr[i];
            countArr[arr[i]]--;
        }
        return outputArr;
    }

    public void PrefixSum(ref int[] countArr)
    {
        for(int i = 1; i < countArr.Length; i++)
        {
            countArr[i] = countArr[i - 1] + countArr[i];
        }
    }

    public int MaxElement(int[] arr)
    {
        int max = Int32.MinValue;
        foreach(int i in arr)
        {
            if(i > max)
            {
                max = i;
            }
        }
        return max;
    }
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 4, 3, 12, 1, 5, 5, 3, 9 };
    //    CountSort obj = new CountSort();
    //    var outputArr = obj.SortArray(arr);
    //    Console.WriteLine("The array after sorting is: ");
    //    foreach (int i in outputArr)
    //    {
    //        Console.Write(i + " ");
    //    }
    //}
}