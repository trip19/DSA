//Time complexity: O(1)
//Space complexity: O(1)
class AreaVolumeOfCuboid
{
    public double[] CalculateAreaVolume(float l, float b, float h)
    {
        double[] arr = { 2 * ((l * b) + (b * h) + (h * l)), l * b * h };
        return arr;
    }
    //public static void Main(string[] args)
    //{
    //    float l = 2, b = 3, h = 4;
    //    AreaVolumeOfCuboid obj = new AreaVolumeOfCuboid();
    //    foreach(double i in obj.CalculateAreaVolume(l, b, h))
    //    {
    //        Console.Write(i + " ");
    //    }
    //}
}