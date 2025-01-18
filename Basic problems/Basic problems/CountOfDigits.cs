
class CountOfDigits
{
    //Time complexity: O(n) 
    //Space complexity: O(1)
    //public int GetDigitsCount(int n)
    //{
    //    int count = 0;
    //    while (n != 0)
    //    {
    //        n = n / 10;
    //        count++;
    //    }
    //    return count;
    //}

    //Time complexity: O(1) 
    //Space complexity: O(1)
    public int GetDigitsCount(int n)
    {
        return (int)Math.Floor(Math.Log10(n) + 1);
    }
    //public static void Main(string[] args)
    //{
    //    int n = 1567;
    //    CountOfDigits obj = new CountOfDigits();
    //    Console.WriteLine("The count so the digit "+n+" is "+obj.GetDigitsCount(n));
    //}
}