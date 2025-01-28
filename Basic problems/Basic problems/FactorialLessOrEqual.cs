//Time complexity: O(n) 
//Space complexity: O(1)
class FactorialLessOrEqual
{
    public void FactLessOrEqual(int n)
    {
        int val = 1;
        int i = 1;
        while (true)
        {
            val = val * i;
            if(val <= n)
            {
                Console.Write(val + " ");
            }
            else
            {
                break;
            }
            i++;
        }
    }
    public static void Main(string[] args)
    {
        int n = 1000;
        FactorialLessOrEqual obj = new FactorialLessOrEqual();
        obj.FactLessOrEqual(n);
    }
}