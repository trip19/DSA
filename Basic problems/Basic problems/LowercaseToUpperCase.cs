
class LowercaseToUpperCase
{
    //Time complexity: O(k) where k is the size of the string input 
    //Space complexity: O(1)
    //public void ConvertToUpper(ref string str)
    //{
    //    str = str.ToUpper();
    //}
    //public static void Main(string[] args)
    //{
    //    string str1 = "GeeksForGeeks";
    //    LowercaseToUpperCase obj = new LowercaseToUpperCase();
    //    obj.ConvertToUpper(ref str1);
    //    Console.WriteLine("The string with uppercase letters is: " + str1);
    //}

    //Time complexity: O(k) where k is the size of the string input 
    //Space complexity: O(k)
    public string ConvertToUpper(char[] str)
    {
        for(int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 'a' && str[i] <= 'z')
            {
                str[i] = (char) (str[i] - 'a' + 'A');
            }
        }
        return string.Join("", str);
    }
    //public static void Main(string[] args)
    //{
    //    string str1 = "GeeksForGeeks";
    //    LowercaseToUpperCase obj = new LowercaseToUpperCase();
    //    Console.WriteLine("The string with uppercase letters is: " + obj.ConvertToUpper(str1.ToCharArray()));
    //}
}
