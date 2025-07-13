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

////ProductOfArrayExceptSelf
//int[] nums = { 1, 2, 3, 4 };
////int[] nums = { -1, 1, 0, -3, 3 };
//int[] product = ProductOfArrayExceptSelfSolution.ProductExceptSelf(nums);
//Console.WriteLine(string.Join(", ", product));

//Valid Sudoku
char[] row1 = { '5', '3', '.', '.', '7', '.', '.', '.', '.' };
//char[] row1 = { '8', '3', '.', '.', '7', '.', '.', '.', '.' }; //wrong answer
char[] row2 = { '6', '.', '.', '1', '9', '5', '.', '.', '.' };
char[] row3 = { '.', '9', '8', '.', '.', '.', '.', '6', '.' };

char[] row4 = { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
char[] row5 = {'4', '.', '.', '8', '.', '3', '.', '.', '1' };
char[] row6 = { '7', '.', '.', '.', '2', '.', '.', '.', '6' };

char[] row7 = { '.', '6', '.', '.', '.', '.', '2', '8', '.' };
char[] row8 = { '.', '.', '.', '4', '1', '9', '.', '.', '5' };
char[] row9 = { '.', '.', '.', '.', '8', '.', '.', '7', '9' };

char[][] board = new char[][] {row1, row2, row3, row4, row5, row6, row7, row8, row9 };
Console.WriteLine(ValidSudokuSolution.IsValidSudoku(board));

