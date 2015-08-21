using System;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            string str;
            char gen;


            int x;
            Console.WriteLine("Enter the name");
            str = (string)Console.ReadLine();
            Console.WriteLine("Enter age");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Gender");
            gen = (char)Console.Read();
            if (x >= 40)
            {
                if (gen == 'M')
                {

                    Console.WriteLine("Good Morning Uncle" + str);
                }
                else
                {
                    Console.WriteLine("Good Morning Aunty " + str);
                }
            }
            else if (gen == 'M')
            {
                Console.WriteLine("Good Morning Mr." + str);
            }
            else
            {
                Console.WriteLine("Good Morning Ms." + str);

            }
        }
    }
}