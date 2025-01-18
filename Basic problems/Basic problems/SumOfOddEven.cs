class SumOfOddEven
{
    //Time complexity: O(n) 
    //Space complexity: O(1)
    //public void CalculateSum(int[] arr)
    //{
    //    int evenSum = 0, oddSum = 0;
    //    for(int i = 0; i < arr.Length; i++)
    //    {
    //        if (i % 2 == 0)
    //        {
    //            evenSum = evenSum + arr[i];
    //        }
    //        else
    //        {
    //            oddSum = oddSum + arr[i];
    //        }
    //    }
    //    Console.WriteLine($"The sum of elements at even indices of the array are: {evenSum}");
    //    Console.WriteLine($"The sum of elements at odd indices of the array are: {oddSum}");
    //}

    //Time complexity: O(n) 
    //Space complexity: O(1)
    public void CalculateSum(int[] arr)
    {
        int evenSum = 0, oddSum = 0;
        for (int i = 0; i < arr.Length; i = i + 2)
        {
            if (i == arr.Length - 1)
            {
                evenSum = evenSum + arr[i];
            }
            else
            {
                evenSum = evenSum + arr[i];
                oddSum = oddSum + arr[i + 1];
            }
        }
        Console.WriteLine($"The sum of elements at even indices of the array are: {evenSum}");
        Console.WriteLine($"The sum of elements at odd indices of the array are: {oddSum}");
    }

    //public static void Main(string[] args)
    //{
    //    int[] arr = { 10, 20, 30, 40, 50, 60, 70 };
    //    SumOfOddEven obj = new SumOfOddEven();
    //    obj.CalculateSum(arr);
    //}
}
