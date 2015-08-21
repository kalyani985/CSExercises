using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            int d;
            Console.WriteLine("Enter the no");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Square Root on Integer {0}", Math.Sqrt(d));
        }
    }
}
