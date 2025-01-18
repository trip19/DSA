
class UniqueChars
{
    //Time complexity: O(n)
    //Space complexity: O(n)
    //public int CountUniqueChars(string str)
    //{
    //    HashSet<char> val = new HashSet<char>();
    //    foreach (char i in str)
    //    {
    //       val.Add(i);
    //    }
    //    return val.Count;
    //}

    //Time complexity: O(n)
    //Space complexity: O(1)
    public int CountUniqueChars(string str)
    {
        str.ToLower();
        int count = 0;
        int[] arr = new int[26];
        for(int i = 0; i < str.Length; i++)
        {
            arr[str[i] - 'a'] += 1; 
        }
        foreach(int i in arr)
        {
            if(i != 0)
            {
                count++;
            }
        }
        return count;
    }
    //public static void Main(string[] args)
    //{
    //    string str = "geeksforgeeks";
    //    UniqueChars obj = new UniqueChars();
    //    Console.WriteLine($"The number of unique characters in {str} is {obj.CountUniqueChars(str)}");
    //}
}