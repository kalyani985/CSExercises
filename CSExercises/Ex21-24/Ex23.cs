using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
          //  int x = 11 ;
            int count = 0;

            int secretNumber = r.Next(1, 11);
            int guess;

            do
            {
                Console.Write("Please enter your guess (1-10): ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine("You guess is correct.");
                }
                else
                {
                    //guess = (guess + (x / guess)) / 2;
                    Console.WriteLine("It's wrong. Please try again.");
                    count=count+1;
                }
            } while (guess != secretNumber);
           // Console.ReadLine();
            if (count<=2)
            
                Console.WriteLine("You are a Wizard");
            
            else if (count<=6)
            
                Console.WriteLine("You are good guess");

            
            else
                Console.WriteLine("you are lousy");

            Console.ReadLine();
             

        }
    }
}
