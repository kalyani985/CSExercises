using System;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            int n, s = 0;
            Console.WriteLine("Enter the no");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    s = s + i;

                }
            }
            if (s == n)
            {
                Console.WriteLine("Perfect Number");
            }
            else
                Console.WriteLine("Not Perfect Number");

        }
    }
}
