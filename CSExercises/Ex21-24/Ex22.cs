using System;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int lcm, hcf, a, b, n1,n2,t;
           System.Console.WriteLine("Enter A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter B");
            b = int.Parse(Console.ReadLine());
           // Console.WriteLine("Calculating LCM and HCF");
            n1 = a;
            n2 = b;
            while(n2!=0)
            {
                t = n2;
                n2 = n1%n2;
                n1 = t;

            }
            hcf = n1;
           lcm = (a*b)/hcf;
          Console.WriteLine("LCM\t{0}\nHCF\t{1}",lcm,hcf);
        }
    }
}
