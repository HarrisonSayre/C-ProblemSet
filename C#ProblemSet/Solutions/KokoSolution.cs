using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

public  class KokoSolution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int left = 1;
        int right = piles.Max();
        int answer = right;
        //Console.WriteLine(right);

        while (left <= right)
        {
            int k = (left + right) / 2;

            //Console.WriteLine(k);

            int spentTime = 0;

            foreach (int bananas in piles)
            {
                spentTime += (int)Math.Ceiling((double)bananas / k);
            }

            Console.WriteLine(spentTime);

            if (spentTime <= h && spentTime >= 0)
            {
                answer = k;
                right = k - 1;
            }
            else
            {
                left = k + 1;
            }

        }

        return answer;
    }

}
