using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

public class ValidAnagramSolution
{
    public static bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> occurancesS = new Dictionary<char, int>();
        Dictionary<char, int> occurancesT = new Dictionary<char, int>();

        if (s.Length != t.Length)
        {
            return false;
        }

        for (int i = 0; i < s.Length; i++)
        {
            char charS = s[i];
            char charT = t[i];    

            occurancesS[charS] = occurancesS.GetValueOrDefault(charS)+1;
            occurancesT[charT] = occurancesT.GetValueOrDefault(charT)+1;
        }

        return occurancesS.Count == occurancesT.Count && !occurancesS.Except(occurancesT).Any();
 
    }

}
