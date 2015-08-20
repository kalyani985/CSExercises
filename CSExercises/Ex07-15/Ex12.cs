using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            int x1;

            double t;

            Console.WriteLine("Enter Distance value");

            x1 = int.Parse(Console.ReadLine());

            t = (float)2.40 + (x1 * 0.4);

            Console.WriteLine("Total fare {0}", Math.Round(t,1));          
        }
    }
}
