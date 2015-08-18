using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{       
    public class Ex04
    {
        public static void Main(string[] args)
        {
            double d,f;
            double amt;
            Console.WriteLine("Enter your travelled distance");
            d = double.Parse(Console.ReadLine());
            f = Math.Round(d,2) * 10;

            amt=2.40+(85*0.04+(f-90)*0.05); 
            Console.WriteLine("Total fare {0:#.00}", Math.Round(amt,1));
        }
    }
}
