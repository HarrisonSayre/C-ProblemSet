using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

public class GenerateParenthesesSolution
{

    private void ParenHelper( int numOpen, int numClose, int goalNum, List<string> validParens, string buildingString)
    {
        if (numOpen == numClose && numClose == goalNum)
        {
            validParens.Add(buildingString);
            return;
        }

        if (numOpen < goalNum) {
            ParenHelper(numOpen+1, numClose, goalNum, validParens, buildingString+"(");
        }

        if (numClose < numOpen)
        {
            ParenHelper(numOpen, numClose+1, goalNum, validParens, buildingString+")");
        }

    }
    public List<string> GenerateParenthesis(int n)
    {
        List<string> validParens = new List<string>();
        ParenHelper(0,0, n, validParens, "");
        return validParens; 
    }
}
