using System;
namespace CSExercises
{
    public class Ex41
    {
        //bool s3;
        public static void Main(string[] arg)
        {
            Console.WriteLine("Enter the String");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the String");
            string str1 = Console.ReadLine();
           bool b= InString(str, str1);
           Console.WriteLine("String s1 contains s2 \t{0}",b);
        }
        public static bool InString(string s1, string s2)
        {
            //int i;
          // bool s3 =false;
            if (s1.Contains(s2))
            {
                //Console.WriteLine("contains");

                return (s1.Contains(s2));
            }
            else
            {
                //Console.WriteLine(" not contains");

                return false;
            }
            //i = s1.IndexOf(s2);

        }
    }
}
