//Time complexity: O(n+m)
//Space complexity: O(n+m)
class Z_algorithm
{
    public static int[] Z_array(string strCon, int len)
    {
        int[] zArr = new int[len];
        int l = 0, r = 0;
        for(int i = 1; i < len; i++)
        {
            if (i < r)
            {
                zArr[i] = zArr[i - l];
                if(i + zArr[i] > r)
                {
                    zArr[i] = r - i;
                }
            }
            while (i + zArr[i]<len && strCon[zArr[i]] == strCon[i + zArr[i]])
            {
                zArr[i]++;
            }  
            if(i + zArr[i] > r)
            {
                l = i;
                r = i + zArr[i];
            }
        }
        return zArr;
    }
    public void Search(string text, string pat)
    {
        int n = pat.Length;
        bool patFound = false;
        string strCon = pat + "#" + text;
        int len = strCon.Length;
        int[] zArr = Z_array(strCon, len);
        for (int i = 0; i < len; i++)
        {
            if (zArr[i] == n)
            {
                patFound = true;
                Console.WriteLine($"Pattern found at index {i-n-1}");
            }
        }
        if (patFound == false)
        {
            Console.WriteLine($"Pattern not found ");
        }
    }
    //public static void Main(string[] args)
    //{
    //    string text = "aabaacaadaabaaba";
    //    string pattern = "aaba";
    //    Z_algorithm obj = new Z_algorithm();
    //    obj.Search(text, pattern);
    //}
}