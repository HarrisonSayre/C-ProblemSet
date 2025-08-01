using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

internal class ValidSudokuSolution
{
    public static bool IsValidSudokuBitMask(char[][] board)
    {
        int[] rowSets = new int[board.Length];
        int[] colSets = new int[board.Length];
        int[] squareSets = new int[board.Length];

        for (int r = 0; r < board[0].Length; ++r)
        {
            for (int c = 0; c < board.Length; ++c)
            {
                if (board[r][c] != '.')
                {

                    int curNum = board[r][c] - '1';
                    //Console.WriteLine(curNum);

                    if ((rowSets[r] & (1 << curNum)) > 0 || (colSets[c] & (1 << curNum)) > 0 || (squareSets[(r / 3) * 3 + (c / 3)] & (1 << curNum)) > 0)
                    {
                        return false;
                    }

                    rowSets[r] |= (1 << curNum);
                    colSets[c] |= (1 << curNum);
                    squareSets[(r / 3) * 3 + (c / 3)] |= (1 << curNum);
                }
                else
                {
                    ;
                }
            }
        }        
        return true;
    }

    public static bool IsValidSudoku(char[][] board)
    {
        Dictionary<int, HashSet<char>> rowSets = new ();
        Dictionary<int, HashSet<char>> colSets = new ();
        Dictionary<int, HashSet<char>> squareSets = new();

        for (int r = 0; r < board.Length; r++)
        {
            rowSets[r] = new HashSet<char>();
            colSets[r] = new HashSet<char>();
            squareSets[r] = new HashSet<char> ();
        }

        for (int r = 0; r < board[0].Length; ++r)
        {
            for (int c = 0; c < board.Length; ++c)
            {
                if (board[r][c] != '.')
                {
                    if (rowSets[r].Contains(board[r][c]) || colSets[c].Contains(board[r][c]) || squareSets[ (r / 3) * 3 + (c / 3)].Contains(board[r][c]))
                    {
                        return false; 
                    }
                }

                rowSets[r].Add(board[r][c]);
                colSets[c].Add(board[r][c]);
                squareSets[(r / 3) * 3 + (c / 3)].Add(board[r][c]);

            }
        }
        return true; 
    }
}
