//Time complexity: O(1)
//Space complexity: O(1)
class SimpleInterest
{
    public float CalculateInterest(float P, float R, float T)
    {
        return P * R * T / 100;
    }
    //public static void Main(string[] args)
    //{
    //    float P = 1000, R = 5, T = 2;
    //    SimpleInterest obj = new SimpleInterest();
    //    Console.WriteLine($"The simple interest is: {obj.CalculateInterest(P, R, T)}");
    //}
}