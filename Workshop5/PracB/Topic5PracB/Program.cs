using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var numbers = new LinkedList<int>();

        // Adding values
        numbers.AddFirst(10);
        numbers.AddLast(20);
        numbers.AddLast(30);
        numbers.AddLast(40);
        numbers.AddLast(50);
        numbers.AddLast(60);
        numbers.AddLast(70);
        numbers.AddLast(80);

        // AddBefore
        LinkedListNode<int>? node30 = numbers.Find(30);
        if (node30 != null)
        {
            numbers.AddBefore(node30, 25);
        }

        // AddAfter
        LinkedListNode<int>? node50 = numbers.Find(50);
        if (node50 != null)
        {
            numbers.AddAfter(node50, 55);
        }

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\n");


        // Removal methods
        numbers.Remove(20);
        numbers.RemoveFirst();
        numbers.RemoveLast();

        // Removing the 5th element
        LinkedListNode<int>? current = numbers.First;

        for (int i = 1; i < 5 && current != null; i++)
        {
            current = current.Next;
        }

        if (current != null)
        {
            numbers.Remove(current);
        }

        // Print the LinkedList
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}