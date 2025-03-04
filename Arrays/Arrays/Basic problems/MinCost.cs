//Time complexity: O(n)
//Space complexity: O(1)
class MinCost
{
    public int CalculateCost(int[] arr)
    {
        int min = Int32.MaxValue;
        foreach(int i in arr)
        {
            if (i < min)
            {
                min = i;
            }
        }
        return (arr.Length - 1) * min;
    }
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 4, 3, 2 };
    //    MinCost obj = new MinCost();
    //    Console.WriteLine("The minimum cost to reduce array size to 1 is: " + obj.CalculateCost(arr));
    //}
}