using System;
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            int i;
            Console.WriteLine("The values 1 to 10");
            Console.WriteLine("No\tINVERSE\tSQUREROOT SQUARE\n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0:0.0}\t{1:0.0}\t{2:0.0}\t{3:0.0}\n", i, (1 / i), Math.Sqrt(i), (i * i));
            }

        }
    }
}
