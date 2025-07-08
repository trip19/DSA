class Anagrams
{
    //Time complexity: O(n+m) where n and m are length of two strings
    //Space complexity: O(1)
    //public bool CheckAnagrams(string s1, string s2)
    //{
    //    Dictionary<char, int> map = new Dictionary<char, int>();
    //    foreach (char i in s1)
    //    {
    //        map[i] = map.GetValueOrDefault(i, 0) + 1;
    //    }

    //    foreach (char i in s2)
    //    {
    //        map[i] = map.GetValueOrDefault(i, 0) - 1; 
    //    }

    //    foreach (var count in map)
    //    {
    //        if (count.Value != 0)
    //        {
    //            return false;
    //        }
    //    }
    //    return true;
    //}

    public bool CheckKAnagrams(string s1, string s2, int k)
    { 
        if (s1.Length != s2.Length)
        {
            return false;
        }
        int diff = 0;
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach (char i in s1)
        {
            map[i] = map.GetValueOrDefault(i, 0) + 1;
        }

        foreach (char i in s2)
        {
            map[i] = map.GetValueOrDefault(i, 0) - 1;
        }

        foreach (var count in map)
        {
            diff += Math.Abs(count.Value);
        }
        return diff <= 2 * k;
    }
    //public static void Main(string[] args)
    //{
    //    string s1 = "anagram", s2 = "grammar";
    //    int k = 3;
    //    Anagrams obj = new Anagrams();
    //    if (obj.CheckAnagrams(s1, s2))
    //    {
    //        Console.WriteLine("The two strings are anagrams");
    //    }
    //    else
    //    {
    //        Console.WriteLine("The two strings are not anagrams");
    //    }
    //    if (obj.CheckKAnagrams(s1, s2, k))
    //    {
    //        Console.WriteLine("The two strings are K anagrams");
    //    }
    //    else
    //    {
    //        Console.WriteLine("The two strings are not K anagrams");
    //    }
    //}
}