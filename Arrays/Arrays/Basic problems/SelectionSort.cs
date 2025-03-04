//Time complexity: O(n^2)
//Space complexity: O(1)
class SelectionSort
{
    public void SortArray(ref int[] arr)
    {
        int min, minPos;
        int temp;
        for(int i = 0; i < arr.Length-1; i++)
        {
            min = Int32.MaxValue;
            minPos = 0;
            for(int j = i; j < arr.Length; j++)
            {
                if (arr[j] < min)
                {
                    min = arr[j];
                    minPos = j;
                }
            }
            temp = arr[i];
            arr[i] = arr[minPos];
            arr[minPos] = temp;
        }
    }
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 64, 25, 12, 22, 11 };
    //    SelectionSort obj = new SelectionSort();
    //    obj.SortArray(ref arr);
    //    Console.WriteLine("The array after sorting is: ");
    //    foreach(int i in arr)
    //    {
    //        Console.Write(i + " ");
    //    }
    //}
}