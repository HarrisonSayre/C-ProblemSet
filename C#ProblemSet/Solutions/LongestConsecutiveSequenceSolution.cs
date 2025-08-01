using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;


public class LongestConsecutiveSequenceSolution
{

    //This is worse than the one I did below.
    public static int LongestConsecutiveSorting(int[] nums)
    {
        int longest = 0;
        if (nums.Length == 0)
        {
            return longest;
        }

        Array.Sort(nums);

        int i = 0;
        int curSequence = 0;
        int curNumber = nums[0];

        while(i < nums.Length)
        {

            if (curNumber != nums[i])
            {
                curSequence = 0;
                curNumber = nums[i];
            }

            while (i < nums.Length && nums[i] == curNumber)
            {
                i++;
            }

            curNumber++;
            curSequence++;

            if(curSequence > longest)
            {
                longest = curSequence;
            }
        }

        return longest;
    }
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
