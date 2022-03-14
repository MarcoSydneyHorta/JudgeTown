using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace JudgeTown
{
    class Solution
    {
        public static int findJudge(int[][] trust)
        {
            int ans = -1;
            int tam = trust.Length;
     
            int same = trust[0][1];
            for (int i = 0; i < tam; i++)
            {
                if (trust[i][1] == same)
                {
                    ans = same; // This is the judge
                }
                else
                {
                    ans = -1; // There's no judge
                    return ans;
                }
            }
            return ans;
        }
    }
}
