public class EmployeeTests
{
    [Fact]
    public void FullTimeEmployee_CalculatePay_ReturnsCorrectPayAfterTax()
    {
        FullTimeEmployee employee =
            new FullTimeEmployee("Alice", 80000m);

        decimal result = employee.CalculatePay();

        Assert.Equal(64000m, result);
    }

    [Fact]
    public void Contractor_CalculatePay_ReturnsCorrectPayAfterTax()
    {
        Contractor contractor =
            new Contractor("Bob", 50m, 40m);

        decimal result = contractor.CalculatePay();

        Assert.Equal(1600m, result);
    }

    [Fact]
    public void FullTimeEmployee_GenerateReport_ReturnsCorrectReport()
    {
        FullTimeEmployee employee =
            new FullTimeEmployee("Alice", 80000m);

        string result = employee.GenerateReport();

        Assert.Contains("Alice", result);
        Assert.Contains("80000.00", result);
        Assert.Contains("64000.00", result);
    }

    [Fact]
    public void Contractor_GenerateReport_ReturnsCorrectReport()
    {
        Contractor contractor =
            new Contractor("Bob", 50m, 40m);

        string result = contractor.GenerateReport();

        Assert.Contains("Bob", result);
        Assert.Contains("50.00", result);
        Assert.Contains("40", result);
        Assert.Contains("1600.00", result);
    }

    [Fact]
    public void FullTimeEmployee_Name_ReturnsCorrectName()
    {
        FullTimeEmployee employee =
            new FullTimeEmployee("Alice", 80000m);

        Assert.Equal("Alice", employee.Name);
    }

    [Fact]
    public void FullTimeEmployee_AnnualSalary_ReturnsCorrectSalary()
    {
        FullTimeEmployee employee =
            new FullTimeEmployee("Alice", 80000m);

        Assert.Equal(80000m, employee.AnnualSalary);
    }

    [Fact]
    public void Contractor_Rate_ReturnsCorrectRate()
    {
        Contractor contractor =
            new Contractor("Bob", 50m, 40m);

        Assert.Equal(50m, contractor.Rate);
    }

    [Fact]
    public void Contractor_Hours_ReturnsCorrectHours()
    {
        Contractor contractor =
            new Contractor("Bob", 50m, 40m);

        Assert.Equal(40m, contractor.Hours);
    }

    [Fact]
    public void TaxRate_IsTwentyPercent()
    {
        Assert.Equal(0.2m, Employee.TaxRate);
    }
    
}