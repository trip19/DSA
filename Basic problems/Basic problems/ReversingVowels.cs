
using System.Text;

class ReversingVowels
{
    //Time complexity: O(k) where k is the length of string  
    //Space complexity: O(k)
    public string ReverseVowels(string str)
    {
        StringBuilder str1 = new StringBuilder();
        int j = 0;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
            {
                str1.Append(str[i]);
            }
        }
        char[] val = str.ToCharArray();
        for (int i = 0; i < val.Length; i++)
        {
            if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
            {
                val[i] = str1[j];
                j++;
            }
        }
        return string.Join("", val);
    }
    //public static void Main(string[] args)
    //{
    //    string str = "hello world";
    //    ReversingVowels obj = new ReversingVowels();
    //    Console.WriteLine($"The string without reversing the vowels: {str}");
    //    Console.WriteLine($"The string after reversing the vowels: {obj.ReverseVowels(str)}");
    //}
}
