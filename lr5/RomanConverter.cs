namespace lr5;

public class RomanConverter
{
    private static readonly Dictionary<int, string> RomanNumbers = new Dictionary<int, string>
    {
        { 1, "I"},
        { 2, "II"},
        { 3 , "III"},
        { 4 , "IV"},
        { 5 , "V"},
        { 6 , "VI"},
        { 7 , "VII"},
        { 8 , "VIII"},
        { 9 , "IX"}
    };

    public static string GetRomanNumber(int number)
    {
        return RomanNumbers[number];
    }

}