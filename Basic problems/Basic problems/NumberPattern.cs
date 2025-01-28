//Time complexity: O(n^2)
//Space complexity: O(1)
class NumberPattern
{
    public void PrintPattern(int n)
    {
        for(int i = 1; i <= n; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            for (int j = i-1; j >= 1; j--)
            {
                Console.Write(j);
            }
            Console.Write(" ");
        }
    }
    //public static void Main(string[] args)
    //{
    //    int n = 10;
    //    NumberPattern obj = new NumberPattern();
    //    obj.PrintPattern(n);
    //}
}
