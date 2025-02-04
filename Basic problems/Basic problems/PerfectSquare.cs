
class PerfectSquare
{
    //Time complexity: O(n^(1/2))
    //Space complexity: O(1)
    //public bool IsPerfectSquare(long n)
    //{
    //    int odd = 1;
    //    while (n > 0)
    //    {
    //        n -= odd;
    //        odd += 2;
    //    }
    //    return (n == 0);
    //}

    //Time complexity: O(log n)
    //Space complexity: O(1)
    public bool IsPerfectSquare(long n)
    {
        long low = 1, high = n/2;
        long mid;
        while (low < high)
        {
            mid = low + (high - low) / 2;
            long sqr = mid * mid;
            if (sqr == n)
            {
                return true;
            }
            if (sqr > n)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return false;
    }
    //public static void Main(string[] args)
    //{
    //    long n = 49;
    //    PerfectSquare obj = new PerfectSquare();
    //    if (obj.IsPerfectSquare(n))
    //    {
    //        Console.WriteLine("The number is a perfect square");
    //    }
    //    else
    //    {
    //        Console.WriteLine("The number is not a perfect square");
    //    }
    //}
}