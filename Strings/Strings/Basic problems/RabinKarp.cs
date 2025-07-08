//Example values for prime number:
//For small texts (~10⁴ characters): p = 101, 103, 131, 233
//For medium texts (~10⁶ characters): p = 10 ^ 9 + 7 or 10^9 + 9 (common prime choices)
//For large texts (~10⁹ characters): p = 2 ^ 61 - 1(Mersenne primes are very efficient)
//Time complexity: O(nm)
//Space complexity: O(1)
class RabinKarp
{
    public void GetOccurences(string text, string pattern)
    {
        const int b = 256;
        const int p = 101;
        int n = text.Length, m = pattern.Length;
        int hashP = 0, hashS = 0, h = 1;


        // Precompute h = b^(m-1) % p
        for (int i = 0; i < m - 1; i++)
            h = (h * b) % p;

        // Compute initial hash values
        for (int i = 0; i < m; i++)
        {
            hashP = (hashP * b + pattern[i]) % p;
            hashS = (hashS * b + text[i]) % p;
        }

        // Slide the pattern over text
        for (int i = 0; i <= n - m; i++)
        {
            if (hashS == hashP)
            { 
                bool match = true;
                for (int j = 0; j < m; j++)
                    if (text[i + j] != pattern[j])
                        match = false;

                if (match)
                    Console.WriteLine($"Pattern found at index {i}");
            }

            // Rolling hash update
            if (i < n - m)
            {
                hashS = (hashS - text[i] * h) * b + text[i + m];
                hashS = (hashS % p + p) % p; // Ensure positive hash
            }
        }
    }
    //public static void Main(string[] args)
    //{
    //    string text = "AABAACAADAABAABA";
    //    string pat = "AABA";
    //    RabinKarp obj = new RabinKarp();
    //    obj.GetOccurences(text, pat);
    //}
}