//Time complexity: O(k) where k is the length of the string
//Space complexity: O(k)
class RemoveVowels
{
    public string RemovedVowels(string str)
    {
        string newStr = "";
        foreach(char i in str)
        {
            if (i != 'a' && i != 'e' && i != 'i' && i != 'o' && i != 'u' && i != 'A' && i != 'E' && i != 'I' && i != 'O' && i != 'U') 
            {
                newStr += i;
            }
        }
        return newStr;
    }
    //public static void Main()
    //{
    //    string str = "welcome to geeksforgeeks";
    //    RemoveVowels obj = new RemoveVowels();
    //    Console.WriteLine($"The string before removing vowels is {str}");
    //    Console.WriteLine($"The string after removing vowels is {obj.RemovedVowels(str)}");
    //}
}