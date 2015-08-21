using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            int c;
            float t;
            double x, y;
            Console.WriteLine("Enter celcious");
            c = int.Parse(Console.ReadLine());
            t = (float)1.8 * c + 32;
            Console.WriteLine("Fahrenheit {0}",t);

        }
    }
}
