using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

internal class ValidParenthesesSolution
{
    public static bool IsValidMemory1(string s)
    {

        Stack<char> parenStack = new Stack<char>();

        foreach (char paren in s)
        {
            if (paren == ')')
            {
                if (parenStack.Count() == 0)
                {
                    return false;
                }
                if (parenStack.Peek() != '(')
                {
                    return false;
                }
                parenStack.Pop();
            }
            else if (paren == ']')
            {
                if (parenStack.Count() == 0)
                {
                    return false;
                }
                if (parenStack.Peek() != '[')
                {
                    return false;
                }
                parenStack.Pop();
            }
            else if (paren == '}')
            {
                if (parenStack.Count() == 0)
                {
                    return false;
                }
                if (parenStack.Peek() != '{')
                {
                    return false;
                }
                parenStack.Pop();
            }
            else
            {
                parenStack.Push(paren);
            }
        }
        return (parenStack.Count() == 0);
    }

    public static bool IsValidMemory2(string s)
    {
        Stack<char> parens = new Stack<char>();

        Dictionary<char, char> closers = new Dictionary<char, char>();
        closers.Add(')', '(');
        closers.Add('}', '{');
        closers.Add(']', '[');

        foreach (char p in s)
        {
            if (closers.ContainsKey(p))
            {
                if (parens.Count == 0)
                {
                    return false;
                }
                else if (closers[p] != parens.Peek())
                {
                    return false;
                }
                parens.Pop();
            }
            else
            {
                parens.Push(p);
            }
        }

        return (parens.Count() == 0);

    }

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
                if (parens.Count == 0)
                {
                    return false;
                }
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
