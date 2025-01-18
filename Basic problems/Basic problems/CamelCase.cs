//Time complexity: O(k) where k is the length of the string
//Space complexity: O(1)
class CamelCase
{
    public int CountCamelCase(string str)
    {
        int count = 0;
        foreach(char i in str)
        {
            if (Char.IsUpper(i))
            {
                count++;
            }
        }
        return count;
    }
    //public static void Main(string[] args)
    //{
    //    string str = "ckjkUUYII";
    //    CamelCase obj = new CamelCase();
    //    Console.WriteLine($"The camelcase count is {obj.CountCamelCase(str)}");
    //}
}
