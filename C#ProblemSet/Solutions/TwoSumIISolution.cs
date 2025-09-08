using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

internal class TwoSumIISolution
{

    public int[] TwoSumMem1(int[] numbers, int target)
    {
        int l = 0;
        int r = numbers.Length - 1;
        int[] answer = new int[2];

        while (l < r)
        {
            int curSum = numbers[l] + numbers[r];
            if (curSum == target)
            {
                answer[0] = l + 1;
                answer[1] = r + 1;
                return answer;
            }
            if (curSum < target)
            {
                l++;
            }
            if (curSum > target)
            {
                r--;
            }
        }

        return null;

    }

    public static int[] TwoSum(int[] numbers, int target)
    {
        int i = 0;
        int j = numbers.Length-1;
        int[] answer = new int[2];

        while (i<j)
        {
            if (numbers[i] + numbers[j] == target)
            {
                //Console.WriteLine(numbers[i]);
                //Console.WriteLine(numbers[j]);
                answer[0] = i + 1;
                answer[1] = j + 1;
                return answer;
            }
            else if (numbers[i] + numbers[j] > target)
            {
                j--;
            }
            else if (numbers[i] + numbers[j] < target)
            {
                i++;
            }
        }

        return null;
    }
}
