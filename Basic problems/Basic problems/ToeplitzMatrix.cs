//Time complexity: O(n)
//Space complexity: O(1)
class ToeplitzMatrix
{
    public bool IsToeplitz(int[,] arr)
    {
        int val = arr[0, 0];
        for(int i = 1; i < arr.GetLength(0); i++)
        {
            if (arr[i,i] != val)
            {
                return false;
            }
            val = arr[i, i];
        }
        return true;
    }
    //public static void Main(string[] args)
    //{
    //    int[,] arr = {{ 6, 3, 8},
    //                { 4, 9, 7},
    //                { 1, 4, 6}};
    //    ToeplitzMatrix obj = new ToeplitzMatrix();
    //    if (obj.IsToeplitz(arr))
    //    {
    //        Console.WriteLine("The matrix is a Toeplitz matrix");
    //    }
    //    else
    //    {
    //        Console.WriteLine("The matrix is not a Toeplitz matrix");
    //    }
    //}
}