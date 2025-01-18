//Time complexity: O(log n)  
//Space complexity: O(k)
class PalindromicSum
{
    public bool IsPalindromicSum(int n)
    {
        long sum = 0L;
        long revSum = 0L;
        while (n != 0)
        {
            sum = sum + n % 10;
            n = n / 10;
        }
        long val = sum;
        while (sum != 0)
        {
            revSum = revSum * 10 + sum % 10;
            sum = sum / 10; 
        }
        if (val == revSum)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //public static void Main(string[] args)
    //{
    //    int n = 56;
    //    PalindromicSum obj = new PalindromicSum();
    //    if (obj.IsPalindromicSum(n))
    //    {
    //        Console.WriteLine($"The sum of digits of {n} is a palindrome");
    //    }
    //    else
    //    {
    //        Console.WriteLine($"The sum of digits of {n} is not a palindrome");
    //    }
    //}
}
