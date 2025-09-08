using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

public class ContainerWithMostWaterSolution
{
    public int MaxAreaMem1(int[] height)
    {
        int maxWater = 0;
        int l = 0;
        int r = height.Length - 1;

        while (l < r)
        {
            int curWater = 0;
            if (height[l] > height[r])
            {
                curWater = (r - l) * height[r];
                if (curWater > maxWater)
                {
                    maxWater = curWater;
                }
                r--;
            }
            else
            {
                curWater = (r - l) * height[l];
                if (curWater > maxWater)
                {
                    maxWater = curWater;
                }
                l++;
            }
        }

        return maxWater;

    }

    public static int MaxArea(int[] height)
    {
        int greatestArea = 0;
        int i = 0;
        int j = height.Length-1;

        while (i < j)
        {
            int difference = j - i;
            int currentArea = Math.Min(height[i], height[j]) * difference;
            if (currentArea > greatestArea)
            {
                greatestArea = currentArea;
            }
            if(height[i] > height[j])
            {
                j--;
            }
            else
            {
                i++;
            }
        }
        return greatestArea;
    }
}
