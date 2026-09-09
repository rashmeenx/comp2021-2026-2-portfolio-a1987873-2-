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

        Queue<BankAccount> accountQueue = new Queue<BankAccount>(bankAccounts);

        // Stack
        var stackResults = bankAccounts
            .Where(x => x.Owner.Contains("e"))
            .Select(x => new { x.Owner, x.Balance })
            .OrderBy(x => x.Balance);

        Console.WriteLine("Stack Results:");

        foreach (var account in stackResults)
        {
            Console.WriteLine($"{account.Owner}: {account.Balance}");
        }

        // Queue
        var queueResults = accountQueue
            .Where(x => x.Owner.Contains("e"))
            .Select(x => new { x.Owner, x.Balance })
            .OrderBy(x => x.Balance);

        Console.WriteLine("\nQueue Results:");

        foreach (var account in queueResults)
        {
            Console.WriteLine($"{account.Owner}: {account.Balance}");
        }
    }
}