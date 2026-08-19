using Xunit;

public class SavingsAccountTests
{
    [Fact]
    public void ApplyInterest_IncreasesBalance()
    {
        SavingsAccount account =
            new SavingsAccount("Rashmeen", 1000m, 0.05m);

        account.ApplyInterest();

        Assert.Equal(1050m, account.Balance);
    }

    [Fact]
    public void DisplayAccountInfo_Runs()
    {
        SavingsAccount account =
            new SavingsAccount("Rashmeen", 1000m, 0.05m);

        account.DisplayAccountInfo();
    }
}