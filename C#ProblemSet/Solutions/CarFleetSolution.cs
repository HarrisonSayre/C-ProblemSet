using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_ProblemSet.Solutions;

public class CarFleetSolution
{
    public static int CarFleet(int target, int[] position, int[] speed)
    {
        int[][] graphPoints = new int[position.Length][];
        for (int i = 0; i < position.Length; ++i)
        {
            graphPoints[i] = new int[] { position[i], speed[i] };
        }

        Array.Sort(graphPoints, (a, b) => b[0].CompareTo(a[0]));

        Stack<double> carStack = new Stack<double>();
        foreach (int[] point in graphPoints)
        {
            double time = target - point[0];
            time = time / point[1];
            if (carStack.Count ==0 || time > carStack.Peek())
            {
                carStack.Push(time);
            }
        }

        return carStack.Count;
        //return 0;
    }
}
