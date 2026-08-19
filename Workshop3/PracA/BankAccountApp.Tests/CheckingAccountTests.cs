using Xunit;

public class CheckingAccountTests
{
    [Fact]
    public void ValidWithdrawal_DeductsAmountAndFee()
    {
        CheckingAccount account =
            new CheckingAccount("Rashmeen", 500m, 5m);

        account.Withdraw(100m);

        Assert.Equal(395m, account.Balance);
    }

    [Fact]
    public void InvalidWithdrawal_ThrowsException()
    {
        CheckingAccount account =
            new CheckingAccount("Rashmeen", 500m, 5m);

        Assert.Throws<ArgumentException>(() =>
            account.Withdraw(0m)
        );
    }

    [Fact]
    public void WithdrawalAboveBalanceIncludingFee_ThrowsException()
    {
        CheckingAccount account =
            new CheckingAccount("Rashmeen", 100m, 5m);

        Assert.Throws<InvalidOperationException>(() =>
            account.Withdraw(100m)
        );
    }

    [Fact]
    public void DisplayAccountInfo_Runs()
    {
        CheckingAccount account =
            new CheckingAccount("Rashmeen", 500m, 5m);

        account.DisplayAccountInfo();
    }
}