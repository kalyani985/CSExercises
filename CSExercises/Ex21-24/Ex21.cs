using System;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the no");
            n = int.Parse(Console.ReadLine());


            //for (i = 0; i == 88;i++ )

               
                do
                {
                    if (n != 88)
                    {
                        Console.WriteLine("Enter the no");
                        Console.WriteLine(n);
                    }

                } while (n<88);
                if (n == 88)
                {
                    Console.WriteLine("Lucky You");
                }
               // Console.WriteLine(n);
                //Console.WriteLine("Enter the no");
            //} while (n != 88);

        }
    }
}
