class LowestSecOccur
{
    //Time complexity: O(n)
    //Space complexity: O(k)  where k is the number of unique characters
    //public char GetLowOccur(string str)
    //{
    //    Dictionary<char, int> val = new Dictionary<char, int>();
    //    int lowSec = Int32.MaxValue;
    //    char ch=' ';
    //    for (int i =0;i<str.Length;i++)
    //    {
    //        if (val.ContainsKey(str[i]))
    //        {
    //            if (val[str[i]] == 1 && i<lowSec)
    //            {
    //                lowSec = i;
    //                ch = str[i];
    //            }
    //            val[str[i]]++;
    //        }
    //        else
    //        {
    //            val.Add(str[i],1);
    //        }
    //    }
    //    return ch;
    //}

    //Time complexity: O(n)
    //Space complexity: O(1)  
    public char GetLowOccur(string str)
    {
        int[] val = new int[26];
        foreach (char ch in str)
        {
            int index = ch - 'a';
            if (val[index] != 0)
            {
                return ch;
            }
            val[index]++;
        }
        return ' ';
    }
    //public static void Main(string[] args)
    //{
    //    string str = "hello geeks";
    //    LowestSecOccur obj = new LowestSecOccur();
    //    Console.WriteLine($"The character having the lowest second occurrence in {str} is {obj.GetLowOccur(str)}");
    //}
}