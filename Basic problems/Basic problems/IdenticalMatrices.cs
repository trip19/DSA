//Time complexity: O(n^2)
//Space complexity: O(1)
class IdenticalMatrices
{
    public bool IsIdentical(int[,] a, int[,] b)
    {
        int r = a.GetLength(0);
        int c = a.GetLength(1);
        for (int i=0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                if (a[i, j] != b[i, j])
                {
                    return false;
                }
            }
        }
        return true;
    }
    //public static void Main(string[] args)
    //{
    //    int[,] A = { {1, 1, 1, 1},
    //                {2, 2, 2, 2},
    //                {3, 2, 3, 3},
    //                {4, 4, 4, 4}};

    //    int[,] B = { {1, 1, 1, 1},
    //                {2, 2, 2, 2},
    //                {3, 3, 3, 3},
    //                {4, 4, 4, 4}};

    //    IdenticalMatrices obj = new IdenticalMatrices();
    //    if (obj.IsIdentical(A, B)) {
    //        Console.WriteLine("The two square matrices are identical");
    //    }
    //    else {
    //        Console.WriteLine("The two square matrices are not identical");
    //    }
    //}
}