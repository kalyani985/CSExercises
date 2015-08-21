using System;
namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            //float a, b, c, s;

            int x, xCopy, y,s1;
            
            Console.WriteLine("Enter value");
            xCopy = x = int.Parse(Console.ReadLine());
            
            s1 = 0;
            do
            {
                 
                y = x % 10;
                s1 = s1 + (y * y * y);
                x = x / 10;

            } while (x !=0) ;
            
            if(s1==xCopy)
            
                Console.WriteLine("Armstrong number");
            
            else
                Console.WriteLine("Not Armstrong number");
           
            //Console.WriteLine(s1);      
        }
    }
}