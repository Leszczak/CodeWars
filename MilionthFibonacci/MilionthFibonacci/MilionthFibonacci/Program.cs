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
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                a += b;
                b += a;
            }
            if ((n - 1) % 2 == 1)
                return a + b;
            else
                return b;
        }
        else if (n < 0)
        {
            for (int i = 0; i < (-n) / 2; i++)
            {
                b -= a;
                a -= b;
            }
            if ((-n) % 2 == 1)
                return b - a;
            else
                return a;
        }
        else //duh
            return new BigInteger(0);
    }

    public static void Main(string[] args)
    {

    }
}