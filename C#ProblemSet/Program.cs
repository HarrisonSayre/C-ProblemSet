// See https://aka.ms/new-c
// onsole-template for more information
using C_ProblemSet.Solutions;
using static System.Net.Mime.MediaTypeNames;

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
//char[] row1 = { '5', '3', '.', '.', '7', '.', '.', '.', '.' };
////char[] row1 = { '8', '3', '.', '.', '7', '.', '.', '.', '.' }; //wrong answer
//char[] row2 = { '6', '.', '.', '1', '9', '5', '.', '.', '.' };
//char[] row3 = { '.', '9', '8', '.', '.', '.', '.', '6', '.' };

//char[] row4 = { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
//char[] row5 = {'4', '.', '.', '8', '.', '3', '.', '.', '1' };
//char[] row6 = { '7', '.', '.', '.', '2', '.', '.', '.', '6' };

//char[] row7 = { '.', '6', '.', '.', '.', '.', '2', '8', '.' };
//char[] row8 = { '.', '.', '.', '4', '1', '9', '.', '.', '5' };
//char[] row9 = { '.', '.', '.', '.', '8', '.', '.', '7', '9' };

//char[][] board = new char[][] {row1, row2, row3, row4, row5, row6, row7, row8, row9 };
//Console.WriteLine(ValidSudokuSolution.IsValidSudoku(board));

//Longest Consecutive sequence
//int[] nums = { 100, 4, 200, 1, 3, 2 };
////int[] nums = { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
////int[] nums = {1,0,1,2};
//Console.WriteLine(LongestConsecutiveSequenceSolution.LongestConsecutive(nums));

//Valid Palindrome 
//string s = "A man, a plan, a canal: Panama";
////string s = "race a car";
////string s = " ";
//Console.WriteLine(ValidPalindromeSolution.IsPalindrome(s));

//TwoSum 2 Electric Boogaloo
////int[] numbers = { 2, 7, 11, 15 };
////int target = 9;
////int[] numbers = { 2, 3, 4 };
////int target = 6;
////int[] numbers = { -1,0 };
////int target = -1;
//int[] numbers = { 2, 7, 11, 15 };
//int target = 18;
//int[] sum = TwoSumIISolution.TwoSum(numbers, target);
//Console.WriteLine(String.Join(",", sum));

////ThreeSum
//int[] numbers = {-1, 0, 1, 2, -1, -4};
////int[] numbers = { 0, 1, 1};
////int[] numbers = { 0, 0, 0};
//ThreeSumSolution.ThreeSum(numbers);

////Container With Most Water
//int[] numbers = {1, 8, 6, 2, 5, 4, 8, 3, 7};
//Console.WriteLine(ContainerWithMostWaterSolution.MaxArea(numbers));

////Valid Parens
////string parens = "()";
////string parens = "()[]{}";
////string parens = "(]";
//string parens = "([])";
//Console.WriteLine(ValidParenthesesSolution.IsValid(parens));

////Min Stack
//MinStack minStack = new MinStack();
//minStack.Push(-2);
//minStack.Push(0);
//minStack.Push(-2);
//minStack.Push(-3);
//Console.WriteLine(minStack.GetMin());
//minStack.Pop();
//minStack.Pop();
//Console.WriteLine(minStack.Top());
//Console.WriteLine(minStack.GetMin());

////Reverse polish notation
////string[] tokens = { "2", "1", "+", "3", "*" };
////string[] tokens = {"4","13","5","/","+"};
//string[] tokens = { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };
//Console.WriteLine(RPNSolution.EvalRPN(tokens));

////Generate Parens
//GenerateParenthesesSolution test = new GenerateParenthesesSolution();
//List<String> result = test.GenerateParenthesis(3);
//Console.WriteLine(String.Join(", ", result));

////Daily Temperature
//int[] temps = { 73, 74, 75, 71, 69, 72, 76, 73 };
////int[] temps = { 30, 40, 50, 60 };
////int[] temps = { 30, 60, 90 };

//int[] answer = DailyTemperatureSolution.DailyTemperatures(temps);
//Console.WriteLine(String.Join(", ", answer));

////Car Fleet
//int target = 12;
//int[] position = { 10, 8, 0, 5, 3 };
//int[] speed = { 2, 4, 1, 1, 3 };
//Console.WriteLine(CarFleetSolution.CarFleet(target, position, speed));

////Binary Search
//int[] nums = { -1, 0, 3, 5, 9, 12 };
//int target = 9;
////int target = 2;
//BinarySearchSolution test = new BinarySearchSolution();
//Console.WriteLine(test.Search(nums, target));

////2D Matrix Search
//int[][] matrix;
//int[] row1 = { 1, 3, 5, 7 };
//int[] row2 = { 10, 11, 16, 20 };
//int[] row3 = { 23, 30, 34, 60 };
//matrix = new int[][] { row1, row2, row3 };
//int target = 3;
////int target = 13;
//TwoDMatrixSolution test = new TwoDMatrixSolution();
//Console.WriteLine(test.searchMatrix(matrix, target));