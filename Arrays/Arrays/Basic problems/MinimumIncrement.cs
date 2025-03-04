//Time complexity: O(n)
//Space complexity: O(1)
class MinimumIncrement
{
    public int GetMinIncrement(int[] arr, int k)
    {
        int max = Int32.MinValue;
        int operations = 0;
        int diff;
        float val;
        foreach(int i in arr)
        {
            if (i > max)
            {
                max = i;
            }
        }
        foreach(int i in arr)
        {
            if (i != max)
            {
                diff = max - i;
                if ((diff%k)==0)
                {
                    operations += (diff/k);
                }
                else
                {
                    return -1;
                }
            }
        }
        return operations;
    }
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 4, 3, 19, 16 };
    //    int k = 3;
    //    MinimumIncrement obj = new MinimumIncrement();
    //    Console.WriteLine("The minimum operations to make all elements of the array equal is: " + obj.GetMinIncrement(arr, k));
    //}
}