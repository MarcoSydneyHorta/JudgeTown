using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace JudgeTown
{
    class Solution
    {
        public static int findJudge(int N, int[][] trust)
        {
            int ans = 0;
            int tam = trust.Length;
            int cit = 0;

            int[] cada = new int[tam];

            for (int i = 0; i < tam; i++)
            {
                cit = trust[i][1];
            for (int j = 0; j < 2; j++)
                {
                if (trust[j][1] == cit)
                    {
                        cada[i]++;
                    }

                }

            }

            //ans = cada.Select(n => n).Max();
            
            for (int i = 0; i < tam; i++)
            {
                if ( cada[i] == N - 1)
                {
                    ans = trust[i][1];
                }
                else
                {
                    ans = -1;
                }
            }
            return ans;
        }
    }
}
