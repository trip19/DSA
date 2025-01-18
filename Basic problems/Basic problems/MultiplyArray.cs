//Time complexity: O(n) 
//Space complexity: O(1)
class MultiplyArray
{
    public int MultiplyArrayElements(int[] arr)
    {
        int product = 1;
        for(int i = 0; i < arr.Length; i++)
        { 
            product = product * arr[i];
        }
        return product;
    }
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 1, 3, 5, 7, 9 };
    //    MultiplyArray obj = new MultiplyArray();
    //    Console.WriteLine("The product of all elements of the array are: "+obj.MultiplyArrayElements(arr));
    //}
}
