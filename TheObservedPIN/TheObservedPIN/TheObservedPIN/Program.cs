using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static List<string> GetPINs(string observed)
    {
        Dictionary<int, int[]> dict = new Dictionary<int, int[]>
                                        {
                                        { 1, new[] { 1, 2, 4 } },
                                        { 2, new[] { 2, 1, 3, 5} },
                                        { 3, new[] { 3, 2, 6} },
                                        { 4, new[] { 4, 1, 5, 7} },
                                        { 5, new[] { 5, 2, 4, 6, 8} },
                                        { 6, new[] { 6, 3, 5, 9} },
                                        { 7, new[] { 7, 4, 8} },
                                        { 8, new[] { 8, 5, 7, 9, 0} },
                                        { 9, new[] { 9, 6, 8} },
                                        { 0, new[] { 0, 8 } },
                                        };
        List<string> results = new List<string>();
        foreach (int i in observed.Select(c => int.Parse(c.ToString())))
        {
            if (results.Count == 0)
                foreach (int j in dict[i])
                    results.Add(j.ToString());
            else
            {
                List<string> temp = new List<string>();
                foreach (int j in dict[i])
                    foreach (string s in results)
                        temp.Add(s + j);
                results = temp;
            }
        }
        return results;
    }
}