//Time complexity: O(n^2) 
//Space complexity: O(1)
class Patterns
{
    public void SolidSquare(int n)
    {
        for(int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine(" ");
        }
        Console.WriteLine(" ");
    }
    public void HollowSquare(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i == 1 || i == n || j == 1 || j == n)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine(" ");
        }
        Console.WriteLine(" ");
    }
    public void RightTriangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine(" ");
        }
    }
    //public static void Main(string[] args)
    //{
    //    int num = 4;
    //    Patterns obj = new Patterns();
    //    obj.SolidSquare(num);
    //    obj.HollowSquare(num);
    //    obj.RightTriangle(num);
    //}
}