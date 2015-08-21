using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            int sa;
            //float t; 
            double x, y;
            Console.WriteLine("Enter salary");
            sa = int.Parse(Console.ReadLine());
            Console.WriteLine("House allowance");
            x = sa * 0.1;
            Console.WriteLine(x);
            Console.WriteLine("Transport allowance");
            y = sa * 0.03;
            Console.WriteLine(y);
            double t = sa + x + y;
            Console.WriteLine("Toatal salary {0:.000} ", t);
            

        }
    }
}
