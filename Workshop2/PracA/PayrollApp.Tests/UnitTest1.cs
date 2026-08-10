public class PayrollTests
{
    [Fact]
    public void CalculateNetPay_ReturnsCorrectAmount()
    {
        Payroll payroll = new Payroll(40, 20m, 0.20m);

        decimal result = payroll.CalculateNetPay();

        Assert.Equal(640m, result);
    }

    [Fact]
    public void ChangeTaxRate_UpdatesTaxRate()
    {
        Payroll payroll = new Payroll(40, 20m, 0.20m);

        payroll.ChangeTaxRate(0.25m);

        Assert.Equal(0.25m, payroll.TaxRate);
    }

    [Fact]
    public void Hours_ThrowsException_WhenNegative()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            new Payroll(-1, 20m, 0.20m);
        });
    }

    [Fact]
    public void Rate_ThrowsException_WhenNegative()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            new Payroll(40, -1m, 0.20m);
        });
    }

    [Fact]
    public void TaxRate_ThrowsException_WhenNegative()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            new Payroll(40, 20m, -0.10m);
        });
    }

    [Fact]
    public void TaxRate_ThrowsException_WhenGreaterThanOne()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            new Payroll(40, 20m, 1.10m);
        });
    }

    [Fact]
    public void Hours_CanBeUpdated_WhenValid()
    {
        Payroll payroll = new Payroll(40, 20m, 0.20m);

        payroll.Hours = 35;

        Assert.Equal(35, payroll.Hours);
    }

    [Fact]
    public void Rate_CanBeUpdated_WhenValid()
    {
        Payroll payroll = new Payroll(40, 20m, 0.20m);

        payroll.Rate = 25m;

        Assert.Equal(25m, payroll.Rate);
    }

    [Fact]
    public void TaxRate_CanBeUpdated_WhenValid()
    {
        Payroll payroll = new Payroll(40, 20m, 0.20m);

        payroll.TaxRate = 0.15m;

        Assert.Equal(0.15m, payroll.TaxRate);
    }
}