
class SquareRoot
{
    //Time complexity: O(sqrt(n)) 
    //Space complexity: O(1)
    //public int CalculateSquareRoot(float num)
    //{
    //    int val = 1;
    //    while (val * val <= num)
    //    {
    //        val++;
    //    }
    //    return val - 1;
    //}

    //Time complexity: O(log(n)) 
    //Space complexity: O(1)
    public float CalculateSquareRoot(float num)
    {
        float low = 1, high = num;
        float mid;
        float val = 0;
        while (low <= high)
        {
            mid = (low + high) / 2;
            if (mid * mid == num)
            {
                val = mid;
                break;
            }
            else if(mid * mid < num)
            {
                val = mid;
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return val;
    }
    //public static void Main(string[] args)
    //{
    //    float num = 11;
    //    SquareRoot obj = new SquareRoot();
    //    Console.WriteLine($"The square root of {num} is {obj.CalculateSquareRoot(num)}");
    //}
}