using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

public class DailyTemperatureSolution
{
    public static int[] DailyTemperatures(int[] temperatures)
    {
        Stack<int> tempindex = new Stack<int>();
        int[] hotterDays = new int[temperatures.Length];

        for(int j = temperatures.Length-1; j >= 0; j--)
        { 

            if (j == temperatures.Length - 1)
            {
                hotterDays[j] = 0;
                tempindex.Push(j);
            }
            else
            {
                Stack<int> curTempIndex = tempindex;
                while (curTempIndex.Count > 0)
                {
                    if (temperatures[curTempIndex.Peek()] > temperatures[j])
                    {
                        hotterDays[j] = curTempIndex.Peek() - j;
                        break;
                    }
                    else curTempIndex.Pop();
                }
                tempindex.Push(j);
            }
        }

        return hotterDays; 
    }

}
