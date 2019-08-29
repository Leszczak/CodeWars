using System;
using System.Linq;
public class Kata
{
    public static long NextBiggerNumber(long n)
    {
        string str = n.ToString();
        Console.WriteLine(str);
        if (n == long.Parse(string.Join("", str.OrderByDescending(c => c))))
            return -1;

        for(int i=2;i<=str.Length;i++)
        {
            Console.WriteLine($"{str[str.Length - i]} vs {str[str.Length - 1]}");
            if(str[str.Length-i]<str[str.Length-1])
            {
                string temp = string.Join("", str.Substring(str.Length - i, i - 1)
                                    .OrderBy(c => c));
                return long.Parse(str.Substring(0, str.Length - i) + str[str.Length - 1] + temp);
            }
        }

        return long.Parse(str.Substring(0, str.Length - 2) + str[str.Length - 1] + str[str.Length - 2]);
    }
}