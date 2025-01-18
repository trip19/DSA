//Time complexity: O(1)
//Space complexity: O(1)
class DistanceBtwPoints
{
    public float CalculateDistance(float x1, float y1, float x2, float y2)
    {
        float x = (float)Math.Pow((x2 - x1), 2);
        float y = (float)Math.Pow((y2 - y1), 2);
        return (float)Math.Sqrt(x + y);
    }
    //public static void Main(string[] args)
    //{
    //    float x1 = 3, y1 = 4, x2 = 4, y2 = 3;
    //    DistanceBtwPoints obj = new DistanceBtwPoints();
    //    Console.WriteLine($"The distance between the points ({x1},{y1}) and ({x2},{y2}) is: {obj.CalculateDistance(x1, y1, x2, y2)}");
    //}
}