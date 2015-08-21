using System;
namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double a, b, c, s,s1;

            //int x, y;
            Console.WriteLine("Enter a value");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b value");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c value");
            c = double.Parse(Console.ReadLine());
           
            s = (a + b + c) / 2;
            Console.WriteLine("Calculate S value\t{0}", s);
            s1 = s * (s - a)*(s - b)*(s - c); //Method name expected
            Console.WriteLine("Area");
            Console.WriteLine(Math.Sqrt(s1));


        }
    }
}