//Time complexity: O(k*n) where k is the nukber of digits of the max element and n is the length of input array
//Space complexity: O(n)
class RadixSort
{
    public void SortArray(ref int[] arr)
    {
        int max = MaxElement(arr);
        for(int exp = 1; max / exp > 0; exp *= 10)
        {
            CountSort(ref arr, exp);
        }
    }

    public void CountSort(ref int[] arr, int exp)
    {
        int len = arr.Length;
        int[] countArr = new int[10];
        int[] outputArr = new int[len];
        for (int i = 0; i < arr.Length; i++)
        {
            countArr[(arr[i]/exp)%10]++;
        }
        for (int i = 1; i < 10; i++)
        {
            countArr[i] = countArr[i-1] + countArr[i];
        }
        for (int i = len - 1; i >= 0; i--)
        {
            outputArr[countArr[(arr[i] / exp) % 10] - 1] = arr[i];
            countArr[(arr[i] / exp) % 10]--;
        }
        for (int i = 0; i < len; i++)
            arr[i] = outputArr[i];
    }

    public int MaxElement(int[] arr)
    {
        int max = Int32.MinValue;
        foreach (int i in arr)
        {
            if (i > max)
            {
                max = i;
            }
        }
        return max;
    }
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
    //    RadixSort obj = new RadixSort();
    //    obj.SortArray(ref arr);
    //    Console.WriteLine("The array after sorting is: ");
    //    foreach (int i in arr)
    //    {
    //        Console.Write(i + " ");
    //    }
    //}
}