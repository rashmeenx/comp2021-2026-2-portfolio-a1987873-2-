using System;
using System.Collections.Generic;

class Example
{
    public static void Main()
    {
        Queue<string> printersJob = new Queue<string>();
        printersJob.Enqueue("Print Job 1");
        printersJob.Enqueue("Print Job 2");
        printersJob.Enqueue("Print Job 3");

        foreach (string job in printersJob)
        {
            Console.WriteLine(job);
        }

        Console.WriteLine("\nDequeuing '{0}'", printersJob.Dequeue());
        foreach (string job in printersJob)
        {
            Console.WriteLine(job);
        }

        Console.WriteLine("\nPeek at next item to dequeue: {0}",
            printersJob.Peek());
        foreach (string job in printersJob)
        {
            Console.WriteLine(job);
        }

        Console.WriteLine("\nDequeuing '{0}'", printersJob.Dequeue());
        foreach (string job in printersJob)
        {
            Console.WriteLine(job);
        }
    }
}
