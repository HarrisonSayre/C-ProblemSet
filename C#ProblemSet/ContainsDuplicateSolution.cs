using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_ProblemSet;

public class ContainsDuplicateSolution
{

    public static bool ContainsDuplicate(int[] nums)
    {
        Dictionary<int, int> duplicateMap = new Dictionary<int, int>();

        foreach (int i in nums)
        {
            if (duplicateMap.ContainsKey(i))
            {
                return true;
            }

            duplicateMap.Add(i, duplicateMap.GetValueOrDefault(i)+1);
        }
        return false; 
    }

}
