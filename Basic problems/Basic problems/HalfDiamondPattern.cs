//Time complexity: O(n^2) 
//Space complexity: O(1)
class HalfDiamondPattern
{
    public void PrintHalfDiamond(int n)
    {
        for(int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*"); 
            }
            Console.WriteLine("");
        }

        for (int i = n-1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
    //public static void Main(string[] args)
    //{
    //    int n = 6;
    //    HalfDiamondPattern obj = new HalfDiamondPattern();
    //    obj.PrintHalfDiamond(n);
    //}
}

