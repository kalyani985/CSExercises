using System;
namespace CSExercises
{
    public class Ex42
    {
        public static void Main(string[] arg)
        {
            
            Console.WriteLine("Enter the String");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the String");
            string str1 = Console.ReadLine();
            int i = FindWord(str, str1);
            Console.WriteLine(i);
        }
        public static int FindWord(string s1, string s2)
        {
            
            int i=0;
            if((s1.IndexOf(s2)) != -1)
	            {
	    // Print out the substring.
	  //  Console.WriteLine(s.Substring(i));

	    // Increment the index.
                    i = s1.IndexOf(s2);
                    return i;

	            }
           
            else
            return -1;
            
           
        }
    }
}
