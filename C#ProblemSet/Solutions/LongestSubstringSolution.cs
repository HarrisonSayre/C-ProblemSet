namespace C_ProblemSet.Solutions;

public class LongestSubstringSolution
{
    public static int LengthOfLongestSubstring(string s)
    {
        int longest = 0;
        int k = 0;
        HashSet<char> currentSubString = new HashSet<char>();


        for (int i = 0; i<s.Length; i++)
        {

            //for (int j = i; j < s.Length; j++)
            //{
            //    if (currentSubString.Contains(s[j]))
            //    {
            //        break;
            //    }
            //    currentSubString.Add(s[j]);
            //}
            //if(currentSubString.Count > longest)
            //{
            //    longest = currentSubString.Count;
            //}

            while (currentSubString.Contains(s[i]))
            {
                currentSubString.Remove(s[k]);
                k++;
            }

            currentSubString.Add(s[i]);
            if (longest < (i-k+1) )
            {
                longest = i - k + 1;
            }
        }

        return longest; 
    }
}
