using System;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
           
            string[] names = { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] mark = { 63, 29, 75, 82, 55 };
            for (int i = 0; i < mark.Length - 1; i++)
            {
                for (int j = i + 1; j < mark.Length; j++)
                {
                    if (mark[i] > mark[j])
                    {
                        int temp = mark[i];
                        mark[i] = mark[j];
                        mark[j] = temp;
                        string temp1 = names[i];
                        names[i] = names[j];
                        names[j] = temp1;
                    }
                }

            }
            Console.WriteLine("\nSorting by mark\n");
            
            for (int i = mark.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("\t{0}\t\t{1}", names[i], mark[i]);
            }
            Console.WriteLine("\nSorting by name\n");
           // Console.WriteLine("\t-------------------\n");
            for (int i = 0; i < mark.Length - 1; i++)
            {
                for (int j = i + 1; j < mark.Length; j++)
                {
                    if (names[i].ToLower().CompareTo(names[j].ToLower()) == -1)
                    {
                        int temp = mark[i];
                        mark[i] = mark[j];
                        mark[j] = temp;
                        string temp1 = names[i];
                        names[i] = names[j];
                        names[j] = temp1;
                    }
                }

            }
            for (int i = mark.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("\t{0}\t\t{1}", names[i], mark[i]);
            }
            Console.ReadLine();


            
        }
    }
}
