namespace dotnet.Models;

public class UserId
{
    private readonly string value;

    public UserId(string value)
    {
        this.value = value ?? throw new ArgumentNullException(nameof(value));
    }
}