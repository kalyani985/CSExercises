using System;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int  s = 0;

            int i, j;

            Console.WriteLine("Perfect numbers");

            // n = int.Parse(Console.ReadLine());

            for (i = 1; i <= 1000; i++)
            {
                s = 0;
                for (j = 1; j < i; j++)
                {

                   // s = 0;

                    if (i % j == 0)
                    {

                        s = s + j;

                    }

                }

                if (s == i)
                {

                    Console.WriteLine(i);

                }



                //Console.ReadLine();

                //else

                //  Console.WriteLine("Not Perfect Number");

            }

            Console.ReadLine();
        }
    }
}
