using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
           
            
            // using ToTitle
            /* string str;
            Console.WriteLine("Enter the String");
            str = Console.ReadLine();
            //Get the culture property of the thread.
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            //Create TextInfo object.
            //TextInfo textInfo = cultureInfo.TextInfo;
            //Convert to title case.
          Console.WriteLine(textInfo.ToTitleCase(str));
          string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
          Console.WriteLine(titleCase);*/

// CharArray
           /*Console.WriteLine("\n\n\t\tTitle Case");
            Console.Write("\n\tEnter sring :");
            string s1 = Console.ReadLine();
            Console.Write("\n\tResult:\t");
           // string s = s1.ToUpper();
            char[] c = s1.ToCharArray();
            char[] d = new char[50];
            for (int i = 0; i < c.Length; i++)
            {
                if(i==0)
                {
                    string temp = c[i].ToString();
                    string temp1 = temp.ToUpper();
                    
                    Console.Write(temp1);


                }
                else if (c[i] == ' ')
                {
                    string temp=c[i+1].ToString();
                    string temp1 = temp.ToUpper();
                    Console.Write(" "+temp1);
                    i = i + 1;
                  // d[i+1] = temp1.ToCharArray();
                }
                else
                {
                    Console.Write(c[i]);
                }
              
            }
            Console.ReadLine();*/
            Console.Write("\n\tEnter sring :");
            string str = Console.ReadLine();
            
            string converted = str.Substring(0, 1).Trim().ToUpper();

            //now loop through the rest of the string converting where needed
            for (int i = 1; i < str.Length; i++)
            {
                converted =
                (Char.IsUpper(str[i])) ?
                converted += " " :
                converted += str[i];
            }
            Console.WriteLine(converted);
        }
    }
}

  
 