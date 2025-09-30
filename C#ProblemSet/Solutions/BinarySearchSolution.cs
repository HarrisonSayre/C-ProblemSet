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

    public int BinarySearcMem1(int left, int right, int[] nums, int target)
    {
        if (left > right)
        {
            return -1;
        }
        int middle = left + (right - left) / 2;

        if (nums[middle] == target)
        {
            return middle;
        }
        else if (nums[middle] < target)
        {
            return BinarySearcMem1(middle + 1, right, nums, target);
        }
        else
        {
            return BinarySearcMem1(left, middle - 1, nums, target);
        }
    }

    public int SearchMem1(int[] nums, int target)
    {
        return BinarySearcMem1(0, nums.Length - 1, nums, target);
    }

}
