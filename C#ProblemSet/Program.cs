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
int[] nums = [2, 7, 11, 15];
int target = 9;

//int[] nums = [3, 2, 4];
//int target = 6;

//int[] nums = [3, 3];
//int target = 6;

int[] solution = TwoSumSolution.TwoSum(nums, target);
Console.WriteLine(solution[0]+" "+solution[1]);
