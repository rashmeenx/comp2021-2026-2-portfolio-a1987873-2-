try
{
    BankAccount account = new BankAccount("Rashmeen", 500m);

    decimal decimalAmount = 100.50m;
    int intAmount = 50;
    double doubleAmount = 25.75;

    account.Deposit(decimalAmount);
    Console.WriteLine(
        $"After decimal deposit: ${account.Balance:F2}"
    );

    account.Deposit(intAmount);
    Console.WriteLine(
        $"After int deposit: ${account.Balance:F2}"
    );

    account.Deposit(doubleAmount);
    Console.WriteLine(
        $"After double deposit: ${account.Balance:F2}"
    );
}
catch (ArgumentException exception)
{
    Console.WriteLine(exception.Message);
}
catch (InvalidOperationException exception)
{
    Console.WriteLine(exception.Message);
}