
class TransposeMatrix
{
    public void TransposeOfSqrMat(int[,] sqrMat)
    {
        int temp;
        for(int i = 0; i < sqrMat.GetLength(0) - 1; i++)
        {
            for (int j = i+1; j < sqrMat.GetLength(1) ; j++)
            {
                temp = sqrMat[i,j];
                sqrMat[i, j] = sqrMat[j, i];
                sqrMat[j, i] = temp; 
            }
        }

        Console.WriteLine("The transpose of the square matrix is:");
        PrintMat(sqrMat);
    }

    public void TransposeOfMat(int[,] Mat)
    {
        int m = Mat.GetLength(0);
        int n = Mat.GetLength(1);
        int[,] resMat = new int[n, m];
        for(int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                resMat[j, i] = Mat[i, j];
            }
        }
        Console.WriteLine("The transpose of the matrix is:");
        PrintMat(resMat);
    }

    public void PrintMat(int[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write(mat[i, j] + " ");
            }
            Console.WriteLine("");
        }
    }
    //public static void Main(string[] args)
    //{
    //    int[,] sqrMat = {
    //        { 1, 1, 1, 1 },
    //        { 2, 2, 2, 2 },
    //        { 3, 3, 3, 3 },
    //        { 4, 4, 4, 4 }
    //    };
    //    int[,] mat = {{ 1, 2, 3 },
    //                 { 4, 5, 6 }};
    //    TransposeMatrix obj = new TransposeMatrix();
    //    obj.TransposeOfSqrMat(sqrMat);
    //    obj.TransposeOfMat(mat);
    //}
}