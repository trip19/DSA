//Time complexity: O(1)
//Space complexity: O(1)
class SumOfAP
{
    public float SumOfApTerms(float a, float d, float n)
    {
        float sum = (n * ((2 * a) + ((n - 1) * d))) / 2;
        return sum;
    }
    //public static void Main(string[] args)
    //{
    //    float a = 2.5f, d = 1.5f, n = 20;
    //    SumOfAP obj = new SumOfAP();
    //    Console.WriteLine($"The sum of first {n} terms of the AP is: {obj.SumOfApTerms(a, d, n)}");
    //}
}
