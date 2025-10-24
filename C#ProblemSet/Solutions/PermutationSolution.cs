using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

public  class PermutationSolution
{
    public bool CheckInclusion(string s1, string s2)
    {

        if (s1.Length > s2.Length)
        {
            return false;
        }

        int[] count1 = new int[26];
        int[] count2 = new int[26];
        int matchingLetters = 0;
        int left = 0;

        for (int i = 0; i < s1.Length; i++)
        {
            count1[s1[i] - 'a']++;
            count2[s2[i] - 'a']++;
        }
        for (int i = 0; i < 26; i++)
        {
            if (count1[i] == count2[i])
            {
                matchingLetters++;
            }
        }

        //Console.WriteLine(matchingLetters);

        for (int right = s1.Length; right < s2.Length; right++)
        {
            if (matchingLetters == 26)
            {
                return true;
            }

            int index = s2[right] - 'a';
            count2[index]++;
            if (count1[index] == count2[index])
            {
                matchingLetters++;
            }
            else if (count1[index] + 1 == count2[index])
            {
                matchingLetters--;
            }

            //Console.WriteLine(matchingLetters+" FIRST");

            index = s2[left] - 'a';
            count2[index]--;
            if (count1[index] == count2[index])
            {
                matchingLetters++;
            }
            else if (count1[index] - 1 == count2[index])
            {
                matchingLetters--;
            }

            //Console.WriteLine(matchingLetters+" SECOND");

            left++;
        }

        return (matchingLetters == 26);

    }
}
