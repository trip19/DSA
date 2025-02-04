//Time complexity: O(n*logn)
//Space complexity: O(1)
class MinDifference
{
    public int CalculateMinDiff(int[] arr, int m)
    {
        int minDiff = Int32.MaxValue;
        Array.Sort(arr);
        for(int i = 0; i <= arr.Length - m; i++)
        {
            if (arr[i+m-1] - arr[i] < minDiff)
            {
                minDiff = arr[i + m - 1] - arr[i];
            }
        }
        return minDiff;
    }
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 7, 3, 2, 4, 9, 12, 56 };
    //    int m = 3;
    //    MinDifference obj = new MinDifference();
    //    Console.WriteLine($"The minimum max difference in the array is {obj.CalculateMinDiff(arr,m)}");
    //}
}