
class MaximumOccuring
{
    //Time complexity: O(n)
    //Space complexity: O(n)
    //public char GetMaxOccuringChar(string str)
    //{
    //    Dictionary<char, int> hashMap = new Dictionary<char, int>();
    //    int maxValue = -1;
    //    char chr = ' ';
    //    foreach(char ch in str)
    //    {
    //        if (hashMap.ContainsKey(ch))
    //        {
    //            hashMap[ch] += 1;
    //        }
    //        else
    //        {
    //            hashMap.Add(ch,1);
    //        }
    //    }
    //    foreach(KeyValuePair<char, int> i in hashMap)
    //    {
    //        if(i.Value > maxValue)
    //        {
    //            maxValue = i.Value;
    //            chr = i.Key;
    //        }
    //    }
    //    return chr;
    //}

    //Time complexity: O(n)
    //Space complexity: O(1)
    public char GetMaxOccuringChar(string str)
    {
        int[] arr = new int[26];
        int maxValue = -1;
        char chr = ' ';
        foreach (char ch in str)
        {
            arr[ch - 'a']++;
        }
        for(int i = 0; i < arr.Length ; i++)
        {
            Console.WriteLine($"{(char)(i + 'a')}: {arr[i]}");
            if (arr[i] > maxValue)
            {
                maxValue = arr[i];
                chr = (char)(i + 'a'); 
            }
        }
        return chr;
    }
    //public static void Main(string[] args)
    //{
    //    string str = "geeksforgeeks";
    //    MaximumOccuring obj = new MaximumOccuring();
    //    Console.WriteLine($"The maximum occurring character in {str} is {obj.GetMaxOccuringChar(str)}");
    //}
}
