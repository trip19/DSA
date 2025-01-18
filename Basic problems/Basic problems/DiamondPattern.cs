//Time complexity: O(n^2) 
//Space complexity: O(1)
class DiamondPattern
{
    public void PrintDiamond(int n)
    {
        for(int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n-i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("");
        }
        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= n-i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("");
        }
    }
    //public static void Main(string[] args)
    //{
    //    int n = 12;
    //    DiamondPattern obj = new DiamondPattern();
    //    obj.PrintDiamond(n);
    //}
}
