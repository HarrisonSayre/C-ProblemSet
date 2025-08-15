using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ProblemSet.Solutions;

public class MinStackMem1
{

    public Stack<int> regularStack;
    public Stack<int> minimumStack;

    public MinStackMem1()
    {
        regularStack = new Stack<int>();
        minimumStack = new Stack<int>();
    }

    public void Push(int val)
    {
        if (regularStack.Count() == 0)
        {
            minimumStack.Push(val);
        }
        else
        {
            if (val < minimumStack.Peek())
            {
                minimumStack.Push(val);
            }
            else
            {
                minimumStack.Push(minimumStack.Peek());
            }
        }
        regularStack.Push(val);

    }

    public void Pop()
    {
        regularStack.Pop();
        minimumStack.Pop();
    }

    public int Top()
    {
        return regularStack.Peek();
    }

    public int GetMin()
    {
        return minimumStack.Peek();
    }
}

public class MinStack
{
    private Stack<int> normalStack = new Stack<int>();
    private Stack<int> minimumStack = new Stack<int>();

    public void Push(int val)
    {
        normalStack.Push(val);
        if(minimumStack.Count == 0 || val < minimumStack.Peek())
        {
            minimumStack.Push(val);
        }
        else
        {
            minimumStack.Push(minimumStack.Peek());
        }
    }

    public void Pop()
    {
        //No check here?
        minimumStack.Pop();
        normalStack.Pop();
    }

    public int Top()
    {
        return normalStack.Peek();
    }

    public int GetMin()
    {
        return minimumStack.Peek();
    }
}
