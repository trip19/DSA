//Time complexity: O(n) 
//Space complexity: O(1)
class MaxProduct
{
    public void CalcMaxProd(int[] arr)
    {
        int posA = int.MinValue;
        int posB = int.MaxValue;
        int negA = int.MinValue;
        int negB = int.MaxValue;
        foreach (int i in arr)
        {
            if (i > posA)
            {
                posB = posA;
                posA = i;
            }
            else if (i > posB)
            {
                posB = i;
            }
            if(i < 0 && Math.Abs(i) > Math.Abs(negA))
            {
                negB = negA;
                negA = i;
            }
            else if(i < 0 && Math.Abs(i) > Math.Abs(negB))
            {
                negB = i;
            }
        }
        if (negA * negB > posA * posB)
        {
            Console.WriteLine($"The product of {negA} and {negB} is maximum");
        }
        else
        {
            Console.WriteLine($"The product of {posA} and {posB} is maximum");
        }
    }
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 1, 4, 3, 6, 7, 0 };
    //    MaxProduct obj = new MaxProduct();
    //    obj.CalcMaxProd(arr);
    //}
}