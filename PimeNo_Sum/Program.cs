using System;

namespace PrimeNo_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int Y = 7;
            int Z = 5;
            int X, i, j, isprime;
            int sum = 0;
            X = Z + Y * Z - Y;
            for (i = 2; i < X; i++)
            {
                isprime = 1;
                for (j = 2; j <= i / 2; j++)
                {

                    if (i % j == 0)
                    {
                        isprime = 0;
                        break;
                    }
                }
                if (isprime == 1)
                {
                    sum += i;

                }
            }
            Console.WriteLine(sum);
        }
    }
}
