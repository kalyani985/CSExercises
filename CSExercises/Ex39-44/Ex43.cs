using System;
namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(Hex(i));
            }


        }
        public static string Hex(int i)
        {
            char[] hexChar = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            int number = i;
            string answer = "";


            answer = hexChar[number % 16] + answer;
            if (!hexChar[number / 16].Equals('0'))
                answer = hexChar[number / 16] + answer;

            return answer;
        }
    }
}

