using System;
//Time complexity: O(k) where k is the number of digits in n
//Space complexity: O(1)
class BinaryNumber
{
    public bool CheckBinaryNumber(long n)
    {
        while (n != 0)
        {
            if (n % 10 > 1)
            {
                return false;
            }
            n = n / 10;
        }
        return true;
    }
    //public static void Main(string[] args)
    //{
    //    long num = 10101102311010L;
    //    BinaryNumber obj = new BinaryNumber();
    //    bool val = obj.CheckBinaryNumber(num);
    //    if (val)
    //    {
    //        Console.WriteLine("The number is a binary number");
    //    }
    //    else
    //    {
    //        Console.WriteLine("The number is not a binary number");
    //    }
    //}
}
