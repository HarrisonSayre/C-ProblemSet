using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

internal class ValidPalindromeSolution
{
    public static bool IsPalindrome(string s)
    {
        string lowerS = s.ToLower();

        int i = 0;
        int j = s.Length-1;

        while (i < j)
        {
            char.IsLetterOrDigit(lowerS[i]); 

            while(!char.IsLetterOrDigit(lowerS[i]))
            {
                i++;
            }
            while (!char.IsLetterOrDigit(lowerS[j]))
            {
                j--;
            }

            if (lowerS[i] != lowerS[j])
            {
                return false; 
            }
            i++;
            j--;
        }

        return true;
    }
}
