namespace External.Assembly;

public sealed class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FullName { get; set; } // NO + FullName

    public const string Surname = "AAA";
    
    public int Age { get; set; }

    public static bool operator ==(User a, User b)
    {
        return true;
    }

    public static bool operator !=(User a, User b)
    {
        return !(a == b);
    }
}