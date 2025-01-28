
using System.Text;

class RemoveDuplicates
{
    //Time complexity: O(n)
    //Space complexity: O(n)
    public string GetUniqueString(string str)
    {
        StringBuilder val = new StringBuilder();
        int i = 0;

        while (i < str.Length)
        {
            val.Append(str[i]);

            // Find the next non-duplicate character
            int j = i + 1;
            while (j < str.Length && str[j] == str[i])
            {
                j++;
            }

            i = j; // Move `i` to the next non-duplicate character
        }

        return val.ToString();
    }
    //public static void Main(string[] args)
    //{
    //    string str = "aaaaabbbbc";
    //    RemoveDuplicates obj = new RemoveDuplicates();
    //    Console.WriteLine($"The unique string after removing the consecutive duplicates is: {obj.GetUniqueString(str)}");
    //}
}
