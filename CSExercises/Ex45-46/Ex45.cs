using System;
namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            int N, c, r, i, j;
            double n;
            Console.WriteLine("Enter the amount");
            n = Convert.ToDouble(Console.ReadLine());
            N = Convert.ToInt32(n * 100);
            int[] d = new[] { 100, 50, 20, 10, 5 };

            for (i = 0; i < 5; i++)
            {
                c = N / d[i];
                r = N % d[i];

                if (c >= 1 && N > 0)
                {
                    for (j = 0; j < c; j++)
                    {
                        Console.WriteLine(d[i]);
                        N = r;
                    }
                }
                else
                {
                    i = ++i;
                    c = N / d[i];
                    r = N % d[i];
                    N = r;
                    if (c >= 1 && N > 0)
                    {
                        Console.WriteLine(d[i]);
                        break;
                    }
                }

            }
            if (N < 5)
            {
                Console.WriteLine("5");

            }

        }
    }
}
