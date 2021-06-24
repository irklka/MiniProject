using System;


//6.     დაწერეთ საკუთარი მონაცემთა სტრუქტურა, 
//       რომელიც საშუალებას მოგვცემს O(1) დროში 
//       წავშალოთ ელემენტი.



class Stack
{
    private int[] _elements;
    private int _topElement;
    private int _size;
    public Stack(int size)
    {
        _elements = new int[size];
        _topElement = -1;
        _size = size;
    }

    public void printStack()
    {
        if (_topElement == -1)
        {
            Console.WriteLine("Stack is Empty");
            return;
        }
        else
        {
            for (int i = 0; i <= _topElement; i++)
            {
                Console.WriteLine("{0} element of Stack", _elements[i]);
            }
        }
    }
    public bool isEmpty()
    {
        if (_topElement == -1)
        {
            Console.WriteLine("Stack is Empty");
            return true;
        }
        else
        {
            Console.WriteLine("Stack is NOT Empty");
            return false;
        }
    }
    public void push(int el)
    {
        if (_topElement == _size - 1)
        {
            Console.WriteLine("Stack Overflow");
            return;
        }
        else
        {
            _elements[++_topElement] = el;
        }
    }

    public int pop()
    {
        if (_topElement == -1)
        {
            Console.WriteLine("Stack is Empty");
            return -1;
        }
        else
        {
            Console.WriteLine("{0} popped from Stack ", _elements[_topElement]);
            return _elements[_topElement--];
        }
    }
    

    public int top()
    {
        if (_topElement == -1)
        {
            Console.WriteLine("Stack is Empty");
            return -1;
        }
        else
        {
            Console.WriteLine("{0} is top element ", _elements[_topElement]);
            return _elements[_topElement];
        }
    }


}

class Program
{
    static void Main()
    {
        Stack stacc = new Stack(3);

        stacc.isEmpty();

        stacc.push(1);
        stacc.push(11);
        stacc.push(111);

        stacc.top();

        stacc.isEmpty();


        stacc.printStack();


        System.Console.WriteLine();


        stacc.pop();

        stacc.top();

        System.Console.WriteLine();

        stacc.printStack();

        System.Console.WriteLine();

        stacc.top();

        System.Console.WriteLine();

        stacc.push(5);
        stacc.push(666);





    }
}

