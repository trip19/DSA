//Time complexity: O(n^2)
//Space complexity: O(1)
class NaiveStringMatching
{
    public void GetAllOccurences(string text, string pattern)
    {
        int n = text.Length;
        int m = pattern.Length;
        int j;
        for (int i = 0; i <= n - m; i++)
        {
            for (j = 0; j < m; j++)
            {
                if (text[i + j] != pattern[j])
                {
                    break;
                }
            }
            if (j == m)
            {
                Console.WriteLine($"The pattern is found at index {i}");
            }
        }
    }
    //public static void Main(string[] args)
    //{
    //    string text = "AABAACAADAABAABA";
    //    string pat = "AABA";
    //    NaiveStringMatching obj = new NaiveStringMatching();
    //    obj.GetAllOccurences(text, pat);
    //}
}