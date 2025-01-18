//Time complexity: O(1) 
//Space complexity: O(1)
class LargestNumber()
{
    public int GetLargestNumber(int a, int b, int c)
    {
        if (a >= b)
        {
            if (a >= c)
            {
                return a;
            }
            else
            {
                return c;
            }
        }
        else
        {
            if (b >= c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
    //public static void Main(string[] args)
    //{
    //    int a = 10, b = 22, c = 19;
    //    LargestNumber obj = new LargestNumber();
    //    Console.WriteLine($"The largest number is: {obj.GetLargestNumber(a,b,c)}");
    //}
}