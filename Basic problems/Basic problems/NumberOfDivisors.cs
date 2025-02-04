//Time complexity: O(n log log n)
//Space complexity: O(n)
class NumberOfDivisors
{
    public int divCount(int n)
    {
        bool[] hash = new bool[n + 1];
        for (int p = 2; p * p < n; p++)
            if (hash[p] == false)
                for (int i = p * 2;
                         i < n; i += p)
                    hash[i] = true;

        int total = 1;
        for (int p = 2; p <= n; p++)
        {
            if (hash[p] == false)
            {
                int count = 0;
                if (n % p == 0)
                {
                    while (n % p == 0)
                    {
                        n = n / p;
                        count++;
                    }
                    total = total * (count + 1);
                }
            }
        }
        return total;
    }

    //public static void Main()
    //{
    //    int n = 24;
    //    NumberOfDivisors obj = new NumberOfDivisors();
    //    Console.WriteLine(obj.divCount(n));
    //}
}