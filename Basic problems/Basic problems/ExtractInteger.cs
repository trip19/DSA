//Time complexity: O(n)
//Space complexity: O(n)
class ExtractInteger
{
    public void PrintIntegers(string str)
    {
        string intTillNow = "";
        foreach (char i in str)
        {
            if (Char.IsDigit(i))
            {
                intTillNow += i;
            }
            else
            {
                if (intTillNow.Length > 0)
                {
                    Console.Write(intTillNow + " ");
                    intTillNow = "";
                }
            }
        }
        if (intTillNow.Length > 0)
        {
            Console.Write(intTillNow + " ");
        }
    }

    //public static void Main(string[] args)
    //{
    //    string str = "Hey34 eve5yone, I have 500 rupee3s and 6432 I wou@ld spend a 100";
    //    ExtractInteger obj = new ExtractInteger();
    //    obj.PrintIntegers(str);
    //}
}