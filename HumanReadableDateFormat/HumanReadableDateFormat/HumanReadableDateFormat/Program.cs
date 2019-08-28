using System.Collections.Generic;
using System.Linq;
public class HumanTimeFormat
{
    public static string formatDuration(int seconds)
    {
        if (seconds == 0)
            return "now";
        List<string> units = new List<string> { "second", "minute", "hour", "day", "year" };
        List<int> divide = new List<int> { 60, 60, 24, 365, int.MaxValue};
        List<int> values = new List<int> { 0, 0, 0, 0, 0};
        units.
        for (int i = 0; i < 5; i++)
        {
            values[i] = (seconds % divide[i]);
            seconds /= divide[i];
            if (seconds == 0)
                break;
        }
        List<string> results = new List<string>();
        for (int i = 4; i >= 0; i--)
        {
            if (values[i] == 0)
                continue;
            results.Add($"{values[i]} {units[i]}{(values[i] == 1 ? "" : "s")}");
        }
        string result = "";
        for (int i = 0; i < results.Count; i++)
        {
            result += results[i];
            if (i == results.Count - 2) //but-last has and
                result += " and ";
            else if(i == results.Count - 1) //last has nothing
                { }
            else                        //rest has ,
                result += ", ";
        }
        return result;
    }
}