using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;


public class LongestConsecutiveSequenceSolution
{
    public static int LongestConsecutive(int[] nums)
    {
        HashSet<int> digits = new HashSet<int>();
        int longest = 0;

        foreach (int num in nums)
        {
            digits.Add(num);
        }

        foreach (int num in digits)
        {
            if (!digits.Contains(num - 1))
            {
                int cur = 1;
                while (digits.Contains(num + cur))
                {
                    cur++;
                }
                if (cur > longest)
                {
                    longest = cur;
                }
            }
        }

        return longest;
    }

}
