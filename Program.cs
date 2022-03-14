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
            Console.WriteLine("Enter the numbers separeted by comma,");
            Console.WriteLine("where the first one trust in the second one,");
            Console.Write("the third one trust in the forth one, and so on: "); 
            // for example: 1, 3, 2, 3 where 1 trust in 3 and 2 trust in 3

            string[] person = Console.ReadLine().Split(',');

            int tams = person.Length;
            int[] rasc = new int[tams];

            for (int i=0; i < tams; i++)
            {
                rasc[i] = int.Parse(person[i]);
            }

            int d = 0;
            int tam = rasc.Length / 2;  // Because there are 2 position for each person
            int[][] ent = new int[tam][];
            for (int i = 0; i < tam; i++)
            {
                ent[i] = new int[2];  //  ent matrix has 2 dimensions
            }

            for (int k = 0; k < tam; k++)
            {
                for (int l = 0; l < 2; l++)
                {
                    ent[k][l] = rasc[d];  // Fill the ent matrix with the person and their trusted person
                    d++;
                }
            }

            int res = Solution.findJudge(ent);
            if (res != -1)
            {
                Console.WriteLine(" The judge is the number " + res);
            }
            else
            {
                Console.WriteLine(" There's no judge ");
            }
            
            Console.Read();
        }
    }
   
}
