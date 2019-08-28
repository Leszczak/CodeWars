using System.Numerics;
public class Fibonacci
{
    public static BigInteger fib(int n)
    {
        if (n == 0)
            return 0;
        BigInteger a = 0;
        BigInteger b = 1;
        if(n > 0)
        {
            for(int i=0; i<n-1;i++)
            {
                //a is next fib number
                a += b;
                //swap numbers
                a = a + b;
                b = a - b;
                a = a - b;
            }
        }
        return b;
    }

    public static void Main(string[] args)
    {

    }
}