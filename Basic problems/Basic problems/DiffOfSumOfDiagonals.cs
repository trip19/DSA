//Time complexity: O(n)
//Space complexity: O(1)
class DiffOfSumOfDiagonals
{
    public int CalculateDiff(int[,] arr, int n)
    {
        int principalDiagonal = 0, secondaryDiagonal = 0;
        for(int i = 0; i < n; i++)
        {
            principalDiagonal += arr[i, i];
            secondaryDiagonal += arr[i, n - 1 - i];
        }
        return Math.Abs(principalDiagonal - secondaryDiagonal);
    }
    //public static void Main(string[] args)
    //{
    //    int[,] arr ={{11, 2, 4},
    //                 {4 , 5, 6},
    //                 {10, 8, -12}};
    //    DiffOfSumOfDiagonals obj = new DiffOfSumOfDiagonals();
    //    Console.WriteLine($"The absolute difference between sum of diagonals is: {obj.CalculateDiff(arr,arr.GetLength(0))}");
    //}
}
