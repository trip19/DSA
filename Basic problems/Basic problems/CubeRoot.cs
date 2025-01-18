//Time complexity: O(logn)
//Space complexity: O(1)
class CubeRoot
{
    public double CalculateCubeRoot(double n, double prec)
    {
        bool isNegative = n < 0 ? true : false;
        if (n == 0)
        {
            return 0;
        }
        n = Math.Abs(n);
        double low = 0, high = n;
        if (n < 1)
        {
            high = 1;
        }
        double mid, diff;
        double val;
        while (true)
        {
            mid = (low + high) / 2;
            diff = Math.Abs(mid * mid * mid - n);
            if (diff <= prec)
            {
                val = mid;
                break;
            }
            
            if((mid * mid * mid) > n)
            {
                high = mid;
            }
            else
            {
                low = mid;
            }
        }
        return isNegative ? -val : val;
    }
    //public static void Main(string[] args)
    //{
    //    double n = 0.234;
    //    double precision = 0.00001;
    //    CubeRoot obj = new CubeRoot();
    //    Console.WriteLine("The cube root of " + n + " is " + obj.CalculateCubeRoot(n, precision));
    //}
}