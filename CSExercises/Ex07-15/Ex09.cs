using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            int c;
            float t;
            double x, y;
            Console.WriteLine("Enter value");
            c = int.Parse(Console.ReadLine());
            t = (float)2 * (c * c) - (4 * c) + 3;
            Console.WriteLine("value of Y = {0}", t);


        }
    }
}
