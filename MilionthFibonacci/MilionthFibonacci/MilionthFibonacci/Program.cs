using System.Numerics;
public class Fibonacci
{
    public static BigInteger fib(int n)
    {
        BigInteger a = 0;
        BigInteger b = 1;
        if (n == 0)
            return new BigInteger(0);
        else if (n > 0)
        {
            for (int i = 0; i < n - 1; i++)
            {
                a += b;
                //swap numbers
                a = a + b;
                b = a - b;
                a = a - b;
            }
            return b;
        }
        else if (n < 0)
        {
            for (int i = 0; i < -n; i++)
            {
                b -= a;
                //swap numbers
                a = a + b;
                b = a - b;
                a = a - b;
            }
            return a;
        }
        else //duh
            return new BigInteger(0);
    }

    public static void Main(string[] args)
    {

    }
}