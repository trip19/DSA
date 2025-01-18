//Time complexity: O(log10n^2) 
//Space complexity: O(1)
class ArmstrongNumber
{
    public bool DetermineIfArmstrong(int n)
    {
        int digits =(int)Math.Floor(Math.Log10(n) + 1);
        int sum = 0;
        int num = n;
        while (n != 0)
        {
            sum = (int)(sum + Math.Pow(n % 10, digits));
            n = n / 10;
        }
        if (sum == num)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //public static void Main(string[] args)
    //{
    //    int n = 153;
    //    ArmstrongNumber obj = new ArmstrongNumber();
    //    if (obj.DetermineIfArmstrong(n))
    //    {
    //        Console.WriteLine("The number is a Armstrong number");
    //    }
    //    else
    //    {
    //        Console.WriteLine("The number is not a Armstrong number");
    //    }
    //}
}
