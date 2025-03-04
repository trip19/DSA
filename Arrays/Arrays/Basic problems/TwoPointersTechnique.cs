
class TwoPointersTechnique
{
    public bool IsPairExists(int[] arr,int key)
    {
        Array.Sort(arr);
        int left = 0, right = arr.Length - 1;
        while (left < right)
        {
            if (arr[left] + arr[right] == key)
            {
                return true;
            }
            else if(arr[left] + arr[right] < key)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return false;
    }
    public static void Main(string[] args)
    {
        int[] arr = { 0, -1, 2, -3, 1 };
        int key = -2;
        TwoPointersTechnique obj = new TwoPointersTechnique();
        if (obj.IsPairExists(arr, key))
        {
            Console.WriteLine("The pair exists whose sum is equal to " + key);
        }
        else
        {
            Console.WriteLine("The pair doesn't exist whose sum is equal to " + key);
        }
    }
}