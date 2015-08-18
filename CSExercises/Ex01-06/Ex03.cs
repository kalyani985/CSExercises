using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            int mark;
            Console.WriteLine("Enter Your Marks");
            mark = int.Parse(Console.ReadLine());
            if(mark>0 && mark <=100)
            {
                
               if (mark == 0 && mark <= 40)
            
                Console.WriteLine("your score {0} which is F Grade", mark);         
           
                if(mark>=40 && mark<=59)
            
                Console.WriteLine("your score {0} which is C Grade", mark);  
            
            if (mark >= 60 && mark <= 79)
            
                Console.WriteLine("your score {0} which is B Grade", mark);
            
             if (mark >= 80 || mark == 100)
            
                Console.WriteLine("your score {0} which is A Grade", mark);
            

            }
            else
            {
                Console.WriteLine("Error");
            }
                                
        }               

    }
}
