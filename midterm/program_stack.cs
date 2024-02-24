//This problem worthy of 7.5%
using System.Collections.Generic;

public class MyStack
{
    private List<int> stack;

    public MyStack()
    {
        stack = new List<int>();
    }

    public void Push(int item)
    {
        // TODO: Complete the Push method to add an item to the stack
        stack.Add(item);
    }

    public int Peek()
    {
        // TODO: Complete the Peek method to return the top item from the stack without removing it
        return stack[stack.Count - 1];
    }
}
