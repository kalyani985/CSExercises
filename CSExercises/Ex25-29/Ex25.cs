using System;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            int i, f = 1, n,fs;
            Console.WriteLine("Enter th no");
            n = int.Parse(Console.ReadLine());
            fs = n;
            for (i = 2; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("Increment Counter Factorial {0}", +f);
            //Console.ReadLine();
            for (i = n - 1; i >= 1; i--)
            {
                fs = fs * i;
            }
            Console.WriteLine("\nDecrement Counter Factorial {0}", +fs);
            Console.ReadLine();

   
        }
    }
}
