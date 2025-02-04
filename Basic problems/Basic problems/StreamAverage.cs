//Time complexity: O(n) 
//Space complexity: O(1)
class StreamAverage
{
    public float CalculateAvg(float prevAvg, int count, float num)
    {
        return ((prevAvg * count) + num) / (count + 1);
    }
    //public static void Main(string[] args)
    //{
    //    float[] arr = { 10, 20, 30, 40, 50, 60 };
    //    StreamAverage obj = new StreamAverage();
    //    float prevAvg = 0;
    //    int count = 0;
    //    for(int i = 0; i < arr.Length; i++)
    //    {
    //        prevAvg = obj.CalculateAvg(prevAvg, count, arr[i]);
    //        Console.WriteLine($"The average of {count + 1} numbers is {prevAvg}");
    //        count++;
    //    }
    //}
}