using System;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int i, l, k, t;
            int[] sort = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            Console.WriteLine("Descending order");
            for(i=0;i<sort.Length-1;i++)
            {
                for(k=0;k<sort.Length;k++)
                {
                    if(sort[k]>sort[i])
                    {
                        t=sort[i];
                        sort[i] = sort[k];
                        sort[k] = t;
                    }
                }
            }
            for(l=0;l<sort.Length;l++)
            {
                Console.WriteLine(sort[l]);
            }
        }
    }
}
