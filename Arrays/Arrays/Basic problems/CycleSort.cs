//Only used when values in the array are in range 1->N
class CycleSort
{
    public void SortArray(ref int[] arr)
    {
        int i = 0;
        int correctPos, temp;
        while (i < arr.Length)
        {
            correctPos = arr[i] - 1;
            if(i != correctPos)
            {
                temp = arr[i];
                arr[i] = arr[correctPos];
                arr[correctPos] = temp;
            }
            else
            {
                i++;
            }
        }
    }
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 3, 2, 4, 5, 1 };
    //    CycleSort obj = new CycleSort();
    //    obj.SortArray(ref arr);
    //    Console.WriteLine("The array after sorting is: ");
    //    foreach (int i in arr)
    //    {
    //        Console.Write(i + " ");
    //    }
    //}
}