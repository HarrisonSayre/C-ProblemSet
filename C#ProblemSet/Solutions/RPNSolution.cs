using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

public class RPNSolution
{
    public static int EvalRPN(string[] tokens)
    {
        Stack<int> result = new Stack<int>();

        foreach (string token in tokens) {
            if (token == "+"){
                int num1 = result.Pop();
                int num2 = result.Pop();
                result.Push(num2+num1);
            }
            else if (token == "-")
            {
                int num1 = result.Pop();
                int num2 = result.Pop();
                result.Push(num2 - num1);
            }
            else if (token == "*")
            {
                int num1 = result.Pop();
                int num2 = result.Pop();
                result.Push(num2 * num1);
            }
            else if (token == "/")
            {
                int num1 = result.Pop();
                int num2 = result.Pop();
                result.Push(num2 / num1);
            }
            else
            {
                result.Push(Int32.Parse(token));
            }
        }
        return result.Pop();
    }

}
