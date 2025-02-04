//Time complexity: O(n+m) where n and m is size of both arrays
//Space complexity: O(n)
class UnionOfArrays
{
    public int[] GetUnionOfArrays(int[] a, int[] b)
    {
        HashSet<int> val = new HashSet<int>();
        foreach (int i in a)
        {
            val.Add(i);
        }
        foreach (int i in b)
        {
            val.Add(i);
        }
        return val.ToArray();
    }
    //public static void Main(string[] args)
    //{
    //    int[] a = { 3, 5, 10, 10, 10, 15, 15, 20 };
    //    int[] b = { 5, 10, 10, 15, 30 };
    //    UnionOfArrays obj = new UnionOfArrays();
    //    int[] arr = obj.GetUnionOfArrays(a, b);
    //    Console.WriteLine("The array after union of unsorted arrays is:");
    //    foreach(int i in arr)
    //    {
    //        Console.Write(i+" ");
    //    }
    //}
}