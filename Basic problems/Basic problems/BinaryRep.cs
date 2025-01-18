//Time complexity: O(log n) 
//Space complexity: O(log n)
class BinaryRep
{
    //public int[] ConvertToBin(int n)
    //{
    //    int i = 0;
    //    int count = 0;
    //    int[] arr = null;
    //    while(Math.Pow(2,i) <= n || n != 0 )
    //    {
    //        if(Math.Pow(2, i+1) > n)
    //        {
    //            if (count == 0)
    //            {
    //                arr = new int[i+1];
    //            }
    //            arr[arr.Length - i - 1] = 1;
    //            n = (int) (n - Math.Pow(2, i));
    //            i = 0;
    //            count++;
    //            continue;
    //        }
    //        i++;
    //    }
    //    return arr;
    //}

    //optimized solution
    //public int[] ConvertToBin(int n)
    //{
    //    if (n == 0) return new int[] { 0 }; // Special case for 0

    //    int numBits = (int)Math.Floor(Math.Log2(n)) + 1; // Number of bits required
    //    int[] arr = new int[numBits]; // Initialize array to hold binary digits

    //    for (int i = numBits - 1; i >= 0; i--)
    //    {
    //        arr[i] = n % 2; // Extract the last binary digit
    //        n /= 2;         // Shift the number to the right (divide by 2)
    //    }

    //    return arr; // Return the binary representation
    //}

    //public static void Main(string[] args)
    //{
    //    int num = 32;
    //    BinaryRep obj = new BinaryRep();
    //    Console.WriteLine("The binary representation of " + num + " is:");
    //    int[] arr = obj.ConvertToBin(num);
    //    for(int i = 0; i < arr.Length; i++)
    //    {
    //        Console.Write(arr[i] + " ");
    //    }
    //}
}
