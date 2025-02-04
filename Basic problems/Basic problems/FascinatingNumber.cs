//Time complexity: O(logn)
//Space complexity: O(1)
class FascinatingNumber
{
    public bool IsFascinating(int n)
    {
        int[] arr = new int[9];
        int num1 = n, num2 = n * 2, num3 = n * 3;
        int rem;

        // Process num1 (original number)
        while (num1 > 0)
        {
            rem = num1 % 10;
            if (rem != 0) // Ignore zeroes
            {
                if (arr[rem - 1] > 0) return false; // Duplicate found
                arr[rem - 1]++;
            }
            num1 /= 10;
        }

        // Process num2 (2 * n)
        while (num2 > 0)
        {
            rem = num2 % 10;
            if (rem != 0)
            {
                if (arr[rem - 1] > 0) return false;
                arr[rem - 1]++;
            }
            num2 /= 10;
        }

        // Process num3 (3 * n)
        while (num3 > 0)
        {
            rem = num3 % 10;
            if (rem != 0)
            {
                if (arr[rem - 1] > 0) return false;
                arr[rem - 1]++;
            }
            num3 /= 10;
        }

        // Ensure all digits 1-9 appear exactly once
        foreach (int i in arr)
        {
            if (i == 0) return false; // If any digit is missing, return false
        }

        return true;
    }
    //public static void Main(string[] args)
    //{
    //    int n = 853;
    //    FascinatingNumber obj = new FascinatingNumber();
    //    if (obj.IsFascinating(n))
    //    {
    //        Console.WriteLine("The number is a fascinating number");
    //    }
    //    else
    //    {
    //        Console.WriteLine("The number is not a fascinating number");
    //    }
    //}
}