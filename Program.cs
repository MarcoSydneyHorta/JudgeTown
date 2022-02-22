using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace JudgeTown
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] rasc = new int[] { 1, 3, 2, 3};
            int d = 0;
            int tam = rasc.Length / 2;
            int[][] ent = new int[tam][];
            ent[0] = new int[2];
            ent[1] = new int[2];
           // ent[2] = new int[2];
            

            for (int k = 0; k < tam; k++)
            {
                for (int l = 0; l < 2; l++)
                {
                    ent[k][l] = rasc[d];
                    d++;
                }
            }

            int res = Solution.findJudge(3, ent);
            Console.WriteLine(" O juíz é o número " + res);
            Console.Read();
            /* Console.Write("Enter N: ");
             var N = Console.ReadLine();
             Console.Write("Enter input delimited by comma: ");
             var input = Console.ReadLine();

             var components = input.Split(',');
             var myList = new List<int[]>();
             var size = components.Length;

             int[][] trust = new int[1][];
             int[] arr = new int[size];

             string[] result = new string[size];

             for (int i = 0; i < size; i++)
             {
                 result = components[i].Split(' ');
                 myList.Insert(i, new int[]{ int.Parse(result[0]), int.Parse(result[1]) });

             }

             trust = myList.Select(a => a.ToArray()).ToArray();
             Console.WriteLine(Solution.findJudge(int.Parse(N), trust)); */

            
 
            Console.Read();

        }
    }

    
}
