//Time complexity: O(n+m)
//Space complexity: O(n+m)
class KMP
{
    public static int[] Lps(string strCon, int len)
    {
        int[] lpsArr = new int[len];
        lpsArr[0] = 0;
        int prevIdx;
        for(int i = 1; i < len; i++)
        {
            prevIdx = lpsArr[i - 1];
            while(prevIdx>0 && strCon[i] != strCon[prevIdx])
            {
                prevIdx = lpsArr[prevIdx - 1];
            }
            lpsArr[i] = strCon[i] == strCon[prevIdx] ? prevIdx + 1 : 0;
        }
        return lpsArr;
    }
    public void Search(string text, string pat)
    {
        int n = pat.Length;
        bool patFound = false;
        string strCon = pat + "#" + text;
        int len = strCon.Length;
        int[] lpsArr = new int[len];
        lpsArr = Lps(strCon, len);
        for(int i = 0; i < len; i++)
        {
            if (lpsArr[i] == n)
            {
                patFound = true;
                Console.WriteLine($"Pattern found at index {i - (2 * n)}");
            }
        }
        if(patFound == false)
        {
            Console.WriteLine($"Pattern not found ");
        }
    }
    //public static void Main(string[] args)
    //{
    //    string text = "aabaacaadaabaaba";
    //    string pattern = "aaba";
    //    KMP obj = new KMP();
    //    obj.Search(text, pattern);
    //}
}