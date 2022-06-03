
using System.Text.RegularExpressions;

class HexdecCode
{

    static void Main(string[] args)
    {
        
        string[] str ={"#Ab9",
        "Ab9", "#Ab94", "#ab94", "#123456"}; ;
       //string[] str =  Int32.Parse(Console.ReadLine());

        foreach (string c in str)
        {
            Console.WriteLine(isValidHexcodeNumber(c));
        }

      }

   
    public static bool isValidHexcodeNumber(string inputHexdecNum)
    {
        string strRegex = "^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$";


        Regex match = new Regex(strRegex);

      
        if (match.IsMatch(inputHexdecNum))
            return (true);
        else
            return (false);
    }
}