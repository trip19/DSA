
class SumOfDiagonals
{
    //Time complexity: O(n^2)
    //Space complexity: O(1)
    //public void CalculateDiagonalSum(int[,] arr)
    //{
    //    int principalDiagonal = 0, secondaryDiagonal = 0;
    //    for(int i = 0; i < arr.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < arr.GetLength(1); j++)
    //        {
    //            if (i == j)
    //            {
    //                principalDiagonal += arr[i, j];
    //            }
    //            if((i+j)== arr.GetLength(1) - 1)
    //            {
    //                secondaryDiagonal += arr[i, j];
    //            }
    //        }
    //    }
    //    Console.WriteLine($"Principal diagonal: {principalDiagonal}, Secondary diagonal: {secondaryDiagonal}");
    //}

    //Time complexity: O(n)
    //Space complexity: O(1)
    public void CalculateDiagonalSum(int[,] arr)
    {
        int principalDiagonal = 0, secondaryDiagonal = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            principalDiagonal += arr[i, i];
            secondaryDiagonal += arr[i, arr.GetLength(0) - 1 - i];
        }
        Console.WriteLine($"Principal diagonal: {principalDiagonal}, Secondary diagonal: {secondaryDiagonal}");
    }

    //public static void Main(string[] args)
    //{
    //    int[,] a = { { 1, 2, 3, 4 },
    //                 { 5, 6, 7, 8 },
    //                 { 1, 2, 3, 4 },
    //                 { 5, 6, 7, 8 } };
    //    SumOfDiagonals obj = new SumOfDiagonals();
    //    obj.CalculateDiagonalSum(a);
    //}
}