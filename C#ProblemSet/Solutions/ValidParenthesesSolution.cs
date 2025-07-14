using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

internal class ValidParenthesesSolution
{
    public static bool IsValid(string s)
    {
        Stack<char> parens = new Stack<char>();

        foreach (char p in s)
        {
            if (p == '(' || p == '{' || p == '[') {
                parens.Push(p);
            }
            if (p == ')' || p == '}' || p == ']')
            {
                char top = parens.Peek();
                if(top == '(' && p == ')')
                {
                    parens.Pop();
                }
                else if(top == '{' && p == '}')
                {
                    parens.Pop();
                }
                else if (top == '[' && p == ']')
                {
                    parens.Pop();
                }
                else
                {
                    return false;
                }
            }
        }
        if(parens.Count == 0)
        {
            return true;
        }
        return false;
    }
}
