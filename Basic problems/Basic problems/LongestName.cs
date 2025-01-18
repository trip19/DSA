
class LongestName
{
    //Time complexity: O(n)
    //Space complexity: O(1)
    //public void PrintLongestName(string[] names)
    //{
    //    int max = Int32.MinValue;
    //    foreach (string i in names)
    //    {
    //        if(i.Length >= max)
    //        {
    //            max = i.Length;
    //        }
    //    }
    //    foreach (string i in names)
    //    {
    //        if (i.Length == max)
    //        {
    //            Console.WriteLine(i);
    //        }
    //    }
    //}

    //Time complexity: O(n)
    //Space complexity: O(k) where k is the number of strings with max length
    public List<string> PrintLongestName(string[] names)
    {
        int max = Int32.MinValue;
        List<string> temp = new List<string>();
        foreach (string i in names)
        {
            if (i.Length > max)
            {
                max = i.Length;
                temp.Clear();
                temp.Add(i);
            }
            else if(i.Length == max)
            {
                temp.Add(i);  
            }
        }
        return temp;
    }
    //public static void Main(string[] args)
    //{
    //    string[] names = { "GeeksforGeeks", "FreeCodeCamp", "StackOverFlow", "MyCodeSchool" };
    //    LongestName obj = new LongestName();
    //    foreach(string i in obj.PrintLongestName(names))
    //    {
    //        Console.WriteLine(i);
    //    }
    //}
}
