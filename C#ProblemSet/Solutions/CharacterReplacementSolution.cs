

namespace C_ProblemSet.Solutions;

public class CharacterReplacementSolution
{

    public int CharacterReplacementMem1(string s, int k)
    {

        int longest = 0;
        int mostCommon = 0;
        int left = 0;

        Dictionary<char, int> charCounts = new Dictionary<char, int>();

        for (int right = 0; right < s.Length; right++)
        {

            if (charCounts.ContainsKey(s[right]))
            {
                charCounts[(s[right])] = charCounts[(s[right])] + 1;
                //Console.WriteLine(charCounts[s[right]]);
            }
            else
            {
                charCounts[s[right]] = 1;
            }

            //if(mostCommon < charCounts[s[right]]){
            //    mostCommon = charCounts[s[right]];
            //}
            mostCommon = Math.Max(mostCommon, charCounts[s[right]]);

            while (((right - left + 1) - mostCommon > k))
            {
                charCounts[s[left]]--;
                left++;
            }

            //if(longest < (right-left+1)){
            //    longest = right-left+1;    
            //}

            longest = Math.Max(longest, (right - left + 1));
        }

        return longest;
    }

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
