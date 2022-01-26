namespace RomanNumerals;
public class RomanNumerals
{
    static Dictionary<int, string > arabicToRoman = new Dictionary<int, string>
    {
        {1000, "M"},
        {500, "D"},
        {100, "C"},
        {50, "L"},
        {10, "X"},
        {5, "V"},
        {1, "I"}
    };

    public static string makeRoman(int arabic)
    {
        string Roman = string.Empty;

        foreach (int value in arabicToRoman.Keys)
        {
            while (arabic >= value)
            {
                Roman += arabicToRoman[value];
                arabic -= value;
            }
        }
        return Roman;
    }
}
