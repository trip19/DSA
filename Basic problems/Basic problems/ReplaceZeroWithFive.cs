//Time complexity: O(log n)
//Space complexity: O(1)
class ReplaceZeroWithFive
{
    public int Replace(int n)
    {
        int result = 0;
        int num = n;
        int decimalPlace = 1;

        if (n == 0)
        {
            result += (5 * decimalPlace);
        }

        while (n > 0)
        {
            if (n % 10 == 0)
                result += (5 * decimalPlace);

            n /= 10;
            decimalPlace *= 10;
        }
        return num+result;
    }

    //public static void Main()
    //{
    //    int n = 10120;
    //    ReplaceZeroWithFive obj = new ReplaceZeroWithFive();
    //    Console.WriteLine("The number after replacing zero with five is: "+obj.Replace(n));
    //}
}