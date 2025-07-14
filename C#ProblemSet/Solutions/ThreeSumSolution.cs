using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

public class ThreeSumSolution
{
    public static List<List<int>> ThreeSum(int[] nums)
    {
        //Sort
        Array.Sort(nums);

        List<List<int>> triplets = new List<List<int>>();

        for (int k = 0; k < nums.Length - 2; k++)
        {

            if (k > 0 && nums[k] == nums[k - 1])
            {
                    k++;
            }

            int target = nums[k];

            int i = k + 1;
            int j = nums.Length - 1;

            while (i < j)
            {
               
                if (nums[i] + nums[j] + target == 0)
                {
                    List<int> triplet = new List<int>() { target, nums[i], nums[j]};
                    triplets.Add(triplet);
                    i++;
                    j--;
                }
                else if (nums[i] + nums[j] > nums[k])
                {
                    j--;
                }
                else if (nums[i] + nums[j] < nums[k])
                {
                    i++;
                }
            }
        }

        return triplets;
    }

}
