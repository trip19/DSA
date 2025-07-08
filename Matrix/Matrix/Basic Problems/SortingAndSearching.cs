
class SortingAndSearching
{
    public void SortRowWise(int[,] mat)
    {
        //Time complexity: O(m*n)
        //Space complexity: O(1)
        int key;
        int k;
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            for(int j=1; j < mat.GetLength(1); j++)
            {
                key = mat[i, j];
                k = j - 1;
                while (k >= 0 && mat[i, k] > key)
                {
                    mat[i, k+1] = mat[i, k];
                    k = k - 1;
                }
                mat[i, k+1] = key;
            }
        }

        Console.WriteLine("The matrix after sorting row wise is: ");
        PrintMat(mat);
    }
    public void SortColumnWise(int[,] mat)
    {
        //Time complexity: O(m*n)
        //Space complexity: O(1)
        int key;
        int k;
        for(int j = 0; j < mat.GetLength(1); j++)
        {
            for (int i = 1; i < mat.GetLength(0); i++)
            {
                key = mat[i, j];
                k = i - 1;
                while (k >= 0 && mat[k,j] > key)
                {
                    mat[k + 1, j] = mat[k, j];
                    k = k - 1;
                }
                mat[k + 1, j] = key;  
            }
        }

        Console.WriteLine("The matrix after sorting column wise is: ");
        PrintMat(mat);
    }

    public int[,] CompleteSort(int[,] mat)
    {
        //Time complexity: O((m*n)^2)
        //Space complexity: O(1)
        int rows = mat.GetLength(0);
        int cols = mat.GetLength(1);
        int size = rows * cols;
        bool swapped;
        int temp;
        for(int i = 0; i < size - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < size - i - 1; j++)
            {
                if (mat[j/cols,j%cols] > mat[(j+1) / cols, (j+1) % cols])
                {
                    temp = mat[j / cols, j % cols];
                    mat[j / cols, j % cols] = mat[(j + 1) / cols, (j + 1) % cols];
                    mat[(j + 1) / cols, (j + 1) % cols] = temp;
                    swapped = true;
                }
            }
            if(swapped == false)
            {
                break;
            }
        }

        return mat;
    }

    public void PrintMat(int[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write(mat[i, j]+" ");
            }
            Console.WriteLine("");
        }
    } 

    public bool SearchCompleteSort(int[,] sortedMat, int target)
    {
        //Time complexity: O(log(m*n))
        //Space complexity: O(1)
        int rows = sortedMat.GetLength(0);
        int cols = sortedMat.GetLength(1);
        int size = rows * cols;
        int low = 0, high = size - 1, mid;
        while (low <= high)
        {
            mid = low + (high - low) / 2;
            if (sortedMat[mid / cols,mid%cols] == target)
            {
                return true;
            }
            else if(sortedMat[mid / cols, mid % cols] > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return false;
    }
    //public static void Main(string[] args)
    //{
    //    int[,] mat = new int[4,4]{{31, 5, 9, 11},
    //                              {14, 7, 21, 26},
    //                              {30, 4, 43, 50},
    //                              {2, 63, 87, 1 }};
    //    int target = 43;
    //    SortingAndSearching obj = new SortingAndSearching();
        
    //    obj.SortRowWise(mat);
        
    //    obj.SortColumnWise(mat);

    //    Console.WriteLine("The matrix after sorting completely is: ");
    //    int[,] sortedMat = obj.CompleteSort(mat);
    //    obj.PrintMat(sortedMat);

    //    if(obj.SearchCompleteSort(sortedMat, target))
    //    {
    //        Console.WriteLine("The target was found: ");
    //    }
    //    else
    //    {
    //        Console.WriteLine("The target was not found: ");
    //    }
    //}
}
