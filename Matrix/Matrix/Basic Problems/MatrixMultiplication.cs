//Time complexity: O(m*p*n) where m is the no. of rows of the first matrix, p is the no. of columns of the second matrix and n is the no. of cols of first matrix/no.of rows fo the second matrix
//Space complexity: O(1)
class MatrixMultiplication
{
    public void MultiplyMatrix(int[,] matA, int[,] matB)
    {
        int rowA = matA.GetLength(0);
        int colB = matB.GetLength(1);
        int n = matA.GetLength(1);
        int k;
        int[,] result = new int[rowA, colB];
        for(int i = 0 ; i < rowA ; i++)
        {
            for (int j = 0; j < colB; j++)
            {
                k = 0;
                while (k < n)
                {
                    result[i, j] += matA[i, k] * matB[k, j];
                    k++;
                }
            }
        }
        Console.WriteLine("The product of matrix multiplication is: ");
        for (int i = 0; i < rowA; i++)
        {
            for (int j = 0; j < colB; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine("");
        }
    }
    //public static void Main(string[] args)
    //{
    //    int[,] matA = { { 1, 2, 3 }, { 4, 5, 6 } };
    //    int[,] matB = { { 7, 8 }, { 9, 10 }, { 11, 12 } };
    //    MatrixMultiplication obj = new MatrixMultiplication();
    //    obj.MultiplyMatrix(matA, matB);
    //}
}