try
{
    SavingsAccount savings = new SavingsAccount(
        "Rashmeen",
        500m,
        0.05m
    );

    Console.WriteLine($"Savings account starting balance: ${savings.Balance:F2}");

    savings.Deposit(100m);
    Console.WriteLine($"After deposit: ${savings.Balance:F2}");

    savings.ApplyInterest();
    Console.WriteLine($"After interest: ${savings.Balance:F2}");


    Console.WriteLine();


    CheckingAccount checking = new CheckingAccount(
        "Rashmeen",
        500m,
        5m
    );

    Console.WriteLine($"Checking account starting balance: ${checking.Balance:F2}");

    checking.Deposit(100m);
    Console.WriteLine($"After deposit: ${checking.Balance:F2}");

    checking.Withdraw(50m);
    Console.WriteLine($"After $50 withdrawal with fee: ${checking.Balance:F2}");
}
catch (ArgumentException exception)
{
    Console.WriteLine(exception.Message);
}
catch (InvalidOperationException exception)
{
    Console.WriteLine(exception.Message);
}