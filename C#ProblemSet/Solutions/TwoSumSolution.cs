using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

public class TwoSumSolution
{
    public static int[]? TwoSum(int[] nums, int target)
    {
        int[] results = new int[2];

        Dictionary<int, int> differences = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int difference = target -nums[i];

            if (differences.ContainsKey(difference)){
                results[0] = differences[difference];
                results[1]= i;
                return results; 
            }
            differences[nums[i]] = i;
        }
        return null;
    }
}