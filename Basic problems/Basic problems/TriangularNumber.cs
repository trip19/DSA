//Time complexity: O(1)
//Space complexity: O(1)
class TriangularNumber
{
    public int GetNthNumber(int n)
    {
        return n * (n + 1) / 2;
    }
    //public static void Main(string[] args)
    //{
    //    int n = 4;
    //    TriangularNumber obj = new TriangularNumber();
    //    Console.WriteLine($"The {13}th triangular number is {obj.GetNthNumber(n)}");
    //}
}
