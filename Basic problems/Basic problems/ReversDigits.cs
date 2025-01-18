
class ReverseDigits
{
    //Time complexity: O(logn) 
    //Space complexity: O(1)
    //public int ReversingDigits(int n)
    //{
    //    int revNum = 0;
    //    while (n > 0)
    //    {
    //        revNum = revNum * 10 + n % 10;
    //        n = n / 10;
    //    }
    //    return revNum;
    //}

    //Time complexity: O(d) where d is the number of digits 
    //Space complexity: O(1)
    public int ReversingDigits(int n)
    {
        char[] num = n.ToString().ToCharArray();
        char temp = ' ';
        float mid = (num.Length - 1) / 2;
        for (int i = 0; i <= Math.Floor(mid); i++)
        {
            temp = num[i];
            num[i] = num[num.Length - i - 1];
            num[num.Length - i - 1] = temp;
        }
        return int.Parse(string.Join("", num));
    }
    //public static void Main(string[] args)
    //{
    //    int n = 4562;
    //    ReverseDigits obj = new ReverseDigits();
    //    Console.WriteLine($"The reverse of {n} is {obj.ReversingDigits(n)}");
    //}
}
