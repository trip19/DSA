//Time complexity: O(1)
//Space complexity: O(1)
class AutomorphicNumber
{
    public bool IsAutomorphic(int n)
    {
        return (n * n) % 10 == n % 10 ? true : false;
    }
    //public static void Main(string[] args)
    //{
    //    int n = 7;
    //    AutomorphicNumber obj = new AutomorphicNumber();
    //    if (obj.IsAutomorphic(n))
    //    {
    //        Console.WriteLine($"The number {n} is a automorphic number");
    //    }
    //    else
    //    {
    //        Console.WriteLine($"The number {n} is not a automorphic number");
    //    }
    //}
}
