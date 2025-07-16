using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_ProblemSet.Solutions;

public class TwoDMatrixSolution
{
    public int searchRow(int[][] matrix, int target, int startIndex, int endIndex)
    {
        int mid = (startIndex + endIndex) / 2;

        if (startIndex > endIndex)
        {
            return -1;
        }

        if ((target < matrix[mid][matrix.Length]) && (target > matrix[mid][0]))
        {
            return mid;
        }
        else if (target > matrix[mid][0])
        {
            return searchRow(matrix, target, startIndex + 1, endIndex);
        }
        else if (target < matrix[mid][matrix.Length])
        {
            return searchRow(matrix, target, startIndex, endIndex - 1);
        }


        return - 1; 
    }

    public int searchColumn(int[][] matrix, int target, int startIndex, int endIndex, int row)
    {
        int mid = (startIndex + endIndex) / 2;

        if (startIndex > endIndex)
        {
            return -1;
        }

        if ((target == matrix[row][mid]))
        {
            return mid;
        }
        else if (matrix[row][mid] > target)
        {
            return searchColumn(matrix, target, startIndex, mid-1, row);
        }
        else if (matrix[row][mid] < target)
        {
           return searchColumn(matrix, target, mid+1, endIndex, row);
        }

        return -1;
    }


    public bool searchMatrix(int[][] matrix, int target)
    {

        int row = this.searchRow(matrix, target, 0, matrix.Length - 1);
        if (row == -1)
        {
            return false;
        }

        int column = this.searchColumn(matrix, target, 0, matrix[0].Length - 1, row);
        return column != -1; 
    }
}
