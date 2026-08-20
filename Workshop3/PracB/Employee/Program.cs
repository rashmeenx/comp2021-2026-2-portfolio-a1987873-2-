List<Employee> employees = new List<Employee>();

employees.Add(new FullTimeEmployee("Alice", 80000m));
employees.Add(new Contractor("Bob", 50m, 40m));

foreach (Employee employee in employees)
{
    decimal pay = employee.CalculatePay();

    decimal tax = 0;

    if (employee is FullTimeEmployee fullTimeEmployee)
    {
        tax = fullTimeEmployee.AnnualSalary * Employee.TaxRate;
    }
    else if (employee is Contractor contractor)
    {
        tax = contractor.Rate * contractor.Hours * Employee.TaxRate;
    }

    Console.WriteLine(
        $"{employee.Name}: Pay ${pay:F2}. Tax ${tax:F2}."
    );
}