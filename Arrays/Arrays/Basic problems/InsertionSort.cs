 
class InsertionSort
{
    public void SortArray(ref int[] arr)
    {
        int key;
        int j;
        for(int i = 1; i < arr.Length; i++)
        {
            key = arr[i];
            j = i - 1;
            while(j>=0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 12, 11, 13, 5, 6 };
    //    InsertionSort obj = new InsertionSort();
    //    obj.SortArray(ref arr);
    //    Console.WriteLine("The array after sorting is: ");
    //    foreach (int i in arr)
    //    {
    //        Console.Write(i + " ");
    //    }
    //}
}