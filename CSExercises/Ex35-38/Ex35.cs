using System;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string :");
            string s1 = Console.ReadLine();
            string s = s1.ToUpper();
            char[] c = s.ToCharArray();
            int count = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 'A' || c[i] == 'E' || c[i] == 'I' || c[i] == 'O' || c[i] == 'U')
                {
                    count = count + 1;
                    int count2 = 0;
                    for (int j = 0; j < c.Length; j++)
                    {
                        if (c[i] == c[j])
                        {
                            count2 = count2 + 1;
                        }
                    }
                    Console.WriteLine("Occurence of {0} is {1}", c[i], count2);
                }
                //Console.WriteLine(c[i]);
            }

            Console.WriteLine("Total number of vowels : {0}", count);

            Console.ReadLine();

}
                                                                                                                                                            
        
            
        }
    }

