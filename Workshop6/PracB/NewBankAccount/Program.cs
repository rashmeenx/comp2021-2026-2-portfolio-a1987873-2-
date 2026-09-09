using System;
using System.Collections.Generic;
using System.Linq;

class UsingLINQ
{
    public static void Main()
    {
        Stack<BankAccount> bankAccounts = new Stack<BankAccount>();

        bankAccounts.Push(new BankAccount("Zara", 1000));
        bankAccounts.Push(new BankAccount("Aisha", 2000));
        bankAccounts.Push(new BankAccount("Maya", 3000));
        bankAccounts.Push(new BankAccount("Nadia", 4000));
        bankAccounts.Push(new BankAccount("Emma", 5000));
        bankAccounts.Push(new BankAccount("Sofia", 6000));
        bankAccounts.Push(new BankAccount("Olivia", 7000));
        bankAccounts.Push(new BankAccount("Hannah", 8000));
        bankAccounts.Push(new BankAccount("Lina", 9000));
        bankAccounts.Push(new BankAccount("Rashmeen", 10000));

        // Stack
        var stackOwners = bankAccounts
            .Select(x => x.Owner)
            .OrderBy(x => x);

        Console.WriteLine("Stack Owners:");

        foreach (string owner in stackOwners)
        {
            Console.WriteLine(owner);
        }

        // Queue
        Queue<BankAccount> accountQueue = new Queue<BankAccount>(bankAccounts);

        var queueOwners = accountQueue
            .Select(x => x.Owner)
            .OrderBy(x => x);

        Console.WriteLine("\nQueue Owners:");

        foreach (string owner in queueOwners)
        {
            Console.WriteLine(owner);
        }
    }
}