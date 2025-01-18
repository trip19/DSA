//Time complexity: O(n*m) where n and m is the number of rows and columns 
//Space complexity: O(1)
class SumOfMatrix
{
    public int CalculateSum(int[,] arr)
    {
        int sum = 0;
        Console.WriteLine("The matrix is :");
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i,j]+" ");
                sum = sum + arr[i, j];
            }
            Console.WriteLine("");
        }
        return sum;
    }
    //public static void Main(string[] args)
    //{
    //    int[,] arr = { { 4, 5, 3, 2 }, { 9, 5, 6, 2 }, { 1, 5, 3, 5 } };
    //    SumOfMatrix obj = new SumOfMatrix();
    //    Console.WriteLine($"The sum of all elements of the matrix is: {obj.CalculateSum(arr)}");
    //}
}