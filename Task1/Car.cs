namespace Task1;

public class Car : Vehicle
{
    public string FuelType { get; set; }

    public Car(int speed, int capacity, string fuelType) : base(speed, capacity)
    {
        FuelType = fuelType;
    }

    public override void Move()
    {
        Console.WriteLine($"Авто рухаєтся зі швидкістю {Speed} км/г використовуючи: {FuelType}.");
    }

}
