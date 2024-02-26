namespace dotnet.Models;

public class UserName
{
    private readonly string value;

    public UserName(string value)
    {
        if (value.Length < 3) throw new ArgumentException("only strings with 3 characters or less are allowed.");
        this.value = value ?? throw new ArgumentNullException(nameof(value));
    }

    public override string ToString()
    {
        return this.value;
    }
}