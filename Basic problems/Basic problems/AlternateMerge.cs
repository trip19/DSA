//Time complexity: O(Max(A,B)) 
//Space complexity: O(A+B)
using System.Text;
class AlternateMerge
{
    public string MergeAlternatively(string strA, string strB)
    {
        StringBuilder str = new StringBuilder();
        int lengthA = strA.Length;
        int lengthB = strB.Length;
        if (lengthA > lengthB)
        {
            for(int i = 0; i < lengthB; i++)
            {
                str.Append(strA[i]);
                str.Append(strB[i]);
            }
            str.Append(strA.Substring(lengthB));
        }
        else if (lengthA < lengthB)
        {
            for (int i = 0; i < lengthA; i++)
            {
                str.Append(strA[i]);
                str.Append(strB[i]);
            }
            str.Append(strB.Substring(lengthA));
        }
        else
        {
            for (int i = 0; i < lengthA; i++)
            {
                str.Append(strA[i]);
                str.Append(strB[i]);
            }
        }
        return str.ToString();
    }
    //public static void Main(string[] args)
    //{
    //    string strA = "hello";
    //    string strB = "geeks";
    //    AlternateMerge obj = new AlternateMerge();
    //    Console.WriteLine($"The string after merging is {obj.MergeAlternatively(strA, strB)}");
    //}
}