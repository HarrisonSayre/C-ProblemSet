using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

public class DailyTemperatureSolution
{
        public int[] DailyTemperaturesMem2(int[] temperatures) {
        Stack<int[]> temperatureStack = new Stack<int[]>();
        int[] tempAnswers = new int[temperatures.Length];


        for(int i = 0; i< temperatures.Length; i++){
            while(temperatureStack.Count() > 0 && temperatures[i] > temperatureStack.Peek()[0]){
                int[] currentPair = temperatureStack.Pop();
                tempAnswers[currentPair[1]] = i - currentPair[1];
            }
            int[] newPair = {temperatures[i], i} ;
            temperatureStack.Push(newPair);
        }
        return tempAnswers;

    }

    public int[] DailyTemperaturesMem1(int[] temperatures)
    {
        Stack<int[]> tempStack = new Stack<int[]>();
        int[] tempAnswers = new int[temperatures.Length];

        for (int i = 0; i < temperatures.Length; i++)
        {
            while (tempStack.Count() > 0 && temperatures[i] > tempStack.Peek()[0])
            {
                int[] curTop = tempStack.Pop();
                tempAnswers[curTop[1]] = i - curTop[1];
            }
            int[] newPair = { temperatures[i], i };
            tempStack.Push(newPair);
        }

        return tempAnswers;
    }

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
