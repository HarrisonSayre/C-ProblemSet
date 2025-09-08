using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

internal class ValidPalindromeSolution
{
    public bool IsPalindromeMem1(string s)
    {
        int l = 0;
        int r = s.Length - 1;

        while (l < r)
        {
            while (!Char.IsLetterOrDigit(s[l]) && l < r)
            {
                l++;
            }
            while (!Char.IsLetterOrDigit(s[r]) && l < r)
            {
                r--;
            }
            if (Char.ToLower(s[l]) != Char.ToLower(s[r]))
            {
                return false;
            }
            l++;
            r--;
        }
        return true;
    }

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
