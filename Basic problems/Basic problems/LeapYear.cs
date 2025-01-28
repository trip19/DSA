//Time complexity: O(1) 
//Space complexity: O(1)
class LeapYear
{
    public void IsLeapYear(int num)
    {
        if(num % 400 == 0 ||( num % 4 == 0 && num % 100 != 0))
        {
            Console.WriteLine("The year is a leap year");
        }
        else
        {
            Console.WriteLine("The year is not a leap year");
        }
    }
    //public static void Main(string[] args)
    //{
    //    int n = 2021;
    //    LeapYear obj = new LeapYear();
    //    obj.IsLeapYear(n);
    //}
}