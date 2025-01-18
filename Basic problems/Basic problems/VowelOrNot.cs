//Time complexity: O(1) 
//Space complexity: O(1)
class VowelOrNot()
{
    public bool CheckVowelOrNot(char val)
    {
        if (val == 'a' || val == 'e' || val == 'i'||val == 'o' || val == 'u')
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //public static void Main(string[] args)
    //{
    //    char val = 'c';
    //    VowelOrNot obj = new VowelOrNot();
    //    if (obj.CheckVowelOrNot(val))
    //    {
    //        Console.WriteLine("Character is a vowel");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Character is not a vowel");
    //    }
    //}
}