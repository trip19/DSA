//Time complexity: O(n^2) where n and k are the sizes of array and number of buckets respectively
//Space complexity: O(n+k)
class BucketSort
{
    public void SortArray(ref float[] arr)
    {
        int n = arr.Length;
        List<float>[] buckets = new List<float>[n];
        for(int i = 0; i < n; i++)
        {
            buckets[i] = new List<float>();
        }
        for (int i = 0; i < n; i++)
        {
            buckets[(int)(n * arr[i])].Add(arr[i]);
        }
        for (int i = 0; i < n; i++)
        {
            buckets[i].Sort();
        }
        int index = 0;
        foreach(List<float> bucket in buckets)
        {
            foreach(float num in bucket)
            {
                arr[index] = num;
                index++;
            }
        }
    }
    //public static void Main(string[] args)
    //{
    //    float[] arr = { 0.42f, 0.32f, 0.23f, 0.52f, 0.25f, 0.47f, 0.51f };
    //    BucketSort obj = new BucketSort();
    //    obj.SortArray(ref arr);
    //    Console.WriteLine("The array after sorting is: ");
    //    foreach (float i in arr)
    //    {
    //        Console.Write(i + " ");
    //    }
    //}
}