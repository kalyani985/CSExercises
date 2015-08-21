using System;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            string str;
            char gen;


            //int x, y,s1=0;
            Console.WriteLine("Enter the name");
            str = (string)Console.ReadLine();
            Console.WriteLine("Gender");
            gen = (char)Console.Read();
            if (gen == 'M')
            {
                Console.WriteLine("Good Morning Mr." + str);
            }
            else
            {
                Console.WriteLine("Good Morning Ms. " + str);
            }           

        }
    }
}