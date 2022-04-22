namespace StackInt;

public class Stack
{
    private int[] _st;
    private int _top;
    private int _max;

    public Stack(int size)
    {
        _max = size;
        _top = -1;
        _st = new int[size];
    }


    public void push(int element)
    {
        if (_top == _max - 1)
        {
            Console.Write("Stack overflow");
            return;
        }

        _st[++_top] = element;
    }

    public int pop()
    {
        if (_top == -1)
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }

        return _st[_top--];
    }

    public void print()
    {
        int i = 0;
        if (_top == -1)
        {
            Console.WriteLine("stack is empty");
            return;
        }

        while (i <= _top)
        {
            Console.WriteLine($"{_st[i]}");
            i++;
        }
    }
}