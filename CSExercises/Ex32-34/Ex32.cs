using System;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int i, j, k, l, avg=0;
            int[] sales=new int[] {1000,200,400,598,756,875,092,876,865,357,456,675};
            
            for(i=0;i<sales.Length;i++)
            {
                Console.WriteLine("Enter the sales for month {0}: {1}", i, sales[i]);
            }
            for(j=0;j<sales.Length;j++)
            {
                for(k=j;k<sales.Length;k++)
                {
                    if(sales[k]< sales[j])
                    {
                        int t = sales[k];
                        sales[k] = sales[j];
                        sales[j] = t;
                    }
                    
                }
                //Console.WriteLine("Maximum Sales {0} Minimum Sales {1}", sales[0],sales[11]);
            }
            for(l=0;l<sales.Length;l++)
            {
                avg = avg + sales[l];

            }
           Console.WriteLine("Minimum sales{0}:", sales[0]);
           Console.WriteLine("Maximum sales{0}:", sales[11]);
            Console.WriteLine("Average sales:{0}", avg / 12);

                }
            }
        }
    
