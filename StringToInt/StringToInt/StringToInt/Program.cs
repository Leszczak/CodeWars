using System.Text.RegularExpressions;
public class Parser
{
    public static int ParseInt(string input)
    {
        int result = 0;
        int temp = 0;
        foreach (string s in input.Replace("-", " ").Split(' '))
        {
            //million, thousand, hundred
            if(new Regex("^million.*").IsMatch(s))
            {
                result += temp * 1000000;
                temp = 0;
                continue;
            }
            if(new Regex("^thousand.*").IsMatch(s))
            {
                result += temp * 1000;
                temp = 0;
                continue;
            }
            if(new Regex("^hundred.*").IsMatch(s))
            {
                temp *= 100;
                continue;
            }
            //12-0 (TWE EL TE N EI SE SI FI FO TH TWO O Z)
            int smallTemp = 0;
            if (new Regex("^twelve").IsMatch(s))
                smallTemp += 12;
            else if (new Regex("^el.*").IsMatch(s))
                smallTemp += 11;
            else if (new Regex("^te.*").IsMatch(s))
                smallTemp += 10;
            else if (new Regex("^n.*").IsMatch(s))
                smallTemp += 9;
            else if (new Regex("^ei.*").IsMatch(s))
                smallTemp += 8;
            else if (new Regex("^se.*").IsMatch(s))
                smallTemp += 7;
            else if (new Regex("^si.*").IsMatch(s))
                smallTemp += 6;
            else if (new Regex("^fi.*").IsMatch(s))
                smallTemp += 5;
            else if (new Regex("^fo.*").IsMatch(s))
                smallTemp += 4;
            else if (new Regex("^th.*").IsMatch(s))
                smallTemp += 3;
            else if (new Regex("^tw.*").IsMatch(s))
                smallTemp += 2;
            else if (new Regex("^o").IsMatch(s))
                smallTemp += 1;
            else if (new Regex("^z.*").IsMatch(s))
                smallTemp = 0;
            //-ty and -teen
            if (new Regex(".*ty$").IsMatch(s))
                smallTemp *= 10;
            else if (new Regex(".*teen$").IsMatch(s))
                smallTemp += 10;
            temp += smallTemp;
        }
        result += temp;
        return result;
    }

    public static void Main(string[] args)
    {

    }
}