using System;
//Time complexity = O(N)
//space complexity = O(1)
class SumOfSumSeries
{
    public int CalculateSum(int n)
    {
        int finalSum = 0;
        for(int i = 1; i <= n; i++)
        {
            int sumSeries = (n * (n + 1)) / 2;
            finalSum = finalSum + sumSeries;
        }
        return finalSum;
    }
    //public static void Main(string[] args)
    //{
    //    int n = 2;
    //    SumOfSumSeries obj = new SumOfSumSeries();
    //    int sum = obj.CalculateSum(n);
    //    Console.WriteLine("The sum of sum-series of " + n + " is " + sum);
    //}
}
