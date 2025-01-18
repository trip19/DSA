//Time complexity: O(n) 
//Space complexity: O(1)
class PalindromicArray
{
    public bool CheckIfPalindrome(int[] arr)
    {
        float mid = (arr.Length - 1)/ 2;
        for (int i = 0; i <= Math.Floor(mid); i++)
        {
            if (arr[i] != arr[arr.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 2,5,6,1,9,4,9,3,6,5,2 };
    //    PalindromicArray obj = new PalindromicArray();
    //    if (obj.CheckIfPalindrome(arr))
    //    {
    //        Console.WriteLine("The given array is palidromic");
    //    }
    //    else
    //    {
    //        Console.WriteLine("The given array is not palidromic");
    //    }
    //}
}
