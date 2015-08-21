using System;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double d, f;
            double amt;
            Console.WriteLine("Enter your travelled distance");
            d = double.Parse(Console.ReadLine());
            f = Math.Round(d, 2) * 10;

            amt = 2.40 + (85 * 0.04 + (f - 90) * 0.05);
            Console.WriteLine("Total fare {0:#.00}", Math.Round(amt, 1));
        }
    }
}