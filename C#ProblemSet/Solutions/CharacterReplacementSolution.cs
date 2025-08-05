

namespace C_ProblemSet.Solutions;

public class CharacterReplacementSolution
{
    public static int CharacterReplacement(string s, int k)
    {
        Dictionary<char, int> charTotals = new Dictionary<char, int>();
        int longest = 0;

        int left = 0;
        int right = 0;
        int mostFrequent = 0;
        while(right < s.Length)
        {
            if (charTotals.ContainsKey(s[right]))
            {
                charTotals[s[right]]++;
            }
            else
            {
                charTotals[s[right]] = 1;
            }

            if (charTotals[s[right]] > mostFrequent)
            {
                mostFrequent = charTotals[s[right]];
            }

            while ( ( (right - left + 1) - mostFrequent) > k)
            {
                charTotals[s[left]]--;
                left++;
            }

            if( right-left+1 > longest)
            {
                longest = right-left+1;
            }
            right++;
        }
        return longest;
    }
}
