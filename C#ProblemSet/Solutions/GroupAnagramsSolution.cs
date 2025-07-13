using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

internal class GroupAnagramsSolution
{
    public static List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {

            int[] alphabetCount = new int[26];
            foreach (char ch in str)
            {
                alphabetCount[ch - 'a'] = alphabetCount[ch - 'a'] + 1;
            }
            string occurances = string.Join(",", alphabetCount);

            if (!anagramGroups.ContainsKey(occurances))
            {
                anagramGroups[occurances] = new List<string>();
            }
            anagramGroups[occurances].Add(str);

        }

        return anagramGroups.Values.ToList<List<string>>();

    }

}
