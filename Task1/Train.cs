namespace Task1;

public class Train : Vehicle
{
    public string TrackType { get; set; }

    public Train(int speed, int capacity, string trackType) : base(speed, capacity)
    {
        TrackType = trackType;
    }

    public override void Move()
    {
        Console.WriteLine($"Потяг рухаєтся зі швидкістю {Speed} км/г по {TrackType} колії разом з {Capacity} пасажирами.");
    }
}
