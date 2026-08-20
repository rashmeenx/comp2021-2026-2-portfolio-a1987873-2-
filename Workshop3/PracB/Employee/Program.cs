FullTimeEmployee fullTimeEmployee =
    new FullTimeEmployee("Alice", 80000m);

Contractor contractor =
    new Contractor("Bob", 50m, 40m);

Console.WriteLine("FULL-TIME EMPLOYEE");
Console.WriteLine(fullTimeEmployee.GenerateReport());
Console.WriteLine(
    $"CalculatePay(): ${fullTimeEmployee.CalculatePay():F2}"
);

Console.WriteLine();

Console.WriteLine("CONTRACTOR");
Console.WriteLine(contractor.GenerateReport());
Console.WriteLine(
    $"CalculatePay(): ${contractor.CalculatePay():F2}"
);