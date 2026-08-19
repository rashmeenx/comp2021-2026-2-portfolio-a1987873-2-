using Xunit;

public class BankAccountTests
{
    [Fact]
    public void DecimalDeposit_IncreasesBalance()
    {
        BankAccount account = new BankAccount("Rashmeen", 500m);

        account.Deposit(100.50m);

        Assert.Equal(600.50m, account.Balance);
    }

    [Fact]
    public void IntDeposit_IncreasesBalance()
    {
        BankAccount account = new BankAccount("Rashmeen", 500m);

        account.Deposit(50);

        Assert.Equal(550m, account.Balance);
    }

    [Fact]
    public void DoubleDeposit_IncreasesBalance()
    {
        BankAccount account = new BankAccount("Rashmeen", 500m);

        account.Deposit(25.75);

        Assert.Equal(525.75m, account.Balance);
    }

    [Fact]
    public void InvalidDeposit_ThrowsException()
    {
        BankAccount account = new BankAccount("Rashmeen", 500m);

        Assert.Throws<ArgumentException>(() =>
            account.Deposit(0m)
        );
    }

    [Fact]
    public void ValidWithdrawal_DecreasesBalance()
    {
        BankAccount account = new BankAccount("Rashmeen", 500m);

        account.Withdraw(100m);

        Assert.Equal(400m, account.Balance);
    }

    [Fact]
    public void InvalidWithdrawal_ThrowsException()
    {
        BankAccount account = new BankAccount("Rashmeen", 500m);

        Assert.Throws<ArgumentException>(() =>
            account.Withdraw(0m)
        );
    }

    [Fact]
    public void WithdrawalAboveBalance_ThrowsException()
    {
        BankAccount account = new BankAccount("Rashmeen", 500m);

        Assert.Throws<InvalidOperationException>(() =>
            account.Withdraw(600m)
        );
    }

    [Fact]
    public void DisplayAccountInfo_Runs()
    {
        BankAccount account = new BankAccount("Rashmeen", 500m);

        account.DisplayAccountInfo();
    }
}