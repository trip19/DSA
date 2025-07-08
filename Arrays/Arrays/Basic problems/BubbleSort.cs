//Time complexity: O(n^2)
//Space complexity: O(1)
class BuubbleSort
{
    public void SortArray(ref int[] arr)
    {
        int i, j, temp;
        bool swapped;
        for (i = 0; i < arr.Length - 1; i++)
        {
            swapped = false;
            for (j = 0; j < arr.Length - i - 1; j++)
            { 
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            if (swapped == false)
                break;
        }
    }
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 64, 25, 12, 22, 11 };
    //    BuubbleSort obj = new BuubbleSort();
    //    obj.SortArray(ref arr);
    //    Console.WriteLine("The array after sorting is: ");
    //    foreach (int i in arr)
    //    {
    //        Console.Write(i + " ");
    //    }
    //}
}