using System;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int x = 11;

            int secretNumber = r.Next(1, 11);
            int guess;

            do
            {
                Console.Write("Please enter your guess (1-10): ");
                guess = Convert.ToInt32(Console.ReadLine());

                if ((guess * guess) == x)
                {
                    Console.WriteLine("You guess is correct.");
                }
                else
                {
                    guess = (guess + (x / guess)) / 2;
                    Console.WriteLine("It's wrong. Please try again.");
                }
            } while (guess != x);
            
            Console.Write("");

        }
    }
}
