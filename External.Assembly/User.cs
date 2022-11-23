namespace External.Assembly;

public sealed class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FullName { get; set; }
    public int Age { get; set; }

    public IEnumerable<Reservation> Reservations = new[]
    {
        new Reservation(),
        new Reservation(),
        new Reservation(),
        new Reservation(),
        new Reservation(),
    };
}

public class Reservation
{
    public Guid Id { get; set; } = new();
}