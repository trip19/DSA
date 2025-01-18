//Time complexity: O(n)
//Space complexity: O(1)
class Factorial
{
    public long CalculateFactorial(int n)
    {
        int product = 1;
        for(int i = 1; i <= n; i++)
        {
            product = product * i;
        }
        return product;
    }
    //public static void Main(string[] args)
    //{
    //    int n = 4;
    //    Factorial obj = new Factorial();
    //    Console.WriteLine($"The factorial of {n} is {obj.CalculateFactorial(n)}");
    //}
}