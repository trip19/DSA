//Time complexity: O(n^(1/2))
//Space complexity: O(1)
class PrimeNumbers
{
    public bool IsPrime(long n)
    {
        for(int i=2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    //public static void Main(string[] args)
    //{
    //    long n = 22;
    //    PrimeNumbers obj = new PrimeNumbers();
    //    if (obj.IsPrime(n))
    //    {
    //        Console.WriteLine("The number is a prime number");
    //    }
    //    else
    //    {
    //        Console.WriteLine("The number is not a prime number");
    //    }
    //}
}