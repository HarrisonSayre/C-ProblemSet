using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

internal class TopKFrequentSolution
{
    public static int[] TopKFrequent(int[] nums, int k)
    {
        int[] topK = new int[k];

        Dictionary<int, int> occurances = new Dictionary<int, int>();

        foreach (int i in nums)
        {
            occurances[i] = occurances.GetValueOrDefault(i) + 1;
        }

        List<int[]> mostFrequent = occurances.Select(occurance => new int[] { occurance.Value, occurance.Key }).ToList();
        mostFrequent.Sort((a, b) => b[0].CompareTo(a[0]));

        for (int i = 0; i < k; i++)
        {
            topK[i] = mostFrequent[i][1];
        }

        return topK;
    }


}
