//Time complexity: O(n+m+klogk) where n is length of s1, m is length of s2 and k is number of uncommon characters
//Space complexity: O(1)
class UncommonCharacters
{
    public string GetUncommonChar(string s1, string s2)
    {
        HashSet<char> set1 = new HashSet<char>(s1);
        HashSet<char> set2 = new HashSet<char>(s2);
        HashSet<char> result = new HashSet<char>();

        foreach(char i in set1)
        {
            if (!set2.Contains(i))
            {
                result.Add(i);
            }
        }
        foreach (char i in set2)
        {
            if (!set1.Contains(i))
            {
                result.Add(i);
            }
        }
        char[] sortedChars = new char[result.Count];
        result.CopyTo(sortedChars);
        Array.Sort(sortedChars);

        return new string(sortedChars);
    }
    //public static void Main(string[] args)
    //{
    //    string s1 = "characters", s2 = "alphabets";
    //    UncommonCharacters obj = new UncommonCharacters();
    //    Console.WriteLine($"The uncommon characters in {s1} and {s2} is {obj.GetUncommonChar(s1, s2)}");
    //}
}
