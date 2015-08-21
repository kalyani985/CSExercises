using System;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            double n,x,q;
            int N;
            

            
            int guess;

            do
            {
                Console.WriteLine("Enter the no");
                n = Convert.ToInt32(Console.ReadLine());
                q = Math.Sqrt(n);
                N = Convert.ToInt32(q);
                guess = r.Next(1, N);
                // Console.Write("Please enter your guess (1-10): ");
                // guess = Convert.ToInt32(Console.ReadLine());

                if ((guess * guess) == N)
                {
                    Console.WriteLine("You guess is correct.");
                    break;
                }
                else
                {
                    guess = (guess + (N / guess)) / 2;
                    Console.WriteLine("It's wrong. Please try again.");
                }

            } while (guess != N);
           // Console.Write("");
            Console.ReadLine();

        }
    }
}
