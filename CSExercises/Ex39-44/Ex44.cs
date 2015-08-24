using System;
namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\t\tFind and replace char in string");
            Console.Write("Enter string1 : ");
            string s1 = Console.ReadLine();
            Console.Write("Enter char1 : ");
            char c1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter char2 : ");
            char c2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("result is {0}", Substitute(s1, c1, c2));
            Console.ReadLine();
        }
        public static string Substitute(string s, char c1, char c2)
        {
            // return s.Replace(s, c1, c2);
            // char[] ch = new char[s.Length];
            int length = s.Length;
            string newS = "";

            for (int i = 0; i < length; i++)
            {
                if (s.Substring(i, 1) == Convert.ToString(c1))
                {
                    newS += c2;
                }
                else
                {
                    newS += s.Substring(i, 1);
                }

            }
            return newS;
        }
    }
}
