using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

internal class ValidSudokuSolution
{
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
