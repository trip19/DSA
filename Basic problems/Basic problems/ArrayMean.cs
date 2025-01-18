//Time complexity: O(n) 
//Space complexity: O(1)
class ArrayMean
{
    public int CalculateMean(int[] arr)
    {
        int sum = 0;
        foreach(int i in arr)
        {
            sum = sum + i;
        }
        float mean = sum / arr.Length;
        return (int)Math.Floor(mean);
    }
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 4, 4, 4, 4, 4 };
    //    ArrayMean obj = new ArrayMean();
    //    Console.WriteLine($"The mean of the array is:{obj.CalculateMean(arr)}");
    //}
}
