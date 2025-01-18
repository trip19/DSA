//Time complexity: O(n^2)
//Space complexity: O(1)
class FloydsTriangle
{
    public void PrintFloydsTriangle(int n)
    {
        int num = 1;
        int j = 0;
        for(int i = 1; i <= n; i++)
        {
            j = 1;
            while (j <= i)
            {
                Console.Write(num+" ");
                num++;
                j++;
            }
            Console.WriteLine("");
        }
    }
    //public static void Main(string[] args)
    //{
    //    int n = 5;
    //    FloydsTriangle obj = new FloydsTriangle();
    //    obj.PrintFloydsTriangle(n);
    //}
}
