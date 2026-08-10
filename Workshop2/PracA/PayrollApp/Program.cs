try
{
    Console.Write("Hours worked: ");
    double hours = double.Parse(Console.ReadLine() ?? "");

    Console.Write("Hourly rate: ");
    decimal rate = decimal.Parse(Console.ReadLine() ?? "");

    Payroll payroll = new Payroll(hours, rate, 0.20m);

    decimal netPay = payroll.CalculateNetPay();

    Console.WriteLine($"Net pay: ${netPay:F2}");

    payroll.ChangeTaxRate(0.25m);

    decimal newNetPay = payroll.CalculateNetPay();

    Console.WriteLine(
        $"Net pay after tax rate change: ${newNetPay:F2}"
    );
}
catch (FormatException)
{
    Console.WriteLine("Please enter valid numbers.");
}
catch (ArgumentException exception)
{
    Console.WriteLine(exception.Message);
}