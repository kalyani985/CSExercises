using System;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            
            //Console.Write("Enter a Number : ");
            //num = Convert.ToInt32(Console.ReadLine());

           // int k;
            Console.WriteLine("Prime Numbers");
             for (int n = 5; n <= 1000; n++)
            {
                int k = 0;

                for (int i = 2; i < n; i++)
                {

                    if (n % i == 0)
                    {
                        k = k + 1;
                    }
                }
                if (k == 0)
                {
                    Console.WriteLine("\t{0} ", n);
                }
               
            }
            Console.ReadLine();
            }
        }
    }

