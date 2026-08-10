public class PersonTests
{
    [Fact]
    public void FullName_ReturnsExpectedFormat()
    {
        Person person = new Person("Rashmeen", "Islam", 20);

        string result = person.FullName();

        Assert.Equal("Islam, Rashmeen", result);
    }

    [Fact]
    public void IsAdult_ReturnsTrue_WhenAge18OrMore()
    {
        Person person = new Person("Rashmeen", "Islam", 20);

        bool result = person.IsAdult();

        Assert.True(result);
    }
}