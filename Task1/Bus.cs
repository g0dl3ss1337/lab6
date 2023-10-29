namespace Task1;

public class Bus : Vehicle
{
    public int RouteNumber { get; set; }

    public Bus(int speed, int capacity, int routeNumber) : base(speed, capacity)
    {
        RouteNumber = routeNumber;
    }

    public override void Move()
    {
        Console.WriteLine($"Автобус {RouteNumber} рухаєтся зі швидкістю {Speed} км/г разом з {Capacity} пасажирами.");
    }
}
