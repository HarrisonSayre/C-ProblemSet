using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

public class BinarySearchSolution
{

    private int BinarySearch(int start, int len, int[] nums, int target)
    {

        if (start > len)
        {
            return -1;
        }

        int mid = (start + len) / 2;
        if (nums[mid] == target)
        {
            return mid;
        }
        else if (nums[mid] > target)
        {
            return BinarySearch(start, mid-1, nums, target);
        }
        else
            return BinarySearch(mid+1, len, nums, target);
    }

    public  int Search(int[] nums, int target)
    {
        return BinarySearch(0, nums.Length - 1, nums, target);
    }
}
