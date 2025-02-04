//Time complexity: O(n+m) where n and m is size of both arrays
//Space complexity: O(n)
class IntersectionOfArrays
{
    public int[] CommonElements(int[] a, int[] b)
    {
        HashSet<int> val = new HashSet<int>();
        List<int> arr = new List<int>();
        foreach (int i in a)
        {
            val.Add(i);
        }
        foreach(int i in b)
        {
            if (val.Contains(i))
            {
                arr.Add(i);
                val.Remove(i);
            }
        }
        return arr.ToArray();
    }
    //public static void Main(string[] args)
    //{
    //    int[] a = { 1, 1, 2, 2, 2, 4 };
    //    int[] b = { 2, 2, 4, 4 };
    //    IntersectionOfArrays obj = new IntersectionOfArrays();
    //    int[] arr = obj.CommonElements(a, b);
    //    Console.WriteLine("The intersection of the two arrays is: ");
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        Console.Write(arr[i] + " ");
    //    }
    //}
}