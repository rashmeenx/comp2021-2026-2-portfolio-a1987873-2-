try
{
    SavingsAccount savings = new SavingsAccount(
        "Rashmeen",
        1500m,
        0.035m
    );

    savings.DisplayAccountInfo();

    Console.WriteLine();

    CheckingAccount checking = new CheckingAccount(
        "Rashmeen",
        1000m,
        5m
    );

    checking.DisplayAccountInfo();
}
catch (ArgumentException exception)
{
    Console.WriteLine(exception.Message);
}
catch (InvalidOperationException exception)
{
    Console.WriteLine(exception.Message);
}