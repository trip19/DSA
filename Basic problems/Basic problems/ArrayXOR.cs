//Time complexity: O(n)
//Space complexity: O(1)
class ArrayXOR
{
    public void XORedArray(ref int[] arr)
    {
        for(int i = 0; i < arr.Length-1; i++)
        {
            arr[i] = arr[i] ^ arr[i + 1]; 
        } 
    }
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 5, 9, 7, 6 };
    //    ArrayXOR obj = new ArrayXOR();
    //    obj.XORedArray(ref arr);
    //    foreach (int i in arr)
    //    {
    //        Console.WriteLine(i + " ");
    //    }
    //}
}