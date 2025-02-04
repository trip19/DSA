
class GCD
{
    //Time complexity: O(min(a,b))
    //Space complexity: O(1)
    //public int CalculateGCD(int a, int b)
    //{
    //    int val = Math.Min(a, b);
    //    while (val > 0)
    //    {
    //        if (a % val == 0 && b % val == 0)
    //        {
    //            break;
    //        }
    //        val--;
    //    }
    //    return val;
    //}

    //Time complexity: O(log(min(a,b)))
    //Space complexity: O(1)
    public int CalculateGCD(int a, int b)
    {
        while(a > 0 && b > 0)
        {
            if (a > b)
            {
                a = a % b;
            }
            else
            {
                b = b % a;
            }
        }
        if (a == 0)
        {
            return b;
        }
        else
        {
            return a;
        }
    }
    //public static void Main(string[] args)
    //{
    //    int a = 98, b = 56;
    //    GCD obj = new GCD();
    //    Console.WriteLine($"The GCD of {a} and {b} is {obj.CalculateGCD(a, b)}");
    //}
}