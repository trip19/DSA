
class SumOfGP
{
    //Time complexity: O(n)
    //Space complexity: O(1)
    //public float CalculateSumOfGP(float a, float r, float n)
    //{
    //    float sum = 0;
    //    for(int i = 1; i <= n; i++)
    //    {
    //        sum = sum + a;
    //        a = a * r;
    //    }
    //    return sum;
    //}

    //Time complexity: O(logn)
    //Space complexity: O(1)
    public float CalculateSumOfGP(float a, float r, float n)
    {
        return (float)(a * (Math.Pow(r, n) - 1)) / (r - 1);
    }
    //public static void Main(string[] args)
    //{
    //    float a = 2, r = 2, n = 15;
    //    SumOfGP obj = new SumOfGP();
    //    Console.WriteLine($"The sum of first {n} terms of the GP are: {Math.Round(obj.CalculateSumOfGP(a, r, n),5)}");
    //}
}