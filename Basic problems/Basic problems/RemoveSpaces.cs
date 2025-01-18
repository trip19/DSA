
using System.Text;

class RemoveSpaces
{
    //Time complexity: O(k) where k is the number of characters in the string 
    //Space complexity: O(k)
    public string RemoveSpacing(string str)
    {
        StringBuilder str1 = new StringBuilder();
        foreach (char i in str)
        {
            if (i != ' ')
            {
                str1.Append(i);
            }
        }
        return str1.ToString();
    }

    //public static void Main(string[] args)
    //{
    //    string str = "gee k s fo r ge e ks";
    //    RemoveSpaces obj = new RemoveSpaces();
    //    Console.WriteLine($"The string after removal of spaces is {obj.RemoveSpacing(str)}");
    //}
}