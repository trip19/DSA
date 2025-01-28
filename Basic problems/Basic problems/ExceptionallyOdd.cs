
class ExceptionallyOdd
{
    //Time complexity: O(n)
    //Space complexity: O(k) where k is the number of unique integers
    public int GetOddInteger(int[] arr)
    {
        Dictionary<int, int> val = new Dictionary<int, int>();
        foreach (int i in arr)
        {
            if (val.ContainsKey(i))
            {
                val[i]++;
            }
            else
            {
                val.Add(i, 1);
            }
        }
        foreach (KeyValuePair<int, int> i in val)
        {
            if (i.Value % 2 != 0)
            {
                return i.Key;
            }
        }
        return -1;
    }

    //public static void Main(string[] args)
    //{
    //    int[] arr = { 1, 2, 3, 2, 3, 1, 3 };
    //    ExceptionallyOdd obj = new ExceptionallyOdd();
    //    Console.WriteLine("The integer occurring odd number of times is " + obj.GetOddInteger(arr));
    //}
}
