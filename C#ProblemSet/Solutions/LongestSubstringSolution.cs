namespace C_ProblemSet.Solutions;

public class LongestSubstringSolution
{
    public static int LengthOfLongestSubstring(string s)
    {
        int longest = 0;

        for(int i = 0; i<s.Length; i++)
        {
            HashSet<char> currentSubString = new HashSet<char>();
            for (int j = i; j < s.Length; j++)
            {
                if (currentSubString.Contains(s[j]))
                {
                    break;
                }
                currentSubString.Add(s[j]);
            }
            if(currentSubString.Count > longest)
            {
                longest = currentSubString.Count;
            }
        }

        return longest; 
    }
}
