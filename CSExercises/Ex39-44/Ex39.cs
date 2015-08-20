using System;
namespace CSExercises
{
    public class Ex39
    {
        public static void Main(string[] args)
        {
            
            int n;
            Console.WriteLine("FACTORIAL");
            Console.Write("Enter number : ");
             n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("factorial of {0} is {1}", n, Factorial(n));
            Console.ReadLine();

        }
        public static int Factorial(int n)
        {
            int f = 1;
            for (int i = 2; i <= n; i++)
            {
                f = f * i;
            }
            return f;
            
        }
    }
}
