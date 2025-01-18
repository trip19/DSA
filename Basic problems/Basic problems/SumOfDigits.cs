//Time complexity: O(k) where k is the number of digits in n
//Space complexity: O(1)
class SumOfDigits()
{
    public int CalculateSum(int n)
    {
        int sum = 0;
        while (n != 0)
        {
            sum = sum + (n % 10);
            n = n / 10;
        }
        return sum;
    }
    //public static void Main(string[] args)
    //{
    //    int num = 23;
    //    SumOfDigits obj = new SumOfDigits();
    //    Console.WriteLine($"The sum of digits of {num} is {obj.CalculateSum(num)}");
    //}
}
