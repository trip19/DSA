//Time complexity: O(n) 
//Space complexity: O(1)
class AlternateElementsOfArray
{
    public void PrintAlternateElements(int[] arr)
    {
        for(int i = 0; i < arr.Length; i = i + 2)
        {
            Console.Write($"{arr[i]} ");
        }
    }
    //public static void Main(string[] args)
    //{
    //    int[] arr = { 10, 20, 30, 40, 50, 60 };
    //    AlternateElementsOfArray obj = new AlternateElementsOfArray();
    //    obj.PrintAlternateElements(arr);
    //}
}
