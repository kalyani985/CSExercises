using System;
namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            //Question 46 (part 1)
            int[] randArray = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
           // int length = randArray.Length;
            int[] a=new int []{};
            int length = a.Length;
            Random r = new Random();
            for (int i = 0; i < 50; i++)
            {
                //randArray[RandomGenerator(r, 0, 10)] += 1;
                a[i]= r.Next(0, 10);
            }

            Console.WriteLine("Number Count");

            for (int j = 0; j < length; j++)
                Console.WriteLine("{0,3}{1,7}", j, a[j]);

            Console.WriteLine();
            //Question 46 (part 2)
            Console.WriteLine("Number");
            for (int j = 0; j < length; j++)
            {
                Console.Write("{0,3} ", j);
                for (int k = 0; k < a[j]; k++)
                    Console.Write("*");

                Console.WriteLine();

            }

        }

        public static int RandomGenerator(Random r, int lower, int upper)
        {
            return r.Next(lower, upper);
        }
    }
}

