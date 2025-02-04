//Time complexity: O(n)
//Space complexity: O(1)
class PerfectArray
{
    public bool isPerfectArray(int[] arr)
    {
        bool isIncreasing, isConstant = false, isDecreasing = false;
        for(int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i + 1] > arr[i])
            {
                if(isConstant==true || isDecreasing == true)
                {
                    return false;
                }
                isIncreasing = true;
            }
            else if (arr[i + 1] == arr[i])
            {
                if (isDecreasing == true)
                {
                    return false;
                }
                isConstant = true;
            }
            else
            {
                isDecreasing = true;
            }
        }
        return true;
    }
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 4, 4, 4, 4 };
    //    PerfectArray obj = new PerfectArray();
    //    if (obj.isPerfectArray(arr))
    //    {
    //        Console.WriteLine("The array is a perfect array");
    //    }
    //    else
    //    {
    //        Console.WriteLine("The array is not a perfect array");
    //    }
    //}
}
