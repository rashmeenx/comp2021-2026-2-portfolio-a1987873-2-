public class CheckingAccount : BankAccount
{
    public decimal TransactionFee { get; set; }

    public CheckingAccount(
        string owner,
        decimal balance,
        decimal transactionFee
    ) : base(owner, balance)
    {
        TransactionFee = transactionFee;
    }

    public override void Withdraw(decimal amount)
    {
        decimal totalAmount = amount + TransactionFee;

        if (amount <= 0)
        {
            throw new ArgumentException(
                "Withdrawal amount must be greater than zero."
            );
        }

        if (totalAmount > Balance)
        {
            throw new InvalidOperationException(
                "Insufficient balance."
            );
        }

        Balance -= totalAmount;
    }

    public override void DisplayAccountInfo()
    {
        Console.WriteLine("Account: CheckingAccount");

        base.DisplayAccountInfo();

        Console.WriteLine(
            $"Transaction fee: ${TransactionFee:F2}"
        );
    }
}