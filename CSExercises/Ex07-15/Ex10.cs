using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            int x1, x2, y1, y2, c1, c2, d;
            float t;
            double x, y;
            Console.WriteLine("Enter value");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value");
            y2 = int.Parse(Console.ReadLine());

            c1 = x2 - x1;
            c2 = y2 - y1;
            d = c1 * c1 + c2 * c2;
            Console.Write("value of D {0:0.00}");
            Console.WriteLine(Math.Sqrt(d));

        }
    }
}
