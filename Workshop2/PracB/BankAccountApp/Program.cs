try
{
    BankAccount account = new BankAccount("Rashmeen", 500m);

    Console.WriteLine($"Owner: {account.Owner}");
    Console.WriteLine($"Starting balance: ${account.Balance:F2}");

    account.Deposit(200m);
    Console.WriteLine($"After depositing $200: ${account.Balance:F2}");

    account.Withdraw(100m);
    Console.WriteLine($"After withdrawing $100: ${account.Balance:F2}");

    account.Withdraw(1000m);
}
catch (ArgumentException exception)
{
    Console.WriteLine(exception.Message);
}
catch (InvalidOperationException exception)
{
    Console.WriteLine(exception.Message);
}