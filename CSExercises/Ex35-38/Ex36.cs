using System;
namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            int i;
            int flag = 0;
            string str;
            // string str1;
            char[] w = new char[] { };
            string word = "";

            char[] c = new char[] { '$', '@', '$', '*', '.', ' ' };
            Console.WriteLine("Enter the String");
            str = Console.ReadLine().ToLower();
            //str1=str.ToCharArray();
            foreach (char value in str)
            {
                if ((value >= 'a' && value <= 'z') || (value >= '0' && value <= '9'))
                {
                    word = word + value;
                }

            }
            Console.WriteLine(word);
            w = word.ToCharArray();

            for (i = 0; i < w.Length / 2 + 1; i++)
            {
                if (w[i] != w[w.Length - i - 1])
                {
                    flag = 1;
                    break;

                }

                //Console.WriteLine(" Not Palindrome");
            }
            if (flag == 1)
            {
                Console.WriteLine("string is not a Palindrome");
            }
            else
                Console.WriteLine("string is a Palindrome");

        }



    }
}

