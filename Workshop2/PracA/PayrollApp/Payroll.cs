public class Payroll
{
    private double hours;
    private decimal rate;
    private decimal taxRate;

    public Payroll(double hours, decimal rate, decimal taxRate)
    {
        if (hours < 0)
        {
            throw new ArgumentException("Hours cannot be negative.");
        }

        if (rate < 0)
        {
            throw new ArgumentException("Rate cannot be negative.");
        }

        if (taxRate < 0 || taxRate > 1)
        {
            throw new ArgumentException(
                "Tax rate must be between 0 and 1."
            );
        }

        this.hours = hours;
        this.rate = rate;
        this.taxRate = taxRate;
    }

    public decimal CalculateNetPay()
    {
        decimal grossPay = (decimal)hours * rate;
        decimal tax = grossPay * taxRate;
        decimal netPay = grossPay - tax;

        return netPay;
    }

    public void ChangeTaxRate(decimal newTaxRate)
    {
        if (newTaxRate < 0 || newTaxRate > 1)
        {
            throw new ArgumentException(
                "Tax rate must be between 0 and 1."
            );
        }

        taxRate = newTaxRate;
    }
}