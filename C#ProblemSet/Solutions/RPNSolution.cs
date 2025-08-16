using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

public class RPNSolution
{
    public int EvalRPNMem2(string[] tokens)
    {
        Stack<int> mathStack = new Stack<int>();

        foreach (string val in tokens)
        {
            if (val == "+")
            {
                mathStack.Push(mathStack.Pop() + mathStack.Pop());
            }
            else if (val == "*")
            {
                mathStack.Push(mathStack.Pop() * mathStack.Pop());
            }
            else if (val == "-")
            {
                int subtractor = mathStack.Pop();
                int subtractee = mathStack.Pop();
                mathStack.Push(subtractee - subtractor);
            }
            else if (val == "/")
            {
                int divisor = mathStack.Pop();
                int numerator = mathStack.Pop();
                mathStack.Push(numerator / divisor);
            }
            else
            {
                mathStack.Push(int.Parse(val));
            }
        }

        return mathStack.Peek();

    }

    public int EvalRPNNMem1(string[] tokens)
    {
        Stack<String> rpnStack = new Stack<String>();

        for (int i = 0; i < tokens.Length; i++)
        {
            if (tokens[i] == "+")
            {
                int firstNumber = Int32.Parse(rpnStack.Pop());
                int secondNumber = Int32.Parse(rpnStack.Pop());
                string result = (firstNumber + secondNumber).ToString();
                rpnStack.Push(result);
            }
            else if (tokens[i] == "-")
            {
                int firstNumber = Int32.Parse(rpnStack.Pop());
                int secondNumber = Int32.Parse(rpnStack.Pop());
                string result = (secondNumber - firstNumber).ToString();
                rpnStack.Push(result);
            }
            else if (tokens[i] == "*")
            {
                int firstNumber = Int32.Parse(rpnStack.Pop());
                int secondNumber = Int32.Parse(rpnStack.Pop());
                string result = (firstNumber * secondNumber).ToString();
                rpnStack.Push(result);
            }
            else if (tokens[i] == "/")
            {
                int firstNumber = Int32.Parse(rpnStack.Pop());
                int secondNumber = Int32.Parse(rpnStack.Pop());
                string result = (secondNumber / firstNumber).ToString();
                rpnStack.Push(result);
            }
            else
            {
                rpnStack.Push(tokens[i]);
            }
        }

        return Int32.Parse(rpnStack.Peek());
    }

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
