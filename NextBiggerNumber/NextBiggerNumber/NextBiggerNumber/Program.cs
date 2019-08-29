using System.Linq;
public class Kata
{
    public static long NextBiggerNumber(long n)
    {
        //find last digit that has bigger digit behind
        //place bigger digit in place of smaller
        //sort smaller digit and all digits behind it and before bigger letter
            //and place it behind bigger
        string str = n.ToString();
        for (int i = 1; i <= str.Length; i++)
        {
            for (int j = 1; j < i; j++)
            {
                if (str[str.Length-i]<str[str.Length-j])
                {
                    return long.Parse(str.Substring(0, str.Length - i)
                                        + str[str.Length - j]
                                        + string.Join("", str.Remove(str.Length - j, 1)
                                                                .Substring(str.Length - i, i - 1)
                                                                .OrderBy(c => c)));
                }
            }
        }
        return -1;
    }
}