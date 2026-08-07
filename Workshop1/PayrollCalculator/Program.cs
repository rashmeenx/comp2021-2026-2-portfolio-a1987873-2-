const double TAX_RATE = 0.20;

static double CalculatePay(double hours, double rate)
{
    if (hours < 0 || rate < 0)
    {
        throw new ArgumentException(
            "Hours and rate must be positive."
        );
    }

    double gross = hours * rate;
    double tax = gross * TAX_RATE;
    double net = gross - tax;

    return net;
}

try
{
    Console.Write("Enter employee name: ");
    string name = Console.ReadLine() ?? "";

    Console.Write("Hours worked: ");
    double hours = double.Parse(Console.ReadLine() ?? "");

    Console.Write("Hourly rate: ");
    double rate = double.Parse(Console.ReadLine() ?? "");

    double netPay = CalculatePay(hours, rate);

    Console.WriteLine(
        $"{name} earned ${netPay:F2} after tax."
    );
}
catch (FormatException)
{
    Console.WriteLine(
        "Invalid input. Please enter numbers for hours and rate."
    );
}
catch (ArgumentException exception)
{
    Console.WriteLine(exception.Message);
}
Console.WriteLine();
Console.WriteLine("Person demonstration");

try
{
    Person person = new Person(
        "Rashmeen",
        "Islam",
        20
    );

    Console.WriteLine($"First name: {person.FirstName}");
    Console.WriteLine($"Last name: {person.LastName}");
    Console.WriteLine($"Age: {person.Age}");

    Console.WriteLine($"Full name: {person.FullName()}");
    Console.WriteLine($"Is adult: {person.IsAdult()}");
}
catch (ArgumentException exception)
{
    Console.WriteLine(exception.Message);
}