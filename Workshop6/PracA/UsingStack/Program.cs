using System;
using System.Collections.Generic;

class UsingStack
{
    public static void Main()
    {
        Stack<string> undoHistory = new Stack<string>(); //using undoHistory(camelcase) as it is local variable
        undoHistory.Push("Typed Text");
        undoHistory.Push("Inserted Image");
        undoHistory.Push("Changed Colour");

        foreach (string history in undoHistory)
        {
            Console.WriteLine(history);
        }
        
        Console.WriteLine("\nPopping '{0}'", undoHistory.Pop());
        foreach (string history in undoHistory)
        {
            Console.WriteLine(history);
        }


        Console.WriteLine("\nPeek at next item to destack: {0}",
            undoHistory.Peek());
        foreach (string history in undoHistory)
        {
            Console.WriteLine(history);
        }

        Console.WriteLine("\nPopping '{0}'", undoHistory.Pop());
        foreach (string history in undoHistory)
        {
            Console.WriteLine(history);
        }
    }

    
}