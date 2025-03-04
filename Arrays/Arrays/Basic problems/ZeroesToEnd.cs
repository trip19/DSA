
class ZeroesToEnd
{
    //Time complexity: O(2*n)
    //Space complexity: O(1)
    //public void PushZeroes(ref int[] arr)
    //{
    //    int count = -1;
    //    foreach(int i in arr)
    //    {
    //        if (i != 0)
    //        {
    //            count++;
    //            arr[count] = i;
    //        }
    //    }
    //    for(int i = count + 1; i < arr.Length; i++)
    //    {
    //        arr[i] = 0;
    //    }
    //}

    //Time complexity: O(n)
    //Space complexity: O(1)
    public void PushZeroes(ref int[] arr)
    {
        int count = -1;
        int temp;
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                count++;
                temp = arr[i];
                arr[i] = arr[count];
                arr[count] = temp;
            }
        }
    }
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 1, 2, 0, 4, 3, 0, 5, 0 };
    //    ZeroesToEnd obj = new ZeroesToEnd();
    //    obj.PushZeroes(ref arr);
    //    Console.WriteLine("The array after pushing zeroes to the end is: ");
    //    foreach(int i in arr)
    //    {
    //        Console.Write(i + " ");
    //    }
    //}
}