//Time complexity: O(logn)
//Space complexity: O(1)
class BinarySearch
{
    public int SearchKey(int[] arr, int key)
    {
        int low = 0;
        int high = (arr.Length) - 1;
        int mid;
        while (low<=high)
        {
            mid = low + (high - low) / 2;
            if (arr[mid] == key)
            {
                return mid;
            }
            else if (arr[mid] > key)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return -1;
    }
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 2, 3, 4, 10, 40 };
    //    int key = 4;
    //    BinarySearch obj = new BinarySearch();
    //    int index = obj.SearchKey(arr, key);
    //    if (index != -1)
    //    {
    //        Console.WriteLine("The key was found at index " + index);
    //    }
    //    else
    //    {
    //        Console.WriteLine("The key was not found");
    //    }
    //}
}