using System;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Squareroot of 1 to 25 ");
            for (int i = 1; i <= 25; i++)
            {
                
                Console.WriteLine("{0:0.00}\t",SQT(i));
            }
        }

        public static double SQT(int i)
        {
            double x=0;
            
            
                x = Math.Sqrt(i);
            
                return x;
        }
    }
}
