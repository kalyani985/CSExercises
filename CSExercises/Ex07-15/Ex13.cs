using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
           
             double t,x1;

            Console.WriteLine("Enter Distance value");

            x1 = Convert.ToDouble(Console.ReadLine());

            t = 2.40 + (x1 * 0.4);

            Console.WriteLine("Total fare {0}", Math.Ceiling(t*10)/10);


        }
    }
}
