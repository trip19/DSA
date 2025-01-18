//Time complexity: O(1) 
//Space complexity: O(1)
class SwapNumbers
{
    public void SwapValue(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
    //public static void Main(string[] args)
    //{
    //    int a = 256, b = 76;
    //    SwapNumbers obj = new SwapNumbers();
    //    Console.WriteLine("The numbers before swapping are: a = " + a + " and b = " + b);
    //    obj.SwapValue(ref a, ref b);
    //    Console.WriteLine("The numbers after swapping are: a = " + a + " and b = " + b);
    //}
}
