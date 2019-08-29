using System;
using System.Linq;
public class StripCommentsSolution
{
    public static string StripComments(string text, string[] commentSymbols)
    {
        return text.Split("\n")
                    .Select(s => { foreach (string com in commentSymbols) s = s.Split(com)[0]; return s.TrimEnd(); })
                    .Aggregate((a, b) => a + Environment.NewLine + b);
    }
}