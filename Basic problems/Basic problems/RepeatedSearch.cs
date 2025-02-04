//Time complexity: O(n)
//Space complexity: O(1)
class RepeatedSearch
{
    public char GetRepeatedChar(string str)
    {
        int[] charCount = new int[26];
        foreach (char ch in str)
        {
            int index = ch - 'a';

            if (charCount[index] != 0)
            {
                return ch;
            }
            charCount[index]++;
        }
        return ' ';
    }
    //public static void Main(string[] args)
    //{
    //    string str = "geeksforgeeks";
    //    RepeatedSearch obj = new RepeatedSearch();
    //    Console.WriteLine("The repeated character is: " + obj.GetRepeatedChar(str));
    //}
}