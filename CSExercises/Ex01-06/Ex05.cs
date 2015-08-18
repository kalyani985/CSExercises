using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            
            int tv, dvd, mp,finalfare,minusf;
            
            Console.WriteLine("Enter Tv Quantity");
            tv=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter DVD Quantity");
            dvd = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter MP3 Quantity");
            mp = int.Parse(Console.ReadLine());

            minusf = tv * 900 + dvd * 500;
           Console.WriteLine(minusf);
            if(minusf>5000 && minusf<=10000)
            {
               // t = minusf / 10;
                finalfare = (int) (minusf-(minusf*0.1)) + (mp * 700);
               Console.WriteLine("Total fare");
              Console.WriteLine(finalfare);
            }

            else if (minusf > 10000)
            {
                // t = minusf *0.15;
                finalfare = (int)(minusf - (minusf * 0.15)) + (mp * 700);
                Console.WriteLine("Total fare", +finalfare);
            }
            else
            {
                finalfare = minusf + (mp * 700);
                Console.Write("Total fare {0}", finalfare);
                Console.ReadLine();
            }
            }
        }
    }

