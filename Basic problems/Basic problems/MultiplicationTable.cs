//Time complexity: O(1)  
//Space complexity: O(1)
class MultiplicationTable
{
    public void PrintMultiplicationTable(int num)
    {
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
    //public static void Main(string[] args)
    //{
    //    int n = 13;
    //    MultiplicationTable obj = new MultiplicationTable();
    //    obj.PrintMultiplicationTable(n);
    //}
}
