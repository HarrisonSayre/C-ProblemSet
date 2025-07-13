// See https://aka.ms/new-c
// onsole-template for more information
using C_ProblemSet.Solutions;

Console.WriteLine("Here is the solution");

//Contains Duplicate
//int[] nums = //[1, 2, 3, 1];

//            //[1, 2, 3, 4];

//            [1, 1, 1, 3, 3, 4, 3, 2, 4, 2];

//Console.WriteLine(ContainsDuplicateSolution.ContainsDuplicate(nums));

//Valid Anagram
//string s = "anagram", t = "nagaram";
////string s = "rat", t = "car";
////string s = "rat", t = "tar";

//Console.WriteLine(ValidAnagramSolution.IsAnagram(s, t));


//TwoSum
//int[] nums = [2, 7, 11, 15];
//int target = 9;

////int[] nums = [3, 2, 4];
////int target = 6;

////int[] nums = [3, 3];
////int target = 6;

//int[] solution = TwoSumSolution.TwoSum(nums, target);
//Console.WriteLine(solution[0]+" "+solution[1]);

//Group Anagrams
//String[] strings = { "eat", "tea", "tan", "ate", "nat", "bat" };
//List<List<string>> result = GroupAnagramsSolution.GroupAnagrams(strings);
//for(int i = 0; i < result.Count; i++)
//{
//    Console.WriteLine(String.Join(",", result[i]));
//}


//K most frequent
//int[] nums = { 1, 1, 1, 2, 2, 3 };
//int k = 2;
//int[] frequent = TopKFrequentSolution.TopKFrequent(nums, k);
//Console.WriteLine(string.Join(", ", frequent));

//ProductOfArrayExceptSelf
int[] nums = { 1, 2, 3, 4 };
//int[] nums = { -1, 1, 0, -3, 3 };
int[] product = ProductOfArrayExceptSelfSolution.ProductExceptSelf(nums);
Console.WriteLine(string.Join(", ", product));
