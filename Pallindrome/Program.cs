using System;
namespace Pattern
{
    class Program
    {
        static void Main(String[] args)
        {
            int i, j, k;
            for (i = 1; i <= 4; i++)
            {
                k = 0;
                for (j = 1; j <= 4; j++)
                {
                    if (j <= i)

                        Console.Write(i + k);

                    else
                        Console.Write(" ");


                }

                Console.Write("\n");
            }
        }

    }
}