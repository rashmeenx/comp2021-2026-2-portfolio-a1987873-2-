using System;
using System.Collections.Generic;

class UsingStackQueue
{
    public static void Main()
    {
        Stack<BankAccount> bankAccounts = new Stack<BankAccount>();

        bankAccounts.Push(new BankAccount("Owner 1", 1000));
        bankAccounts.Push(new BankAccount("Owner 2", 2000));
        bankAccounts.Push(new BankAccount("Owner 3", 3000));
        bankAccounts.Push(new BankAccount("Owner 4", 4000));
        bankAccounts.Push(new BankAccount("Owner 5", 5000));
        bankAccounts.Push(new BankAccount("Owner 6", 6000));
        bankAccounts.Push(new BankAccount("Owner 7", 7000));
        bankAccounts.Push(new BankAccount("Owner 8", 8000));
        bankAccounts.Push(new BankAccount("Owner 9", 9000));
        bankAccounts.Push(new BankAccount("Owner 10", 10000));

        Console.WriteLine("Stack:");

        foreach (BankAccount account in bankAccounts)
        {
            Console.WriteLine(account);
        }

        Queue<BankAccount> accountQueue = StackToQueue(bankAccounts);
        
        Console.WriteLine("\nQueue:");

        foreach (BankAccount account in accountQueue)
        {
            Console.WriteLine(account);
        }

        Queue<BankAccount> sortedQueue = SortQueue(accountQueue);

        Console.WriteLine("\nSorted Queue:");

        foreach (BankAccount account in sortedQueue)
        {
            Console.WriteLine(account);
        }
    }

    public static Queue<BankAccount> StackToQueue(
        Stack<BankAccount> bankAccounts)
    {
        Queue<BankAccount> accountQueue = new Queue<BankAccount>();

        foreach (BankAccount account in bankAccounts)
        {
            accountQueue.Enqueue(account);
        }

        return accountQueue;
    }

    public static Queue<BankAccount> SortQueue(Queue<BankAccount> bankAccounts)
    {
        List<BankAccount> accountList = new List<BankAccount>(bankAccounts);

        accountList.Sort((a, b) => a.Balance.CompareTo(b.Balance));

        Queue<BankAccount> sortedQueue = new Queue<BankAccount>(accountList);

        return sortedQueue;
    }


}