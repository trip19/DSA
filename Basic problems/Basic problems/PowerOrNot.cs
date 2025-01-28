//Time complexity: O(1) 
//Space complexity: O(1)
class PowerOrNot
{
    public void IsPowerOf(int x, int y)
    {
        double logResult = Math.Log(y)/ Math.Log(x);
        if (logResult % 1 == 0 && logResult >= 0)
        {
            Console.WriteLine($"{y} is a power of {x}");
        }
        else
        {
            Console.WriteLine($"{y} is not a power of {x}");
        }
    }
    //public static void Main(string[] args)
    //{
    //    int x = 10, y = 1001;
    //    PowerOrNot obj = new PowerOrNot();
    //    obj.IsPowerOf(x, y);
    //}
}