//Time complexity: O(log n) 
//Space complexity: O(log n)
class SparseNumber
{
    public bool IsSparse(int[] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 1)
            {
                if (i < arr.Length-1 && arr[i+1] == 1)
                {
                    return false;
                }
            }
        }
        return true;
    }
    public int[] ConvertToBin(int n)
    {
        if (n == 0) return new int[] { 0 }; 
        int numBits = (int)Math.Floor(Math.Log2(n)) + 1; 
        int[] arr = new int[numBits]; 

        for (int i = numBits - 1; i >= 0; i--)
        {
            arr[i] = n % 2; 
            n /= 2;        
        }

        return arr; 
    }
    //public static void Main(string[] args)
    //{
    //    int num = 12;
    //    SparseNumber obj = new SparseNumber();
    //    int[] arr = obj.ConvertToBin(num);
    //    if (obj.IsSparse(arr))
    //    {
    //        Console.WriteLine("The number is a sparse number");
    //    }
    //    else
    //    {
    //        Console.WriteLine("The number is not a sparse number");
    //    }
    //}
}