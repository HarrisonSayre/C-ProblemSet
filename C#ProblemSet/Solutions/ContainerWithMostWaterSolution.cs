using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

public class ContainerWithMostWaterSolution
{
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
